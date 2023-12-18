using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    AudioSource bgm;
    AudioSource se;
    [SerializeField] AudioClip[] audios;
    public AudioClip[] Audios
    {
        get => this.audios;
    }

    void Start()
    {
        ToSingleton();
        GetAudioSourceComponent();
    }

    void Update()
    {

    }

    public string[] GetAudioNames()
    {
        List<string> auidoNames = new();
        for (int i = 0; i < this.audios.Length; i++)
        {
            if (this.audios[i] == null) continue;
            auidoNames.Add(this.audios[i].name);
        }
        return auidoNames.ToArray();
    }

    public void SetAuidoBGM(int selected)
    {
        // audioSourceがnullならGetComponentする
        if (bgm == null)
        {
            AudioSource[] audioSources = GetComponents<AudioSource>();
            foreach (AudioSource source in audioSources)
            {
                switch (source.outputAudioMixerGroup.name)
                {
                    case "BGM":
                        bgm = source;
                        break;
                    case "SE":
                        se = source;
                        break;
                }
            }
        }
        //  selectedがindex外なら最後のindexにする
        if (selected >= this.audios.Length - 1) selected = this.audios.Length - 1;
        // AudioClipを変更する
        bgm.clip = selected != -1 ? this.audios[selected] : null;
    }

    void GetAudioSourceComponent()
    {
        // BGM,SE用のAudioSourceコンポーネント取得
        AudioSource[] audios = GetComponents<AudioSource>();
        foreach (AudioSource source in audios)
        {
            switch (source.outputAudioMixerGroup.name)
            {
                case "BGM":
                    bgm = source;
                    break;
                case "SE":
                    se = source;
                    break;
            }
        }
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
