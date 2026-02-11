using UnityEngine;

public class MouvementMeteorite : MonoBehaviour
{
    // Variables du script
    public float vitesseY;

    public float tauxReduction = 0.01f;

    //Vector2 = objet avec x et y;
    private Vector2 position;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { }

    // Update is called once per frame
    void Update()
    {
        /*Deplacement lateral des meteorites*/
        transform.position = new Vector2(transform.position.x, transform.position.y - vitesseY);

        if (transform.position.y < -12f)
        {
            transform.position = new Vector2(transform.position.x, 12f);
        }

        /*Changement de taille des meteorites*/
        float nouvelleTaille = transform.localScale.x - tauxReduction;
        transform.localScale = new Vector3(nouvelleTaille, nouvelleTaille, nouvelleTaille);
    }
}
