using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TImer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    private float elepsedTime;
    private int min;
    private int sec;
    public bool timeRun = true;
    public Color transparent;
    [SerializeField] TextMeshProUGUI gameOverText;
    // Update is called once per frame
    private void Start()
    {
    }
    void Update()
    {
        if (timeRun)
        {
            elepsedTime += Time.deltaTime;
            min = Mathf.FloorToInt(elepsedTime / 60);
            sec = Mathf.FloorToInt(elepsedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", min, sec);
        }
        if (!timeRun)
        {
            gameOverText.text = string.Format("{0:00}:{1:00}", min, sec);
        }
    }
}
