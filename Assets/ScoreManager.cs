using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public GameObject Prefab;
    public Vector3 Position;
    public int score;
    public int vida;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        vida = 20;
        UpdateHudText();
        InvokeRepeating("SpawnObject", 2.0f, 2f);
    }

    public void AddScore(){
        score++;
        UpdateHudText();
    }

    public void LoseLife(){
        vida--;
        UpdateHudText();
    }

    public void UpdateHudText(){
        ScoreText.text = $"Vida: {vida}\nPontos: {score}";
    }

    public void SpawnObject(){
        var obj = Instantiate(Prefab);

        obj.transform.position = new Vector3(Random.Range(-260f,261f),Random.Range(0f,101f),0); //x: -260˜260 // y: 0˜100
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
