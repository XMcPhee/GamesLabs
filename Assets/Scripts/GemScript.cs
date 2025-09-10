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
            gameObject.SetActive(false);
            var hp = other.GetComponentInChildren<Health>();
            hp.ApplyDamage(new DamageInfo(5, gameObject));
            player.gemCount += 1;
            gemUI.text = "Gem Count: " + player.gemCount.ToString();
        }
    }
}
