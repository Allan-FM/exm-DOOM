using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public int life = 5;
    public float spd = 0.004f;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.Play("Anim_inimigo_runnig");
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, GameObject.Find("Main Camera").transform.eulerAngles.y,0);
        transform.position -= transform.forward * this.spd;
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            float DanoTomado = Random.Range(0, 100);
            if (DanoTomado < 50)
            {
                Debug.Log(DanoTomado);
                playerMove.vidaAtual--;
            }            
        }
    }
}
