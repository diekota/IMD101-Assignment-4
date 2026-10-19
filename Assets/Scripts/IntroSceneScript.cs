using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class IntroSceneScript : MonoBehaviour
{
    public Button PlayButton;

    void Start()
    {
        Button button = PlayButton.GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("FirstScene");
        Debug.Log("button pressed");
    }
}
