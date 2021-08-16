using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickCounter : MonoBehaviour
{
    private int clickCount;
    [SerializeField]
    private Text clickCountText;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            clickCount++;
            clickCountText.text = clickCount.ToString();
            //clickCount.text
        }
    }
}
