using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public Button backButton;
    public GameObject MenuCanvas;
    public GameObject CurrentCanvas;


    void Start()
    {
        backButton.onClick.AddListener(OnButtonPress);
    }

    void OnButtonPress()
    {
        Debug.Log("BackToMenu");
        MenuCanvas.SetActive(true);
        CurrentCanvas.SetActive(false);
    }
}
