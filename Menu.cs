using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public float menuWaitTime = 2f;

    private GameObject eyesNormal;
    private GameObject eyesHappy;
    public Animator playerAnimator;

    void Start()
    {
        eyesNormal = GameObject.Find("Player_controller/SARA/Screen_normal");
        eyesHappy = GameObject.Find("Player_controller/SARA/Screen_happy");
    }

    public void StartButtonClick()
    {
        eyesNormal.transform.gameObject.SetActive(false);
        eyesHappy.transform.gameObject.SetActive(true);
        playerAnimator.enabled = false;
        Invoke("StartGame", menuWaitTime);
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Application ended!");
        Application.Quit();
    }
}
