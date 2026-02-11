using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001F5 RID: 501
	public class NexusPlayerWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600110A RID: 4362 RVA: 0x00043654 File Offset: 0x00041854
		// Note: this type is marked as 'beforefieldinit'.
		static NexusPlayerWindowsUnityProfile()
		{
			Il2CppClassPointerStore<NexusPlayerWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "NexusPlayerWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NexusPlayerWindowsUnityProfile>.NativeClassPtr);
			NexusPlayerWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexusPlayerWindowsUnityProfile>.NativeClassPtr, 100665596);
			NexusPlayerWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NexusPlayerWindowsUnityProfile>.NativeClassPtr, 100665597);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x000436AC File Offset: 0x000418AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846012, XrefRangeEnd = 846180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NexusPlayerWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x000436E8 File Offset: 0x000418E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 846180, XrefRangeEnd = 846184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NexusPlayerWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NexusPlayerWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NexusPlayerWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00006EC3 File Offset: 0x000050C3
		public NexusPlayerWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
