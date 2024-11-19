using TMPro;
using UnityEngine;

public class TextHealthBarRenderer : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private TextMeshProUGUI _text;

    private void Update()
    {
        Render();
    }

    private void Render() =>
        _text.text = _health.Value + "/" + _health.MaxValue;
}
