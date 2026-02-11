using System;
using Canis.actions;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000C9 RID: 201
	public sealed class StateAction<TMatch, TActiveAbility, TAbilityDefinition> : MulticastDelegate where TMatch : Match where TActiveAbility : ActiveAbility<TMatch, TAbilityDefinition> where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
	{
		// Token: 0x0600091C RID: 2332 RVA: 0x0003F384 File Offset: 0x0003D584
		// Note: this type is marked as 'beforefieldinit'.
		static StateAction()
		{
			Il2CppClassPointerStore<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "StateAction`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
			})).TypeHandle.value);
			StateAction<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665195);
			StateAction<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Action_TActiveAbility_TMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665196);
			StateAction<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TActiveAbility_TMatch_Context_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665197);
			StateAction<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Action_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665198);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0003F45C File Offset: 0x0003D65C
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 561466, RefRangeEnd = 561507, XrefRangeStart = 561466, XrefRangeEnd = 561507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateAction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateAction<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0003F4B8 File Offset: 0x0003D6B8
		[CallerCount(0)]
		public unsafe Canis.actions.Action Invoke(TActiveAbility activeAbility, TMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TActiveAbility).IsValueType)
				{
					TActiveAbility tactiveAbility = activeAbility;
					intPtr = ((tactiveAbility is string) ? IL2CPP.ManagedStringToIl2Cpp(tactiveAbility as string) : IL2CPP.Il2CppObjectBaseToPtr(tactiveAbility as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref activeAbility;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TMatch).IsValueType)
			{
				TMatch tmatch = match;
				intPtr2 = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref match;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StateAction<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Action_TActiveAbility_TMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr5) : null;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0003F598 File Offset: 0x0003D798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(TActiveAbility activeAbility, TMatch match, Context context, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TActiveAbility).IsValueType)
				{
					TActiveAbility tactiveAbility = activeAbility;
					intPtr = ((tactiveAbility is string) ? IL2CPP.ManagedStringToIl2Cpp(tactiveAbility as string) : IL2CPP.Il2CppObjectBaseToPtr(tactiveAbility as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref activeAbility;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TMatch).IsValueType)
			{
				TMatch tmatch = match;
				intPtr2 = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref match;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StateAction<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TActiveAbility_TMatch_Context_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0003F6A0 File Offset: 0x0003D8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateAction<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Action_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00005826 File Offset: 0x00003A26
		public StateAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0000582F File Offset: 0x00003A2F
		public static implicit operator StateAction<TMatch, TActiveAbility, TAbilityDefinition>(Func<TActiveAbility, TMatch, Context, Canis.actions.Action> A_0)
		{
			return DelegateSupport.ConvertDelegate<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>(A_0);
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00005837 File Offset: 0x00003A37
		public static StateAction<TMatch, TActiveAbility, TAbilityDefinition>operator +(StateAction<TMatch, TActiveAbility, TAbilityDefinition> A_0, StateAction<TMatch, TActiveAbility, TAbilityDefinition> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>();
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00005845 File Offset: 0x00003A45
		public static StateAction<TMatch, TActiveAbility, TAbilityDefinition>operator -(StateAction<TMatch, TActiveAbility, TAbilityDefinition> A_0, StateAction<TMatch, TActiveAbility, TAbilityDefinition> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>();
			}
			return delegate2;
		}

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Action_TActiveAbility_TMatch_Context_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TActiveAbility_TMatch_Context_AsyncCallback_Object_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Action_IAsyncResult_0;
	}
}
