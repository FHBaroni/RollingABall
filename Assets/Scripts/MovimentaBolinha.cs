using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class MovimentaBolinha : MonoBehaviour
{
    private float speed = 2;
    private Rigidbody rb;
    public GameObject paticulaItem;
    public Text textScore;
    public Text finalText;
    public int score;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.AddForce(move * speed);
        textScore.text = "Score: " + score.ToString();
        finalText.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            Instantiate(paticulaItem, other.gameObject.transform.position, Quaternion.identity);
            ScorePonctuation();
        }
    }
    void ScorePonctuation()
    {
        score++;
        textScore.text = "Score: " + score.ToString();
        if (score == 8)
        {
            finalText.text = "You Win!!!";
        }
    }
}
