using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    bool panel = false;
    bool button = true;
    bool main_panel = false;

    public GameObject panel_select;
    public GameObject button_diwali;
    public GameObject button_christmas;
    public GameObject main_panell;


    // for hiding/showing main panel on click/again click
    public void main_panelll()
    {
        main_panel = !main_panel;
        main_panell.SetActive(main_panel);

    }

    public void panel_main()
    {
        //for hiding/showing movement panel on click/again click 
        panel = !panel;
        panel_select.SetActive(panel);

        //hide/show diwali and christmas button on clicking on movement button
       //button = !button;
        //button_diwali.SetActive(button);
        //button_christmas.SetActive(button);
    }
   

}
