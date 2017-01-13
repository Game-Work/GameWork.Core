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
		
		public StateController(params TState[] states)
		{
			foreach (var state in states)
			{
				States.Add(state.Name, state);
			}
		}

		public override void Initialize(string startStateName)
		{
			foreach (var state in States.Values)
			{
				state.Initialize();
			}

			OnInitialize();

			ChangeState(startStateName);
		}

		public override void Terminate()
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

		protected override void OnChangeState(string toStateName)
		{
			if (ActiveStateName != null)
			{
				States[ActiveStateName].Exit(toStateName);
			}

			if (States.ContainsKey(toStateName))
			{
				States[toStateName].Enter(ActiveStateName);
				ActiveStateName = toStateName;
			}
			else
			{
				if (ParentController != null)
				{
					ParentController.ChangeState(toStateName);
				}
				else
				{
					throw new ArgumentOutOfRangeException($"No state with the name: {toStateName} was found" +
														  $"There is also no parent {nameof(StateController)} set, which may also resolve the state change.");
				}
			}
		}
	}
}