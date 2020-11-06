using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public Text scoreGT;
    public GameObject winTextObject;


    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGo = GameObject.Find("Score");
        scoreGT = scoreGo.GetComponent<Text>();
        scoreGT.text = "15";

        winTextObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("points"))
        {
            other.gameObject.SetActive(false);

            int score = int.Parse(scoreGT.text);
            score -= 1;
            if(score == 0)
            {
                GameObject gate = GameObject.FindGameObjectWithTag("Door");
                Destroy(gate);
            }
            scoreGT.text = score.ToString();
        }
        if (other.CompareTag("End"))
        {
            winTextObject.SetActive(true);
        }
    }
}
