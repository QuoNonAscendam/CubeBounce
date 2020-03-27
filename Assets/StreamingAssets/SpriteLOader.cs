using System.IO;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class SpriteLOader 
{
    string spriteDirectiry;

    public SpriteLOader()
    {
        spriteDirectiry = Path.Combine(Application.streemingAssetsPath, "images");
    }
    public Sprite LoadSqripts(string imageName)
    {
        var path = Path.Combine(spriteDirectiry, imageName);

        byte[] bites = null;
        Sprite sprite = null;

        var file = new FileInfo(path);

        if(file.Exists)
        {
            bites = File.ReadAllBytes(path);
            var texture = new Texture2D(512,410,TextureFormat.DXT1,false,true);
            texture.LoadImage(bites);
            sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2D.zero);
        }
        return sprite;
    }
}
