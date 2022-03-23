using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("Number to display")]
    [SerializeField] private int number = 0;
    [Tooltip("Application is closing")]
    private static bool applicationQuitting = false;
    [Tooltip("Current instance of the GameManager")]
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (applicationQuitting)
            {
                return null;
            }
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                if (_instance == null)
                {
                    GameObject go = new GameObject();
                    _instance = go.AddComponent<GameManager>();
                }
            }
            return _instance;
        }
    }
    /// <summary>
    /// Called on GameObject Awake
    /// </summary>
    private void Awake()
    {
        Application.quitting += () => applicationQuitting = true;
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }
    /// <summary>
    /// Gets the number
    /// </summary>
    /// <returns></returns>
    public int GetNumber()
    {
        return number;
    }
}
