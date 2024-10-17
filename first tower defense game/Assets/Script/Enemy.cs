using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private List<Transform> targets = new List<Transform>();

    public List<Transform> Targets 
    { 
        set { 
            targets = value;
        }
    }

    [SerializeField] public float health;


    [SerializeField] private List<Quaternion> pathRotations = new List<Quaternion>();


    [SerializeField] private float speed = 1f;

    private Vector3 differenceFactor;

    [SerializeField] private Transform startPoint;

    private Transform goingPoint;

    private int pointPos;

    private Vector3 direction;

    public static event Action Hit;



    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.Find("PathManager").GetComponent<Path>().PathList;

        transform.position = startPoint.position;

        goingPoint = targets[pointPos];

        health = MathF.Max(health, 0);
    }
    void Update()
    {
        StartGoing();

        DestroyAtEnd();
    }

    void StartGoing()
    {
        differenceFactor = goingPoint.position - transform.position;
        direction = differenceFactor.normalized;

        transform.position += direction * speed * Time.deltaTime;
        if(differenceFactor.magnitude < 0.1) 
        {
            goingPoint = targets[pointPos];
            transform.rotation = pathRotations[pointPos];
            pointPos++;
            
        }
    }
    
    void DestroyAtEnd()
    {
        if (goingPoint == targets[10])
        {
            Hit?.Invoke();
            Destroy(gameObject);
        }
    }

   

    public void EnemyHealth(int damage)
    {
        health -= damage;
    }
}
