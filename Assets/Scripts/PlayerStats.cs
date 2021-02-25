using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int m_gold = 0;
    public int m_bank = 100;

    public int m_tapLevel = 1;
    public int m_baseTapPoints = 1;

    public int m_bugLevel = 1;
    public float m_bugBonus = 1.0f;


    /// <summary>
    /// Increases the player's gold up to their current maximum allowed.
    /// Will not deal with a negative value.
    /// </summary>
    /// <param name="gold">The amount of gold to receive.</param>
    /// <returns>True if no excess gold, false if any excess gold.</returns>
    public bool ReceiveGold(int gold)
    {
        bool result = gold < 0;
        
        if (!result)
        {
            m_gold += gold;
            result = m_gold <= m_bank;
            if (!result) m_gold = m_bank;
        }

        return result;
    }

    public void TapEnemy()
    {
        int goldObtained = (int)(m_baseTapPoints * m_bugBonus);
        ReceiveGold(goldObtained);
    }
}
