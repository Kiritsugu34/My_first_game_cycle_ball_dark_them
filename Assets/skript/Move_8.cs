using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_8 : MonoBehaviour
{
    public Transform P0;
    public Transform P1;
    public Transform P2;
    public Transform P3;
    public Transform P4;
    public Transform P5;
    public Transform P6;
    public Transform P7;
    public Transform P8;
    public Transform P9;
    public Transform P10;

   [SerializeField] [Range(0,1)] public float t=0;
    [SerializeField] bool direction=false;
    public void ChangeDirection()
    {
        direction = !direction;
    }

    void FixedUpdate()
    {
        
        if (direction==true&&t<=0)
        {
            t = 4;
        }
        if (t >= 0) 
        {
            transform.position = my_static_class.GetPoint(P0.position, P1.position, P2.position, P3.position, t);
        }
        
        if (t>=1)
        {
            transform.position = my_static_class.GetPoint(P3.position, P4.position, P5.position, P0.position, t-1);
        }
        
        if (t>=2)
        {
            transform.position = my_static_class.GetPoint(P0.position, P6.position, P7.position, P8.position, t - 2);
        }
        
        if (t>=3)
        {
            transform.position = my_static_class.GetPoint(P8.position, P9.position, P10.position, P0.position, t - 3);
        }
        

        if (direction == false)
        {
            t = t + 0.015f;
        }
        else 
        {
            t = t - 0.015f;
        }
       
        if (t>4)
        {
            t = 0;
        }
        
    }
    


}
