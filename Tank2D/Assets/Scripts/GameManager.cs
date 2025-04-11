using Core.Pool;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : SingletonMono<GameManager>
{
    public GameObject enemyTank;
    public Image hpImage;
    private int score;
    private void Start() {
        this.RegisterListener(EventID.AttackEnemy, (sender, param) =>  OnAttackEnemy());
        this.RegisterListener(EventID.EnemyDie, (sender, param) => SpawnEnemy());
        this.RegisterListener(EventID.PlayerTakeDamage, (sender, param) => PlayerHealth((int)param));
        SpawnEnemy();

        hpImage.fillAmount = 1;
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

    private void SpawnEnemy()
    {
        var enemy = SmartPool.Instance.Spawn(enemyTank, Vector3.zero, Quaternion.identity);
        enemy.GetComponent<EnemyController>().InitData();

    }

    private void PlayerHealth(int currentHealth)
    {
        Debug.Log("Mau hien tai " + currentHealth);
        hpImage.fillAmount = (float) currentHealth / PlayerController.Instance.maxHealth;
    }
}
