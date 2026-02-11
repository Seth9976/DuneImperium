using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200019B RID: 411
	public class Xbox360RockCandyAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000FA2 RID: 4002 RVA: 0x0003ED34 File Offset: 0x0003CF34
		// Note: this type is marked as 'beforefieldinit'.
		static Xbox360RockCandyAndroidUnityProfile()
		{
			Il2CppClassPointerStore<Xbox360RockCandyAndroidUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "Xbox360RockCandyAndroidUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Xbox360RockCandyAndroidUnityProfile>.NativeClassPtr);
			Xbox360RockCandyAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360RockCandyAndroidUnityProfile>.NativeClassPtr, 100665416);
			Xbox360RockCandyAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Xbox360RockCandyAndroidUnityProfile>.NativeClassPtr, 100665417);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0003ED8C File Offset: 0x0003CF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 827902, XrefRangeEnd = 828092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Xbox360RockCandyAndroidUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0003EDC8 File Offset: 0x0003CFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 828092, XrefRangeEnd = 828096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Xbox360RockCandyAndroidUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Xbox360RockCandyAndroidUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Xbox360RockCandyAndroidUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00006B99 File Offset: 0x00004D99
		public Xbox360RockCandyAndroidUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
