using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000024 RID: 36
	public class MSCompatUnicodeTable : Object
	{
		// Token: 0x06000116 RID: 278 RVA: 0x000295E8 File Offset: 0x000277E8
		// Note: this type is marked as 'beforefieldinit'.
		static MSCompatUnicodeTable()
		{
			Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "MSCompatUnicodeTable");
			MSCompatUnicodeTable.NativeFieldInfoPtr_MaxExpansionLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "MaxExpansionLength");
			MSCompatUnicodeTable.NativeFieldInfoPtr_ignorableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "ignorableFlags");
			MSCompatUnicodeTable.NativeFieldInfoPtr_categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "categories");
			MSCompatUnicodeTable.NativeFieldInfoPtr_level1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "level1");
			MSCompatUnicodeTable.NativeFieldInfoPtr_level2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "level2");
			MSCompatUnicodeTable.NativeFieldInfoPtr_level3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "level3");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHScategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkCHScategory");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHTcategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkCHTcategory");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkJAcategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkJAcategory");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOcategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkKOcategory");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHSlv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkCHSlv1");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHTlv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkCHTlv1");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkJAlv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkJAlv1");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOlv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkKOlv1");
			MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOlv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "cjkKOlv2");
			MSCompatUnicodeTable.NativeFieldInfoPtr_tailoringArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "tailoringArr");
			MSCompatUnicodeTable.NativeFieldInfoPtr_tailoringInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "tailoringInfos");
			MSCompatUnicodeTable.NativeFieldInfoPtr_forLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "forLock");
			MSCompatUnicodeTable.NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "isReady");
			MSCompatUnicodeTable.NativeMethodInfoPtr_GetTailoringInfo_Public_Static_TailoringInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663494);
			MSCompatUnicodeTable.NativeMethodInfoPtr_BuildTailoringTables_Public_Static_Void_CultureInfo_TailoringInfo_byref_Il2CppReferenceArray_1_Contraction_byref_Il2CppReferenceArray_1_Level2Map_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663495);
			MSCompatUnicodeTable.NativeMethodInfoPtr_SetCJKReferences_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663496);
			MSCompatUnicodeTable.NativeMethodInfoPtr_Category_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663497);
			MSCompatUnicodeTable.NativeMethodInfoPtr_Level1_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663498);
			MSCompatUnicodeTable.NativeMethodInfoPtr_Level2_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663499);
			MSCompatUnicodeTable.NativeMethodInfoPtr_Level3_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663500);
			MSCompatUnicodeTable.NativeMethodInfoPtr_IsIgnorable_Public_Static_Boolean_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663501);
			MSCompatUnicodeTable.NativeMethodInfoPtr_IsIgnorableNonSpacing_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663502);
			MSCompatUnicodeTable.NativeMethodInfoPtr_ToKanaTypeInsensitive_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663503);
			MSCompatUnicodeTable.NativeMethodInfoPtr_ToWidthCompat_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663504);
			MSCompatUnicodeTable.NativeMethodInfoPtr_HasSpecialWeight_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663505);
			MSCompatUnicodeTable.NativeMethodInfoPtr_IsHalfWidthKana_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663506);
			MSCompatUnicodeTable.NativeMethodInfoPtr_IsHiragana_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663507);
			MSCompatUnicodeTable.NativeMethodInfoPtr_IsJapaneseSmallLetter_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663508);
			MSCompatUnicodeTable.NativeMethodInfoPtr_get_IsReady_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663509);
			MSCompatUnicodeTable.NativeMethodInfoPtr_GetResource_Private_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663510);
			MSCompatUnicodeTable.NativeMethodInfoPtr_UInt32FromBytePtr_Private_Static_UInt32_ptr_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663511);
			MSCompatUnicodeTable.NativeMethodInfoPtr_FillCJK_Public_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663513);
			MSCompatUnicodeTable.NativeMethodInfoPtr_FillCJKCore_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, 100663514);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0002991C File Offset: 0x00027B1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1276486, RefRangeEnd = 1276488, XrefRangeStart = 1276477, XrefRangeEnd = 1276486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TailoringInfo GetTailoringInfo(int lcid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lcid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_GetTailoringInfo_Public_Static_TailoringInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TailoringInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0002995C File Offset: 0x00027B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276594, RefRangeEnd = 1276595, XrefRangeStart = 1276488, XrefRangeEnd = 1276594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Il2CppReferenceArray<Contraction> contractions, ref Il2CppReferenceArray<Level2Map> diacriticals)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(contractions);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(diacriticals);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_BuildTailoringTables_Public_Static_Void_CultureInfo_TailoringInfo_byref_Il2CppReferenceArray_1_Contraction_byref_Il2CppReferenceArray_1_Level2Map_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			contractions = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<Contraction>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			diacriticals = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Level2Map>(intPtr6));
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000299F4 File Offset: 0x00027BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276641, RefRangeEnd = 1276642, XrefRangeStart = 1276595, XrefRangeEnd = 1276641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cjkIndexer);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(catTable);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(lv1Table);
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(lv2Indexer);
			ptr5 = &intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5 = IL2CPP.Il2CppObjectBaseToPtr(lv2Table);
			ptr6 = &intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_SetCJKReferences_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, 0, (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
			IntPtr intPtr8 = intPtr;
			cjkIndexer = ((intPtr8 == 0) ? null : new CodePointIndexer(intPtr8));
			IntPtr intPtr9 = intPtr2;
			catTable = ((intPtr9 == 0) ? null : new byte*(intPtr9));
			IntPtr intPtr10 = intPtr3;
			lv1Table = ((intPtr10 == 0) ? null : new byte*(intPtr10));
			IntPtr intPtr11 = intPtr4;
			lv2Indexer = ((intPtr11 == 0) ? null : new CodePointIndexer(intPtr11));
			IntPtr intPtr12 = intPtr5;
			lv2Table = ((intPtr12 == 0) ? null : new byte*(intPtr12));
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00029AFC File Offset: 0x00027CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276642, XrefRangeEnd = 1276651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Category(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_Category_Public_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00029B3C File Offset: 0x00027D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276651, XrefRangeEnd = 1276660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Level1(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_Level1_Public_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00029B7C File Offset: 0x00027D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276669, RefRangeEnd = 1276670, XrefRangeStart = 1276660, XrefRangeEnd = 1276669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Level2(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_Level2_Public_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00029BBC File Offset: 0x00027DBC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1276679, RefRangeEnd = 1276687, XrefRangeStart = 1276670, XrefRangeEnd = 1276679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Level3(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_Level3_Public_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00029BFC File Offset: 0x00027DFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1276697, RefRangeEnd = 1276700, XrefRangeStart = 1276687, XrefRangeEnd = 1276697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIgnorable(int cp, byte flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_IsIgnorable_Public_Static_Boolean_Int32_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00029C48 File Offset: 0x00027E48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1276704, RefRangeEnd = 1276709, XrefRangeStart = 1276700, XrefRangeEnd = 1276704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIgnorableNonSpacing(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_IsIgnorableNonSpacing_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00029C88 File Offset: 0x00027E88
		[CallerCount(0)]
		public unsafe static int ToKanaTypeInsensitive(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_ToKanaTypeInsensitive_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00029CC8 File Offset: 0x00027EC8
		[CallerCount(0)]
		public unsafe static int ToWidthCompat(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_ToWidthCompat_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00029D08 File Offset: 0x00027F08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1276709, RefRangeEnd = 1276714, XrefRangeStart = 1276709, XrefRangeEnd = 1276709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasSpecialWeight(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_HasSpecialWeight_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00029D48 File Offset: 0x00027F48
		[CallerCount(0)]
		public unsafe static bool IsHalfWidthKana(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_IsHalfWidthKana_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00029D88 File Offset: 0x00027F88
		[CallerCount(0)]
		public unsafe static bool IsHiragana(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_IsHiragana_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00029DC8 File Offset: 0x00027FC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1276714, RefRangeEnd = 1276718, XrefRangeStart = 1276714, XrefRangeEnd = 1276714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsJapaneseSmallLetter(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_IsJapaneseSmallLetter_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00029E08 File Offset: 0x00028008
		public unsafe static bool IsReady
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276718, XrefRangeEnd = 1276722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_get_IsReady_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00029E38 File Offset: 0x00028038
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1276728, RefRangeEnd = 1276730, XrefRangeStart = 1276722, XrefRangeEnd = 1276728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetResource(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_GetResource_Private_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00029E7C File Offset: 0x0002807C
		[CallerCount(0)]
		public unsafe static uint UInt32FromBytePtr(byte* raw, uint idx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = raw;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_UInt32FromBytePtr_Private_Static_UInt32_ptr_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00029EC8 File Offset: 0x000280C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1276742, RefRangeEnd = 1276744, XrefRangeStart = 1276730, XrefRangeEnd = 1276742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(culture);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cjkIndexer);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(catTable);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(lv1Table);
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(lv2Indexer);
			ptr5 = &intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5 = IL2CPP.Il2CppObjectBaseToPtr(lv2Table);
			ptr6 = &intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_FillCJK_Public_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, 0, (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
			IntPtr intPtr8 = intPtr;
			cjkIndexer = ((intPtr8 == 0) ? null : new CodePointIndexer(intPtr8));
			IntPtr intPtr9 = intPtr2;
			catTable = ((intPtr9 == 0) ? null : new byte*(intPtr9));
			IntPtr intPtr10 = intPtr3;
			lv1Table = ((intPtr10 == 0) ? null : new byte*(intPtr10));
			IntPtr intPtr11 = intPtr4;
			lv2Indexer = ((intPtr11 == 0) ? null : new CodePointIndexer(intPtr11));
			IntPtr intPtr12 = intPtr5;
			lv2Table = ((intPtr12 == 0) ? null : new byte*(intPtr12));
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00029FD0 File Offset: 0x000281D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276840, RefRangeEnd = 1276841, XrefRangeStart = 1276744, XrefRangeEnd = 1276840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(culture);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(cjkIndexer);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(catTable);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(lv1Table);
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(cjkLv2Indexer);
			ptr5 = &intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5 = IL2CPP.Il2CppObjectBaseToPtr(lv2Table);
			ptr6 = &intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.NativeMethodInfoPtr_FillCJKCore_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, 0, (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
			IntPtr intPtr8 = intPtr;
			cjkIndexer = ((intPtr8 == 0) ? null : new CodePointIndexer(intPtr8));
			IntPtr intPtr9 = intPtr2;
			catTable = ((intPtr9 == 0) ? null : new byte*(intPtr9));
			IntPtr intPtr10 = intPtr3;
			lv1Table = ((intPtr10 == 0) ? null : new byte*(intPtr10));
			IntPtr intPtr11 = intPtr4;
			cjkLv2Indexer = ((intPtr11 == 0) ? null : new CodePointIndexer(intPtr11));
			IntPtr intPtr12 = intPtr5;
			lv2Table = ((intPtr12 == 0) ? null : new byte*(intPtr12));
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002796 File Offset: 0x00000996
		public MSCompatUnicodeTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0002A0D8 File Offset: 0x000282D8
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0000279F File Offset: 0x0000099F
		public unsafe static int MaxExpansionLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_MaxExpansionLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_MaxExpansionLength, (void*)(&value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0002A0F4 File Offset: 0x000282F4
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000027AD File Offset: 0x000009AD
		public unsafe static byte* ignorableFlags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_ignorableFlags, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_ignorableFlags, (void*)value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0002A110 File Offset: 0x00028310
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000027BA File Offset: 0x000009BA
		public unsafe static byte* categories
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_categories, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_categories, (void*)value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0002A12C File Offset: 0x0002832C
		// (set) Token: 0x06000133 RID: 307 RVA: 0x000027C7 File Offset: 0x000009C7
		public unsafe static byte* level1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_level1, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_level1, (void*)value);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0002A148 File Offset: 0x00028348
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000027D4 File Offset: 0x000009D4
		public unsafe static byte* level2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_level2, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_level2, (void*)value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0002A164 File Offset: 0x00028364
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000027E1 File Offset: 0x000009E1
		public unsafe static byte* level3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_level3, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_level3, (void*)value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0002A180 File Offset: 0x00028380
		// (set) Token: 0x06000139 RID: 313 RVA: 0x000027EE File Offset: 0x000009EE
		public unsafe static byte* cjkCHScategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHScategory, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHScategory, (void*)value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0002A19C File Offset: 0x0002839C
		// (set) Token: 0x0600013B RID: 315 RVA: 0x000027FB File Offset: 0x000009FB
		public unsafe static byte* cjkCHTcategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHTcategory, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHTcategory, (void*)value);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0002A1B8 File Offset: 0x000283B8
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00002808 File Offset: 0x00000A08
		public unsafe static byte* cjkJAcategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkJAcategory, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkJAcategory, (void*)value);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0002A1D4 File Offset: 0x000283D4
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00002815 File Offset: 0x00000A15
		public unsafe static byte* cjkKOcategory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOcategory, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOcategory, (void*)value);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0002A1F0 File Offset: 0x000283F0
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002822 File Offset: 0x00000A22
		public unsafe static byte* cjkCHSlv1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHSlv1, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHSlv1, (void*)value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0002A20C File Offset: 0x0002840C
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0000282F File Offset: 0x00000A2F
		public unsafe static byte* cjkCHTlv1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHTlv1, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkCHTlv1, (void*)value);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0002A228 File Offset: 0x00028428
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0000283C File Offset: 0x00000A3C
		public unsafe static byte* cjkJAlv1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkJAlv1, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkJAlv1, (void*)value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0002A244 File Offset: 0x00028444
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00002849 File Offset: 0x00000A49
		public unsafe static byte* cjkKOlv1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOlv1, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOlv1, (void*)value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0002A260 File Offset: 0x00028460
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002856 File Offset: 0x00000A56
		public unsafe static byte* cjkKOlv2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOlv2, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_cjkKOlv2, (void*)value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0002A27C File Offset: 0x0002847C
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002863 File Offset: 0x00000A63
		public unsafe static Il2CppStructArray<char> tailoringArr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_tailoringArr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_tailoringArr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0002A2A4 File Offset: 0x000284A4
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002875 File Offset: 0x00000A75
		public unsafe static Il2CppReferenceArray<TailoringInfo> tailoringInfos
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_tailoringInfos, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TailoringInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_tailoringInfos, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0002A2CC File Offset: 0x000284CC
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002887 File Offset: 0x00000A87
		public unsafe static Object forLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_forLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_forLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0002A2F4 File Offset: 0x000284F4
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002899 File Offset: 0x00000A99
		public unsafe static bool isReady
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.NativeFieldInfoPtr_isReady, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.NativeFieldInfoPtr_isReady, (void*)(&value));
			}
		}

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_MaxExpansionLength;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_ignorableFlags;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_categories;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr_level1;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_level2;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_level3;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_cjkCHScategory;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_cjkCHTcategory;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_cjkJAcategory;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_cjkKOcategory;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_cjkCHSlv1;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_cjkCHTlv1;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_cjkJAlv1;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_cjkKOlv1;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_cjkKOlv2;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_tailoringArr;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_tailoringInfos;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_forLock;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_isReady;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_GetTailoringInfo_Public_Static_TailoringInfo_Int32_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_BuildTailoringTables_Public_Static_Void_CultureInfo_TailoringInfo_byref_Il2CppReferenceArray_1_Contraction_byref_Il2CppReferenceArray_1_Level2Map_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_SetCJKReferences_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_Category_Public_Static_Byte_Int32_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_Level1_Public_Static_Byte_Int32_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_Level2_Public_Static_Byte_Int32_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_Level3_Public_Static_Byte_Int32_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_IsIgnorable_Public_Static_Boolean_Int32_Byte_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_IsIgnorableNonSpacing_Public_Static_Boolean_Int32_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_ToKanaTypeInsensitive_Public_Static_Int32_Int32_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_ToWidthCompat_Public_Static_Int32_Int32_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_HasSpecialWeight_Public_Static_Boolean_Char_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_IsHalfWidthKana_Public_Static_Boolean_Char_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_IsHiragana_Public_Static_Boolean_Char_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_IsJapaneseSmallLetter_Public_Static_Boolean_Char_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReady_Public_Static_get_Boolean_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_GetResource_Private_Static_IntPtr_String_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_UInt32FromBytePtr_Private_Static_UInt32_ptr_Byte_UInt32_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_FillCJK_Public_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_FillCJKCore_Private_Static_Void_String_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

		// Token: 0x02000569 RID: 1385
		[ObfuscatedName("Mono.Globalization.Unicode.MSCompatUnicodeTable+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060055BB RID: 21947 RVA: 0x0018C694 File Offset: 0x0018A894
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSCompatUnicodeTable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr);
				MSCompatUnicodeTable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr, "<>9");
				MSCompatUnicodeTable.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr, "<>9__17_0");
				MSCompatUnicodeTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr, 100663516);
				MSCompatUnicodeTable.__c.NativeMethodInfoPtr__BuildTailoringTables_b__17_0_Internal_Int32_Level2Map_Level2Map_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr, 100663517);
			}

			// Token: 0x060055BC RID: 21948 RVA: 0x0018C710 File Offset: 0x0018A910
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSCompatUnicodeTable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055BD RID: 21949 RVA: 0x0018C74C File Offset: 0x0018A94C
			[CallerCount(0)]
			public unsafe int _BuildTailoringTables_b__17_0(Level2Map a, Level2Map b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSCompatUnicodeTable.__c.NativeMethodInfoPtr__BuildTailoringTables_b__17_0_Internal_Int32_Level2Map_Level2Map_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060055BE RID: 21950 RVA: 0x0001E6CE File Offset: 0x0001C8CE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015EB RID: 5611
			// (get) Token: 0x060055BF RID: 21951 RVA: 0x0018C7AC File Offset: 0x0018A9AC
			// (set) Token: 0x060055C0 RID: 21952 RVA: 0x0001E6D7 File Offset: 0x0001C8D7
			public unsafe static MSCompatUnicodeTable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSCompatUnicodeTable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015EC RID: 5612
			// (get) Token: 0x060055C1 RID: 21953 RVA: 0x0018C7D4 File Offset: 0x0018A9D4
			// (set) Token: 0x060055C2 RID: 21954 RVA: 0x0001E6E9 File Offset: 0x0001C8E9
			public unsafe static Comparison<Level2Map> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MSCompatUnicodeTable.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Level2Map>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MSCompatUnicodeTable.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045E9 RID: 17897
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040045EA RID: 17898
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x040045EB RID: 17899
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040045EC RID: 17900
			private static readonly IntPtr NativeMethodInfoPtr__BuildTailoringTables_b__17_0_Internal_Int32_Level2Map_Level2Map_0;
		}
	}
}
