using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBarRenderer : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _delay;

    private void Awake()
    {
        _slider.maxValue = _health.MaxValue;
        _slider.wholeNumbers = false;
        _slider.value = _health.Value;
    }

    private void Update()
    {
        Render();
    }

    private void Render() =>
        _slider.value = Mathf.MoveTowards(_slider.value, _health.Value, _delay);
}
