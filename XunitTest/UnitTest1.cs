using Individuell_inlamning.Controllers;
using Individuell_inlamning.Repository;
using Microsoft.AspNetCore.Mvc;

namespace XunitTest
{
    public class UnitTest1
    {
        //--------------------------------------------------------- Test för repositorys funktiones
        Service service = new Service();

        [Fact]
        public void Encrypt_Test()
        {
            Model model = new Model { Name = "Ali", Text = "random" , key = 7 }; //yhukvt

            Assert.Equal("yhukvt", service.Encrypt(model));
        }

        [Fact]
        public void Decrypt_Test()
        {
            service.Encrypt(new Model { Name = "Ali", Text = "random", key = 7 });
            ModelDto modelDto = new ModelDto { Name = "Ali", Text = "yhukvt"};
            Assert.Equal("random", service.Decrypt(modelDto));
        }

        //----------------------------------------------------------- Test för Controllers end-point

        [Fact]
        public void Controller_Encrypt_test()
        {
            var controller = new CipherController();
            var model = new Model { Name = "Ali", Text = "random", key = 7 };
            var result = controller.Encrypt(model);


            Assert.IsType<OkObjectResult>(result.Result);

            var okResult = result.Result as OkObjectResult;
            Assert.NotNull(okResult!.Value);
            Assert.Equal("String", okResult.Value.GetType().Name);
        }

        [Fact]
        public void Controller_Decrypt_test()
        {

            var controller = new CipherController();
            var model = new ModelDto { Name = "Ali" , Text = "random"};
            var result = controller.Decrypt(model);


            Assert.IsType<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;

            Assert.NotNull(okResult!.Value);
            Assert.Equal("String", okResult.Value.GetType().Name);

        }

    }
}