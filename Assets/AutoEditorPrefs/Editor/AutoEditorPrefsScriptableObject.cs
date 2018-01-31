using UnityEngine;
using System.Collections.Generic;

public class AutoEditorPrefsScriptableObject : ScriptableObject
{
	Dictionary<string, bool> m_dictBools = new Dictionary<string, bool>();
	Dictionary<string, int> m_dictInts = new Dictionary<string, int>();
	Dictionary<string, float> m_dictFloats = new Dictionary<string, float>();
	Dictionary<string, string> m_dictStrings = new Dictionary<string, string>();

	public void SetBool(string strKey, bool bValue)
	{
		if (!m_dictBools.ContainsKey(strKey))
		{
			m_dictBools.Add(strKey, bValue);
		}
		else
		{
			m_dictBools[strKey] = bValue;
		}
	}

	public bool GetBool(string strKey)
	{
		if (m_dictBools.ContainsKey(strKey))
		{
			return m_dictBools[strKey];
		}

		return false;
	}

	public void DeleteBool(string strKey)
	{
		if (m_dictBools.ContainsKey(strKey))
		{
			m_dictBools.Remove(strKey);
		}
	}

	public void SetInt(string strKey, int nValue)
	{
		if (!m_dictInts.ContainsKey(strKey))
		{
			m_dictInts.Add(strKey, nValue);
		}
		else
		{
			m_dictInts[strKey] = nValue;
		}
	}

	public int GetInt(string strKey)
	{
		if (m_dictInts.ContainsKey(strKey))
		{
			return m_dictInts[strKey];
		}

		return 0;
	}

	public void DeleteInt(string strKey)
	{
		if (m_dictInts.ContainsKey(strKey))
		{
			m_dictInts.Remove(strKey);
		}
	}

	public void SetFloat(string strKey, float fValue)
	{
		if (!m_dictFloats.ContainsKey(strKey))
		{
			m_dictFloats.Add(strKey, fValue);
		}
		else
		{
			m_dictFloats[strKey] = fValue;
		}
	}

	public float GetFloat(string strKey)
	{
		if (m_dictFloats.ContainsKey(strKey))
		{
			return m_dictFloats[strKey];
		}

		return 0.0f;
	}

	public void DeleteFloat(string strKey)
	{
		if (m_dictFloats.ContainsKey(strKey))
		{
			m_dictFloats.Remove(strKey);
		}
	}

	public void SetString(string strKey, string strValue)
	{
		if (!m_dictStrings.ContainsKey(strKey))
		{
			m_dictStrings.Add(strKey, strValue);
		}
		else
		{
			m_dictStrings[strKey] = strValue;
		}
	}

	public string GetString(string strKey)
	{
		if (m_dictStrings.ContainsKey(strKey))
		{
			return m_dictStrings[strKey];
		}

		return string.Empty;
	}

	public void DeleteString(string strKey)
	{
		if (m_dictStrings.ContainsKey(strKey))
		{
			m_dictStrings.Remove(strKey);
		}
	}
}
