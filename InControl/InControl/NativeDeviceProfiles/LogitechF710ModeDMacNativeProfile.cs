using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200010C RID: 268
	public class LogitechF710ModeDMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D41 RID: 3393 RVA: 0x00036D9C File Offset: 0x00034F9C
		// Note: this type is marked as 'beforefieldinit'.
		static LogitechF710ModeDMacNativeProfile()
		{
			Il2CppClassPointerStore<LogitechF710ModeDMacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "LogitechF710ModeDMacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogitechF710ModeDMacNativeProfile>.NativeClassPtr);
			LogitechF710ModeDMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechF710ModeDMacNativeProfile>.NativeClassPtr, 100665093);
			LogitechF710ModeDMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechF710ModeDMacNativeProfile>.NativeClassPtr, 100665094);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00036DF4 File Offset: 0x00034FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796624, XrefRangeEnd = 796875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogitechF710ModeDMacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00036E30 File Offset: 0x00035030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796875, XrefRangeEnd = 796879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogitechF710ModeDMacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogitechF710ModeDMacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogitechF710ModeDMacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00006692 File Offset: 0x00004892
		public LogitechF710ModeDMacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
