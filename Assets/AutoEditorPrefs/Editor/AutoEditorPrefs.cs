using UnityEditor;
using UnityEngine;
using System.IO;

[InitializeOnLoad]
public static class AutoEditorPrefs
{
	static AutoEditorPrefsScriptableObject m_cAutoEditorPrefsScriptableObject = null;

	static AutoEditorPrefs()
	{
		if (m_cAutoEditorPrefsScriptableObject == null)
		{
			string[] astrAutoEditorPrefsScriptableObjectGuids = AssetDatabase.FindAssets("t:AutoEditorPrefsScriptableObject");

			if (astrAutoEditorPrefsScriptableObjectGuids.Length > 0)
			{
				string strAutoEditorPrefsScriptableObjectPath = AssetDatabase.GUIDToAssetPath(astrAutoEditorPrefsScriptableObjectGuids[0]);

				m_cAutoEditorPrefsScriptableObject = AssetDatabase.LoadAssetAtPath<AutoEditorPrefsScriptableObject>(strAutoEditorPrefsScriptableObjectPath);
			}
			else
			{
				m_cAutoEditorPrefsScriptableObject = ScriptableObject.CreateInstance<AutoEditorPrefsScriptableObject>();

				Directory.CreateDirectory(Application.dataPath + "/AutoEditorPrefs/Settings/");

				AssetDatabase.CreateAsset(m_cAutoEditorPrefsScriptableObject, "Assets/AutoEditorPrefs/Settings/AutoEditorPrefsScriptableObject.asset");
				AssetDatabase.SaveAssets();
			}
		}
	}

	static void SaveAutoEditorPrefsScriptableObject()
	{
		EditorUtility.SetDirty(m_cAutoEditorPrefsScriptableObject);
		AssetDatabase.SaveAssets();
	}

	public static void SetBool(string strKey, bool bValue)
	{
		m_cAutoEditorPrefsScriptableObject.SetBool(strKey, bValue);
		SaveAutoEditorPrefsScriptableObject();
	}

	public static bool GetBool(string strKey)
	{
		return m_cAutoEditorPrefsScriptableObject.GetBool(strKey);
	}

	public static void DeleteBool(string strKey)
	{
		m_cAutoEditorPrefsScriptableObject.DeleteBool(strKey);
		SaveAutoEditorPrefsScriptableObject();
	}

	public static void SetInt(string strKey, int nValue)
	{
		m_cAutoEditorPrefsScriptableObject.SetInt(strKey, nValue);
		SaveAutoEditorPrefsScriptableObject();
	}

	public static int GetInt(string strKey)
	{
		return m_cAutoEditorPrefsScriptableObject.GetInt(strKey);
	}

	public static void DeleteInt(string strKey)
	{
		m_cAutoEditorPrefsScriptableObject.DeleteInt(strKey);
		SaveAutoEditorPrefsScriptableObject();
	}

	public static void SetFloat(string strKey, float fValue)
	{
		m_cAutoEditorPrefsScriptableObject.SetFloat(strKey, fValue);
		SaveAutoEditorPrefsScriptableObject();
	}

	public static float GetFloat(string strKey)
	{
		return m_cAutoEditorPrefsScriptableObject.GetFloat(strKey);
	}

	public static void DeleteFloat(string strKey)
	{
		m_cAutoEditorPrefsScriptableObject.DeleteFloat(strKey);
		SaveAutoEditorPrefsScriptableObject();
	}

	public static void SetString(string strKey, string strValue)
	{
		m_cAutoEditorPrefsScriptableObject.SetString(strKey, strValue);
		SaveAutoEditorPrefsScriptableObject();
	}

	public static string GetString(string strKey)
	{
		return m_cAutoEditorPrefsScriptableObject.GetString(strKey);
	}

	public static void DeleteString(string strKey)
	{
		m_cAutoEditorPrefsScriptableObject.DeleteString(strKey);
		SaveAutoEditorPrefsScriptableObject();
	}
}
