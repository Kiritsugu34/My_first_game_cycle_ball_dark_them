using UnityEngine;
public class Rotation : MonoBehaviour
{
    [SerializeField] GameObject CenterCicle;
    bool direction = false;
    [SerializeField] int speed_move = 100;
    void FixedUpdate()
    { if (direction == false)CenterCicle.transform.Rotate(0, 0, speed_move * Time.deltaTime);
        else CenterCicle.transform.Rotate(0, 0, -speed_move * Time.deltaTime);
    }
    public void ChangeDirection()
    {
        direction = !direction;
    }

}
