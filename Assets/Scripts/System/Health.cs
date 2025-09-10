using UnityEngine;

public class Health : MonoBehaviour, IDamageable, IEnvironmentDamage
{
    [SerializeField] private float maxHealth = 100f;

    public float MaxHealth => maxHealth;
    public float CurrentHealth { get; private set; }

    private void Awake() {
        CurrentHealth = maxHealth;
    }

    public void ApplyDamage(DamageInfo info)
    {
        Debug.Log($"Applying Damage {info.Amount}");
    }
    public void ApplyHeal(float amount) {}
}
