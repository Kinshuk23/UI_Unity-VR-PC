using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour 
{

	private string filePath;
	public Text filePathText, test;
//	private string toRemove = "/Test_Build_Data";
	private string toRemove = "/ArmyUI_Data";


	void Start () 
	{
		//		tempPath = Application.dataPath;
		//		tempPathText.text = tempPath;
		filePath = Application.dataPath.Replace (toRemove, "");
//				filePathText.text = filePath;


	}

	public void OpenExeFunction(string str)
	{
		System.Diagnostics.Process.Start (filePath + str);
//		System.Diagnostics.Process.Start (test.ToString());

//		test.text = filePath + str;
		//		filePathText.text = System.Diagnostics.Process.Start (filePath + str).ToString();
	}

}
