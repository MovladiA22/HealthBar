using UnityEngine;

public class HealthTaker : HealthChanger
{
    [SerializeField] private int _damageValue;

    protected override void Change() =>
        Health.Lost(_damageValue);
}
