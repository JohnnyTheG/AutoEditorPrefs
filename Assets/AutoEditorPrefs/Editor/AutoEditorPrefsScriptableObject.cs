using UnityEngine;
using System.Collections.Generic;

public class AutoEditorPrefsScriptableObject : ScriptableObject
{
	[SerializeField]
	List<string> m_lstBoolKeys = new List<string>();
	[SerializeField]
	List<bool> m_lstBoolValues = new List<bool>();

	[SerializeField]
	List<string> m_lstIntKeys = new List<string>();
	[SerializeField]
	List<int> m_lstIntValues = new List<int>();

	[SerializeField]
	List<string> m_lstFloatKeys = new List<string>();
	[SerializeField]
	List<float> m_lstFloatValues = new List<float>();

	[SerializeField]
	List<string> m_lstStringKeys = new List<string>();
	[SerializeField]
	List<string> m_lstStringValues = new List<string>();

	public void SetBool(string strKey, bool bValue)
	{
		if (!m_lstBoolKeys.Contains(strKey))
		{
			m_lstBoolKeys.Add(strKey);
		}

		m_lstBoolValues.Add(bValue);
	}

	public bool GetBool(string strKey)
	{
		if (m_lstBoolKeys.Contains(strKey))
		{
			int nIndex = m_lstBoolKeys.IndexOf(strKey);

			return m_lstBoolValues[nIndex];
		}

		return false;
	}

	public void DeleteBool(string strKey)
	{
		if (m_lstBoolKeys.Contains(strKey))
		{
			int nIndex = m_lstBoolKeys.IndexOf(strKey);

			m_lstBoolKeys.RemoveAt(nIndex);
			m_lstBoolValues.RemoveAt(nIndex);
		}
	}

	public void SetInt(string strKey, int nValue)
	{
		if (!m_lstIntKeys.Contains(strKey))
		{
			m_lstIntKeys.Add(strKey);
		}

		m_lstIntValues.Add(nValue);
	}

	public int GetInt(string strKey)
	{
		if (m_lstIntKeys.Contains(strKey))
		{
			int nIndex = m_lstIntKeys.IndexOf(strKey);

			return m_lstIntValues[nIndex];
		}

		return 0;
	}

	public void DeleteInt(string strKey)
	{
		if (m_lstIntKeys.Contains(strKey))
		{
			int nIndex = m_lstIntKeys.IndexOf(strKey);

			m_lstIntKeys.RemoveAt(nIndex);
			m_lstIntValues.RemoveAt(nIndex);
		}
	}

	public void SetFloat(string strKey, float fValue)
	{
		if (!m_lstFloatKeys.Contains(strKey))
		{
			m_lstFloatKeys.Add(strKey);
		}

		m_lstFloatValues.Add(fValue);
	}

	public float GetFloat(string strKey)
	{
		if (m_lstFloatKeys.Contains(strKey))
		{
			int nIndex = m_lstFloatKeys.IndexOf(strKey);

			return m_lstFloatValues[nIndex];
		}

		return 0.0f;
	}

	public void DeleteFloat(string strKey)
	{
		if (m_lstFloatKeys.Contains(strKey))
		{
			int nIndex = m_lstFloatKeys.IndexOf(strKey);

			m_lstFloatKeys.RemoveAt(nIndex);
			m_lstFloatValues.RemoveAt(nIndex);
		}
	}

	public void SetString(string strKey, string strValue)
	{
		if (!m_lstStringKeys.Contains(strKey))
		{
			m_lstStringKeys.Add(strKey);
		}

		m_lstStringValues.Add(strValue);
	}

	public string GetString(string strKey)
	{
		if (m_lstStringKeys.Contains(strKey))
		{
			int nIndex = m_lstStringKeys.IndexOf(strKey);

			return m_lstStringValues[nIndex];
		}

		return string.Empty;
	}

	public void DeleteString(string strKey)
	{
		if (m_lstStringKeys.Contains(strKey))
		{
			int nIndex = m_lstStringKeys.IndexOf(strKey);

			m_lstStringKeys.RemoveAt(nIndex);
			m_lstStringValues.RemoveAt(nIndex);
		}
	}
}
