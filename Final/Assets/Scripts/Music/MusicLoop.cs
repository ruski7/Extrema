using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicLoop : MonoBehaviour {

   void Update()
    {
    if(SceneManager.GetActiveScene().buildIndex == 6)
        {
            Destroy(this.gameObject);
        }
    }

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }
}
