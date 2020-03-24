using UnityEngine;
using Unity.Entities;
public class Damage : MonoBehaviour
{
    public int amount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            amount += 1;
            Destroy(other.gameObject);
        }
        //else
        //{
        //    points.Increase(1);
        //    Destroy(other.gameObject);
        //}
    }
    public void Reset()
    {
        amount = 0;
    }
}
