using UnityEngine;

public static class InputProvider {
  public delegate void HasMove(Vector3 direction);
  public static event HasMove OnHasMove;

  public delegate void HasShoot();
  public static event HasShoot OnHasShoot;

  public delegate void HasShootSpecial();
  public static event HasShootSpecial OnHasShootSpecial;

  public delegate void HasDamage(float damage);
  public static event HasDamage OnHasDamage;

  public delegate void HasLevelUp();
  public static event HasLevelUp OnHasLevelUp;


  public static void TriggerOnHasMove(Vector3 direction) {
    OnHasMove?.Invoke(direction);
  }

  public static void TriggerOnHasShoot() {
    OnHasShoot?.Invoke();
  }

  public static void TriggerOnHasShootSpecial() {
    OnHasShootSpecial?.Invoke();
  }

  public static void TriggerOnHasDamage(float damage) {
    OnHasDamage?.Invoke(damage);
  }

  public static void TriggerOnHasLevelUp() {
    OnHasLevelUp?.Invoke();
  }
}