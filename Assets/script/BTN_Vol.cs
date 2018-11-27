using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BTN_Vol : MonoBehaviour {
    public Text text;
    VolManage vManage;
    private void Awake()
    {
        vManage = GameObject.Find("VolManage").GetComponent<VolManage>();
        this.GetComponent<Button>().onClick.AddListener(() => vManage.OpenVolIntro(this));
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
