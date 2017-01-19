using System;
using System.Collections.Generic;

namespace GameWork.Core.States
{
	public class StateController : StateController<State>
	{
		public StateController(params State[] states) : base(states)
		{
		}
	}

	public class StateController<TState> : StateControllerBase
		where TState : State
	{
		protected readonly Dictionary<string, TState> States = new Dictionary<string, TState>();
		
		public string ActiveStateName { protected set; get; }

		protected bool IsProcessingStateChange { get; set; }
		protected string LastActiveStateName { get; set; }

		public StateController(params TState[] states)
		{
			foreach (var state in states)
			{
				States.Add(state.Name, state);
				state.SetStateController(this);
			}
		}

		public void Initialize()
		{
			foreach (var state in States.Values)
			{
				state.Initialize();
			}

			OnInitialize();
		}

		public void Terminate()
		{
			OnTerminate();

			if (ActiveStateName != null)
			{
				States[ActiveStateName].Exit(null);
			}

			foreach (var state in States.Values)
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

		public override void ExitState(string toStateName)
		{
			IsProcessingStateChange = true;

			if (ActiveStateName != null)
			{
				LastActiveStateName = ActiveStateName;
				ActiveStateName = null;
				States[LastActiveStateName].Exit(toStateName);
			}
		}

		public override void EnterState(string toStateName)
		{
			if (States.ContainsKey(toStateName))
			{
				States[toStateName].Enter(LastActiveStateName);
				ActiveStateName = toStateName;
			}
			else
			{
				if (ParentController != null)
				{
					ParentController.ExitState(toStateName);
					ParentController.EnterState(toStateName);
				}
				else
				{
					throw new ArgumentOutOfRangeException($"No state with the name: {toStateName} was found" +
														  $"There is also no parent {nameof(StateController)} set, which may also resolve the state change.");
				}
			}

			IsProcessingStateChange = false;
		}
	}
}