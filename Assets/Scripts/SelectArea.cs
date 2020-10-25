using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectArea : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Terrain"))
        {
            SceneManager.LoadScene("01-TerrainExperiment");
        }else if (other.CompareTag("Interiors"))
        {
            SceneManager.LoadScene("02-Interiors");
        }else if(other.CompareTag("Audio"))
        {
            SceneManager.LoadScene("03-Textures-Audio");
        }
        else
        {
            SceneManager.LoadScene("SceneManage");
        }
    }
}
