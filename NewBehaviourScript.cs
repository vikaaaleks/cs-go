using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject image;
    static int money = 0;
    static int bullet = 30;
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI bulletText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Destroy(image);
        Destroy(gameObject);
        money = money + 300;
        moneyText.text = "$" + money ;
        bullet = bullet - 1;
        bulletText.text = bullet + "";
    }
}
