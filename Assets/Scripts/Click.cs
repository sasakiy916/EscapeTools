using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour
{
    [SerializeField] EventSystem eventSystem;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        // button.GetComponent<Button>().onClick.AddListener(Clickable);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(event.);
        // Debug.Log(eventSystem.currentSelectedGameObject.name);
    }
    public void Clickable()
    {
        Debug.Log(eventSystem.currentSelectedGameObject.name);
    }
}
