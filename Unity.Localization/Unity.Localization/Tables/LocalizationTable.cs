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
	// Token: 0x02000028 RID: 40
	public class LocalizationTable : ScriptableObject
	{
		// Token: 0x06000236 RID: 566 RVA: 0x00011B44 File Offset: 0x0000FD44
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizationTable()
		{
			Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "LocalizationTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr);
			LocalizationTable.NativeFieldInfoPtr_m_LocaleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, "m_LocaleId");
			LocalizationTable.NativeFieldInfoPtr_m_SharedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, "m_SharedData");
			LocalizationTable.NativeFieldInfoPtr_m_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, "m_Metadata");
			LocalizationTable.NativeFieldInfoPtr_m_TableData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, "m_TableData");
			LocalizationTable.NativeMethodInfoPtr_get_LocaleIdentifier_Public_get_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663701);
			LocalizationTable.NativeMethodInfoPtr_set_LocaleIdentifier_Public_set_Void_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663702);
			LocalizationTable.NativeMethodInfoPtr_get_TableCollectionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663703);
			LocalizationTable.NativeMethodInfoPtr_get_SharedData_Public_get_SharedTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663704);
			LocalizationTable.NativeMethodInfoPtr_set_SharedData_Public_set_Void_SharedTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663705);
			LocalizationTable.NativeMethodInfoPtr_get_TableData_Internal_get_List_1_TableEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663706);
			LocalizationTable.NativeMethodInfoPtr_get_MetadataEntries_Public_Virtual_Final_New_get_IList_1_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663707);
			LocalizationTable.NativeMethodInfoPtr_GetMetadata_Public_Virtual_Final_New_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663708);
			LocalizationTable.NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663709);
			LocalizationTable.NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663710);
			LocalizationTable.NativeMethodInfoPtr_AddMetadata_Public_Virtual_Final_New_Void_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663711);
			LocalizationTable.NativeMethodInfoPtr_RemoveMetadata_Public_Virtual_Final_New_Boolean_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663712);
			LocalizationTable.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_IMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663713);
			LocalizationTable.NativeMethodInfoPtr_CreateEmpty_Public_Abstract_Virtual_New_Void_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663714);
			LocalizationTable.NativeMethodInfoPtr_FindKeyId_Protected_Int64_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663715);
			LocalizationTable.NativeMethodInfoPtr_VerifySharedTableDataIsNotNull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663716);
			LocalizationTable.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663717);
			LocalizationTable.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_LocalizationTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663718);
			LocalizationTable.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr, 100663719);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00011D40 File Offset: 0x0000FF40
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00011D78 File Offset: 0x0000FF78
		public unsafe LocaleIdentifier LocaleIdentifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_get_LocaleIdentifier_Public_get_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LocaleIdentifier(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_set_LocaleIdentifier_Public_set_Void_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		public unsafe string TableCollectionName
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1067282, RefRangeEnd = 1067288, XrefRangeStart = 1067281, XrefRangeEnd = 1067282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_get_TableCollectionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00011DF8 File Offset: 0x0000FFF8
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00011E38 File Offset: 0x00010038
		public unsafe SharedTableData SharedData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_get_SharedData_Public_get_SharedTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_set_SharedData_Public_set_Void_SharedTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00011E7C File Offset: 0x0001007C
		public unsafe List<TableEntryData> TableData
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_get_TableData_Internal_get_List_1_TableEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TableEntryData>>(intPtr3) : null;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00011EBC File Offset: 0x000100BC
		public unsafe virtual IList<IMetadata> MetadataEntries
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 372752, RefRangeEnd = 372755, XrefRangeStart = 372752, XrefRangeEnd = 372755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_get_MetadataEntries_Public_Virtual_Final_New_get_IList_1_IMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IMetadata>>(intPtr3) : null;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00011EFC File Offset: 0x000100FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1067291, RefRangeEnd = 1067293, XrefRangeStart = 1067288, XrefRangeEnd = 1067291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TObject GetMetadata<TObject>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.MethodInfoStoreGeneric_GetMetadata_Public_Virtual_Final_New_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00011F38 File Offset: 0x00010138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067293, XrefRangeEnd = 1067295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetMetadatas<TObject>(IList<TObject> foundItems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(foundItems);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.MethodInfoStoreGeneric_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00011F7C File Offset: 0x0001017C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067295, XrefRangeEnd = 1067297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<TObject> GetMetadatas<TObject>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.MethodInfoStoreGeneric_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<TObject>>(intPtr3) : null;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00011FBC File Offset: 0x000101BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1067299, RefRangeEnd = 1067300, XrefRangeStart = 1067297, XrefRangeEnd = 1067299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddMetadata(IMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_AddMetadata_Public_Virtual_Final_New_Void_IMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00012000 File Offset: 0x00010200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067300, XrefRangeEnd = 1067302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool RemoveMetadata(IMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_RemoveMetadata_Public_Virtual_Final_New_Boolean_IMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00012050 File Offset: 0x00010250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067302, XrefRangeEnd = 1067304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(IMetadata md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_IMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000120A0 File Offset: 0x000102A0
		[CallerCount(0)]
		public unsafe virtual void CreateEmpty(TableEntryReference entryReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entryReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationTable.NativeMethodInfoPtr_CreateEmpty_Public_Abstract_Virtual_New_Void_TableEntryReference_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000120F4 File Offset: 0x000102F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1067307, RefRangeEnd = 1067314, XrefRangeStart = 1067304, XrefRangeEnd = 1067307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long FindKeyId(string key, bool addKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_FindKeyId_Protected_Int64_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00012150 File Offset: 0x00010350
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1067318, RefRangeEnd = 1067321, XrefRangeStart = 1067314, XrefRangeEnd = 1067318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifySharedTableDataIsNotNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_VerifySharedTableDataIsNotNull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00012184 File Offset: 0x00010384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067321, XrefRangeEnd = 1067328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizationTable.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000121C8 File Offset: 0x000103C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067328, XrefRangeEnd = 1067337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(LocalizationTable other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_LocalizationTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00012218 File Offset: 0x00010418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1067350, RefRangeEnd = 1067351, XrefRangeStart = 1067337, XrefRangeEnd = 1067350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizationTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationTable.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002D26 File Offset: 0x00000F26
		public LocalizationTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00012254 File Offset: 0x00010454
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002D2F File Offset: 0x00000F2F
		public LocaleIdentifier m_LocaleId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationTable.NativeFieldInfoPtr_m_LocaleId);
				return new LocaleIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationTable.NativeFieldInfoPtr_m_LocaleId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00012284 File Offset: 0x00010484
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00002D5D File Offset: 0x00000F5D
		public unsafe SharedTableData m_SharedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationTable.NativeFieldInfoPtr_m_SharedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SharedTableData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationTable.NativeFieldInfoPtr_m_SharedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000122B4 File Offset: 0x000104B4
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00002D7C File Offset: 0x00000F7C
		public unsafe MetadataCollection m_Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationTable.NativeFieldInfoPtr_m_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetadataCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationTable.NativeFieldInfoPtr_m_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000122E4 File Offset: 0x000104E4
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002D9B File Offset: 0x00000F9B
		public unsafe List<TableEntryData> m_TableData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationTable.NativeFieldInfoPtr_m_TableData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TableEntryData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationTable.NativeFieldInfoPtr_m_TableData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr_m_LocaleId;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeFieldInfoPtr_m_SharedData;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_m_Metadata;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_m_TableData;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_get_LocaleIdentifier_Public_get_LocaleIdentifier_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_set_LocaleIdentifier_Public_set_Void_LocaleIdentifier_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_get_TableCollectionName_Public_get_String_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedData_Public_get_SharedTableData_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedData_Public_set_Void_SharedTableData_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_get_TableData_Internal_get_List_1_TableEntryData_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataEntries_Public_Virtual_Final_New_get_IList_1_IMetadata_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadata_Public_Virtual_Final_New_TObject_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_AddMetadata_Public_Virtual_Final_New_Void_IMetadata_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMetadata_Public_Virtual_Final_New_Boolean_IMetadata_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_IMetadata_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_CreateEmpty_Public_Abstract_Virtual_New_Void_TableEntryReference_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_FindKeyId_Protected_Int64_String_Boolean_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_VerifySharedTableDataIsNotNull_Private_Void_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_LocalizationTable_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000125 RID: 293
		private sealed class MethodInfoStoreGeneric_GetMetadata_Public_Virtual_Final_New_TObject_0<TObject>
		{
			// Token: 0x0400091F RID: 2335
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LocalizationTable.NativeMethodInfoPtr_GetMetadata_Public_Virtual_Final_New_TObject_0, Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000126 RID: 294
		private sealed class MethodInfoStoreGeneric_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0<TObject>
		{
			// Token: 0x04000920 RID: 2336
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LocalizationTable.NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_Void_IList_1_TObject_0, Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000127 RID: 295
		private sealed class MethodInfoStoreGeneric_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0<TObject>
		{
			// Token: 0x04000921 RID: 2337
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LocalizationTable.NativeMethodInfoPtr_GetMetadatas_Public_Virtual_Final_New_IList_1_TObject_0, Il2CppClassPointerStore<LocalizationTable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}
	}
}
