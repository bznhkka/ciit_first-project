using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI storytextMeshPro, hptextMeshPro,staminatextMeshPro;
    public string storyText;
    public int hp_value;
    public int sta_val;
    public GameObject lvl1choice, hpobject, staobject, title, startobject, exitobject, mainmenu, storytext;

    // Start is called before the first frame update
    void Start()
    {
        storytextMeshPro.text = storyText;
    }

    // Update is called once per frame
    void Update()
    {
        storytextMeshPro.text = storyText;
        hptextMeshPro.text = hp_value.ToString();
        staminatextMeshPro.text = sta_val.ToString();
    }

    public void meow_na_green()
    {
        storyText = "omg kolay green";
        hp_value = 10;
        
    }

    public void meow_na_red() 
    {
        storyText = "aray q";
        hp_value = 5;
    }

    public void meow_na_blue() 
    {
        storyText = "may anim n bohai k p nman";
        hp_value = 0;
        lvl1choice.SetActive(false);
    }

    public void StartGame () 
    {
        hpobject.SetActive(true);
        staobject.SetActive(true);
        lvl1choice.SetActive(true);
        mainmenu.SetActive(false) ;
        storytext.SetActive(true);
        title.SetActive(false);
       
    }
    public void ExitGame ()
    {
        Application.Quit();
    }
}
