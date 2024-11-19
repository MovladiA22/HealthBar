using UnityEngine;

public class HealthReplenisher : HealthChanger
{
    [SerializeField] private int _healthValue;

    protected override void Change() =>
        _health.Replenish(_healthValue);
}
