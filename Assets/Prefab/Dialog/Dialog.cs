using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    [SerializeField] private int text_index = 0;
    [SerializeField] private string[] texts;
    [SerializeField] private GameObject Dialog_canvas;
    [SerializeField] private TextMeshProUGUI TMP_text;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Dialog_canvas.active)
        {
            if(text_index + 1 < texts.Length)
            {
                text_index++;
                SetText();

            }
            else
            {
                Dialog_canvas.SetActive(false);
                text_index = 0;
                Time.timeScale = 1;
            }


        }

        if (Input.GetKeyDown(KeyCode.Mouse1) && Dialog_canvas.active)
        {
            if (text_index - 1 >= 0)
            {
                text_index--;
                SetText();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        Dialog_canvas.SetActive(true);
        SetText();
    }
    private void SetText()
    {
        TMP_text.text = texts[text_index];
    }
}
