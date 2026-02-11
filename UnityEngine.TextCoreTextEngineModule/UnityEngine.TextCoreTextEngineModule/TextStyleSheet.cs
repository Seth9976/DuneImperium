using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200003B RID: 59
	[Serializable]
	public class TextStyleSheet : ScriptableObject
	{
		// Token: 0x060006D3 RID: 1747 RVA: 0x0001B07C File Offset: 0x0001927C
		// Note: this type is marked as 'beforefieldinit'.
		static TextStyleSheet()
		{
			Il2CppClassPointerStore<TextStyleSheet>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextStyleSheet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextStyleSheet>.NativeClassPtr);
			TextStyleSheet.NativeFieldInfoPtr_m_StyleList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStyleSheet>.NativeClassPtr, "m_StyleList");
			TextStyleSheet.NativeFieldInfoPtr_m_StyleLookupDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextStyleSheet>.NativeClassPtr, "m_StyleLookupDictionary");
			TextStyleSheet.NativeMethodInfoPtr_get_styles_Internal_get_List_1_TextStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStyleSheet>.NativeClassPtr, 100663750);
			TextStyleSheet.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStyleSheet>.NativeClassPtr, 100663751);
			TextStyleSheet.NativeMethodInfoPtr_GetStyle_Public_TextStyle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStyleSheet>.NativeClassPtr, 100663752);
			TextStyleSheet.NativeMethodInfoPtr_GetStyle_Public_TextStyle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStyleSheet>.NativeClassPtr, 100663753);
			TextStyleSheet.NativeMethodInfoPtr_RefreshStyles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStyleSheet>.NativeClassPtr, 100663754);
			TextStyleSheet.NativeMethodInfoPtr_LoadStyleDictionaryInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStyleSheet>.NativeClassPtr, 100663755);
			TextStyleSheet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextStyleSheet>.NativeClassPtr, 100663756);
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0001B160 File Offset: 0x00019360
		public unsafe List<TextStyle> styles
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 318167, RefRangeEnd = 318212, XrefRangeStart = 318167, XrefRangeEnd = 318212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStyleSheet.NativeMethodInfoPtr_get_styles_Internal_get_List_1_TextStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TextStyle>>(intPtr3) : null;
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0001B1A0 File Offset: 0x000193A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106176, XrefRangeEnd = 1106177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStyleSheet.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0001B1D4 File Offset: 0x000193D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1106181, RefRangeEnd = 1106183, XrefRangeStart = 1106177, XrefRangeEnd = 1106181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextStyle GetStyle(int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStyleSheet.NativeMethodInfoPtr_GetStyle_Public_TextStyle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextStyle>(intPtr3) : null;
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0001B220 File Offset: 0x00019420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106183, XrefRangeEnd = 1106188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextStyle GetStyle(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStyleSheet.NativeMethodInfoPtr_GetStyle_Public_TextStyle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextStyle>(intPtr3) : null;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001B270 File Offset: 0x00019470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshStyles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStyleSheet.NativeMethodInfoPtr_RefreshStyles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001B2A4 File Offset: 0x000194A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1106245, RefRangeEnd = 1106249, XrefRangeStart = 1106188, XrefRangeEnd = 1106245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadStyleDictionaryInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStyleSheet.NativeMethodInfoPtr_LoadStyleDictionaryInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0001B2D8 File Offset: 0x000194D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106249, XrefRangeEnd = 1106257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextStyleSheet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextStyleSheet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextStyleSheet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000060CD File Offset: 0x000042CD
		public TextStyleSheet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0001B314 File Offset: 0x00019514
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x000060D6 File Offset: 0x000042D6
		public unsafe List<TextStyle> m_StyleList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyleSheet.NativeFieldInfoPtr_m_StyleList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextStyle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyleSheet.NativeFieldInfoPtr_m_StyleList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0001B344 File Offset: 0x00019544
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x000060F5 File Offset: 0x000042F5
		public unsafe Dictionary<int, TextStyle> m_StyleLookupDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyleSheet.NativeFieldInfoPtr_m_StyleLookupDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TextStyle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextStyleSheet.NativeFieldInfoPtr_m_StyleLookupDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleList;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleLookupDictionary;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_get_styles_Internal_get_List_1_TextStyle_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Public_TextStyle_Int32_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Public_TextStyle_String_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_RefreshStyles_Public_Void_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_LoadStyleDictionaryInternal_Private_Void_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
