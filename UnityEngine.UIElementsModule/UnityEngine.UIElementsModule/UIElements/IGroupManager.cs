using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013F RID: 319
	public class IGroupManager : Il2CppObjectBase
	{
		// Token: 0x060017B5 RID: 6069 RVA: 0x00070EDC File Offset: 0x0006F0DC
		// Note: this type is marked as 'beforefieldinit'.
		static IGroupManager()
		{
			Il2CppClassPointerStore<IGroupManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IGroupManager");
			IGroupManager.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_IGroupBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGroupManager>.NativeClassPtr, 100666826);
			IGroupManager.NativeMethodInfoPtr_OnOptionSelectionChanged_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGroupManager>.NativeClassPtr, 100666827);
			IGroupManager.NativeMethodInfoPtr_RegisterOption_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGroupManager>.NativeClassPtr, 100666828);
			IGroupManager.NativeMethodInfoPtr_UnregisterOption_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGroupManager>.NativeClassPtr, 100666829);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00070F54 File Offset: 0x0006F154
		[CallerCount(0)]
		public unsafe virtual void Init(IGroupBox groupBox)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupBox);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGroupManager.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_IGroupBox_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00070FA4 File Offset: 0x0006F1A4
		[CallerCount(0)]
		public unsafe virtual void OnOptionSelectionChanged(IGroupBoxOption selectedOption)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedOption);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGroupManager.NativeMethodInfoPtr_OnOptionSelectionChanged_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00070FF4 File Offset: 0x0006F1F4
		[CallerCount(0)]
		public unsafe virtual void RegisterOption(IGroupBoxOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGroupManager.NativeMethodInfoPtr_RegisterOption_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00071044 File Offset: 0x0006F244
		[CallerCount(0)]
		public unsafe virtual void UnregisterOption(IGroupBoxOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGroupManager.NativeMethodInfoPtr_UnregisterOption_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0000AEDC File Offset: 0x000090DC
		public IGroupManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_IGroupBox_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr_OnOptionSelectionChanged_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOption_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterOption_Public_Abstract_Virtual_New_Void_IGroupBoxOption_0;
	}
}
