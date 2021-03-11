using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    /* Power Index
     * 0 >> Bank // Cost = Bank * 0.75 || Increase = Bank + (Bank / 10)^2
     * 1 >> Tap // Cost = (Tap Level + 4)^2 || Increase = Tap + 2
     * 2 >> Bug // Cost = (Tap Level + 4)^2 || Increase = Bug + 0.5
     * 3 >> Shake // Cost = (Tap Level + 4)^3 || Increase = Shake + 1
    */

    [SerializeField] public PlayerStats m_workingPlayer;
    
    // True if able to purchase, false if not.
    public void PurchasePowerUp(int powerIndex)
    {
        bool result = false;

        switch (powerIndex)
        {
            case 0:
                result = BankUp();
                break;
            case 1:
                result = TapUp();
                break;
            case 2:
                result = BugUp();
                break;
            default:
                break;
        }

        //return result;
    }

    private bool BankUp()
    {
        bool result = false;
        int cost = (int)(m_workingPlayer.m_bank * 0.75f);
        if (cost <= m_workingPlayer.m_gold)
        {
            result = true;
            m_workingPlayer.m_bank += (m_workingPlayer.m_bank / 10)^2;
            m_workingPlayer.m_gold -= cost;
        }
        return result;
    }

    private bool TapUp()
    { 
        bool result = false;
        int cost = (m_workingPlayer.m_tapLevel + 4)^2;
        if (cost <= m_workingPlayer.m_gold)
        {
            result = true;
            m_workingPlayer.m_baseTapPoints += 2;
            m_workingPlayer.m_gold -= cost;
            m_workingPlayer.m_tapLevel++;
        }
        return result;
    }

    private bool BugUp()
    {
        bool result = false;
        int cost = (m_workingPlayer.m_tapLevel + 4) ^ 2;
        if (cost <= m_workingPlayer.m_gold)
        {
            result = true;
            m_workingPlayer.m_bugBonus += 0.5f;
            m_workingPlayer.m_gold -= cost;
            m_workingPlayer.m_bugLevel++;
        }
        return result;
    }
}
