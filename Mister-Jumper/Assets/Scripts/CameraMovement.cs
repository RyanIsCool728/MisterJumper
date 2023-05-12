using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera cam;
    public Transform player;
    public void Update()
    {
    

    Vector3 camPos = cam.transform.position;
    camPos.x = player.position.x;
    cam.transform.position = camPos;
    }



}
