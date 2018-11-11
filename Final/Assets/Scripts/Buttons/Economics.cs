using UnityEngine.SceneManagement;
using UnityEngine;

public class Economics : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 12);
    }
}
