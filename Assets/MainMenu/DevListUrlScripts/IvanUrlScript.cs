
using UnityEngine;

public class IvanUrlScript : MonoBehaviour
{
    public string url;
    public void Open()
    {
        Application.OpenURL(url);
    }
}
