using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000027 RID: 39
	public class SimpleCollator : Object
	{
		// Token: 0x06000170 RID: 368 RVA: 0x0002A6D8 File Offset: 0x000288D8
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleCollator()
		{
			Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "SimpleCollator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr);
			SimpleCollator.NativeFieldInfoPtr_invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "invariant");
			SimpleCollator.NativeFieldInfoPtr_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "textInfo");
			SimpleCollator.NativeFieldInfoPtr_cjkIndexer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkIndexer");
			SimpleCollator.NativeFieldInfoPtr_contractions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "contractions");
			SimpleCollator.NativeFieldInfoPtr_level2Maps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "level2Maps");
			SimpleCollator.NativeFieldInfoPtr_unsafeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "unsafeFlags");
			SimpleCollator.NativeFieldInfoPtr_cjkCatTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkCatTable");
			SimpleCollator.NativeFieldInfoPtr_cjkLv1Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkLv1Table");
			SimpleCollator.NativeFieldInfoPtr_cjkLv2Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkLv2Table");
			SimpleCollator.NativeFieldInfoPtr_cjkLv2Indexer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "cjkLv2Indexer");
			SimpleCollator.NativeFieldInfoPtr_lcid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "lcid");
			SimpleCollator.NativeFieldInfoPtr_frenchSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "frenchSort");
			SimpleCollator.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663522);
			SimpleCollator.NativeMethodInfoPtr_SetCJKTable_Private_Void_CultureInfo_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663523);
			SimpleCollator.NativeMethodInfoPtr_GetNeutralCulture_Private_Static_CultureInfo_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663524);
			SimpleCollator.NativeMethodInfoPtr_Category_Private_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663525);
			SimpleCollator.NativeMethodInfoPtr_Level1_Private_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663526);
			SimpleCollator.NativeMethodInfoPtr_Level2_Private_Byte_Int32_ExtenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663527);
			SimpleCollator.NativeMethodInfoPtr_IsHalfKana_Private_Static_Boolean_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663528);
			SimpleCollator.NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663529);
			SimpleCollator.NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663530);
			SimpleCollator.NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663531);
			SimpleCollator.NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663532);
			SimpleCollator.NativeMethodInfoPtr_FilterOptions_Private_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663533);
			SimpleCollator.NativeMethodInfoPtr_GetExtenderType_Private_ExtenderType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663534);
			SimpleCollator.NativeMethodInfoPtr_ToDashTypeValue_Private_Static_Byte_ExtenderType_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663535);
			SimpleCollator.NativeMethodInfoPtr_FilterExtender_Private_Int32_Int32_ExtenderType_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663536);
			SimpleCollator.NativeMethodInfoPtr_IsIgnorable_Private_Static_Boolean_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663537);
			SimpleCollator.NativeMethodInfoPtr_IsSafe_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663538);
			SimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_Virtual_Final_New_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663539);
			SimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663540);
			SimpleCollator.NativeMethodInfoPtr_GetSortKey_Private_Void_String_Int32_Int32_SortKeyBuffer_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663541);
			SimpleCollator.NativeMethodInfoPtr_FillSortKeyRaw_Private_Void_Int32_ExtenderType_SortKeyBuffer_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663542);
			SimpleCollator.NativeMethodInfoPtr_FillSurrogateSortKeyRaw_Private_Void_Int32_SortKeyBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663543);
			SimpleCollator.NativeMethodInfoPtr_System_Globalization_ISimpleCollator_Compare_Private_Virtual_Final_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663544);
			SimpleCollator.NativeMethodInfoPtr_Compare_Internal_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663545);
			SimpleCollator.NativeMethodInfoPtr_ClearBuffer_Private_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663546);
			SimpleCollator.NativeMethodInfoPtr_CompareInternal_Private_Int32_String_Int32_Int32_String_Int32_Int32_byref_Boolean_byref_Boolean_Boolean_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663547);
			SimpleCollator.NativeMethodInfoPtr_CompareFlagPair_Private_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663548);
			SimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Virtual_Final_New_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663549);
			SimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663550);
			SimpleCollator.NativeMethodInfoPtr_IsPrefix_Private_Boolean_String_String_Int32_Int32_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663551);
			SimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Virtual_Final_New_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663552);
			SimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663553);
			SimpleCollator.NativeMethodInfoPtr_QuickIndexOf_Private_Int32_String_String_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663554);
			SimpleCollator.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663555);
			SimpleCollator.NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663556);
			SimpleCollator.NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663557);
			SimpleCollator.NativeMethodInfoPtr_IndexOfSortKey_Private_Int32_String_Int32_Int32_ptr_Byte_Char_Int32_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663558);
			SimpleCollator.NativeMethodInfoPtr_IndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663559);
			SimpleCollator.NativeMethodInfoPtr_LastIndexOf_Public_Virtual_Final_New_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663560);
			SimpleCollator.NativeMethodInfoPtr_LastIndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663561);
			SimpleCollator.NativeMethodInfoPtr_LastIndexOfSortKey_Private_Int32_String_Int32_Int32_Int32_ptr_Byte_Int32_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663562);
			SimpleCollator.NativeMethodInfoPtr_LastIndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663563);
			SimpleCollator.NativeMethodInfoPtr_MatchesForward_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663564);
			SimpleCollator.NativeMethodInfoPtr_MatchesForwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663565);
			SimpleCollator.NativeMethodInfoPtr_MatchesPrimitive_Private_Boolean_CompareOptions_ptr_Byte_Int32_ExtenderType_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663566);
			SimpleCollator.NativeMethodInfoPtr_MatchesBackward_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663567);
			SimpleCollator.NativeMethodInfoPtr_MatchesBackwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, 100663568);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0002ABA4 File Offset: 0x00028DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276971, RefRangeEnd = 1276972, XrefRangeStart = 1276938, XrefRangeEnd = 1276971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleCollator(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0002ABF0 File Offset: 0x00028DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276972, XrefRangeEnd = 1276980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
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
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_SetCJKTable_Private_Void_CultureInfo_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr7);
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

		// Token: 0x06000173 RID: 371 RVA: 0x0002AD04 File Offset: 0x00028F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276980, XrefRangeEnd = 1276981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetNeutralCulture(CultureInfo info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetNeutralCulture_Private_Static_CultureInfo_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0002AD48 File Offset: 0x00028F48
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1276983, RefRangeEnd = 1276994, XrefRangeStart = 1276981, XrefRangeEnd = 1276983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte Category(int cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_Category_Private_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0002AD94 File Offset: 0x00028F94
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1276996, RefRangeEnd = 1277002, XrefRangeStart = 1276994, XrefRangeEnd = 1276996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte Level1(int cp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_Level1_Private_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0002ADE0 File Offset: 0x00028FE0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1277008, RefRangeEnd = 1277021, XrefRangeStart = 1277002, XrefRangeEnd = 1277008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte Level2(int cp, SimpleCollator.ExtenderType ext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_Level2_Private_Byte_Int32_ExtenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0002AE38 File Offset: 0x00029038
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1277022, RefRangeEnd = 1277026, XrefRangeStart = 1277021, XrefRangeEnd = 1277022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHalfKana(int cp, CompareOptions opt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsHalfKana_Private_Static_Boolean_Int32_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0002AE84 File Offset: 0x00029084
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1277032, RefRangeEnd = 1277039, XrefRangeStart = 1277026, XrefRangeEnd = 1277032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction GetContraction(string s, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contraction>(intPtr3) : null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0002AEF0 File Offset: 0x000290F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277043, RefRangeEnd = 1277045, XrefRangeStart = 1277039, XrefRangeEnd = 1277043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction GetContraction(string s, int start, int end, Il2CppReferenceArray<Contraction> clist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contraction>(intPtr3) : null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0002AF70 File Offset: 0x00029170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277045, XrefRangeEnd = 1277051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction GetTailContraction(string s, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contraction>(intPtr3) : null;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0002AFDC File Offset: 0x000291DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277055, RefRangeEnd = 1277057, XrefRangeStart = 1277051, XrefRangeEnd = 1277055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction GetTailContraction(string s, int start, int end, Il2CppReferenceArray<Contraction> clist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contraction>(intPtr3) : null;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0002B05C File Offset: 0x0002925C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1277083, RefRangeEnd = 1277091, XrefRangeStart = 1277057, XrefRangeEnd = 1277083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FilterOptions(int i, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_FilterOptions_Private_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0002B0B4 File Offset: 0x000292B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1277091, RefRangeEnd = 1277096, XrefRangeStart = 1277091, XrefRangeEnd = 1277091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleCollator.ExtenderType GetExtenderType(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetExtenderType_Private_ExtenderType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0002B100 File Offset: 0x00029300
		[CallerCount(0)]
		public unsafe static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_ToDashTypeValue_Private_Static_Byte_ExtenderType_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0002B14C File Offset: 0x0002934C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1277100, RefRangeEnd = 1277104, XrefRangeStart = 1277096, XrefRangeEnd = 1277100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_FilterExtender_Private_Int32_Int32_ExtenderType_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0002B1B4 File Offset: 0x000293B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1277108, RefRangeEnd = 1277113, XrefRangeStart = 1277104, XrefRangeEnd = 1277108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIgnorable(int i, CompareOptions opt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsIgnorable_Private_Static_Boolean_Int32_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0002B200 File Offset: 0x00029400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277113, RefRangeEnd = 1277115, XrefRangeStart = 1277113, XrefRangeEnd = 1277113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSafe(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsSafe_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0002B24C File Offset: 0x0002944C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277115, XrefRangeEnd = 1277122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SortKey GetSortKey(string s, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_Virtual_Final_New_SortKey_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0002B2AC File Offset: 0x000294AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277122, XrefRangeEnd = 1277129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey GetSortKey(string s, int start, int length, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0002B328 File Offset: 0x00029528
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1277164, RefRangeEnd = 1277167, XrefRangeStart = 1277129, XrefRangeEnd = 1277164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_GetSortKey_Private_Void_String_Int32_Int32_SortKeyBuffer_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0002B3A8 File Offset: 0x000295A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277177, RefRangeEnd = 1277178, XrefRangeStart = 1277167, XrefRangeEnd = 1277177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_FillSortKeyRaw_Private_Void_Int32_ExtenderType_SortKeyBuffer_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0002B414 File Offset: 0x00029614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277178, XrefRangeEnd = 1277182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_FillSurrogateSortKeyRaw_Private_Void_Int32_SortKeyBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0002B464 File Offset: 0x00029664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277182, XrefRangeEnd = 1277183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Globalization_ISimpleCollator_Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_System_Globalization_ISimpleCollator_Compare_Private_Virtual_Final_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0002B50C File Offset: 0x0002970C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277184, RefRangeEnd = 1277185, XrefRangeStart = 1277183, XrefRangeEnd = 1277184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_Compare_Internal_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0002B5B4 File Offset: 0x000297B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277185, XrefRangeEnd = 1277186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBuffer(byte* buffer, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_ClearBuffer_Private_Void_ptr_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0002B600 File Offset: 0x00029800
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1277330, RefRangeEnd = 1277335, XrefRangeStart = 1277186, XrefRangeEnd = 1277330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &targetConsumed;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sourceConsumed;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipHeadingExtenders;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediateBreakup;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_CompareInternal_Private_Int32_String_Int32_Int32_String_Int32_Int32_byref_Boolean_byref_Boolean_Boolean_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0002B6E4 File Offset: 0x000298E4
		[CallerCount(0)]
		public unsafe int CompareFlagPair(bool b1, bool b2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_CompareFlagPair_Private_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0002B73C File Offset: 0x0002993C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277335, XrefRangeEnd = 1277336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsPrefix(string src, string target, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Virtual_Final_New_Boolean_String_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0002B7AC File Offset: 0x000299AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277337, RefRangeEnd = 1277338, XrefRangeStart = 1277336, XrefRangeEnd = 1277337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPrefix(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0002B838 File Offset: 0x00029A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277338, XrefRangeEnd = 1277339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipHeadingExtenders;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsPrefix_Private_Boolean_String_String_Int32_Int32_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0002B8D0 File Offset: 0x00029AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277339, XrefRangeEnd = 1277340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsSuffix(string src, string target, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Virtual_Final_New_Boolean_String_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0002B940 File Offset: 0x00029B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277340, XrefRangeEnd = 1277341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSuffix(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0002B9CC File Offset: 0x00029BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277341, XrefRangeEnd = 1277348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &testWasUnable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_QuickIndexOf_Private_Int32_String_String_Int32_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0002BA58 File Offset: 0x00029C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277348, XrefRangeEnd = 1277354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOf(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0002BAE4 File Offset: 0x00029CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277354, XrefRangeEnd = 1277357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfOrdinal(string s, string target, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0002BB60 File Offset: 0x00029D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277357, XrefRangeEnd = 1277358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfOrdinal(string s, char target, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0002BBD8 File Offset: 0x00029DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277358, XrefRangeEnd = 1277361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOfSortKey_Private_Int32_String_Int32_Int32_ptr_Byte_Char_Int32_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0002BC88 File Offset: 0x00029E88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1277393, RefRangeEnd = 1277394, XrefRangeStart = 1277361, XrefRangeEnd = 1277393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = targetSortKey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_IndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0002BD20 File Offset: 0x00029F20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277395, RefRangeEnd = 1277397, XrefRangeStart = 1277394, XrefRangeEnd = 1277395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int LastIndexOf(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_LastIndexOf_Public_Virtual_Final_New_Int32_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0002BDAC File Offset: 0x00029FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277397, XrefRangeEnd = 1277401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfOrdinal(string s, string target, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_LastIndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0002BE28 File Offset: 0x0002A028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277401, XrefRangeEnd = 1277404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orgStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_LastIndexOfSortKey_Private_Int32_String_Int32_Int32_Int32_ptr_Byte_Int32_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0002BED8 File Offset: 0x0002A0D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277435, RefRangeEnd = 1277437, XrefRangeStart = 1277404, XrefRangeEnd = 1277435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = targetSortKey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_LastIndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0002BF70 File Offset: 0x0002A170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277438, RefRangeEnd = 1277440, XrefRangeStart = 1277437, XrefRangeEnd = 1277438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesForward_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0002C014 File Offset: 0x0002A214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277440, XrefRangeEnd = 1277444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(ct);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesForwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ct = ((intPtr4 == 0) ? null : new Contraction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0002C0F0 File Offset: 0x0002A2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277444, XrefRangeEnd = 1277466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref si;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = target;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesPrimitive_Private_Boolean_CompareOptions_ptr_Byte_Int32_ExtenderType_ptr_Byte_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0002C18C File Offset: 0x0002A38C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277467, RefRangeEnd = 1277469, XrefRangeStart = 1277466, XrefRangeEnd = 1277467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orgStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesBackward_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0002C23C File Offset: 0x0002A43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277469, XrefRangeEnd = 1277483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orgStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ti;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = sortkey;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noLv4;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(ct);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ctx;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.NativeMethodInfoPtr_MatchesBackwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ct = ((intPtr4 == 0) ? null : new Contraction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002991 File Offset: 0x00000B91
		public SimpleCollator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0002C328 File Offset: 0x0002A528
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000299A File Offset: 0x00000B9A
		public unsafe static SimpleCollator invariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SimpleCollator.NativeFieldInfoPtr_invariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleCollator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SimpleCollator.NativeFieldInfoPtr_invariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0002C350 File Offset: 0x0002A550
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x000029AC File Offset: 0x00000BAC
		public unsafe TextInfo textInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_textInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_textInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0002C380 File Offset: 0x0002A580
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x000029CB File Offset: 0x00000BCB
		public unsafe CodePointIndexer cjkIndexer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkIndexer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkIndexer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0002C3B0 File Offset: 0x0002A5B0
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x000029EA File Offset: 0x00000BEA
		public unsafe Il2CppReferenceArray<Contraction> contractions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_contractions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Contraction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_contractions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0002C3E0 File Offset: 0x0002A5E0
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00002A09 File Offset: 0x00000C09
		public unsafe Il2CppReferenceArray<Level2Map> level2Maps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_level2Maps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Level2Map>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_level2Maps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0002C410 File Offset: 0x0002A610
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002A28 File Offset: 0x00000C28
		public unsafe Il2CppStructArray<byte> unsafeFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_unsafeFlags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_unsafeFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0002C440 File Offset: 0x0002A640
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002A47 File Offset: 0x00000C47
		public unsafe byte* cjkCatTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkCatTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkCatTable)) = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0002C464 File Offset: 0x0002A664
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002A62 File Offset: 0x00000C62
		public unsafe byte* cjkLv1Table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv1Table);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv1Table)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0002C488 File Offset: 0x0002A688
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002A7D File Offset: 0x00000C7D
		public unsafe byte* cjkLv2Table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv2Table);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv2Table)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0002C4AC File Offset: 0x0002A6AC
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002A98 File Offset: 0x00000C98
		public unsafe CodePointIndexer cjkLv2Indexer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv2Indexer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_cjkLv2Indexer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0002C4DC File Offset: 0x0002A6DC
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002AB7 File Offset: 0x00000CB7
		public unsafe int lcid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_lcid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_lcid)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0002C504 File Offset: 0x0002A704
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002AD2 File Offset: 0x00000CD2
		public unsafe bool frenchSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_frenchSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.NativeFieldInfoPtr_frenchSort)) = value;
			}
		}

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_invariant;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_textInfo;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_cjkIndexer;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_contractions;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_level2Maps;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_unsafeFlags;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_cjkCatTable;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_cjkLv1Table;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_cjkLv2Table;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_cjkLv2Indexer;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_lcid;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_frenchSort;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_SetCJKTable_Private_Void_CultureInfo_byref_CodePointIndexer_byref_ptr_Byte_byref_ptr_Byte_byref_CodePointIndexer_byref_ptr_Byte_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_GetNeutralCulture_Private_Static_CultureInfo_CultureInfo_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_Category_Private_Byte_Int32_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_Level1_Private_Byte_Int32_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_Level2_Private_Byte_Int32_ExtenderType_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_IsHalfKana_Private_Static_Boolean_Int32_CompareOptions_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_GetContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_GetTailContraction_Private_Contraction_String_Int32_Int32_Il2CppReferenceArray_1_Contraction_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_FilterOptions_Private_Int32_Int32_CompareOptions_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_GetExtenderType_Private_ExtenderType_Int32_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_ToDashTypeValue_Private_Static_Byte_ExtenderType_CompareOptions_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_FilterExtender_Private_Int32_Int32_ExtenderType_CompareOptions_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_IsIgnorable_Private_Static_Boolean_Int32_CompareOptions_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_IsSafe_Private_Boolean_Int32_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Public_Virtual_Final_New_SortKey_String_CompareOptions_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Public_SortKey_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Private_Void_String_Int32_Int32_SortKeyBuffer_CompareOptions_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_FillSortKeyRaw_Private_Void_Int32_ExtenderType_SortKeyBuffer_CompareOptions_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_FillSurrogateSortKeyRaw_Private_Void_Int32_SortKeyBuffer_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_System_Globalization_ISimpleCollator_Compare_Private_Virtual_Final_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_ClearBuffer_Private_Void_ptr_Byte_Int32_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_CompareInternal_Private_Int32_String_Int32_Int32_String_Int32_Int32_byref_Boolean_byref_Boolean_Boolean_Boolean_byref_Context_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_CompareFlagPair_Private_Int32_Boolean_Boolean_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Public_Virtual_Final_New_Boolean_String_String_CompareOptions_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Private_Boolean_String_String_Int32_Int32_Boolean_byref_Context_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_IsSuffix_Public_Virtual_Final_New_Boolean_String_String_CompareOptions_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_IsSuffix_Public_Boolean_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_QuickIndexOf_Private_Int32_String_String_Int32_Int32_byref_Boolean_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfOrdinal_Private_Int32_String_Char_Int32_Int32_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfSortKey_Private_Int32_String_Int32_Int32_ptr_Byte_Char_Int32_Boolean_byref_Context_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Virtual_Final_New_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfOrdinal_Private_Int32_String_String_Int32_Int32_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfSortKey_Private_Int32_String_Int32_Int32_Int32_ptr_Byte_Int32_Boolean_byref_Context_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Private_Int32_String_String_Int32_Int32_ptr_Byte_byref_Context_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_MatchesForward_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_MatchesForwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_MatchesPrimitive_Private_Boolean_CompareOptions_ptr_Byte_Int32_ExtenderType_ptr_Byte_Int32_Boolean_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_MatchesBackward_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_byref_Context_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_MatchesBackwardCore_Private_Boolean_String_byref_Int32_Int32_Int32_Int32_ptr_Byte_Boolean_ExtenderType_byref_Contraction_byref_Context_0;

		// Token: 0x0200056A RID: 1386
		[StructLayout(2)]
		public struct Context
		{
			// Token: 0x060055C3 RID: 21955 RVA: 0x0018C7FC File Offset: 0x0018A9FC
			// Note: this type is marked as 'beforefieldinit'.
			static Context()
			{
				Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "Context");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr);
				SimpleCollator.Context.NativeFieldInfoPtr_Option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "Option");
				SimpleCollator.Context.NativeFieldInfoPtr_NeverMatchFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "NeverMatchFlags");
				SimpleCollator.Context.NativeFieldInfoPtr_AlwaysMatchFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "AlwaysMatchFlags");
				SimpleCollator.Context.NativeFieldInfoPtr_Buffer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "Buffer1");
				SimpleCollator.Context.NativeFieldInfoPtr_Buffer2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "Buffer2");
				SimpleCollator.Context.NativeFieldInfoPtr_PrevCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "PrevCode");
				SimpleCollator.Context.NativeFieldInfoPtr_PrevSortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, "PrevSortKey");
				SimpleCollator.Context.NativeMethodInfoPtr__ctor_Public_Void_CompareOptions_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, 100663570);
			}

			// Token: 0x060055C4 RID: 21956 RVA: 0x0018C8C8 File Offset: 0x0018AAC8
			[CallerCount(0)]
			public unsafe Context(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref opt;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = alwaysMatchFlags;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = neverMatchFlags;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer1;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer2;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = prev1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.Context.NativeMethodInfoPtr__ctor_Public_Void_CompareOptions_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055C5 RID: 21957 RVA: 0x0001E6FB File Offset: 0x0001C8FB
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SimpleCollator.Context>.NativeClassPtr, ref this));
			}

			// Token: 0x040045ED RID: 17901
			private static readonly IntPtr NativeFieldInfoPtr_Option;

			// Token: 0x040045EE RID: 17902
			private static readonly IntPtr NativeFieldInfoPtr_NeverMatchFlags;

			// Token: 0x040045EF RID: 17903
			private static readonly IntPtr NativeFieldInfoPtr_AlwaysMatchFlags;

			// Token: 0x040045F0 RID: 17904
			private static readonly IntPtr NativeFieldInfoPtr_Buffer1;

			// Token: 0x040045F1 RID: 17905
			private static readonly IntPtr NativeFieldInfoPtr_Buffer2;

			// Token: 0x040045F2 RID: 17906
			private static readonly IntPtr NativeFieldInfoPtr_PrevCode;

			// Token: 0x040045F3 RID: 17907
			private static readonly IntPtr NativeFieldInfoPtr_PrevSortKey;

			// Token: 0x040045F4 RID: 17908
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CompareOptions_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_ptr_Byte_0;

			// Token: 0x040045F5 RID: 17909
			[FieldOffset(0)]
			public readonly CompareOptions Option;

			// Token: 0x040045F6 RID: 17910
			[FieldOffset(8)]
			public readonly IntPtr NeverMatchFlags;

			// Token: 0x040045F7 RID: 17911
			[FieldOffset(16)]
			public readonly IntPtr AlwaysMatchFlags;

			// Token: 0x040045F8 RID: 17912
			[FieldOffset(24)]
			public IntPtr Buffer1;

			// Token: 0x040045F9 RID: 17913
			[FieldOffset(32)]
			public IntPtr Buffer2;

			// Token: 0x040045FA RID: 17914
			[FieldOffset(40)]
			public int PrevCode;

			// Token: 0x040045FB RID: 17915
			[FieldOffset(48)]
			public IntPtr PrevSortKey;
		}

		// Token: 0x0200056B RID: 1387
		[StructLayout(2)]
		public struct PreviousInfo
		{
			// Token: 0x060055C6 RID: 21958 RVA: 0x0018C940 File Offset: 0x0018AB40
			// Note: this type is marked as 'beforefieldinit'.
			static PreviousInfo()
			{
				Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "PreviousInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr);
				SimpleCollator.PreviousInfo.NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr, "Code");
				SimpleCollator.PreviousInfo.NativeFieldInfoPtr_SortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr, "SortKey");
				SimpleCollator.PreviousInfo.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr, 100663571);
			}

			// Token: 0x060055C7 RID: 21959 RVA: 0x0018C9A8 File Offset: 0x0018ABA8
			[CallerCount(0)]
			public unsafe PreviousInfo(bool dummy)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dummy;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCollator.PreviousInfo.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060055C8 RID: 21960 RVA: 0x0001E70D File Offset: 0x0001C90D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SimpleCollator.PreviousInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x040045FC RID: 17916
			private static readonly IntPtr NativeFieldInfoPtr_Code;

			// Token: 0x040045FD RID: 17917
			private static readonly IntPtr NativeFieldInfoPtr_SortKey;

			// Token: 0x040045FE RID: 17918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

			// Token: 0x040045FF RID: 17919
			[FieldOffset(0)]
			public int Code;

			// Token: 0x04004600 RID: 17920
			[FieldOffset(8)]
			public IntPtr SortKey;
		}

		// Token: 0x0200056C RID: 1388
		public sealed class Escape : ValueType
		{
			// Token: 0x060055C9 RID: 21961 RVA: 0x0018C9DC File Offset: 0x0018ABDC
			// Note: this type is marked as 'beforefieldinit'.
			static Escape()
			{
				Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCollator>.NativeClassPtr, "Escape");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr);
				SimpleCollator.Escape.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "Source");
				SimpleCollator.Escape.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "Index");
				SimpleCollator.Escape.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "Start");
				SimpleCollator.Escape.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "End");
				SimpleCollator.Escape.NativeFieldInfoPtr_Optional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr, "Optional");
			}

			// Token: 0x060055CA RID: 21962 RVA: 0x0001E71F File Offset: 0x0001C91F
			public Escape(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060055CB RID: 21963 RVA: 0x0001E728 File Offset: 0x0001C928
			public Escape()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCollator.Escape>.NativeClassPtr))
			{
			}

			// Token: 0x170015ED RID: 5613
			// (get) Token: 0x060055CC RID: 21964 RVA: 0x0018CA6C File Offset: 0x0018AC6C
			// (set) Token: 0x060055CD RID: 21965 RVA: 0x0001E73A File Offset: 0x0001C93A
			public unsafe string Source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Source);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Source), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170015EE RID: 5614
			// (get) Token: 0x060055CE RID: 21966 RVA: 0x0018CA94 File Offset: 0x0018AC94
			// (set) Token: 0x060055CF RID: 21967 RVA: 0x0001E759 File Offset: 0x0001C959
			public unsafe int Index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Index)) = value;
				}
			}

			// Token: 0x170015EF RID: 5615
			// (get) Token: 0x060055D0 RID: 21968 RVA: 0x0018CABC File Offset: 0x0018ACBC
			// (set) Token: 0x060055D1 RID: 21969 RVA: 0x0001E774 File Offset: 0x0001C974
			public unsafe int Start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Start)) = value;
				}
			}

			// Token: 0x170015F0 RID: 5616
			// (get) Token: 0x060055D2 RID: 21970 RVA: 0x0018CAE4 File Offset: 0x0018ACE4
			// (set) Token: 0x060055D3 RID: 21971 RVA: 0x0001E78F File Offset: 0x0001C98F
			public unsafe int End
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_End);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_End)) = value;
				}
			}

			// Token: 0x170015F1 RID: 5617
			// (get) Token: 0x060055D4 RID: 21972 RVA: 0x0018CB0C File Offset: 0x0018AD0C
			// (set) Token: 0x060055D5 RID: 21973 RVA: 0x0001E7AA File Offset: 0x0001C9AA
			public unsafe int Optional
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Optional);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCollator.Escape.NativeFieldInfoPtr_Optional)) = value;
				}
			}

			// Token: 0x04004601 RID: 17921
			private static readonly IntPtr NativeFieldInfoPtr_Source;

			// Token: 0x04004602 RID: 17922
			private static readonly IntPtr NativeFieldInfoPtr_Index;

			// Token: 0x04004603 RID: 17923
			private static readonly IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x04004604 RID: 17924
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x04004605 RID: 17925
			private static readonly IntPtr NativeFieldInfoPtr_Optional;
		}

		// Token: 0x0200056D RID: 1389
		public enum ExtenderType
		{
			// Token: 0x04004607 RID: 17927
			None,
			// Token: 0x04004608 RID: 17928
			Simple,
			// Token: 0x04004609 RID: 17929
			Voiced,
			// Token: 0x0400460A RID: 17930
			Conditional,
			// Token: 0x0400460B RID: 17931
			Buggy
		}
	}
}
