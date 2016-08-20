using System;

namespace GameWork.Factories
{
	public class SingleModelFactory<TCreate, TModel>
	{
		private TModel _model;

		public void SetModel(TModel model)
		{
			_model = model;
		}

		public TCreate Create()
		{
			return (TCreate)Activator.CreateInstance(typeof(TCreate), _model);
		}
	}
}