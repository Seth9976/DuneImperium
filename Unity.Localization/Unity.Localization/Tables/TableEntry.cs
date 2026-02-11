using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Localization.Metadata;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x02000022 RID: 34
	public class TableEntry : Object
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		// Note: this type is marked as 'beforefieldinit'.
		static TableEntry()
		{
			Il2CppClassPointerStore<TableEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "TableEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TableEntry>.NativeClassPtr);
			TableEntry.NativeFieldInfoPtr_m_SharedTableEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, "m_SharedTableEntry");
			TableEntry.NativeFieldInfoPtr__Table_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, "<Table>k__BackingField");
			TableEntry.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, "<Data>k__BackingField");
			TableEntry.NativeMethodInfoPtr_get_Table_Public_get_LocalizationTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663620);
			TableEntry.NativeMethodInfoPtr_set_Table_Internal_set_Void_LocalizationTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663621);
			TableEntry.NativeMethodInfoPtr_get_Data_Internal_get_TableEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663622);
			TableEntry.NativeMethodInfoPtr_set_Data_Internal_set_Void_TableEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663623);
			TableEntry.NativeMethodInfoPtr_get_SharedEntry_Public_get_SharedTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663624);
			TableEntry.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663625);
			TableEntry.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663626);
			TableEntry.NativeMethodInfoPtr_get_KeyId_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663627);
			TableEntry.NativeMethodInfoPtr_get_LocalizedValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663628);
			TableEntry.NativeMethodInfoPtr_get_MetadataEntries_Public_Virtual_Final_New_get_IList_1_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663629);
			TableEntry.NativeMethodInfoPtr_GetMetadata_Public_Virtual_Final_New_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663630);
			TableEntry.NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663631);
			TableEntry.NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663632);
			TableEntry.NativeMethodInfoPtr_HasTagMetadata_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663633);
			TableEntry.NativeMethodInfoPtr_AddTagMetadata_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663634);
			TableEntry.NativeMethodInfoPtr_AddSharedMetadata_Public_Void_SharedTableEntryMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663635);
			TableEntry.NativeMethodInfoPtr_AddSharedMetadata_Public_Void_SharedTableCollectionMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663636);
			TableEntry.NativeMethodInfoPtr_AddMetadata_Public_Virtual_Final_New_Void_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663637);
			TableEntry.NativeMethodInfoPtr_RemoveTagMetadata_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663638);
			TableEntry.NativeMethodInfoPtr_RemoveSharedMetadata_Public_Void_SharedTableEntryMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663639);
			TableEntry.NativeMethodInfoPtr_RemoveSharedMetadata_Public_Void_SharedTableCollectionMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663640);
			TableEntry.NativeMethodInfoPtr_RemoveMetadata_Public_Virtual_Final_New_Boolean_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663641);
			TableEntry.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663642);
			TableEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663643);
			TableEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntry>.NativeClassPtr, 100663644);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000FE18 File Offset: 0x0000E018
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0000FE58 File Offset: 0x0000E058
		public unsafe LocalizationTable Table
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_get_Table_Public_get_LocalizationTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizationTable>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_set_Table_Internal_set_Void_LocalizationTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000FE9C File Offset: 0x0000E09C
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x0000FEDC File Offset: 0x0000E0DC
		public unsafe TableEntryData Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_get_Data_Internal_get_TableEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TableEntryData>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_set_Data_Internal_set_Void_TableEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000FF20 File Offset: 0x0000E120
		public unsafe SharedTableData.SharedTableEntry SharedEntry
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1066900, RefRangeEnd = 1066902, XrefRangeStart = 1066898, XrefRangeEnd = 1066900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_get_SharedEntry_Public_get_SharedTableEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData.SharedTableEntry>(intPtr3) : null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000FF60 File Offset: 0x0000E160
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0000FF98 File Offset: 0x0000E198
		public unsafe string Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066902, XrefRangeEnd = 1066904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_get_Key_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066904, XrefRangeEnd = 1066906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000FFDC File Offset: 0x0000E1DC
		public unsafe long KeyId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 374430, RefRangeEnd = 374432, XrefRangeStart = 374430, XrefRangeEnd = 374432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_get_KeyId_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00010018 File Offset: 0x0000E218
		public unsafe string LocalizedValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 374429, RefRangeEnd = 374430, XrefRangeStart = 374429, XrefRangeEnd = 374430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_get_LocalizedValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00010050 File Offset: 0x0000E250
		public unsafe virtual IList<IMetadata> MetadataEntries
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1066906, RefRangeEnd = 1066908, XrefRangeStart = 1066906, XrefRangeEnd = 1066906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_get_MetadataEntries_Public_Virtual_Final_New_get_IList_1_IMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IMetadata>>(intPtr3) : null;
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00010090 File Offset: 0x0000E290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066908, XrefRangeEnd = 1066911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TObject GetMetadata<TObject>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.MethodInfoStoreGeneric_GetMetadata_Public_Virtual_Final_New_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000100CC File Offset: 0x0000E2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066911, XrefRangeEnd = 1066913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetMetadatas<TObject>(IList<TObject> foundItems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(foundItems);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.MethodInfoStoreGeneric_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00010110 File Offset: 0x0000E310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066913, XrefRangeEnd = 1066915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<TObject> GetMetadatas<TObject>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.MethodInfoStoreGeneric_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<TObject>>(intPtr3) : null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00010150 File Offset: 0x0000E350
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1066918, RefRangeEnd = 1066920, XrefRangeStart = 1066915, XrefRangeEnd = 1066918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasTagMetadata<TShared>() where TShared : SharedTableEntryMetadata
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.MethodInfoStoreGeneric_HasTagMetadata_Public_Boolean_0<TShared>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0001018C File Offset: 0x0000E38C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1066949, RefRangeEnd = 1066950, XrefRangeStart = 1066920, XrefRangeEnd = 1066949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTagMetadata<TShared>() where TShared : SharedTableEntryMetadata, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.MethodInfoStoreGeneric_AddTagMetadata_Public_Void_0<TShared>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000101C0 File Offset: 0x0000E3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066950, XrefRangeEnd = 1066955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSharedMetadata(SharedTableEntryMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_AddSharedMetadata_Public_Void_SharedTableEntryMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00010204 File Offset: 0x0000E404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066955, XrefRangeEnd = 1066959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSharedMetadata(SharedTableCollectionMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_AddSharedMetadata_Public_Void_SharedTableCollectionMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00010248 File Offset: 0x0000E448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1066961, RefRangeEnd = 1066962, XrefRangeStart = 1066959, XrefRangeEnd = 1066961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddMetadata(IMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_AddMetadata_Public_Virtual_Final_New_Void_IMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0001028C File Offset: 0x0000E48C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1066993, RefRangeEnd = 1066994, XrefRangeStart = 1066962, XrefRangeEnd = 1066993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTagMetadata<TShared>() where TShared : SharedTableEntryMetadata
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.MethodInfoStoreGeneric_RemoveTagMetadata_Public_Void_0<TShared>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066994, XrefRangeEnd = 1066999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSharedMetadata(SharedTableEntryMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_RemoveSharedMetadata_Public_Void_SharedTableEntryMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00010304 File Offset: 0x0000E504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066999, XrefRangeEnd = 1067002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSharedMetadata(SharedTableCollectionMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_RemoveSharedMetadata_Public_Void_SharedTableCollectionMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00010348 File Offset: 0x0000E548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067002, XrefRangeEnd = 1067004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool RemoveMetadata(IMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_RemoveMetadata_Public_Virtual_Final_New_Boolean_IMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00010398 File Offset: 0x0000E598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067004, XrefRangeEnd = 1067006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(IMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_IMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000103E8 File Offset: 0x0000E5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067006, XrefRangeEnd = 1067012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TableEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0001042C File Offset: 0x0000E62C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TableEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TableEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002B7D File Offset: 0x00000D7D
		public TableEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00010468 File Offset: 0x0000E668
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002B86 File Offset: 0x00000D86
		public unsafe SharedTableData.SharedTableEntry m_SharedTableEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntry.NativeFieldInfoPtr_m_SharedTableEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SharedTableData.SharedTableEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntry.NativeFieldInfoPtr_m_SharedTableEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00010498 File Offset: 0x0000E698
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002BA5 File Offset: 0x00000DA5
		public unsafe LocalizationTable _Table_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntry.NativeFieldInfoPtr__Table_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizationTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntry.NativeFieldInfoPtr__Table_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000104C8 File Offset: 0x0000E6C8
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002BC4 File Offset: 0x00000DC4
		public unsafe TableEntryData _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntry.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TableEntryData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntry.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_m_SharedTableEntry;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr__Table_k__BackingField;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_get_Table_Public_get_LocalizationTable_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_set_Table_Internal_set_Void_LocalizationTable_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Internal_get_TableEntryData_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Internal_set_Void_TableEntryData_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedEntry_Public_get_SharedTableEntry_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_String_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyId_Public_get_Int64_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalizedValue_Public_get_String_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataEntries_Public_Virtual_Final_New_get_IList_1_IMetadata_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadata_Public_Virtual_Final_New_TObject_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_HasTagMetadata_Public_Boolean_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_AddTagMetadata_Public_Void_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_AddSharedMetadata_Public_Void_SharedTableEntryMetadata_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_AddSharedMetadata_Public_Void_SharedTableCollectionMetadata_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_AddMetadata_Public_Virtual_Final_New_Void_IMetadata_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTagMetadata_Public_Void_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSharedMetadata_Public_Void_SharedTableEntryMetadata_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSharedMetadata_Public_Void_SharedTableCollectionMetadata_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMetadata_Public_Virtual_Final_New_Boolean_IMetadata_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_IMetadata_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200011E RID: 286
		private sealed class MethodInfoStoreGeneric_GetMetadata_Public_Virtual_Final_New_TObject_0<TObject>
		{
			// Token: 0x04000913 RID: 2323
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TableEntry.NativeMethodInfoPtr_GetMetadata_Public_Virtual_Final_New_TObject_0, Il2CppClassPointerStore<TableEntry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200011F RID: 287
		private sealed class MethodInfoStoreGeneric_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0<TObject>
		{
			// Token: 0x04000914 RID: 2324
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TableEntry.NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0, Il2CppClassPointerStore<TableEntry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000120 RID: 288
		private sealed class MethodInfoStoreGeneric_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0<TObject>
		{
			// Token: 0x04000915 RID: 2325
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TableEntry.NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0, Il2CppClassPointerStore<TableEntry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000121 RID: 289
		private sealed class MethodInfoStoreGeneric_HasTagMetadata_Public_Boolean_0<TShared>
		{
			// Token: 0x04000916 RID: 2326
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TableEntry.NativeMethodInfoPtr_HasTagMetadata_Public_Boolean_0, Il2CppClassPointerStore<TableEntry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TShared>.NativeClassPtr)) }))));
		}

		// Token: 0x02000122 RID: 290
		private sealed class MethodInfoStoreGeneric_AddTagMetadata_Public_Void_0<TShared>
		{
			// Token: 0x04000917 RID: 2327
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TableEntry.NativeMethodInfoPtr_AddTagMetadata_Public_Void_0, Il2CppClassPointerStore<TableEntry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TShared>.NativeClassPtr)) }))));
		}

		// Token: 0x02000123 RID: 291
		private sealed class MethodInfoStoreGeneric_RemoveTagMetadata_Public_Void_0<TShared>
		{
			// Token: 0x04000918 RID: 2328
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TableEntry.NativeMethodInfoPtr_RemoveTagMetadata_Public_Void_0, Il2CppClassPointerStore<TableEntry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TShared>.NativeClassPtr)) }))));
		}
	}
}
