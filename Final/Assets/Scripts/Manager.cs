using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    public float restartDelay = 2f;
    bool gameHasEnded = false;

    GameObject[] Enemy;
    public int enemyleft;

    void Start()
    {
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        enemyleft = Enemy.Length;
    }

    void Update()
    {
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        enemyleft = Enemy.Length;
        if (enemyleft == 0)
        {
            if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                Invoke("FINALLYDONE", 2f);
            }
            else{
                Invoke("FINALLYDONE", 3f);
            }
        }
    }

    void FINALLYDONE()
    {
        CompleteLevel();
    }

    public void CompleteLevel ()
    {
            Debug.Log("LEVEL WON!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

	public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAMEOVER");
            Invoke("Restart", restartDelay);
        }
    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
