using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState {START, PLAYERTURN, ENEMYTURN, WON, LOST}
public enum WhatBattle {BANDITS, TEST}

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject banditPrefab;
    public GameObject testPrefab;

    public Transform playerSpawn;
    public Transform enemySpawn;
    public Transform enemySpawn2;
    public Transform enemySpawn3;

    public Text currentPhaseText;

    Unit playerUnit;
    Unit enemyUnitOne;
    Unit enemyUnitTwo;
    Unit enemyUnitThree;


    public BattleState state;
    public WhatBattle whatBattle;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        whatBattle = WhatBattle.BANDITS;
        currentPhaseText.text = "Start of Game";
        StartCoroutine(setupBattle());
    }

    IEnumerator setupBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerSpawn);
        playerUnit = playerGO.GetComponent<Unit>();

        if (whatBattle == WhatBattle.BANDITS)
        {
            GameObject banditOneGO = Instantiate(banditPrefab, enemySpawn);
            enemyUnitOne = banditOneGO.GetComponent<Unit>();

            GameObject banditTwoGO = Instantiate(banditPrefab, enemySpawn2);
            enemyUnitTwo = banditTwoGO.GetComponent<Unit>();
        } else if (whatBattle == WhatBattle.TEST)
        {
            GameObject testOneGO = Instantiate(testPrefab, enemySpawn2);
            enemyUnitOne = testOneGO.GetComponent<Unit>();

            GameObject testTwoGO = Instantiate(testPrefab, enemySpawn3);
            enemyUnitTwo = testTwoGO.GetComponent<Unit>();
        }

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        currentPhaseText.text = "Player Turn";
    }
}
