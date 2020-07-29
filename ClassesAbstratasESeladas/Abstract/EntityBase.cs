using System;

namespace ClassesAbstratasESeladas.Abstract
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public abstract bool EhValido();
    }
}
