using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001A8 RID: 424
	public class PlayStation4LinuxUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000FD6 RID: 4054 RVA: 0x0003F7C4 File Offset: 0x0003D9C4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayStation4LinuxUnityProfile()
		{
			Il2CppClassPointerStore<PlayStation4LinuxUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "PlayStation4LinuxUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayStation4LinuxUnityProfile>.NativeClassPtr);
			PlayStation4LinuxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4LinuxUnityProfile>.NativeClassPtr, 100665442);
			PlayStation4LinuxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation4LinuxUnityProfile>.NativeClassPtr, 100665443);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0003F81C File Offset: 0x0003DA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 830292, XrefRangeEnd = 830484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayStation4LinuxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0003F858 File Offset: 0x0003DA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 830484, XrefRangeEnd = 830488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayStation4LinuxUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayStation4LinuxUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayStation4LinuxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00006C0E File Offset: 0x00004E0E
		public PlayStation4LinuxUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
