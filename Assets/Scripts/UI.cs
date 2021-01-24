using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] Slider HPBar;
    [SerializeField] Slider ManaBar;


    private void Start()
    {
        Panel.SetActive(false);
        HPBar.value = HPBar.maxValue;
        ManaBar.value = ManaBar.maxValue;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) Panel.SetActive(true);
        if (Input.GetKeyUp(KeyCode.I)) Panel.SetActive(false);
    }
}
