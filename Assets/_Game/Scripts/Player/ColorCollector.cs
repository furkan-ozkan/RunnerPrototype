using UnityEngine;

public class ColorCollector : MonoBehaviour
{
    [SerializeField] private Material _material;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CollectableColor>())
        {
            if (other.GetComponent<Red>())
            {
                _material.color = Color.Lerp(_material.color, Color.red, 0.4f);
                _material.SetColor("_EmissionColor", Color.Lerp(_material.color, Color.red, 0.4f));
            }
            else if (other.GetComponent<Green>())
            {
                _material.color = Color.Lerp(_material.color, Color.green, 0.4f);
                _material.SetColor("_EmissionColor", Color.Lerp(_material.color, Color.green, 0.4f));
            }
            else if (other.GetComponent<Blue>())
            {
                _material.color = Color.Lerp(_material.color, Color.blue, 0.4f);
                _material.SetColor("_EmissionColor", Color.Lerp(_material.color, Color.blue, 0.4f));
            }
            // Play Color Change Anim or change state etc...
        }
    }
}
