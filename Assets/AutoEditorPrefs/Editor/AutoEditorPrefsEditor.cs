using UnityEditor;
using UnityEngine;
using System.IO;

[InitializeOnLoad]
public static class AutoEditorPrefsEditor
{
	public static AutoEditorPrefsScriptableObject m_cAutoEditorPrefsScriptableObject = null;

	static AutoEditorPrefsEditor()
	{
		if (m_cAutoEditorPrefsScriptableObject == null)
		{
			string[] astrAutoEditorPrefsScriptableObjectPaths = AssetDatabase.FindAssets("t:AutoEditorPrefsScriptableObject");

			if (astrAutoEditorPrefsScriptableObjectPaths.Length > 0)
			{
				m_cAutoEditorPrefsScriptableObject = AssetDatabase.LoadAssetAtPath<AutoEditorPrefsScriptableObject>(astrAutoEditorPrefsScriptableObjectPaths[0]);
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
}
