using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public float Size;
    public TileSO TileData;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.matrix = transform.localToWorldMatrix;

        Gizmos.DrawLine(transform.position, Vector3.up);

        for (int i = 0; i < 6; i++)
        {
            var corner = GetCorner(transform.position, Size, i);
            Gizmos.DrawLine(corner, corner + Vector3.up);
        }
    }

    Vector3 GetCorner(Vector3 center, float size, int i)
    {
        var angle_deg = 60 * i - 30;
        var angle_rad = Mathf.PI / 180 * angle_deg;

        return new Vector3(center.x + size * Mathf.Cos(angle_rad), center.y, center.z + size * Mathf.Sin(angle_rad));
    }
}
