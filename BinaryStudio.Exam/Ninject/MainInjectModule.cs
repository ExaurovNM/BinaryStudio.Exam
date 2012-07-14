using BinaryStudio.Exam.Core;
using BinaryStudio.Exam.Domain;
using Ninject.Modules;
namespace BinaryStudio.Exam.Ninject
{
    public class MainInjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<DataBaseContext>().ToMethod(it => new DataBaseContext());
            this.Bind<IUserProcessor>().To<UserProcessor>();
        }
    }
}