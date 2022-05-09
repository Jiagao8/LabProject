using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    
    public Slider volumeSlider;
    public AudioMixer mixer;

    public void SetVolume() 
    {   
        mixer.SetFloat("volume", volumeSlider.value);
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel1() 
    {
        SceneManager.LoadScene("SampleScene");
    }
}
