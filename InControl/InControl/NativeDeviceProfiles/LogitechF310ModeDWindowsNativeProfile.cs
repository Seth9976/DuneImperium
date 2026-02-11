using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200013C RID: 316
	public class LogitechF310ModeDWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000E26 RID: 3622 RVA: 0x0003A004 File Offset: 0x00038204
		// Note: this type is marked as 'beforefieldinit'.
		static LogitechF310ModeDWindowsNativeProfile()
		{
			Il2CppClassPointerStore<LogitechF310ModeDWindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "LogitechF310ModeDWindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogitechF310ModeDWindowsNativeProfile>.NativeClassPtr);
			LogitechF310ModeDWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechF310ModeDWindowsNativeProfile>.NativeClassPtr, 100665226);
			LogitechF310ModeDWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechF310ModeDWindowsNativeProfile>.NativeClassPtr, 100665227);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0003A05C File Offset: 0x0003825C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 808606, XrefRangeEnd = 808905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogitechF310ModeDWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0003A098 File Offset: 0x00038298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 808905, XrefRangeEnd = 808909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogitechF310ModeDWindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogitechF310ModeDWindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogitechF310ModeDWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00006842 File Offset: 0x00004A42
		public LogitechF310ModeDWindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
