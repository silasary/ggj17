using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Xml.Serialization;

public class GameManager : MonoBehaviour {

	public string dataPath;
	public string filePath;
	

	// Use this for initialization
	void Save() 
	{
		dataPath = Application.persistentDataPath;
		filePath = Path.Combine(dataPath, "savegame.xml");
		XmlSerializer serializer = new XmlSerializer(typeof(item[]), 
                                 new XmlRootAttribute() { ElementName = "items" });
		
	}

	//Load game from local storage.

	//Save game

}

public class item
{
    [XmlAttribute]
    public string key;
    [XmlAttribute]
    public string value;
}