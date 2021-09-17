using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneOpenScript : MonoBehaviour
{
	private string filePath;
	// public Text pathText;
	//	string textToRemove = "/ArmyUI_Data";
	private string toRemove = "/ArmyUI_Data";

	//  string DesertPath = "/Builds/Desert/GunshotChest/GunshotChest.exe";
	// Start is called before the first frame update
	void Start()
	{
		//filePath = "D:/Army";
		filePath = Application.dataPath.Replace (toRemove, "");
		//D:/ Army / FinalBuilds / Categorised_Army_Final_Builds / CMC / Desert

		///FinalBuilds/Categorised_Army_Final_Builds/CMC/Desert/Desert Control of Bleeding
		//filePath = Application.dataPath;
		//  E:/VR_CMC/VR_CMCDrills/
		// pathText.text = filePath.Replace(textToRemove,"");

		//C:/Users/enrg/AppData/LocalLow/DefaultCompany/ArmyUI prese data path
		//D:/kinshuk/UI_Office/Assets data path
		//D:\ArmyTest\MainMenu\ArmyUI_Data\Builds\Desert\GunshotChest
	}

	// Update is called once per frame
	void Update()
	{
		//if (Input.GetKeyDown(KeyCode.A))
		//{
		//    System.Diagnostics.Process.Start(filePath+ DesertPath);
		//    System.Diagnostics.Process.Start(filePath.Replace(textToRemove,"") + DesertPath);



		//}

	}

	public void OpenClickedExe(string str)
	{

		System.Diagnostics.Process.Start(filePath + str);
		// System.Diagnostics.Process.Start(filePath.Replace(textToRemove, "") + DesertPath);
		//System.Diagnostics.Process.Start(Application.dataPath + "/RacingPlanet2Launch.exe");
	}
}
