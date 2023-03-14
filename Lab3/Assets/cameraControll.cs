using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControll : MonoBehaviour
{

    public GameObject CannonBall;
    Rigidbody CannonBallRB;
    public Transform ShootPoint;
    public float firepower;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        firepower *= 1000;
    }
}
