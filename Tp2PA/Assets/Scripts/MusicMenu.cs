
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicMenu : MonoBehaviour
{
    public AudioSource music;
    public float sliderValue;

    void Update()
    {
        music.volume = PlayerPrefs.GetFloat("save", sliderValue);
        ToggleOnMp();
        SongTime();
    }

    public void ToggleOnMp()
    {
        music.mute = PlayerPrefs.GetInt("IsOn") == 1;
    }

    public void SceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SongTime()
    {
        PlayerPrefs.SetFloat("timer", music.time);
    }

}
