using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBarRenderer : HealthBarRenderer
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _delay;

    private Coroutine _coroutine;

    protected override void Render()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(RenderingSmooth());
    }

    private IEnumerator RenderingSmooth()
    {
        var wait = new WaitForEndOfFrame();
        float currentHealth = (float)Health.Value / Health.MaxValue;

        while (_slider.value != currentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, currentHealth, _delay);
            yield return wait;
        }
    }
}
