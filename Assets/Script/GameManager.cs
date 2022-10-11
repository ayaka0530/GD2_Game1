using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int hatCount;
    public Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
        hatCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    public void AddHatCount()
    {
        hatCount = hatCount + 1;
        Debug.Log("HatCount:" + hatCount);
        textComponent.text = "HatCount : " + hatCount;
    }

    //å∏ÇÁÇ∑ä÷êî
    public void SubtractHatCount()
    {
        hatCount = hatCount - 1;
        Debug.Log("HatCount:" + hatCount);
        textComponent.text = "HatCount : " + hatCount;
    }
}
