using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001F0 RID: 496
	public class LogitechF710ModeXWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060010F6 RID: 4342 RVA: 0x00043244 File Offset: 0x00041444
		// Note: this type is marked as 'beforefieldinit'.
		static LogitechF710ModeXWindowsUnityProfile()
		{
			Il2CppClassPointerStore<LogitechF710ModeXWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "LogitechF710ModeXWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogitechF710ModeXWindowsUnityProfile>.NativeClassPtr);
			LogitechF710ModeXWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechF710ModeXWindowsUnityProfile>.NativeClassPtr, 100665586);
			LogitechF710ModeXWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechF710ModeXWindowsUnityProfile>.NativeClassPtr, 100665587);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0004329C File Offset: 0x0004149C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 845098, XrefRangeEnd = 845275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogitechF710ModeXWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x000432D8 File Offset: 0x000414D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 845275, XrefRangeEnd = 845279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogitechF710ModeXWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogitechF710ModeXWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogitechF710ModeXWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00006E96 File Offset: 0x00005096
		public LogitechF710ModeXWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
