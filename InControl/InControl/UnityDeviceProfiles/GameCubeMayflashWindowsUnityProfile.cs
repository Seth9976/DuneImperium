using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020001E6 RID: 486
	public class GameCubeMayflashWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060010CE RID: 4302 RVA: 0x00042A24 File Offset: 0x00040C24
		// Note: this type is marked as 'beforefieldinit'.
		static GameCubeMayflashWindowsUnityProfile()
		{
			Il2CppClassPointerStore<GameCubeMayflashWindowsUnityProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "GameCubeMayflashWindowsUnityProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameCubeMayflashWindowsUnityProfile>.NativeClassPtr);
			GameCubeMayflashWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCubeMayflashWindowsUnityProfile>.NativeClassPtr, 100665566);
			GameCubeMayflashWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCubeMayflashWindowsUnityProfile>.NativeClassPtr, 100665567);
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00042A7C File Offset: 0x00040C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 843132, XrefRangeEnd = 843396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameCubeMayflashWindowsUnityProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00042AB8 File Offset: 0x00040CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 843396, XrefRangeEnd = 843400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameCubeMayflashWindowsUnityProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameCubeMayflashWindowsUnityProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameCubeMayflashWindowsUnityProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00006E3C File Offset: 0x0000503C
		public GameCubeMayflashWindowsUnityProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
