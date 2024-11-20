using UnityEngine;
using UnityEngine.UI;

public class SliderHealthBarRenderer : HealthBarRenderer
{
    [SerializeField] private Slider _slider;

    protected override void Render() =>
        _slider.value = (float)Health.Value / Health.MaxValue;
}
