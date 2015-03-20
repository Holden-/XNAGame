using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace XnaApp.Objetos
{
    class Nave : ObjetoJogo
    {
        public float Aceleracao { get; set; }
        public bool Acelerando { get; set; }
        public float VelocidadeMax { get; set; }
        public int Life { get; set; }

        public Nave(Vector2 Posicao, Vector2 Velocidade)
            : base (Posicao, Velocidade)
        {
        }
    }
}
