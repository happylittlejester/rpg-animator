using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button resumeButton;
    public Button controlsButton;
    public Button quitButton;

    private void Start()
    {
        resumeButton.onClick.AddListener(() => buttonCallBack(resumeButton));
        controlsButton.onClick.AddListener(() => buttonCallBack(controlsButton));
        quitButton.onClick.AddListener(() => buttonCallBack(quitButton));
    }

    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == resumeButton)
        {
            SceneManager.LoadScene("Main");
            Time.timeScale = 1f;
        }

        if (buttonPressed == controlsButton)
        {
            SceneManager.LoadScene("Controls");
        }

        if (buttonPressed == quitButton)
        {
            Application.Quit();
        }
    }
}
