using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    public int scene2LoadId;
    public virtual void loadScene()
    {
        SceneManager.LoadScene(scene2LoadId);
    }
}
