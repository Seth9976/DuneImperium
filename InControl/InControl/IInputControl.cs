using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace InControl
{
	// Token: 0x02000025 RID: 37
	public class IInputControl : Il2CppObjectBase
	{
		// Token: 0x0600026B RID: 619 RVA: 0x000108B0 File Offset: 0x0000EAB0
		// Note: this type is marked as 'beforefieldinit'.
		static IInputControl()
		{
			Il2CppClassPointerStore<IInputControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "IInputControl");
			IInputControl.NativeMethodInfoPtr_get_HasChanged_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputControl>.NativeClassPtr, 100663633);
			IInputControl.NativeMethodInfoPtr_get_IsPressed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputControl>.NativeClassPtr, 100663634);
			IInputControl.NativeMethodInfoPtr_get_WasPressed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputControl>.NativeClassPtr, 100663635);
			IInputControl.NativeMethodInfoPtr_get_WasReleased_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputControl>.NativeClassPtr, 100663636);
			IInputControl.NativeMethodInfoPtr_ClearInputState_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInputControl>.NativeClassPtr, 100663637);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0001093C File Offset: 0x0000EB3C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputControl.NativeMethodInfoPtr_get_HasChanged_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00010984 File Offset: 0x0000EB84
		public unsafe virtual bool IsPressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputControl.NativeMethodInfoPtr_get_IsPressed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000109CC File Offset: 0x0000EBCC
		public unsafe virtual bool WasPressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputControl.NativeMethodInfoPtr_get_WasPressed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00010A14 File Offset: 0x0000EC14
		public unsafe virtual bool WasReleased
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputControl.NativeMethodInfoPtr_get_WasReleased_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00010A5C File Offset: 0x0000EC5C
		[CallerCount(0)]
		public unsafe virtual void ClearInputState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInputControl.NativeMethodInfoPtr_ClearInputState_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002E14 File Offset: 0x00001014
		public IInputControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPressed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_get_WasPressed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_get_WasReleased_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_ClearInputState_Public_Abstract_Virtual_New_Void_0;
	}
}
