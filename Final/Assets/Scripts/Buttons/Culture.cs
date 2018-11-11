using UnityEngine.SceneManagement;
using UnityEngine;

public class Culture : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }
}
