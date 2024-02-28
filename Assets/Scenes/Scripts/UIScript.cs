using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject title;
    public Button startButton;
    
    public void StartGame()
    {
        title.SetActive(false);
        startButton.gameObject.SetActive(false);
    }
}
