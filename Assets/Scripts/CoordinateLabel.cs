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
        
        DisplayCoordinates();
    }

    private void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateObjectName();
        }
    }

    private void DisplayCoordinates()
    {
        var parentPosition = transform.parent.position;
        var snapMove=UnityEditor.EditorSnapSettings.move;

        _coordinates.x = Mathf.RoundToInt(parentPosition.x/snapMove.x); //snapMove=10 in IncrementSnapping
        _coordinates.y = Mathf.RoundToInt(parentPosition.z/snapMove.z);

        _label.text = _coordinates.x + "," + _coordinates.y;
    }

    private void UpdateObjectName()
    {
        transform.parent.name = _coordinates.ToString();
    }
}