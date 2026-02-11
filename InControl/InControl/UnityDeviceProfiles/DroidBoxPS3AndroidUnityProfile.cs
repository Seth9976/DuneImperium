using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200016B RID: 363
	public class DroidBoxPS3AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EE2 RID: 3810 RVA: 0x0003C634 File Offset: 0x0003A834
		// Note: this type is marked as 'beforefieldinit'.
		static DroidBoxPS3AndroidUnityProfile()
		{
			Il2CppClassPointerStore<DroidBoxPS3AndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "DroidBoxPS3AndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DroidBoxPS3AndroidUnityProfile>.NativeClassPtr);
			DroidBoxPS3AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroidBoxPS3AndroidUnityProfile>.NativeClassPtr, 100665320);
			DroidBoxPS3AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroidBoxPS3AndroidUnityProfile>.NativeClassPtr, 100665321);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0003C68C File Offset: 0x0003A88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819637, XrefRangeEnd = 819814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DroidBoxPS3AndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0003C6C8 File Offset: 0x0003A8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 819814, XrefRangeEnd = 819818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DroidBoxPS3AndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DroidBoxPS3AndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DroidBoxPS3AndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x000069E9 File Offset: 0x00004BE9
		public DroidBoxPS3AndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
