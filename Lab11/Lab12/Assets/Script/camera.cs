using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Vector3 offset;
    //public GameObject Player;
    public float rotationSpeed;
    float mouseX, mouseY;
    public Transform Player, Target;
    // Start is called before the first frame update
    void Start()
    {
        //offset = transform.position - Player.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;

        //Mathf.Clamp(mouseY, -1, 60);

        //Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);

        Player.transform.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        //Player.rotation = Quaternion.Euler(0, mouseX, 0);
        //s transform.position = Player.transform.position + offset;
    }
}
