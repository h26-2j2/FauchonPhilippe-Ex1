using UnityEngine;

public class RotationStarDestroyer : MonoBehaviour
{
    [Header("Vitesse de Rotation des Star-destroyer")]
    public float vitesseRotation = 0.1f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*Rotation des star-destroyer*/
        transform.Rotate(0, 0, vitesseRotation);
    }
}
