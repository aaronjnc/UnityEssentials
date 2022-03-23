using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    /// <summary>
    /// Loads scene with given build index
    /// </summary>
    /// <param name="i">Build index</param>
    public void LoadScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
