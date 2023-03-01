using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    [SerializeField]
    private AudioClip sound_btn;

    [SerializeField]
    private AudioSource audio;

    [SerializeField]
    private GameObject panelPause;

    [SerializeField]
    private Slider slider;

    private void Start()
    {
        AudioListener.volume = 1;
    }

    void audioPlay()
    {
        audio.clip = sound_btn;
        audio.Play();

    }
    // Start is called before the first frame update
    public void restart()
    {

        audioPlay();
        Application.LoadLevel("Main");

    }
    public void back()
    {
        Time.timeScale = 1;
        Application.LoadLevel("Playgame");
        audioPlay();

    }
    public void quit()
    {
        audio.clip = sound_btn;
        audioPlay();
    }

    public void paused()
    {
        panelPause.active = true;
        Time.timeScale = 0;
        audioPlay();
    }

    public void resume()
    {
        panelPause.active = false;
        Time.timeScale = 1;
        audioPlay();
    }
    public void Update()
    {
        if (slider)
        {
            AudioListener.volume = slider.value;
        }
    }




}
