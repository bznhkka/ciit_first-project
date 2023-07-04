using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_manager : MonoBehaviour
{
    public Animator anim;
    public Player_Movement player;
    // trap damage
    public int trapDamage;
    //player trap contact
    public bool isPlayerOnTop;

    // Start is called before the first frame update
    void Start()
    {
       anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerOnTop = true;
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("IsActive", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerOnTop = false;
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("IsActive", false);
        }
    }

    public void PlayerDamage()
    {
        player.healthPoints -= trapDamage;
    }
}
