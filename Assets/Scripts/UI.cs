using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] GameObject Panel;

    private void Start()
    {
        Panel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) Panel.SetActive(true);
        if (Input.GetKeyUp(KeyCode.I)) Panel.SetActive(false);
    }

}
