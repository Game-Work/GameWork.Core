using System;

namespace GameWork.Factories
{
	public class SingleModelFactory<TCreate, TModel>
	{
		protected TModel Model;

		public void SetModel(TModel model)
		{
            Model = model;
		}

		public TCreate Create()
		{
			return (TCreate)Activator.CreateInstance(typeof(TCreate), Model);
		}
	}
}