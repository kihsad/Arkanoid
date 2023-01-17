﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    [SerializeField]
    private Button _restartButton;

    [SerializeField]
    private Button _resumeButton;

    [SerializeField]
    private Button _exitButton;

    public void OnRestart()
    {
        SceneManager.LoadScene(1);
    }
    public void OnResume()
    {
        gameObject.SetActive(false);
    }
    public void OnExit()
    {
        EditorApplication.isPlaying = false;
    }

}