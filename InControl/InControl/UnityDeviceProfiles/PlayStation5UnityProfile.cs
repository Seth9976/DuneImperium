using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001CD RID: 461
	public class PlayStation5UnityProfile : InputDeviceProfile
	{
		// Token: 0x0600106A RID: 4202 RVA: 0x000415D4 File Offset: 0x0003F7D4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayStation5UnityProfile()
		{
			Il2CppClassPointerStore<PlayStation5UnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "PlayStation5UnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayStation5UnityProfile>.NativeClassPtr);
			PlayStation5UnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation5UnityProfile>.NativeClassPtr, 100665516);
			PlayStation5UnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayStation5UnityProfile>.NativeClassPtr, 100665517);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0004162C File Offset: 0x0003F82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 837050, XrefRangeEnd = 837306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayStation5UnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00041668 File Offset: 0x0003F868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 837306, XrefRangeEnd = 837310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayStation5UnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayStation5UnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayStation5UnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00006D5B File Offset: 0x00004F5B
		public PlayStation5UnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
