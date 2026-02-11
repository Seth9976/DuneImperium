using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D4 RID: 468
	[Serializable]
	public class ThemeStyleSheet : StyleSheet
	{
		// Token: 0x06002466 RID: 9318 RVA: 0x000A33FC File Offset: 0x000A15FC
		// Note: this type is marked as 'beforefieldinit'.
		static ThemeStyleSheet()
		{
			Il2CppClassPointerStore<ThemeStyleSheet>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ThemeStyleSheet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThemeStyleSheet>.NativeClassPtr);
			ThemeStyleSheet.NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeStyleSheet>.NativeClassPtr, 100668809);
			ThemeStyleSheet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThemeStyleSheet>.NativeClassPtr, 100668810);
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x000A3454 File Offset: 0x000A1654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338340, XrefRangeEnd = 338342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThemeStyleSheet.NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x000A3490 File Offset: 0x000A1690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338342, XrefRangeEnd = 338346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThemeStyleSheet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThemeStyleSheet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThemeStyleSheet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0000EFCA File Offset: 0x0000D1CA
		public ThemeStyleSheet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Internal_Virtual_Void_0;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
