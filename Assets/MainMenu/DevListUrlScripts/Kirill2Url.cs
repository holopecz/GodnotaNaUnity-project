
using UnityEngine;

public class Kirill2Url : MonoBehaviour
{
    public string url;
    public void Open()
    {
        Application.OpenURL(url);
    }
}
