using UnityEngine;
using UnityEngine.UI;

public class SliderHealthBarRenderer : HealthBarRenderer
{
    [SerializeField] private Slider _slider;

    protected override void Render() =>
        _slider.value = (float)_health.Value / _health.MaxValue;
}
