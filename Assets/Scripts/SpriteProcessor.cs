using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpriteProcessor : AssetPostprocessor
{
    void OnPreprocessTexture()
    {
        TextureImporter importer = (TextureImporter)assetImporter;
        importer.filterMode = FilterMode.Point;
        importer.spritePixelsPerUnit = 32;
    }
    void OnPreprocessAsset()
    {
        TextureImporter importer = assetImporter as TextureImporter;
        if (importer != null)
        {
            //texture stuff
        }
    }
}
