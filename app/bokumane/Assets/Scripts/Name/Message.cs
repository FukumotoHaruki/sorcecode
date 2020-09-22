using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
    [SerializeField]
    private Text m_text = null;

    public void OnAddString(string i_string)
    {
        m_text.text += i_string;
    }

    public void OnDeleteString()
    {
        m_text.text = "";
    }
}
