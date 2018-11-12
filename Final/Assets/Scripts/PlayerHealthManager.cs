using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {

    public int startHealth;
    public int currentHealth;

    public float flashLength;
    public float flashCounter;

    private Renderer rend;
    private Color storedColor;

	// Use this for initialization
	void Start () {
        currentHealth = startHealth;
        rend = GetComponentInChildren<Renderer>();
        storedColor = rend.material.GetColor("_Color");
	}
	
	// Update is called once per frame
	void Update () {
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            FindObjectOfType<Manager>().EndGame();

<<<<<<< HEAD

            //FindObjectOfType<EViewMech>().StopMovement();



            FindObjectOfType<EViewMech>().stopMovement();
=======
            FindObjectOfType<EViewMech>().StopMovement();

            //FindObjectOfType<EViewMech>().stopMovement();
>>>>>>> ae16aa3769ed3997ed7d7d75f628e0c9271e0a05

        }

        if (flashCounter > 0)
        {
            flashCounter -= Time.deltaTime;
            if(flashCounter <= 0)
            {
                rend.material.SetColor("_Color", storedColor);
            }
        }
	}

    public void HurtPlayer(int damageAmount)
    {
        currentHealth -= damageAmount;
        flashCounter = flashLength;
        rend.material.SetColor("_Color", Color.red);
    }
}
