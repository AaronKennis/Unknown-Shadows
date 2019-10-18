﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown_Shadows.Support
{
    public class Texture
    {
        Texture2D image;
        Vector2 position;
        Vector2 size;

        public Texture(String image, Vector2 position, Vector2 size)
        {
            this.image = Game1.sContent.Load<Texture2D>(image);
            this.position = position;
            this.size = size;
        }

        public void Update(Vector2 deltaTranslate, Vector2 deltaScale)
        {
            position += deltaTranslate;
            size += deltaScale;
        }

        public void Draw()
        {
            Rectangle destRect = Camera.ScreenRectangle(position, size);
            Game1.sSpriteBatch.Draw(image, destRect, Color.White);
        }
    }
}
