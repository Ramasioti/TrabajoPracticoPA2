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


    void Values() 
    {
        slider.value = PlayerPrefs.GetFloat("save", sliderValue);
    }

    public void SetVolume(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("save", sliderValue);
    }

    public void ChangeToggle()
    {
        PlayerPrefs.SetInt("IsOn", (toggle.isOn ? 1 : 0));
    }

    public void ToggleOn()
    {

        toggle.isOn = PlayerPrefs.GetInt("IsOn", 0) == 1;

    }


    public void ChanceScene()
    {
        SceneManager.LoadScene("Principal");
    }

}
