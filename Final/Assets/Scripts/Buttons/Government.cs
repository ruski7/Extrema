using UnityEngine.SceneManagement;
using UnityEngine;

public class Government : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 11);
    }
}
