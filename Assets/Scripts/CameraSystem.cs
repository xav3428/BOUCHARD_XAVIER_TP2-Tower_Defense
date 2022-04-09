using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{   
    private GameObject g_1;
    private GameObject g_2;
    private GameObject g_3;
    private GameObject g_4;
    [SerializeField] private List<GameObject> g_cameras;
    [SerializeField] private List<Camera> c_cameras;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        g_1 = g_cameras[0];
        g_2 = g_cameras[1];
        g_3 = g_cameras[2];
        g_4 = g_cameras[3];
        g_1.SetActive(true);
        g_2.SetActive(false);
        g_3.SetActive(false);
        g_4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("ToggleCamera1"))
        {
            g_1.SetActive(true);
            g_2.SetActive(false);
            g_3.SetActive(false);
            g_4.SetActive(false);
        }
        if (Input.GetButtonDown("ToggleCamera2"))
        {
            g_1.SetActive(false);
            g_2.SetActive(true);
            g_3.SetActive(false);
            g_4.SetActive(false);
        }
        if (Input.GetButtonDown("ToggleCamera3"))
        {
            g_1.SetActive(false);
            g_2.SetActive(false);
            g_3.SetActive(true);
            g_4.SetActive(false);
        }
        if (Input.GetButtonDown("ToggleCamera4"))
        {
            g_1.SetActive(false);
            g_2.SetActive(false);
            g_3.SetActive(false);
            g_4.SetActive(true);
        }
        for (int i = 0; i < g_cameras.Count; i++)
        {
            GameObject cam = g_cameras[i];
            if (cam.activeSelf)
            {
                RotateMenus(cam);
                RotateHealthBars(cam);
            }
        }
    }

    public void CanvasRotateToCam(Transform targetTransform, Transform canTransform)
    {
        Vector3 targetDirection = targetTransform.position - canTransform.position;

        float singleStep = speed * Time.deltaTime;

        Vector3 newDirection = Vector3.RotateTowards(canTransform.forward, targetDirection, singleStep, 0.0f);

        canTransform.rotation = Quaternion.LookRotation(newDirection);
    }

    void RotateMenus(GameObject cam)
    {
        GameObject[] canvases = GameObject.FindGameObjectsWithTag("TowerUI");
        foreach (GameObject canvas in canvases)
        {
            canvas.GetComponent<Canvas>().worldCamera = cam.GetComponent<Camera>();
            CanvasRotateToCam(cam.transform, canvas.transform);
        }
    }
    void RotateHealthBars(GameObject cam)
    {
        GameObject[] healthbars = GameObject.FindGameObjectsWithTag("Healthbar");
        foreach (GameObject healthbar in healthbars)
        {
            healthbar.GetComponent<Canvas>().worldCamera = cam.GetComponent<Camera>();
            CanvasRotateToCam(cam.transform, healthbar.transform);
        }
    }
}
