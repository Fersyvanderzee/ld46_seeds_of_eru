using UnityEngine;
using UnityEngine.SceneManagement;

public class endRestart : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
