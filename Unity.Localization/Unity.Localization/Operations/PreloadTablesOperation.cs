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

namespace UnityEngine.Localization.Operations
{
	// Token: 0x020000BE RID: 190
	public class PreloadTablesOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase<TTable, TEntry>> where TTable : DetailedLocalizationTable<TEntry> where TEntry : TableEntry
	{
		// Token: 0x06000A35 RID: 2613 RVA: 0x0002FEF4 File Offset: 0x0002E0F4
		// Note: this type is marked as 'beforefieldinit'.
		static PreloadTablesOperation()
		{
			Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Operations", "PreloadTablesOperation`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr);
			PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_Database");
			PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTables");
			PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTablesOperation");
			PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadTablesOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_PreloadTablesOperations");
			PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableContentsAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTableContentsAction");
			PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_FinishPreloadingAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_FinishPreloadingAction");
			PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesOperationHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTablesOperationHandle");
			PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadTablesContentsHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_PreloadTablesContentsHandle");
			PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_TableReferences");
			PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_SelectedLocale");
			PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, "Pool");
			PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, 100665025);
			PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_IList_1_TableReference_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, 100665026);
			PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, 100665027);
			PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_BeginPreloadingTables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, 100665028);
			PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_LoadTableContents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, 100665029);
			PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_FinishPreloading_Private_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, 100665030);
			PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, 100665031);
			PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr___ctor_b__11_0_Private_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, 100665033);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x000300F0 File Offset: 0x0002E2F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078596, RefRangeEnd = 1078597, XrefRangeStart = 1078569, XrefRangeEnd = 1078596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreloadTablesOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0003012C File Offset: 0x0002E32C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1078600, RefRangeEnd = 1078602, XrefRangeStart = 1078597, XrefRangeEnd = 1078600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(LocalizedDatabase<TTable, TEntry> database, IList<TableReference> tableReference, Locale locale = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(database);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tableReference);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_IList_1_TableReference_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00030194 File Offset: 0x0002E394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078602, XrefRangeEnd = 1078603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000301D0 File Offset: 0x0002E3D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078641, RefRangeEnd = 1078642, XrefRangeStart = 1078603, XrefRangeEnd = 1078641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginPreloadingTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_BeginPreloadingTables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00030204 File Offset: 0x0002E404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078679, RefRangeEnd = 1078680, XrefRangeStart = 1078642, XrefRangeEnd = 1078679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTableContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_LoadTableContents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00030238 File Offset: 0x0002E438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078680, XrefRangeEnd = 1078682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishPreloading(AsyncOperationHandle op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_FinishPreloading_Private_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00030280 File Offset: 0x0002E480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078682, XrefRangeEnd = 1078698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x000302BC File Offset: 0x0002E4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078698, XrefRangeEnd = 1078703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_0(AsyncOperationHandle<IList<AsyncOperationHandle>> a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadTablesOperation<TTable, TEntry>.NativeMethodInfoPtr___ctor_b__11_0_Private_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0000629B File Offset: 0x0000449B
		public PreloadTablesOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00030304 File Offset: 0x0002E504
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x000062A4 File Offset: 0x000044A4
		public unsafe LocalizedDatabase<TTable, TEntry> m_Database
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedDatabase<TTable, TEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00030334 File Offset: 0x0002E534
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x000062C3 File Offset: 0x000044C3
		public unsafe List<AsyncOperationHandle<TTable>> m_LoadTables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AsyncOperationHandle<TTable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00030364 File Offset: 0x0002E564
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x000062E2 File Offset: 0x000044E2
		public unsafe List<AsyncOperationHandle> m_LoadTablesOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00030394 File Offset: 0x0002E594
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00006301 File Offset: 0x00004501
		public unsafe List<AsyncOperationHandle> m_PreloadTablesOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadTablesOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadTablesOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x000303C4 File Offset: 0x0002E5C4
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x00006320 File Offset: 0x00004520
		public unsafe Action<AsyncOperationHandle<IList<AsyncOperationHandle>>> m_LoadTableContentsAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableContentsAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<IList<AsyncOperationHandle>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableContentsAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x000303F4 File Offset: 0x0002E5F4
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x0000633F File Offset: 0x0000453F
		public unsafe Action<AsyncOperationHandle> m_FinishPreloadingAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_FinishPreloadingAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_FinishPreloadingAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00030424 File Offset: 0x0002E624
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x0000635E File Offset: 0x0000455E
		public AsyncOperationHandle<IList<AsyncOperationHandle>> m_LoadTablesOperationHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesOperationHandle);
				return new AsyncOperationHandle<IList<AsyncOperationHandle>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTablesOperationHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00030454 File Offset: 0x0002E654
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x0000638C File Offset: 0x0000458C
		public AsyncOperationHandle<IList<AsyncOperationHandle>> m_PreloadTablesContentsHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadTablesContentsHandle);
				return new AsyncOperationHandle<IList<AsyncOperationHandle>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_PreloadTablesContentsHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00030484 File Offset: 0x0002E684
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x000063BA File Offset: 0x000045BA
		public unsafe IList<TableReference> m_TableReferences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableReferences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<TableReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableReferences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x000304B4 File Offset: 0x0002E6B4
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x000063D9 File Offset: 0x000045D9
		public unsafe Locale m_SelectedLocale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x000304E4 File Offset: 0x0002E6E4
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x000063F8 File Offset: 0x000045F8
		public unsafe static ObjectPool<PreloadTablesOperation<TTable, TEntry>> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<PreloadTablesOperation<TTable, TEntry>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PreloadTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_m_Database;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTables;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTablesOperation;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_m_PreloadTablesOperations;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTableContentsAction;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_m_FinishPreloadingAction;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTablesOperationHandle;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_m_PreloadTablesContentsHandle;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_m_TableReferences;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedLocale;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_IList_1_TableReference_Locale_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_BeginPreloadingTables_Private_Void_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_LoadTableContents_Private_Void_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_FinishPreloading_Private_Void_AsyncOperationHandle_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_0_Private_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0;

		// Token: 0x02000173 RID: 371
		[ObfuscatedName("UnityEngine.Localization.Operations.PreloadTablesOperation`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F9C RID: 3996 RVA: 0x000429A4 File Offset: 0x00040BA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>.__c>.NativeClassPtr);
				PreloadTablesOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>.__c>.NativeClassPtr, "<>9");
				PreloadTablesOperation<TTable, TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>.__c>.NativeClassPtr, 100665035);
				PreloadTablesOperation<TTable, TEntry>.__c.NativeMethodInfoPtr___cctor_b__18_0_Internal_PreloadTablesOperation_2_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>.__c>.NativeClassPtr, 100665036);
			}

			// Token: 0x06000F9D RID: 3997 RVA: 0x00042A58 File Offset: 0x00040C58
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreloadTablesOperation<TTable, TEntry>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadTablesOperation<TTable, TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F9E RID: 3998 RVA: 0x00042A94 File Offset: 0x00040C94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078566, XrefRangeEnd = 1078569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PreloadTablesOperation<TTable, TEntry> __cctor_b__18_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadTablesOperation<TTable, TEntry>.__c.NativeMethodInfoPtr___cctor_b__18_0_Internal_PreloadTablesOperation_2_TTable_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PreloadTablesOperation<TTable, TEntry>>(intPtr3) : null;
			}

			// Token: 0x06000F9F RID: 3999 RVA: 0x000087DA File Offset: 0x000069DA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700042D RID: 1069
			// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00042AD4 File Offset: 0x00040CD4
			// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x000087E3 File Offset: 0x000069E3
			public unsafe static PreloadTablesOperation<TTable, TEntry>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PreloadTablesOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PreloadTablesOperation<TTable, TEntry>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PreloadTablesOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AB8 RID: 2744
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000AB9 RID: 2745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000ABA RID: 2746
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__18_0_Internal_PreloadTablesOperation_2_TTable_TEntry_0;
		}
	}
}
