using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject panel;


    public void openPanel()
    {

        //Time.timeScale = 0;

        if (panel != null)
        {
            bool isActive = panel.activeSelf; //panel is active
            panel.SetActive(!isActive); //panel is false and active
            Time.timeScale = isActive ? 1 : 0; // set time.timescale based on if the panel is active, use time.timescale when panel is active, 1 is assigned to true, 0 to false
        }
        else
        {
            panel = null;
            Time.timeScale = 1;// current scene without the panel being active

        }
    }
}
