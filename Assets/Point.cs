using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Point : MonoBehaviour
{
    float points = 0;
    public TextMeshProUGUI scoreText;


    void Start()
    {
        scoreText.text = "0";
    }
    // Start is called before the first frame update
    public void AddPoints()
    {
        points ++;
        scoreText.text = points.ToString();
    }
}
