using Unity.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public enum GemColor { GreenGem, SilverGem }

public class GemSilver : MonoBehaviour
{
    //public GameObject scoreBox;           // L'objet contenant le texte du score
    public AudioSource collectSound;      // Le son joué à la collecte
    private int score = 0;             // Score que cette gemme ajoute

    private GemColor gemColor;

    void Update()
    {
        string colorGem = gameObject.name;
        
        int count = LengthText(colorGem);

        colorGem = ShortentheText(colorGem, count);

        if (colorGem == "GreGem")
        {
            gemColor = GemColor.GreenGem;
            score = 5000;
        }
        else if (colorGem == "SilGem")
        {
            gemColor = GemColor.SilverGem;
            score = 1000;
        }
        else
        {
            Debug.LogWarning("Nom de gemme non reconnu : " + colorGem);
            // Tu peux mettre un score par défaut si besoin
            score = 0;
        }
    }

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

    private int LengthText(string text) { 
        string countText = text;
        int length = countText.Length;
        //Debug.Log("La longueur du texte est : " + length);
        return length;
    }

    private string ShortentheText(string text , int length) {
        if (length != 6)
        {
            //commence de l'index zero , la longeir du string 
            return text.Substring(0, 6);
        }
        else { 
         return text;
        }
    
    }

}
