using UnityEngine;

public class Wavepointfollower : MonoBehaviour
{
    [SerializeField] GameObject[] Waypoints;
    int currentWayPointIndex = 0;

    [SerializeField] public float Speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Waypoints[currentWayPointIndex].transform.position) < .1f)
        {
            currentWayPointIndex++;
            if (currentWayPointIndex >= Waypoints.Length)
                currentWayPointIndex = 0;
        }
        
        transform.position = Vector3.MoveTowards(transform.position, Waypoints[currentWayPointIndex].transform.position, Speed * Time.deltaTime);
    }
}
