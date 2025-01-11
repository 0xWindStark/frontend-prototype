   using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject MainMenuCanvas;
    public GameObject ScrollSelectionCanvas;
    public GameObject OptionsCanvas;
    public GameObject AboutCanvas;
    public GameObject PauseMenu;

    private void Awake()
    {
        MainMenuCanvas.SetActive(true);
        ScrollSelectionCanvas.SetActive(false);
        OptionsCanvas.SetActive(false);
        AboutCanvas.SetActive(false);
        PauseMenu.SetActive(false);
    }
}

