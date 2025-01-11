using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoguesButton : MonoBehaviour
{
    public Button myButton;
    public GameObject MenuCanvas;
    public GameObject ScrollCanvas;


    void Start()
    {
        myButton.onClick.AddListener(OnButtonPress);
    }

    void OnButtonPress()
    {
        Debug.Log("OpenMenu");
        MenuCanvas.SetActive(false);
        ScrollCanvas.SetActive(true);
    }
}
