using UnityEngine;
using Unity.Entities;

class DamageSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;
        Entities.ForEach((Damage d, Health h) => {
            h.hp -= d.amount;
            if (h.hp == 0) h.dead = true;
            d.amount = 0;
            h.ui.text = h.hp.ToString();
        });
    }
}