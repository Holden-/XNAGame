using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace XnaApp.Objetos
{
    class Nuvem : ObjetoJogo
    {
        public Nuvem(Vector2 Posicao, Vector2 Velocidade)
            : base (Posicao, Velocidade)
        {
        }
    }
}
