/***********************************************************************
ABIE Development team
***********************************************************************/

using Presidents.DataLayer;
using Presidents.Entities;
using Unity;

namespace Presidents.BusinessLayer
{
    public class Factory
    {
        private static readonly UnityContainer UnityContainer = new UnityContainer();

        public Factory()
        {
            UnityContainer.RegisterType<IAction, FileControl>();
        }

        public static FileControl FileControl => UnityContainer.Resolve<FileControl>();
    }
}