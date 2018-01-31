using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TestingEditorWindow : Editor
{
	[MenuItem("Tools/AutoEditorPrefs/SetTestData")]
	public static void SetTestData()
	{
		AutoEditorPrefs.SetBool("test", true);
		AutoEditorPrefs.SetInt("test", 1);
		AutoEditorPrefs.SetFloat("test", 1.0f);
		AutoEditorPrefs.SetString("test", "test string");
	}

	[MenuItem("Tools/AutoEditorPrefs/GetTestData")]
	public static void GetTestData()
	{
		Debug.Log(AutoEditorPrefs.GetBool("test"));
		Debug.Log(AutoEditorPrefs.GetInt("test"));
		Debug.Log(AutoEditorPrefs.GetFloat("test"));
		Debug.Log(AutoEditorPrefs.GetString("test"));
	}

	[MenuItem("Tools/AutoEditorPrefs/DeleteTestData")]
	public static void DeleteTestData()
	{
		AutoEditorPrefs.DeleteBool("test");
		AutoEditorPrefs.DeleteInt("test");
		AutoEditorPrefs.DeleteFloat("test");
		AutoEditorPrefs.DeleteString("test");
	}
}
