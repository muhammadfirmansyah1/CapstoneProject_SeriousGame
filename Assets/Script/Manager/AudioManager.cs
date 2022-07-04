using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource levelMusic, gameOverMusic, winMusic;
    public AudioSource Enemy;
    public AudioSource Quiz;
    public AudioSource[] sfx;
    public float volumeMusic;

    public float enemeyMusic = 0.1f;

    public Sound[] sounds;

    void Awake() {
        if(instance == null)
        {
            instance= this;
            
        } else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
    
    void Start()
    {

    }

    

    void Update()
    {
    }

    public void PlayMusicOnMenu()
    {
        Enemy.GetComponent<AudioSource>().playOnAwake = true;
        Enemy.GetComponent<AudioSource>().loop = false;
        gameOverMusic.Stop();
        Quiz.Stop();
        levelMusic.Play();
    }

    public void PlayGameOver()
    {
        levelMusic.Stop();
        gameOverMusic.Play();
    }
    public void PlayLevelWin()
    {
        levelMusic.Stop();
        winMusic.Play();
    }

    public void PlaySFX(int sfxPlay)
    {
        sfx[sfxPlay].Stop();
        sfx[sfxPlay].Play();
    }

    public void EnemyMusicOnSCreen()
    {
        Enemy.GetComponent<AudioSource>().loop = false;
        Enemy.GetComponent<AudioSource>().playOnAwake= true;
        Enemy.Play();
    }

    public void QuizMusicBegin()
    {
        levelMusic.Stop();
        Quiz.Play();
    }

    IEnumerator EnemyMusic()
    {
        yield return new WaitForSeconds(enemeyMusic);
        Enemy.Play();
    }
    

}
