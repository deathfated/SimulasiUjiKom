using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.MatchPicture.Gameplay
{
    public class TileGroup : MonoBehaviour
    {
        GameObject tile;
        GameObject gameFlow;
        List<int> tileIndexes = new List<int> { 0, 1, 2, 3, 4, 0, 1, 2, 3, 4,
                                                5, 6, 7, 8, 9, 5, 6, 7, 8, 9,
                                                10, 11, 12, 13, 14, 10, 11, 12, 13, 14 }; /*,
                                                15, 16, 17, 18, 19, 15, 16, 17, 18, 19,
                                                20, 21, 22, 23, 24, 20, 21, 22, 23, 24,
                                                25, 26, 27, 28, 29, 25, 26, 27, 28, 29};*/
        
        public static System.Random rnd = new System.Random();
        public int shuffleNum = 0;
        int[] visibleTiles = { -1, -2 };

        public event System.Action TilesCleared;
        private int _tilesClearedCounter;
        public bool _isWin = false;

        private void Start()
        {
            int originalLength = tileIndexes.Count;
            float yPosition = 1.5f;
            float xPosition = -1.0f;

            _tilesClearedCounter = 0;

            for (int i = 0; i < 29; i++)
            {
                shuffleNum = rnd.Next(0, (tileIndexes.Count));
                var t = Instantiate(tile, new Vector3(
                    xPosition, yPosition, 0),
                    Quaternion.identity);

                t.GetComponent<Tile>().spriteIndex = tileIndexes[shuffleNum];
                tileIndexes.Remove(tileIndexes[shuffleNum]);

                xPosition++;

                if(i == 3)
                {
                    yPosition = 0.5f;
                    xPosition = -2.0f;
                }

                if (i == 8)
                {
                    yPosition = -0.5f;
                    xPosition = -2.0f;
                }

                if (i == 13)
                {
                    yPosition = -1.5f;
                    xPosition = -2.0f;
                }

                if (i == 18)
                {
                    yPosition = -2.5f;
                    xPosition = -2.0f;
                }

                if (i == 23)
                {
                    yPosition = -3.5f;
                    xPosition = -2.0f;
                }
            }
            tile.GetComponent<Tile>().spriteIndex = tileIndexes[0];
        }

        public bool TwoSelected()
        {
            bool tilesUp = false;
            if(visibleTiles[0] >= 0 && visibleTiles[1] >= 0)
            {
                tilesUp = true;
            }
            return tilesUp;
        }

        public void AddVisibleTile(int index)
        {
            if(visibleTiles[0] == -1)
            {
                visibleTiles[0] = index;
            }
            else if (visibleTiles[1] == -2)
            {
                visibleTiles[1] = index;
            }
        }

        public void RemoveVisibleTile(int index)
        {
            if (visibleTiles[0] == index)
            {
                visibleTiles[0] = -1;
            }
            else if (visibleTiles[1] == index)
            {
                visibleTiles[1] = -2;
            }
        }

        public bool TryMatchClickedTiles()
        {
            bool success = false;
            if(visibleTiles[0] == visibleTiles[1])
            {
                visibleTiles[0] = -1;
                visibleTiles[1] = -2;
                success = true;
                _tilesClearedCounter += 2;
            }
            return success;
        }

        private void Update()
        {
            if(_tilesClearedCounter >= 4)
            {
                _isWin = true;
                TilesCleared?.Invoke();
                _tilesClearedCounter = 0;
            }
        }

        private void Awake()
        {
            tile = GameObject.Find("Tile");
        }
    }
}
