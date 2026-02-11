using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x0200002E RID: 46
	[Serializable]
	public sealed class TableEntryReference : ValueType
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x000147E0 File Offset: 0x000129E0
		// Note: this type is marked as 'beforefieldinit'.
		static TableEntryReference()
		{
			Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "TableEntryReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr);
			TableEntryReference.NativeFieldInfoPtr_m_KeyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, "m_KeyId");
			TableEntryReference.NativeFieldInfoPtr_m_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, "m_Key");
			TableEntryReference.NativeFieldInfoPtr_m_Valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, "m_Valid");
			TableEntryReference.NativeFieldInfoPtr__ReferenceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, "<ReferenceType>k__BackingField");
			TableEntryReference.NativeMethodInfoPtr_get_ReferenceType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663820);
			TableEntryReference.NativeMethodInfoPtr_set_ReferenceType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663821);
			TableEntryReference.NativeMethodInfoPtr_get_KeyId_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663822);
			TableEntryReference.NativeMethodInfoPtr_set_KeyId_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663823);
			TableEntryReference.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663824);
			TableEntryReference.NativeMethodInfoPtr_set_Key_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663825);
			TableEntryReference.NativeMethodInfoPtr_op_Implicit_Public_Static_TableEntryReference_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663826);
			TableEntryReference.NativeMethodInfoPtr_op_Implicit_Public_Static_TableEntryReference_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663827);
			TableEntryReference.NativeMethodInfoPtr_op_Implicit_Public_Static_String_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663828);
			TableEntryReference.NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663829);
			TableEntryReference.NativeMethodInfoPtr_Validate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663830);
			TableEntryReference.NativeMethodInfoPtr_ResolveKeyName_Public_String_SharedTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663831);
			TableEntryReference.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663832);
			TableEntryReference.NativeMethodInfoPtr_ToString_Public_String_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663833);
			TableEntryReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663834);
			TableEntryReference.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663835);
			TableEntryReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663836);
			TableEntryReference.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663837);
			TableEntryReference.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, 100663838);
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x000149DC File Offset: 0x00012BDC
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00014A20 File Offset: 0x00012C20
		public unsafe TableEntryReference.Type ReferenceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_get_ReferenceType_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_set_ReferenceType_Private_set_Void_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00014A64 File Offset: 0x00012C64
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00014AA8 File Offset: 0x00012CA8
		public unsafe long KeyId
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_get_KeyId_Public_get_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_set_KeyId_Private_set_Void_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00014AEC File Offset: 0x00012CEC
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00014B28 File Offset: 0x00012D28
		public unsafe string Key
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_get_Key_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_set_Key_Private_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00014B70 File Offset: 0x00012D70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1068170, RefRangeEnd = 1068172, XrefRangeStart = 1068169, XrefRangeEnd = 1068170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator TableEntryReference(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_op_Implicit_Public_Static_TableEntryReference_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TableEntryReference(intPtr);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00014BAC File Offset: 0x00012DAC
		[CallerCount(0)]
		public new unsafe static implicit operator TableEntryReference(long keyId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_op_Implicit_Public_Static_TableEntryReference_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TableEntryReference(intPtr);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00014BE4 File Offset: 0x00012DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator string(TableEntryReference tableEntryReference)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_op_Implicit_Public_Static_String_TableEntryReference_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00014C28 File Offset: 0x00012E28
		[CallerCount(99)]
		[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator long(TableEntryReference tableEntryReference)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_TableEntryReference_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00014C70 File Offset: 0x00012E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068172, XrefRangeEnd = 1068174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_Validate_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00014CA8 File Offset: 0x00012EA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1068181, RefRangeEnd = 1068183, XrefRangeStart = 1068174, XrefRangeEnd = 1068181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ResolveKeyName(SharedTableData sharedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sharedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_ResolveKeyName_Public_String_SharedTableData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00014CF8 File Offset: 0x00012EF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1068197, RefRangeEnd = 1068199, XrefRangeStart = 1068183, XrefRangeEnd = 1068197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00014D34 File Offset: 0x00012F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1068222, RefRangeEnd = 1068223, XrefRangeStart = 1068199, XrefRangeEnd = 1068222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(TableReference tableReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_ToString_Public_String_TableReference_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00014D88 File Offset: 0x00012F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068223, XrefRangeEnd = 1068226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00014DDC File Offset: 0x00012FDC
		[CallerCount(0)]
		public unsafe bool Equals(TableEntryReference other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TableEntryReference_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00014E34 File Offset: 0x00013034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068226, XrefRangeEnd = 1068230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00014E78 File Offset: 0x00013078
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00014EB0 File Offset: 0x000130B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068230, XrefRangeEnd = 1068231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TableEntryReference.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00003039 File Offset: 0x00001239
		public TableEntryReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00003042 File Offset: 0x00001242
		public TableEntryReference()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr))
		{
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00014EE8 File Offset: 0x000130E8
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00003054 File Offset: 0x00001254
		public unsafe long m_KeyId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryReference.NativeFieldInfoPtr_m_KeyId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryReference.NativeFieldInfoPtr_m_KeyId)) = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00014F10 File Offset: 0x00013110
		// (set) Token: 0x060002FA RID: 762 RVA: 0x0000306F File Offset: 0x0000126F
		public unsafe string m_Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryReference.NativeFieldInfoPtr_m_Key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryReference.NativeFieldInfoPtr_m_Key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00014F38 File Offset: 0x00013138
		// (set) Token: 0x060002FC RID: 764 RVA: 0x0000308E File Offset: 0x0000128E
		public unsafe bool m_Valid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryReference.NativeFieldInfoPtr_m_Valid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryReference.NativeFieldInfoPtr_m_Valid)) = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00014F60 File Offset: 0x00013160
		// (set) Token: 0x060002FE RID: 766 RVA: 0x000030A9 File Offset: 0x000012A9
		public unsafe TableEntryReference.Type _ReferenceType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryReference.NativeFieldInfoPtr__ReferenceType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TableEntryReference.NativeFieldInfoPtr__ReferenceType_k__BackingField)) = value;
			}
		}

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyId;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_m_Key;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr_m_Valid;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr__ReferenceType_k__BackingField;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceType_Public_get_Type_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_set_ReferenceType_Private_set_Void_Type_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyId_Public_get_Int64_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyId_Private_set_Void_Int64_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Private_set_Void_String_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TableEntryReference_String_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TableEntryReference_Int64_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_TableEntryReference_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_TableEntryReference_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Void_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_ResolveKeyName_Public_String_SharedTableData_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_TableReference_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TableEntryReference_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0200012B RID: 299
		public enum Type
		{
			// Token: 0x04000936 RID: 2358
			Empty,
			// Token: 0x04000937 RID: 2359
			Name,
			// Token: 0x04000938 RID: 2360
			Id
		}
	}
}
