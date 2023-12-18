using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    AudioSource audioSource;
    AudioSource seSource;
    void Start()
    {
        ToSingleton();

        // BGM,SE用のAudioSourceコンポーネント取得
        AudioSource[] audios = GetComponents<AudioSource>();
        foreach (AudioSource source in audios)
        {
            switch (source.outputAudioMixerGroup.name)
            {
                case "BGM":
                    audioSource = source;
                    break;
                case "SE":
                    seSource = source;
                    break;
            }
        }
    }

    void Update()
    {

    }

    // シングルトン化
    void ToSingleton()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
