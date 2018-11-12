using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float Testspeed;

    public float lifeTime;

    public float damageToGive;

    public float HitRemovalTime;

	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Testspeed * Time.deltaTime);

        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
            Destroy(gameObject);
	}

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
            Invoke("Remove", HitRemovalTime);
        }

        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

    void Remove()
    {
        Destroy(gameObject);
    }
}
