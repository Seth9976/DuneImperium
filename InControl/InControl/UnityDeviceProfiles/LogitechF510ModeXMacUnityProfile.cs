using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001B5 RID: 437
	public class LogitechF510ModeXMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600100A RID: 4106 RVA: 0x00040254 File Offset: 0x0003E454
		// Note: this type is marked as 'beforefieldinit'.
		static LogitechF510ModeXMacUnityProfile()
		{
			Il2CppClassPointerStore<LogitechF510ModeXMacUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "LogitechF510ModeXMacUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogitechF510ModeXMacUnityProfile>.NativeClassPtr);
			LogitechF510ModeXMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechF510ModeXMacUnityProfile>.NativeClassPtr, 100665468);
			LogitechF510ModeXMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechF510ModeXMacUnityProfile>.NativeClassPtr, 100665469);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x000402AC File Offset: 0x0003E4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 832781, XrefRangeEnd = 832983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogitechF510ModeXMacUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x000402E8 File Offset: 0x0003E4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 832983, XrefRangeEnd = 832987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogitechF510ModeXMacUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogitechF510ModeXMacUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogitechF510ModeXMacUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00006C83 File Offset: 0x00004E83
		public LogitechF510ModeXMacUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
