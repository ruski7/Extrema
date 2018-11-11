using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour {

    public Transform[] MovePoints;
    public float Speed;
    public int curWaypoint;
    public bool Patrol = true;
    public Vector3 Target;
    public Vector3 MoveDirection;
    public Vector3 Velocity;

    void FixedUpdate()
    {
        if (curWaypoint < MovePoints.Length)
        {
            Target = MovePoints[curWaypoint].position;
            MoveDirection = Target - transform.position;
            Velocity = GetComponent<Rigidbody>().velocity;

            if (MoveDirection.magnitude < 1)
            {
                curWaypoint++;
            }

            else
            {
                Velocity = MoveDirection.normalized * Speed;
            }
        }
        else
        {
            if(Patrol)
            {
                curWaypoint = 0;
            }

            else
            {
                Velocity = Vector3.zero;
            }
        }
        GetComponent<Rigidbody>().velocity = Velocity;
        {
            transform.Rotate(new Vector3(0, 300, 0) * Time.deltaTime);
        }
    }
}
