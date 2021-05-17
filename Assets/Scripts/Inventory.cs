using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int coinsCount;
    public Text coinsCountText;
    public static Inventory instance ;

    private void Awake()
    {
        if(instance != null){
          Debug.LogWarning("Il y a plus d'un inventaire");
          return ;
        }
        instance = this;
    }

    public void AddCoins(int count)
    {
       coinsCount += count;
       coinsCountText.text = coinsCount.ToString();
    }

    public void RemoveCoins(int count)
    {
       coinsCount -= count;
       coinsCountText.text = coinsCount.ToString();
    }
}
