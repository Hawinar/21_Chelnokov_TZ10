using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private GameObject _obscacle;
    [SerializeField] private SpriteRenderer _sprite;
    void Start()
    {
        float z = Random.Range(-15, 15);
        _obscacle.transform.Rotate(new Vector3(0, 0, z));

        int id = Random.Range(0, 3);
        _sprite.color = GameManager.PlayerColors[id];
        _obscacle.gameObject.tag = $"Color{id}";
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag == _obscacle.gameObject.tag)
        {
            Debug.Log("Æèâ¸ì");
            GameManager.Score++;
            Debug.Log(GameManager.Score);
            Destroy(_obscacle.gameObject);
        }
        else
        {
            Debug.Log("ÃÃ");
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            if(GameManager.Score > GameManager.BestScore)
                GameManager.BestScore = GameManager.Score;
        }
    }
}
