using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player
{
    private int hp = 100;
    private int Power = 50;

    public void Attack()
    {
        Debug.Log(this.Power + " 데미지를 입혔다 ");
    }

    public void Damage(int Damage)
    {
        this.hp -= Damage;
        Debug.Log(Damage + " 데미지를 입었다 ");
    }
    
    public int GetHp()
    {
         return hp;
    }
}

public class Test_008 : MonoBehaviour
{
    public Text playerHp;
    public Text player2Hp;

    Player mPlayer = new Player();
    Player mPlayer2 = new Player();


    // Start is called before the first frame update
    void Start()
    {
       // mPlayer.Attack();
       // mPlayer.Damage(30);
        //Debug.Log(mPlayer.GetHp());
    }

    // Update is called once per frame
    void Update()
    {
        playerHp.text = "Player 1 HP : " +  mPlayer.GetHp().ToString();
        player2Hp.text = "Player 2 HP : " +  mPlayer2.GetHp().ToString();

        if (Input.GetMouseButtonDown(0))
        {
            mPlayer.Damage(1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            mPlayer2.Damage(1);
        }
    }
}
