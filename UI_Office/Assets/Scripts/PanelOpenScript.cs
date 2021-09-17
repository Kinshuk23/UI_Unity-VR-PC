using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpenScript : MonoBehaviour
{

    public GameObject mainPanel, familiarizationPanel, CMCPanel, DesertPanel;
	public GameObject SnowPanel, ForestPanel, CCTPanel;
	private bool _isActive, _DisActive, _FisActive;
    
    

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

    public void MainBackFun()
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

	public void DesertOpenFun()
	{
		CMCPanel.SetActive(false);
		DesertPanel.SetActive(true);
		_DisActive = true;
	}

	public void ForestOpenFun()
	{
		CMCPanel.SetActive(false);
		ForestPanel.SetActive(true);
		_FisActive = true;
	}

	public void SnowOpenFun()
	{
		CMCPanel.SetActive(false);
		SnowPanel.SetActive(true);
	}

	public void CMCOpBackFunc()
	{
		if(_DisActive == true)
		{
			_DisActive = false;
			CMCPanel.SetActive(true);
			DesertPanel.SetActive(false);
		}
		else if(_FisActive == true)
		{
			_FisActive = false;
			CMCPanel.SetActive(true);
			ForestPanel.SetActive(false);
		}
		else
		{
			CMCPanel.SetActive(true);
			SnowPanel.SetActive(false);
		}
	}

	public void CCTOpenFunc()
	{
		familiarizationPanel.SetActive(false);
		CCTPanel.SetActive(true);
	}

	public void CCTBackFunc()
	{
		familiarizationPanel.SetActive(true);
		CCTPanel.SetActive(false);
	}

}
