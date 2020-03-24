using UnityEngine;
using UnityEngine.UI;
using Unity.Entities;
public class Award : MonoBehaviour
{
    public int amount;
    public Text text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Finish")
        {
            amount += 1;
            Destroy(other.gameObject);
        }
    }

    public void Reset()
    {
        amount = 0;
        text.text = "0";
    }
}
