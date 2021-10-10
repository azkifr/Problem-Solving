using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PreviousScene : MonoBehaviour
{
    private int PScene;
    public void SceneSwitcher()
    {
        PScene = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(PScene);
    }
}
