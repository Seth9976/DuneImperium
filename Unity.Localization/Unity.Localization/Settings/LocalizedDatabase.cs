using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Operations;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x02000094 RID: 148
	[Serializable]
	public class LocalizedDatabase<TTable, TEntry> : Object where TTable : DetailedLocalizationTable<TEntry> where TEntry : TableEntry
	{
		// Token: 0x060006F0 RID: 1776 RVA: 0x00023BA4 File Offset: 0x00021DA4
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedDatabase()
		{
			Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "LocalizedDatabase`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr);
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_DefaultTableReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "m_DefaultTableReference");
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_CustomTableProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "m_CustomTableProvider");
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_CustomTablePostprocessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "m_CustomTablePostprocessor");
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_AsynchronousBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "m_AsynchronousBehaviour");
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_UseFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "m_UseFallback");
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadOperationHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "m_PreloadOperationHandle");
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_ReleaseNextFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "m_ReleaseNextFrame");
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_PatchTableContentsAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "m_PatchTableContentsAction");
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_RegisterSharedTableAndGuidOperationAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "m_RegisterSharedTableAndGuidOperationAction");
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_RegisterCompletedTableOperationAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "m_RegisterCompletedTableOperationAction");
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_k_SelectedLocaleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "k_SelectedLocaleId");
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr__TableOperations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "<TableOperations>k__BackingField");
			LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr__SharedTableDataOperations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "<SharedTableDataOperations>k__BackingField");
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_PreloadOperation_Public_Virtual_Final_New_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664553);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_ReleaseNextFrame_Internal_get_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664554);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_TableOperations_Internal_get_Dictionary_2_ValueTuple_2_LocaleIdentifier_String_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664555);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_SharedTableDataOperations_Internal_get_Dictionary_2_Guid_AsyncOperationHandle_1_SharedTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664556);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_DefaultTable_Public_Virtual_New_get_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664557);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_set_DefaultTable_Public_Virtual_New_set_Void_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664558);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_TableProvider_Public_get_ITableProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664559);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_set_TableProvider_Public_set_Void_ITableProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664560);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_TablePostprocessor_Public_get_ITablePostprocessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664561);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_set_TablePostprocessor_Public_set_Void_ITablePostprocessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664562);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_UseFallback_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664563);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_set_UseFallback_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664564);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_AsynchronousBehaviour_Public_get_AsynchronousBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664565);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_set_AsynchronousBehaviour_Public_set_Void_AsynchronousBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664566);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664567);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetDefaultTable_Internal_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664568);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_RegisterCompletedTableOperation_Internal_Void_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664569);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_RegisterTableNameOperation_Private_Void_AsyncOperationHandle_1_TTable_LocaleIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664570);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_RegisterSharedTableAndGuidOperation_Private_Void_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664571);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetDefaultTableAsync_Public_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664572);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetTableAsync_Public_Virtual_New_AsyncOperationHandle_1_TTable_TableReference_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664573);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetTable_Public_Virtual_New_TTable_TableReference_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664574);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_PreloadTables_Public_AsyncOperationHandle_TableReference_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664575);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_PreloadTables_Public_AsyncOperationHandle_IList_1_TableReference_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664576);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_ReleaseAllTables_Public_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664577);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_ReleaseTable_Public_Void_TableReference_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664578);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetAllTables_Public_Virtual_New_AsyncOperationHandle_1_IList_1_TTable_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664579);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_IsTableLoaded_Public_Virtual_New_Boolean_TableReference_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664580);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_CreateLoadTableOperation_Internal_Virtual_New_LoadTableOperation_2_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664581);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_CreatePreloadTablesOperation_Internal_Virtual_New_PreloadTablesOperation_2_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664582);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetTableEntryAsync_Public_Virtual_New_AsyncOperationHandle_1_TableEntryResult_TTable_TEntry_TableReference_TableEntryReference_Locale_FallbackBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664583);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetTableEntry_Public_Virtual_New_TableEntryResult_TTable_TEntry_TableReference_TableEntryReference_Locale_FallbackBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664584);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetSharedTableData_Internal_AsyncOperationHandle_1_SharedTableData_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664585);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_ReleaseTableContents_Internal_Virtual_New_Void_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664586);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_OnLocaleChanged_Public_Virtual_New_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664587);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_PatchTableContents_Private_Void_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664588);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_ResetState_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664589);
			LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, 100664590);
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00024020 File Offset: 0x00022220
		public unsafe virtual AsyncOperationHandle PreloadOperation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074403, XrefRangeEnd = 1074413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_PreloadOperation_Public_Virtual_Final_New_get_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00024058 File Offset: 0x00022258
		public unsafe Action<AsyncOperationHandle> ReleaseNextFrame
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_ReleaseNextFrame_Internal_get_Action_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr3) : null;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00024098 File Offset: 0x00022298
		public unsafe Dictionary<ValueTuple<LocaleIdentifier, string>, AsyncOperationHandle<TTable>> TableOperations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_TableOperations_Internal_get_Dictionary_2_ValueTuple_2_LocaleIdentifier_String_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<LocaleIdentifier, string>, AsyncOperationHandle<TTable>>>(intPtr3) : null;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x000240D8 File Offset: 0x000222D8
		public unsafe Dictionary<Guid, AsyncOperationHandle<SharedTableData>> SharedTableDataOperations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_SharedTableDataOperations_Internal_get_Dictionary_2_Guid_AsyncOperationHandle_1_SharedTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Guid, AsyncOperationHandle<SharedTableData>>>(intPtr3) : null;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00024118 File Offset: 0x00022318
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x0002415C File Offset: 0x0002235C
		public unsafe virtual TableReference DefaultTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_DefaultTable_Public_Virtual_New_get_TableReference_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TableReference(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074413, XrefRangeEnd = 1074414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_set_DefaultTable_Public_Virtual_New_set_Void_TableReference_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x000241B0 File Offset: 0x000223B0
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x000241F0 File Offset: 0x000223F0
		public unsafe ITableProvider TableProvider
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_TableProvider_Public_get_ITableProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITableProvider>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_set_TableProvider_Public_set_Void_ITableProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00024234 File Offset: 0x00022434
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x00024274 File Offset: 0x00022474
		public unsafe ITablePostprocessor TablePostprocessor
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_TablePostprocessor_Public_get_ITablePostprocessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITablePostprocessor>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_set_TablePostprocessor_Public_set_Void_ITablePostprocessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x000242B8 File Offset: 0x000224B8
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x000242F4 File Offset: 0x000224F4
		public unsafe bool UseFallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_UseFallback_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_set_UseFallback_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00024334 File Offset: 0x00022534
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00024370 File Offset: 0x00022570
		public unsafe AsynchronousBehaviour AsynchronousBehaviour
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_get_AsynchronousBehaviour_Public_get_AsynchronousBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_set_AsynchronousBehaviour_Public_set_Void_AsynchronousBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000243B0 File Offset: 0x000225B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1074449, RefRangeEnd = 1074453, XrefRangeStart = 1074414, XrefRangeEnd = 1074449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedDatabase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000243EC File Offset: 0x000225EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1074456, RefRangeEnd = 1074462, XrefRangeStart = 1074453, XrefRangeEnd = 1074456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TableReference GetDefaultTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetDefaultTable_Internal_TableReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TableReference(intPtr);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00024424 File Offset: 0x00022624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074472, RefRangeEnd = 1074473, XrefRangeStart = 1074462, XrefRangeEnd = 1074472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCompletedTableOperation(AsyncOperationHandle<TTable> tableOperation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableOperation));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_RegisterCompletedTableOperation_Internal_Void_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0002446C File Offset: 0x0002266C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1074480, RefRangeEnd = 1074483, XrefRangeStart = 1074473, XrefRangeEnd = 1074480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterTableNameOperation(AsyncOperationHandle<TTable> tableOperation, LocaleIdentifier localeIdentifier, string tableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableOperation));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tableName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_RegisterTableNameOperation_Private_Void_AsyncOperationHandle_1_TTable_LocaleIdentifier_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000244DC File Offset: 0x000226DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1074510, RefRangeEnd = 1074512, XrefRangeStart = 1074483, XrefRangeEnd = 1074510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSharedTableAndGuidOperation(AsyncOperationHandle<TTable> tableOperation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableOperation));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_RegisterSharedTableAndGuidOperation_Private_Void_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00024524 File Offset: 0x00022724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074512, XrefRangeEnd = 1074515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TTable> GetDefaultTableAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetDefaultTableAsync_Public_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TTable>(intPtr);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0002455C File Offset: 0x0002275C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074515, XrefRangeEnd = 1074598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<TTable> GetTableAsync(TableReference tableReference, Locale locale = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetTableAsync_Public_Virtual_New_AsyncOperationHandle_1_TTable_TableReference_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TTable>(intPtr);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x000245C8 File Offset: 0x000227C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074598, XrefRangeEnd = 1074599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TTable GetTable(TableReference tableReference, Locale locale = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetTable_Public_Virtual_New_TTable_TableReference_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TTable>(intPtr, false, true);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00024634 File Offset: 0x00022834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074599, XrefRangeEnd = 1074618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle PreloadTables(TableReference tableReference, Locale locale = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_PreloadTables_Public_AsyncOperationHandle_TableReference_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00024694 File Offset: 0x00022894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074618, XrefRangeEnd = 1074633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle PreloadTables(IList<TableReference> tableReferences, Locale locale = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tableReferences);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_PreloadTables_Public_AsyncOperationHandle_IList_1_TableReference_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000246F0 File Offset: 0x000228F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1074689, RefRangeEnd = 1074692, XrefRangeStart = 1074633, XrefRangeEnd = 1074689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseAllTables(Locale locale = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_ReleaseAllTables_Public_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00024734 File Offset: 0x00022934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074692, XrefRangeEnd = 1074804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseTable(TableReference tableReference, Locale locale = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_ReleaseTable_Public_Void_TableReference_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00024790 File Offset: 0x00022990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074804, XrefRangeEnd = 1074823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<IList<TTable>> GetAllTables(Locale locale = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetAllTables_Public_Virtual_New_AsyncOperationHandle_1_IList_1_TTable_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<IList<TTable>>(intPtr);
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000247E4 File Offset: 0x000229E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074823, XrefRangeEnd = 1074845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsTableLoaded(TableReference tableReference, Locale locale = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_IsTableLoaded_Public_Virtual_New_Boolean_TableReference_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00024854 File Offset: 0x00022A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074845, XrefRangeEnd = 1074850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LoadTableOperation<TTable, TEntry> CreateLoadTableOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_CreateLoadTableOperation_Internal_Virtual_New_LoadTableOperation_2_TTable_TEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadTableOperation<TTable, TEntry>>(intPtr3) : null;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000248A0 File Offset: 0x00022AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074850, XrefRangeEnd = 1074855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PreloadTablesOperation<TTable, TEntry> CreatePreloadTablesOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_CreatePreloadTablesOperation_Internal_Virtual_New_PreloadTablesOperation_2_TTable_TEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PreloadTablesOperation<TTable, TEntry>>(intPtr3) : null;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000248EC File Offset: 0x00022AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074855, XrefRangeEnd = 1074866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<LocalizedDatabase<TTable, TEntry>.TableEntryResult> GetTableEntryAsync(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetTableEntryAsync_Public_Virtual_New_AsyncOperationHandle_1_TableEntryResult_TTable_TEntry_TableReference_TableEntryReference_Locale_FallbackBehavior_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<LocalizedDatabase<TTable, TEntry>.TableEntryResult>(intPtr);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0002497C File Offset: 0x00022B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074866, XrefRangeEnd = 1074867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LocalizedDatabase<TTable, TEntry>.TableEntryResult GetTableEntry(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetTableEntry_Public_Virtual_New_TableEntryResult_TTable_TEntry_TableReference_TableEntryReference_Locale_FallbackBehavior_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LocalizedDatabase<TTable, TEntry>.TableEntryResult(intPtr);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00024A0C File Offset: 0x00022C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1074880, RefRangeEnd = 1074882, XrefRangeStart = 1074867, XrefRangeEnd = 1074880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<SharedTableData> GetSharedTableData(Guid tableNameGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tableNameGuid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_GetSharedTableData_Internal_AsyncOperationHandle_1_SharedTableData_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<SharedTableData>(intPtr);
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00024A50 File Offset: 0x00022C50
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReleaseTableContents(TTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TTable).IsValueType)
				{
					TTable ttable = table;
					intPtr = ((ttable is string) ? IL2CPP.ManagedStringToIl2Cpp(ttable as string) : IL2CPP.Il2CppObjectBaseToPtr(ttable as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref table;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_ReleaseTableContents_Internal_Virtual_New_Void_TTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00024AD4 File Offset: 0x00022CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074882, XrefRangeEnd = 1074883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnLocaleChanged(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_OnLocaleChanged_Public_Virtual_New_Void_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00024B24 File Offset: 0x00022D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074883, XrefRangeEnd = 1074892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PatchTableContents(AsyncOperationHandle<TTable> tableOperation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableOperation));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_PatchTableContents_Private_Void_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00024B6C File Offset: 0x00022D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074892, XrefRangeEnd = 1074901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_ResetState_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00024BA0 File Offset: 0x00022DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00004A79 File Offset: 0x00002C79
		public LocalizedDatabase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00024BD4 File Offset: 0x00022DD4
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00004A82 File Offset: 0x00002C82
		public TableReference m_DefaultTableReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_DefaultTableReference);
				return new TableReference(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TableReference>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_DefaultTableReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TableReference>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00024C04 File Offset: 0x00022E04
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x00004AB0 File Offset: 0x00002CB0
		public unsafe ITableProvider m_CustomTableProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_CustomTableProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITableProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_CustomTableProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00024C34 File Offset: 0x00022E34
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00004ACF File Offset: 0x00002CCF
		public unsafe ITablePostprocessor m_CustomTablePostprocessor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_CustomTablePostprocessor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITablePostprocessor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_CustomTablePostprocessor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00024C64 File Offset: 0x00022E64
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00004AEE File Offset: 0x00002CEE
		public unsafe AsynchronousBehaviour m_AsynchronousBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_AsynchronousBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_AsynchronousBehaviour)) = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00024C8C File Offset: 0x00022E8C
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00004B09 File Offset: 0x00002D09
		public unsafe bool m_UseFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_UseFallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_UseFallback)) = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00024CB4 File Offset: 0x00022EB4
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00004B24 File Offset: 0x00002D24
		public AsyncOperationHandle m_PreloadOperationHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadOperationHandle);
				return new AsyncOperationHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadOperationHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00024CE4 File Offset: 0x00022EE4
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00004B52 File Offset: 0x00002D52
		public unsafe Action<AsyncOperationHandle> m_ReleaseNextFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_ReleaseNextFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_ReleaseNextFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00024D14 File Offset: 0x00022F14
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x00004B71 File Offset: 0x00002D71
		public unsafe Action<AsyncOperationHandle<TTable>> m_PatchTableContentsAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_PatchTableContentsAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TTable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_PatchTableContentsAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00024D44 File Offset: 0x00022F44
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x00004B90 File Offset: 0x00002D90
		public unsafe Action<AsyncOperationHandle<TTable>> m_RegisterSharedTableAndGuidOperationAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_RegisterSharedTableAndGuidOperationAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TTable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_RegisterSharedTableAndGuidOperationAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00024D74 File Offset: 0x00022F74
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00004BAF File Offset: 0x00002DAF
		public unsafe Action<AsyncOperationHandle<TTable>> m_RegisterCompletedTableOperationAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_RegisterCompletedTableOperationAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TTable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_m_RegisterCompletedTableOperationAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00024DA4 File Offset: 0x00022FA4
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00004BCE File Offset: 0x00002DCE
		public unsafe static LocaleIdentifier k_SelectedLocaleId
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_k_SelectedLocaleId, intPtr);
				return new LocaleIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr_k_SelectedLocaleId, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00024DE0 File Offset: 0x00022FE0
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00004BE5 File Offset: 0x00002DE5
		public unsafe Dictionary<ValueTuple<LocaleIdentifier, string>, AsyncOperationHandle<TTable>> _TableOperations_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr__TableOperations_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<LocaleIdentifier, string>, AsyncOperationHandle<TTable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr__TableOperations_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00024E10 File Offset: 0x00023010
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x00004C04 File Offset: 0x00002E04
		public unsafe Dictionary<Guid, AsyncOperationHandle<SharedTableData>> _SharedTableDataOperations_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr__SharedTableDataOperations_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Guid, AsyncOperationHandle<SharedTableData>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.NativeFieldInfoPtr__SharedTableDataOperations_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultTableReference;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomTableProvider;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomTablePostprocessor;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeFieldInfoPtr_m_AsynchronousBehaviour;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeFieldInfoPtr_m_UseFallback;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeFieldInfoPtr_m_PreloadOperationHandle;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeFieldInfoPtr_m_ReleaseNextFrame;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeFieldInfoPtr_m_PatchTableContentsAction;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeFieldInfoPtr_m_RegisterSharedTableAndGuidOperationAction;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeFieldInfoPtr_m_RegisterCompletedTableOperationAction;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr_k_SelectedLocaleId;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr__TableOperations_k__BackingField;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr__SharedTableDataOperations_k__BackingField;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_get_PreloadOperation_Public_Virtual_Final_New_get_AsyncOperationHandle_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_get_ReleaseNextFrame_Internal_get_Action_1_AsyncOperationHandle_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_get_TableOperations_Internal_get_Dictionary_2_ValueTuple_2_LocaleIdentifier_String_AsyncOperationHandle_1_TTable_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedTableDataOperations_Internal_get_Dictionary_2_Guid_AsyncOperationHandle_1_SharedTableData_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultTable_Public_Virtual_New_get_TableReference_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultTable_Public_Virtual_New_set_Void_TableReference_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_get_TableProvider_Public_get_ITableProvider_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_set_TableProvider_Public_set_Void_ITableProvider_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_get_TablePostprocessor_Public_get_ITablePostprocessor_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_set_TablePostprocessor_Public_set_Void_ITablePostprocessor_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_get_UseFallback_Public_get_Boolean_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_set_UseFallback_Public_set_Void_Boolean_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_get_AsynchronousBehaviour_Public_get_AsynchronousBehaviour_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_set_AsynchronousBehaviour_Public_set_Void_AsynchronousBehaviour_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultTable_Internal_TableReference_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCompletedTableOperation_Internal_Void_AsyncOperationHandle_1_TTable_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTableNameOperation_Private_Void_AsyncOperationHandle_1_TTable_LocaleIdentifier_String_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSharedTableAndGuidOperation_Private_Void_AsyncOperationHandle_1_TTable_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultTableAsync_Public_AsyncOperationHandle_1_TTable_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_GetTableAsync_Public_Virtual_New_AsyncOperationHandle_1_TTable_TableReference_Locale_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_GetTable_Public_Virtual_New_TTable_TableReference_Locale_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_PreloadTables_Public_AsyncOperationHandle_TableReference_Locale_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_PreloadTables_Public_AsyncOperationHandle_IList_1_TableReference_Locale_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAllTables_Public_Void_Locale_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseTable_Public_Void_TableReference_Locale_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTables_Public_Virtual_New_AsyncOperationHandle_1_IList_1_TTable_Locale_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_IsTableLoaded_Public_Virtual_New_Boolean_TableReference_Locale_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_CreateLoadTableOperation_Internal_Virtual_New_LoadTableOperation_2_TTable_TEntry_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_CreatePreloadTablesOperation_Internal_Virtual_New_PreloadTablesOperation_2_TTable_TEntry_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_GetTableEntryAsync_Public_Virtual_New_AsyncOperationHandle_1_TableEntryResult_TTable_TEntry_TableReference_TableEntryReference_Locale_FallbackBehavior_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_GetTableEntry_Public_Virtual_New_TableEntryResult_TTable_TEntry_TableReference_TableEntryReference_Locale_FallbackBehavior_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedTableData_Internal_AsyncOperationHandle_1_SharedTableData_Guid_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseTableContents_Internal_Virtual_New_Void_TTable_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_OnLocaleChanged_Public_Virtual_New_Void_Locale_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_PatchTableContents_Private_Void_AsyncOperationHandle_1_TTable_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_ResetState_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0200015C RID: 348
		public sealed class TableEntryResult : ValueType
		{
			// Token: 0x06000F0F RID: 3855 RVA: 0x00040A30 File Offset: 0x0003EC30
			// Note: this type is marked as 'beforefieldinit'.
			static TableEntryResult()
			{
				Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>.TableEntryResult>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "TableEntryResult"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>.TableEntryResult>.NativeClassPtr);
				LocalizedDatabase<TTable, TEntry>.TableEntryResult.NativeFieldInfoPtr__Entry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>.TableEntryResult>.NativeClassPtr, "<Entry>k__BackingField");
				LocalizedDatabase<TTable, TEntry>.TableEntryResult.NativeFieldInfoPtr__Table_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>.TableEntryResult>.NativeClassPtr, "<Table>k__BackingField");
				LocalizedDatabase<TTable, TEntry>.TableEntryResult.NativeMethodInfoPtr_get_Entry_Public_get_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>.TableEntryResult>.NativeClassPtr, 100664592);
				LocalizedDatabase<TTable, TEntry>.TableEntryResult.NativeMethodInfoPtr_get_Table_Public_get_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>.TableEntryResult>.NativeClassPtr, 100664593);
				LocalizedDatabase<TTable, TEntry>.TableEntryResult.NativeMethodInfoPtr__ctor_Internal_Void_TEntry_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>.TableEntryResult>.NativeClassPtr, 100664594);
			}

			// Token: 0x17000412 RID: 1042
			// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00040B0C File Offset: 0x0003ED0C
			public unsafe TEntry Entry
			{
				[CallerCount(99)]
				[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.TableEntryResult.NativeMethodInfoPtr_get_Entry_Public_get_TEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
				}
			}

			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x06000F11 RID: 3857 RVA: 0x00040B4C File Offset: 0x0003ED4C
			public unsafe TTable Table
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.TableEntryResult.NativeMethodInfoPtr_get_Table_Public_get_TTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TTable>(intPtr, false, true);
				}
			}

			// Token: 0x06000F12 RID: 3858 RVA: 0x00040B8C File Offset: 0x0003ED8C
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TableEntryResult(TEntry entry, TTable table)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>.TableEntryResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TEntry).IsValueType)
					{
						TEntry tentry = entry;
						intPtr = ((tentry is string) ? IL2CPP.ManagedStringToIl2Cpp(tentry as string) : IL2CPP.Il2CppObjectBaseToPtr(tentry as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref entry;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TTable).IsValueType)
				{
					TTable ttable = table;
					intPtr2 = ((ttable is string) ? IL2CPP.ManagedStringToIl2Cpp(ttable as string) : IL2CPP.Il2CppObjectBaseToPtr(ttable as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref table;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LocalizedDatabase<TTable, TEntry>.TableEntryResult.NativeMethodInfoPtr__ctor_Internal_Void_TEntry_TTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}

			// Token: 0x06000F13 RID: 3859 RVA: 0x00008529 File Offset: 0x00006729
			public TableEntryResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000F14 RID: 3860 RVA: 0x00008532 File Offset: 0x00006732
			public TableEntryResult()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>.TableEntryResult>.NativeClassPtr))
			{
			}

			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x06000F15 RID: 3861 RVA: 0x00040C5C File Offset: 0x0003EE5C
			// (set) Token: 0x06000F16 RID: 3862 RVA: 0x00040C84 File Offset: 0x0003EE84
			public unsafe TEntry _Entry_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.TableEntryResult.NativeFieldInfoPtr__Entry_k__BackingField);
					return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.TableEntryResult.NativeFieldInfoPtr__Entry_k__BackingField);
					Type typeFromHandle = typeof(TEntry);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x06000F17 RID: 3863 RVA: 0x00040D2C File Offset: 0x0003EF2C
			// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00040D54 File Offset: 0x0003EF54
			public unsafe TTable _Table_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.TableEntryResult.NativeFieldInfoPtr__Table_k__BackingField);
					return IL2CPP.PointerToValueGeneric<TTable>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedDatabase<TTable, TEntry>.TableEntryResult.NativeFieldInfoPtr__Table_k__BackingField);
					Type typeFromHandle = typeof(TTable);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04000A56 RID: 2646
			private static readonly IntPtr NativeFieldInfoPtr__Entry_k__BackingField;

			// Token: 0x04000A57 RID: 2647
			private static readonly IntPtr NativeFieldInfoPtr__Table_k__BackingField;

			// Token: 0x04000A58 RID: 2648
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_get_TEntry_0;

			// Token: 0x04000A59 RID: 2649
			private static readonly IntPtr NativeMethodInfoPtr_get_Table_Public_get_TTable_0;

			// Token: 0x04000A5A RID: 2650
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TEntry_TTable_0;
		}

		// Token: 0x0200015D RID: 349
		[ObfuscatedName("UnityEngine.Localization.Settings.LocalizedDatabase`2+<>O")]
		public static class __O : Object
		{
			// Token: 0x06000F19 RID: 3865 RVA: 0x00040DFC File Offset: 0x0003EFFC
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>.__O>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>>.NativeClassPtr, "<>O"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>.__O>.NativeClassPtr);
				LocalizedDatabase<TTable, TEntry>.__O.NativeFieldInfoPtr__0___ReleaseNextFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedDatabase<TTable, TEntry>.__O>.NativeClassPtr, "<0>__ReleaseNextFrame");
			}

			// Token: 0x06000F1A RID: 3866 RVA: 0x00008544 File Offset: 0x00006744
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06000F1B RID: 3867 RVA: 0x00040E88 File Offset: 0x0003F088
			// (set) Token: 0x06000F1C RID: 3868 RVA: 0x0000854D File Offset: 0x0000674D
			public unsafe static Action<AsyncOperationHandle> _0___ReleaseNextFrame
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalizedDatabase<TTable, TEntry>.__O.NativeFieldInfoPtr__0___ReleaseNextFrame, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalizedDatabase<TTable, TEntry>.__O.NativeFieldInfoPtr__0___ReleaseNextFrame, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A5B RID: 2651
			private static readonly IntPtr NativeFieldInfoPtr__0___ReleaseNextFrame;
		}
	}
}
