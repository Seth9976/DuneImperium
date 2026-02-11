using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000F3 RID: 243
	public class IHasAbilityStateStack : Il2CppObjectBase
	{
		// Token: 0x06000AC9 RID: 2761 RVA: 0x00047994 File Offset: 0x00045B94
		// Note: this type is marked as 'beforefieldinit'.
		static IHasAbilityStateStack()
		{
			Il2CppClassPointerStore<IHasAbilityStateStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IHasAbilityStateStack");
			IHasAbilityStateStack.NativeMethodInfoPtr_get_ActiveAbility_Public_Abstract_Virtual_New_get_ActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAbilityStateStack>.NativeClassPtr, 100665659);
			IHasAbilityStateStack.NativeMethodInfoPtr_get_AbilityStack_Public_Abstract_Virtual_New_get_IEnumerable_1_ActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAbilityStateStack>.NativeClassPtr, 100665660);
			IHasAbilityStateStack.NativeMethodInfoPtr_PushNewAbility_Public_Abstract_Virtual_New_ActiveAbility_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAbilityStateStack>.NativeClassPtr, 100665661);
			IHasAbilityStateStack.NativeMethodInfoPtr_PopAbility_Public_Abstract_Virtual_New_Action_ActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasAbilityStateStack>.NativeClassPtr, 100665662);
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00047A0C File Offset: 0x00045C0C
		public unsafe virtual ActiveAbility ActiveAbility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAbilityStateStack.NativeMethodInfoPtr_get_ActiveAbility_Public_Abstract_Virtual_New_get_ActiveAbility_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActiveAbility>(intPtr3) : null;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00047A58 File Offset: 0x00045C58
		public unsafe virtual IEnumerable<ActiveAbility> AbilityStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAbilityStateStack.NativeMethodInfoPtr_get_AbilityStack_Public_Abstract_Virtual_New_get_IEnumerable_1_ActiveAbility_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActiveAbility>>(intPtr3) : null;
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00047AA4 File Offset: 0x00045CA4
		[CallerCount(0)]
		public unsafe virtual ActiveAbility PushNewAbility([Optional] Il2CppReferenceArray<Object> parameters)
		{
			if (parameters == null)
			{
				parameters = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAbilityStateStack.NativeMethodInfoPtr_PushNewAbility_Public_Abstract_Virtual_New_ActiveAbility_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActiveAbility>(intPtr3) : null;
			}
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00047B0C File Offset: 0x00045D0C
		[CallerCount(0)]
		public unsafe virtual Canis.actions.Action PopAbility(ActiveAbility ability)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasAbilityStateStack.NativeMethodInfoPtr_PopAbility_Public_Abstract_Virtual_New_Action_ActiveAbility_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00005E94 File Offset: 0x00004094
		public virtual ActiveAbility PushNewAbility(params Object[] parameters)
		{
			return this.PushNewAbility(new Il2CppReferenceArray<Object>(parameters));
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00005EA2 File Offset: 0x000040A2
		public IHasAbilityStateStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAbility_Public_Abstract_Virtual_New_get_ActiveAbility_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilityStack_Public_Abstract_Virtual_New_get_IEnumerable_1_ActiveAbility_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_PushNewAbility_Public_Abstract_Virtual_New_ActiveAbility_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_PopAbility_Public_Abstract_Virtual_New_Action_ActiveAbility_0;
	}
}
