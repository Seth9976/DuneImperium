using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001CF RID: 463
	public class RazerServalForgeTVUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001072 RID: 4210 RVA: 0x00041774 File Offset: 0x0003F974
		// Note: this type is marked as 'beforefieldinit'.
		static RazerServalForgeTVUnityProfile()
		{
			Il2CppClassPointerStore<RazerServalForgeTVUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "RazerServalForgeTVUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RazerServalForgeTVUnityProfile>.NativeClassPtr);
			RazerServalForgeTVUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RazerServalForgeTVUnityProfile>.NativeClassPtr, 100665520);
			RazerServalForgeTVUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RazerServalForgeTVUnityProfile>.NativeClassPtr, 100665521);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x000417CC File Offset: 0x0003F9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 837464, XrefRangeEnd = 837675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RazerServalForgeTVUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00041808 File Offset: 0x0003FA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 837675, XrefRangeEnd = 837679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RazerServalForgeTVUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RazerServalForgeTVUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RazerServalForgeTVUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00006D6D File Offset: 0x00004F6D
		public RazerServalForgeTVUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
