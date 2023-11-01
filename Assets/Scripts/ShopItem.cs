using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private List<Color> colorList;
    [SerializeField] private Button product;
    void Start()
    {
        product.onClick.AddListener(() => Interact());
    }
    private void Interact()
    {
        GameManager.PlayerColors = colorList;
    }
}
