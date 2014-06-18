using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MurderQuest
{
    class AnimatedSprite
    {
        private Texture2D texture;
        private Rectangle drawRectangle;

        protected Vector2 position, textureOrigin;
        protected SpriteEffects spriteEffect;
        protected int currentFrame, startFrame, endFrame, frameWidth, frameHeight, rowmax, mod, countframe;
        protected Color drawColor = Color.White;
        protected float elapsedTime, nextFrameTime, rotation = 0.0f, size = 1.0f, layerDepth;
        protected bool playOnce, UpdateAgain;

        public bool IsDonePlaying
        {
            get { return !UpdateAgain && playOnce; }
        }
        public AnimatedSprite(Texture2D _texture, Vector2 _position, float _layerDepth, float _nextframe, int start, int end, int widht, int height, bool _playOnce)
            : this(_texture, _position, _layerDepth, _nextframe, start, end, widht, height, _playOnce, 1.0f) { }
        public AnimatedSprite(Texture2D _texture, Vector2 _position, float _layerDepth, float _nextframe, int start, int end, int widht, int height, bool _playOnce, float _size)
            : this(_texture, _position, _layerDepth, _nextframe, start, end, widht, height, _playOnce, 1.0f, 0.0f) { }
        public AnimatedSprite(Texture2D _texture, Vector2 _position, float _layerDepth, float _nextframe, int start, int end, int widht, int height, bool _playOnce, float _size, float _rotation)
        {
            texture = _texture;
            position = _position;
            layerDepth = _layerDepth;
            nextFrameTime = _nextframe;
            size = _size;
            rotation = _rotation;

            spriteEffect = SpriteEffects.None;
            textureOrigin = new Vector2(widht / 2, height / 2);

            startFrame = start;
            endFrame = end;
            mod = end - start;
            frameWidth = widht;
            frameHeight = height;
            playOnce = _playOnce;
            rowmax = _texture.Width / widht;
            UpdateAgain = true;
        }
        public void ChangeAnimation(float _nextFrame, int start, int end, bool _playonce, SpriteEffects effect)
        {
            spriteEffect = effect;
            ChangeAnimation(_nextFrame, start, end, _playonce);
        }
        public void ChangeAnimation(float _nextFrame, int start, int end, bool _playonce)
        {
            elapsedTime = 0;
            nextFrameTime = _nextFrame;
            startFrame = currentFrame = start;
            endFrame = end;
            playOnce = _playonce;
            UpdateAgain = true;
            mod = end - start;
            countframe = 0;
        }
        public void Update(GameTime gameTime)
        {
            if (UpdateAgain)
            {
                elapsedTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (elapsedTime >= nextFrameTime)
                {
                    elapsedTime -= nextFrameTime;
                    if (mod > 0)
                    {
                        countframe++;
                        countframe = countframe % mod;
                    }
                    currentFrame = startFrame + countframe;
                    if (currentFrame == startFrame && playOnce)
                    {
                        UpdateAgain = false;
                    }
                }
            }
        }

        public void Update(GameTime gameTime, Vector2 _pos)
        {
            position = _pos;
            Update(gameTime);
        }
        //set the rotation depending on gradians then transform to radians
        public void SetRotation(float xvalue)
        {
            //float circle = MathHelper.Pi * 2;
            //rotation = xvalue % circle * 0.4f;
            rotation = MathHelper.ToRadians(xvalue);
        }
        public bool WhatAnimationIsPlaying(int start, SpriteEffects effect)
        {
            if (startFrame == start && effect == spriteEffect)
                return false;
            else
                return true;
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (rowmax != 0)
            {
                drawRectangle = new Rectangle((currentFrame % rowmax) * frameWidth, (currentFrame / rowmax) * frameHeight, frameWidth, frameHeight);
                spriteBatch.Draw(texture, position, drawRectangle, drawColor, rotation, textureOrigin, size, spriteEffect, layerDepth);
            }

        }
    }
}
