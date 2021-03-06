﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Configuration")]

public class WaveConfig : ScriptableObject
{

    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spanRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float moveSpeed = 2f;

    public GameObject EnemyPrefab { get => enemyPrefab; set => enemyPrefab = value; }
    public GameObject PathPrefab { get => pathPrefab; set => pathPrefab = value; }
    public float TimeBetweenSpawns { get => timeBetweenSpawns; set => timeBetweenSpawns = value; }
    public float SpanRandomFactor { get => spanRandomFactor; set => spanRandomFactor = value; }
    public int NumberOfEnemies { get => numberOfEnemies; set => numberOfEnemies = value; }
    public float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }



}
