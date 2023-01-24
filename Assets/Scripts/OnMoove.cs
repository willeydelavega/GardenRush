using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OnMoove : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent  gardener ;
    [SerializeField] private bool walking;
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update() {
    if (Input.GetMouseButtonDown(0)) {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            gardener.SetDestination(hit.point);
            // .SetDirection (ray.direction);
        }
        float dist=gardener.remainingDistance; 
        if (dist<0.1f)
        {
            
            gardener.isStopped = true;

        }
        else 
        
        {
            walking = false;
        }
    }

      
}


    
 
}
