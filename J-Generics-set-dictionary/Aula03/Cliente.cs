using System;

namespace J_Generics_set_dictionary.Aula03
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Cliente))
            {
                throw new ArgumentException("Argumento inválido!");
            }

            var cliente = obj as Cliente;
            return Email.Equals(cliente.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}