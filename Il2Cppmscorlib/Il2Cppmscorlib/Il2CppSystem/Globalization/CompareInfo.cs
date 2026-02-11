using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200046A RID: 1130
	[Serializable]
	public class CompareInfo : Object
	{
		// Token: 0x06004387 RID: 17287 RVA: 0x0013E334 File Offset: 0x0013C534
		// Note: this type is marked as 'beforefieldinit'.
		static CompareInfo()
		{
			Il2CppClassPointerStore<CompareInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CompareInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr);
			CompareInfo.NativeFieldInfoPtr_ValidIndexMaskOffFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "ValidIndexMaskOffFlags");
			CompareInfo.NativeFieldInfoPtr_ValidCompareMaskOffFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "ValidCompareMaskOffFlags");
			CompareInfo.NativeFieldInfoPtr_ValidHashCodeOfStringMaskOffFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "ValidHashCodeOfStringMaskOffFlags");
			CompareInfo.NativeFieldInfoPtr_ValidSortkeyCtorMaskOffFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "ValidSortkeyCtorMaskOffFlags");
			CompareInfo.NativeFieldInfoPtr_Invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "Invariant");
			CompareInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "m_name");
			CompareInfo.NativeFieldInfoPtr__sortName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "_sortName");
			CompareInfo.NativeFieldInfoPtr_m_SortVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "m_SortVersion");
			CompareInfo.NativeFieldInfoPtr_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "culture");
			CompareInfo.NativeFieldInfoPtr_collator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "collator");
			CompareInfo.NativeFieldInfoPtr_collators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "collators");
			CompareInfo.NativeFieldInfoPtr_managedCollation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "managedCollation");
			CompareInfo.NativeFieldInfoPtr_managedCollationChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "managedCollationChecked");
			CompareInfo.NativeMethodInfoPtr_InvariantIndexOf_Internal_Static_Int32_String_String_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673273);
			CompareInfo.NativeMethodInfoPtr_InvariantLastIndexOf_Internal_Static_Int32_String_String_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673274);
			CompareInfo.NativeMethodInfoPtr_InvariantFindString_Private_Static_Int32_ptr_Char_Int32_ptr_Char_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673275);
			CompareInfo.NativeMethodInfoPtr_InvariantToUpper_Private_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673276);
			CompareInfo.NativeMethodInfoPtr_InvariantCreateSortKey_Private_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673277);
			CompareInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673278);
			CompareInfo.NativeMethodInfoPtr_GetCompareInfo_Public_Static_CompareInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673279);
			CompareInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673280);
			CompareInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673281);
			CompareInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673282);
			CompareInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673283);
			CompareInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673284);
			CompareInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673285);
			CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673286);
			CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673287);
			CompareInfo.NativeMethodInfoPtr_Compare_Internal_Int32_ReadOnlySpan_1_Char_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673288);
			CompareInfo.NativeMethodInfoPtr_CompareOptionIgnoreCase_Internal_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673289);
			CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673290);
			CompareInfo.NativeMethodInfoPtr_CompareOrdinalIgnoreCase_Internal_Static_Int32_String_Int32_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673291);
			CompareInfo.NativeMethodInfoPtr_CompareOrdinalIgnoreCase_Internal_Static_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673292);
			CompareInfo.NativeMethodInfoPtr_IsPrefix_Public_Virtual_New_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673293);
			CompareInfo.NativeMethodInfoPtr_IsPrefix_Internal_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673294);
			CompareInfo.NativeMethodInfoPtr_IsSuffix_Public_Virtual_New_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673295);
			CompareInfo.NativeMethodInfoPtr_IsSuffix_Internal_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673296);
			CompareInfo.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673297);
			CompareInfo.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673298);
			CompareInfo.NativeMethodInfoPtr_IndexOfOrdinal_Internal_Int32_String_String_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673299);
			CompareInfo.NativeMethodInfoPtr_LastIndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673300);
			CompareInfo.NativeMethodInfoPtr_LastIndexOfOrdinal_Internal_Int32_String_String_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673301);
			CompareInfo.NativeMethodInfoPtr_GetSortKey_Public_Virtual_New_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673302);
			CompareInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673303);
			CompareInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673304);
			CompareInfo.NativeMethodInfoPtr_GetIgnoreCaseHash_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673305);
			CompareInfo.NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673306);
			CompareInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_New_Int32_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673307);
			CompareInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673308);
			CompareInfo.NativeMethodInfoPtr_get_UseManagedCollation_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673309);
			CompareInfo.NativeMethodInfoPtr_GetCollator_Private_ISimpleCollator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673310);
			CompareInfo.NativeMethodInfoPtr_CreateSortKeyCore_Private_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673311);
			CompareInfo.NativeMethodInfoPtr_internal_index_switch_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673312);
			CompareInfo.NativeMethodInfoPtr_internal_compare_switch_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673313);
			CompareInfo.NativeMethodInfoPtr_internal_compare_managed_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673314);
			CompareInfo.NativeMethodInfoPtr_internal_index_managed_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673315);
			CompareInfo.NativeMethodInfoPtr_internal_compare_icall_Private_Static_Int32_ptr_Char_Int32_ptr_Char_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673316);
			CompareInfo.NativeMethodInfoPtr_internal_compare_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673317);
			CompareInfo.NativeMethodInfoPtr_internal_index_icall_Private_Static_Int32_ptr_Char_Int32_Int32_ptr_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673318);
			CompareInfo.NativeMethodInfoPtr_internal_index_Private_Static_Int32_String_Int32_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673319);
			CompareInfo.NativeMethodInfoPtr_InitSort_Private_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673320);
			CompareInfo.NativeMethodInfoPtr_CompareStringOrdinalIgnoreCase_Private_Static_Int32_ptr_Char_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673321);
			CompareInfo.NativeMethodInfoPtr_IndexOfOrdinalCore_Internal_Static_Int32_String_String_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673322);
			CompareInfo.NativeMethodInfoPtr_LastIndexOfOrdinalCore_Internal_Static_Int32_String_String_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673323);
			CompareInfo.NativeMethodInfoPtr_LastIndexOfCore_Private_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673324);
			CompareInfo.NativeMethodInfoPtr_IndexOfCore_Private_Int32_String_String_Int32_Int32_CompareOptions_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673325);
			CompareInfo.NativeMethodInfoPtr_CompareString_Private_Int32_ReadOnlySpan_1_Char_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673326);
			CompareInfo.NativeMethodInfoPtr_CompareString_Private_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673327);
			CompareInfo.NativeMethodInfoPtr_CreateSortKey_Private_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673328);
			CompareInfo.NativeMethodInfoPtr_StartsWith_Private_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673329);
			CompareInfo.NativeMethodInfoPtr_StartsWith_Private_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673330);
			CompareInfo.NativeMethodInfoPtr_EndsWith_Private_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673331);
			CompareInfo.NativeMethodInfoPtr_EndsWith_Private_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673332);
			CompareInfo.NativeMethodInfoPtr_GetHashCodeOfStringCore_Internal_Int32_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673333);
			CompareInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100673335);
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x0013E940 File Offset: 0x0013CB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406514, XrefRangeEnd = 1406520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_InvariantIndexOf_Internal_Static_Int32_String_String_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x0013E9C0 File Offset: 0x0013CBC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1406526, RefRangeEnd = 1406527, XrefRangeStart = 1406520, XrefRangeEnd = 1406526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_InvariantLastIndexOf_Internal_Static_Int32_String_String_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x0013EA40 File Offset: 0x0013CC40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1406528, RefRangeEnd = 1406530, XrefRangeStart = 1406527, XrefRangeEnd = 1406528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_InvariantFindString_Private_Static_Int32_ptr_Char_Int32_ptr_Char_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x0013EAC4 File Offset: 0x0013CCC4
		[CallerCount(0)]
		public unsafe static char InvariantToUpper(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_InvariantToUpper_Private_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x0013EB04 File Offset: 0x0013CD04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1406552, RefRangeEnd = 1406553, XrefRangeStart = 1406530, XrefRangeEnd = 1406552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey InvariantCreateSortKey(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_InvariantCreateSortKey_Private_SortKey_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x0013EB64 File Offset: 0x0013CD64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1406557, RefRangeEnd = 1406558, XrefRangeStart = 1406553, XrefRangeEnd = 1406557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompareInfo(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x0013EBB0 File Offset: 0x0013CDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406558, XrefRangeEnd = 1406569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CompareInfo GetCompareInfo(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetCompareInfo_Public_Static_CompareInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x0013EBF4 File Offset: 0x0013CDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x0013EC3C File Offset: 0x0013CE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406569, XrefRangeEnd = 1406570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x0013EC80 File Offset: 0x0013CE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x0013ECC8 File Offset: 0x0013CEC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1406579, RefRangeEnd = 1406581, XrefRangeStart = 1406570, XrefRangeEnd = 1406579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x0013ECFC File Offset: 0x0013CEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406581, XrefRangeEnd = 1406585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x0013ED44 File Offset: 0x0013CF44
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406585, XrefRangeEnd = 1406591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x0013ED88 File Offset: 0x0013CF88
		[CallerCount(0)]
		public unsafe virtual int Compare(string string1, string string2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x0013EDF4 File Offset: 0x0013CFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406591, XrefRangeEnd = 1406611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(string string1, string string2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x0013EE6C File Offset: 0x0013D06C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1406652, RefRangeEnd = 1406655, XrefRangeStart = 1406611, XrefRangeEnd = 1406652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(ReadOnlySpan<char> string1, string string2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(string1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_Compare_Internal_Int32_ReadOnlySpan_1_Char_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x0013EEE0 File Offset: 0x0013D0E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1406667, RefRangeEnd = 1406669, XrefRangeStart = 1406655, XrefRangeEnd = 1406667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareOptionIgnoreCase(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(string1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(string2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CompareOptionIgnoreCase_Internal_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x0013EF4C File Offset: 0x0013D14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406669, XrefRangeEnd = 1406698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x0013F000 File Offset: 0x0013D200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406698, XrefRangeEnd = 1406712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lengthA;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lengthB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CompareOrdinalIgnoreCase_Internal_Static_Int32_String_Int32_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x0013F08C File Offset: 0x0013D28C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1406731, RefRangeEnd = 1406743, XrefRangeStart = 1406712, XrefRangeEnd = 1406731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinalIgnoreCase(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(strA));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(strB));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CompareOrdinalIgnoreCase_Internal_Static_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x0013F0EC File Offset: 0x0013D2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406743, XrefRangeEnd = 1406750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsPrefix(string source, string prefix, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_IsPrefix_Public_Virtual_New_Boolean_String_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x0013F164 File Offset: 0x0013D364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1406753, RefRangeEnd = 1406755, XrefRangeStart = 1406750, XrefRangeEnd = 1406753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPrefix(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(prefix));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_IsPrefix_Internal_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x0013F1DC File Offset: 0x0013D3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406755, XrefRangeEnd = 1406762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsSuffix(string source, string suffix, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(suffix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_IsSuffix_Public_Virtual_New_Boolean_String_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x0013F254 File Offset: 0x0013D454
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1406765, RefRangeEnd = 1406767, XrefRangeStart = 1406762, XrefRangeEnd = 1406765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(suffix));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_IsSuffix_Internal_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x0013F2CC File Offset: 0x0013D4CC
		[CallerCount(0)]
		public unsafe virtual int IndexOf(string source, string value, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_String_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x0013F344 File Offset: 0x0013D544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406767, XrefRangeEnd = 1406774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x0013F3D8 File Offset: 0x0013D5D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1406785, RefRangeEnd = 1406789, XrefRangeStart = 1406774, XrefRangeEnd = 1406785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_IndexOfOrdinal_Internal_Int32_String_String_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x0013F464 File Offset: 0x0013D664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406789, XrefRangeEnd = 1406791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_LastIndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x0013F4F8 File Offset: 0x0013D6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406791, XrefRangeEnd = 1406807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_LastIndexOfOrdinal_Internal_Int32_String_String_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x0013F584 File Offset: 0x0013D784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406807, XrefRangeEnd = 1406816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SortKey GetSortKey(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_GetSortKey_Public_Virtual_New_SortKey_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x0013F5F0 File Offset: 0x0013D7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406816, XrefRangeEnd = 1406820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x0013F648 File Offset: 0x0013D848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406820, XrefRangeEnd = 1406821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x0013F690 File Offset: 0x0013D890
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1406867, RefRangeEnd = 1406871, XrefRangeStart = 1406821, XrefRangeEnd = 1406867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetIgnoreCaseHash(string source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetIgnoreCaseHash_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x0013F6D4 File Offset: 0x0013D8D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1406896, RefRangeEnd = 1406898, XrefRangeStart = 1406871, XrefRangeEnd = 1406896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHashCodeOfString(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x0013F730 File Offset: 0x0013D930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406898, XrefRangeEnd = 1406909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_New_Int32_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x0013F798 File Offset: 0x0013D998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1406909, XrefRangeEnd = 1406921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x060043AC RID: 17324 RVA: 0x0013F7DC File Offset: 0x0013D9DC
		public unsafe static bool UseManagedCollation
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1406946, RefRangeEnd = 1406952, XrefRangeStart = 1406921, XrefRangeEnd = 1406946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_get_UseManagedCollation_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x0013F80C File Offset: 0x0013DA0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1407000, RefRangeEnd = 1407005, XrefRangeStart = 1406952, XrefRangeEnd = 1407000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISimpleCollator GetCollator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetCollator_Private_ISimpleCollator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISimpleCollator>(intPtr3) : null;
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x0013F84C File Offset: 0x0013DA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407005, XrefRangeEnd = 1407014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey CreateSortKeyCore(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CreateSortKeyCore_Private_SortKey_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x0013F8AC File Offset: 0x0013DAAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1407023, RefRangeEnd = 1407026, XrefRangeStart = 1407014, XrefRangeEnd = 1407023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sindex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_index_switch_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x0013F944 File Offset: 0x0013DB44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1407044, RefRangeEnd = 1407049, XrefRangeStart = 1407026, XrefRangeEnd = 1407044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_compare_switch_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x0013F9EC File Offset: 0x0013DBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407049, XrefRangeEnd = 1407055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_compare_managed_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x0013FA94 File Offset: 0x0013DC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407055, XrefRangeEnd = 1407061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sindex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_index_managed_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x0013FB2C File Offset: 0x0013DD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407061, XrefRangeEnd = 1407062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = str2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_compare_icall_Private_Static_Int32_ptr_Char_Int32_ptr_Char_Int32_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x0013FBA0 File Offset: 0x0013DDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407062, XrefRangeEnd = 1407068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_compare_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x0013FC3C File Offset: 0x0013DE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407068, XrefRangeEnd = 1407069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sindex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = value;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value_length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_index_icall_Private_Static_Int32_ptr_Char_Int32_Int32_ptr_Char_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x0013FCC0 File Offset: 0x0013DEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407069, XrefRangeEnd = 1407076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int internal_index(string source, int sindex, int count, string value, bool first)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sindex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_index_Private_Static_Int32_String_Int32_Int32_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x0013FD40 File Offset: 0x0013DF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407076, XrefRangeEnd = 1407078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSort(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_InitSort_Private_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x0013FD84 File Offset: 0x0013DF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407078, XrefRangeEnd = 1407082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pString1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pString2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CompareStringOrdinalIgnoreCase_Private_Static_Int32_ptr_Char_Int32_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x0013FDEC File Offset: 0x0013DFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407082, XrefRangeEnd = 1407083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_IndexOfOrdinalCore_Internal_Static_Int32_String_String_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x0013FE6C File Offset: 0x0013E06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407083, XrefRangeEnd = 1407084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_LastIndexOfOrdinalCore_Internal_Static_Int32_String_String_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x0013FEEC File Offset: 0x0013E0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407084, XrefRangeEnd = 1407085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_LastIndexOfCore_Private_Int32_String_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x0013FF78 File Offset: 0x0013E178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407085, XrefRangeEnd = 1407091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = matchLengthPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_IndexOfCore_Private_Int32_String_String_Int32_Int32_CompareOptions_ptr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x00140010 File Offset: 0x0013E210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407091, XrefRangeEnd = 1407093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareString(ReadOnlySpan<char> string1, string string2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(string1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CompareString_Private_Int32_ReadOnlySpan_1_Char_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x00140084 File Offset: 0x0013E284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407093, XrefRangeEnd = 1407099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(string1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(string2));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CompareString_Private_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x001400FC File Offset: 0x0013E2FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1407112, RefRangeEnd = 1407113, XrefRangeStart = 1407099, XrefRangeEnd = 1407112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey CreateSortKey(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CreateSortKey_Private_SortKey_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x0014015C File Offset: 0x0013E35C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1407118, RefRangeEnd = 1407121, XrefRangeStart = 1407113, XrefRangeEnd = 1407118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(string source, string prefix, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_StartsWith_Private_Boolean_String_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x001401CC File Offset: 0x0013E3CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1406753, RefRangeEnd = 1406755, XrefRangeStart = 1406753, XrefRangeEnd = 1406755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(prefix));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_StartsWith_Private_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x00140244 File Offset: 0x0013E444
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1407126, RefRangeEnd = 1407129, XrefRangeStart = 1407121, XrefRangeEnd = 1407126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EndsWith(string source, string suffix, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(suffix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_EndsWith_Private_Boolean_String_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x001402B4 File Offset: 0x0013E4B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1406765, RefRangeEnd = 1406767, XrefRangeStart = 1406765, XrefRangeEnd = 1406767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(source));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(suffix));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_EndsWith_Private_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x0014032C File Offset: 0x0013E52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407129, XrefRangeEnd = 1407130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHashCodeOfStringCore(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetHashCodeOfStringCore_Internal_Int32_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00140388 File Offset: 0x0013E588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407130, XrefRangeEnd = 1407133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompareInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x0001873A File Offset: 0x0001693A
		public CompareInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x060043C7 RID: 17351 RVA: 0x001403C4 File Offset: 0x0013E5C4
		// (set) Token: 0x060043C8 RID: 17352 RVA: 0x00018743 File Offset: 0x00016943
		public unsafe static CompareOptions ValidIndexMaskOffFlags
		{
			get
			{
				CompareOptions compareOptions;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_ValidIndexMaskOffFlags, (void*)(&compareOptions));
				return compareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_ValidIndexMaskOffFlags, (void*)(&value));
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x001403E0 File Offset: 0x0013E5E0
		// (set) Token: 0x060043CA RID: 17354 RVA: 0x00018751 File Offset: 0x00016951
		public unsafe static CompareOptions ValidCompareMaskOffFlags
		{
			get
			{
				CompareOptions compareOptions;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_ValidCompareMaskOffFlags, (void*)(&compareOptions));
				return compareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_ValidCompareMaskOffFlags, (void*)(&value));
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x060043CB RID: 17355 RVA: 0x001403FC File Offset: 0x0013E5FC
		// (set) Token: 0x060043CC RID: 17356 RVA: 0x0001875F File Offset: 0x0001695F
		public unsafe static CompareOptions ValidHashCodeOfStringMaskOffFlags
		{
			get
			{
				CompareOptions compareOptions;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_ValidHashCodeOfStringMaskOffFlags, (void*)(&compareOptions));
				return compareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_ValidHashCodeOfStringMaskOffFlags, (void*)(&value));
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x060043CD RID: 17357 RVA: 0x00140418 File Offset: 0x0013E618
		// (set) Token: 0x060043CE RID: 17358 RVA: 0x0001876D File Offset: 0x0001696D
		public unsafe static CompareOptions ValidSortkeyCtorMaskOffFlags
		{
			get
			{
				CompareOptions compareOptions;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_ValidSortkeyCtorMaskOffFlags, (void*)(&compareOptions));
				return compareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_ValidSortkeyCtorMaskOffFlags, (void*)(&value));
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x060043CF RID: 17359 RVA: 0x00140434 File Offset: 0x0013E634
		// (set) Token: 0x060043D0 RID: 17360 RVA: 0x0001877B File Offset: 0x0001697B
		public unsafe static CompareInfo Invariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_Invariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_Invariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x060043D1 RID: 17361 RVA: 0x0014045C File Offset: 0x0013E65C
		// (set) Token: 0x060043D2 RID: 17362 RVA: 0x0001878D File Offset: 0x0001698D
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x00140484 File Offset: 0x0013E684
		// (set) Token: 0x060043D4 RID: 17364 RVA: 0x000187AC File Offset: 0x000169AC
		public unsafe string _sortName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr__sortName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr__sortName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x001404AC File Offset: 0x0013E6AC
		// (set) Token: 0x060043D6 RID: 17366 RVA: 0x000187CB File Offset: 0x000169CB
		public unsafe SortVersion m_SortVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_SortVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortVersion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_SortVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x060043D7 RID: 17367 RVA: 0x001404DC File Offset: 0x0013E6DC
		// (set) Token: 0x060043D8 RID: 17368 RVA: 0x000187EA File Offset: 0x000169EA
		public unsafe int culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_culture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_culture)) = value;
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x00140504 File Offset: 0x0013E704
		// (set) Token: 0x060043DA RID: 17370 RVA: 0x00018805 File Offset: 0x00016A05
		public unsafe ISimpleCollator collator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_collator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISimpleCollator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_collator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x00140534 File Offset: 0x0013E734
		// (set) Token: 0x060043DC RID: 17372 RVA: 0x00018824 File Offset: 0x00016A24
		public unsafe static Dictionary<string, ISimpleCollator> collators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_collators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ISimpleCollator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_collators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060043DD RID: 17373 RVA: 0x0014055C File Offset: 0x0013E75C
		// (set) Token: 0x060043DE RID: 17374 RVA: 0x00018836 File Offset: 0x00016A36
		public unsafe static bool managedCollation
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_managedCollation, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_managedCollation, (void*)(&value));
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060043DF RID: 17375 RVA: 0x00140578 File Offset: 0x0013E778
		// (set) Token: 0x060043E0 RID: 17376 RVA: 0x00018844 File Offset: 0x00016A44
		public unsafe static bool managedCollationChecked
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_managedCollationChecked, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_managedCollationChecked, (void*)(&value));
			}
		}

		// Token: 0x0400378E RID: 14222
		private static readonly IntPtr NativeFieldInfoPtr_ValidIndexMaskOffFlags;

		// Token: 0x0400378F RID: 14223
		private static readonly IntPtr NativeFieldInfoPtr_ValidCompareMaskOffFlags;

		// Token: 0x04003790 RID: 14224
		private static readonly IntPtr NativeFieldInfoPtr_ValidHashCodeOfStringMaskOffFlags;

		// Token: 0x04003791 RID: 14225
		private static readonly IntPtr NativeFieldInfoPtr_ValidSortkeyCtorMaskOffFlags;

		// Token: 0x04003792 RID: 14226
		private static readonly IntPtr NativeFieldInfoPtr_Invariant;

		// Token: 0x04003793 RID: 14227
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04003794 RID: 14228
		private static readonly IntPtr NativeFieldInfoPtr__sortName;

		// Token: 0x04003795 RID: 14229
		private static readonly IntPtr NativeFieldInfoPtr_m_SortVersion;

		// Token: 0x04003796 RID: 14230
		private static readonly IntPtr NativeFieldInfoPtr_culture;

		// Token: 0x04003797 RID: 14231
		private static readonly IntPtr NativeFieldInfoPtr_collator;

		// Token: 0x04003798 RID: 14232
		private static readonly IntPtr NativeFieldInfoPtr_collators;

		// Token: 0x04003799 RID: 14233
		private static readonly IntPtr NativeFieldInfoPtr_managedCollation;

		// Token: 0x0400379A RID: 14234
		private static readonly IntPtr NativeFieldInfoPtr_managedCollationChecked;

		// Token: 0x0400379B RID: 14235
		private static readonly IntPtr NativeMethodInfoPtr_InvariantIndexOf_Internal_Static_Int32_String_String_Int32_Int32_Boolean_0;

		// Token: 0x0400379C RID: 14236
		private static readonly IntPtr NativeMethodInfoPtr_InvariantLastIndexOf_Internal_Static_Int32_String_String_Int32_Int32_Boolean_0;

		// Token: 0x0400379D RID: 14237
		private static readonly IntPtr NativeMethodInfoPtr_InvariantFindString_Private_Static_Int32_ptr_Char_Int32_ptr_Char_Int32_Boolean_Boolean_0;

		// Token: 0x0400379E RID: 14238
		private static readonly IntPtr NativeMethodInfoPtr_InvariantToUpper_Private_Static_Char_Char_0;

		// Token: 0x0400379F RID: 14239
		private static readonly IntPtr NativeMethodInfoPtr_InvariantCreateSortKey_Private_SortKey_String_CompareOptions_0;

		// Token: 0x040037A0 RID: 14240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_0;

		// Token: 0x040037A1 RID: 14241
		private static readonly IntPtr NativeMethodInfoPtr_GetCompareInfo_Public_Static_CompareInfo_String_0;

		// Token: 0x040037A2 RID: 14242
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x040037A3 RID: 14243
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x040037A4 RID: 14244
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x040037A5 RID: 14245
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_0;

		// Token: 0x040037A6 RID: 14246
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x040037A7 RID: 14247
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x040037A8 RID: 14248
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_0;

		// Token: 0x040037A9 RID: 14249
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_CompareOptions_0;

		// Token: 0x040037AA RID: 14250
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Int32_ReadOnlySpan_1_Char_String_CompareOptions_0;

		// Token: 0x040037AB RID: 14251
		private static readonly IntPtr NativeMethodInfoPtr_CompareOptionIgnoreCase_Internal_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x040037AC RID: 14252
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040037AD RID: 14253
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinalIgnoreCase_Internal_Static_Int32_String_Int32_Int32_String_Int32_Int32_0;

		// Token: 0x040037AE RID: 14254
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinalIgnoreCase_Internal_Static_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x040037AF RID: 14255
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Public_Virtual_New_Boolean_String_String_CompareOptions_0;

		// Token: 0x040037B0 RID: 14256
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Internal_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0;

		// Token: 0x040037B1 RID: 14257
		private static readonly IntPtr NativeMethodInfoPtr_IsSuffix_Public_Virtual_New_Boolean_String_String_CompareOptions_0;

		// Token: 0x040037B2 RID: 14258
		private static readonly IntPtr NativeMethodInfoPtr_IsSuffix_Internal_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0;

		// Token: 0x040037B3 RID: 14259
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_String_String_CompareOptions_0;

		// Token: 0x040037B4 RID: 14260
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040037B5 RID: 14261
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfOrdinal_Internal_Int32_String_String_Int32_Int32_Boolean_0;

		// Token: 0x040037B6 RID: 14262
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040037B7 RID: 14263
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfOrdinal_Internal_Int32_String_String_Int32_Int32_Boolean_0;

		// Token: 0x040037B8 RID: 14264
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Public_Virtual_New_SortKey_String_CompareOptions_0;

		// Token: 0x040037B9 RID: 14265
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040037BA RID: 14266
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040037BB RID: 14267
		private static readonly IntPtr NativeMethodInfoPtr_GetIgnoreCaseHash_Internal_Static_Int32_String_0;

		// Token: 0x040037BC RID: 14268
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_0;

		// Token: 0x040037BD RID: 14269
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_New_Int32_String_CompareOptions_0;

		// Token: 0x040037BE RID: 14270
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040037BF RID: 14271
		private static readonly IntPtr NativeMethodInfoPtr_get_UseManagedCollation_Private_Static_get_Boolean_0;

		// Token: 0x040037C0 RID: 14272
		private static readonly IntPtr NativeMethodInfoPtr_GetCollator_Private_ISimpleCollator_0;

		// Token: 0x040037C1 RID: 14273
		private static readonly IntPtr NativeMethodInfoPtr_CreateSortKeyCore_Private_SortKey_String_CompareOptions_0;

		// Token: 0x040037C2 RID: 14274
		private static readonly IntPtr NativeMethodInfoPtr_internal_index_switch_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0;

		// Token: 0x040037C3 RID: 14275
		private static readonly IntPtr NativeMethodInfoPtr_internal_compare_switch_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040037C4 RID: 14276
		private static readonly IntPtr NativeMethodInfoPtr_internal_compare_managed_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040037C5 RID: 14277
		private static readonly IntPtr NativeMethodInfoPtr_internal_index_managed_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0;

		// Token: 0x040037C6 RID: 14278
		private static readonly IntPtr NativeMethodInfoPtr_internal_compare_icall_Private_Static_Int32_ptr_Char_Int32_ptr_Char_Int32_CompareOptions_0;

		// Token: 0x040037C7 RID: 14279
		private static readonly IntPtr NativeMethodInfoPtr_internal_compare_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040037C8 RID: 14280
		private static readonly IntPtr NativeMethodInfoPtr_internal_index_icall_Private_Static_Int32_ptr_Char_Int32_Int32_ptr_Char_Int32_Boolean_0;

		// Token: 0x040037C9 RID: 14281
		private static readonly IntPtr NativeMethodInfoPtr_internal_index_Private_Static_Int32_String_Int32_Int32_String_Boolean_0;

		// Token: 0x040037CA RID: 14282
		private static readonly IntPtr NativeMethodInfoPtr_InitSort_Private_Void_CultureInfo_0;

		// Token: 0x040037CB RID: 14283
		private static readonly IntPtr NativeMethodInfoPtr_CompareStringOrdinalIgnoreCase_Private_Static_Int32_ptr_Char_Int32_ptr_Char_Int32_0;

		// Token: 0x040037CC RID: 14284
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfOrdinalCore_Internal_Static_Int32_String_String_Int32_Int32_Boolean_0;

		// Token: 0x040037CD RID: 14285
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfOrdinalCore_Internal_Static_Int32_String_String_Int32_Int32_Boolean_0;

		// Token: 0x040037CE RID: 14286
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfCore_Private_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040037CF RID: 14287
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfCore_Private_Int32_String_String_Int32_Int32_CompareOptions_ptr_Int32_0;

		// Token: 0x040037D0 RID: 14288
		private static readonly IntPtr NativeMethodInfoPtr_CompareString_Private_Int32_ReadOnlySpan_1_Char_String_CompareOptions_0;

		// Token: 0x040037D1 RID: 14289
		private static readonly IntPtr NativeMethodInfoPtr_CompareString_Private_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0;

		// Token: 0x040037D2 RID: 14290
		private static readonly IntPtr NativeMethodInfoPtr_CreateSortKey_Private_SortKey_String_CompareOptions_0;

		// Token: 0x040037D3 RID: 14291
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Private_Boolean_String_String_CompareOptions_0;

		// Token: 0x040037D4 RID: 14292
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Private_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0;

		// Token: 0x040037D5 RID: 14293
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Private_Boolean_String_String_CompareOptions_0;

		// Token: 0x040037D6 RID: 14294
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Private_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_CompareOptions_0;

		// Token: 0x040037D7 RID: 14295
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeOfStringCore_Internal_Int32_String_CompareOptions_0;

		// Token: 0x040037D8 RID: 14296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
