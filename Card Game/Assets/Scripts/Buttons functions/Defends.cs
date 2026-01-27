using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Defends : Button
{
    protected float DefenceValue = 0.3f;
    public void Addefence()
    {
        gameManger.Damages = DefenceValue * gameManger.Damages;
        base.Nexturn();
    }
}
