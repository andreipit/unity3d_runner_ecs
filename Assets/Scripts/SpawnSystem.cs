using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Entities;

class SpawnSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;
        Entities.ForEach((Spawn s) => {
            if (s.active)
            {
                s.timer -= deltaTime;
                if (s.timer <= 0.0f)
                {
                    Vector3 pos = new Vector3(s.player.position.x, 1, s.player.position.z + 30);
                    GameObject clone;
                    if ((int)Random.Range(1, 3) == 1)
                        clone = Object.Instantiate(s.obstacle, pos, Quaternion.identity);
                    else
                        clone = Object.Instantiate(s.prize, pos, Quaternion.identity);
                    s.timer = s.period;
                    s.alive.Add(clone);
                    if (s.alive.Count == 5)
                    {
                        GameObject bad = s.alive[0];
                        s.alive.RemoveAt(0);
                        Object.Destroy(bad);
                    }
                }
            }
        });
    }
}