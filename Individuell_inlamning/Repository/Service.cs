using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Security.Cryptography;

namespace Individuell_inlamning.Repository
{
    public class Service : IService
    {
        private static List<Model> models = new List<Model>(); 

        public string? Decrypt(ModelDto modelDto)
        {
            foreach (var item in models)
            {
                if(item.Name == modelDto.Name)
                {
                    string result = "";
                    //if (modelDto.Text == null)
                    //{
                    //    return $"Hej ! vilken {modelDto.Name} är du ? ";
                    //}

                    //// bara koda lite för att inte har tråkigt !!
                    Model model = new Model { Name = modelDto.Name, Text = modelDto.Text, key = 26 - item.key };
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
            return null;
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

            models.Add(new Model { Name = model.Name, Text = model.Text, key = model.key});
            return result;
        }
    }
}
