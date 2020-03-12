using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class Throw : MonoBehaviour
{
    public bool grabbed;
    RaycastHit2D hit;
    public float distance = 2f;
    public Transform holdpoint;

    void Update(){
        if (Input.GetKeyDown(KeyCode.P))
        {   
            if(!grabbed)
            {
                Physics2D.queriesStartInColliders=false;
                hit = Physics2D.Raycast(transform.position,Vector2.right*transform.localScale.x,distance);
                if(hit.collider!=null)
                {
                   grabbed = true; 
                }
            }
            else
            {

            }
        }

        if(grabbed)
            hit.collider.gameObject.transform.position=holdpoint.position;
    
    
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position,transform.position+Vector3.right*transform.localScale.x*distance);
    }




}

