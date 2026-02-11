using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001AA RID: 426
	public class Xbox360LinuxUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000FDE RID: 4062 RVA: 0x0003F964 File Offset: 0x0003DB64
		// Note: this type is marked as 'beforefieldinit'.
		static Xbox360LinuxUnityProfile()
		{
			Il2CppClassPointerStore<Xbox360LinuxUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "Xbox360LinuxUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Xbox360LinuxUnityProfile>.NativeClassPtr);
			Xbox360LinuxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360LinuxUnityProfile>.NativeClassPtr, 100665446);
			Xbox360LinuxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360LinuxUnityProfile>.NativeClassPtr, 100665447);
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x0003F9BC File Offset: 0x0003DBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 830633, XrefRangeEnd = 830879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Xbox360LinuxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0003F9F8 File Offset: 0x0003DBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 830879, XrefRangeEnd = 830883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Xbox360LinuxUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Xbox360LinuxUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Xbox360LinuxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00006C20 File Offset: 0x00004E20
		public Xbox360LinuxUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
