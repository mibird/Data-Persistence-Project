using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI yesText;
    [SerializeField] GameObject yesButton;
    [SerializeField] GameObject noButton;
    int yestime = 1;
    public void Yes()
    {
        yestime += 1;
        if (yestime == 2)
        {
            yesText.text = "Sure?";
        }
        else if (yestime == 3)
        {
            Vector3 yesbuttonPos = yesButton.transform.position;
            Vector3 nobuttonPos = noButton.transform.position;
            yesButton.transform.position = nobuttonPos;
            noButton.transform.position = yesbuttonPos;
            yesText.text = "Yes";
        }
        else if (yestime == 4)
        {
            #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
            #endif
            Application.Quit();
        }
    }
    public void No()
    {
        SceneManager.LoadScene("menu");
    }
}
