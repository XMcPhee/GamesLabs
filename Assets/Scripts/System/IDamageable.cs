using System.Diagnostics;
using System.Runtime;
using UnityEngine;

public struct DamageInfo
{
  public float Amount;
  public GameObject Source;
  public DamageInfo(float amount, GameObject source = null) {
    Amount = Mathf.Max(0f, amount);  // clamp to non‑negative
    Source = source;                 // store source
  }
}

public interface IDamageable
{
  float CurrentHealth { get; }
  float MaxHealth { get; }
  void ApplyDamage(DamageInfo info);
  void ApplyHeal(float amount);
}
