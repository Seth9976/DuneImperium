using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization
{
	// Token: 0x02000016 RID: 22
	[Serializable]
	public class LocalizedTable<TTable, TEntry> : Object where TTable : DetailedLocalizationTable<TEntry> where TEntry : TableEntry
	{
		// Token: 0x0600012A RID: 298 RVA: 0x0000D878 File Offset: 0x0000BA78
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedTable()
		{
			Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedTable`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr);
			LocalizedTable<TTable, TEntry>.NativeFieldInfoPtr_m_TableReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, "m_TableReference");
			LocalizedTable<TTable, TEntry>.NativeFieldInfoPtr_m_ChangeHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, "m_ChangeHandler");
			LocalizedTable<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocaleChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, "m_SelectedLocaleChanged");
			LocalizedTable<TTable, TEntry>.NativeFieldInfoPtr__CurrentLoadingOperationHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, "<CurrentLoadingOperationHandle>k__BackingField");
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_get_Database_Protected_Abstract_Virtual_New_get_LocalizedDatabase_2_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663533);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_get_CurrentLoadingOperationHandle_Public_get_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663534);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_set_CurrentLoadingOperationHandle_Internal_set_Void_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663535);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_get_TableReference_Public_get_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663536);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_set_TableReference_Public_set_Void_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663537);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663538);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_add_TableChanged_Public_add_Void_ChangeHandler_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663539);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_remove_TableChanged_Public_rem_Void_ChangeHandler_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663540);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663541);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_GetTableAsync_Public_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663542);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_GetTable_Public_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663543);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_ForceUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663544);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_InvokeChangeHandler_Private_Void_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663545);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_HandleLocaleChange_Private_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663546);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_AutomaticLoadingCompleted_Private_Void_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663547);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_ClearLoadingOperation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663548);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663549);
			LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_get_CurrentLoadingOperation_Public_get_Nullable_1_AsyncOperationHandle_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, 100663550);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000DAB0 File Offset: 0x0000BCB0
		public unsafe virtual LocalizedDatabase<TTable, TEntry> Database
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_get_Database_Protected_Abstract_Virtual_New_get_LocalizedDatabase_2_TTable_TEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedDatabase<TTable, TEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0000DB34 File Offset: 0x0000BD34
		public unsafe AsyncOperationHandle<TTable> CurrentLoadingOperationHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_get_CurrentLoadingOperationHandle_Public_get_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TTable>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066255, XrefRangeEnd = 1066256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_set_CurrentLoadingOperationHandle_Internal_set_Void_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0000DB7C File Offset: 0x0000BD7C
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0000DBB4 File Offset: 0x0000BDB4
		public unsafe TableReference TableReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_get_TableReference_Public_get_TableReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TableReference(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1066262, RefRangeEnd = 1066264, XrefRangeStart = 1066256, XrefRangeEnd = 1066262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_set_TableReference_Public_set_Void_TableReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000DBFC File Offset: 0x0000BDFC
		public unsafe bool IsEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066264, XrefRangeEnd = 1066267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000DC38 File Offset: 0x0000BE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066267, XrefRangeEnd = 1066272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_TableChanged(LocalizedTable<TTable, TEntry>.ChangeHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_add_TableChanged_Public_add_Void_ChangeHandler_TTable_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000DC7C File Offset: 0x0000BE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066272, XrefRangeEnd = 1066275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_TableChanged(LocalizedTable<TTable, TEntry>.ChangeHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_remove_TableChanged_Public_rem_Void_ChangeHandler_TTable_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000DCC0 File Offset: 0x0000BEC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1066281, RefRangeEnd = 1066285, XrefRangeStart = 1066275, XrefRangeEnd = 1066281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000DCFC File Offset: 0x0000BEFC
		[CallerCount(0)]
		public unsafe AsyncOperationHandle<TTable> GetTableAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_GetTableAsync_Public_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TTable>(intPtr);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000DD34 File Offset: 0x0000BF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066285, XrefRangeEnd = 1066286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TTable GetTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_GetTable_Public_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TTable>(intPtr, false, true);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000DD70 File Offset: 0x0000BF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066286, XrefRangeEnd = 1066287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_ForceUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000DDA4 File Offset: 0x0000BFA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1066298, RefRangeEnd = 1066299, XrefRangeStart = 1066287, XrefRangeEnd = 1066298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeChangeHandler(TTable value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TTable).IsValueType)
				{
					TTable ttable = value;
					intPtr = ((ttable is string) ? IL2CPP.ManagedStringToIl2Cpp(ttable as string) : IL2CPP.Il2CppObjectBaseToPtr(ttable as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_InvokeChangeHandler_Private_Void_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000DE1C File Offset: 0x0000C01C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1066309, RefRangeEnd = 1066311, XrefRangeStart = 1066299, XrefRangeEnd = 1066309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleLocaleChange(Locale _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_HandleLocaleChange_Private_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000DE60 File Offset: 0x0000C060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066311, XrefRangeEnd = 1066314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutomaticLoadingCompleted(AsyncOperationHandle<TTable> loadOperation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loadOperation));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_AutomaticLoadingCompleted_Private_Void_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066314, XrefRangeEnd = 1066321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLoadingOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_ClearLoadingOperation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000DEDC File Offset: 0x0000C0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066321, XrefRangeEnd = 1066325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000DF20 File Offset: 0x0000C120
		public unsafe Nullable<AsyncOperationHandle<TTable>> CurrentLoadingOperation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066325, XrefRangeEnd = 1066328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.NativeMethodInfoPtr_get_CurrentLoadingOperation_Public_get_Nullable_1_AsyncOperationHandle_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<AsyncOperationHandle<TTable>>(intPtr);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000027C7 File Offset: 0x000009C7
		public LocalizedTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000DF58 File Offset: 0x0000C158
		// (set) Token: 0x0600013F RID: 319 RVA: 0x000027D0 File Offset: 0x000009D0
		public TableReference m_TableReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedTable<TTable, TEntry>.NativeFieldInfoPtr_m_TableReference);
				return new TableReference(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TableReference>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedTable<TTable, TEntry>.NativeFieldInfoPtr_m_TableReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TableReference>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000DF88 File Offset: 0x0000C188
		// (set) Token: 0x06000141 RID: 321 RVA: 0x000027FE File Offset: 0x000009FE
		public CallbackArray<LocalizedTable<TTable, TEntry>.ChangeHandler> m_ChangeHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedTable<TTable, TEntry>.NativeFieldInfoPtr_m_ChangeHandler);
				return new CallbackArray<LocalizedTable<TTable, TEntry>.ChangeHandler>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallbackArray<LocalizedTable<TTable, TEntry>.ChangeHandler>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedTable<TTable, TEntry>.NativeFieldInfoPtr_m_ChangeHandler), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallbackArray<LocalizedTable<TTable, TEntry>.ChangeHandler>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0000282C File Offset: 0x00000A2C
		public unsafe Action<Locale> m_SelectedLocaleChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedTable<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocaleChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Locale>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedTable<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocaleChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000DFE8 File Offset: 0x0000C1E8
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0000284B File Offset: 0x00000A4B
		public AsyncOperationHandle<TTable> _CurrentLoadingOperationHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedTable<TTable, TEntry>.NativeFieldInfoPtr__CurrentLoadingOperationHandle_k__BackingField);
				return new AsyncOperationHandle<TTable>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<TTable>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedTable<TTable, TEntry>.NativeFieldInfoPtr__CurrentLoadingOperationHandle_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<TTable>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_m_TableReference;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_m_ChangeHandler;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedLocaleChanged;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLoadingOperationHandle_k__BackingField;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_Database_Protected_Abstract_Virtual_New_get_LocalizedDatabase_2_TTable_TEntry_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLoadingOperationHandle_Public_get_AsyncOperationHandle_1_TTable_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLoadingOperationHandle_Internal_set_Void_AsyncOperationHandle_1_TTable_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_get_TableReference_Public_get_TableReference_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_set_TableReference_Public_set_Void_TableReference_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_add_TableChanged_Public_add_Void_ChangeHandler_TTable_TEntry_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_remove_TableChanged_Public_rem_Void_ChangeHandler_TTable_TEntry_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_GetTableAsync_Public_AsyncOperationHandle_1_TTable_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_GetTable_Public_TTable_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdate_Protected_Void_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_InvokeChangeHandler_Private_Void_TTable_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_HandleLocaleChange_Private_Void_Locale_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_AutomaticLoadingCompleted_Private_Void_AsyncOperationHandle_1_TTable_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_ClearLoadingOperation_Private_Void_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLoadingOperation_Public_get_Nullable_1_AsyncOperationHandle_1_TTable_0;

		// Token: 0x02000119 RID: 281
		public sealed class ChangeHandler : MulticastDelegate
		{
			// Token: 0x06000D04 RID: 3332 RVA: 0x0003A070 File Offset: 0x00038270
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeHandler()
			{
				Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>.ChangeHandler>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>>.NativeClassPtr, "ChangeHandler"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
				})).TypeHandle.value);
				LocalizedTable<TTable, TEntry>.ChangeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>.ChangeHandler>.NativeClassPtr, 100663551);
				LocalizedTable<TTable, TEntry>.ChangeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>.ChangeHandler>.NativeClassPtr, 100663552);
				LocalizedTable<TTable, TEntry>.ChangeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TTable_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>.ChangeHandler>.NativeClassPtr, 100663553);
				LocalizedTable<TTable, TEntry>.ChangeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>.ChangeHandler>.NativeClassPtr, 100663554);
			}

			// Token: 0x06000D05 RID: 3333 RVA: 0x0003A130 File Offset: 0x00038330
			[CallerCount(144)]
			[CachedScanResults(RefRangeStart = 387041, RefRangeEnd = 387185, XrefRangeStart = 387041, XrefRangeEnd = 387185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedTable<TTable, TEntry>.ChangeHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.ChangeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D06 RID: 3334 RVA: 0x0003A18C File Offset: 0x0003838C
			[CallerCount(0)]
			public unsafe void Invoke(TTable value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TTable).IsValueType)
					{
						TTable ttable = value;
						intPtr = ((ttable is string) ? IL2CPP.ManagedStringToIl2Cpp(ttable as string) : IL2CPP.Il2CppObjectBaseToPtr(ttable as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.ChangeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06000D07 RID: 3335 RVA: 0x0003A204 File Offset: 0x00038404
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(TTable value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TTable).IsValueType)
					{
						TTable ttable = value;
						intPtr = ((ttable is string) ? IL2CPP.ManagedStringToIl2Cpp(ttable as string) : IL2CPP.Il2CppObjectBaseToPtr(ttable as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.ChangeHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TTable_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x06000D08 RID: 3336 RVA: 0x0003A2B0 File Offset: 0x000384B0
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTable<TTable, TEntry>.ChangeHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D09 RID: 3337 RVA: 0x00007805 File Offset: 0x00005A05
			public ChangeHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000D0A RID: 3338 RVA: 0x0000780E File Offset: 0x00005A0E
			public static implicit operator LocalizedTable<TTable, TEntry>.ChangeHandler(Action<TTable> A_0)
			{
				return DelegateSupport.ConvertDelegate<LocalizedTable<TTable, TEntry>.ChangeHandler>(A_0);
			}

			// Token: 0x06000D0B RID: 3339 RVA: 0x00007816 File Offset: 0x00005A16
			public static LocalizedTable<TTable, TEntry>.ChangeHandler operator +(LocalizedTable<TTable, TEntry>.ChangeHandler A_0, LocalizedTable<TTable, TEntry>.ChangeHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LocalizedTable<TTable, TEntry>.ChangeHandler>();
			}

			// Token: 0x06000D0C RID: 3340 RVA: 0x00007824 File Offset: 0x00005A24
			public static LocalizedTable<TTable, TEntry>.ChangeHandler operator -(LocalizedTable<TTable, TEntry>.ChangeHandler A_0, LocalizedTable<TTable, TEntry>.ChangeHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LocalizedTable<TTable, TEntry>.ChangeHandler>();
				}
				return delegate2;
			}

			// Token: 0x04000908 RID: 2312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000909 RID: 2313
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TTable_0;

			// Token: 0x0400090A RID: 2314
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TTable_AsyncCallback_Object_0;

			// Token: 0x0400090B RID: 2315
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
