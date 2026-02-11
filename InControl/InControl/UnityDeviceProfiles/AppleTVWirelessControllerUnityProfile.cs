using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200019E RID: 414
	public class AppleTVWirelessControllerUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000FAE RID: 4014 RVA: 0x0003EFA4 File Offset: 0x0003D1A4
		// Note: this type is marked as 'beforefieldinit'.
		static AppleTVWirelessControllerUnityProfile()
		{
			Il2CppClassPointerStore<AppleTVWirelessControllerUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "AppleTVWirelessControllerUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleTVWirelessControllerUnityProfile>.NativeClassPtr);
			AppleTVWirelessControllerUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleTVWirelessControllerUnityProfile>.NativeClassPtr, 100665422);
			AppleTVWirelessControllerUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleTVWirelessControllerUnityProfile>.NativeClassPtr, 100665423);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0003EFFC File Offset: 0x0003D1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 828424, XrefRangeEnd = 828608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppleTVWirelessControllerUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0003F038 File Offset: 0x0003D238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 828608, XrefRangeEnd = 828612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppleTVWirelessControllerUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppleTVWirelessControllerUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleTVWirelessControllerUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00006BB4 File Offset: 0x00004DB4
		public AppleTVWirelessControllerUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
