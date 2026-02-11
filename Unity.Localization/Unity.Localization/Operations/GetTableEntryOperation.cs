using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Metadata;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	// Token: 0x020000B5 RID: 181
	public class GetTableEntryOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<LocalizedDatabase<TTable, TEntry>.TableEntryResult> where TTable : DetailedLocalizationTable<TEntry> where TEntry : TableEntry
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x0002CA5C File Offset: 0x0002AC5C
		// Note: this type is marked as 'beforefieldinit'.
		static GetTableEntryOperation()
		{
			Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Operations", "GetTableEntryOperation`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr);
			GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_ExtractEntryFromTableAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "m_ExtractEntryFromTableAction");
			GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadTableOperation");
			GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "m_TableReference");
			GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableEntryReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "m_TableEntryReference");
			GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "m_Database");
			GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "m_SelectedLocale");
			GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CurrentLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "m_CurrentLocale");
			GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_HandledFallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "m_HandledFallbacks");
			GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_FallbackQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "m_FallbackQueue");
			GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_UseFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "m_UseFallback");
			GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_AutoRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "m_AutoRelease");
			GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "Pool");
			GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, 100664901);
			GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_AsyncOperationHandle_1_TTable_TableReference_TableEntryReference_Locale_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, 100664902);
			GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, 100664903);
			GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_ExtractEntryFromTable_Private_Void_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, 100664904);
			GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_HandleEntryOverride_Private_Boolean_AsyncOperationHandle_1_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, 100664905);
			GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_ApplyEntryOverride_Private_Boolean_IEntryOverride_AsyncOperationHandle_1_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, 100664906);
			GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_GetNextFallback_Private_Locale_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, 100664907);
			GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_HandleFallback_Private_Boolean_AsyncOperationHandle_1_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, 100664908);
			GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_CompleteAndRelease_Private_Void_TableEntryResult_TTable_TEntry_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, 100664909);
			GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, 100664910);
			GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, 100664911);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0002CCA8 File Offset: 0x0002AEA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1077256, RefRangeEnd = 1077257, XrefRangeStart = 1077230, XrefRangeEnd = 1077256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetTableEntryOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0002CCE4 File Offset: 0x0002AEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1077264, RefRangeEnd = 1077265, XrefRangeStart = 1077257, XrefRangeEnd = 1077264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(LocalizedDatabase<TTable, TEntry> database, AsyncOperationHandle<TTable> loadTableOperation, TableReference tableReference, TableEntryReference tableEntryReference, Locale selectedLoale, bool UseFallBack, bool autoRelease)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(database);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loadTableOperation));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectedLoale);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UseFallBack;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRelease;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_AsyncOperationHandle_1_TTable_TableReference_TableEntryReference_Locale_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0002CD9C File Offset: 0x0002AF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077265, XrefRangeEnd = 1077285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1077294, RefRangeEnd = 1077297, XrefRangeStart = 1077285, XrefRangeEnd = 1077294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExtractEntryFromTable(AsyncOperationHandle<TTable> asyncOperation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(asyncOperation));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_ExtractEntryFromTable_Private_Void_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0002CE20 File Offset: 0x0002B020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1077322, RefRangeEnd = 1077323, XrefRangeStart = 1077297, XrefRangeEnd = 1077322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntryOverride(AsyncOperationHandle<TTable> asyncOperation, TEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(asyncOperation));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_HandleEntryOverride_Private_Boolean_AsyncOperationHandle_1_TTable_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0002CEBC File Offset: 0x0002B0BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1077347, RefRangeEnd = 1077349, XrefRangeStart = 1077323, XrefRangeEnd = 1077347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ApplyEntryOverride(IEntryOverride entryOverride, AsyncOperationHandle<TTable> asyncOperation, TEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entryOverride);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(asyncOperation));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_ApplyEntryOverride_Private_Boolean_IEntryOverride_AsyncOperationHandle_1_TTable_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0002CF68 File Offset: 0x0002B168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1077401, RefRangeEnd = 1077402, XrefRangeStart = 1077349, XrefRangeEnd = 1077401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Locale GetNextFallback(Locale currentLocale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentLocale);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_GetNextFallback_Private_Locale_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0002CFB8 File Offset: 0x0002B1B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1077420, RefRangeEnd = 1077421, XrefRangeStart = 1077402, XrefRangeEnd = 1077420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleFallback(AsyncOperationHandle<TTable> asyncOperation, TEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(asyncOperation));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_HandleFallback_Private_Boolean_AsyncOperationHandle_1_TTable_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0002D054 File Offset: 0x0002B254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077421, XrefRangeEnd = 1077427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteAndRelease(LocalizedDatabase<TTable, TEntry>.TableEntryResult result, bool success, string errorMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_CompleteAndRelease_Private_Void_TableEntryResult_TTable_TEntry_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0002D0BC File Offset: 0x0002B2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077427, XrefRangeEnd = 1077448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0002D0F8 File Offset: 0x0002B2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077448, XrefRangeEnd = 1077476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetTableEntryOperation<TTable, TEntry>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00005976 File Offset: 0x00003B76
		public GetTableEntryOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0002D13C File Offset: 0x0002B33C
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x0000597F File Offset: 0x00003B7F
		public unsafe Action<AsyncOperationHandle<TTable>> m_ExtractEntryFromTableAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_ExtractEntryFromTableAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TTable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_ExtractEntryFromTableAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0002D16C File Offset: 0x0002B36C
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x0000599E File Offset: 0x00003B9E
		public AsyncOperationHandle<TTable> m_LoadTableOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableOperation);
				return new AsyncOperationHandle<TTable>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<TTable>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadTableOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<TTable>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0002D19C File Offset: 0x0002B39C
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x000059CC File Offset: 0x00003BCC
		public TableReference m_TableReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableReference);
				return new TableReference(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TableReference>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TableReference>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0002D1CC File Offset: 0x0002B3CC
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x000059FA File Offset: 0x00003BFA
		public TableEntryReference m_TableEntryReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableEntryReference);
				return new TableEntryReference(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_TableEntryReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0002D1FC File Offset: 0x0002B3FC
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x00005A28 File Offset: 0x00003C28
		public unsafe LocalizedDatabase<TTable, TEntry> m_Database
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedDatabase<TTable, TEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0002D22C File Offset: 0x0002B42C
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x00005A47 File Offset: 0x00003C47
		public unsafe Locale m_SelectedLocale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0002D25C File Offset: 0x0002B45C
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x00005A66 File Offset: 0x00003C66
		public unsafe Locale m_CurrentLocale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CurrentLocale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_CurrentLocale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0002D28C File Offset: 0x0002B48C
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x00005A85 File Offset: 0x00003C85
		public unsafe HashSet<Locale> m_HandledFallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_HandledFallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Locale>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_HandledFallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0002D2BC File Offset: 0x0002B4BC
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00005AA4 File Offset: 0x00003CA4
		public unsafe List<Locale> m_FallbackQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_FallbackQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Locale>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_FallbackQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0002D2EC File Offset: 0x0002B4EC
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00005AC3 File Offset: 0x00003CC3
		public unsafe bool m_UseFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_UseFallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_UseFallback)) = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0002D314 File Offset: 0x0002B514
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00005ADE File Offset: 0x00003CDE
		public unsafe bool m_AutoRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_AutoRelease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_m_AutoRelease)) = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0002D33C File Offset: 0x0002B53C
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x00005AF9 File Offset: 0x00003CF9
		public unsafe static ObjectPool<GetTableEntryOperation<TTable, TEntry>> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<GetTableEntryOperation<TTable, TEntry>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetTableEntryOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtractEntryFromTableAction;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadTableOperation;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeFieldInfoPtr_m_TableReference;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeFieldInfoPtr_m_TableEntryReference;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeFieldInfoPtr_m_Database;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedLocale;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentLocale;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_m_HandledFallbacks;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr_m_FallbackQueue;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_m_UseFallback;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoRelease;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_AsyncOperationHandle_1_TTable_TableReference_TableEntryReference_Locale_Boolean_Boolean_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_ExtractEntryFromTable_Private_Void_AsyncOperationHandle_1_TTable_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntryOverride_Private_Boolean_AsyncOperationHandle_1_TTable_TEntry_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEntryOverride_Private_Boolean_IEntryOverride_AsyncOperationHandle_1_TTable_TEntry_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_GetNextFallback_Private_Locale_Locale_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_HandleFallback_Private_Boolean_AsyncOperationHandle_1_TTable_TEntry_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAndRelease_Private_Void_TableEntryResult_TTable_TEntry_Boolean_String_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000169 RID: 361
		[ObfuscatedName("UnityEngine.Localization.Operations.GetTableEntryOperation`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F5B RID: 3931 RVA: 0x00041BEC File Offset: 0x0003FDEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>.__c>.NativeClassPtr);
				GetTableEntryOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>.__c>.NativeClassPtr, "<>9");
				GetTableEntryOperation<TTable, TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>.__c>.NativeClassPtr, 100664914);
				GetTableEntryOperation<TTable, TEntry>.__c.NativeMethodInfoPtr___cctor_b__23_0_Internal_GetTableEntryOperation_2_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>.__c>.NativeClassPtr, 100664915);
			}

			// Token: 0x06000F5C RID: 3932 RVA: 0x00041CA0 File Offset: 0x0003FEA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetTableEntryOperation<TTable, TEntry>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetTableEntryOperation<TTable, TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F5D RID: 3933 RVA: 0x00041CDC File Offset: 0x0003FEDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077227, XrefRangeEnd = 1077230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetTableEntryOperation<TTable, TEntry> __cctor_b__23_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetTableEntryOperation<TTable, TEntry>.__c.NativeMethodInfoPtr___cctor_b__23_0_Internal_GetTableEntryOperation_2_TTable_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GetTableEntryOperation<TTable, TEntry>>(intPtr3) : null;
			}

			// Token: 0x06000F5E RID: 3934 RVA: 0x000086A0 File Offset: 0x000068A0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000422 RID: 1058
			// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00041D1C File Offset: 0x0003FF1C
			// (set) Token: 0x06000F60 RID: 3936 RVA: 0x000086A9 File Offset: 0x000068A9
			public unsafe static GetTableEntryOperation<TTable, TEntry>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetTableEntryOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetTableEntryOperation<TTable, TEntry>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetTableEntryOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A96 RID: 2710
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000A97 RID: 2711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A98 RID: 2712
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__23_0_Internal_GetTableEntryOperation_2_TTable_TEntry_0;
		}
	}
}
