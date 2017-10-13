using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Exit : MonoBehaviour
{
    [SerializeField]
    private Button exitButton;
    void Start()
    {
        Button btn = exitButton.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        Application.Quit();
    }
}