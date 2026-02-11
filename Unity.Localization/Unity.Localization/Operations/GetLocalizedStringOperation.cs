using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using UnityEngine.Localization.Tables;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	// Token: 0x020000B4 RID: 180
	public class GetLocalizedStringOperation : WaitForCurrentOperationAsyncOperationBase<string>
	{
		// Token: 0x06000926 RID: 2342 RVA: 0x0002C534 File Offset: 0x0002A734
		// Note: this type is marked as 'beforefieldinit'.
		static GetLocalizedStringOperation()
		{
			Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Operations", "GetLocalizedStringOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr);
			GetLocalizedStringOperation.NativeFieldInfoPtr_m_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, "m_Database");
			GetLocalizedStringOperation.NativeFieldInfoPtr_m_TableEntryOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, "m_TableEntryOperation");
			GetLocalizedStringOperation.NativeFieldInfoPtr_m_TableReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, "m_TableReference");
			GetLocalizedStringOperation.NativeFieldInfoPtr_m_TableEntryReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, "m_TableEntryReference");
			GetLocalizedStringOperation.NativeFieldInfoPtr_m_SelectedLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, "m_SelectedLocale");
			GetLocalizedStringOperation.NativeFieldInfoPtr_m_Arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, "m_Arguments");
			GetLocalizedStringOperation.NativeFieldInfoPtr_m_LocalVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, "m_LocalVariables");
			GetLocalizedStringOperation.NativeFieldInfoPtr_m_AutoRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, "m_AutoRelease");
			GetLocalizedStringOperation.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, "Pool");
			GetLocalizedStringOperation.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_Locale_LocalizedStringDatabase_TableReference_TableEntryReference_IList_1_Object_IVariableGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, 100664891);
			GetLocalizedStringOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, 100664892);
			GetLocalizedStringOperation.NativeMethodInfoPtr_CompleteAndRelease_Public_Void_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, 100664893);
			GetLocalizedStringOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, 100664894);
			GetLocalizedStringOperation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, 100664895);
			GetLocalizedStringOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, 100664896);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0002C690 File Offset: 0x0002A890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1077138, RefRangeEnd = 1077139, XrefRangeStart = 1077127, XrefRangeEnd = 1077138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult> tableEntryOperation, Locale locale, LocalizedStringDatabase database, TableReference tableReference, TableEntryReference tableEntryReference, IList<Object> arguments, IVariableGroup localVariables, bool autoRelease)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryOperation));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(database);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localVariables);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRelease;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetLocalizedStringOperation.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_Locale_LocalizedStringDatabase_TableReference_TableEntryReference_IList_1_Object_IVariableGroup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0002C760 File Offset: 0x0002A960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077139, XrefRangeEnd = 1077174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetLocalizedStringOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0002C79C File Offset: 0x0002A99C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1077190, RefRangeEnd = 1077192, XrefRangeStart = 1077174, XrefRangeEnd = 1077190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteAndRelease(string result, bool success, string errorMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetLocalizedStringOperation.NativeMethodInfoPtr_CompleteAndRelease_Public_Void_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0002C800 File Offset: 0x0002AA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077192, XrefRangeEnd = 1077203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetLocalizedStringOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0002C83C File Offset: 0x0002AA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077203, XrefRangeEnd = 1077224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetLocalizedStringOperation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0002C880 File Offset: 0x0002AA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077224, XrefRangeEnd = 1077227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetLocalizedStringOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetLocalizedStringOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0000583A File Offset: 0x00003A3A
		public GetLocalizedStringOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0002C8BC File Offset: 0x0002AABC
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x00005843 File Offset: 0x00003A43
		public unsafe LocalizedStringDatabase m_Database
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_Database);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedStringDatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0002C8EC File Offset: 0x0002AAEC
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x00005862 File Offset: 0x00003A62
		public AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult> m_TableEntryOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_TableEntryOperation);
				return new AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_TableEntryOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0002C91C File Offset: 0x0002AB1C
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x00005890 File Offset: 0x00003A90
		public TableReference m_TableReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_TableReference);
				return new TableReference(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TableReference>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_TableReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TableReference>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0002C94C File Offset: 0x0002AB4C
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x000058BE File Offset: 0x00003ABE
		public TableEntryReference m_TableEntryReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_TableEntryReference);
				return new TableEntryReference(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_TableEntryReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x0002C97C File Offset: 0x0002AB7C
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x000058EC File Offset: 0x00003AEC
		public unsafe Locale m_SelectedLocale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_SelectedLocale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_SelectedLocale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0002C9AC File Offset: 0x0002ABAC
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x0000590B File Offset: 0x00003B0B
		public unsafe IList<Object> m_Arguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_Arguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_Arguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0002C9DC File Offset: 0x0002ABDC
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x0000592A File Offset: 0x00003B2A
		public unsafe IVariableGroup m_LocalVariables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_LocalVariables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVariableGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_LocalVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0002CA0C File Offset: 0x0002AC0C
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x00005949 File Offset: 0x00003B49
		public unsafe bool m_AutoRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_AutoRelease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLocalizedStringOperation.NativeFieldInfoPtr_m_AutoRelease)) = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0002CA34 File Offset: 0x0002AC34
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x00005964 File Offset: 0x00003B64
		public unsafe static ObjectPool<GetLocalizedStringOperation> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GetLocalizedStringOperation.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<GetLocalizedStringOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetLocalizedStringOperation.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeFieldInfoPtr_m_Database;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeFieldInfoPtr_m_TableEntryOperation;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeFieldInfoPtr_m_TableReference;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeFieldInfoPtr_m_TableEntryReference;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedLocale;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeFieldInfoPtr_m_Arguments;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalVariables;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoRelease;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_TableEntryResult_StringTable_StringTableEntry_Locale_LocalizedStringDatabase_TableReference_TableEntryReference_IList_1_Object_IVariableGroup_Boolean_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAndRelease_Public_Void_String_Boolean_String_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000168 RID: 360
		[ObfuscatedName("UnityEngine.Localization.Operations.GetLocalizedStringOperation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F55 RID: 3925 RVA: 0x00041AE0 File Offset: 0x0003FCE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GetLocalizedStringOperation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetLocalizedStringOperation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetLocalizedStringOperation.__c>.NativeClassPtr);
				GetLocalizedStringOperation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLocalizedStringOperation.__c>.NativeClassPtr, "<>9");
				GetLocalizedStringOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLocalizedStringOperation.__c>.NativeClassPtr, 100664899);
				GetLocalizedStringOperation.__c.NativeMethodInfoPtr___cctor_b__15_0_Internal_GetLocalizedStringOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLocalizedStringOperation.__c>.NativeClassPtr, 100664900);
			}

			// Token: 0x06000F56 RID: 3926 RVA: 0x00041B48 File Offset: 0x0003FD48
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetLocalizedStringOperation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetLocalizedStringOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F57 RID: 3927 RVA: 0x00041B84 File Offset: 0x0003FD84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077121, XrefRangeEnd = 1077127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetLocalizedStringOperation __cctor_b__15_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetLocalizedStringOperation.__c.NativeMethodInfoPtr___cctor_b__15_0_Internal_GetLocalizedStringOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GetLocalizedStringOperation>(intPtr3) : null;
			}

			// Token: 0x06000F58 RID: 3928 RVA: 0x00008685 File Offset: 0x00006885
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000421 RID: 1057
			// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00041BC4 File Offset: 0x0003FDC4
			// (set) Token: 0x06000F5A RID: 3930 RVA: 0x0000868E File Offset: 0x0000688E
			public unsafe static GetLocalizedStringOperation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetLocalizedStringOperation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetLocalizedStringOperation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetLocalizedStringOperation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A93 RID: 2707
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000A94 RID: 2708
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A95 RID: 2709
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__15_0_Internal_GetLocalizedStringOperation_0;
		}
	}
}
