using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000130 RID: 304
	[Serializable]
	public class HashSet<T> : Object
	{
		// Token: 0x060011C8 RID: 4552 RVA: 0x0005CE78 File Offset: 0x0005B078
		// Note: this type is marked as 'beforefieldinit'.
		static HashSet()
		{
			Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Collections.Generic", "HashSet`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr);
			HashSet<T>.NativeFieldInfoPtr_Lower31BitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "Lower31BitMask");
			HashSet<T>.NativeFieldInfoPtr_StackAllocThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "StackAllocThreshold");
			HashSet<T>.NativeFieldInfoPtr_ShrinkThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "ShrinkThreshold");
			HashSet<T>.NativeFieldInfoPtr_CapacityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "CapacityName");
			HashSet<T>.NativeFieldInfoPtr_ElementsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "ElementsName");
			HashSet<T>.NativeFieldInfoPtr_ComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "ComparerName");
			HashSet<T>.NativeFieldInfoPtr_VersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "VersionName");
			HashSet<T>.NativeFieldInfoPtr__buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_buckets");
			HashSet<T>.NativeFieldInfoPtr__slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_slots");
			HashSet<T>.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_count");
			HashSet<T>.NativeFieldInfoPtr__lastIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_lastIndex");
			HashSet<T>.NativeFieldInfoPtr__freeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_freeList");
			HashSet<T>.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_comparer");
			HashSet<T>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_version");
			HashSet<T>.NativeFieldInfoPtr__siInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "_siInfo");
			HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666669);
			HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666670);
			HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666671);
			HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666672);
			HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666673);
			HashSet<T>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666674);
			HashSet<T>.NativeMethodInfoPtr_CopyFrom_Private_Void_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666675);
			HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666676);
			HashSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666677);
			HashSet<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666678);
			HashSet<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666679);
			HashSet<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666680);
			HashSet<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666681);
			HashSet<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666682);
			HashSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666683);
			HashSet<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666684);
			HashSet<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666685);
			HashSet<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666686);
			HashSet<T>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666687);
			HashSet<T>.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666688);
			HashSet<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666689);
			HashSet<T>.NativeMethodInfoPtr_UnionWith_Public_Virtual_Final_New_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666690);
			HashSet<T>.NativeMethodInfoPtr_IntersectWith_Public_Virtual_Final_New_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666691);
			HashSet<T>.NativeMethodInfoPtr_ExceptWith_Public_Virtual_Final_New_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666692);
			HashSet<T>.NativeMethodInfoPtr_IsSubsetOf_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666693);
			HashSet<T>.NativeMethodInfoPtr_IsProperSubsetOf_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666694);
			HashSet<T>.NativeMethodInfoPtr_IsSupersetOf_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666695);
			HashSet<T>.NativeMethodInfoPtr_IsProperSupersetOf_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666696);
			HashSet<T>.NativeMethodInfoPtr_Overlaps_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666697);
			HashSet<T>.NativeMethodInfoPtr_SetEquals_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666698);
			HashSet<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666699);
			HashSet<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666700);
			HashSet<T>.NativeMethodInfoPtr_RemoveWhere_Public_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666701);
			HashSet<T>.NativeMethodInfoPtr_get_Comparer_Public_get_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666702);
			HashSet<T>.NativeMethodInfoPtr_TrimExcess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666703);
			HashSet<T>.NativeMethodInfoPtr_CreateSetComparer_Public_Static_IEqualityComparer_1_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666704);
			HashSet<T>.NativeMethodInfoPtr_Initialize_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666705);
			HashSet<T>.NativeMethodInfoPtr_IncreaseCapacity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666706);
			HashSet<T>.NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666707);
			HashSet<T>.NativeMethodInfoPtr_AddIfNotPresent_Private_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666708);
			HashSet<T>.NativeMethodInfoPtr_AddValue_Private_Void_Int32_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666709);
			HashSet<T>.NativeMethodInfoPtr_ContainsAllElements_Private_Boolean_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666710);
			HashSet<T>.NativeMethodInfoPtr_IsSubsetOfHashSetWithSameEC_Private_Boolean_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666711);
			HashSet<T>.NativeMethodInfoPtr_IntersectWithHashSetWithSameEC_Private_Void_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666712);
			HashSet<T>.NativeMethodInfoPtr_IntersectWithEnumerable_Private_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666713);
			HashSet<T>.NativeMethodInfoPtr_InternalIndexOf_Private_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666714);
			HashSet<T>.NativeMethodInfoPtr_CheckUniqueAndUnfoundElements_Private_ElementCount_T_IEnumerable_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666715);
			HashSet<T>.NativeMethodInfoPtr_HashSetEquals_Internal_Static_Boolean_HashSet_1_T_HashSet_1_T_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666716);
			HashSet<T>.NativeMethodInfoPtr_AreEqualityComparersEqual_Private_Static_Boolean_HashSet_1_T_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666717);
			HashSet<T>.NativeMethodInfoPtr_InternalGetHashCode_Private_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, 100666718);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0005D3F8 File Offset: 0x0005B5F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1031352, RefRangeEnd = 1031353, XrefRangeStart = 1031348, XrefRangeEnd = 1031352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0005D434 File Offset: 0x0005B634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031353, XrefRangeEnd = 1031356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet(IEqualityComparer<T> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0005D480 File Offset: 0x0005B680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031356, XrefRangeEnd = 1031361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0005D4C8 File Offset: 0x0005B6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031361, XrefRangeEnd = 1031363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet(IEnumerable<T> collection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0005D514 File Offset: 0x0005B714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1031370, RefRangeEnd = 1031371, XrefRangeStart = 1031363, XrefRangeEnd = 1031370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0005D574 File Offset: 0x0005B774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0005D5D8 File Offset: 0x0005B7D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1031393, RefRangeEnd = 1031394, XrefRangeStart = 1031371, XrefRangeEnd = 1031393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(HashSet<T> source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_CopyFrom_Private_Void_HashSet_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0005D61C File Offset: 0x0005B81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031394, XrefRangeEnd = 1031398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet(int capacity, IEqualityComparer<T> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0005D678 File Offset: 0x0005B878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1031399, RefRangeEnd = 1031400, XrefRangeStart = 1031398, XrefRangeEnd = 1031399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_ICollection_T__Add(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0005D6F0 File Offset: 0x0005B8F0
		[CallerCount(99)]
		[CachedScanResults(RefRangeStart = 1031402, RefRangeEnd = 1031501, XrefRangeStart = 1031400, XrefRangeEnd = 1031402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0005D724 File Offset: 0x0005B924
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1031504, RefRangeEnd = 1031512, XrefRangeStart = 1031501, XrefRangeEnd = 1031504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0005D7A8 File Offset: 0x0005B9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031512, XrefRangeEnd = 1031513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppArrayBase<T> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0005D7F8 File Offset: 0x0005B9F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1031516, RefRangeEnd = 1031521, XrefRangeStart = 1031513, XrefRangeEnd = 1031516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0005D87C File Offset: 0x0005BA7C
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0005D8B8 File Offset: 0x0005BAB8
		public unsafe virtual bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0005D8F4 File Offset: 0x0005BAF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1031522, RefRangeEnd = 1031528, XrefRangeStart = 1031521, XrefRangeEnd = 1031522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new HashSet<T>.Enumerator(intPtr);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0005D92C File Offset: 0x0005BB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031528, XrefRangeEnd = 1031530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0005D96C File Offset: 0x0005BB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0005D9AC File Offset: 0x0005BBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031530, XrefRangeEnd = 1031553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashSet<T>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0005DA10 File Offset: 0x0005BC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031553, XrefRangeEnd = 1031600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HashSet<T>.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0005DA60 File Offset: 0x0005BC60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1031399, RefRangeEnd = 1031400, XrefRangeStart = 1031399, XrefRangeEnd = 1031400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Add(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0005DAE4 File Offset: 0x0005BCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031600, XrefRangeEnd = 1031616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnionWith(IEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_UnionWith_Public_Virtual_Final_New_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0005DB28 File Offset: 0x0005BD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031616, XrefRangeEnd = 1031625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void IntersectWith(IEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_IntersectWith_Public_Virtual_Final_New_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0005DB6C File Offset: 0x0005BD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031625, XrefRangeEnd = 1031643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExceptWith(IEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_ExceptWith_Public_Virtual_Final_New_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x0005DBB0 File Offset: 0x0005BDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031643, XrefRangeEnd = 1031647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsSubsetOf(IEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_IsSubsetOf_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0005DC00 File Offset: 0x0005BE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031647, XrefRangeEnd = 1031658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsProperSubsetOf(IEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_IsProperSubsetOf_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0005DC50 File Offset: 0x0005BE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031658, XrefRangeEnd = 1031665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsSupersetOf(IEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_IsSupersetOf_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0005DCA0 File Offset: 0x0005BEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031665, XrefRangeEnd = 1031673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsProperSupersetOf(IEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_IsProperSupersetOf_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0005DCF0 File Offset: 0x0005BEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031673, XrefRangeEnd = 1031692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Overlaps(IEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_Overlaps_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0005DD40 File Offset: 0x0005BF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031692, XrefRangeEnd = 1031696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SetEquals(IEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_SetEquals_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0005DD90 File Offset: 0x0005BF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031696, XrefRangeEnd = 1031697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0005DDD4 File Offset: 0x0005BFD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1031698, RefRangeEnd = 1031701, XrefRangeStart = 1031697, XrefRangeEnd = 1031698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppArrayBase<T> array, int arrayIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0005DE34 File Offset: 0x0005C034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031701, XrefRangeEnd = 1031702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RemoveWhere(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_RemoveWhere_Public_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0005DE84 File Offset: 0x0005C084
		public unsafe IEqualityComparer<T> Comparer
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_get_Comparer_Public_get_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x0005DEC4 File Offset: 0x0005C0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031702, XrefRangeEnd = 1031714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrimExcess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_TrimExcess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0005DEF8 File Offset: 0x0005C0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031714, XrefRangeEnd = 1031721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEqualityComparer<HashSet<T>> CreateSetComparer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_CreateSetComparer_Public_Static_IEqualityComparer_1_HashSet_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<HashSet<T>>>(intPtr3) : null;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0005DF2C File Offset: 0x0005C12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031721, XrefRangeEnd = 1031732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Initialize(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_Initialize_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0005DF78 File Offset: 0x0005C178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1031762, RefRangeEnd = 1031764, XrefRangeStart = 1031732, XrefRangeEnd = 1031762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_IncreaseCapacity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0005DFAC File Offset: 0x0005C1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031764, XrefRangeEnd = 1031778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCapacity(int newSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0005DFEC File Offset: 0x0005C1EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1031785, RefRangeEnd = 1031788, XrefRangeStart = 1031778, XrefRangeEnd = 1031785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddIfNotPresent(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_AddIfNotPresent_Private_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0005E070 File Offset: 0x0005C270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031788, XrefRangeEnd = 1031789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(int index, int hashCode, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_AddValue_Private_Void_Int32_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0005E104 File Offset: 0x0005C304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1031800, RefRangeEnd = 1031802, XrefRangeStart = 1031789, XrefRangeEnd = 1031800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsAllElements(IEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_ContainsAllElements_Private_Boolean_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0005E154 File Offset: 0x0005C354
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1031806, RefRangeEnd = 1031808, XrefRangeStart = 1031802, XrefRangeEnd = 1031806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSubsetOfHashSetWithSameEC(HashSet<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_IsSubsetOfHashSetWithSameEC_Private_Boolean_HashSet_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0005E1A4 File Offset: 0x0005C3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031808, XrefRangeEnd = 1031810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntersectWithHashSetWithSameEC(HashSet<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_IntersectWithHashSetWithSameEC_Private_Void_HashSet_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0005E1E8 File Offset: 0x0005C3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031810, XrefRangeEnd = 1031844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntersectWithEnumerable(IEnumerable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_IntersectWithEnumerable_Private_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0005E22C File Offset: 0x0005C42C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1031847, RefRangeEnd = 1031849, XrefRangeStart = 1031844, XrefRangeEnd = 1031847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalIndexOf(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_InternalIndexOf_Private_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0005E2B0 File Offset: 0x0005C4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031849, XrefRangeEnd = 1031885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet<T>.ElementCount CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnIfUnfound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_CheckUniqueAndUnfoundElements_Private_ElementCount_T_IEnumerable_1_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new HashSet<T>.ElementCount(intPtr);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0005E308 File Offset: 0x0005C508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1031931, RefRangeEnd = 1031932, XrefRangeStart = 1031885, XrefRangeEnd = 1031931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HashSetEquals(HashSet<T> set1, HashSet<T> set2, IEqualityComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(set1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(set2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_HashSetEquals_Internal_Static_Boolean_HashSet_1_T_HashSet_1_T_IEqualityComparer_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0005E370 File Offset: 0x0005C570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031932, XrefRangeEnd = 1031935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(set1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(set2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_AreEqualityComparersEqual_Private_Static_Boolean_HashSet_1_T_HashSet_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0005E3C4 File Offset: 0x0005C5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031935, XrefRangeEnd = 1031937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalGetHashCode(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.NativeMethodInfoPtr_InternalGetHashCode_Private_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0000765F File Offset: 0x0000585F
		public HashSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0005E448 File Offset: 0x0005C648
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x00007668 File Offset: 0x00005868
		public unsafe static int Lower31BitMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_Lower31BitMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_Lower31BitMask, (void*)(&value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0005E464 File Offset: 0x0005C664
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x00007676 File Offset: 0x00005876
		public unsafe static int StackAllocThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_StackAllocThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_StackAllocThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x0005E480 File Offset: 0x0005C680
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x00007684 File Offset: 0x00005884
		public unsafe static int ShrinkThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_ShrinkThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_ShrinkThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x0005E49C File Offset: 0x0005C69C
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x00007692 File Offset: 0x00005892
		public unsafe static string CapacityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_CapacityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_CapacityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x0005E4BC File Offset: 0x0005C6BC
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x000076A4 File Offset: 0x000058A4
		public unsafe static string ElementsName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_ElementsName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_ElementsName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x0005E4DC File Offset: 0x0005C6DC
		// (set) Token: 0x06001207 RID: 4615 RVA: 0x000076B6 File Offset: 0x000058B6
		public unsafe static string ComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_ComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_ComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x0005E4FC File Offset: 0x0005C6FC
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x000076C8 File Offset: 0x000058C8
		public unsafe static string VersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashSet<T>.NativeFieldInfoPtr_VersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSet<T>.NativeFieldInfoPtr_VersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x0005E51C File Offset: 0x0005C71C
		// (set) Token: 0x0600120B RID: 4619 RVA: 0x000076DA File Offset: 0x000058DA
		public unsafe Il2CppStructArray<int> _buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x0005E54C File Offset: 0x0005C74C
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x000076F9 File Offset: 0x000058F9
		public unsafe Il2CppReferenceArray<HashSet<T>.Slot> _slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HashSet<T>.Slot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x0005E57C File Offset: 0x0005C77C
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x00007718 File Offset: 0x00005918
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x0005E5A4 File Offset: 0x0005C7A4
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x00007733 File Offset: 0x00005933
		public unsafe int _lastIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__lastIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__lastIndex)) = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x0005E5CC File Offset: 0x0005C7CC
		// (set) Token: 0x06001213 RID: 4627 RVA: 0x0000774E File Offset: 0x0000594E
		public unsafe int _freeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__freeList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__freeList)) = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x0005E5F4 File Offset: 0x0005C7F4
		// (set) Token: 0x06001215 RID: 4629 RVA: 0x00007769 File Offset: 0x00005969
		public unsafe IEqualityComparer<T> _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x0005E624 File Offset: 0x0005C824
		// (set) Token: 0x06001217 RID: 4631 RVA: 0x00007788 File Offset: 0x00005988
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x0005E64C File Offset: 0x0005C84C
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x000077A3 File Offset: 0x000059A3
		public unsafe SerializationInfo _siInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__siInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.NativeFieldInfoPtr__siInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeFieldInfoPtr_Lower31BitMask;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeFieldInfoPtr_StackAllocThreshold;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeFieldInfoPtr_ShrinkThreshold;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeFieldInfoPtr_CapacityName;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeFieldInfoPtr_ElementsName;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeFieldInfoPtr_ComparerName;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeFieldInfoPtr_VersionName;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeFieldInfoPtr__buckets;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeFieldInfoPtr__slots;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeFieldInfoPtr__lastIndex;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeFieldInfoPtr__freeList;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeFieldInfoPtr__siInfo;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_T_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_IEqualityComparer_1_T_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Private_Void_HashSet_1_T_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_T_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_UnionWith_Public_Virtual_Final_New_Void_IEnumerable_1_T_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_IntersectWith_Public_Virtual_Final_New_Void_IEnumerable_1_T_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_ExceptWith_Public_Virtual_Final_New_Void_IEnumerable_1_T_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_IsSubsetOf_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_IsProperSubsetOf_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_IsSupersetOf_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_IsProperSupersetOf_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_Overlaps_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_SetEquals_Public_Virtual_Final_New_Boolean_IEnumerable_1_T_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_RemoveWhere_Public_Int32_Predicate_1_T_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_get_Comparer_Public_get_IEqualityComparer_1_T_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_TrimExcess_Public_Void_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_CreateSetComparer_Public_Static_IEqualityComparer_1_HashSet_1_T_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Int32_Int32_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseCapacity_Private_Void_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Private_Void_Int32_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_AddIfNotPresent_Private_Boolean_T_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Private_Void_Int32_Int32_T_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_ContainsAllElements_Private_Boolean_IEnumerable_1_T_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_IsSubsetOfHashSetWithSameEC_Private_Boolean_HashSet_1_T_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_IntersectWithHashSetWithSameEC_Private_Void_HashSet_1_T_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_IntersectWithEnumerable_Private_Void_IEnumerable_1_T_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_InternalIndexOf_Private_Int32_T_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_CheckUniqueAndUnfoundElements_Private_ElementCount_T_IEnumerable_1_T_Boolean_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_HashSetEquals_Internal_Static_Boolean_HashSet_1_T_HashSet_1_T_IEqualityComparer_1_T_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_AreEqualityComparersEqual_Private_Static_Boolean_HashSet_1_T_HashSet_1_T_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetHashCode_Private_Int32_T_0;

		// Token: 0x02000357 RID: 855
		public sealed class ElementCount : ValueType
		{
			// Token: 0x06001C27 RID: 7207 RVA: 0x00084FA0 File Offset: 0x000831A0
			// Note: this type is marked as 'beforefieldinit'.
			static ElementCount()
			{
				Il2CppClassPointerStore<HashSet<T>.ElementCount>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "ElementCount"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSet<T>.ElementCount>.NativeClassPtr);
				HashSet<T>.ElementCount.NativeFieldInfoPtr_uniqueCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.ElementCount>.NativeClassPtr, "uniqueCount");
				HashSet<T>.ElementCount.NativeFieldInfoPtr_unfoundCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.ElementCount>.NativeClassPtr, "unfoundCount");
			}

			// Token: 0x06001C28 RID: 7208 RVA: 0x0000AB9E File Offset: 0x00008D9E
			public ElementCount(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C29 RID: 7209 RVA: 0x0000ABA7 File Offset: 0x00008DA7
			public ElementCount()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>.ElementCount>.NativeClassPtr))
			{
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00085030 File Offset: 0x00083230
			// (set) Token: 0x06001C2B RID: 7211 RVA: 0x0000ABB9 File Offset: 0x00008DB9
			public unsafe int uniqueCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.ElementCount.NativeFieldInfoPtr_uniqueCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.ElementCount.NativeFieldInfoPtr_uniqueCount)) = value;
				}
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00085058 File Offset: 0x00083258
			// (set) Token: 0x06001C2D RID: 7213 RVA: 0x0000ABD4 File Offset: 0x00008DD4
			public unsafe int unfoundCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.ElementCount.NativeFieldInfoPtr_unfoundCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.ElementCount.NativeFieldInfoPtr_unfoundCount)) = value;
				}
			}

			// Token: 0x04001303 RID: 4867
			private static readonly IntPtr NativeFieldInfoPtr_uniqueCount;

			// Token: 0x04001304 RID: 4868
			private static readonly IntPtr NativeFieldInfoPtr_unfoundCount;
		}

		// Token: 0x02000358 RID: 856
		public sealed class Slot : ValueType
		{
			// Token: 0x06001C2E RID: 7214 RVA: 0x00085080 File Offset: 0x00083280
			// Note: this type is marked as 'beforefieldinit'.
			static Slot()
			{
				Il2CppClassPointerStore<HashSet<T>.Slot>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "Slot"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSet<T>.Slot>.NativeClassPtr);
				HashSet<T>.Slot.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Slot>.NativeClassPtr, "hashCode");
				HashSet<T>.Slot.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Slot>.NativeClassPtr, "next");
				HashSet<T>.Slot.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Slot>.NativeClassPtr, "value");
			}

			// Token: 0x06001C2F RID: 7215 RVA: 0x0000ABEF File Offset: 0x00008DEF
			public Slot(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C30 RID: 7216 RVA: 0x0000ABF8 File Offset: 0x00008DF8
			public Slot()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>.Slot>.NativeClassPtr))
			{
			}

			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x06001C31 RID: 7217 RVA: 0x00085124 File Offset: 0x00083324
			// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0000AC0A File Offset: 0x00008E0A
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Slot.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Slot.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x06001C33 RID: 7219 RVA: 0x0008514C File Offset: 0x0008334C
			// (set) Token: 0x06001C34 RID: 7220 RVA: 0x0000AC25 File Offset: 0x00008E25
			public unsafe int next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Slot.NativeFieldInfoPtr_next);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Slot.NativeFieldInfoPtr_next)) = value;
				}
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x06001C35 RID: 7221 RVA: 0x00085174 File Offset: 0x00083374
			// (set) Token: 0x06001C36 RID: 7222 RVA: 0x0008519C File Offset: 0x0008339C
			public unsafe T value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Slot.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Slot.NativeFieldInfoPtr_value);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04001305 RID: 4869
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x04001306 RID: 4870
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04001307 RID: 4871
			private static readonly IntPtr NativeFieldInfoPtr_value;
		}

		// Token: 0x02000359 RID: 857
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06001C37 RID: 7223 RVA: 0x00085244 File Offset: 0x00083444
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HashSet<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr);
				HashSet<T>.Enumerator.NativeFieldInfoPtr__set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, "_set");
				HashSet<T>.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, "_index");
				HashSet<T>.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, "_version");
				HashSet<T>.Enumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, "_current");
				HashSet<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, 100666719);
				HashSet<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, 100666720);
				HashSet<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, 100666721);
				HashSet<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, 100666722);
				HashSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, 100666723);
				HashSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr, 100666724);
			}

			// Token: 0x06001C38 RID: 7224 RVA: 0x00085374 File Offset: 0x00083574
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1031324, RefRangeEnd = 1031332, XrefRangeStart = 1031323, XrefRangeEnd = 1031324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(HashSet<T> set)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_HashSet_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C39 RID: 7225 RVA: 0x000853C4 File Offset: 0x000835C4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C3A RID: 7226 RVA: 0x000853FC File Offset: 0x000835FC
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1031334, RefRangeEnd = 1031345, XrefRangeStart = 1031332, XrefRangeEnd = 1031334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x06001C3B RID: 7227 RVA: 0x00085440 File Offset: 0x00083640
			public unsafe T Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x06001C3C RID: 7228 RVA: 0x00085480 File Offset: 0x00083680
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1031345, XrefRangeEnd = 1031348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C3D RID: 7229 RVA: 0x000854C4 File Offset: 0x000836C4
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C3E RID: 7230 RVA: 0x0000AC40 File Offset: 0x00008E40
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C3F RID: 7231 RVA: 0x0000AC49 File Offset: 0x00008E49
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSet<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x06001C40 RID: 7232 RVA: 0x000854FC File Offset: 0x000836FC
			// (set) Token: 0x06001C41 RID: 7233 RVA: 0x0000AC5B File Offset: 0x00008E5B
			public unsafe HashSet<T> _set
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__set);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__set), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x06001C42 RID: 7234 RVA: 0x0008552C File Offset: 0x0008372C
			// (set) Token: 0x06001C43 RID: 7235 RVA: 0x0000AC7A File Offset: 0x00008E7A
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00085554 File Offset: 0x00083754
			// (set) Token: 0x06001C45 RID: 7237 RVA: 0x0000AC95 File Offset: 0x00008E95
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x06001C46 RID: 7238 RVA: 0x0008557C File Offset: 0x0008377C
			// (set) Token: 0x06001C47 RID: 7239 RVA: 0x000855A4 File Offset: 0x000837A4
			public unsafe T _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HashSet<T>.Enumerator.NativeFieldInfoPtr__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04001308 RID: 4872
			private static readonly IntPtr NativeFieldInfoPtr__set;

			// Token: 0x04001309 RID: 4873
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x0400130A RID: 4874
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x0400130B RID: 4875
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x0400130C RID: 4876
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HashSet_1_T_0;

			// Token: 0x0400130D RID: 4877
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400130E RID: 4878
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x0400130F RID: 4879
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04001310 RID: 4880
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001311 RID: 4881
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
