using UnityEngine;

public class Path : MonoBehaviour
{
    public Vector3[] Waypoints { get; private set; }

    // Awake is called when the script instance is loaded
    void Awake()
    {
        Waypoints = new Vector3[transform.childCount];
        for (int i = 0; i < Waypoints.Length; i++)
        {
            Waypoints[i] = transform.GetChild(i).position;
        }
    }

    void OnDrawGizmos()
    {
        if (Waypoints == null) return;

        for (int i = 1; i < Waypoints.Length; i++)
        {
            Gizmos.DrawLine(Waypoints[i - 1], Waypoints[i]);
        }
    }
}
