using UnityEngine;

public class HealthTaker : HealthChanger
{
    [SerializeField] private int _damageValue;

    protected override void Change() =>
        _health.Lost(_damageValue);
}
