using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x02000095 RID: 149
	[Serializable]
	public class LocalizedStringDatabase : LocalizedDatabase<StringTable, StringTableEntry>
	{
		// Token: 0x06000732 RID: 1842 RVA: 0x00024E40 File Offset: 0x00023040
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedStringDatabase()
		{
			Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "LocalizedStringDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr);
			LocalizedStringDatabase.NativeFieldInfoPtr_m_MissingTranslationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, "m_MissingTranslationState");
			LocalizedStringDatabase.NativeFieldInfoPtr_TranslationNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, "TranslationNotFound");
			LocalizedStringDatabase.NativeFieldInfoPtr_k_DefaultNoTranslationMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, "k_DefaultNoTranslationMessage");
			LocalizedStringDatabase.NativeFieldInfoPtr_m_NoTranslationFoundMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, "m_NoTranslationFoundMessage");
			LocalizedStringDatabase.NativeFieldInfoPtr_m_SmartFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, "m_SmartFormat");
			LocalizedStringDatabase.NativeFieldInfoPtr_m_MissingTranslationTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, "m_MissingTranslationTable");
			LocalizedStringDatabase.NativeMethodInfoPtr_add_TranslationNotFound_Public_add_Void_MissingTranslation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664595);
			LocalizedStringDatabase.NativeMethodInfoPtr_remove_TranslationNotFound_Public_rem_Void_MissingTranslation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664596);
			LocalizedStringDatabase.NativeMethodInfoPtr_get_NoTranslationFoundMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664597);
			LocalizedStringDatabase.NativeMethodInfoPtr_set_NoTranslationFoundMessage_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664598);
			LocalizedStringDatabase.NativeMethodInfoPtr_get_MissingTranslationState_Public_get_MissingTranslationBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664599);
			LocalizedStringDatabase.NativeMethodInfoPtr_set_MissingTranslationState_Public_set_Void_MissingTranslationBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664600);
			LocalizedStringDatabase.NativeMethodInfoPtr_get_SmartFormatter_Public_get_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664601);
			LocalizedStringDatabase.NativeMethodInfoPtr_set_SmartFormatter_Public_set_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664602);
			LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_TableEntryReference_Locale_FallbackBehavior_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664603);
			LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedString_Public_String_TableEntryReference_Locale_FallbackBehavior_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664604);
			LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664605);
			LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedString_Public_String_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664606);
			LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_Virtual_New_AsyncOperationHandle_1_String_TableReference_TableEntryReference_Locale_FallbackBehavior_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664607);
			LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedString_Public_Virtual_New_String_TableReference_TableEntryReference_Locale_FallbackBehavior_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664608);
			LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_Virtual_New_AsyncOperationHandle_1_String_TableReference_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_IVariableGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664609);
			LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedStringAsyncInternal_Internal_Virtual_New_AsyncOperationHandle_1_String_TableReference_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_IVariableGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664610);
			LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedString_Public_Virtual_New_String_TableReference_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664611);
			LocalizedStringDatabase.NativeMethodInfoPtr_GenerateLocalizedString_FamOrAssem_Virtual_New_String_StringTable_StringTableEntry_TableReference_TableEntryReference_Locale_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664612);
			LocalizedStringDatabase.NativeMethodInfoPtr_GetUntranslatedTextTempTable_Private_StringTable_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664613);
			LocalizedStringDatabase.NativeMethodInfoPtr_ProcessUntranslatedText_Internal_String_String_Int64_TableReference_StringTable_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664614);
			LocalizedStringDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, 100664615);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0002508C File Offset: 0x0002328C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074912, XrefRangeEnd = 1074916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_TranslationNotFound(LocalizedStringDatabase.MissingTranslation value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_add_TranslationNotFound_Public_add_Void_MissingTranslation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000250D0 File Offset: 0x000232D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074916, XrefRangeEnd = 1074920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_TranslationNotFound(LocalizedStringDatabase.MissingTranslation value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_remove_TranslationNotFound_Public_rem_Void_MissingTranslation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00025114 File Offset: 0x00023314
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x0002514C File Offset: 0x0002334C
		public unsafe string NoTranslationFoundMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_get_NoTranslationFoundMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_set_NoTranslationFoundMessage_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00025190 File Offset: 0x00023390
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x000251CC File Offset: 0x000233CC
		public unsafe MissingTranslationBehavior MissingTranslationState
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_get_MissingTranslationState_Public_get_MissingTranslationBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_set_MissingTranslationState_Public_set_Void_MissingTranslationBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x0002520C File Offset: 0x0002340C
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x0002524C File Offset: 0x0002344C
		public unsafe SmartFormatter SmartFormatter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_get_SmartFormatter_Public_get_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SmartFormatter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_set_SmartFormatter_Public_set_Void_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00025290 File Offset: 0x00023490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074920, XrefRangeEnd = 1074923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<string> GetLocalizedStringAsync(TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings, [Optional] Il2CppReferenceArray<Object> arguments)
		{
			if (arguments == null)
			{
				arguments = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_TableEntryReference_Locale_FallbackBehavior_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<string>(intPtr);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00025320 File Offset: 0x00023520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074923, XrefRangeEnd = 1074926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString(TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings, [Optional] Il2CppReferenceArray<Object> arguments)
		{
			if (arguments == null)
			{
				arguments = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedString_Public_String_TableEntryReference_Locale_FallbackBehavior_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000253B0 File Offset: 0x000235B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074926, XrefRangeEnd = 1074929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<string> GetLocalizedStringAsync(TableEntryReference tableEntryReference, IList<Object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<string>(intPtr);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00025430 File Offset: 0x00023630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074929, XrefRangeEnd = 1074932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedString(TableEntryReference tableEntryReference, IList<Object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedString_Public_String_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000254B0 File Offset: 0x000236B0
		[CallerCount(0)]
		public unsafe virtual AsyncOperationHandle<string> GetLocalizedStringAsync(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings, [Optional] Il2CppReferenceArray<Object> arguments)
		{
			if (arguments == null)
			{
				arguments = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_Virtual_New_AsyncOperationHandle_1_String_TableReference_TableEntryReference_Locale_FallbackBehavior_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<string>(intPtr);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00025560 File Offset: 0x00023760
		[CallerCount(0)]
		public unsafe virtual string GetLocalizedString(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings, [Optional] Il2CppReferenceArray<Object> arguments)
		{
			if (arguments == null)
			{
				arguments = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedString_Public_Virtual_New_String_TableReference_TableEntryReference_Locale_FallbackBehavior_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00025610 File Offset: 0x00023810
		[CallerCount(0)]
		public unsafe virtual AsyncOperationHandle<string> GetLocalizedStringAsync(TableReference tableReference, TableEntryReference tableEntryReference, IList<Object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings, IVariableGroup localVariables = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localVariables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedStringAsync_Public_Virtual_New_AsyncOperationHandle_1_String_TableReference_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_IVariableGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<string>(intPtr);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000256C8 File Offset: 0x000238C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074932, XrefRangeEnd = 1074951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<string> GetLocalizedStringAsyncInternal(TableReference tableReference, TableEntryReference tableEntryReference, IList<Object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings, IVariableGroup localVariables = null, bool autoRelease = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localVariables);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRelease;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedStringAsyncInternal_Internal_Virtual_New_AsyncOperationHandle_1_String_TableReference_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_IVariableGroup_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<string>(intPtr);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0002578C File Offset: 0x0002398C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074951, XrefRangeEnd = 1074958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedString(TableReference tableReference, TableEntryReference tableEntryReference, IList<Object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedStringDatabase.NativeMethodInfoPtr_GetLocalizedString_Public_Virtual_New_String_TableReference_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00025830 File Offset: 0x00023A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074958, XrefRangeEnd = 1074986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GenerateLocalizedString(StringTable table, StringTableEntry entry, TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, IList<Object> arguments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedStringDatabase.NativeMethodInfoPtr_GenerateLocalizedString_FamOrAssem_Virtual_New_String_StringTable_StringTableEntry_TableReference_TableEntryReference_Locale_IList_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000258EC File Offset: 0x00023AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1075031, RefRangeEnd = 1075032, XrefRangeStart = 1074986, XrefRangeEnd = 1075031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringTable GetUntranslatedTextTempTable(TableReference tableReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_GetUntranslatedTextTempTable_Private_StringTable_TableReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00025944 File Offset: 0x00023B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1075087, RefRangeEnd = 1075088, XrefRangeStart = 1075032, XrefRangeEnd = 1075087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ProcessUntranslatedText(string key, long keyId, TableReference tableReference, StringTable table, Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr_ProcessUntranslatedText_Internal_String_String_Int64_TableReference_StringTable_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000259D8 File Offset: 0x00023BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075088, XrefRangeEnd = 1075103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedStringDatabase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00004C23 File Offset: 0x00002E23
		public AsyncOperationHandle<string> GetLocalizedStringAsync(TableEntryReference tableEntryReference, [Optional] Locale locale, [Optional] FallbackBehavior fallbackBehavior, params Object[] arguments)
		{
			return this.GetLocalizedStringAsync(tableEntryReference, locale, fallbackBehavior, new Il2CppReferenceArray<Object>(arguments));
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00004C35 File Offset: 0x00002E35
		public string GetLocalizedString(TableEntryReference tableEntryReference, [Optional] Locale locale, [Optional] FallbackBehavior fallbackBehavior, params Object[] arguments)
		{
			return this.GetLocalizedString(tableEntryReference, locale, fallbackBehavior, new Il2CppReferenceArray<Object>(arguments));
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00004C47 File Offset: 0x00002E47
		public virtual AsyncOperationHandle<string> GetLocalizedStringAsync(TableReference tableReference, TableEntryReference tableEntryReference, [Optional] Locale locale, [Optional] FallbackBehavior fallbackBehavior, params Object[] arguments)
		{
			return this.GetLocalizedStringAsync(tableReference, tableEntryReference, locale, fallbackBehavior, new Il2CppReferenceArray<Object>(arguments));
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00004C5B File Offset: 0x00002E5B
		public virtual string GetLocalizedString(TableReference tableReference, TableEntryReference tableEntryReference, [Optional] Locale locale, [Optional] FallbackBehavior fallbackBehavior, params Object[] arguments)
		{
			return this.GetLocalizedString(tableReference, tableEntryReference, locale, fallbackBehavior, new Il2CppReferenceArray<Object>(arguments));
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00004C6F File Offset: 0x00002E6F
		public LocalizedStringDatabase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00025A14 File Offset: 0x00023C14
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00004C78 File Offset: 0x00002E78
		public unsafe MissingTranslationBehavior m_MissingTranslationState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringDatabase.NativeFieldInfoPtr_m_MissingTranslationState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringDatabase.NativeFieldInfoPtr_m_MissingTranslationState)) = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00025A3C File Offset: 0x00023C3C
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00004C93 File Offset: 0x00002E93
		public unsafe LocalizedStringDatabase.MissingTranslation TranslationNotFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringDatabase.NativeFieldInfoPtr_TranslationNotFound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedStringDatabase.MissingTranslation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringDatabase.NativeFieldInfoPtr_TranslationNotFound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00025A6C File Offset: 0x00023C6C
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00004CB2 File Offset: 0x00002EB2
		public unsafe static string k_DefaultNoTranslationMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LocalizedStringDatabase.NativeFieldInfoPtr_k_DefaultNoTranslationMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizedStringDatabase.NativeFieldInfoPtr_k_DefaultNoTranslationMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00025A8C File Offset: 0x00023C8C
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public unsafe string m_NoTranslationFoundMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringDatabase.NativeFieldInfoPtr_m_NoTranslationFoundMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringDatabase.NativeFieldInfoPtr_m_NoTranslationFoundMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00025AB4 File Offset: 0x00023CB4
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00004CE3 File Offset: 0x00002EE3
		public unsafe SmartFormatter m_SmartFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringDatabase.NativeFieldInfoPtr_m_SmartFormat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmartFormatter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringDatabase.NativeFieldInfoPtr_m_SmartFormat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00025AE4 File Offset: 0x00023CE4
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00004D02 File Offset: 0x00002F02
		public unsafe StringTable m_MissingTranslationTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringDatabase.NativeFieldInfoPtr_m_MissingTranslationTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedStringDatabase.NativeFieldInfoPtr_m_MissingTranslationTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeFieldInfoPtr_m_MissingTranslationState;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeFieldInfoPtr_TranslationNotFound;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultNoTranslationMessage;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeFieldInfoPtr_m_NoTranslationFoundMessage;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeFieldInfoPtr_m_SmartFormat;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeFieldInfoPtr_m_MissingTranslationTable;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_add_TranslationNotFound_Public_add_Void_MissingTranslation_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_remove_TranslationNotFound_Public_rem_Void_MissingTranslation_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_get_NoTranslationFoundMessage_Public_get_String_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_set_NoTranslationFoundMessage_Public_set_Void_String_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_get_MissingTranslationState_Public_get_MissingTranslationBehavior_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_set_MissingTranslationState_Public_set_Void_MissingTranslationBehavior_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_get_SmartFormatter_Public_get_SmartFormatter_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_set_SmartFormatter_Public_set_Void_SmartFormatter_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_TableEntryReference_Locale_FallbackBehavior_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_TableEntryReference_Locale_FallbackBehavior_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedStringAsync_Public_AsyncOperationHandle_1_String_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_String_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedStringAsync_Public_Virtual_New_AsyncOperationHandle_1_String_TableReference_TableEntryReference_Locale_FallbackBehavior_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_Virtual_New_String_TableReference_TableEntryReference_Locale_FallbackBehavior_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedStringAsync_Public_Virtual_New_AsyncOperationHandle_1_String_TableReference_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_IVariableGroup_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedStringAsyncInternal_Internal_Virtual_New_AsyncOperationHandle_1_String_TableReference_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_IVariableGroup_Boolean_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_Virtual_New_String_TableReference_TableEntryReference_IList_1_Object_Locale_FallbackBehavior_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_GenerateLocalizedString_FamOrAssem_Virtual_New_String_StringTable_StringTableEntry_TableReference_TableEntryReference_Locale_IList_1_Object_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_GetUntranslatedTextTempTable_Private_StringTable_TableReference_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_ProcessUntranslatedText_Internal_String_String_Int64_TableReference_StringTable_Locale_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200015E RID: 350
		public sealed class MissingTranslation : MulticastDelegate
		{
			// Token: 0x06000F1D RID: 3869 RVA: 0x00040EB0 File Offset: 0x0003F0B0
			// Note: this type is marked as 'beforefieldinit'.
			static MissingTranslation()
			{
				Il2CppClassPointerStore<LocalizedStringDatabase.MissingTranslation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedStringDatabase>.NativeClassPtr, "MissingTranslation");
				LocalizedStringDatabase.MissingTranslation.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase.MissingTranslation>.NativeClassPtr, 100664616);
				LocalizedStringDatabase.MissingTranslation.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int64_TableReference_StringTable_Locale_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase.MissingTranslation>.NativeClassPtr, 100664617);
				LocalizedStringDatabase.MissingTranslation.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int64_TableReference_StringTable_Locale_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase.MissingTranslation>.NativeClassPtr, 100664618);
				LocalizedStringDatabase.MissingTranslation.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringDatabase.MissingTranslation>.NativeClassPtr, 100664619);
			}

			// Token: 0x06000F1E RID: 3870 RVA: 0x00040F24 File Offset: 0x0003F124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074901, XrefRangeEnd = 1074905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MissingTranslation(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedStringDatabase.MissingTranslation>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.MissingTranslation.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F1F RID: 3871 RVA: 0x00040F80 File Offset: 0x0003F180
			[CallerCount(0)]
			public unsafe void Invoke(string key, long keyId, TableReference tableReference, StringTable table, Locale locale, string noTranslationFoundMessage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(noTranslationFoundMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.MissingTranslation.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int64_TableReference_StringTable_Locale_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F20 RID: 3872 RVA: 0x00041020 File Offset: 0x0003F220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074905, XrefRangeEnd = 1074912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string key, long keyId, TableReference tableReference, StringTable table, Locale locale, string noTranslationFoundMessage, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(noTranslationFoundMessage);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.MissingTranslation.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int64_TableReference_StringTable_Locale_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000F21 RID: 3873 RVA: 0x000410F4 File Offset: 0x0003F2F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedStringDatabase.MissingTranslation.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F22 RID: 3874 RVA: 0x0000855F File Offset: 0x0000675F
			public MissingTranslation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000F23 RID: 3875 RVA: 0x00008568 File Offset: 0x00006768
			public static implicit operator LocalizedStringDatabase.MissingTranslation(Action<string, long, TableReference, StringTable, Locale, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<LocalizedStringDatabase.MissingTranslation>(A_0);
			}

			// Token: 0x06000F24 RID: 3876 RVA: 0x00008570 File Offset: 0x00006770
			public static LocalizedStringDatabase.MissingTranslation operator +(LocalizedStringDatabase.MissingTranslation A_0, LocalizedStringDatabase.MissingTranslation A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LocalizedStringDatabase.MissingTranslation>();
			}

			// Token: 0x06000F25 RID: 3877 RVA: 0x0000857E File Offset: 0x0000677E
			public static LocalizedStringDatabase.MissingTranslation operator -(LocalizedStringDatabase.MissingTranslation A_0, LocalizedStringDatabase.MissingTranslation A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LocalizedStringDatabase.MissingTranslation>();
				}
				return delegate2;
			}

			// Token: 0x04000A5C RID: 2652
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000A5D RID: 2653
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int64_TableReference_StringTable_Locale_String_0;

			// Token: 0x04000A5E RID: 2654
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int64_TableReference_StringTable_Locale_String_AsyncCallback_Object_0;

			// Token: 0x04000A5F RID: 2655
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
