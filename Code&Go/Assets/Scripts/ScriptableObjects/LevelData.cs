﻿using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "Level", menuName = "ScriptableObjects/Level")]
public class LevelData : ScriptableObject
{

    public LocalizedString levelNameLocalized;
    public string levelName;
    public Sprite levelPreview;

    public LocalizedAsset<TextAsset> initialState; // Estado inicial en .xml
    public TextAsset customInitialState = null;

    [Header("Active Blocks")]
    public TextAsset activeBlocks;//Bloques y categorias disponibles    
    public bool allActive = false;

    [Space(10)]
    public TextAsset levelBoard;
    public string auxLevelBoard;
    
    [Space(10)] 
    public int minimosPasos;
    
    
    public LocalizedString endTextLocalized;
}
