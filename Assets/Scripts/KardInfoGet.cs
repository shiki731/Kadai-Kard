using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class KardInfoGet : MonoBehaviour
{
    public static int MyKardNum;
    

    private KardScript _kardScript;
    [SerializeField] private KardScript Enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            Collider2D hit = Physics2D.OverlapPoint(worldPos);
            if (hit != null)
            {
                if (hit.CompareTag("Card"))
                {
                    
                    _kardScript = hit.gameObject.GetComponent<KardScript>();
                    MyKardNum = Mathf.Clamp(_kardScript.KardNum, 1, 13);
                    Debug.Log(_kardScript.KardNum);

                }
                else
                {
                    Debug.Log("bbb");
                }
            }

            if (MyKardNum == Enemy.KardNum)
            {
                _kardScript.CardDrow();
            }
            else if (MyKardNum + 1 == Enemy.KardNum)
            {
                Enemy.KardNum--;
                _kardScript.CardDrow();
            }
            else if (MyKardNum - 1 == Enemy.KardNum) // —á:MyCard 3 , Enemy 2
            {
                Enemy.KardNum++;
                _kardScript.CardDrow();
            }
            else if (MyKardNum == 1 && Enemy.KardNum == 13)
            {
                Enemy.KardNum = 1;
                _kardScript.CardDrow();
            }
            else if (MyKardNum == 13 && Enemy.KardNum == 1)
            {
                Enemy.KardNum = 13;
                _kardScript.CardDrow();
            }
            MyKardNum = 0;
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if(KardScript.deck[Enemy.KardNum - 1] <= 3)
            {
                KardScript.deck[Enemy.KardNum - 1]++;
                Enemy.CardDrow();
            }
            else
            {
                Enemy.CardDrow();
            }

                
        }
    }
}
