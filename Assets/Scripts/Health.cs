using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public int hp = 3;
    public Text ui;
    public bool dead;

    public void Reset()
    {
        hp = 3;
        dead = false;
        ui.text = hp.ToString();
    }
}
