using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicLoops : MonoBehaviour
{

    void Awake()
    {
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Music1");
            if (objs.Length > 1)
                Destroy(this.gameObject);
         
             DontDestroyOnLoad(this.gameObject);
         
        
    }
}
