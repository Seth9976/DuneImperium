using System;
using dwd.core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace context
{
	// Token: 0x0200000E RID: 14
	public class IRegisterInputActions : Il2CppObjectBase
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00008458 File Offset: 0x00006658
		// Note: this type is marked as 'beforefieldinit'.
		static IRegisterInputActions()
		{
			Il2CppClassPointerStore<IRegisterInputActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "context", "IRegisterInputActions");
			IRegisterInputActions.NativeMethodInfoPtr_get_InputActions_Public_Abstract_Virtual_New_get_IEnumerable_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegisterInputActions>.NativeClassPtr, 100663343);
			IRegisterInputActions.NativeMethodInfoPtr_get_IsGlobal_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegisterInputActions>.NativeClassPtr, 100663344);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000084A8 File Offset: 0x000066A8
		public unsafe virtual IEnumerable<InputAction> InputActions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegisterInputActions.NativeMethodInfoPtr_get_InputActions_Public_Abstract_Virtual_New_get_IEnumerable_1_InputAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<InputAction>>(intPtr3) : null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000084F4 File Offset: 0x000066F4
		public unsafe virtual bool IsGlobal
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegisterInputActions.NativeMethodInfoPtr_get_IsGlobal_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000226C File Offset: 0x0000046C
		public IRegisterInputActions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_get_InputActions_Public_Abstract_Virtual_New_get_IEnumerable_1_InputAction_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGlobal_Public_Virtual_New_get_Boolean_0;
	}
}
