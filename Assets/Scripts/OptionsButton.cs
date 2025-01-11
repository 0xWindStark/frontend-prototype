using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutButton : MonoBehaviour
{
    public Button OptionsButton;
    public GameObject CurrentCanvas;
    public GameObject NextCanvas;


    void Start()
    {
        OptionsButton.onClick.AddListener(OnButtonPress);
    }

    void OnButtonPress()
    {
        Debug.Log("OptionsMenu");
        CurrentCanvas.SetActive(false);
        NextCanvas.SetActive(true);
    }
}
