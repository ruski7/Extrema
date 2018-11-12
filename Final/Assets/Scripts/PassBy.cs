using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassBy : MonoBehaviour
{
    public object Enemy;



    //function OnCollisionEnter(bullet : Collision){  }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {   

        if (other.gameObject.tag == "Enemy")
        {
            //Physics.IgnoreCollision(Enemy.collider, collider);
        }
    }
		
}
