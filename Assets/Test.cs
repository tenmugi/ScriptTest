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
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic(int mp)
    {
        if (mp > 5)
        {
            Debug.Log("魔法攻撃をした。残りMPは〇〇");
            this.mp -= 5;
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
        midboss.Magic(53);

        for (int i = 0; i > 5; i++)
        {
            int mp = 53;
            if(mp <5)
            {
                Debug.Log("MPが足りない");
            }
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
