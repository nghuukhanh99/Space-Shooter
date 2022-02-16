using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public static Boss Instance;

    Rigidbody2D rb;

    public GameObject boss;

    public int HP = 100;

    public GameObject bulletPrefabs;

    public float speedBullet = 1.0f;

    public float speedBoss = 1.0f;

    private Vector2 target;

    public bool bossIsDead = false;


    private void Awake()
    {
        Instance = this;


    }

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector2(0f, 3f);



        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void BossMove()
    {
        float step = speedBoss * Time.deltaTime;

        this.boss.gameObject.transform.position = Vector2.MoveTowards(this.boss.gameObject.transform.position, target, step);



    }

    
}
