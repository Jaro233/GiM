using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
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
     
        if(Input.GetMouseButtonDown(0))
        {
            Fire();
        }
            

     }

    public void Fire()
    {

        float ShootPower = firepower * 1000;
        GameObject CannonBallCopy = Instantiate(CannonBall, ShootPoint.position, ShootPoint.rotation) as GameObject;
        Destroy(CannonBallCopy, 5f);
        CannonBallRB = CannonBallCopy.GetComponent<Rigidbody>();
        CannonBallRB.AddForce(transform.forward * ShootPower);
   
    }
}
