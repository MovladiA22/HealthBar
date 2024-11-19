using UnityEngine;
using UnityEngine.UI;

public class SliderHealthBarRenderer : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;

    private void Awake()
    {
        _slider.maxValue = _health.MaxValue;
        _slider.wholeNumbers = true;
    }

    private void Update()
    {
        Render();
    }

    private void Render() =>
        _slider.value = _health.Value;
}
