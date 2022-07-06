using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class a1Mgr : MonoBehaviour
{
    public Button btn;
    public Image img;

    private void Awake()
    {
        btn.onClick.AddListener(OnBtnClick);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBtnClick()
    {
        Debug.Log("yayaya");
        img.color = new Color(0, 0, 0);
    }
}
