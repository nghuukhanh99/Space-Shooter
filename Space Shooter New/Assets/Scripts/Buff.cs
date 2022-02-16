using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff : MonoBehaviour
{
    public static Buff Instance;

    public List<GameObject> itemBuff;

    float speed = 1f;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void itemBuffMove()
	{
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(0, -6), Time.deltaTime * speed);
	}
}
