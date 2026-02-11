using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.Localization.Operations
{
	// Token: 0x020000BA RID: 186
	public class LoadTableOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<TTable> where TTable : DetailedLocalizationTable<TEntry> where TEntry : TableEntry
	{
		// Token: 0x060009C9 RID: 2505 RVA: 0x0002E7B4 File Offset: 0x0002C9B4
		// Note: this type is marked as 'beforefieldinit'.
		static LoadTableOperation()
		{
			Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Operations", "LoadTableOperation`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr);
			LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableByGuidAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTableByGuidAction");
			LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableResourceAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTableResourceAction");
			LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableLoadedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, "m_TableLoadedAction");
			LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CustomTableLoadedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, "m_CustomTableLoadedAction");
			LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, "m_Database");
			LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, "m_TableReference");
			LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTableOperation");
			LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, "m_SelectedLocale");
			LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CollectionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, "m_CollectionName");
			LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, "Pool");
			LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr__RegisterTableOperation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, "<RegisterTableOperation>k__BackingField");
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_get_RegisterTableOperation_Public_get_Action_1_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664969);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_set_RegisterTableOperation_Private_set_Void_Action_1_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664970);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664971);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_TableReference_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664972);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664973);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_LoadTableByGuid_Private_Void_AsyncOperationHandle_1_SharedTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664974);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_FindTableByName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664975);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_TryLoadWithTableProvider_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664976);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_DefaultLoadTableByName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664977);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_LoadTableResource_Private_Void_AsyncOperationHandle_1_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664978);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_CustomTableLoaded_Private_Void_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664979);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_TableLoaded_Private_Void_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664980);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664981);
			LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, 100664982);
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0002EA28 File Offset: 0x0002CC28
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x0002EA68 File Offset: 0x0002CC68
		public unsafe Action<AsyncOperationHandle<TTable>> RegisterTableOperation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_get_RegisterTableOperation_Public_get_Action_1_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TTable>>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_set_RegisterTableOperation_Private_set_Void_Action_1_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0002EAAC File Offset: 0x0002CCAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078026, RefRangeEnd = 1078027, XrefRangeStart = 1078007, XrefRangeEnd = 1078026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadTableOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0002EAE8 File Offset: 0x0002CCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078027, XrefRangeEnd = 1078030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(LocalizedDatabase<TTable, TEntry> database, TableReference tableReference, Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(database);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_TableReference_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0002EB54 File Offset: 0x0002CD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078030, XrefRangeEnd = 1078075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0002EB90 File Offset: 0x0002CD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078075, XrefRangeEnd = 1078086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTableByGuid(AsyncOperationHandle<SharedTableData> operationHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(operationHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_LoadTableByGuid_Private_Void_AsyncOperationHandle_1_SharedTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0002EBD8 File Offset: 0x0002CDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078086, XrefRangeEnd = 1078089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindTableByName(string collectionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(collectionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_FindTableByName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0002EC1C File Offset: 0x0002CE1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078097, RefRangeEnd = 1078098, XrefRangeStart = 1078089, XrefRangeEnd = 1078097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryLoadWithTableProvider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_TryLoadWithTableProvider_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0002EC58 File Offset: 0x0002CE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078098, XrefRangeEnd = 1078113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefaultLoadTableByName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_DefaultLoadTableByName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0002EC8C File Offset: 0x0002CE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078113, XrefRangeEnd = 1078150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTableResource(AsyncOperationHandle<IList<IResourceLocation>> operationHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(operationHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_LoadTableResource_Private_Void_AsyncOperationHandle_1_IList_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0002ECD4 File Offset: 0x0002CED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078150, XrefRangeEnd = 1078158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomTableLoaded(AsyncOperationHandle<TTable> operationHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(operationHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_CustomTableLoaded_Private_Void_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0002ED1C File Offset: 0x0002CF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078158, XrefRangeEnd = 1078161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TableLoaded(AsyncOperationHandle<TTable> operationHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(operationHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_TableLoaded_Private_Void_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0002ED64 File Offset: 0x0002CF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078161, XrefRangeEnd = 1078168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0002EDA0 File Offset: 0x0002CFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078168, XrefRangeEnd = 1078175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadTableOperation<TTable, TEntry>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00005EC2 File Offset: 0x000040C2
		public LoadTableOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0002EDE4 File Offset: 0x0002CFE4
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x00005ECB File Offset: 0x000040CB
		public unsafe Action<AsyncOperationHandle<SharedTableData>> m_LoadTableByGuidAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableByGuidAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<SharedTableData>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableByGuidAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0002EE14 File Offset: 0x0002D014
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x00005EEA File Offset: 0x000040EA
		public unsafe Action<AsyncOperationHandle<IList<IResourceLocation>>> m_LoadTableResourceAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableResourceAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<IList<IResourceLocation>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableResourceAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0002EE44 File Offset: 0x0002D044
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x00005F09 File Offset: 0x00004109
		public unsafe Action<AsyncOperationHandle<TTable>> m_TableLoadedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableLoadedAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TTable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableLoadedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0002EE74 File Offset: 0x0002D074
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x00005F28 File Offset: 0x00004128
		public unsafe Action<AsyncOperationHandle<TTable>> m_CustomTableLoadedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CustomTableLoadedAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TTable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CustomTableLoadedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0002EEA4 File Offset: 0x0002D0A4
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00005F47 File Offset: 0x00004147
		public unsafe LocalizedDatabase<TTable, TEntry> m_Database
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedDatabase<TTable, TEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x0002EED4 File Offset: 0x0002D0D4
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00005F66 File Offset: 0x00004166
		public TableReference m_TableReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableReference);
				return new TableReference(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TableReference>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TableReference>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0002EF04 File Offset: 0x0002D104
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x00005F94 File Offset: 0x00004194
		public AsyncOperationHandle<TTable> m_LoadTableOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableOperation);
				return new AsyncOperationHandle<TTable>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<TTable>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<TTable>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0002EF34 File Offset: 0x0002D134
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x00005FC2 File Offset: 0x000041C2
		public unsafe Locale m_SelectedLocale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0002EF64 File Offset: 0x0002D164
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00005FE1 File Offset: 0x000041E1
		public unsafe string m_CollectionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CollectionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CollectionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0002EF8C File Offset: 0x0002D18C
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00006000 File Offset: 0x00004200
		public unsafe static ObjectPool<LoadTableOperation<TTable, TEntry>> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<LoadTableOperation<TTable, TEntry>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0002EFB4 File Offset: 0x0002D1B4
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00006012 File Offset: 0x00004212
		public unsafe Action<AsyncOperationHandle<TTable>> _RegisterTableOperation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr__RegisterTableOperation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TTable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadTableOperation<TTable, TEntry>.NativeFieldInfoPtr__RegisterTableOperation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTableByGuidAction;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTableResourceAction;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr_m_TableLoadedAction;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomTableLoadedAction;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeFieldInfoPtr_m_Database;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeFieldInfoPtr_m_TableReference;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTableOperation;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedLocale;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectionName;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeFieldInfoPtr__RegisterTableOperation_k__BackingField;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisterTableOperation_Public_get_Action_1_AsyncOperationHandle_1_TTable_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_set_RegisterTableOperation_Private_set_Void_Action_1_AsyncOperationHandle_1_TTable_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_TableReference_Locale_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_LoadTableByGuid_Private_Void_AsyncOperationHandle_1_SharedTableData_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_FindTableByName_Private_Void_String_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadWithTableProvider_Private_Boolean_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_DefaultLoadTableByName_Private_Void_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_LoadTableResource_Private_Void_AsyncOperationHandle_1_IList_1_IResourceLocation_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_CustomTableLoaded_Private_Void_AsyncOperationHandle_1_TTable_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_TableLoaded_Private_Void_AsyncOperationHandle_1_TTable_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0200016F RID: 367
		[ObfuscatedName("UnityEngine.Localization.Operations.LoadTableOperation`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F84 RID: 3972 RVA: 0x00042490 File Offset: 0x00040690
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>.__c>.NativeClassPtr);
				LoadTableOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>.__c>.NativeClassPtr, "<>9");
				LoadTableOperation<TTable, TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>.__c>.NativeClassPtr, 100664985);
				LoadTableOperation<TTable, TEntry>.__c.NativeMethodInfoPtr___cctor_b__26_0_Internal_LoadTableOperation_2_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>.__c>.NativeClassPtr, 100664986);
			}

			// Token: 0x06000F85 RID: 3973 RVA: 0x00042544 File Offset: 0x00040744
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadTableOperation<TTable, TEntry>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F86 RID: 3974 RVA: 0x00042580 File Offset: 0x00040780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078004, XrefRangeEnd = 1078007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LoadTableOperation<TTable, TEntry> __cctor_b__26_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadTableOperation<TTable, TEntry>.__c.NativeMethodInfoPtr___cctor_b__26_0_Internal_LoadTableOperation_2_TTable_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadTableOperation<TTable, TEntry>>(intPtr3) : null;
			}

			// Token: 0x06000F87 RID: 3975 RVA: 0x0000876E File Offset: 0x0000696E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x06000F88 RID: 3976 RVA: 0x000425C0 File Offset: 0x000407C0
			// (set) Token: 0x06000F89 RID: 3977 RVA: 0x00008777 File Offset: 0x00006977
			public unsafe static LoadTableOperation<TTable, TEntry>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadTableOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadTableOperation<TTable, TEntry>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadTableOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AAC RID: 2732
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000AAD RID: 2733
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000AAE RID: 2734
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__26_0_Internal_LoadTableOperation_2_TTable_TEntry_0;
		}
	}
}
