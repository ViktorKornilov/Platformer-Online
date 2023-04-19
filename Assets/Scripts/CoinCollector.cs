using TMPro;
using UnityEngine;

// made by Karolis

public class CoinCollector : MonoBehaviour
{

    public TMP_Text coinsText;
    public float coinsCount = 0;
    public GameObject teleporter;
    public int coinsToTeleport = 3;
    
    void Update()
    {
        coinsText.text = coinsCount.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coinsCount++;
            
            if (coinsCount >= coinsToTeleport)
            {
                teleporter.SetActive(true);
            }
            
            Destroy(collision.gameObject);
        }
    }
}
