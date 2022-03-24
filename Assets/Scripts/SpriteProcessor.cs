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
        ModelImporter importer = assetImporter as ModelImporter;
        if (importer != null)
        {
            //texture stuff
        }
    }
}
