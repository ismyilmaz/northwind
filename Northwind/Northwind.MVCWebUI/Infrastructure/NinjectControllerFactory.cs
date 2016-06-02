using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Norhwind.Bll.Concrete;
using Northwind.Dal.Concrete.EntitiyFramework;
using Northwind.Interfaces;

namespace Northwind.MVCWebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel _ninjectKernel;

        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            AddBllBindings();
        }

        private void AddBllBindings()
        {
            _ninjectKernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal",new EfProductDal());

            _ninjectKernel.Bind<IAuthenticationService>()
                .To<AuthenticationManager>()
                .WithConstructorArgument("authenticationDal", new EfIAuthenticationDal());

            _ninjectKernel.Bind<ICategortService>()
                .To<CategoryManager>()
                .WithConstructorArgument("categoryDal", new EfCategoryDal());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_ninjectKernel.Get(controllerType);
        }
    }
}