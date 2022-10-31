using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuRtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    public void ChangeScene2()
    {
        SceneManager.LoadScene("Math", LoadSceneMode.Single);
    }
    public void ChangeScene3()
    {
        SceneManager.LoadScene("Physics", LoadSceneMode.Single);
    }
    public void ChangeScene4()
    {
        SceneManager.LoadScene("LevelsMath", LoadSceneMode.Single);
    }
    public void ChangeScene5()
    {
        SceneManager.LoadScene("Recall", LoadSceneMode.Single);
    }
    public void ChangeScene6()
    {
        SceneManager.LoadScene("Level1Recall", LoadSceneMode.Single);
    }
}
