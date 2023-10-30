using UnityEngine;
using TMPro;

[ExecuteAlways]
public class CoordinateLabel : MonoBehaviour
{
    private TextMeshPro _label;
    private Vector2Int _coordinates = new();

    private void Awake()
    {
        _label = GetComponent<TextMeshPro>();
    }

    private void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
        }
    }

    private void DisplayCoordinates()
    {
        var parentPosition = transform.parent.position;

        _coordinates.x = Mathf.RoundToInt(parentPosition.x);
        _coordinates.y = Mathf.RoundToInt(parentPosition.z);

        _label.text = _coordinates.x + "," + _coordinates.y;
    }
}