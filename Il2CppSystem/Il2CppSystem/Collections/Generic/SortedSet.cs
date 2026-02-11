using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000170 RID: 368
	[Serializable]
	public class SortedSet<T> : Object
	{
		// Token: 0x06001698 RID: 5784 RVA: 0x00074FAC File Offset: 0x000731AC
		// Note: this type is marked as 'beforefieldinit'.
		static SortedSet()
		{
			Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "SortedSet`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr);
			SortedSet<T>.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "root");
			SortedSet<T>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "comparer");
			SortedSet<T>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "count");
			SortedSet<T>.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "version");
			SortedSet<T>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "_syncRoot");
			SortedSet<T>.NativeFieldInfoPtr_siInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "siInfo");
			SortedSet<T>.NativeFieldInfoPtr_ComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "ComparerName");
			SortedSet<T>.NativeFieldInfoPtr_CountName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "CountName");
			SortedSet<T>.NativeFieldInfoPtr_ItemsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "ItemsName");
			SortedSet<T>.NativeFieldInfoPtr_VersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "VersionName");
			SortedSet<T>.NativeFieldInfoPtr_TreeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "TreeName");
			SortedSet<T>.NativeFieldInfoPtr_NodeValueName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "NodeValueName");
			SortedSet<T>.NativeFieldInfoPtr_EnumStartName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "EnumStartName");
			SortedSet<T>.NativeFieldInfoPtr_ReverseName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "ReverseName");
			SortedSet<T>.NativeFieldInfoPtr_EnumVersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "EnumVersionName");
			SortedSet<T>.NativeFieldInfoPtr_MinName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "MinName");
			SortedSet<T>.NativeFieldInfoPtr_MaxName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "MaxName");
			SortedSet<T>.NativeFieldInfoPtr_LowerBoundActiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "LowerBoundActiveName");
			SortedSet<T>.NativeFieldInfoPtr_UpperBoundActiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "UpperBoundActiveName");
			SortedSet<T>.NativeFieldInfoPtr_StackAllocThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "StackAllocThreshold");
			SortedSet<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666874);
			SortedSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666875);
			SortedSet<T>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666876);
			SortedSet<T>.NativeMethodInfoPtr_InOrderTreeWalk_Internal_Virtual_New_Boolean_TreeWalkPredicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666877);
			SortedSet<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666878);
			SortedSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666879);
			SortedSet<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666880);
			SortedSet<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666881);
			SortedSet<T>.NativeMethodInfoPtr_VersionCheck_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666882);
			SortedSet<T>.NativeMethodInfoPtr_IsWithinRange_Internal_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666883);
			SortedSet<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666884);
			SortedSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666885);
			SortedSet<T>.NativeMethodInfoPtr_AddIfNotPresent_Internal_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666886);
			SortedSet<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666887);
			SortedSet<T>.NativeMethodInfoPtr_DoRemove_Internal_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666888);
			SortedSet<T>.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666889);
			SortedSet<T>.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666890);
			SortedSet<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666891);
			SortedSet<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666892);
			SortedSet<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666893);
			SortedSet<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666894);
			SortedSet<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666895);
			SortedSet<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666896);
			SortedSet<T>.NativeMethodInfoPtr_InsertionBalance_Private_Void_Node_T_byref_Node_T_Node_T_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666897);
			SortedSet<T>.NativeMethodInfoPtr_ReplaceChildOrRoot_Private_Void_Node_T_Node_T_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666898);
			SortedSet<T>.NativeMethodInfoPtr_ReplaceNode_Private_Void_Node_T_Node_T_Node_T_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666899);
			SortedSet<T>.NativeMethodInfoPtr_FindNode_Internal_Virtual_New_Node_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666900);
			SortedSet<T>.NativeMethodInfoPtr_UpdateVersion_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666901);
			SortedSet<T>.NativeMethodInfoPtr_get_Min_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666902);
			SortedSet<T>.NativeMethodInfoPtr_get_MinInternal_Internal_Virtual_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666903);
			SortedSet<T>.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666904);
			SortedSet<T>.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666905);
			SortedSet<T>.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666906);
			SortedSet<T>.NativeMethodInfoPtr_OnDeserialization_Protected_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666907);
			SortedSet<T>.NativeMethodInfoPtr_Log2_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, 100666908);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00075464 File Offset: 0x00073664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469009, RefRangeEnd = 469010, XrefRangeStart = 469006, XrefRangeEnd = 469009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000754A0 File Offset: 0x000736A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469014, RefRangeEnd = 469015, XrefRangeStart = 469010, XrefRangeEnd = 469014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedSet(IComparer<T> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x000754EC File Offset: 0x000736EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469017, RefRangeEnd = 469018, XrefRangeStart = 469015, XrefRangeEnd = 469017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedSet(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00075550 File Offset: 0x00073750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469018, XrefRangeEnd = 469027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_InOrderTreeWalk_Internal_Virtual_New_Boolean_TreeWalkPredicate_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x000755A8 File Offset: 0x000737A8
		public unsafe virtual int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 469027, RefRangeEnd = 469028, XrefRangeStart = 469027, XrefRangeEnd = 469027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x000755E4 File Offset: 0x000737E4
		public unsafe virtual bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x00075620 File Offset: 0x00073820
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0007565C File Offset: 0x0007385C
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469028, XrefRangeEnd = 469033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x0007569C File Offset: 0x0007389C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void VersionCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_VersionCheck_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x000756D8 File Offset: 0x000738D8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsWithinRange(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_IsWithinRange_Internal_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00075768 File Offset: 0x00073968
		[CallerCount(0)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x000757EC File Offset: 0x000739EC
		[CallerCount(0)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00075864 File Offset: 0x00073A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469073, RefRangeEnd = 469074, XrefRangeStart = 469033, XrefRangeEnd = 469073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AddIfNotPresent(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_AddIfNotPresent_Internal_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000758F4 File Offset: 0x00073AF4
		[CallerCount(0)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00075978 File Offset: 0x00073B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469074, XrefRangeEnd = 469114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoRemove(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_DoRemove_Internal_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00075A08 File Offset: 0x00073C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469114, XrefRangeEnd = 469115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00075A44 File Offset: 0x00073C44
		[CallerCount(0)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00075AD4 File Offset: 0x00073CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469115, XrefRangeEnd = 469116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppArrayBase<T> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00075B24 File Offset: 0x00073D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469149, RefRangeEnd = 469150, XrefRangeStart = 469116, XrefRangeEnd = 469149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppArrayBase<T> array, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00075B84 File Offset: 0x00073D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469150, XrefRangeEnd = 469169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00075BD4 File Offset: 0x00073DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469170, RefRangeEnd = 469171, XrefRangeStart = 469169, XrefRangeEnd = 469170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedSet<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SortedSet<T>.Enumerator(intPtr);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00075C0C File Offset: 0x00073E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469171, XrefRangeEnd = 469173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00075C4C File Offset: 0x00073E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00075C8C File Offset: 0x00073E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469173, XrefRangeEnd = 469184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertionBalance(SortedSet<T>.Node current, ref SortedSet<T>.Node parent, SortedSet<T>.Node grandParent, SortedSet<T>.Node greatGrandParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grandParent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(greatGrandParent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_InsertionBalance_Private_Void_Node_T_byref_Node_T_Node_T_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parent = ((intPtr4 == 0) ? null : new SortedSet<T>.Node(intPtr4));
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00075D1C File Offset: 0x00073F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469184, XrefRangeEnd = 469186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceChildOrRoot(SortedSet<T>.Node parent, SortedSet<T>.Node child, SortedSet<T>.Node newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(child);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newChild);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_ReplaceChildOrRoot_Private_Void_Node_T_Node_T_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00075D84 File Offset: 0x00073F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469186, XrefRangeEnd = 469193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceNode(SortedSet<T>.Node match, SortedSet<T>.Node parentOfMatch, SortedSet<T>.Node successor, SortedSet<T>.Node parentOfSuccessor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentOfMatch);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(successor);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentOfSuccessor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_ReplaceNode_Private_Void_Node_T_Node_T_Node_T_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00075E00 File Offset: 0x00074000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469193, XrefRangeEnd = 469197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SortedSet<T>.Node FindNode(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_FindNode_Internal_Virtual_New_Node_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr4) : null;
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00075E94 File Offset: 0x00074094
		[CallerCount(0)]
		public unsafe void UpdateVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_UpdateVersion_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x00075EC8 File Offset: 0x000740C8
		public unsafe T Min
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_get_Min_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x00075F04 File Offset: 0x00074104
		public unsafe virtual T MinInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469197, XrefRangeEnd = 469198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_get_MinInternal_Internal_Virtual_New_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00075F48 File Offset: 0x00074148
		[CallerCount(0)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00075FA4 File Offset: 0x000741A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469198, XrefRangeEnd = 469220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00076008 File Offset: 0x00074208
		[CallerCount(0)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0007604C File Offset: 0x0007424C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469220, XrefRangeEnd = 469250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedSet<T>.NativeMethodInfoPtr_OnDeserialization_Protected_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0007609C File Offset: 0x0007429C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469250, RefRangeEnd = 469251, XrefRangeStart = 469250, XrefRangeEnd = 469250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Log2(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.NativeMethodInfoPtr_Log2_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00009C0B File Offset: 0x00007E0B
		public SortedSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x000760DC File Offset: 0x000742DC
		// (set) Token: 0x060016BE RID: 5822 RVA: 0x00009C14 File Offset: 0x00007E14
		public unsafe SortedSet<T>.Node root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x0007610C File Offset: 0x0007430C
		// (set) Token: 0x060016C0 RID: 5824 RVA: 0x00009C33 File Offset: 0x00007E33
		public unsafe IComparer<T> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x0007613C File Offset: 0x0007433C
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x00009C52 File Offset: 0x00007E52
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x00076164 File Offset: 0x00074364
		// (set) Token: 0x060016C4 RID: 5828 RVA: 0x00009C6D File Offset: 0x00007E6D
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x0007618C File Offset: 0x0007438C
		// (set) Token: 0x060016C6 RID: 5830 RVA: 0x00009C88 File Offset: 0x00007E88
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x000761BC File Offset: 0x000743BC
		// (set) Token: 0x060016C8 RID: 5832 RVA: 0x00009CA7 File Offset: 0x00007EA7
		public unsafe SerializationInfo siInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_siInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.NativeFieldInfoPtr_siInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060016C9 RID: 5833 RVA: 0x000761EC File Offset: 0x000743EC
		// (set) Token: 0x060016CA RID: 5834 RVA: 0x00009CC6 File Offset: 0x00007EC6
		public unsafe static string ComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_ComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_ComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x0007620C File Offset: 0x0007440C
		// (set) Token: 0x060016CC RID: 5836 RVA: 0x00009CD8 File Offset: 0x00007ED8
		public unsafe static string CountName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_CountName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_CountName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x0007622C File Offset: 0x0007442C
		// (set) Token: 0x060016CE RID: 5838 RVA: 0x00009CEA File Offset: 0x00007EEA
		public unsafe static string ItemsName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_ItemsName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_ItemsName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x0007624C File Offset: 0x0007444C
		// (set) Token: 0x060016D0 RID: 5840 RVA: 0x00009CFC File Offset: 0x00007EFC
		public unsafe static string VersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_VersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_VersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x0007626C File Offset: 0x0007446C
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x00009D0E File Offset: 0x00007F0E
		public unsafe static string TreeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_TreeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_TreeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x0007628C File Offset: 0x0007448C
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x00009D20 File Offset: 0x00007F20
		public unsafe static string NodeValueName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_NodeValueName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_NodeValueName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x000762AC File Offset: 0x000744AC
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x00009D32 File Offset: 0x00007F32
		public unsafe static string EnumStartName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_EnumStartName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_EnumStartName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x000762CC File Offset: 0x000744CC
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x00009D44 File Offset: 0x00007F44
		public unsafe static string ReverseName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_ReverseName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_ReverseName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x000762EC File Offset: 0x000744EC
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x00009D56 File Offset: 0x00007F56
		public unsafe static string EnumVersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_EnumVersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_EnumVersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x0007630C File Offset: 0x0007450C
		// (set) Token: 0x060016DC RID: 5852 RVA: 0x00009D68 File Offset: 0x00007F68
		public unsafe static string MinName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_MinName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_MinName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x0007632C File Offset: 0x0007452C
		// (set) Token: 0x060016DE RID: 5854 RVA: 0x00009D7A File Offset: 0x00007F7A
		public unsafe static string MaxName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_MaxName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_MaxName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x0007634C File Offset: 0x0007454C
		// (set) Token: 0x060016E0 RID: 5856 RVA: 0x00009D8C File Offset: 0x00007F8C
		public unsafe static string LowerBoundActiveName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_LowerBoundActiveName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_LowerBoundActiveName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x0007636C File Offset: 0x0007456C
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x00009D9E File Offset: 0x00007F9E
		public unsafe static string UpperBoundActiveName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_UpperBoundActiveName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_UpperBoundActiveName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x0007638C File Offset: 0x0007458C
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x00009DB0 File Offset: 0x00007FB0
		public unsafe static int StackAllocThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.NativeFieldInfoPtr_StackAllocThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.NativeFieldInfoPtr_StackAllocThreshold, (void*)(&value));
			}
		}

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeFieldInfoPtr_siInfo;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeFieldInfoPtr_ComparerName;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeFieldInfoPtr_CountName;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeFieldInfoPtr_ItemsName;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeFieldInfoPtr_VersionName;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeFieldInfoPtr_TreeName;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeFieldInfoPtr_NodeValueName;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeFieldInfoPtr_EnumStartName;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeFieldInfoPtr_ReverseName;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeFieldInfoPtr_EnumVersionName;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeFieldInfoPtr_MinName;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeFieldInfoPtr_MaxName;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeFieldInfoPtr_LowerBoundActiveName;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeFieldInfoPtr_UpperBoundActiveName;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeFieldInfoPtr_StackAllocThreshold;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_T_0;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr_InOrderTreeWalk_Internal_Virtual_New_Boolean_TreeWalkPredicate_1_T_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeMethodInfoPtr_VersionCheck_Internal_Virtual_New_Void_0;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr_IsWithinRange_Internal_Virtual_New_Boolean_T_0;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_AddIfNotPresent_Internal_Virtual_New_Boolean_T_0;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeMethodInfoPtr_DoRemove_Internal_Virtual_New_Boolean_T_0;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_T_0;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr_InsertionBalance_Private_Void_Node_T_byref_Node_T_Node_T_Node_T_0;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceChildOrRoot_Private_Void_Node_T_Node_T_Node_T_0;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceNode_Private_Void_Node_T_Node_T_Node_T_Node_T_0;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr_FindNode_Internal_Virtual_New_Node_T_T_0;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVersion_Internal_Void_0;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr_get_Min_Public_get_T_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr_get_MinInternal_Internal_Virtual_New_get_T_0;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Protected_Virtual_New_Void_Object_0;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_Log2_Private_Static_Int32_Int32_0;

		// Token: 0x02000302 RID: 770
		[Serializable]
		public sealed class Node : Object
		{
			// Token: 0x06002DF5 RID: 11765 RVA: 0x000C9FF8 File Offset: 0x000C81F8
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "Node"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr);
				SortedSet<T>.Node.NativeFieldInfoPtr__Item_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, "<Item>k__BackingField");
				SortedSet<T>.Node.NativeFieldInfoPtr__Left_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, "<Left>k__BackingField");
				SortedSet<T>.Node.NativeFieldInfoPtr__Right_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, "<Right>k__BackingField");
				SortedSet<T>.Node.NativeFieldInfoPtr__Color_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, "<Color>k__BackingField");
				SortedSet<T>.Node.NativeMethodInfoPtr__ctor_Public_Void_T_NodeColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666909);
				SortedSet<T>.Node.NativeMethodInfoPtr_IsNonNullRed_Public_Static_Boolean_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666910);
				SortedSet<T>.Node.NativeMethodInfoPtr_IsNullOrBlack_Public_Static_Boolean_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666911);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_Item_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666912);
				SortedSet<T>.Node.NativeMethodInfoPtr_set_Item_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666913);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_Left_Public_get_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666914);
				SortedSet<T>.Node.NativeMethodInfoPtr_set_Left_Public_set_Void_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666915);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_Right_Public_get_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666916);
				SortedSet<T>.Node.NativeMethodInfoPtr_set_Right_Public_set_Void_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666917);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_Color_Public_get_NodeColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666918);
				SortedSet<T>.Node.NativeMethodInfoPtr_set_Color_Public_set_Void_NodeColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666919);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_IsBlack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666920);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_IsRed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666921);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_Is2Node_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666922);
				SortedSet<T>.Node.NativeMethodInfoPtr_get_Is4Node_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666923);
				SortedSet<T>.Node.NativeMethodInfoPtr_ColorBlack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666924);
				SortedSet<T>.Node.NativeMethodInfoPtr_ColorRed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666925);
				SortedSet<T>.Node.NativeMethodInfoPtr_GetRotation_Public_TreeRotation_Node_T_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666926);
				SortedSet<T>.Node.NativeMethodInfoPtr_GetSibling_Public_Node_T_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666927);
				SortedSet<T>.Node.NativeMethodInfoPtr_Split4Node_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666928);
				SortedSet<T>.Node.NativeMethodInfoPtr_Rotate_Public_Node_T_TreeRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666929);
				SortedSet<T>.Node.NativeMethodInfoPtr_RotateLeft_Public_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666930);
				SortedSet<T>.Node.NativeMethodInfoPtr_RotateLeftRight_Public_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666931);
				SortedSet<T>.Node.NativeMethodInfoPtr_RotateRight_Public_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666932);
				SortedSet<T>.Node.NativeMethodInfoPtr_RotateRightLeft_Public_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666933);
				SortedSet<T>.Node.NativeMethodInfoPtr_Merge2Nodes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666934);
				SortedSet<T>.Node.NativeMethodInfoPtr_ReplaceChild_Public_Void_Node_T_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr, 100666935);
			}

			// Token: 0x06002DF6 RID: 11766 RVA: 0x000CA2CC File Offset: 0x000C84CC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 468853, RefRangeEnd = 468855, XrefRangeStart = 468851, XrefRangeEnd = 468853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node(T item, NodeColor color)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.Node>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
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
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr__ctor_Public_Void_T_NodeColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x06002DF7 RID: 11767 RVA: 0x000CA35C File Offset: 0x000C855C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 468855, RefRangeEnd = 468856, XrefRangeStart = 468855, XrefRangeEnd = 468855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsNonNullRed(SortedSet<T>.Node node)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_IsNonNullRed_Public_Static_Boolean_Node_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002DF8 RID: 11768 RVA: 0x000CA3A0 File Offset: 0x000C85A0
			[CallerCount(0)]
			public unsafe static bool IsNullOrBlack(SortedSet<T>.Node node)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_IsNullOrBlack_Public_Static_Boolean_Node_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E73 RID: 3699
			// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x000CA3E4 File Offset: 0x000C85E4
			// (set) Token: 0x06002DFA RID: 11770 RVA: 0x000CA420 File Offset: 0x000C8620
			public unsafe T Item
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_Item_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468856, XrefRangeEnd = 468857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
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
						IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_set_Item_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
						Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					}
				}
			}

			// Token: 0x17000E74 RID: 3700
			// (get) Token: 0x06002DFB RID: 11771 RVA: 0x000CA498 File Offset: 0x000C8698
			// (set) Token: 0x06002DFC RID: 11772 RVA: 0x000CA4D8 File Offset: 0x000C86D8
			public unsafe SortedSet<T>.Node Left
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_Left_Public_get_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_set_Left_Public_set_Void_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000E75 RID: 3701
			// (get) Token: 0x06002DFD RID: 11773 RVA: 0x000CA51C File Offset: 0x000C871C
			// (set) Token: 0x06002DFE RID: 11774 RVA: 0x000CA55C File Offset: 0x000C875C
			public unsafe SortedSet<T>.Node Right
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_Right_Public_get_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_set_Right_Public_set_Void_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000E76 RID: 3702
			// (get) Token: 0x06002DFF RID: 11775 RVA: 0x000CA5A0 File Offset: 0x000C87A0
			// (set) Token: 0x06002E00 RID: 11776 RVA: 0x000CA5DC File Offset: 0x000C87DC
			public unsafe NodeColor Color
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_Color_Public_get_NodeColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_set_Color_Public_set_Void_NodeColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000E77 RID: 3703
			// (get) Token: 0x06002E01 RID: 11777 RVA: 0x000CA61C File Offset: 0x000C881C
			public unsafe bool IsBlack
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_IsBlack_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E78 RID: 3704
			// (get) Token: 0x06002E02 RID: 11778 RVA: 0x000CA658 File Offset: 0x000C8858
			public unsafe bool IsRed
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 468857, RefRangeEnd = 468859, XrefRangeStart = 468857, XrefRangeEnd = 468857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_IsRed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E79 RID: 3705
			// (get) Token: 0x06002E03 RID: 11779 RVA: 0x000CA694 File Offset: 0x000C8894
			public unsafe bool Is2Node
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 468860, RefRangeEnd = 468862, XrefRangeStart = 468859, XrefRangeEnd = 468860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_Is2Node_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E7A RID: 3706
			// (get) Token: 0x06002E04 RID: 11780 RVA: 0x000CA6D0 File Offset: 0x000C88D0
			public unsafe bool Is4Node
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 468864, RefRangeEnd = 468865, XrefRangeStart = 468862, XrefRangeEnd = 468864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_get_Is4Node_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002E05 RID: 11781 RVA: 0x000CA70C File Offset: 0x000C890C
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 364726, RefRangeEnd = 364739, XrefRangeStart = 364726, XrefRangeEnd = 364739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ColorBlack()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_ColorBlack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E06 RID: 11782 RVA: 0x000CA740 File Offset: 0x000C8940
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 468865, RefRangeEnd = 468871, XrefRangeStart = 468865, XrefRangeEnd = 468865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ColorRed()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_ColorRed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E07 RID: 11783 RVA: 0x000CA774 File Offset: 0x000C8974
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 468872, RefRangeEnd = 468873, XrefRangeStart = 468871, XrefRangeEnd = 468872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TreeRotation GetRotation(SortedSet<T>.Node current, SortedSet<T>.Node sibling)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sibling);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_GetRotation_Public_TreeRotation_Node_T_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002E08 RID: 11784 RVA: 0x000CA7D4 File Offset: 0x000C89D4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 468873, RefRangeEnd = 468875, XrefRangeStart = 468873, XrefRangeEnd = 468873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SortedSet<T>.Node GetSibling(SortedSet<T>.Node node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_GetSibling_Public_Node_T_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
				}
			}

			// Token: 0x06002E09 RID: 11785 RVA: 0x000CA824 File Offset: 0x000C8A24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 468875, RefRangeEnd = 468876, XrefRangeStart = 468875, XrefRangeEnd = 468875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Split4Node()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_Split4Node_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E0A RID: 11786 RVA: 0x000CA858 File Offset: 0x000C8A58
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 468876, RefRangeEnd = 468877, XrefRangeStart = 468876, XrefRangeEnd = 468876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SortedSet<T>.Node Rotate(TreeRotation rotation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref rotation;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_Rotate_Public_Node_T_TreeRotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
				}
			}

			// Token: 0x06002E0B RID: 11787 RVA: 0x000CA8A4 File Offset: 0x000C8AA4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 468879, RefRangeEnd = 468883, XrefRangeStart = 468877, XrefRangeEnd = 468879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SortedSet<T>.Node RotateLeft()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_RotateLeft_Public_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
			}

			// Token: 0x06002E0C RID: 11788 RVA: 0x000CA8E4 File Offset: 0x000C8AE4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 468887, RefRangeEnd = 468890, XrefRangeStart = 468883, XrefRangeEnd = 468887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SortedSet<T>.Node RotateLeftRight()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_RotateLeftRight_Public_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
			}

			// Token: 0x06002E0D RID: 11789 RVA: 0x000CA924 File Offset: 0x000C8B24
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 468892, RefRangeEnd = 468896, XrefRangeStart = 468890, XrefRangeEnd = 468892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SortedSet<T>.Node RotateRight()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_RotateRight_Public_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
			}

			// Token: 0x06002E0E RID: 11790 RVA: 0x000CA964 File Offset: 0x000C8B64
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 468900, RefRangeEnd = 468903, XrefRangeStart = 468896, XrefRangeEnd = 468900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SortedSet<T>.Node RotateRightLeft()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_RotateRightLeft_Public_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr3) : null;
			}

			// Token: 0x06002E0F RID: 11791 RVA: 0x000CA9A4 File Offset: 0x000C8BA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 468903, RefRangeEnd = 468904, XrefRangeStart = 468903, XrefRangeEnd = 468903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Merge2Nodes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_Merge2Nodes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E10 RID: 11792 RVA: 0x000CA9D8 File Offset: 0x000C8BD8
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 468906, RefRangeEnd = 468912, XrefRangeStart = 468904, XrefRangeEnd = 468906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ReplaceChild(SortedSet<T>.Node child, SortedSet<T>.Node newChild)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Node.NativeMethodInfoPtr_ReplaceChild_Public_Void_Node_T_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E11 RID: 11793 RVA: 0x000148C6 File Offset: 0x00012AC6
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E6F RID: 3695
			// (get) Token: 0x06002E12 RID: 11794 RVA: 0x000CAA2C File Offset: 0x000C8C2C
			// (set) Token: 0x06002E13 RID: 11795 RVA: 0x000CAA54 File Offset: 0x000C8C54
			public unsafe T _Item_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Item_k__BackingField);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Item_k__BackingField);
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

			// Token: 0x17000E70 RID: 3696
			// (get) Token: 0x06002E14 RID: 11796 RVA: 0x000CAAFC File Offset: 0x000C8CFC
			// (set) Token: 0x06002E15 RID: 11797 RVA: 0x000148CF File Offset: 0x00012ACF
			public unsafe SortedSet<T>.Node _Left_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Left_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Left_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E71 RID: 3697
			// (get) Token: 0x06002E16 RID: 11798 RVA: 0x000CAB2C File Offset: 0x000C8D2C
			// (set) Token: 0x06002E17 RID: 11799 RVA: 0x000148EE File Offset: 0x00012AEE
			public unsafe SortedSet<T>.Node _Right_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Right_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Right_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E72 RID: 3698
			// (get) Token: 0x06002E18 RID: 11800 RVA: 0x000CAB5C File Offset: 0x000C8D5C
			// (set) Token: 0x06002E19 RID: 11801 RVA: 0x0001490D File Offset: 0x00012B0D
			public unsafe NodeColor _Color_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Color_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Node.NativeFieldInfoPtr__Color_k__BackingField)) = value;
				}
			}

			// Token: 0x04002417 RID: 9239
			private static readonly IntPtr NativeFieldInfoPtr__Item_k__BackingField;

			// Token: 0x04002418 RID: 9240
			private static readonly IntPtr NativeFieldInfoPtr__Left_k__BackingField;

			// Token: 0x04002419 RID: 9241
			private static readonly IntPtr NativeFieldInfoPtr__Right_k__BackingField;

			// Token: 0x0400241A RID: 9242
			private static readonly IntPtr NativeFieldInfoPtr__Color_k__BackingField;

			// Token: 0x0400241B RID: 9243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_NodeColor_0;

			// Token: 0x0400241C RID: 9244
			private static readonly IntPtr NativeMethodInfoPtr_IsNonNullRed_Public_Static_Boolean_Node_T_0;

			// Token: 0x0400241D RID: 9245
			private static readonly IntPtr NativeMethodInfoPtr_IsNullOrBlack_Public_Static_Boolean_Node_T_0;

			// Token: 0x0400241E RID: 9246
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_0;

			// Token: 0x0400241F RID: 9247
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_T_0;

			// Token: 0x04002420 RID: 9248
			private static readonly IntPtr NativeMethodInfoPtr_get_Left_Public_get_Node_T_0;

			// Token: 0x04002421 RID: 9249
			private static readonly IntPtr NativeMethodInfoPtr_set_Left_Public_set_Void_Node_T_0;

			// Token: 0x04002422 RID: 9250
			private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Node_T_0;

			// Token: 0x04002423 RID: 9251
			private static readonly IntPtr NativeMethodInfoPtr_set_Right_Public_set_Void_Node_T_0;

			// Token: 0x04002424 RID: 9252
			private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_NodeColor_0;

			// Token: 0x04002425 RID: 9253
			private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_NodeColor_0;

			// Token: 0x04002426 RID: 9254
			private static readonly IntPtr NativeMethodInfoPtr_get_IsBlack_Public_get_Boolean_0;

			// Token: 0x04002427 RID: 9255
			private static readonly IntPtr NativeMethodInfoPtr_get_IsRed_Public_get_Boolean_0;

			// Token: 0x04002428 RID: 9256
			private static readonly IntPtr NativeMethodInfoPtr_get_Is2Node_Public_get_Boolean_0;

			// Token: 0x04002429 RID: 9257
			private static readonly IntPtr NativeMethodInfoPtr_get_Is4Node_Public_get_Boolean_0;

			// Token: 0x0400242A RID: 9258
			private static readonly IntPtr NativeMethodInfoPtr_ColorBlack_Public_Void_0;

			// Token: 0x0400242B RID: 9259
			private static readonly IntPtr NativeMethodInfoPtr_ColorRed_Public_Void_0;

			// Token: 0x0400242C RID: 9260
			private static readonly IntPtr NativeMethodInfoPtr_GetRotation_Public_TreeRotation_Node_T_Node_T_0;

			// Token: 0x0400242D RID: 9261
			private static readonly IntPtr NativeMethodInfoPtr_GetSibling_Public_Node_T_Node_T_0;

			// Token: 0x0400242E RID: 9262
			private static readonly IntPtr NativeMethodInfoPtr_Split4Node_Public_Void_0;

			// Token: 0x0400242F RID: 9263
			private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Node_T_TreeRotation_0;

			// Token: 0x04002430 RID: 9264
			private static readonly IntPtr NativeMethodInfoPtr_RotateLeft_Public_Node_T_0;

			// Token: 0x04002431 RID: 9265
			private static readonly IntPtr NativeMethodInfoPtr_RotateLeftRight_Public_Node_T_0;

			// Token: 0x04002432 RID: 9266
			private static readonly IntPtr NativeMethodInfoPtr_RotateRight_Public_Node_T_0;

			// Token: 0x04002433 RID: 9267
			private static readonly IntPtr NativeMethodInfoPtr_RotateRightLeft_Public_Node_T_0;

			// Token: 0x04002434 RID: 9268
			private static readonly IntPtr NativeMethodInfoPtr_Merge2Nodes_Public_Void_0;

			// Token: 0x04002435 RID: 9269
			private static readonly IntPtr NativeMethodInfoPtr_ReplaceChild_Public_Void_Node_T_Node_T_0;
		}

		// Token: 0x02000303 RID: 771
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06002E1A RID: 11802 RVA: 0x000CAB84 File Offset: 0x000C8D84
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr);
				SortedSet<T>.Enumerator.NativeFieldInfoPtr_s_dummyNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, "s_dummyNode");
				SortedSet<T>.Enumerator.NativeFieldInfoPtr__tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, "_tree");
				SortedSet<T>.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, "_version");
				SortedSet<T>.Enumerator.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, "_stack");
				SortedSet<T>.Enumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, "_current");
				SortedSet<T>.Enumerator.NativeFieldInfoPtr__reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, "_reverse");
				SortedSet<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100666936);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedSet_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100666937);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100666938);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100666939);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100666940);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100666941);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100666942);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100666943);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100666944);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_get_NotStartedOrEnded_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100666945);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100666946);
				SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr, 100666947);
			}

			// Token: 0x06002E1B RID: 11803 RVA: 0x000CAD54 File Offset: 0x000C8F54
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 468919, RefRangeEnd = 468922, XrefRangeStart = 468912, XrefRangeEnd = 468919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(SortedSet<T> set)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedSet_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E1C RID: 11804 RVA: 0x000CADA4 File Offset: 0x000C8FA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 468940, RefRangeEnd = 468941, XrefRangeStart = 468922, XrefRangeEnd = 468940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(SortedSet<T> set, bool reverse)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedSet_1_T_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E1D RID: 11805 RVA: 0x000CAE04 File Offset: 0x000C9004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E1E RID: 11806 RVA: 0x000CAE64 File Offset: 0x000C9064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E1F RID: 11807 RVA: 0x000CAEAC File Offset: 0x000C90AC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 468954, RefRangeEnd = 468956, XrefRangeStart = 468941, XrefRangeEnd = 468954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Initialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E20 RID: 11808 RVA: 0x000CAEE4 File Offset: 0x000C90E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 468974, RefRangeEnd = 468975, XrefRangeStart = 468956, XrefRangeEnd = 468974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002E21 RID: 11809 RVA: 0x000CAF28 File Offset: 0x000C9128
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E81 RID: 3713
			// (get) Token: 0x06002E22 RID: 11810 RVA: 0x000CAF60 File Offset: 0x000C9160
			public unsafe T Current
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 468975, RefRangeEnd = 468978, XrefRangeStart = 468975, XrefRangeEnd = 468975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x17000E82 RID: 3714
			// (get) Token: 0x06002E23 RID: 11811 RVA: 0x000CAFA0 File Offset: 0x000C91A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468978, XrefRangeEnd = 468981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000E83 RID: 3715
			// (get) Token: 0x06002E24 RID: 11812 RVA: 0x000CAFE4 File Offset: 0x000C91E4
			public unsafe bool NotStartedOrEnded
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 468981, RefRangeEnd = 468982, XrefRangeStart = 468981, XrefRangeEnd = 468981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_get_NotStartedOrEnded_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002E25 RID: 11813 RVA: 0x000CB028 File Offset: 0x000C9228
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 468995, RefRangeEnd = 468997, XrefRangeStart = 468982, XrefRangeEnd = 468995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E26 RID: 11814 RVA: 0x000CB060 File Offset: 0x000C9260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468997, XrefRangeEnd = 469002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E27 RID: 11815 RVA: 0x00014928 File Offset: 0x00012B28
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002E28 RID: 11816 RVA: 0x00014931 File Offset: 0x00012B31
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x17000E7B RID: 3707
			// (get) Token: 0x06002E29 RID: 11817 RVA: 0x000CB098 File Offset: 0x000C9298
			// (set) Token: 0x06002E2A RID: 11818 RVA: 0x00014943 File Offset: 0x00012B43
			public unsafe static SortedSet<T>.Node s_dummyNode
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SortedSet<T>.Enumerator.NativeFieldInfoPtr_s_dummyNode, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SortedSet<T>.Enumerator.NativeFieldInfoPtr_s_dummyNode, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E7C RID: 3708
			// (get) Token: 0x06002E2B RID: 11819 RVA: 0x000CB0C0 File Offset: 0x000C92C0
			// (set) Token: 0x06002E2C RID: 11820 RVA: 0x00014955 File Offset: 0x00012B55
			public unsafe SortedSet<T> _tree
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__tree);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__tree), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E7D RID: 3709
			// (get) Token: 0x06002E2D RID: 11821 RVA: 0x000CB0F0 File Offset: 0x000C92F0
			// (set) Token: 0x06002E2E RID: 11822 RVA: 0x00014974 File Offset: 0x00012B74
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x17000E7E RID: 3710
			// (get) Token: 0x06002E2F RID: 11823 RVA: 0x000CB118 File Offset: 0x000C9318
			// (set) Token: 0x06002E30 RID: 11824 RVA: 0x0001498F File Offset: 0x00012B8F
			public unsafe Stack<SortedSet<T>.Node> _stack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__stack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<SortedSet<T>.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E7F RID: 3711
			// (get) Token: 0x06002E31 RID: 11825 RVA: 0x000CB148 File Offset: 0x000C9348
			// (set) Token: 0x06002E32 RID: 11826 RVA: 0x000149AE File Offset: 0x00012BAE
			public unsafe SortedSet<T>.Node _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedSet<T>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E80 RID: 3712
			// (get) Token: 0x06002E33 RID: 11827 RVA: 0x000CB178 File Offset: 0x000C9378
			// (set) Token: 0x06002E34 RID: 11828 RVA: 0x000149CD File Offset: 0x00012BCD
			public unsafe bool _reverse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__reverse);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.Enumerator.NativeFieldInfoPtr__reverse)) = value;
				}
			}

			// Token: 0x04002436 RID: 9270
			private static readonly IntPtr NativeFieldInfoPtr_s_dummyNode;

			// Token: 0x04002437 RID: 9271
			private static readonly IntPtr NativeFieldInfoPtr__tree;

			// Token: 0x04002438 RID: 9272
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04002439 RID: 9273
			private static readonly IntPtr NativeFieldInfoPtr__stack;

			// Token: 0x0400243A RID: 9274
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x0400243B RID: 9275
			private static readonly IntPtr NativeFieldInfoPtr__reverse;

			// Token: 0x0400243C RID: 9276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedSet_1_T_0;

			// Token: 0x0400243D RID: 9277
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedSet_1_T_Boolean_0;

			// Token: 0x0400243E RID: 9278
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x0400243F RID: 9279
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

			// Token: 0x04002440 RID: 9280
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

			// Token: 0x04002441 RID: 9281
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04002442 RID: 9282
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002443 RID: 9283
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04002444 RID: 9284
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002445 RID: 9285
			private static readonly IntPtr NativeMethodInfoPtr_get_NotStartedOrEnded_Internal_get_Boolean_0;

			// Token: 0x04002446 RID: 9286
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

			// Token: 0x04002447 RID: 9287
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000304 RID: 772
		[ObfuscatedName("System.Collections.Generic.SortedSet`1+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : Object
		{
			// Token: 0x06002E35 RID: 11829 RVA: 0x000CB1A0 File Offset: 0x000C93A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "<>c__DisplayClass52_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr);
				SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr, "index");
				SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr, "count");
				SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr, "array");
				SortedSet<T>.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr, 100666949);
				SortedSet<T>.__c__DisplayClass52_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr, 100666950);
			}

			// Token: 0x06002E36 RID: 11830 RVA: 0x000CB26C File Offset: 0x000C946C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E37 RID: 11831 RVA: 0x000CB2A8 File Offset: 0x000C94A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469002, XrefRangeEnd = 469003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CopyTo_b__0(SortedSet<T>.Node node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.__c__DisplayClass52_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002E38 RID: 11832 RVA: 0x000149E8 File Offset: 0x00012BE8
			public __c__DisplayClass52_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E84 RID: 3716
			// (get) Token: 0x06002E39 RID: 11833 RVA: 0x000CB2F8 File Offset: 0x000C94F8
			// (set) Token: 0x06002E3A RID: 11834 RVA: 0x000149F1 File Offset: 0x00012BF1
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17000E85 RID: 3717
			// (get) Token: 0x06002E3B RID: 11835 RVA: 0x000CB320 File Offset: 0x000C9520
			// (set) Token: 0x06002E3C RID: 11836 RVA: 0x00014A0C File Offset: 0x00012C0C
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17000E86 RID: 3718
			// (get) Token: 0x06002E3D RID: 11837 RVA: 0x000CB348 File Offset: 0x000C9548
			// (set) Token: 0x06002E3E RID: 11838 RVA: 0x00014A27 File Offset: 0x00012C27
			public unsafe Il2CppArrayBase<T> array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_array);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass52_0.NativeFieldInfoPtr_array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002448 RID: 9288
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04002449 RID: 9289
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x0400244A RID: 9290
			private static readonly IntPtr NativeFieldInfoPtr_array;

			// Token: 0x0400244B RID: 9291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400244C RID: 9292
			private static readonly IntPtr NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_T_0;
		}

		// Token: 0x02000305 RID: 773
		[ObfuscatedName("System.Collections.Generic.SortedSet`1+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Object
		{
			// Token: 0x06002E3F RID: 11839 RVA: 0x000CB370 File Offset: 0x000C9570
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedSet<T>>.NativeClassPtr, "<>c__DisplayClass53_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_0>.NativeClassPtr);
				SortedSet<T>.__c__DisplayClass53_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_0>.NativeClassPtr, "index");
				SortedSet<T>.__c__DisplayClass53_0.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_0>.NativeClassPtr, "objects");
				SortedSet<T>.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_0>.NativeClassPtr, 100666951);
				SortedSet<T>.__c__DisplayClass53_0.NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_0>.NativeClassPtr, 100666952);
			}

			// Token: 0x06002E40 RID: 11840 RVA: 0x000CB428 File Offset: 0x000C9628
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedSet<T>.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E41 RID: 11841 RVA: 0x000CB464 File Offset: 0x000C9664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469003, XrefRangeEnd = 469006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _System_Collections_ICollection_CopyTo_b__0(SortedSet<T>.Node node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedSet<T>.__c__DisplayClass53_0.NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002E42 RID: 11842 RVA: 0x00014A46 File Offset: 0x00012C46
			public __c__DisplayClass53_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E87 RID: 3719
			// (get) Token: 0x06002E43 RID: 11843 RVA: 0x000CB4B4 File Offset: 0x000C96B4
			// (set) Token: 0x06002E44 RID: 11844 RVA: 0x00014A4F File Offset: 0x00012C4F
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass53_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass53_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17000E88 RID: 3720
			// (get) Token: 0x06002E45 RID: 11845 RVA: 0x000CB4DC File Offset: 0x000C96DC
			// (set) Token: 0x06002E46 RID: 11846 RVA: 0x00014A6A File Offset: 0x00012C6A
			public unsafe Il2CppReferenceArray<Object> objects
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass53_0.NativeFieldInfoPtr_objects);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedSet<T>.__c__DisplayClass53_0.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400244D RID: 9293
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400244E RID: 9294
			private static readonly IntPtr NativeFieldInfoPtr_objects;

			// Token: 0x0400244F RID: 9295
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002450 RID: 9296
			private static readonly IntPtr NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_T_0;
		}
	}
}
