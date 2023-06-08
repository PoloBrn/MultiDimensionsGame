using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string characterName;
    [TextArea(3, 10)]
    public string message;
    public Texture2D characterImage;
}
