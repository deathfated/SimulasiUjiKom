using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.MatchPicture.Gameplay
{
    public class Tile : MonoBehaviour, IRaycastable
    {
        GameObject tileGroup;
        SpriteRenderer spriteRenderer;
        public Sprite[] sprites;
        public int spriteIndex;
        public bool matched = false;
        private bool IsSelected = false;

        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            tileGroup = GameObject.Find("TileGroup");
        }

        private void Start()
        {
            spriteRenderer.sprite = sprites[spriteIndex];
        }

        public void OnRaycasted()
        {
            if (matched == false)
            {
                if (IsSelected == false)
                {
                    if (tileGroup.GetComponent<TileGroup>().TwoSelected() == false)
                    {
                        transform.GetChild(0).gameObject.SetActive(true);
                        IsSelected = true;
                        tileGroup.GetComponent<TileGroup>().AddVisibleTile(spriteIndex);
                        matched = tileGroup.GetComponent<TileGroup>().TryMatchClickedTiles();
                    }
                }
                else
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                    IsSelected = false;
                    tileGroup.GetComponent<TileGroup>().RemoveVisibleTile(spriteIndex);
                }
            }
        }
    }

    
}