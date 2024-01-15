using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaySE : MonoBehaviour, IPointerClickHandler
{
    [HideInInspector] public AudioClip se;
    public void OnPointerClick(PointerEventData eventData)
    {
        Play();
    }

    void Play()
    {
        SoundManager.instance.PlaySE(se);
    }
}
