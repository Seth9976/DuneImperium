using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000138 RID: 312
	public class GameCubeMayflashWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000E16 RID: 3606 RVA: 0x00039CC4 File Offset: 0x00037EC4
		// Note: this type is marked as 'beforefieldinit'.
		static GameCubeMayflashWindowsNativeProfile()
		{
			Il2CppClassPointerStore<GameCubeMayflashWindowsNativeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.NativeDeviceProfiles", "GameCubeMayflashWindowsNativeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameCubeMayflashWindowsNativeProfile>.NativeClassPtr);
			GameCubeMayflashWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCubeMayflashWindowsNativeProfile>.NativeClassPtr, 100665218);
			GameCubeMayflashWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCubeMayflashWindowsNativeProfile>.NativeClassPtr, 100665219);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00039D1C File Offset: 0x00037F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 807512, XrefRangeEnd = 807834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameCubeMayflashWindowsNativeProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00039D58 File Offset: 0x00037F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 807834, XrefRangeEnd = 807838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameCubeMayflashWindowsNativeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameCubeMayflashWindowsNativeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameCubeMayflashWindowsNativeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0000681E File Offset: 0x00004A1E
		public GameCubeMayflashWindowsNativeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
