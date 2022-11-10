using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{

    
    AudioSource music;


    public Text lyrics;
    public int Time;

    public int Count = 0;

    public Lyrics[] soLyrics;
    

    void Start()
    {
        music = GetComponent<AudioSource>();
        lyrics.text = "";
    }

    void Update()
    {
        Time = Mathf.RoundToInt(PlayerPrefs.GetFloat("timer"));
        Debug.Log(Time);
        ChangeLyrics();
    }

    public void ChangeLyrics()
    {
        if (Time > soLyrics[Count].initTime)
        {
            lyrics.text = soLyrics[Count].currLyric;
        }

        if (Time > soLyrics[Count].finalTime)
        {
            lyrics.text = "";
            Count++;
        }
    }


}
