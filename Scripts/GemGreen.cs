using UnityEngine;
using UnityEngine.UI;

public class GemGreen : MonoBehaviour
{
    //public GameObject scoreBox;           // L'objet contenant le texte du score
    public AudioSource collectSound;      // Le son joué à la collecte
    private int score = 5000;             // Score que cette gemme ajoute

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //// Récupérer le score actuel dans le Text
            //Text scoreText = scoreBox.GetComponent<Text>();
            ////print("score original :" + scoreText.text);
            //int currentScore = int.Parse(scoreText.text);

            //// Ajouter le score de la gemme
            //int newScore = currentScore + score;

            //// Mettre à jour l'affichage du score
            //scoreText.text = newScore.ToString();
            ////print("score apres modification :" + scoreText.text);
            // Jouer le son

            GlobalScore.current += score;
            collectSound.Play();

            // Détruire la gemme
            Destroy(gameObject);
        }
    }
}
