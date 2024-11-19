using UnityEngine;
using UnityEngine.UI;

public class HealthReplenisher : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _button;
    [SerializeField] private int _healthValue;

    private void OnEnable()
    {
        _button.onClick.AddListener(Replenish);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Replenish);
    }

    private void Replenish() =>
        _health.Replenish(_healthValue);
}
