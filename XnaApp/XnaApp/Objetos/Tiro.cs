using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace XnaApp.Objetos
{
    class Tiro : ObjetoJogo
    {
        public Vector2 direcao { get; set; }
        public Vector2 origin { get; set; }
        public float speed = 8f;
        public float rotation { get; set; }
        public Tiro(Vector2 Posicao)
            : base (Posicao)
        {

        }
    }
}
