using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibles : MonoBehaviour
{
    public bool speed, health;
    public int speedBoost, healthBoost, duration;
    public Player_Movement player;
    private int baseSpeed;
    // Start is called before the first frame update

    private void Start()
    {
        baseSpeed = player.moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (speed)
        {
            player.moveSpeed += speedBoost;
            StartCoroutine(BackToBaseSpeed());
        }

        if (health)
        {
            player.healthPoints += healthBoost;
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator BackToBaseSpeed()
    {
        yield return new WaitForSeconds(duration);
        player.moveSpeed = baseSpeed;
    }
}
