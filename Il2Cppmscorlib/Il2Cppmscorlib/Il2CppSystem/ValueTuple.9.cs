using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;

namespace Il2CppSystem
{
	// Token: 0x0200010C RID: 268
	[Serializable]
	public sealed class ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : ValueType where TRest : new()
	{
		// Token: 0x060011F8 RID: 4600 RVA: 0x0007C0E8 File Offset: 0x0007A2E8
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTuple()
		{
			Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ValueTuple`8"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRest>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, "Item1");
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, "Item2");
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, "Item3");
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, "Item4");
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, "Item5");
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, "Item6");
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, "Item7");
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Rest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, "Rest");
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_T4_T5_T6_T7_TRest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666438);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666439);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_8_T1_T2_T3_T4_T5_T6_T7_TRest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666440);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666441);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666442);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_8_T1_T2_T3_T4_T5_T6_T7_TRest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666443);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666444);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666445);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666446);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_GetHashCodeCore_Private_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666447);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_IValueTupleInternal_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666448);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666449);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_IValueTupleInternal_ToStringEnd_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666450);
			ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_Runtime_CompilerServices_ITuple_get_Length_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr, 100666451);
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0007C38C File Offset: 0x0007A58C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1331981, RefRangeEnd = 1331982, XrefRangeStart = 1331979, XrefRangeEnd = 1331981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = item1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = item2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref item2;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = item3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref item3;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T4).IsValueType)
			{
				T4 t4 = item4;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref item4;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T5).IsValueType)
			{
				T5 t5 = item5;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref item5;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T6).IsValueType)
			{
				T6 t6 = item6;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref item6;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T7).IsValueType)
			{
				T7 t7 = item7;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref item7;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(TRest).IsValueType)
			{
				TRest trest = rest;
				intPtr8 = ((trest is string) ? IL2CPP.ManagedStringToIl2Cpp(trest as string) : IL2CPP.Il2CppObjectBaseToPtr(trest as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref rest;
			}
			ptr9 = intPtr8;
			IntPtr intPtr10;
			IntPtr intPtr9 = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_T4_T5_T6_T7_TRest_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr10);
			Il2CppException.RaiseExceptionIfNecessary(intPtr10);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0007C610 File Offset: 0x0007A810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1331982, XrefRangeEnd = 1331989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0007C664 File Offset: 0x0007A864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1332025, RefRangeEnd = 1332026, XrefRangeStart = 1331989, XrefRangeEnd = 1332025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_8_T1_T2_T3_T4_T5_T6_T7_TRest_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0007C6BC File Offset: 0x0007A8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1332026, XrefRangeEnd = 1332081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_Collections_IStructuralEquatable_Equals(Object other, IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0007C720 File Offset: 0x0007A920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1332081, XrefRangeEnd = 1332088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IComparable_CompareTo(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0007C774 File Offset: 0x0007A974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1332104, RefRangeEnd = 1332105, XrefRangeStart = 1332088, XrefRangeEnd = 1332104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_8_T1_T2_T3_T4_T5_T6_T7_TRest_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0007C7CC File Offset: 0x0007A9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1332105, XrefRangeEnd = 1332160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_Collections_IStructuralComparable_CompareTo(Object other, IComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0007C830 File Offset: 0x0007AA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1332160, XrefRangeEnd = 1332268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0007C874 File Offset: 0x0007AA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1332268, XrefRangeEnd = 1332272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_Collections_IStructuralEquatable_GetHashCode(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0007C8C8 File Offset: 0x0007AAC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1332386, RefRangeEnd = 1332388, XrefRangeStart = 1332272, XrefRangeEnd = 1332386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHashCodeCore(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_GetHashCodeCore_Private_Int32_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0007C91C File Offset: 0x0007AB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IValueTupleInternal_GetHashCode(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_IValueTupleInternal_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0007C970 File Offset: 0x0007AB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1332388, XrefRangeEnd = 1332952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0007C9AC File Offset: 0x0007ABAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1332952, XrefRangeEnd = 1333506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string System_IValueTupleInternal_ToStringEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_IValueTupleInternal_ToStringEnd_Private_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x0007C9E8 File Offset: 0x0007ABE8
		public unsafe int System.Runtime.CompilerServices.ITuple.Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1333506, XrefRangeEnd = 1333509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeMethodInfoPtr_System_Runtime_CompilerServices_ITuple_get_Length_Private_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00005FA9 File Offset: 0x000041A9
		public ValueTuple(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00005FB2 File Offset: 0x000041B2
		public ValueTuple()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>.NativeClassPtr))
		{
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x0007CA2C File Offset: 0x0007AC2C
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x0007CA54 File Offset: 0x0007AC54
		public unsafe T1 Item1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item1);
				return IL2CPP.PointerToValueGeneric<T1>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item1);
				Type typeFromHandle = typeof(T1);
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

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x0007CAFC File Offset: 0x0007ACFC
		// (set) Token: 0x0600120C RID: 4620 RVA: 0x0007CB24 File Offset: 0x0007AD24
		public unsafe T2 Item2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item2);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item2);
				Type typeFromHandle = typeof(T2);
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

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0007CBCC File Offset: 0x0007ADCC
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x0007CBF4 File Offset: 0x0007ADF4
		public unsafe T3 Item3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item3);
				return IL2CPP.PointerToValueGeneric<T3>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item3);
				Type typeFromHandle = typeof(T3);
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

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x0007CC9C File Offset: 0x0007AE9C
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x0007CCC4 File Offset: 0x0007AEC4
		public unsafe T4 Item4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item4);
				return IL2CPP.PointerToValueGeneric<T4>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item4);
				Type typeFromHandle = typeof(T4);
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

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0007CD6C File Offset: 0x0007AF6C
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x0007CD94 File Offset: 0x0007AF94
		public unsafe T5 Item5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item5);
				return IL2CPP.PointerToValueGeneric<T5>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item5);
				Type typeFromHandle = typeof(T5);
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

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x0007CE3C File Offset: 0x0007B03C
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x0007CE64 File Offset: 0x0007B064
		public unsafe T6 Item6
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item6);
				return IL2CPP.PointerToValueGeneric<T6>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item6);
				Type typeFromHandle = typeof(T6);
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

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x0007CF0C File Offset: 0x0007B10C
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x0007CF34 File Offset: 0x0007B134
		public unsafe T7 Item7
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item7);
				return IL2CPP.PointerToValueGeneric<T7>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Item7);
				Type typeFromHandle = typeof(T7);
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

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0007CFDC File Offset: 0x0007B1DC
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x0007D004 File Offset: 0x0007B204
		public unsafe TRest Rest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Rest);
				return IL2CPP.PointerToValueGeneric<TRest>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>.NativeFieldInfoPtr_Rest);
				Type typeFromHandle = typeof(TRest);
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

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeFieldInfoPtr_Item1;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeFieldInfoPtr_Item2;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeFieldInfoPtr_Item3;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeFieldInfoPtr_Item4;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeFieldInfoPtr_Item5;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeFieldInfoPtr_Item6;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeFieldInfoPtr_Item7;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeFieldInfoPtr_Rest;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_T4_T5_T6_T7_TRest_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_8_T1_T2_T3_T4_T5_T6_T7_TRest_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_8_T1_T2_T3_T4_T5_T6_T7_TRest_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeCore_Private_Int32_IEqualityComparer_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_System_IValueTupleInternal_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_System_IValueTupleInternal_ToStringEnd_Private_Virtual_Final_New_String_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_CompilerServices_ITuple_get_Length_Private_Virtual_Final_New_get_Int32_0;
	}
}
