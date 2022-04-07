using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TurretManager : MonoBehaviour
{
    protected ParticleSystem particles;
    protected Light areaLight;
    protected Canvas canvas;
    
    // Start is called before the first frame update
    protected void Start()
    {
        
        particles = GetComponentInChildren(typeof(ParticleSystem), true) as ParticleSystem;
        areaLight = GetComponentInChildren(typeof(Light), true) as Light;
        canvas = GetComponentInChildren(typeof(Canvas), true) as Canvas;
        areaLight.enabled = false;
        canvas.enabled = false;
        particles.Stop();
        
    }

    protected void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("TowerUI"))
        {
            item.GetComponent<Canvas>().enabled = false;
        }
        canvas.enabled = true;
    }

    void OnMouseOver()
    {
        if (!canvas.enabled)
        {
            particles.Play();
            areaLight.enabled = true;
        }
        
    }
    void OnMouseExit()
    { 
        particles.Stop();
        areaLight.enabled = false;
    }
}
