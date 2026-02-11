using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001A4 RID: 420
	public class LogitechF710LinuxUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000FC6 RID: 4038 RVA: 0x0003F484 File Offset: 0x0003D684
		// Note: this type is marked as 'beforefieldinit'.
		static LogitechF710LinuxUnityProfile()
		{
			Il2CppClassPointerStore<LogitechF710LinuxUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "LogitechF710LinuxUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogitechF710LinuxUnityProfile>.NativeClassPtr);
			LogitechF710LinuxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechF710LinuxUnityProfile>.NativeClassPtr, 100665434);
			LogitechF710LinuxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechF710LinuxUnityProfile>.NativeClassPtr, 100665435);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0003F4DC File Offset: 0x0003D6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 829538, XrefRangeEnd = 829715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogitechF710LinuxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0003F518 File Offset: 0x0003D718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 829715, XrefRangeEnd = 829719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogitechF710LinuxUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogitechF710LinuxUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogitechF710LinuxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00006BEA File Offset: 0x00004DEA
		public LogitechF710LinuxUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
