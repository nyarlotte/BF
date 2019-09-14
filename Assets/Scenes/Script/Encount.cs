using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encount : MonoBehaviour
{
    Move Move;
    GameObject Player;
    public GameManegement GameManegement;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Move = Player.GetComponent<Move>();
    }
    void OnCollisionStay(Collision other)
    {
        //Move._Encount = true;
    }

    void OnCollisionEnter(Collision other)
    {
        Move._Encount = true;
    }

    void OnCollisionExit(Collision other)
    {
        Move._Encount = false;
    }
}
