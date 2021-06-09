﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fruits
{
    public class FruitPickerGameManager : ModeSystemGameManager
    {
        [SerializeField] private FrutalTree tree; 
        public override string Name => throw new System.NotImplementedException();

        public object TimeSpawnGap { get; internal set; }
        public int SpawnRate { get; internal set; }
        public float SelfDestructionTime { get; internal set; }

        public override void EndGame()
        {
            throw new System.NotImplementedException();
        }

        public override void StartGame()
        {
            throw new System.NotImplementedException();
        }

        public FruitSpawner SelectRandomFruit()
        {
            return tree.SelectRandomFruit();
        }
    }
}