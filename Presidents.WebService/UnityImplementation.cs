/***********************************************************************
ABIE Development team
***********************************************************************/

using Presidents.BusinessLayer;
using Presidents.Entities;
using Unity;

namespace Presidents.WebService
{
    public class UnityImplementation
    {
        private static readonly UnityContainer UnityContainer = new UnityContainer();

        public UnityImplementation()
        {
            UnityContainer.RegisterType<IAction, PresidentControl>();
        }

        public static PresidentControl PresidentControl => UnityContainer.Resolve<PresidentControl>();
    }
}