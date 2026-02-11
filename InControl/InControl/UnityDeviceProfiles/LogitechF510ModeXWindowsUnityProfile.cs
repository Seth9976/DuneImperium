using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001EE RID: 494
	public class LogitechF510ModeXWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060010EE RID: 4334 RVA: 0x000430A4 File Offset: 0x000412A4
		// Note: this type is marked as 'beforefieldinit'.
		static LogitechF510ModeXWindowsUnityProfile()
		{
			Il2CppClassPointerStore<LogitechF510ModeXWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "LogitechF510ModeXWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogitechF510ModeXWindowsUnityProfile>.NativeClassPtr);
			LogitechF510ModeXWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechF510ModeXWindowsUnityProfile>.NativeClassPtr, 100665582);
			LogitechF510ModeXWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechF510ModeXWindowsUnityProfile>.NativeClassPtr, 100665583);
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x000430FC File Offset: 0x000412FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 844736, XrefRangeEnd = 844913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogitechF510ModeXWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00043138 File Offset: 0x00041338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 844913, XrefRangeEnd = 844917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogitechF510ModeXWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogitechF510ModeXWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogitechF510ModeXWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00006E84 File Offset: 0x00005084
		public LogitechF510ModeXWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
