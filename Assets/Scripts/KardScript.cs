using TMPro;
using UnityEngine;

public class KardScript : MonoBehaviour
{
    public static int[] deck;

    public int KardNum = 0;
    public TextMeshProUGUI KardNumIllust;

    private int CheckNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        deck = new int[13];
        for(int i = 0;i < 13; i++)
        {
            deck[i] = 4;
        }


        CardDrow();
    }

    // Update is called once per frame
    void Update()
    {
        KardNumIllust.text = KardNum.ToString();
    }

    public void CardDrow()
    {
        while (true)
        {
            //Debug.Log("AA");
            CheckNum = Random.Range(1, 14);
            if (deck[CheckNum - 1] > 0)
            {
                KardNum = CheckNum;
                deck[CheckNum - 1]--;

                // Debug.Log(KardNum);
                break;
            }
            else
            {
                
                Debug.Log("èdï°");
                return;
            }
        }
        
    }
}
