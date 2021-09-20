using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 20;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        if (hp >= 5)
        {
            this.hp -= damage;
            Debug.Log(damage + "のダメージを受けた");
        }

        else
        {
            Debug.Log("負けた");
        }
    }

    public void Magic()
    {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }

        else
        {
            Debug.Log("MPが足りないため、魔法が使えない");
        }
    }
    
}

public class Test : MonoBehaviour
{
    void Start()
    {
        Boss midboss = new Boss();

        midboss.Attack();
        midboss.Defence(5);
        midboss.Magic();

        for (int i = 0; i < 10; i++)
        {
            midboss.Magic();
        }


        for(int i = 0; i < 20; i++)
        {
            midboss.Defence(5);
        }

        int[] array = new int[5];

        array[0] = 1;
        array[1] = 3;
        array[2] = 5;
        array[3] = 7;
        array[4] = 9;

        for (int i = 0; i < 5; i++) 
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }

    private void Update()
    {
        
    }
}
