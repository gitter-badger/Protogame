﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Protogame
{
	public class ComponentizedObject : IContainsComponents
	{
		private List<object> _registeredComponents = new List<object>();

		private List<object> _publicComponents = new List<object>(); 
	
		private class ImplementedComponentCallable<T> : IComponentCallable where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke()
			{
				_target.InvokeCallableOnComponents<T>(_method);
			}
		}

		protected IComponentCallable RegisterCallable<T>(Action<T> method) where T : class
		{
			return new ImplementedComponentCallable<T>(this, method);
		}

		private void InvokeCallableOnComponents<T>(Action<T> method) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1> : IComponentCallable<T1> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1)
			{
				_target.InvokeCallableOnComponents<T, T1>(_method, arg1);
			}
		}

		protected IComponentCallable<T1> RegisterCallable<T, T1>(Action<T, T1> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1>(Action<T, T1> method, T1 arg1) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2> : IComponentCallable<T1, T2> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2)
			{
				_target.InvokeCallableOnComponents<T, T1, T2>(_method, arg1, arg2);
			}
		}

		protected IComponentCallable<T1, T2> RegisterCallable<T, T1, T2>(Action<T, T1, T2> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2>(Action<T, T1, T2> method, T1 arg1, T2 arg2) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3> : IComponentCallable<T1, T2, T3> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3>(_method, arg1, arg2, arg3);
			}
		}

		protected IComponentCallable<T1, T2, T3> RegisterCallable<T, T1, T2, T3>(Action<T, T1, T2, T3> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3>(Action<T, T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3, T4> : IComponentCallable<T1, T2, T3, T4> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3, T4> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3, T4> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3, T4>(_method, arg1, arg2, arg3, arg4);
			}
		}

		protected IComponentCallable<T1, T2, T3, T4> RegisterCallable<T, T1, T2, T3, T4>(Action<T, T1, T2, T3, T4> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3, T4>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3, T4>(Action<T, T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3, arg4);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3, T4, T5> : IComponentCallable<T1, T2, T3, T4, T5> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3, T4, T5> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3, T4, T5> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3, T4, T5>(_method, arg1, arg2, arg3, arg4, arg5);
			}
		}

		protected IComponentCallable<T1, T2, T3, T4, T5> RegisterCallable<T, T1, T2, T3, T4, T5>(Action<T, T1, T2, T3, T4, T5> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3, T4, T5>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3, T4, T5>(Action<T, T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3, arg4, arg5);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6> : IComponentCallable<T1, T2, T3, T4, T5, T6> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3, T4, T5, T6> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3, T4, T5, T6> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6>(_method, arg1, arg2, arg3, arg4, arg5, arg6);
			}
		}

		protected IComponentCallable<T1, T2, T3, T4, T5, T6> RegisterCallable<T, T1, T2, T3, T4, T5, T6>(Action<T, T1, T2, T3, T4, T5, T6> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6>(Action<T, T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3, arg4, arg5, arg6);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7> : IComponentCallable<T1, T2, T3, T4, T5, T6, T7> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3, T4, T5, T6, T7> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3, T4, T5, T6, T7> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7>(_method, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			}
		}

		protected IComponentCallable<T1, T2, T3, T4, T5, T6, T7> RegisterCallable<T, T1, T2, T3, T4, T5, T6, T7>(Action<T, T1, T2, T3, T4, T5, T6, T7> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7>(Action<T, T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8> : IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3, T4, T5, T6, T7, T8> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3, T4, T5, T6, T7, T8> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8>(_method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			}
		}

		protected IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8> RegisterCallable<T, T1, T2, T3, T4, T5, T6, T7, T8>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(_method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			}
		}

		protected IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9> RegisterCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(_method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
			}
		}

		protected IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> RegisterCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(_method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
			}
		}

		protected IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> RegisterCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(_method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
			}
		}

		protected IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> RegisterCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(_method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
			}
		}

		protected IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> RegisterCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(_method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
			}
		}

		protected IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> RegisterCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
				}
			}
		}

		private class ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> where T : class
		{
			private readonly ComponentizedObject _target;
			private readonly Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _method;

			public ImplementedComponentCallable(ComponentizedObject target, Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> method)
			{
				_target = target;
				_method = method;
			}

			public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
			{
				_target.InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(_method, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
			}
		}

		protected IComponentCallable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> RegisterCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> method) where T : class
		{
			return new ImplementedComponentCallable<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this, method);
		}

		private void InvokeCallableOnComponents<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) where T : class
		{
			foreach (var component in _registeredComponents)
			{
				var targetable = component as T;
				if (targetable != null)
				{
					method(targetable, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
				}
			}
		}

		protected void RegisterPrivateComponent(object component)
        {
		    if (component is IInternalHasComponent)
		    {
		        _registeredComponents.Add(((IInternalHasComponent)component).Component);
		    }
		    else
            {
                _registeredComponents.Add(component);
            }
        }

		protected void RegisterPublicComponent(object component)
		{
		    if (component is IInternalHasComponent)
		    {
		        _registeredComponents.Add(((IInternalHasComponent)component).Component);
                _publicComponents.Add(((IInternalHasComponent)component).Component);
            }
		    else
            {
                _registeredComponents.Add(component);
                _publicComponents.Add(component);
            }
		}

		public ReadOnlyCollection<object> PublicComponents
		{
			get
			{
				return _publicComponents.AsReadOnly();
			}
		}
	}
}