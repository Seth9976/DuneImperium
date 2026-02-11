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
	// Token: 0x020000BC RID: 188
	public class PreloadDatabaseOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase<TTable, TEntry>> where TTable : DetailedLocalizationTable<TEntry> where TEntry : TableEntry
	{
		// Token: 0x060009F6 RID: 2550 RVA: 0x0002F14C File Offset: 0x0002D34C
		// Note: this type is marked as 'beforefieldinit'.
		static PreloadDatabaseOperation()
		{
			Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Operations", "PreloadDatabaseOperation`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr);
			PreloadDatabaseOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CompleteOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, "m_CompleteOperation");
			PreloadDatabaseOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CompleteGenericGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, "m_CompleteGenericGroup");
			PreloadDatabaseOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, "m_Database");
			PreloadDatabaseOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, "Pool");
			PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, 100664994);
			PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, 100664995);
			PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, 100664996);
			PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, 100664997);
			PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, 100664998);
			PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_GetAllFallbackLocales_Private_Void_Locale_HashSet_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, 100664999);
			PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_PreloadLocale_Private_AsyncOperationHandle_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, 100665000);
			PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_PreloadLocales_Private_Void_ICollection_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, 100665001);
			PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_CompleteOperation_Private_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, 100665002);
			PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_CompleteGenericGroup_Private_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, 100665003);
			PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, 100665004);
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0002F2F8 File Offset: 0x0002D4F8
		public unsafe override float Progress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078214, XrefRangeEnd = 1078216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0002F340 File Offset: 0x0002D540
		public unsafe override string DebugName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078216, XrefRangeEnd = 1078221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0002F384 File Offset: 0x0002D584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078232, RefRangeEnd = 1078233, XrefRangeStart = 1078221, XrefRangeEnd = 1078232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreloadDatabaseOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0002F3C0 File Offset: 0x0002D5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(LocalizedDatabase<TTable, TEntry> database)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(database);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0002F404 File Offset: 0x0002D604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078233, XrefRangeEnd = 1078247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0002F440 File Offset: 0x0002D640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078269, RefRangeEnd = 1078270, XrefRangeStart = 1078247, XrefRangeEnd = 1078269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAllFallbackLocales(Locale current, HashSet<Locale> locales)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locales);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_GetAllFallbackLocales_Private_Void_Locale_HashSet_1_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0002F494 File Offset: 0x0002D694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1078282, RefRangeEnd = 1078283, XrefRangeStart = 1078270, XrefRangeEnd = 1078282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle PreloadLocale(Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_PreloadLocale_Private_AsyncOperationHandle_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0002F4DC File Offset: 0x0002D6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078283, XrefRangeEnd = 1078330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreloadLocales(ICollection<Locale> locales)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locales);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_PreloadLocales_Private_Void_ICollection_1_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0002F520 File Offset: 0x0002D720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078330, XrefRangeEnd = 1078332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteOperation(AsyncOperationHandle operationHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(operationHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_CompleteOperation_Private_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0002F568 File Offset: 0x0002D768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078332, XrefRangeEnd = 1078337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteGenericGroup(AsyncOperationHandle<IList<AsyncOperationHandle>> operationHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(operationHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_CompleteGenericGroup_Private_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0002F5B0 File Offset: 0x0002D7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078337, XrefRangeEnd = 1078343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PreloadDatabaseOperation<TTable, TEntry>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0000604C File Offset: 0x0000424C
		public PreloadDatabaseOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0002F5EC File Offset: 0x0002D7EC
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00006055 File Offset: 0x00004255
		public unsafe Action<AsyncOperationHandle> m_CompleteOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadDatabaseOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CompleteOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadDatabaseOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CompleteOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0002F61C File Offset: 0x0002D81C
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00006074 File Offset: 0x00004274
		public unsafe Action<AsyncOperationHandle<IList<AsyncOperationHandle>>> m_CompleteGenericGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadDatabaseOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CompleteGenericGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<IList<AsyncOperationHandle>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadDatabaseOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CompleteGenericGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0002F64C File Offset: 0x0002D84C
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x00006093 File Offset: 0x00004293
		public unsafe LocalizedDatabase<TTable, TEntry> m_Database
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadDatabaseOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedDatabase<TTable, TEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PreloadDatabaseOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0002F67C File Offset: 0x0002D87C
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x000060B2 File Offset: 0x000042B2
		public unsafe static ObjectPool<PreloadDatabaseOperation<TTable, TEntry>> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PreloadDatabaseOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<PreloadDatabaseOperation<TTable, TEntry>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PreloadDatabaseOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeFieldInfoPtr_m_CompleteOperation;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr_m_CompleteGenericGroup;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeFieldInfoPtr_m_Database;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_GetAllFallbackLocales_Private_Void_Locale_HashSet_1_Locale_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_PreloadLocale_Private_AsyncOperationHandle_Locale_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_PreloadLocales_Private_Void_ICollection_1_Locale_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_CompleteOperation_Private_Void_AsyncOperationHandle_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_CompleteGenericGroup_Private_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x02000171 RID: 369
		[ObfuscatedName("UnityEngine.Localization.Operations.PreloadDatabaseOperation`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F90 RID: 3984 RVA: 0x000426F4 File Offset: 0x000408F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>.__c>.NativeClassPtr);
				PreloadDatabaseOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>.__c>.NativeClassPtr, "<>9");
				PreloadDatabaseOperation<TTable, TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>.__c>.NativeClassPtr, 100665007);
				PreloadDatabaseOperation<TTable, TEntry>.__c.NativeMethodInfoPtr___cctor_b__17_0_Internal_PreloadDatabaseOperation_2_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>.__c>.NativeClassPtr, 100665008);
			}

			// Token: 0x06000F91 RID: 3985 RVA: 0x000427A8 File Offset: 0x000409A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreloadDatabaseOperation<TTable, TEntry>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadDatabaseOperation<TTable, TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F92 RID: 3986 RVA: 0x000427E4 File Offset: 0x000409E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078211, XrefRangeEnd = 1078214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PreloadDatabaseOperation<TTable, TEntry> __cctor_b__17_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadDatabaseOperation<TTable, TEntry>.__c.NativeMethodInfoPtr___cctor_b__17_0_Internal_PreloadDatabaseOperation_2_TTable_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PreloadDatabaseOperation<TTable, TEntry>>(intPtr3) : null;
			}

			// Token: 0x06000F93 RID: 3987 RVA: 0x000087A4 File Offset: 0x000069A4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700042B RID: 1067
			// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00042824 File Offset: 0x00040A24
			// (set) Token: 0x06000F95 RID: 3989 RVA: 0x000087AD File Offset: 0x000069AD
			public unsafe static PreloadDatabaseOperation<TTable, TEntry>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PreloadDatabaseOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PreloadDatabaseOperation<TTable, TEntry>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PreloadDatabaseOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AB2 RID: 2738
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000AB3 RID: 2739
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000AB4 RID: 2740
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__17_0_Internal_PreloadDatabaseOperation_2_TTable_TEntry_0;
		}
	}
}
