using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoquitoScript : MonoBehaviour
{
    public GameObject[] colors;
    public int currentLightIndex =-1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateNextLight()
    {
        //MUY IMPORTANTE
        currentLightIndex++;
        if (currentLightIndex >= colors.Length)
        {
            currentLightIndex = 0;
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
    }

    public void ActivatePreviousLight()
    {
        //IMPORTANTE
        currentLightIndex--;
        if (currentLightIndex < 0)
        {
            currentLightIndex = colors.Length - 1;
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
    }

    void DeactivateAllLights()
    {
        //IMPORTANTE
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i].SetActive(false);
        }
    }

    //IMPORTANTE
    public void ActivateRepeating(float t)
    {
        InvokeRepeating(nameof(ActivateNextLight),0,t);
    }
}
