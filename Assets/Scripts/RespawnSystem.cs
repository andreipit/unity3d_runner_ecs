using UnityEngine;
using Unity.Entities;

class RespawnSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;
        Entities.ForEach((Health h, Movement m, Respawn r) => {
            if (h.dead)
            {
                m.moving = false;
                GameObject.Find("Environment").GetComponent<Spawn>().active = false;
                r.startPanel.SetActive(true);
            }
        });
    }
}