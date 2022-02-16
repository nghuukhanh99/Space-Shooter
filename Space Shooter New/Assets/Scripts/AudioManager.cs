using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioClip deadSound;

    public AudioClip shootSound;

    public AudioClip destroySound;

    public AudioClip musicGame;

    AudioSource audioSource;

    
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UiManager.Instance.isGameOver == true)
        {
            audioSource.mute = true;
        }
    }

    public void gameOverSoundEffect()
    {
        audioSource.PlayOneShot(deadSound, 2);
    }

    public void shootSoundEffect()
    {
        audioSource.PlayOneShot(shootSound, 10);
    }

    public void destroySoundEffect()
    {
        audioSource.PlayOneShot(destroySound, 2);
    }

    public void MuteButton()
    {
       
        audioSource.mute = true;

    }

    public void unMuteButton()
    {
       
        audioSource.mute = false;

        
    }
}
