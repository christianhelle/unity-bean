using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    [SerializeField] float speed = 1f;
    int currentWaypointIndex = 0;

    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }

        transform.position = Vector3.MoveTowards(
            transform.position,
             waypoints[currentWaypointIndex].transform.position,
             speed * Time.deltaTime);
    }
}
