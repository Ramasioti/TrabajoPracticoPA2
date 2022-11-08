using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{

    
    public AudioSource music;
    public float sliderValue;
    

    void Start()
    {
        
    }

    void Update()
    {
        music.volume = PlayerPrefs.GetFloat("save", sliderValue);
        ToggleOnMp();
    }

    public void ToggleOnMp()
    {
        bool IsOn = false;
        music.mute = PlayerPrefs.GetInt("IsOn") == 1;
    }

    public void SceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
