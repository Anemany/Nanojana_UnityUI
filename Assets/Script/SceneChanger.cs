using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void toFirstScene()
    {
        SceneManager.LoadScene("FirstScene", LoadSceneMode.Single);
    }
    public void toSecondScene()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

}
