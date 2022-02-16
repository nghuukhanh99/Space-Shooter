using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BulletFire : MonoBehaviour
{
    private GameObject bullet;

    public float speedBullet = 7.0f;

    private float yLimit = 6.5f;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletMove();
        destroyOutOfBounds();
    }

    private void bulletMove()
    {
        transform.Translate(Vector2.up * speedBullet * Time.deltaTime);
    }

    private void destroyOutOfBounds()
    {
        if(transform.position.y > yLimit)
        {
            Destroy(gameObject);
        }
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            AudioManager.Instance.destroySoundEffect();
            ScoreManager.instance.AddScore();
        }

        if(other.tag == "Boss")
        {
            Boss.Instance.HP -= 2;
            if(Boss.Instance.HP <= 0)
            {
                Boss.Instance.boss.gameObject.SetActive(false);
                
                Boss.Instance.bossIsDead = true;
                AudioManager.Instance.destroySoundEffect();

            }
            Destroy(gameObject);
        }
    }
}
