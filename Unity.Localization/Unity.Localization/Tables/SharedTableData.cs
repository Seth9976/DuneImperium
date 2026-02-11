using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Metadata;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x02000029 RID: 41
	public class SharedTableData : ScriptableObject
	{
		// Token: 0x06000253 RID: 595 RVA: 0x00012314 File Offset: 0x00010514
		// Note: this type is marked as 'beforefieldinit'.
		static SharedTableData()
		{
			Il2CppClassPointerStore<SharedTableData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "SharedTableData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr);
			SharedTableData.NativeFieldInfoPtr_EmptyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, "EmptyId");
			SharedTableData.NativeFieldInfoPtr_NewEntryKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, "NewEntryKey");
			SharedTableData.NativeFieldInfoPtr_m_TableCollectionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, "m_TableCollectionName");
			SharedTableData.NativeFieldInfoPtr_m_TableCollectionNameGuidString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, "m_TableCollectionNameGuidString");
			SharedTableData.NativeFieldInfoPtr_m_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, "m_Entries");
			SharedTableData.NativeFieldInfoPtr_m_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, "m_Metadata");
			SharedTableData.NativeFieldInfoPtr_m_KeyGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, "m_KeyGenerator");
			SharedTableData.NativeFieldInfoPtr_m_TableCollectionNameGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, "m_TableCollectionNameGuid");
			SharedTableData.NativeFieldInfoPtr_m_IdDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, "m_IdDictionary");
			SharedTableData.NativeFieldInfoPtr_m_KeyDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, "m_KeyDictionary");
			SharedTableData.NativeMethodInfoPtr_get_Entries_Public_get_List_1_SharedTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663720);
			SharedTableData.NativeMethodInfoPtr_set_Entries_Public_set_Void_List_1_SharedTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663721);
			SharedTableData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663722);
			SharedTableData.NativeMethodInfoPtr_get_TableCollectionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663723);
			SharedTableData.NativeMethodInfoPtr_set_TableCollectionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663724);
			SharedTableData.NativeMethodInfoPtr_get_TableCollectionNameGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663725);
			SharedTableData.NativeMethodInfoPtr_set_TableCollectionNameGuid_Internal_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663726);
			SharedTableData.NativeMethodInfoPtr_get_Metadata_Public_get_MetadataCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663727);
			SharedTableData.NativeMethodInfoPtr_set_Metadata_Public_set_Void_MetadataCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663728);
			SharedTableData.NativeMethodInfoPtr_get_KeyGenerator_Public_get_IKeyGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663729);
			SharedTableData.NativeMethodInfoPtr_set_KeyGenerator_Public_set_Void_IKeyGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663730);
			SharedTableData.NativeMethodInfoPtr_GetKey_Public_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663731);
			SharedTableData.NativeMethodInfoPtr_GetId_Public_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663732);
			SharedTableData.NativeMethodInfoPtr_GetId_Public_Int64_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663733);
			SharedTableData.NativeMethodInfoPtr_GetEntryFromReference_Public_SharedTableEntry_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663734);
			SharedTableData.NativeMethodInfoPtr_GetEntry_Public_SharedTableEntry_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663735);
			SharedTableData.NativeMethodInfoPtr_GetEntry_Public_SharedTableEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663736);
			SharedTableData.NativeMethodInfoPtr_Contains_Public_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663737);
			SharedTableData.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663738);
			SharedTableData.NativeMethodInfoPtr_AddKey_Public_SharedTableEntry_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663739);
			SharedTableData.NativeMethodInfoPtr_AddKey_Public_SharedTableEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663740);
			SharedTableData.NativeMethodInfoPtr_RemoveKey_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663741);
			SharedTableData.NativeMethodInfoPtr_RemoveKey_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663742);
			SharedTableData.NativeMethodInfoPtr_RenameKey_Public_Void_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663743);
			SharedTableData.NativeMethodInfoPtr_RenameKey_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663744);
			SharedTableData.NativeMethodInfoPtr_RemapId_Public_Boolean_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663745);
			SharedTableData.NativeMethodInfoPtr_FindSimilarKey_Public_SharedTableEntry_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663746);
			SharedTableData.NativeMethodInfoPtr_ComputeLevenshteinDistance_Private_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663747);
			SharedTableData.NativeMethodInfoPtr_AddKeyInternal_Private_SharedTableEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663748);
			SharedTableData.NativeMethodInfoPtr_AddKeyInternal_Private_SharedTableEntry_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663749);
			SharedTableData.NativeMethodInfoPtr_RenameKeyInternal_Private_Void_SharedTableEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663750);
			SharedTableData.NativeMethodInfoPtr_RemoveKeyInternal_Private_Void_SharedTableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663751);
			SharedTableData.NativeMethodInfoPtr_FindWithId_Private_SharedTableEntry_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663752);
			SharedTableData.NativeMethodInfoPtr_FindWithKey_Private_SharedTableEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663753);
			SharedTableData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663754);
			SharedTableData.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663755);
			SharedTableData.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663756);
			SharedTableData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, 100663757);
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00012704 File Offset: 0x00010904
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00012744 File Offset: 0x00010944
		public unsafe List<SharedTableData.SharedTableEntry> Entries
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_get_Entries_Public_get_List_1_SharedTableEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SharedTableData.SharedTableEntry>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067363, XrefRangeEnd = 1067371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_set_Entries_Public_set_Void_List_1_SharedTableEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00012788 File Offset: 0x00010988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067371, XrefRangeEnd = 1067380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000127BC File Offset: 0x000109BC
		// (set) Token: 0x06000258 RID: 600 RVA: 0x000127F4 File Offset: 0x000109F4
		public unsafe string TableCollectionName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_get_TableCollectionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_set_TableCollectionName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00012838 File Offset: 0x00010A38
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00012874 File Offset: 0x00010A74
		public unsafe Guid TableCollectionNameGuid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_get_TableCollectionNameGuid_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_set_TableCollectionNameGuid_Internal_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600025B RID: 603 RVA: 0x000128B4 File Offset: 0x00010AB4
		// (set) Token: 0x0600025C RID: 604 RVA: 0x000128F4 File Offset: 0x00010AF4
		public unsafe MetadataCollection Metadata
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_get_Metadata_Public_get_MetadataCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MetadataCollection>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_set_Metadata_Public_set_Void_MetadataCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00012938 File Offset: 0x00010B38
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00012978 File Offset: 0x00010B78
		public unsafe IKeyGenerator KeyGenerator
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_get_KeyGenerator_Public_get_IKeyGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IKeyGenerator>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_set_KeyGenerator_Public_set_Void_IKeyGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000129BC File Offset: 0x00010BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067380, XrefRangeEnd = 1067381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetKey(long id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_GetKey_Public_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00012A00 File Offset: 0x00010C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067381, XrefRangeEnd = 1067382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetId(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_GetId_Public_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00012A50 File Offset: 0x00010C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067382, XrefRangeEnd = 1067384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetId(string key, bool addNewKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addNewKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_GetId_Public_Int64_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00012AAC File Offset: 0x00010CAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1067386, RefRangeEnd = 1067388, XrefRangeStart = 1067384, XrefRangeEnd = 1067386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableData.SharedTableEntry GetEntryFromReference(TableEntryReference tableEntryReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_GetEntryFromReference_Public_SharedTableEntry_TableEntryReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData.SharedTableEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00012B04 File Offset: 0x00010D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067388, XrefRangeEnd = 1067389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableData.SharedTableEntry GetEntry(long id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_GetEntry_Public_SharedTableEntry_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData.SharedTableEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00012B50 File Offset: 0x00010D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067389, XrefRangeEnd = 1067390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableData.SharedTableEntry GetEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_GetEntry_Public_SharedTableEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData.SharedTableEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00012BA0 File Offset: 0x00010DA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1067391, RefRangeEnd = 1067392, XrefRangeStart = 1067390, XrefRangeEnd = 1067391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(long id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_Contains_Public_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00012BEC File Offset: 0x00010DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067392, XrefRangeEnd = 1067393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00012C3C File Offset: 0x00010E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067393, XrefRangeEnd = 1067395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableData.SharedTableEntry AddKey(string key, long id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_AddKey_Public_SharedTableEntry_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData.SharedTableEntry>(intPtr3) : null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00012C9C File Offset: 0x00010E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1067407, RefRangeEnd = 1067408, XrefRangeStart = 1067395, XrefRangeEnd = 1067407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableData.SharedTableEntry AddKey(string key = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_AddKey_Public_SharedTableEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData.SharedTableEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00012CEC File Offset: 0x00010EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067408, XrefRangeEnd = 1067410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKey(long id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_RemoveKey_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00012D2C File Offset: 0x00010F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067410, XrefRangeEnd = 1067412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_RemoveKey_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00012D70 File Offset: 0x00010F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067412, XrefRangeEnd = 1067414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenameKey(long id, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_RenameKey_Public_Void_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00012DC0 File Offset: 0x00010FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067414, XrefRangeEnd = 1067416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenameKey(string oldValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_RenameKey_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00012E14 File Offset: 0x00011014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1067425, RefRangeEnd = 1067426, XrefRangeStart = 1067416, XrefRangeEnd = 1067425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemapId(long currentId, long newId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_RemapId_Public_Boolean_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00012E6C File Offset: 0x0001106C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067426, XrefRangeEnd = 1067443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableData.SharedTableEntry FindSimilarKey(string text, out int distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_FindSimilarKey_Public_SharedTableEntry_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData.SharedTableEntry>(intPtr3) : null;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00012ECC File Offset: 0x000110CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1067448, RefRangeEnd = 1067449, XrefRangeStart = 1067443, XrefRangeEnd = 1067448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ComputeLevenshteinDistance(string a, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_ComputeLevenshteinDistance_Private_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00012F20 File Offset: 0x00011120
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1067484, RefRangeEnd = 1067487, XrefRangeStart = 1067449, XrefRangeEnd = 1067484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableData.SharedTableEntry AddKeyInternal(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_AddKeyInternal_Private_SharedTableEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData.SharedTableEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00012F70 File Offset: 0x00011170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1067514, RefRangeEnd = 1067515, XrefRangeStart = 1067487, XrefRangeEnd = 1067514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableData.SharedTableEntry AddKeyInternal(string key, long id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_AddKeyInternal_Private_SharedTableEntry_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData.SharedTableEntry>(intPtr3) : null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00012FD0 File Offset: 0x000111D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1067526, RefRangeEnd = 1067529, XrefRangeStart = 1067515, XrefRangeEnd = 1067526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenameKeyInternal(SharedTableData.SharedTableEntry entry, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_RenameKeyInternal_Private_Void_SharedTableEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00013024 File Offset: 0x00011224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1067545, RefRangeEnd = 1067547, XrefRangeStart = 1067529, XrefRangeEnd = 1067545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKeyInternal(SharedTableData.SharedTableEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_RemoveKeyInternal_Private_Void_SharedTableEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00013068 File Offset: 0x00011268
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1067570, RefRangeEnd = 1067585, XrefRangeStart = 1067547, XrefRangeEnd = 1067570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableData.SharedTableEntry FindWithId(long id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_FindWithId_Private_SharedTableEntry_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData.SharedTableEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000130B4 File Offset: 0x000112B4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1067608, RefRangeEnd = 1067618, XrefRangeStart = 1067585, XrefRangeEnd = 1067608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableData.SharedTableEntry FindWithKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_FindWithKey_Private_SharedTableEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData.SharedTableEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00013104 File Offset: 0x00011304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067618, XrefRangeEnd = 1067621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SharedTableData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00013148 File Offset: 0x00011348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067621, XrefRangeEnd = 1067626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0001317C File Offset: 0x0001137C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067626, XrefRangeEnd = 1067635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000131B0 File Offset: 0x000113B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067635, XrefRangeEnd = 1067672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedTableData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002DBA File Offset: 0x00000FBA
		public SharedTableData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600027B RID: 635 RVA: 0x000131EC File Offset: 0x000113EC
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00002DC3 File Offset: 0x00000FC3
		public unsafe static long EmptyId
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(SharedTableData.NativeFieldInfoPtr_EmptyId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SharedTableData.NativeFieldInfoPtr_EmptyId, (void*)(&value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00013208 File Offset: 0x00011408
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00002DD1 File Offset: 0x00000FD1
		public unsafe static string NewEntryKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SharedTableData.NativeFieldInfoPtr_NewEntryKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SharedTableData.NativeFieldInfoPtr_NewEntryKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00013228 File Offset: 0x00011428
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00002DE3 File Offset: 0x00000FE3
		public unsafe string m_TableCollectionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_TableCollectionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_TableCollectionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00013250 File Offset: 0x00011450
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00002E02 File Offset: 0x00001002
		public unsafe string m_TableCollectionNameGuidString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_TableCollectionNameGuidString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_TableCollectionNameGuidString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00013278 File Offset: 0x00011478
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00002E21 File Offset: 0x00001021
		public unsafe List<SharedTableData.SharedTableEntry> m_Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SharedTableData.SharedTableEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000285 RID: 645 RVA: 0x000132A8 File Offset: 0x000114A8
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00002E40 File Offset: 0x00001040
		public unsafe MetadataCollection m_Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetadataCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000287 RID: 647 RVA: 0x000132D8 File Offset: 0x000114D8
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00002E5F File Offset: 0x0000105F
		public unsafe IKeyGenerator m_KeyGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_KeyGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IKeyGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_KeyGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00013308 File Offset: 0x00011508
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00002E7E File Offset: 0x0000107E
		public unsafe Guid m_TableCollectionNameGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_TableCollectionNameGuid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_TableCollectionNameGuid)) = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00013330 File Offset: 0x00011530
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00002E99 File Offset: 0x00001099
		public unsafe Dictionary<long, SharedTableData.SharedTableEntry> m_IdDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_IdDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<long, SharedTableData.SharedTableEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_IdDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00013360 File Offset: 0x00011560
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00002EB8 File Offset: 0x000010B8
		public unsafe Dictionary<string, SharedTableData.SharedTableEntry> m_KeyDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_KeyDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SharedTableData.SharedTableEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.NativeFieldInfoPtr_m_KeyDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_EmptyId;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_NewEntryKey;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_m_TableCollectionName;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_m_TableCollectionNameGuidString;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_m_Entries;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_m_Metadata;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyGenerator;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_m_TableCollectionNameGuid;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_m_IdDictionary;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyDictionary;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_get_Entries_Public_get_List_1_SharedTableEntry_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_set_Entries_Public_set_Void_List_1_SharedTableEntry_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_get_TableCollectionName_Public_get_String_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_set_TableCollectionName_Public_set_Void_String_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_get_TableCollectionNameGuid_Public_get_Guid_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_set_TableCollectionNameGuid_Internal_set_Void_Guid_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_get_Metadata_Public_get_MetadataCollection_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_set_Metadata_Public_set_Void_MetadataCollection_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyGenerator_Public_get_IKeyGenerator_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyGenerator_Public_set_Void_IKeyGenerator_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_String_Int64_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_GetId_Public_Int64_String_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_GetId_Public_Int64_String_Boolean_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_GetEntryFromReference_Public_SharedTableEntry_TableEntryReference_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_SharedTableEntry_Int64_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_SharedTableEntry_String_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Int64_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Public_SharedTableEntry_String_Int64_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Public_SharedTableEntry_String_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKey_Public_Void_Int64_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKey_Public_Void_String_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_RenameKey_Public_Void_Int64_String_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_RenameKey_Public_Void_String_String_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_RemapId_Public_Boolean_Int64_Int64_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_FindSimilarKey_Public_SharedTableEntry_String_byref_Int32_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_ComputeLevenshteinDistance_Private_Static_Int32_String_String_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyInternal_Private_SharedTableEntry_String_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyInternal_Private_SharedTableEntry_String_Int64_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_RenameKeyInternal_Private_Void_SharedTableEntry_String_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKeyInternal_Private_Void_SharedTableEntry_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_FindWithId_Private_SharedTableEntry_Int64_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_FindWithKey_Private_SharedTableEntry_String_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000128 RID: 296
		[Serializable]
		public class SharedTableEntry : Object
		{
			// Token: 0x06000D2B RID: 3371 RVA: 0x0003AA7C File Offset: 0x00038C7C
			// Note: this type is marked as 'beforefieldinit'.
			static SharedTableEntry()
			{
				Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SharedTableData>.NativeClassPtr, "SharedTableEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr);
				SharedTableData.SharedTableEntry.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr, "m_Id");
				SharedTableData.SharedTableEntry.NativeFieldInfoPtr_m_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr, "m_Key");
				SharedTableData.SharedTableEntry.NativeFieldInfoPtr_m_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr, "m_Metadata");
				SharedTableData.SharedTableEntry.NativeMethodInfoPtr_get_Id_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr, 100663758);
				SharedTableData.SharedTableEntry.NativeMethodInfoPtr_set_Id_Internal_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr, 100663759);
				SharedTableData.SharedTableEntry.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr, 100663760);
				SharedTableData.SharedTableEntry.NativeMethodInfoPtr_set_Key_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr, 100663761);
				SharedTableData.SharedTableEntry.NativeMethodInfoPtr_get_Metadata_Public_get_MetadataCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr, 100663762);
				SharedTableData.SharedTableEntry.NativeMethodInfoPtr_set_Metadata_Public_set_Void_MetadataCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr, 100663763);
				SharedTableData.SharedTableEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr, 100663764);
				SharedTableData.SharedTableEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr, 100663765);
			}

			// Token: 0x1700038F RID: 911
			// (get) Token: 0x06000D2C RID: 3372 RVA: 0x0003AB84 File Offset: 0x00038D84
			// (set) Token: 0x06000D2D RID: 3373 RVA: 0x0003ABC0 File Offset: 0x00038DC0
			public unsafe long Id
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.SharedTableEntry.NativeMethodInfoPtr_get_Id_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.SharedTableEntry.NativeMethodInfoPtr_set_Id_Internal_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000390 RID: 912
			// (get) Token: 0x06000D2E RID: 3374 RVA: 0x0003AC00 File Offset: 0x00038E00
			// (set) Token: 0x06000D2F RID: 3375 RVA: 0x0003AC38 File Offset: 0x00038E38
			public unsafe string Key
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.SharedTableEntry.NativeMethodInfoPtr_get_Key_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.SharedTableEntry.NativeMethodInfoPtr_set_Key_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000391 RID: 913
			// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0003AC7C File Offset: 0x00038E7C
			// (set) Token: 0x06000D31 RID: 3377 RVA: 0x0003ACBC File Offset: 0x00038EBC
			public unsafe MetadataCollection Metadata
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.SharedTableEntry.NativeMethodInfoPtr_get_Metadata_Public_get_MetadataCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MetadataCollection>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.SharedTableEntry.NativeMethodInfoPtr_set_Metadata_Public_set_Void_MetadataCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000D32 RID: 3378 RVA: 0x0003AD00 File Offset: 0x00038F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067351, XrefRangeEnd = 1067357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SharedTableData.SharedTableEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000D33 RID: 3379 RVA: 0x0003AD44 File Offset: 0x00038F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067357, XrefRangeEnd = 1067363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SharedTableEntry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedTableData.SharedTableEntry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedTableData.SharedTableEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D34 RID: 3380 RVA: 0x0000788F File Offset: 0x00005A8F
			public SharedTableEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700038C RID: 908
			// (get) Token: 0x06000D35 RID: 3381 RVA: 0x0003AD80 File Offset: 0x00038F80
			// (set) Token: 0x06000D36 RID: 3382 RVA: 0x00007898 File Offset: 0x00005A98
			public unsafe long m_Id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.SharedTableEntry.NativeFieldInfoPtr_m_Id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.SharedTableEntry.NativeFieldInfoPtr_m_Id)) = value;
				}
			}

			// Token: 0x1700038D RID: 909
			// (get) Token: 0x06000D37 RID: 3383 RVA: 0x0003ADA8 File Offset: 0x00038FA8
			// (set) Token: 0x06000D38 RID: 3384 RVA: 0x000078B3 File Offset: 0x00005AB3
			public unsafe string m_Key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.SharedTableEntry.NativeFieldInfoPtr_m_Key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.SharedTableEntry.NativeFieldInfoPtr_m_Key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700038E RID: 910
			// (get) Token: 0x06000D39 RID: 3385 RVA: 0x0003ADD0 File Offset: 0x00038FD0
			// (set) Token: 0x06000D3A RID: 3386 RVA: 0x000078D2 File Offset: 0x00005AD2
			public unsafe MetadataCollection m_Metadata
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.SharedTableEntry.NativeFieldInfoPtr_m_Metadata);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetadataCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedTableData.SharedTableEntry.NativeFieldInfoPtr_m_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000922 RID: 2338
			private static readonly IntPtr NativeFieldInfoPtr_m_Id;

			// Token: 0x04000923 RID: 2339
			private static readonly IntPtr NativeFieldInfoPtr_m_Key;

			// Token: 0x04000924 RID: 2340
			private static readonly IntPtr NativeFieldInfoPtr_m_Metadata;

			// Token: 0x04000925 RID: 2341
			private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int64_0;

			// Token: 0x04000926 RID: 2342
			private static readonly IntPtr NativeMethodInfoPtr_set_Id_Internal_set_Void_Int64_0;

			// Token: 0x04000927 RID: 2343
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;

			// Token: 0x04000928 RID: 2344
			private static readonly IntPtr NativeMethodInfoPtr_set_Key_Internal_set_Void_String_0;

			// Token: 0x04000929 RID: 2345
			private static readonly IntPtr NativeMethodInfoPtr_get_Metadata_Public_get_MetadataCollection_0;

			// Token: 0x0400092A RID: 2346
			private static readonly IntPtr NativeMethodInfoPtr_set_Metadata_Public_set_Void_MetadataCollection_0;

			// Token: 0x0400092B RID: 2347
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x0400092C RID: 2348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
