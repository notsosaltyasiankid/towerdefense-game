using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public List<Transform> targets = new List<Transform>();
    public float speed = 1f;

    private Vector3 differenceFactor;

    public Transform startPoint;

    private Transform goingPoint;

    private int pointPos;

    private Vector3 direction;

    public static event Action Hit;



    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.Find("PathManager").GetComponent<Path>().pathList;

        

        transform.position = startPoint.position;

        goingPoint = targets[pointPos];
    }

    // Update is called once per frame
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
}
