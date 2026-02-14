using UnityEngine;

public class MouvementMeteoriteHaut : MonoBehaviour
{
    // Variables du script
    [Header("Taux de reduction des meteorites")]
    public float tauxReduction = 0.2f;
    
    [Header("Vitesse de Rotation des meteorites")]
    public float vitesseRotation = 0.5f;
    
    [Header("Positions maximales et minimales des meteorites sur l'axe des X")]
    public float positionXMin = -10f;
    public float positionXMax = 10f;

    [Header("Vitesses maximales et minimales des meteorites sur l'axe des Y")]
    public float vitesseYMax = 0.1f;
    public float vitesseYMin = 0.01f;

    //Vector2 = objet avec x et y;
    private Vector2 position;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*Position aleatoire des meteorites au debut de la partie*/
        float positionXInitiale = Random.Range(positionXMin, positionXMax);
        // Debug.Log(positionXInitiale);

        transform.position = new Vector2(positionXInitiale, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        /*Vitesse Aleatoire des meteorites*/
        float vitesseY = Random.Range(vitesseYMin, vitesseYMax);
        
        /*Deplacement vertical des meteorites*/
        transform.position = new Vector2(transform.position.x, transform.position.y + vitesseY);

        if (transform.position.y > 12f)
        {
            transform.position = new Vector2(transform.position.x, -12f);
        }

        /*Changement de taille des meteorites*/
        float nouvelleTaille = transform.localScale.x - tauxReduction;
        
        if (nouvelleTaille < 1 || nouvelleTaille > 3f)
        {
            tauxReduction *= -1f;
        }
        
        transform.localScale = new Vector2(nouvelleTaille, nouvelleTaille);

        /*Faire tourner les meteorites sur elles-memes*/
        transform.Rotate(0, 0, vitesseRotation);
    }
}
