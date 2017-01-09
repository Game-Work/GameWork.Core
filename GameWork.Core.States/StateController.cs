using System;
using System.Collections.Generic;
using GameWork.Core.States.Interfaces;

namespace GameWork.Core.States
{
	public class StateController : StateController<State>
	{
		public StateController(params State[] states) : base(states)
		{
		}
	}

	public class StateController<TState> : IStateController
		where TState : State
	{
		protected readonly TState[] States;

		private readonly List<int> _history = new List<int>();
		private IStateController _parentController;

		public int ActiveStateIndex { get; private set; }
		public int ActiveStateHistoryIndex { get; private set; }
		public string ActiveStateName => States[ActiveStateIndex].Name;
		public int HistoryCount => _history.Count;

		public StateController(params TState[] states)
		{
			States = states;

			ActiveStateIndex = -1;
			ActiveStateHistoryIndex = -1;
		}

		public void SetParent(IStateController parentController)
		{
			_parentController = parentController;
		}

		public void Initialize()
		{
			foreach (var state in States)
			{
				state.Initialize();
			}
		}

		public void Terminate()
		{
			if (ActiveStateIndex > 0)
			{
				States[ActiveStateIndex].Exit();
			}

			foreach (var state in States)
			{
				state.Terminate();
			}
		}

		protected virtual void OnInitialize()
		{
		}

		protected virtual void OnTerminate()
		{
		}

		#region Actions
		public void NextStateInSequence()
		{
			ChangeState(ActiveStateIndex + 1);
			UpdateHistory();
		}

		public void PreviousStateInSequence()
		{
			ChangeState(ActiveStateIndex - 1);
			UpdateHistory();
		}

		public virtual void ChangeState(string toStateName)
		{
			var toStateIndex = -1;

			for(var i = 0; i < States.Length; i++)
			{
				if (States[i].Name == toStateName)
				{
					toStateIndex = i;
					break;
				}
			}

			if (toStateIndex >= 0)
			{
				ChangeState(toStateIndex);
				UpdateHistory();
			}
			else
			{
				if (_parentController != null)
				{
					TryExitCurrentState();
					_parentController.ChangeState(toStateName);
				}
				else
				{
					throw new ArgumentOutOfRangeException($"No state with the name: {toStateName} was found" +
														  $"There is also no parent {nameof(StateController)} set, which may also resolve the state change.");
				}
			}
		}

		public bool TryNextStateInHistory()
		{
			var toHistoryStateIndex = ActiveStateHistoryIndex + 1;

			if (toHistoryStateIndex < _history.Count)
			{
				ChangeState(_history[toHistoryStateIndex]);
				ActiveStateHistoryIndex = toHistoryStateIndex;
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool TryPreviousStateInHistory()
		{
			var toHistoryStateIndex = ActiveStateHistoryIndex - 1;

			if (toHistoryStateIndex >= 0)
			{
				ChangeState(_history[toHistoryStateIndex]);
				ActiveStateHistoryIndex = toHistoryStateIndex;
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion
		
		private void ChangeState(int toStateIndex)
		{
			TryExitCurrentState();

			ActiveStateIndex = toStateIndex;
			States[toStateIndex].Enter();
		}

		private void TryExitCurrentState()
		{
			if (ActiveStateIndex >= 0)
			{
				States[ActiveStateIndex].Exit();
				ActiveStateIndex = -1;
			}
		}

		private void UpdateHistory()
		{
			// If not the latest in the history
			if (ActiveStateHistoryIndex < _history.Count - 1)
			{
				// Restart history from this point onwards
				_history.RemoveRange(ActiveStateHistoryIndex + 1, _history.Count - (ActiveStateHistoryIndex + 1));
			}

			_history.Add(ActiveStateIndex);
			ActiveStateHistoryIndex = _history.Count - 1;
		}
	}
}