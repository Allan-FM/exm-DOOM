using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10f))
            {
                if (hit.collider.gameObject.tag == "Inimigo")
                {
                    GameObject Inimigo = hit.collider.gameObject;
                    Inimigo.GetComponent<AI>().life--;
                    if(Inimigo.GetComponent<AI>().life == 0)
                    {
                        Debug.Log(Inimigo.GetComponent<AI>().life);
                        Destroy(hit.collider.gameObject);
                    }
                    
                }
            }
        }
    }
}
