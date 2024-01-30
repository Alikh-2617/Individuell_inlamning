namespace Individuell_inlamning.Repository
{
    public interface IService
    {
        public string Encrypt(Model model); 
        public string? Decrypt(ModelDto model);
    }
}
