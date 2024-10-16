using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolsButton : MonoBehaviour
{
    [SerializeField] GameObject TowerMenu;
    private Towers tower;
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
    public void ClickOnTool(GameObject posObject)
    {
        TowerMenu.SetActive(true);
        tower = TowerMenu.GetComponent<Towers>();
        tower.SpawnPoint = posObject;
        tower.ZaButton = this.gameObject;
    }
}
