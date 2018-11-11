using UnityEngine.SceneManagement;
using UnityEngine;

public class Religion : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 13);
    }
}
