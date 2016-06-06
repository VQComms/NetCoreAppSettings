using depb;
using TinyIoC;

namespace depa
{
    public class MessageProcessor
    {
        public void Start(DepAConfiguration configuration)
        {
            var container = TinyIoCContainer.Current;

            container.Register(configuration);
            container.Register(configuration.DepBConfiguration);
            container.Register<IDepAClass, DepAClass>();
            container.Register<IDepBClass, DepBClass>();

            var depA = container.Resolve<IDepAClass>();

            depA.DepAMethod();
        }
    }
}