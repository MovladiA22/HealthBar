using UnityEngine;

public class HealthBarRenderer : MonoBehaviour
{
    [SerializeField] protected Health _health;

    private void Awake()
    {
        Render();
    }

    private void OnEnable()
    {
        _health.Changed += Render;
    }

    private void OnDisable()
    {
        _health.Changed -= Render;
    }

    protected virtual void Render() { }
}
