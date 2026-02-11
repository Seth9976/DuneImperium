using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001D6 RID: 470
	public class Xbox360MacSafariUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600108E RID: 4238 RVA: 0x00041D24 File Offset: 0x0003FF24
		// Note: this type is marked as 'beforefieldinit'.
		static Xbox360MacSafariUnityProfile()
		{
			Il2CppClassPointerStore<Xbox360MacSafariUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "Xbox360MacSafariUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Xbox360MacSafariUnityProfile>.NativeClassPtr);
			Xbox360MacSafariUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360MacSafariUnityProfile>.NativeClassPtr, 100665534);
			Xbox360MacSafariUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360MacSafariUnityProfile>.NativeClassPtr, 100665535);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00041D7C File Offset: 0x0003FF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 839310, XrefRangeEnd = 839574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Xbox360MacSafariUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00041DB8 File Offset: 0x0003FFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 839574, XrefRangeEnd = 839578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Xbox360MacSafariUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Xbox360MacSafariUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Xbox360MacSafariUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00006DAC File Offset: 0x00004FAC
		public Xbox360MacSafariUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
