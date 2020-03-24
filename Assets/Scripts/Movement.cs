using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool moving;
    public float speed = 10f;
    public enum States { left, middle, right, lm, ml, rm, mr }; // mr => going from middle to right
    public States state = States.middle;
    
    public void Reset()
    {
        moving = true;
    }
}
