using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000058 RID: 88
	[Serializable]
	public class TMP_StyleSheet : ScriptableObject
	{
		// Token: 0x060009DF RID: 2527 RVA: 0x0002A0F8 File Offset: 0x000282F8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_StyleSheet()
		{
			Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_StyleSheet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr);
			TMP_StyleSheet.NativeFieldInfoPtr_m_StyleList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, "m_StyleList");
			TMP_StyleSheet.NativeFieldInfoPtr_m_StyleLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, "m_StyleLookupDictionary");
			TMP_StyleSheet.NativeMethodInfoPtr_get_styles_Internal_get_List_1_TMP_Style_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664391);
			TMP_StyleSheet.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664392);
			TMP_StyleSheet.NativeMethodInfoPtr_GetStyle_Public_TMP_Style_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664393);
			TMP_StyleSheet.NativeMethodInfoPtr_GetStyle_Public_TMP_Style_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664394);
			TMP_StyleSheet.NativeMethodInfoPtr_RefreshStyles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664395);
			TMP_StyleSheet.NativeMethodInfoPtr_LoadStyleDictionaryInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664396);
			TMP_StyleSheet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr, 100664397);
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0002A1DC File Offset: 0x000283DC
		public unsafe List<TMP_Style> styles
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr_get_styles_Internal_get_List_1_TMP_Style_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_Style>>(intPtr3) : null;
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0002A21C File Offset: 0x0002841C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046483, XrefRangeEnd = 1046484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0002A250 File Offset: 0x00028450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1046488, RefRangeEnd = 1046490, XrefRangeStart = 1046484, XrefRangeEnd = 1046488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Style GetStyle(int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr_GetStyle_Public_TMP_Style_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr3) : null;
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002A29C File Offset: 0x0002849C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046490, XrefRangeEnd = 1046498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Style GetStyle(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr_GetStyle_Public_TMP_Style_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr3) : null;
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0002A2EC File Offset: 0x000284EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshStyles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr_RefreshStyles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0002A320 File Offset: 0x00028520
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1046549, RefRangeEnd = 1046553, XrefRangeStart = 1046498, XrefRangeEnd = 1046549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadStyleDictionaryInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr_LoadStyleDictionaryInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0002A354 File Offset: 0x00028554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046553, XrefRangeEnd = 1046561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_StyleSheet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_StyleSheet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_StyleSheet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0000695C File Offset: 0x00004B5C
		public TMP_StyleSheet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0002A390 File Offset: 0x00028590
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x00006965 File Offset: 0x00004B65
		public unsafe List<TMP_Style> m_StyleList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_StyleSheet.NativeFieldInfoPtr_m_StyleList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Style>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_StyleSheet.NativeFieldInfoPtr_m_StyleList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0002A3C0 File Offset: 0x000285C0
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x00006984 File Offset: 0x00004B84
		public unsafe Dictionary<int, TMP_Style> m_StyleLookupDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_StyleSheet.NativeFieldInfoPtr_m_StyleLookupDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TMP_Style>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_StyleSheet.NativeFieldInfoPtr_m_StyleLookupDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleList;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleLookupDictionary;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_get_styles_Internal_get_List_1_TMP_Style_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Public_TMP_Style_Int32_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Public_TMP_Style_String_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_RefreshStyles_Public_Void_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_LoadStyleDictionaryInternal_Private_Void_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
