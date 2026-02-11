using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200010E RID: 270
	public class PlayStation3MacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000D49 RID: 3401 RVA: 0x00036F3C File Offset: 0x0003513C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayStation3MacNativeProfile()
		{
			Il2CppClassPointerStore<PlayStation3MacNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "PlayStation3MacNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayStation3MacNativeProfile>.NativeClassPtr);
			PlayStation3MacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation3MacNativeProfile>.NativeClassPtr, 100665097);
			PlayStation3MacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation3MacNativeProfile>.NativeClassPtr, 100665098);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00036F94 File Offset: 0x00035194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797205, XrefRangeEnd = 797467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayStation3MacNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00036FD0 File Offset: 0x000351D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 797467, XrefRangeEnd = 797471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayStation3MacNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayStation3MacNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayStation3MacNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x000066A4 File Offset: 0x000048A4
		public PlayStation3MacNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
