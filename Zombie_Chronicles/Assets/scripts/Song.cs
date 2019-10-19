using UnityEngine;
using UnityEngine.SceneManagement;

public class Song : MonoBehaviour
{
    public AudioSource _audioSource;
    float m_MySliderValue;

    public void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
        m_MySliderValue = 0.5f;
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }
    void OnGUI()
    {
        m_MySliderValue = GUI.HorizontalSlider(new Rect(25, 25, 200, 60), m_MySliderValue, 0.5F,0.5F);
        _audioSource.volume = m_MySliderValue;
    }

    public void StopMusic()
    { 
        _audioSource.Stop();
    }
}