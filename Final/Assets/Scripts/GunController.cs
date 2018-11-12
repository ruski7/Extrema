using UnityEngine;

public class GunController : MonoBehaviour {

    public bool isFiring;

    public BulletController bullet;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;

    AudioSource bulletAudio;


	// Use this for initialization
	void Start () {
        bulletAudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if(isFiring)
        {
            shotCounter -= Time.deltaTime;
            if(shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
                BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
                newBullet.Testspeed = bulletSpeed;
                bulletAudio.Play();
            }
        }
        else
        {
            shotCounter = 0;
        }
	}
}
