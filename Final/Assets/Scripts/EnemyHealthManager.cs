using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int health = 1;
    private int currentHealth;
    public bool infiniteHP;
    

	// Use this for initialization
	void Start () {
        currentHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            GameObject manage = GameObject.Find("Manager");
            Manager script = manage.GetComponent<Manager>();
            script.enemyleft -= 1;
            
        }
            
	}

    public void HurtEnemy(int damage)
    {
        if (infiniteHP == false)
        {
            currentHealth -= damage;
        }
        else{
            health = 69;
        }
    }
}
