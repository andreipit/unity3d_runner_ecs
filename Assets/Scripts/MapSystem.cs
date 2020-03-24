using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Entities;

class MapSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;
        Entities.ForEach((Map m) => {
            if (m.step==0) m.step = m.middle.localPosition.z - m.first.localPosition.z;

            if (m.player.position.z > m.middle.position.z - m.offset)
            {
                m.first.localPosition = new Vector3(0, 0, m.first.localPosition.z + m.step * m.parts); // terrains.Length);
                m.buffer = m.middle;
                m.middle = m.last;
                m.last = m.first;
                m.first = m.buffer;
            }
        });
    }
}