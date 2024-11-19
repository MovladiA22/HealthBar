using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBarRenderer : HealthBarRenderer
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _delay;

    protected override void Render() =>
        StartCoroutine(SmoothRender());

    private IEnumerator SmoothRender()
    {
        var wait = new WaitForEndOfFrame();
        float currentHealth = (float)_health.Value / _health.MaxValue;

        while (_slider.value != currentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, currentHealth, _delay);
            yield return wait;
        }
    }
}
