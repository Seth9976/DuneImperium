using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000157 RID: 343
	public class GameCoreGDKProfile : InputDeviceProfile
	{
		// Token: 0x06000E92 RID: 3730 RVA: 0x0003B5F4 File Offset: 0x000397F4
		// Note: this type is marked as 'beforefieldinit'.
		static GameCoreGDKProfile()
		{
			Il2CppClassPointerStore<GameCoreGDKProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl.UnityDeviceProfiles", "GameCoreGDKProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameCoreGDKProfile>.NativeClassPtr);
			GameCoreGDKProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCoreGDKProfile>.NativeClassPtr, 100665280);
			GameCoreGDKProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCoreGDKProfile>.NativeClassPtr, 100665281);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0003B64C File Offset: 0x0003984C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816379, XrefRangeEnd = 816580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Define()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameCoreGDKProfile.NativeMethodInfoPtr_Define_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0003B688 File Offset: 0x00039888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 816580, XrefRangeEnd = 816584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameCoreGDKProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameCoreGDKProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameCoreGDKProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00006935 File Offset: 0x00004B35
		public GameCoreGDKProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr_Define_Public_Virtual_Void_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
