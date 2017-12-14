﻿using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;  // 体力
    private int mp = 53;   //魔力
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log("打撃で" + this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //魔法用の関数
    public void Magic(int Magic)
    {

        if (mp >= 5)
        {
            Debug.Log("魔法で" + Magic + "のダメージを与えた");
        //残りmpを減らす
        this.mp -= Magic;
        Debug.Log(mp);

        }

        if (mp <= 5)
        {
            Debug.Log("MPが足りないみたいですよ");
        }

    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法用の関数を呼び出す

        for (int v = 0; v < 10; v++) {
            lastboss.Magic(5);

                }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
