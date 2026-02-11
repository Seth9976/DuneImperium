using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001C9 RID: 457
	public class GameStickUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600105A RID: 4186 RVA: 0x00041294 File Offset: 0x0003F494
		// Note: this type is marked as 'beforefieldinit'.
		static GameStickUnityProfile()
		{
			Il2CppClassPointerStore<GameStickUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "GameStickUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameStickUnityProfile>.NativeClassPtr);
			GameStickUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStickUnityProfile>.NativeClassPtr, 100665508);
			GameStickUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStickUnityProfile>.NativeClassPtr, 100665509);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x000412EC File Offset: 0x0003F4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836280, XrefRangeEnd = 836429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameStickUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00041328 File Offset: 0x0003F528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836429, XrefRangeEnd = 836433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameStickUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameStickUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameStickUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00006D37 File Offset: 0x00004F37
		public GameStickUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
