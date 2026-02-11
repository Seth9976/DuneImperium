using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200015D RID: 349
	public class LogitechModeDAmazonUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000EAA RID: 3754 RVA: 0x0003BAD4 File Offset: 0x00039CD4
		// Note: this type is marked as 'beforefieldinit'.
		static LogitechModeDAmazonUnityProfile()
		{
			Il2CppClassPointerStore<LogitechModeDAmazonUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "LogitechModeDAmazonUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogitechModeDAmazonUnityProfile>.NativeClassPtr);
			LogitechModeDAmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechModeDAmazonUnityProfile>.NativeClassPtr, 100665292);
			LogitechModeDAmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogitechModeDAmazonUnityProfile>.NativeClassPtr, 100665293);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0003BB2C File Offset: 0x00039D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817318, XrefRangeEnd = 817495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LogitechModeDAmazonUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0003BB68 File Offset: 0x00039D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817495, XrefRangeEnd = 817499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogitechModeDAmazonUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogitechModeDAmazonUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogitechModeDAmazonUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0000696B File Offset: 0x00004B6B
		public LogitechModeDAmazonUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
