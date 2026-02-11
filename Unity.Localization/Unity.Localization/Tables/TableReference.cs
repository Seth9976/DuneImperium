using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x0200002D RID: 45
	[Serializable]
	public sealed class TableReference : ValueType
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x00013E64 File Offset: 0x00012064
		// Note: this type is marked as 'beforefieldinit'.
		static TableReference()
		{
			Il2CppClassPointerStore<TableReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "TableReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TableReference>.NativeClassPtr);
			TableReference.NativeFieldInfoPtr_s_GuidToStringCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableReference>.NativeClassPtr, "s_GuidToStringCache");
			TableReference.NativeFieldInfoPtr_s_StringToGuidCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableReference>.NativeClassPtr, "s_StringToGuidCache");
			TableReference.NativeFieldInfoPtr_m_TableCollectionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableReference>.NativeClassPtr, "m_TableCollectionName");
			TableReference.NativeFieldInfoPtr_m_Valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableReference>.NativeClassPtr, "m_Valid");
			TableReference.NativeFieldInfoPtr_k_GuidTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableReference>.NativeClassPtr, "k_GuidTag");
			TableReference.NativeFieldInfoPtr__ReferenceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableReference>.NativeClassPtr, "<ReferenceType>k__BackingField");
			TableReference.NativeFieldInfoPtr__TableCollectionNameGuid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableReference>.NativeClassPtr, "<TableCollectionNameGuid>k__BackingField");
			TableReference.NativeMethodInfoPtr_get_ReferenceType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663796);
			TableReference.NativeMethodInfoPtr_set_ReferenceType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663797);
			TableReference.NativeMethodInfoPtr_get_TableCollectionNameGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663798);
			TableReference.NativeMethodInfoPtr_set_TableCollectionNameGuid_Private_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663799);
			TableReference.NativeMethodInfoPtr_get_TableCollectionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663800);
			TableReference.NativeMethodInfoPtr_set_TableCollectionName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663801);
			TableReference.NativeMethodInfoPtr_get_SharedTableData_Internal_get_SharedTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663802);
			TableReference.NativeMethodInfoPtr_op_Implicit_Public_Static_TableReference_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663803);
			TableReference.NativeMethodInfoPtr_op_Implicit_Public_Static_TableReference_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663804);
			TableReference.NativeMethodInfoPtr_op_Implicit_Public_Static_String_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663805);
			TableReference.NativeMethodInfoPtr_op_Implicit_Public_Static_Guid_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663806);
			TableReference.NativeMethodInfoPtr_Validate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663807);
			TableReference.NativeMethodInfoPtr_GetSerializedString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663808);
			TableReference.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663809);
			TableReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663810);
			TableReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663811);
			TableReference.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663812);
			TableReference.NativeMethodInfoPtr_GuidFromString_Internal_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663813);
			TableReference.NativeMethodInfoPtr_StringFromGuid_Internal_Static_String_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663814);
			TableReference.NativeMethodInfoPtr_TableReferenceFromString_Internal_Static_TableReference_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663815);
			TableReference.NativeMethodInfoPtr_IsGuid_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663816);
			TableReference.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663817);
			TableReference.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableReference>.NativeClassPtr, 100663818);
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002BA RID: 698 RVA: 0x000140EC File Offset: 0x000122EC
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00014130 File Offset: 0x00012330
		public unsafe TableReference.Type ReferenceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_get_ReferenceType_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 310309, RefRangeEnd = 310312, XrefRangeStart = 310309, XrefRangeEnd = 310312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_set_ReferenceType_Private_set_Void_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00014174 File Offset: 0x00012374
		// (set) Token: 0x060002BD RID: 701 RVA: 0x000141B8 File Offset: 0x000123B8
		public unsafe Guid TableCollectionNameGuid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_get_TableCollectionNameGuid_Public_get_Guid_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_set_TableCollectionNameGuid_Private_set_Void_Guid_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000141FC File Offset: 0x000123FC
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00014238 File Offset: 0x00012438
		public unsafe string TableCollectionName
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1067930, RefRangeEnd = 1067938, XrefRangeStart = 1067926, XrefRangeEnd = 1067930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_get_TableCollectionName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_set_TableCollectionName_Private_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00014280 File Offset: 0x00012480
		public unsafe SharedTableData SharedTableData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1067987, RefRangeEnd = 1067988, XrefRangeStart = 1067938, XrefRangeEnd = 1067987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_get_SharedTableData_Internal_get_SharedTableData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SharedTableData>(intPtr3) : null;
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000142C4 File Offset: 0x000124C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1067995, RefRangeEnd = 1067997, XrefRangeStart = 1067988, XrefRangeEnd = 1067995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TableReference(string tableCollectionName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableCollectionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_op_Implicit_Public_Static_TableReference_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TableReference(intPtr);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00014300 File Offset: 0x00012500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067997, XrefRangeEnd = 1068005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator TableReference(Guid tableCollectionNameGuid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tableCollectionNameGuid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_op_Implicit_Public_Static_TableReference_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TableReference(intPtr);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00014338 File Offset: 0x00012538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1068009, RefRangeEnd = 1068010, XrefRangeStart = 1068005, XrefRangeEnd = 1068009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator string(TableReference tableReference)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_op_Implicit_Public_Static_String_TableReference_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0001437C File Offset: 0x0001257C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1068013, RefRangeEnd = 1068014, XrefRangeStart = 1068010, XrefRangeEnd = 1068013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Guid(TableReference tableReference)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_op_Implicit_Public_Static_Guid_TableReference_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000143C4 File Offset: 0x000125C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1068026, RefRangeEnd = 1068028, XrefRangeStart = 1068014, XrefRangeEnd = 1068026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_Validate_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000143FC File Offset: 0x000125FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1068041, RefRangeEnd = 1068042, XrefRangeStart = 1068028, XrefRangeEnd = 1068041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSerializedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_GetSerializedString_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00014438 File Offset: 0x00012638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068042, XrefRangeEnd = 1068055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00014474 File Offset: 0x00012674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068055, XrefRangeEnd = 1068061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000144C8 File Offset: 0x000126C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068061, XrefRangeEnd = 1068069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0001450C File Offset: 0x0001270C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1068077, RefRangeEnd = 1068082, XrefRangeStart = 1068069, XrefRangeEnd = 1068077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TableReference other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TableReference_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00014564 File Offset: 0x00012764
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1068096, RefRangeEnd = 1068098, XrefRangeStart = 1068082, XrefRangeEnd = 1068096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid GuidFromString(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_GuidFromString_Internal_Static_Guid_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000145A8 File Offset: 0x000127A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1068114, RefRangeEnd = 1068121, XrefRangeStart = 1068098, XrefRangeEnd = 1068114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StringFromGuid(Guid value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_StringFromGuid_Internal_Static_String_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000145E0 File Offset: 0x000127E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068121, XrefRangeEnd = 1068149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TableReference TableReferenceFromString(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_TableReferenceFromString_Internal_Static_TableReference_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TableReference(intPtr);
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0001461C File Offset: 0x0001281C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068149, XrefRangeEnd = 1068153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGuid(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_IsGuid_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00014660 File Offset: 0x00012860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068153, XrefRangeEnd = 1068158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00014698 File Offset: 0x00012898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068158, XrefRangeEnd = 1068169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableReference.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002F78 File Offset: 0x00001178
		public TableReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002F81 File Offset: 0x00001181
		public TableReference()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TableReference>.NativeClassPtr))
		{
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x000146D0 File Offset: 0x000128D0
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00002F93 File Offset: 0x00001193
		public unsafe static Dictionary<Guid, string> s_GuidToStringCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TableReference.NativeFieldInfoPtr_s_GuidToStringCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Guid, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TableReference.NativeFieldInfoPtr_s_GuidToStringCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x000146F8 File Offset: 0x000128F8
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00002FA5 File Offset: 0x000011A5
		public unsafe static Dictionary<string, Guid> s_StringToGuidCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TableReference.NativeFieldInfoPtr_s_StringToGuidCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Guid>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TableReference.NativeFieldInfoPtr_s_StringToGuidCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00014720 File Offset: 0x00012920
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00002FB7 File Offset: 0x000011B7
		public unsafe string m_TableCollectionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableReference.NativeFieldInfoPtr_m_TableCollectionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableReference.NativeFieldInfoPtr_m_TableCollectionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00014748 File Offset: 0x00012948
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00002FD6 File Offset: 0x000011D6
		public unsafe bool m_Valid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableReference.NativeFieldInfoPtr_m_Valid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableReference.NativeFieldInfoPtr_m_Valid)) = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00014770 File Offset: 0x00012970
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00002FF1 File Offset: 0x000011F1
		public unsafe static string k_GuidTag
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TableReference.NativeFieldInfoPtr_k_GuidTag, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TableReference.NativeFieldInfoPtr_k_GuidTag, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00014790 File Offset: 0x00012990
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00003003 File Offset: 0x00001203
		public unsafe TableReference.Type _ReferenceType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableReference.NativeFieldInfoPtr__ReferenceType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableReference.NativeFieldInfoPtr__ReferenceType_k__BackingField)) = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002DF RID: 735 RVA: 0x000147B8 File Offset: 0x000129B8
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x0000301E File Offset: 0x0000121E
		public unsafe Guid _TableCollectionNameGuid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableReference.NativeFieldInfoPtr__TableCollectionNameGuid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableReference.NativeFieldInfoPtr__TableCollectionNameGuid_k__BackingField)) = value;
			}
		}

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_s_GuidToStringCache;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_s_StringToGuidCache;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_m_TableCollectionName;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_m_Valid;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_k_GuidTag;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr__ReferenceType_k__BackingField;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr__TableCollectionNameGuid_k__BackingField;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceType_Public_get_Type_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_set_ReferenceType_Private_set_Void_Type_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_get_TableCollectionNameGuid_Public_get_Guid_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_set_TableCollectionNameGuid_Private_set_Void_Guid_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_get_TableCollectionName_Public_get_String_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_set_TableCollectionName_Private_set_Void_String_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedTableData_Internal_get_SharedTableData_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TableReference_String_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TableReference_Guid_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_TableReference_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Guid_TableReference_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Void_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializedString_Internal_String_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TableReference_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_GuidFromString_Internal_Static_Guid_String_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_StringFromGuid_Internal_Static_String_Guid_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_TableReferenceFromString_Internal_Static_TableReference_String_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_IsGuid_Internal_Static_Boolean_String_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0200012A RID: 298
		public enum Type
		{
			// Token: 0x04000932 RID: 2354
			Empty,
			// Token: 0x04000933 RID: 2355
			Guid,
			// Token: 0x04000934 RID: 2356
			Name
		}
	}
}
