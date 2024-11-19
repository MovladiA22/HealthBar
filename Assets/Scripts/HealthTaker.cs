using UnityEngine;
using UnityEngine.UI;

public class HealthTaker : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _button;
    [SerializeField] private int _damageValue;

    private void OnEnable()
    {
        _button.onClick.AddListener(Take);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Take);
    }

    private void Take() =>
        _health.Lost(_damageValue);
}
