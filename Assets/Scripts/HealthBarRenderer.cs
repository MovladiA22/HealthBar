using UnityEngine;

public class HealthBarRenderer : MonoBehaviour
{
    [SerializeField] protected Health Health;

    private void Awake()
    {
        Render();
    }

    private void OnEnable()
    {
        Health.Changed += Render;
    }

    private void OnDisable()
    {
        Health.Changed -= Render;
    }

    protected virtual void Render() { }
}
