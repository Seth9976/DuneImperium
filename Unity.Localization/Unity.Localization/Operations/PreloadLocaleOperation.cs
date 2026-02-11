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
	// Token: 0x020000BD RID: 189
	public class PreloadLocaleOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase<TTable, TEntry>> where TTable : DetailedLocalizationTable<TEntry> where TEntry : TableEntry
	{
		// Token: 0x06000A0B RID: 2571 RVA: 0x0002F6A4 File Offset: 0x0002D8A4
		// Note: this type is marked as 'beforefieldinit'.
		static PreloadLocaleOperation()
		{
			Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Operations", "PreloadLocaleOperation`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr);
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTablesAction");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableContentsAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTableContentsAction");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_FinishPreloadingAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_FinishPreloadingAction");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadTablesCompletedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_PreloadTablesCompletedAction");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_Database");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_Locale");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadResourcesOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadResourcesOperation");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesGroupOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTablesGroupOperation");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableContentsOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTableContentsOperation");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTablesOperations");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadTableContentsOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_PreloadTableContentsOperations");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_ResourceLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_ResourceLabels");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "m_Progress");
			PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "Pool");
			PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, 100665009);
			PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, 100665010);
			PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, 100665011);
			PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, 100665012);
			PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, 100665013);
			PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_BeginPreloading_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, 100665014);
			PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_LoadTables_Private_Void_AsyncOperationHandle_1_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, 100665015);
			PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_LoadTableContents_Private_Void_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, 100665016);
			PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_PreloadTablesCompleted_Private_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, 100665017);
			PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_FinishPreloading_Private_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, 100665018);
			PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_CompleteAndRelease_Private_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, 100665019);
			PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, 100665020);
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0002F92C File Offset: 0x0002DB2C
		public unsafe override float Progress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0002F974 File Offset: 0x0002DB74
		public unsafe override string DebugName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078346, XrefRangeEnd = 1078351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0002F9B8 File Offset: 0x0002DBB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078390, RefRangeEnd = 1078391, XrefRangeStart = 1078351, XrefRangeEnd = 1078390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreloadLocaleOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0002F9F4 File Offset: 0x0002DBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078391, XrefRangeEnd = 1078396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(LocalizedDatabase<TTable, TEntry> database, Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(database);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0002FA48 File Offset: 0x0002DC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078396, XrefRangeEnd = 1078397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0002FA84 File Offset: 0x0002DC84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078430, RefRangeEnd = 1078431, XrefRangeStart = 1078397, XrefRangeEnd = 1078430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginPreloading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_BeginPreloading_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0002FAB8 File Offset: 0x0002DCB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078431, XrefRangeEnd = 1078507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTables(AsyncOperationHandle<IList<IResourceLocation>> loadResourcesOperation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loadResourcesOperation));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_LoadTables_Private_Void_AsyncOperationHandle_1_IList_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0002FB00 File Offset: 0x0002DD00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078532, RefRangeEnd = 1078533, XrefRangeStart = 1078507, XrefRangeEnd = 1078532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTableContents(AsyncOperationHandle<TTable> operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(operation));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_LoadTableContents_Private_Void_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0002FB48 File Offset: 0x0002DD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078533, XrefRangeEnd = 1078549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreloadTablesCompleted(AsyncOperationHandle<IList<AsyncOperationHandle>> obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_PreloadTablesCompleted_Private_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0002FB90 File Offset: 0x0002DD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078549, XrefRangeEnd = 1078551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishPreloading(AsyncOperationHandle op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_FinishPreloading_Private_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0002FBD8 File Offset: 0x0002DDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078551, XrefRangeEnd = 1078560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteAndRelease(bool success, string errorMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref success;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_CompleteAndRelease_Private_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0002FC28 File Offset: 0x0002DE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078560, XrefRangeEnd = 1078566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PreloadLocaleOperation<TTable, TEntry>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000060C4 File Offset: 0x000042C4
		public PreloadLocaleOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0002FC64 File Offset: 0x0002DE64
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x000060CD File Offset: 0x000042CD
		public unsafe Action<AsyncOperationHandle<IList<IResourceLocation>>> m_LoadTablesAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<IList<IResourceLocation>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0002FC94 File Offset: 0x0002DE94
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x000060EC File Offset: 0x000042EC
		public unsafe Action<AsyncOperationHandle<TTable>> m_LoadTableContentsAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableContentsAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TTable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableContentsAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0002FCC4 File Offset: 0x0002DEC4
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x0000610B File Offset: 0x0000430B
		public unsafe Action<AsyncOperationHandle> m_FinishPreloadingAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_FinishPreloadingAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_FinishPreloadingAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0002FCF4 File Offset: 0x0002DEF4
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x0000612A File Offset: 0x0000432A
		public unsafe Action<AsyncOperationHandle<IList<AsyncOperationHandle>>> m_PreloadTablesCompletedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadTablesCompletedAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<IList<AsyncOperationHandle>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadTablesCompletedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0002FD24 File Offset: 0x0002DF24
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x00006149 File Offset: 0x00004349
		public unsafe LocalizedDatabase<TTable, TEntry> m_Database
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedDatabase<TTable, TEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x0002FD54 File Offset: 0x0002DF54
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00006168 File Offset: 0x00004368
		public unsafe Locale m_Locale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Locale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Locale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0002FD84 File Offset: 0x0002DF84
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x00006187 File Offset: 0x00004387
		public AsyncOperationHandle<IList<IResourceLocation>> m_LoadResourcesOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadResourcesOperation);
				return new AsyncOperationHandle<IList<IResourceLocation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadResourcesOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0002FDB4 File Offset: 0x0002DFB4
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x000061B5 File Offset: 0x000043B5
		public AsyncOperationHandle<IList<AsyncOperationHandle>> m_LoadTablesGroupOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesGroupOperation);
				return new AsyncOperationHandle<IList<AsyncOperationHandle>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesGroupOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0002FDE4 File Offset: 0x0002DFE4
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x000061E3 File Offset: 0x000043E3
		public AsyncOperationHandle<IList<AsyncOperationHandle>> m_LoadTableContentsOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableContentsOperation);
				return new AsyncOperationHandle<IList<AsyncOperationHandle>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableContentsOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0002FE14 File Offset: 0x0002E014
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x00006211 File Offset: 0x00004411
		public unsafe List<AsyncOperationHandle> m_LoadTablesOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0002FE44 File Offset: 0x0002E044
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00006230 File Offset: 0x00004430
		public unsafe List<AsyncOperationHandle> m_PreloadTableContentsOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadTableContentsOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadTableContentsOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0002FE74 File Offset: 0x0002E074
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x0000624F File Offset: 0x0000444F
		public unsafe List<string> m_ResourceLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_ResourceLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_ResourceLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0002FEA4 File Offset: 0x0002E0A4
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x0000626E File Offset: 0x0000446E
		public unsafe float m_Progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Progress)) = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0002FECC File Offset: 0x0002E0CC
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00006289 File Offset: 0x00004489
		public unsafe static ObjectPool<PreloadLocaleOperation<TTable, TEntry>> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<PreloadLocaleOperation<TTable, TEntry>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PreloadLocaleOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTablesAction;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTableContentsAction;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_m_FinishPreloadingAction;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_m_PreloadTablesCompletedAction;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_m_Database;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_m_Locale;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadResourcesOperation;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTablesGroupOperation;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTableContentsOperation;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTablesOperations;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_m_PreloadTableContentsOperations;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceLabels;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_m_Progress;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_Locale_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_BeginPreloading_Private_Void_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_LoadTables_Private_Void_AsyncOperationHandle_1_IList_1_IResourceLocation_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_LoadTableContents_Private_Void_AsyncOperationHandle_1_TTable_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_PreloadTablesCompleted_Private_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_FinishPreloading_Private_Void_AsyncOperationHandle_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAndRelease_Private_Void_Boolean_String_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x02000172 RID: 370
		[ObfuscatedName("UnityEngine.Localization.Operations.PreloadLocaleOperation`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F96 RID: 3990 RVA: 0x0004284C File Offset: 0x00040A4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>.__c>.NativeClassPtr);
				PreloadLocaleOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>.__c>.NativeClassPtr, "<>9");
				PreloadLocaleOperation<TTable, TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>.__c>.NativeClassPtr, 100665023);
				PreloadLocaleOperation<TTable, TEntry>.__c.NativeMethodInfoPtr___cctor_b__28_0_Internal_PreloadLocaleOperation_2_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>.__c>.NativeClassPtr, 100665024);
			}

			// Token: 0x06000F97 RID: 3991 RVA: 0x00042900 File Offset: 0x00040B00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreloadLocaleOperation<TTable, TEntry>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadLocaleOperation<TTable, TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F98 RID: 3992 RVA: 0x0004293C File Offset: 0x00040B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078343, XrefRangeEnd = 1078346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PreloadLocaleOperation<TTable, TEntry> __cctor_b__28_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadLocaleOperation<TTable, TEntry>.__c.NativeMethodInfoPtr___cctor_b__28_0_Internal_PreloadLocaleOperation_2_TTable_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PreloadLocaleOperation<TTable, TEntry>>(intPtr3) : null;
			}

			// Token: 0x06000F99 RID: 3993 RVA: 0x000087BF File Offset: 0x000069BF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700042C RID: 1068
			// (get) Token: 0x06000F9A RID: 3994 RVA: 0x0004297C File Offset: 0x00040B7C
			// (set) Token: 0x06000F9B RID: 3995 RVA: 0x000087C8 File Offset: 0x000069C8
			public unsafe static PreloadLocaleOperation<TTable, TEntry>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PreloadLocaleOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PreloadLocaleOperation<TTable, TEntry>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PreloadLocaleOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AB5 RID: 2741
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000AB6 RID: 2742
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000AB7 RID: 2743
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__28_0_Internal_PreloadLocaleOperation_2_TTable_TEntry_0;
		}
	}
}
