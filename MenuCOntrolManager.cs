using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject optionPanel;
    public GameObject topPanel,middlePANEL;
    public void OptionsMenu()
    {
        optionPanel.SetActive(true);
        topPanel.SetActive(false);
        middlePANEL.SetActive(false);
    }
    public void Back()
    {
        optionPanel.SetActive(false);
        topPanel.SetActive(true);
        middlePANEL.SetActive(true);
    }
}
