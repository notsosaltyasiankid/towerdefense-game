using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

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
    [SerializeField] private GameObject archerTower;
    [SerializeField] private GameObject BombTower;
    [SerializeField] private GameObject gunTower;

    private ScoreSystem scrap;

    void Start()
    {
        scrap = FindAnyObjectByType<ScoreSystem>();
    }

    void Update()
    {
        
    }
    public void SpawnArcher()
    {
        if(scrap.TotalScore >= 50)
        {
            scrap.addedScore(-50);
            Instantiate(archerTower, spawnPoint.transform.position, Quaternion.identity, spawnPoint.transform);
            gameObject.SetActive(false);
            zaButton.SetActive(false);
        }
    }
    public  void SpawnCanon()
    {
        if(scrap.TotalScore >= 200)
        {
            scrap.addedScore(-200);
            Instantiate(BombTower, spawnPoint.transform.position, Quaternion.identity, spawnPoint.transform);
            gameObject.SetActive(false);
            zaButton.SetActive(false);
        }
    }
    public void SpawnGun()
    {
        if(scrap.TotalScore >= 100)
        {
            scrap.addedScore(-100);
            Instantiate(gunTower, spawnPoint.transform.position, Quaternion.identity, spawnPoint.transform);
            gameObject.SetActive(false);
            zaButton.SetActive(false);
        }
    }
}
