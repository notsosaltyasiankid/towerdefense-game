using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour
{
    [SerializeField] private GameObject zaButton;
    public GameObject ZaButton
        {
         set { zaButton = value; }
        }

    [SerializeField] private GameObject spawnPoint;

    public GameObject SpawnPoint
    {
        set { spawnPoint = value; }
    }
    [SerializeField] private GameObject tower1;
    [SerializeField] private GameObject tower2;
    [SerializeField] private GameObject tower3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnArcher()
    {
        Instantiate(tower1, spawnPoint.transform.position, Quaternion.identity, spawnPoint.transform);
        gameObject.SetActive(false);
        zaButton.SetActive(false);
    }
    public  void SpawnCanon()
    {
        Instantiate (tower2, spawnPoint.transform.position, Quaternion.identity, spawnPoint.transform);
        gameObject.SetActive(false);
        zaButton.SetActive(false);
    }
    public void SpawnGun()
    {
        Instantiate (tower3, spawnPoint.transform.position, Quaternion.identity, spawnPoint.transform);
        gameObject.SetActive(false);
        zaButton.SetActive(false);
    }
}
