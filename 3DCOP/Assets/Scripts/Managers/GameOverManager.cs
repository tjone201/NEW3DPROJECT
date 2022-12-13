using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    GameObject winningPanel;


    Animator anim;


    void Awake()
    {
        anim = GetComponent<Animator>();
        winningPanel = GameObject.FindGameObjectWithTag("winningPanel");
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
        }
        if(ScoreManager.score >= 6)
        {
            winningPanel.SetActive(true);
        }
        if (ScoreManager.score < 6)
        {
            winningPanel.SetActive(false);
        }
    }

}
