using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMono<GameManager>
{
    private int score;
    private void Start() {
        this.RegisterListener(EventID.AttackEnemy, (sender, param) =>  OnAttackEnemy());
    }

    private void OnAttackEnemy()
    {
        Debug.Log("Attack Enemy");
    }
    public void AddScore()
    {
        score += 10;
        Debug.Log(score);
    }
}
