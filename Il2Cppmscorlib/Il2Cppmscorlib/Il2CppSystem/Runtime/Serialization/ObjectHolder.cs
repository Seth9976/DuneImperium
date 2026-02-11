using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032A RID: 810
	public sealed class ObjectHolder : Object
	{
		// Token: 0x06003178 RID: 12664 RVA: 0x000FB514 File Offset: 0x000F9714
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectHolder()
		{
			Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr);
			ObjectHolder.NativeFieldInfoPtr_m_object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_object");
			ObjectHolder.NativeFieldInfoPtr_m_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_id");
			ObjectHolder.NativeFieldInfoPtr_m_missingElementsRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_missingElementsRemaining");
			ObjectHolder.NativeFieldInfoPtr_m_missingDecendents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_missingDecendents");
			ObjectHolder.NativeFieldInfoPtr_m_serInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_serInfo");
			ObjectHolder.NativeFieldInfoPtr_m_surrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_surrogate");
			ObjectHolder.NativeFieldInfoPtr_m_missingElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_missingElements");
			ObjectHolder.NativeFieldInfoPtr_m_dependentObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_dependentObjects");
			ObjectHolder.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_next");
			ObjectHolder.NativeFieldInfoPtr_m_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_flags");
			ObjectHolder.NativeFieldInfoPtr_m_markForFixupWhenAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_markForFixupWhenAvailable");
			ObjectHolder.NativeFieldInfoPtr_m_valueFixup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_valueFixup");
			ObjectHolder.NativeFieldInfoPtr_m_typeLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_typeLoad");
			ObjectHolder.NativeFieldInfoPtr_m_reachable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, "m_reachable");
			ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671074);
			ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_Object_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671075);
			ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_String_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671076);
			ObjectHolder.NativeMethodInfoPtr_IncrementDescendentFixups_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671077);
			ObjectHolder.NativeMethodInfoPtr_DecrementFixupsRemaining_Internal_Void_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671078);
			ObjectHolder.NativeMethodInfoPtr_RemoveDependency_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671079);
			ObjectHolder.NativeMethodInfoPtr_AddFixup_Internal_Void_FixupHolder_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671080);
			ObjectHolder.NativeMethodInfoPtr_UpdateDescendentDependencyChain_Private_Void_Int32_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671081);
			ObjectHolder.NativeMethodInfoPtr_AddDependency_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671082);
			ObjectHolder.NativeMethodInfoPtr_UpdateData_Internal_Void_Object_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671083);
			ObjectHolder.NativeMethodInfoPtr_MarkForCompletionWhenAvailable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671084);
			ObjectHolder.NativeMethodInfoPtr_SetFlags_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671085);
			ObjectHolder.NativeMethodInfoPtr_get_IsIncompleteObjectReference_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671086);
			ObjectHolder.NativeMethodInfoPtr_set_IsIncompleteObjectReference_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671087);
			ObjectHolder.NativeMethodInfoPtr_get_RequiresDelayedFixup_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671088);
			ObjectHolder.NativeMethodInfoPtr_get_RequiresValueTypeFixup_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671089);
			ObjectHolder.NativeMethodInfoPtr_get_ValueTypeFixupPerformed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671090);
			ObjectHolder.NativeMethodInfoPtr_set_ValueTypeFixupPerformed_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671091);
			ObjectHolder.NativeMethodInfoPtr_get_HasISerializable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671092);
			ObjectHolder.NativeMethodInfoPtr_get_HasSurrogate_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671093);
			ObjectHolder.NativeMethodInfoPtr_get_CanSurrogatedObjectValueChange_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671094);
			ObjectHolder.NativeMethodInfoPtr_get_CanObjectValueChange_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671095);
			ObjectHolder.NativeMethodInfoPtr_get_DirectlyDependentObjects_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671096);
			ObjectHolder.NativeMethodInfoPtr_get_TotalDependentObjects_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671097);
			ObjectHolder.NativeMethodInfoPtr_get_Reachable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671098);
			ObjectHolder.NativeMethodInfoPtr_set_Reachable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671099);
			ObjectHolder.NativeMethodInfoPtr_get_TypeLoadExceptionReachable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671100);
			ObjectHolder.NativeMethodInfoPtr_get_TypeLoadException_Internal_get_TypeLoadExceptionHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671101);
			ObjectHolder.NativeMethodInfoPtr_set_TypeLoadException_Internal_set_Void_TypeLoadExceptionHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671102);
			ObjectHolder.NativeMethodInfoPtr_get_ObjectValue_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671103);
			ObjectHolder.NativeMethodInfoPtr_SetObjectValue_Internal_Void_Object_ObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671104);
			ObjectHolder.NativeMethodInfoPtr_get_SerializationInfo_Internal_get_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671105);
			ObjectHolder.NativeMethodInfoPtr_set_SerializationInfo_Internal_set_Void_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671106);
			ObjectHolder.NativeMethodInfoPtr_get_Surrogate_Internal_get_ISerializationSurrogate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671107);
			ObjectHolder.NativeMethodInfoPtr_get_DependentObjects_Internal_get_LongList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671108);
			ObjectHolder.NativeMethodInfoPtr_set_DependentObjects_Internal_set_Void_LongList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671109);
			ObjectHolder.NativeMethodInfoPtr_get_RequiresSerInfoFixup_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671110);
			ObjectHolder.NativeMethodInfoPtr_set_RequiresSerInfoFixup_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671111);
			ObjectHolder.NativeMethodInfoPtr_get_ValueFixup_Internal_get_ValueTypeFixupInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671112);
			ObjectHolder.NativeMethodInfoPtr_get_CompletelyFixed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671113);
			ObjectHolder.NativeMethodInfoPtr_get_ContainerID_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr, 100671114);
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x000FB990 File Offset: 0x000F9B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385739, XrefRangeEnd = 1385746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder(long objID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x000FB9D8 File Offset: 0x000F9BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385746, XrefRangeEnd = 1385774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder(Object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Il2CppStructArray<int> arrayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainingObj;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_Object_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x000FBA8C File Offset: 0x000F9C8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385785, RefRangeEnd = 1385786, XrefRangeStart = 1385774, XrefRangeEnd = 1385785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Il2CppStructArray<int> arrayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainingObj;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr__ctor_Internal_Void_String_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x000FBB40 File Offset: 0x000F9D40
		[CallerCount(0)]
		public unsafe void IncrementDescendentFixups(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_IncrementDescendentFixups_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x000FBB80 File Offset: 0x000F9D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385786, XrefRangeEnd = 1385788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DecrementFixupsRemaining(ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_DecrementFixupsRemaining_Internal_Void_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x000FBBC4 File Offset: 0x000F9DC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1385788, RefRangeEnd = 1385790, XrefRangeStart = 1385788, XrefRangeEnd = 1385788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDependency(long id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_RemoveDependency_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x000FBC04 File Offset: 0x000F9E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385790, XrefRangeEnd = 1385801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFixup(FixupHolder fixup, ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_AddFixup_Internal_Void_FixupHolder_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x000FBC58 File Offset: 0x000F9E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385801, XrefRangeEnd = 1385803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDescendentDependencyChain(int amount, ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_UpdateDescendentDependencyChain_Private_Void_Int32_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x000FBCA8 File Offset: 0x000F9EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385803, XrefRangeEnd = 1385817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDependency(long dependentObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dependentObject;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_AddDependency_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x000FBCE8 File Offset: 0x000F9EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385830, RefRangeEnd = 1385831, XrefRangeStart = 1385817, XrefRangeEnd = 1385830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateData(Object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, Il2CppStructArray<int> arrayIndex, ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayIndex);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_UpdateData_Internal_Void_Object_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x000FBD98 File Offset: 0x000F9F98
		[CallerCount(0)]
		public unsafe void MarkForCompletionWhenAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_MarkForCompletionWhenAvailable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x000FBDCC File Offset: 0x000F9FCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1385838, RefRangeEnd = 1385840, XrefRangeStart = 1385831, XrefRangeEnd = 1385838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_SetFlags_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x000FBE00 File Offset: 0x000FA000
		// (set) Token: 0x06003186 RID: 12678 RVA: 0x000FBE3C File Offset: 0x000FA03C
		public unsafe bool IsIncompleteObjectReference
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 389761, RefRangeEnd = 389762, XrefRangeStart = 389761, XrefRangeEnd = 389762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_IsIncompleteObjectReference_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_IsIncompleteObjectReference_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x000FBE7C File Offset: 0x000FA07C
		public unsafe bool RequiresDelayedFixup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_RequiresDelayedFixup_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x000FBEB8 File Offset: 0x000FA0B8
		public unsafe bool RequiresValueTypeFixup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_RequiresValueTypeFixup_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x000FBEF4 File Offset: 0x000FA0F4
		// (set) Token: 0x0600318A RID: 12682 RVA: 0x000FBF30 File Offset: 0x000FA130
		public unsafe bool ValueTypeFixupPerformed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_ValueTypeFixupPerformed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_ValueTypeFixupPerformed_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x000FBF70 File Offset: 0x000FA170
		public unsafe bool HasISerializable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_HasISerializable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x0600318C RID: 12684 RVA: 0x000FBFAC File Offset: 0x000FA1AC
		public unsafe bool HasSurrogate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_HasSurrogate_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x0600318D RID: 12685 RVA: 0x000FBFE8 File Offset: 0x000FA1E8
		public unsafe bool CanSurrogatedObjectValueChange
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1385842, RefRangeEnd = 1385845, XrefRangeStart = 1385840, XrefRangeEnd = 1385842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_CanSurrogatedObjectValueChange_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x000FC024 File Offset: 0x000FA224
		public unsafe bool CanObjectValueChange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_CanObjectValueChange_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x000FC060 File Offset: 0x000FA260
		public unsafe int DirectlyDependentObjects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_DirectlyDependentObjects_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x000FC09C File Offset: 0x000FA29C
		public unsafe int TotalDependentObjects
		{
			[CallerCount(178)]
			[CachedScanResults(RefRangeStart = 1363788, RefRangeEnd = 1363966, XrefRangeStart = 1363788, XrefRangeEnd = 1363966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_TotalDependentObjects_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x000FC0D8 File Offset: 0x000FA2D8
		// (set) Token: 0x06003192 RID: 12690 RVA: 0x000FC114 File Offset: 0x000FA314
		public unsafe bool Reachable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_Reachable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_Reachable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x000FC154 File Offset: 0x000FA354
		public unsafe bool TypeLoadExceptionReachable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_TypeLoadExceptionReachable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x000FC190 File Offset: 0x000FA390
		// (set) Token: 0x06003195 RID: 12693 RVA: 0x000FC1D0 File Offset: 0x000FA3D0
		public unsafe TypeLoadExceptionHolder TypeLoadException
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_TypeLoadException_Internal_get_TypeLoadExceptionHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeLoadExceptionHolder>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_TypeLoadException_Internal_set_Void_TypeLoadExceptionHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x000FC214 File Offset: 0x000FA414
		public unsafe Object ObjectValue
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_ObjectValue_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x000FC254 File Offset: 0x000FA454
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1385851, RefRangeEnd = 1385854, XrefRangeStart = 1385845, XrefRangeEnd = 1385851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectValue(Object obj, ObjectManager manager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_SetObjectValue_Internal_Void_Object_ObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x000FC2A8 File Offset: 0x000FA4A8
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x000FC2E8 File Offset: 0x000FA4E8
		public unsafe SerializationInfo SerializationInfo
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_SerializationInfo_Internal_get_SerializationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_SerializationInfo_Internal_set_Void_SerializationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x000FC32C File Offset: 0x000FA52C
		public unsafe ISerializationSurrogate Surrogate
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_Surrogate_Internal_get_ISerializationSurrogate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr3) : null;
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x000FC36C File Offset: 0x000FA56C
		// (set) Token: 0x0600319C RID: 12700 RVA: 0x000FC3AC File Offset: 0x000FA5AC
		public unsafe LongList DependentObjects
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_DependentObjects_Internal_get_LongList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LongList>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_DependentObjects_Internal_set_Void_LongList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x000FC3F0 File Offset: 0x000FA5F0
		// (set) Token: 0x0600319E RID: 12702 RVA: 0x000FC42C File Offset: 0x000FA62C
		public unsafe bool RequiresSerInfoFixup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_RequiresSerInfoFixup_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_set_RequiresSerInfoFixup_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x000FC46C File Offset: 0x000FA66C
		public unsafe ValueTypeFixupInfo ValueFixup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_ValueFixup_Internal_get_ValueTypeFixupInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueTypeFixupInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x000FC4AC File Offset: 0x000FA6AC
		public unsafe bool CompletelyFixed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_CompletelyFixed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x000FC4E8 File Offset: 0x000FA6E8
		public unsafe long ContainerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolder.NativeMethodInfoPtr_get_ContainerID_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x000110BA File Offset: 0x0000F2BA
		public ObjectHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x060031A3 RID: 12707 RVA: 0x000FC524 File Offset: 0x000FA724
		// (set) Token: 0x060031A4 RID: 12708 RVA: 0x000110C3 File Offset: 0x0000F2C3
		public unsafe Object m_object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_object);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_object), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x060031A5 RID: 12709 RVA: 0x000FC554 File Offset: 0x000FA754
		// (set) Token: 0x060031A6 RID: 12710 RVA: 0x000110E2 File Offset: 0x0000F2E2
		public unsafe long m_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_id)) = value;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x000FC57C File Offset: 0x000FA77C
		// (set) Token: 0x060031A8 RID: 12712 RVA: 0x000110FD File Offset: 0x0000F2FD
		public unsafe int m_missingElementsRemaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingElementsRemaining);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingElementsRemaining)) = value;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x000FC5A4 File Offset: 0x000FA7A4
		// (set) Token: 0x060031AA RID: 12714 RVA: 0x00011118 File Offset: 0x0000F318
		public unsafe int m_missingDecendents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingDecendents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingDecendents)) = value;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x000FC5CC File Offset: 0x000FA7CC
		// (set) Token: 0x060031AC RID: 12716 RVA: 0x00011133 File Offset: 0x0000F333
		public unsafe SerializationInfo m_serInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_serInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_serInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x000FC5FC File Offset: 0x000FA7FC
		// (set) Token: 0x060031AE RID: 12718 RVA: 0x00011152 File Offset: 0x0000F352
		public unsafe ISerializationSurrogate m_surrogate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_surrogate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_surrogate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x000FC62C File Offset: 0x000FA82C
		// (set) Token: 0x060031B0 RID: 12720 RVA: 0x00011171 File Offset: 0x0000F371
		public unsafe FixupHolderList m_missingElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FixupHolderList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_missingElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x000FC65C File Offset: 0x000FA85C
		// (set) Token: 0x060031B2 RID: 12722 RVA: 0x00011190 File Offset: 0x0000F390
		public unsafe LongList m_dependentObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_dependentObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LongList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_dependentObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060031B3 RID: 12723 RVA: 0x000FC68C File Offset: 0x000FA88C
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x000111AF File Offset: 0x0000F3AF
		public unsafe ObjectHolder m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x000FC6BC File Offset: 0x000FA8BC
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x000111CE File Offset: 0x0000F3CE
		public unsafe int m_flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_flags)) = value;
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x000FC6E4 File Offset: 0x000FA8E4
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x000111E9 File Offset: 0x0000F3E9
		public unsafe bool m_markForFixupWhenAvailable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_markForFixupWhenAvailable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_markForFixupWhenAvailable)) = value;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x000FC70C File Offset: 0x000FA90C
		// (set) Token: 0x060031BA RID: 12730 RVA: 0x00011204 File Offset: 0x0000F404
		public unsafe ValueTypeFixupInfo m_valueFixup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_valueFixup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTypeFixupInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_valueFixup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x000FC73C File Offset: 0x000FA93C
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x00011223 File Offset: 0x0000F423
		public unsafe TypeLoadExceptionHolder m_typeLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_typeLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeLoadExceptionHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_typeLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x000FC76C File Offset: 0x000FA96C
		// (set) Token: 0x060031BE RID: 12734 RVA: 0x00011242 File Offset: 0x0000F442
		public unsafe bool m_reachable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_reachable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolder.NativeFieldInfoPtr_m_reachable)) = value;
			}
		}

		// Token: 0x040028B2 RID: 10418
		private static readonly IntPtr NativeFieldInfoPtr_m_object;

		// Token: 0x040028B3 RID: 10419
		private static readonly IntPtr NativeFieldInfoPtr_m_id;

		// Token: 0x040028B4 RID: 10420
		private static readonly IntPtr NativeFieldInfoPtr_m_missingElementsRemaining;

		// Token: 0x040028B5 RID: 10421
		private static readonly IntPtr NativeFieldInfoPtr_m_missingDecendents;

		// Token: 0x040028B6 RID: 10422
		private static readonly IntPtr NativeFieldInfoPtr_m_serInfo;

		// Token: 0x040028B7 RID: 10423
		private static readonly IntPtr NativeFieldInfoPtr_m_surrogate;

		// Token: 0x040028B8 RID: 10424
		private static readonly IntPtr NativeFieldInfoPtr_m_missingElements;

		// Token: 0x040028B9 RID: 10425
		private static readonly IntPtr NativeFieldInfoPtr_m_dependentObjects;

		// Token: 0x040028BA RID: 10426
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x040028BB RID: 10427
		private static readonly IntPtr NativeFieldInfoPtr_m_flags;

		// Token: 0x040028BC RID: 10428
		private static readonly IntPtr NativeFieldInfoPtr_m_markForFixupWhenAvailable;

		// Token: 0x040028BD RID: 10429
		private static readonly IntPtr NativeFieldInfoPtr_m_valueFixup;

		// Token: 0x040028BE RID: 10430
		private static readonly IntPtr NativeFieldInfoPtr_m_typeLoad;

		// Token: 0x040028BF RID: 10431
		private static readonly IntPtr NativeFieldInfoPtr_m_reachable;

		// Token: 0x040028C0 RID: 10432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int64_0;

		// Token: 0x040028C1 RID: 10433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x040028C2 RID: 10434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int64_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x040028C3 RID: 10435
		private static readonly IntPtr NativeMethodInfoPtr_IncrementDescendentFixups_Private_Void_Int32_0;

		// Token: 0x040028C4 RID: 10436
		private static readonly IntPtr NativeMethodInfoPtr_DecrementFixupsRemaining_Internal_Void_ObjectManager_0;

		// Token: 0x040028C5 RID: 10437
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDependency_Internal_Void_Int64_0;

		// Token: 0x040028C6 RID: 10438
		private static readonly IntPtr NativeMethodInfoPtr_AddFixup_Internal_Void_FixupHolder_ObjectManager_0;

		// Token: 0x040028C7 RID: 10439
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDescendentDependencyChain_Private_Void_Int32_ObjectManager_0;

		// Token: 0x040028C8 RID: 10440
		private static readonly IntPtr NativeMethodInfoPtr_AddDependency_Internal_Void_Int64_0;

		// Token: 0x040028C9 RID: 10441
		private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Internal_Void_Object_SerializationInfo_ISerializationSurrogate_Int64_FieldInfo_Il2CppStructArray_1_Int32_ObjectManager_0;

		// Token: 0x040028CA RID: 10442
		private static readonly IntPtr NativeMethodInfoPtr_MarkForCompletionWhenAvailable_Internal_Void_0;

		// Token: 0x040028CB RID: 10443
		private static readonly IntPtr NativeMethodInfoPtr_SetFlags_Internal_Void_0;

		// Token: 0x040028CC RID: 10444
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIncompleteObjectReference_Internal_get_Boolean_0;

		// Token: 0x040028CD RID: 10445
		private static readonly IntPtr NativeMethodInfoPtr_set_IsIncompleteObjectReference_Internal_set_Void_Boolean_0;

		// Token: 0x040028CE RID: 10446
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresDelayedFixup_Internal_get_Boolean_0;

		// Token: 0x040028CF RID: 10447
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresValueTypeFixup_Internal_get_Boolean_0;

		// Token: 0x040028D0 RID: 10448
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueTypeFixupPerformed_Internal_get_Boolean_0;

		// Token: 0x040028D1 RID: 10449
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueTypeFixupPerformed_Internal_set_Void_Boolean_0;

		// Token: 0x040028D2 RID: 10450
		private static readonly IntPtr NativeMethodInfoPtr_get_HasISerializable_Internal_get_Boolean_0;

		// Token: 0x040028D3 RID: 10451
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSurrogate_Internal_get_Boolean_0;

		// Token: 0x040028D4 RID: 10452
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSurrogatedObjectValueChange_Internal_get_Boolean_0;

		// Token: 0x040028D5 RID: 10453
		private static readonly IntPtr NativeMethodInfoPtr_get_CanObjectValueChange_Internal_get_Boolean_0;

		// Token: 0x040028D6 RID: 10454
		private static readonly IntPtr NativeMethodInfoPtr_get_DirectlyDependentObjects_Internal_get_Int32_0;

		// Token: 0x040028D7 RID: 10455
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDependentObjects_Internal_get_Int32_0;

		// Token: 0x040028D8 RID: 10456
		private static readonly IntPtr NativeMethodInfoPtr_get_Reachable_Internal_get_Boolean_0;

		// Token: 0x040028D9 RID: 10457
		private static readonly IntPtr NativeMethodInfoPtr_set_Reachable_Internal_set_Void_Boolean_0;

		// Token: 0x040028DA RID: 10458
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeLoadExceptionReachable_Internal_get_Boolean_0;

		// Token: 0x040028DB RID: 10459
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeLoadException_Internal_get_TypeLoadExceptionHolder_0;

		// Token: 0x040028DC RID: 10460
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeLoadException_Internal_set_Void_TypeLoadExceptionHolder_0;

		// Token: 0x040028DD RID: 10461
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectValue_Internal_get_Object_0;

		// Token: 0x040028DE RID: 10462
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectValue_Internal_Void_Object_ObjectManager_0;

		// Token: 0x040028DF RID: 10463
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializationInfo_Internal_get_SerializationInfo_0;

		// Token: 0x040028E0 RID: 10464
		private static readonly IntPtr NativeMethodInfoPtr_set_SerializationInfo_Internal_set_Void_SerializationInfo_0;

		// Token: 0x040028E1 RID: 10465
		private static readonly IntPtr NativeMethodInfoPtr_get_Surrogate_Internal_get_ISerializationSurrogate_0;

		// Token: 0x040028E2 RID: 10466
		private static readonly IntPtr NativeMethodInfoPtr_get_DependentObjects_Internal_get_LongList_0;

		// Token: 0x040028E3 RID: 10467
		private static readonly IntPtr NativeMethodInfoPtr_set_DependentObjects_Internal_set_Void_LongList_0;

		// Token: 0x040028E4 RID: 10468
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresSerInfoFixup_Internal_get_Boolean_0;

		// Token: 0x040028E5 RID: 10469
		private static readonly IntPtr NativeMethodInfoPtr_set_RequiresSerInfoFixup_Internal_set_Void_Boolean_0;

		// Token: 0x040028E6 RID: 10470
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueFixup_Internal_get_ValueTypeFixupInfo_0;

		// Token: 0x040028E7 RID: 10471
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletelyFixed_Internal_get_Boolean_0;

		// Token: 0x040028E8 RID: 10472
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainerID_Internal_get_Int64_0;
	}
}
