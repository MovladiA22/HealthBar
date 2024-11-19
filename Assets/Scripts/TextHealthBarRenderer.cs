using TMPro;
using UnityEngine;

public class TextHealthBarRenderer : HealthBarRenderer
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void Render() =>
        _text.text = _health.Value + "/" + _health.MaxValue;
}
