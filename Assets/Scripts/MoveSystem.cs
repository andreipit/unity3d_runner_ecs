using UnityEngine;
using Unity.Entities;

class MoveSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;
        Entities.ForEach((Transform t, Movement m) => {
            if (m.moving)
            {
                t.Translate(Vector3.forward * m.speed * deltaTime);
                switch (m.state)
                {
                    case Movement.States.middle:
                        if (Input.GetAxis("Horizontal") > 0) m.state = Movement.States.mr;
                        if (Input.GetAxis("Horizontal") < 0) m.state = Movement.States.ml;
                        break;
                    case Movement.States.mr:
                        t.Translate(Vector3.right * m.speed * deltaTime);
                        if (t.position.x > 3) m.state = Movement.States.right;
                        break;
                    case Movement.States.ml:
                        t.Translate(Vector3.left * m.speed * deltaTime);
                        if (t.position.x < -3) m.state = Movement.States.left;
                        break;
                    case Movement.States.right:
                        if (Input.GetAxis("Horizontal") < 0) m.state = Movement.States.rm;
                        break;
                    case Movement.States.rm:
                        t.Translate(Vector3.left * m.speed * deltaTime);
                        if (t.position.x < 0) m.state = Movement.States.middle;
                        break;
                    case Movement.States.left:
                        if (Input.GetAxis("Horizontal") > 0) m.state = Movement.States.lm;
                        break;
                    case Movement.States.lm:
                        t.Translate(Vector3.right * m.speed * deltaTime);
                        if (t.position.x > 0) m.state = Movement.States.middle;
                        break;
                }
            }
        });
    }
}