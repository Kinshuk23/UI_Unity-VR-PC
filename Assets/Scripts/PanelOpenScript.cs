using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpenScript : MonoBehaviour
{

    public GameObject mainPanel, familiarizationPanel, CMCPanel;
    private bool _isActive;
    
    

    public void FamiliarizationOpFun()
    {
        mainPanel.SetActive(false);
        familiarizationPanel.SetActive(true);
        _isActive = true;
    }

    public void CMCOpFun()
    {
        mainPanel.SetActive(false);
        CMCPanel.SetActive(true);
    }

    public void BackFun()
    {
        if (_isActive == true)
        {
            _isActive = false;
            mainPanel.SetActive(true);
            familiarizationPanel.SetActive(false);
        }
        else
        {
            mainPanel.SetActive(true);
            CMCPanel.SetActive(false);
        }
    }
}
