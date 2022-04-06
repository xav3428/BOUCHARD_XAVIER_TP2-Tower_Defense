using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyMenu : MonoBehaviour
{
    ParticleSystem particles;
    Light areaLight;
    Canvas canvas;


    // Start is called before the first frame update
    void Start()
    {
        particles = GetComponentInChildren(typeof(ParticleSystem), true) as ParticleSystem;
        areaLight = GetComponentInChildren(typeof(Light), true) as Light;
        canvas = GetComponentInChildren(typeof(Canvas), true) as Canvas;
        areaLight.enabled = false;
        canvas.enabled = false;
        particles.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        particles.Play();
        areaLight.enabled = true;
    }

    void OnMouseExit()
    {
        
        particles.Stop();
        areaLight.enabled = false;
    }

    private void OnMouseDown()
    {
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("TowerUI"))
        {
            item.GetComponent<Canvas>().enabled = false;
        }
        canvas.enabled = true;
    }
}
