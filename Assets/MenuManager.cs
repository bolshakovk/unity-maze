using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager: MonoBehaviour
{
    public Button resetButton;
    public GameObject player;
    public Button exitButton;
    public GameObject optionsMenu;
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {  
        exitButton.onClick.AddListener(Exit);
        originalPos = player.transform.position;
        resetButton.onClick.AddListener(ResetPosition);
        
    }
    public void ResetPosition()
    {
        player.transform.position = originalPos;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
