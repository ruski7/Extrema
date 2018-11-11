using UnityEngine.SceneManagement;
using UnityEngine;

public class History : MonoBehaviour
{

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(8);
    }
}
