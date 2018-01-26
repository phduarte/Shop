using Gadz.Shop.Commom.Model;
using System;

namespace Gadz.Shop.HR.DomainModel.Situacoes {
    internal class Situacao : Entity, ISituacao {
        public Nome Nome { get; private set; }
        public Status Status { get; private set; }
        public DateTime Desde { get; private set; }
        public DateTime Ate { get; private set; }
        public bool Custo { get; }
    }
}
