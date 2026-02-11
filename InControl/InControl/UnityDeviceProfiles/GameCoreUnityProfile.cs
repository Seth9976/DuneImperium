using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001C8 RID: 456
	public class GameCoreUnityProfile : InputDeviceProfile
	{
		// Token: 0x06001056 RID: 4182 RVA: 0x000411C4 File Offset: 0x0003F3C4
		// Note: this type is marked as 'beforefieldinit'.
		static GameCoreUnityProfile()
		{
			Il2CppClassPointerStore<GameCoreUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "GameCoreUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameCoreUnityProfile>.NativeClassPtr);
			GameCoreUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCoreUnityProfile>.NativeClassPtr, 100665506);
			GameCoreUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCoreUnityProfile>.NativeClassPtr, 100665507);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0004121C File Offset: 0x0003F41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836083, XrefRangeEnd = 836276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameCoreUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00041258 File Offset: 0x0003F458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836276, XrefRangeEnd = 836280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameCoreUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameCoreUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameCoreUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00006D2E File Offset: 0x00004F2E
		public GameCoreUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
