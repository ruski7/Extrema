using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEController : MonoBehaviour {

    public float speed;

    public float lifeTime;

    public int damageToGive;

    


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
            Destroy(gameObject);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "Enemy")
        {
            //Physics.IgnoreCollision(this.gameObject.GetComponent<Collider>, Collider.);
        }
    }
}
