using UnityEngine;
using System.Collections;
using Pathfinding;
using Pathfinding.RVO;

public class slimeAI : AIPath
{
    public Animation anim;

    /* * Minimum velocity for moving */
    public float sleepVelocity = 0.4F;

    /* * Speed relative to velocity with which to play animations */
    public float animationSpeed = 0.2F;

    public new void Start()
    { 
        base.Start();
    }

    /* * Point for the last spawn of #endOfPathEffect */
    protected Vector3 lastTarget;

    public override Vector3 GetFeetPosition()
    {
        return tr.position;
    }

    new void Update()
    {
        //Get velocity in world-space
        Vector3 velocity;

        if (canMove)
        {
            //Calculate desired velocity
            Vector3 dir = CalculateVelocity(GetFeetPosition());
            //Rotate towards targetDirection (filled in by CalculateVelocity)
            RotateTowards(targetDirection);

            dir.y = 0;
            if (dir.sqrMagnitude > sleepVelocity * sleepVelocity)
            {
                //If the velocity is large enough, move
            }
            else
            {
                //Otherwise, just stand still (this ensures gravity is applied)
                dir = Vector3.zero;
            }

            if (controller != null)
            {
                controller.SimpleMove(dir);
                velocity = controller.velocity;
            }
            else
            {
                Debug.LogWarning("No NavmeshController or CharacterController attached to GameObject");
                velocity = Vector3.zero;
            }
        }
        else
        {
            velocity = Vector3.zero;
        }
        //Calculate the velocity relative to this transform's orientation
        Vector3 relVelocity = tr.InverseTransformDirection(velocity);
        relVelocity.y = 0;

        if (velocity.sqrMagnitude <= sleepVelocity * sleepVelocity)
        {
            
        }
        else
        {
            float speed = relVelocity.z;         
        }
    }
}

