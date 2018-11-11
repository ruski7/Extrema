using UnityEngine.SceneManagement;
using UnityEngine;

public class Education : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }
}
