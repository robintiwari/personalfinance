﻿using System;
using Ninject.Modules;
using Service;
using Service.Interfaces;

namespace Web.Infrastructure
{
	public class WebModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IAccountService>().To<AccountService>();
			Bind<ICategoryService>().To<CategoryService>();
			Bind<IEncryptionService>().To<EncryptionService>();
			Bind<ITransactionService> ().To<TransactionService> ();
		}
	} // class
} // namespace