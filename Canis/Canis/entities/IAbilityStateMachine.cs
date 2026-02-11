using System;
using Canis.actions;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000C0 RID: 192
	public class IAbilityStateMachine : Il2CppObjectBase
	{
		// Token: 0x060008D8 RID: 2264 RVA: 0x0003DBC8 File Offset: 0x0003BDC8
		// Note: this type is marked as 'beforefieldinit'.
		static IAbilityStateMachine()
		{
			Il2CppClassPointerStore<IAbilityStateMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IAbilityStateMachine");
			IAbilityStateMachine.NativeMethodInfoPtr_RunStateMachineBase_Public_Abstract_Virtual_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAbilityStateMachine>.NativeClassPtr, 100665122);
			IAbilityStateMachine.NativeMethodInfoPtr_ResumeExecutionBase_Public_Abstract_Virtual_New_Int32_ActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAbilityStateMachine>.NativeClassPtr, 100665123);
			IAbilityStateMachine.NativeMethodInfoPtr_get_Ordering_Public_Abstract_Virtual_New_get_IComparer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAbilityStateMachine>.NativeClassPtr, 100665124);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0003DC2C File Offset: 0x0003BE2C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> RunStateMachineBase(ActiveAbility activeAbility, Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAbilityStateMachine.NativeMethodInfoPtr_RunStateMachineBase_Public_Abstract_Virtual_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0003DCAC File Offset: 0x0003BEAC
		[CallerCount(0)]
		public unsafe virtual int ResumeExecutionBase(ActiveAbility activeAbility, Action returningAction, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAbilityStateMachine.NativeMethodInfoPtr_ResumeExecutionBase_Public_Abstract_Virtual_New_Int32_ActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x0003DD28 File Offset: 0x0003BF28
		public unsafe virtual IComparer<int> Ordering
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAbilityStateMachine.NativeMethodInfoPtr_get_Ordering_Public_Abstract_Virtual_New_get_IComparer_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000056C9 File Offset: 0x000038C9
		public IAbilityStateMachine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_RunStateMachineBase_Public_Abstract_Virtual_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecutionBase_Public_Abstract_Virtual_New_Int32_ActiveAbility_Action_Context_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_get_Ordering_Public_Abstract_Virtual_New_get_IComparer_1_Int32_0;
	}
}
