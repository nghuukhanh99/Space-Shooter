using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCtrl : MonoBehaviour
{
    static SpawnManager spawnManager;
    
    public GameObject bulletPrefabs; // game object sinh ra bullet

    

    private Vector3 mousePosition; // vi tri chuot

    private float speedSpaceShip = 0.3f;

    public float speedBullet = 7;

    public float timeStamp ; // moc thoi gian 

    private float xRange = 2.5f;

    private float yRange = 4.0f;

    BulletFire bulletFire;

    // Start is called before the first frame update
    void Start()
    {
        
        spawnManager = GetComponent<SpawnManager>();

        bulletFire = GetComponent<BulletFire>();
    }

    // Update is called once per frame
    void Update()
    {
        
            followMouse();
            
        

        CantMoveOutOfBounds();
    }

    void followMouse()
    {
        
            // neu an chuot trai
            if (Input.GetMouseButton(1) )
            {
                // cho vi tri chuot = vi tri click mouse
                mousePosition = Input.mousePosition;

                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

                // dich chuyen object tu vi tri hien tai den vi tri click mouse
                transform.position = Vector2.Lerp(transform.position, mousePosition, speedSpaceShip);

            if (Time.time > timeStamp)
            {
                Instantiate(bulletPrefabs, new Vector2(transform.position.x, transform.position.y + 0.5f), bulletPrefabs.gameObject.transform.rotation);
                timeStamp = Time.time + speedBullet;

                AudioManager.Instance.shootSoundEffect();
            }
        }
        
    }

    

    private void CantMoveOutOfBounds()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }

        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            UiManager.Instance.GameOver();
            AudioManager.Instance.gameOverSoundEffect();
            Time.timeScale = 0;
        }

        
	}


}
