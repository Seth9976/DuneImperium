using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D6 RID: 470
	public class PanelTextSettings : TextSettings
	{
		// Token: 0x0600247A RID: 9338 RVA: 0x000A3824 File Offset: 0x000A1A24
		// Note: this type is marked as 'beforefieldinit'.
		static PanelTextSettings()
		{
			Il2CppClassPointerStore<PanelTextSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PanelTextSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelTextSettings>.NativeClassPtr);
			PanelTextSettings.NativeFieldInfoPtr_s_DefaultPanelTextSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelTextSettings>.NativeClassPtr, "s_DefaultPanelTextSettings");
			PanelTextSettings.NativeFieldInfoPtr_EditorGUIUtilityLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelTextSettings>.NativeClassPtr, "EditorGUIUtilityLoad");
			PanelTextSettings.NativeFieldInfoPtr_GetCurrentLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelTextSettings>.NativeClassPtr, "GetCurrentLanguage");
			PanelTextSettings.NativeFieldInfoPtr_s_DefaultEditorPanelTextSettingPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelTextSettings>.NativeClassPtr, "s_DefaultEditorPanelTextSettingPath");
			PanelTextSettings.NativeMethodInfoPtr_get_defaultPanelTextSettings_Internal_Static_get_PanelTextSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelTextSettings>.NativeClassPtr, 100668823);
			PanelTextSettings.NativeMethodInfoPtr_UpdateLocalizationFontAsset_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelTextSettings>.NativeClassPtr, 100668824);
			PanelTextSettings.NativeMethodInfoPtr_GetCachedFontAsset_Internal_FontAsset_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelTextSettings>.NativeClassPtr, 100668825);
			PanelTextSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelTextSettings>.NativeClassPtr, 100668826);
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x000A38F4 File Offset: 0x000A1AF4
		public unsafe static PanelTextSettings defaultPanelTextSettings
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 338457, RefRangeEnd = 338462, XrefRangeStart = 338432, XrefRangeEnd = 338457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelTextSettings.NativeMethodInfoPtr_get_defaultPanelTextSettings_Internal_Static_get_PanelTextSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PanelTextSettings>(intPtr3) : null;
			}
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x000A3928 File Offset: 0x000A1B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338462, XrefRangeEnd = 338573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateLocalizationFontAsset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelTextSettings.NativeMethodInfoPtr_UpdateLocalizationFontAsset_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x000A3950 File Offset: 0x000A1B50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338574, RefRangeEnd = 338575, XrefRangeStart = 338573, XrefRangeEnd = 338574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontAsset GetCachedFontAsset(Font font)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelTextSettings.NativeMethodInfoPtr_GetCachedFontAsset_Internal_FontAsset_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr3) : null;
			}
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x000A39A0 File Offset: 0x000A1BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338575, XrefRangeEnd = 338576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PanelTextSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanelTextSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelTextSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x0000F041 File Offset: 0x0000D241
		public PanelTextSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x000A39DC File Offset: 0x000A1BDC
		// (set) Token: 0x06002481 RID: 9345 RVA: 0x0000F04A File Offset: 0x0000D24A
		public unsafe static PanelTextSettings s_DefaultPanelTextSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PanelTextSettings.NativeFieldInfoPtr_s_DefaultPanelTextSettings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PanelTextSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PanelTextSettings.NativeFieldInfoPtr_s_DefaultPanelTextSettings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x000A3A04 File Offset: 0x000A1C04
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x0000F05C File Offset: 0x0000D25C
		public unsafe static Func<string, Object> EditorGUIUtilityLoad
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PanelTextSettings.NativeFieldInfoPtr_EditorGUIUtilityLoad, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PanelTextSettings.NativeFieldInfoPtr_EditorGUIUtilityLoad, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x000A3A2C File Offset: 0x000A1C2C
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x0000F06E File Offset: 0x0000D26E
		public unsafe static Func<SystemLanguage> GetCurrentLanguage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PanelTextSettings.NativeFieldInfoPtr_GetCurrentLanguage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SystemLanguage>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PanelTextSettings.NativeFieldInfoPtr_GetCurrentLanguage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x000A3A54 File Offset: 0x000A1C54
		// (set) Token: 0x06002487 RID: 9351 RVA: 0x0000F080 File Offset: 0x0000D280
		public unsafe static string s_DefaultEditorPanelTextSettingPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PanelTextSettings.NativeFieldInfoPtr_s_DefaultEditorPanelTextSettingPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PanelTextSettings.NativeFieldInfoPtr_s_DefaultEditorPanelTextSettingPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultPanelTextSettings;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeFieldInfoPtr_EditorGUIUtilityLoad;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeFieldInfoPtr_GetCurrentLanguage;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultEditorPanelTextSettingPath;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultPanelTextSettings_Internal_Static_get_PanelTextSettings_0;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLocalizationFontAsset_Internal_Static_Void_0;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedFontAsset_Internal_FontAsset_Font_0;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
