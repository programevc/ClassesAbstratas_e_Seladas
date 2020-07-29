using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratasESeladas.Abstract
{
    public class PedidoEntity : EntityBase
    {
        public override bool EhValido()
        {
            return true;
        }
    }
}
