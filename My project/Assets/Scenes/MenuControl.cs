using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuControl : MonoBehaviour
{

    public Slider volumenSlider;


    void Start()
    {
        Values();
    }


    void Update()
    {

    }

    public void ChanceScene()
    {
        SceneManager.LoadScene("Principal");
    }

    void Values() 
    {
        volumenSlider.value = PlayerPrefs.GetFloat("volumerSlider");
    }

    public void SetVolume()
    {
        PlayerPrefs.GetFloat("volumeSlider", volumenSlider.value);
    }
}
