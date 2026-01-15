using DG.Tweening;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Splines;

public class HandManager : MonoBehaviour
{
    [SerializeField] private int maxHandSize = 5;
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private SplineContainer splineContainer;
    [SerializeField] private Transform spawnPoint;
    private List<GameObject> handCards = new();

    private void Update()
    {
    
            DrawCards();
    }
    private void DrawCards()
    {
        if (handCards.Count >= maxHandSize) return;
        GameObject g = Instantiate(cardPrefab, spawnPoint.position, spawnPoint.rotation);
        handCards.Add(g);
        UpdateCardPositions();
    }
    private void UpdateCardPositions()
    {
        if(handCards.Count == 0) return;
        float CardSpacing = 1f / maxHandSize;
        float firstCardPosition = 0.5f - (handCards.Count -1)* CardSpacing / 2;
        Spline spline = splineContainer.Spline;
        for (int i = 0; i < handCards.Count; i++)
        {
            float p = firstCardPosition + i * CardSpacing;
            Vector3 splinePosition = spline.EvaluatePosition(p);
            Vector3 forward = spline.EvaluateTangent(p);
            Vector3 up = spline.EvaluateUpVector(p);
            Quaternion rotation = Quaternion.LookRotation(up,Vector3.Cross(up,forward).normalized);
            handCards[i].transform.DOMove(splinePosition, 0.25f);
            handCards[i].transform.DORotateQuaternion(rotation, 0.25f);
        }
    }
    // Credits  to the code otter with the video " EASY CURVED Card Hand in Unity Using Splines"
}
