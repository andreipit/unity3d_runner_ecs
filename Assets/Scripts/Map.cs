using UnityEngine;
using UnityEngine.UI;
using Unity.Entities;
public class Map : MonoBehaviour
{
    public Transform player, first, middle, last;
    [HideInInspector] public Transform buffer;
    [HideInInspector] public float offset = 5;
    [HideInInspector] public float parts = 3;
    [HideInInspector] public float step;

}
