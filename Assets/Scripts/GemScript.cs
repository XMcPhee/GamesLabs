using UnityEngine;
using TMPro;

public class GemScript : MonoBehaviour
{
    public TextMeshProUGUI gemUI;
    public HumanMovement player;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            player.gemCount += 1;
            gemUI.text = "Gem Count: " + player.gemCount.ToString();
        }
    }
}
