using GoogleARCore.Examples.AugmentedFaces;
using UnityEngine;

/// <summary>
/// Face mesh properties
/// </summary>

[RequireComponent(typeof(ARCoreAugmentedFaceMeshFilter))]
public class FaceOrientation : MonoBehaviour
{
    private Transform facefilterTransform;

    private void Awake()
    {
        facefilterTransform = GetComponent<Transform>();
    }

    //Returns face orientation in X axis
    public float GetFaceOrientation_Xasxis()
    {
        return facefilterTransform.eulerAngles.x;
    }
}
