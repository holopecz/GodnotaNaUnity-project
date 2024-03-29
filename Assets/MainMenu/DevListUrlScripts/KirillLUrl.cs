using UnityEngine;

public class KirillLUrl : MonoBehaviour
{
    public string url;
    public void Open()
    {
        Application.OpenURL(url);
    }
}
