using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    GameObject winningPanel;
    float timer;

    Animator anim;


    void Awake()
    {
        anim = GetComponent<Animator>();
        winningPanel = GameObject.FindGameObjectWithTag("winningPanel");
        timer = 3f;
        
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
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                SceneManager.LoadScene(0);
            }
            
        }
        if (ScoreManager.score < 6)
        {
            winningPanel.SetActive(false);
        }
    }

}
