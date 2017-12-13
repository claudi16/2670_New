using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData {
	/*public float health = SVars.healthCounter;
	GameData(){}

	public const string DATA_NAME = "GameData";
	private static GameData instance;

	public static GameData Instance{
		get{
			if(instance == null){
				GetData();
			}return instance;
		}
	}

	public static void GetData(){
		if(string.IsNullOrEmpty(PlayerPrefs.GetString(DATA_NAME))){
			instance = new GameData();
		}else{
			instance = JsonUtility.FromJson<GameData>(PlayerPrefs.GetString(DATA_NAME));
		}
	}
	public static void SetData(){
		PlayerPrefs.SetString(DATA_NAME, JsonUtility.ToJson(instance));
	}
	public void SaveDataFromInstance(){
		PlayerPrefs.SetString(DATA_NAME, JsonUtiliy.ToJson(this));
	}*/
}
