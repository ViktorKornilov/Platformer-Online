using TMPro;
using UnityEngine;

// made by Karolis

public class CoinCollector : MonoBehaviour
{

    public TMP_Text coinsText;

    public float coinsCount = 0;

    void Update()
    {
        coinsText.text = coinsCount.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coinsCount += 1;
            Destroy(collision.gameObject);
        }
    }
}
