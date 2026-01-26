using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Splines;

public class HandManager : MonoBehaviour
{
    [SerializeField] private int cardswitcher = 0;
    [SerializeField] private int maxHandSize = 5;
    [SerializeField] private List<GameObject> cardPrefab;
    [SerializeField] private SplineContainer splineContainer;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private List<GameObject> handCards = new();

    private void Update()
    {
        Keyboard kb = Keyboard.current;
        if (kb != null)
            if (kb.spaceKey.wasPressedThisFrame)
            {
                DrawCards();
            }
        DeleteOld();
        UpdateCardPositions();
    }
    public void DrawCards()
    {
        if (handCards.Count >= maxHandSize) return;
        GameObject g = Instantiate(cardPrefab[cardswitcher],spawnPoint.position, spawnPoint.rotation);
        handCards.Add(g);
        UpdateCardPositions();
        g.transform.SetParent(this.transform);
        cardswitcher++;
        if (cardswitcher > cardPrefab.Count - 1)
        {
            cardswitcher = 0;
        }
    }
    private void UpdateCardPositions()
    {
        DeleteOld();
        if (handCards.Count == 0) return;
        float CardSpacing = 1f / maxHandSize;
        float firstCardPosition = 0.5f - (handCards.Count - 1) * CardSpacing / 2;
        Spline spline = splineContainer.Spline;
        for (int i = 0; i < handCards.Count; i++)
        {
            float p = firstCardPosition + i * CardSpacing;
            Vector3 splinePosition = spline.EvaluatePosition(p);
            //Vector3 forward = spline.EvaluateTangent(p);
            //Vector3 up = spline.EvaluateUpVector(p);
            //Quaternion rotation = Quaternion.LookRotation(forward, up);
            //  Quaternion rotation = Quaternion.LookRotation(up,Vector3.Cross(up,forward).normalized);

            handCards[i].transform.DOMove(splinePosition, 0.5f);
            // handCards[i].transform.DORotateQuaternion(rotation, 0.5f);
        }
    }
    // Credits  to the code otter with the video " EASY CURVED Card Hand in Unity Using Splines"

    void DeleteOld()
    {
        for (var i = handCards.Count - 1; i > -1; i--)
        {
            if (handCards[i] == null)
            {
                handCards.RemoveAt(i);
            }
        }
    }

}
//  Quaternion rotation = Quaternion.LookRotation(up,Vector3.Cross(up,forward).normalized);