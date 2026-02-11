using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace TMPro
{
	// Token: 0x02000049 RID: 73
	public class TMP_ResourceManager : Object
	{
		// Token: 0x06000813 RID: 2067 RVA: 0x00025548 File Offset: 0x00023748
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_ResourceManager()
		{
			Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_ResourceManager");
			TMP_ResourceManager.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_instance");
			TMP_ResourceManager.NativeFieldInfoPtr_s_TextSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_TextSettings");
			TMP_ResourceManager.NativeFieldInfoPtr_s_FontAssetReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_FontAssetReferences");
			TMP_ResourceManager.NativeFieldInfoPtr_s_FontAssetReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_FontAssetReferenceLookup");
			TMP_ResourceManager.NativeMethodInfoPtr_GetTextSettings_Internal_Static_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664257);
			TMP_ResourceManager.NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664258);
			TMP_ResourceManager.NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664259);
			TMP_ResourceManager.NativeMethodInfoPtr_RebuildFontAssetCache_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664260);
			TMP_ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664261);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00025624 File Offset: 0x00023824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044803, XrefRangeEnd = 1044824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Settings GetTextSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ResourceManager.NativeMethodInfoPtr_GetTextSettings_Internal_Static_TMP_Settings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr3) : null;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00025658 File Offset: 0x00023858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044824, XrefRangeEnd = 1044843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddFontAsset(TMP_FontAsset fontAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ResourceManager.NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00025690 File Offset: 0x00023890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044843, XrefRangeEnd = 1044877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashcode;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_ResourceManager.NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			fontAsset = ((intPtr4 == 0) ? null : new TMP_FontAsset(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x000256F0 File Offset: 0x000238F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044877, XrefRangeEnd = 1044892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RebuildFontAssetCache(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ResourceManager.NativeMethodInfoPtr_RebuildFontAssetCache_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00025724 File Offset: 0x00023924
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ResourceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ResourceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00005C4D File Offset: 0x00003E4D
		public TMP_ResourceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00025760 File Offset: 0x00023960
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00005C56 File Offset: 0x00003E56
		public unsafe static TMP_ResourceManager s_instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_ResourceManager.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ResourceManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ResourceManager.NativeFieldInfoPtr_s_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00025788 File Offset: 0x00023988
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x00005C68 File Offset: 0x00003E68
		public unsafe static TMP_Settings s_TextSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_ResourceManager.NativeFieldInfoPtr_s_TextSettings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ResourceManager.NativeFieldInfoPtr_s_TextSettings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x000257B0 File Offset: 0x000239B0
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00005C7A File Offset: 0x00003E7A
		public unsafe static List<TMP_FontAsset> s_FontAssetReferences
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_ResourceManager.NativeFieldInfoPtr_s_FontAssetReferences, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ResourceManager.NativeFieldInfoPtr_s_FontAssetReferences, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x000257D8 File Offset: 0x000239D8
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00005C8C File Offset: 0x00003E8C
		public unsafe static Dictionary<int, TMP_FontAsset> s_FontAssetReferenceLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_ResourceManager.NativeFieldInfoPtr_s_FontAssetReferenceLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ResourceManager.NativeFieldInfoPtr_s_FontAssetReferenceLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeFieldInfoPtr_s_instance;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeFieldInfoPtr_s_TextSettings;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeFieldInfoPtr_s_FontAssetReferences;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeFieldInfoPtr_s_FontAssetReferenceLookup;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_GetTextSettings_Internal_Static_TMP_Settings_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_TMP_FontAsset_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFontAsset_Public_Static_Boolean_Int32_byref_TMP_FontAsset_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_RebuildFontAssetCache_Internal_Static_Void_Int32_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
