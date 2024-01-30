using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Security.Cryptography;

namespace Individuell_inlamning.Repository
{
    public class Service : IService
    {
        private readonly List<Model> models = new List<Model>(); 

        public string Decrypt(Model model)
        {
            foreach (var item in models)
            {
                if(item.Name == model.Name)
                {
                    return Encrypt(new Model { Name = model.Name, Text = model.Text, key = 26 - item.key});
                }
            }
            return ("användare hittades inte , vi kan inte ge decryptade informationen ! ");
        }

        public string Encrypt(Model model)
        {
            string result = "";

            foreach (char ch in model.Text)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    result += (char)((ch + model.key - offset) % 26 + offset);
                }
                else
                {
                    result += ch;
                }
            }

            return result;
        }
    }
}
