using UnityEngine;

public class EViewMech : MonoBehaviour {

    public float turnSpeed = 1f;

    private Rigidbody myRB;
    public float moveSpeed;
    public Transform Player;


    // Use this for initialization
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        myRB.velocity = (transform.forward * moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 targetLookAtPoint = Player.position - transform.position;

        targetLookAtPoint = new Vector3(targetLookAtPoint.x, 0.0f, targetLookAtPoint.z);

        targetLookAtPoint.Normalize();

        targetLookAtPoint = Vector3.Slerp(transform.forward, targetLookAtPoint, Time.deltaTime * turnSpeed);

        targetLookAtPoint += transform.position;
        transform.LookAt(targetLookAtPoint);
        
        
    }

    public void StopMovement()
    {
        moveSpeed = 0;
        
    }
}
