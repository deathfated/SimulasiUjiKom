using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deathfated.MatchPicture.Global
{
    [System.Serializable]
    public class SaveData : MonoBehaviour
    {
        private const string _prefsKey = "_Player_";

        //

        public void Load()
        {
            if(PlayerPrefs.HasKey(_prefsKey))
            {
                string json = PlayerPrefs.GetString(_prefsKey);
                JsonUtility.FromJsonOverwrite(json, this);
            }
            else
            {
                Save();
            }
        }

        public void Save()
        {
            string json = JsonUtility.ToJson(this);
            PlayerPrefs.SetString(_prefsKey, json);
        }

        public void SetCurrentTheme()
        {
            //
            Save();
        }

        public void SetBoughtThemes()
        {
            //
            Save();
        }
    }
}