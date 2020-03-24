using UnityEngine;
using UnityEngine.UI;
using Unity.Entities;
using System.Collections.Generic;
public class Spawn : MonoBehaviour
{
    public bool active;
    public float period = 1f;
    public float timer = 0;
    public GameObject obstacle;
    public GameObject prize;
    public Transform player;
    public List<GameObject> alive = new List<GameObject>();

    public void Reset()
    {
        active = true;
        foreach (GameObject obj in alive)
        {
            Destroy(obj);
        }
        alive = new List<GameObject>();
    }

}
