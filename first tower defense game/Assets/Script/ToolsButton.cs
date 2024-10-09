using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolsButton : MonoBehaviour
{
    [SerializeField] GameObject TowerMenu;
    private void Start()
    {
        TowerMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) 
        {
            TowerMenu.SetActive(false);
        }
    }
    public void ClickOnTool()
    {
        TowerMenu.SetActive(true);;
    }
}
