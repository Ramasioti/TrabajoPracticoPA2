using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuControl : MonoBehaviour
{



    public Slider slider;
    public Toggle toggle;

    public float sliderValue;
    


    void Start()
    {
        Values();
        ToggleOn();
    }


    void Update()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("IsOn", 1);
        }
        else
        {
            PlayerPrefs.SetInt("IsOn", 0);
        }
    }


    void Values() 
    {
        slider.value = PlayerPrefs.GetFloat("save", sliderValue);
    }

    public void SetVolume(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("save", sliderValue);
    }

    public void ToggleOn()
    {
        bool IsOn = false;
        if(PlayerPrefs.GetInt("IsOn") == 1)
        {
            IsOn = true;
        }

        else
        {
            IsOn = false;
        }

        toggle.isOn = IsOn;
    }


    public void ChanceScene()
    {
        SceneManager.LoadScene("Principal");
    }

}
