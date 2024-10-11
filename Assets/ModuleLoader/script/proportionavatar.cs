using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustAvatarDimensions : MonoBehaviour
{
    // Articulații pentru ajustări
    public Transform headBone;
    public Transform leftUpperArm;
    public Transform rightUpperArm;
    public Transform leftUpperLeg;
    public Transform rightUpperLeg;

    // Factori de ajustare
    public float headScaleFactor = 1.2f;
    public float armLengthFactor = 1.2f;
    public float legLengthFactor = 1.3f;
    public float heightFactor = 1.0f;

    void Start()
    {
        // Inițial ajustează avatarul
        UpdateAvatarDimensions();
    }

    // Funcție care ajustează dimensiunile avatarului pe baza factorilor
    public void UpdateAvatarDimensions()
    {
        // Ajustarea dimensiunii capului
        headBone.localScale = new Vector3(headScaleFactor, headScaleFactor, headScaleFactor);

        // Ajustarea lungimii brațelor
        leftUpperArm.localScale = new Vector3(1, armLengthFactor, 1);
        rightUpperArm.localScale = new Vector3(1, armLengthFactor, 1);

        // Ajustarea lungimii picioarelor
        leftUpperLeg.localScale = new Vector3(1, legLengthFactor, 1);
        rightUpperLeg.localScale = new Vector3(1, legLengthFactor, 1);

        // Ajustarea înălțimii generale
        Vector3 newScale = new Vector3(heightFactor, heightFactor, heightFactor);
        transform.localScale = newScale;
    }
}
