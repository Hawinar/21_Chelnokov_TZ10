using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _rotation;
    [SerializeField] private Camera _camera;

    //[SerializeField] private GameObject _effect;

    [SerializeField] private SpriteRenderer _spriteRendererTop;
    [SerializeField] private SpriteRenderer _spriteRendererLeft;
    [SerializeField] private SpriteRenderer _spriteRendererRight;
    void Start()
    {
        if (GameManager.PlayerColors.Count > 0)
        {
            _spriteRendererTop.color = GameManager.PlayerColors[0];
            _spriteRendererLeft.color = GameManager.PlayerColors[1];
            _spriteRendererRight.color = GameManager.PlayerColors[2];

            _camera.backgroundColor = GameManager.PlayerColors[3];
        }
        else
        {
            GameManager.PlayerColors.Add(_spriteRendererTop.color);
            GameManager.PlayerColors.Add(_spriteRendererLeft.color);
            GameManager.PlayerColors.Add(_spriteRendererRight.color);
            GameManager.PlayerColors.Add(_camera.backgroundColor);
        }
    }
    private void Update()
    {
        _rotation = Input.GetAxis("Horizontal") * _rotateSpeed * Time.deltaTime;
    }
    private void LateUpdate()
    {
        transform.Rotate(0f, 0f, _rotation);
    }
    private void OnDestroy()
    {
        //Instantiate(_effect, new Vector3(0,5,0), new Quaternion(0, 0, 0, 0));
    }
}
