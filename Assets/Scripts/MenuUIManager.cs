using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadMainmenu()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("main");
    }
    public void FakeQuit()
    {
        SceneManager.LoadScene("Quit");
    }
}
