using System;

namespace GameWork.Core.Factories
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
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