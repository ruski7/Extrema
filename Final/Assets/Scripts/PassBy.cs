using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassBy : MonoBehaviour
{

	
	
    //function OnCollisionEnter(bullet : Collision){  }

	// Update is called once per frame
	void OnCollisionEnter(Collision other)
    {   

        if (other.gameObject.tag == "Enemy")
        {
            //Physics.IgnoreCollision;
        }
    }
		
}
