﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LD32_OSTGame
{
    public class Plane : Entity
    {

        protected float FireRate { get; set; }

        public Plane(Texture2D image, int health, Vector2 position, float scale, Vector2 velocity) : base()
        {
            this.image = image;
            this.Health = health;
            this.Position = position;
            this.Scale = scale;
            this.Velocity = velocity;
        }

        public void Move()
        {
            
        }

        public void Fire()
        {
            
        }

        public void SwitchUpgrade()
        {
            
        }
    }
}
