using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSCamera : MonoBehaviour
{

    Camera cam;
    public string zoomingAxis = "Mouse ScrollWheel";
    public float zoomSpeed = 10f;

    public int verticalPanLimit = 10;
    public int horizontalPanLimit = 20;
    public float panSpeed = 10f;

    void Start()
    {
        cam = Camera.main;
    }


    void Update()
    {


        Vector3 move = new Vector3(0f, Input.GetAxis(zoomingAxis) * zoomSpeed * Time.deltaTime, 0f);

        if (Input.mousePosition.x >= (Screen.width - horizontalPanLimit))
        {
            move.z -= 1.0f * panSpeed * Time.deltaTime;
        }

        if (Input.mousePosition.x <= (horizontalPanLimit))
        {
            move.z += 1.0f * panSpeed * Time.deltaTime;
        }

        if (Input.mousePosition.y >= Screen.height - verticalPanLimit)
        {
            move.x += 1.0f * panSpeed * Time.deltaTime;
        }

        if (Input.mousePosition.y <= 0.0f + verticalPanLimit)
        {
            move.x -= 1.0f * panSpeed * Time.deltaTime;
        }

        cam.transform.position -= move;


    }
}
