using UnityEngine;
using Unity.Entities;

class AwardSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;
        Entities.ForEach((Award a) => {

            a.text.text = a.amount.ToString();

        });
    }
}