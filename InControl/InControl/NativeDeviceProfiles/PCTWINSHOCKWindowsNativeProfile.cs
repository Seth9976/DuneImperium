using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000144 RID: 324
	public class PCTWINSHOCKWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000E46 RID: 3654 RVA: 0x0003A684 File Offset: 0x00038884
		// Note: this type is marked as 'beforefieldinit'.
		static PCTWINSHOCKWindowsNativeProfile()
		{
			Il2CppClassPointerStore<PCTWINSHOCKWindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "PCTWINSHOCKWindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PCTWINSHOCKWindowsNativeProfile>.NativeClassPtr);
			PCTWINSHOCKWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCTWINSHOCKWindowsNativeProfile>.NativeClassPtr, 100665242);
			PCTWINSHOCKWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCTWINSHOCKWindowsNativeProfile>.NativeClassPtr, 100665243);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0003A6DC File Offset: 0x000388DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811053, XrefRangeEnd = 811352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PCTWINSHOCKWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0003A718 File Offset: 0x00038918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 811352, XrefRangeEnd = 811356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PCTWINSHOCKWindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PCTWINSHOCKWindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PCTWINSHOCKWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0000688A File Offset: 0x00004A8A
		public PCTWINSHOCKWindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
