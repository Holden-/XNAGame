using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace XnaApp.Objetos
{
    class Arco : ObjetoJogo
    {
        // Controle de visibilidade
        public Boolean Visivel { get; set; }
        // Controle de placar
        public Boolean Placar { get; set; }

        public Arco(Vector2 Posicao, Vector2 Velocidade)
            : base (Posicao, Velocidade)
        {
        }
    }
}
