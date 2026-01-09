using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Scriptable Objects/Card")]
public class Card : ScriptableObject
{
    public new string CardName;
    public Image Artwork;
}
