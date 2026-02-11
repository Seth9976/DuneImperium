using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001A5 RID: 421
	public class MogaProLinuxUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000FCA RID: 4042 RVA: 0x0003F554 File Offset: 0x0003D754
		// Note: this type is marked as 'beforefieldinit'.
		static MogaProLinuxUnityProfile()
		{
			Il2CppClassPointerStore<MogaProLinuxUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "MogaProLinuxUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MogaProLinuxUnityProfile>.NativeClassPtr);
			MogaProLinuxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MogaProLinuxUnityProfile>.NativeClassPtr, 100665436);
			MogaProLinuxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MogaProLinuxUnityProfile>.NativeClassPtr, 100665437);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0003F5AC File Offset: 0x0003D7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 829719, XrefRangeEnd = 829888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MogaProLinuxUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0003F5E8 File Offset: 0x0003D7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 829888, XrefRangeEnd = 829892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MogaProLinuxUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MogaProLinuxUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MogaProLinuxUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00006BF3 File Offset: 0x00004DF3
		public MogaProLinuxUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
