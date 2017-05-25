﻿using System.Collections.Generic;

namespace GameWork.Core.Audio.MultiClip
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public class MultiClipFactory
	{
		private readonly Dictionary<string, MultiClipModel> _models = new Dictionary<string, MultiClipModel>();

		public void AddModel(string id, MultiClipModel model)
		{
			_models[id] = model;
		}

		public MultiClip Create(string id)
		{
			return new MultiClip(_models[id]);
		}
	}
}