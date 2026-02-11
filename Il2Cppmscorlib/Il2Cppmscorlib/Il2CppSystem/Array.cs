using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000120 RID: 288
	[Serializable]
	public class Array : Object
	{
		// Token: 0x060012D0 RID: 4816 RVA: 0x00080118 File Offset: 0x0007E318
		// Note: this type is marked as 'beforefieldinit'.
		static Array()
		{
			Il2CppClassPointerStore<Array>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Array");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array>.NativeClassPtr);
			Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666576);
			Array.NativeMethodInfoPtr_AsReadOnly_Public_Static_ReadOnlyCollection_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666577);
			Array.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666578);
			Array.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666579);
			Array.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666580);
			Array.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666581);
			Array.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666582);
			Array.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666583);
			Array.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666584);
			Array.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666585);
			Array.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666586);
			Array.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666587);
			Array.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666588);
			Array.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666589);
			Array.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666590);
			Array.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666591);
			Array.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666592);
			Array.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666593);
			Array.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666594);
			Array.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666595);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666596);
			Array.NativeMethodInfoPtr_ConvertAll_Public_Static_Il2CppArrayBase_1_TOutput_Il2CppArrayBase_1_TInput_Converter_2_TInput_TOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666597);
			Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Array_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666598);
			Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Int64_Array_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666599);
			Array.NativeMethodInfoPtr_CopyTo_Public_Void_Array_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666600);
			Array.NativeMethodInfoPtr_ForEach_Public_Static_Void_Il2CppArrayBase_1_T_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666601);
			Array.NativeMethodInfoPtr_get_LongLength_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666602);
			Array.NativeMethodInfoPtr_GetLongLength_Public_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666603);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666604);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666605);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666606);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666607);
			Array.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666608);
			Array.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666609);
			Array.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666610);
			Array.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666611);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666612);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666613);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Int32_Int32_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666614);
			Array.NativeMethodInfoPtr_GetMedian_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666615);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666616);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666617);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666618);
			Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666619);
			Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666620);
			Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666621);
			Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666622);
			Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666623);
			Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666624);
			Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666625);
			Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666626);
			Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666627);
			Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666628);
			Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666629);
			Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666630);
			Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666631);
			Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666632);
			Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666633);
			Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666634);
			Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666635);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666636);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666637);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666638);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666639);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666640);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666641);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666642);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Int32_Int32_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666643);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666644);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666645);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666646);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_Int32_Int32_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666647);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666648);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666649);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666650);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666651);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666652);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666653);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666654);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666655);
			Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666656);
			Array.NativeMethodInfoPtr_Exists_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666657);
			Array.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666658);
			Array.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666659);
			Array.NativeMethodInfoPtr_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666660);
			Array.NativeMethodInfoPtr_FindAll_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666661);
			Array.NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666662);
			Array.NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666663);
			Array.NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666664);
			Array.NativeMethodInfoPtr_FindLast_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666665);
			Array.NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666666);
			Array.NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666667);
			Array.NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666668);
			Array.NativeMethodInfoPtr_TrueForAll_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666669);
			Array.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666670);
			Array.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666671);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_get_Count_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666672);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_get_IsReadOnly_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666673);
			Array.NativeMethodInfoPtr_GetRawSzArrayData_Internal_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666674);
			Array.NativeMethodInfoPtr_InternalArray__IEnumerable_GetEnumerator_Internal_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666675);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666676);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_Add_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666677);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_Remove_Internal_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666678);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_Contains_Internal_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666679);
			Array.NativeMethodInfoPtr_InternalArray__ICollection_CopyTo_Internal_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666680);
			Array.NativeMethodInfoPtr_InternalArray__IReadOnlyList_get_Item_Internal_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666681);
			Array.NativeMethodInfoPtr_InternalArray__IReadOnlyCollection_get_Count_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666682);
			Array.NativeMethodInfoPtr_InternalArray__Insert_Internal_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666683);
			Array.NativeMethodInfoPtr_InternalArray__RemoveAt_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666684);
			Array.NativeMethodInfoPtr_InternalArray__IndexOf_Internal_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666685);
			Array.NativeMethodInfoPtr_InternalArray__get_Item_Internal_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666686);
			Array.NativeMethodInfoPtr_InternalArray__set_Item_Internal_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666687);
			Array.NativeMethodInfoPtr_GetGenericValueImpl_Internal_Void_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666688);
			Array.NativeMethodInfoPtr_SetGenericValueImpl_Internal_Void_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666689);
			Array.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666690);
			Array.NativeMethodInfoPtr_get_Rank_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666691);
			Array.NativeMethodInfoPtr_GetRank_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666692);
			Array.NativeMethodInfoPtr_GetLength_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666693);
			Array.NativeMethodInfoPtr_GetLowerBound_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666694);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666695);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666696);
			Array.NativeMethodInfoPtr_GetValueImpl_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666697);
			Array.NativeMethodInfoPtr_SetValueImpl_Internal_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666698);
			Array.NativeMethodInfoPtr_FastCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666699);
			Array.NativeMethodInfoPtr_CreateInstanceImpl_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666700);
			Array.NativeMethodInfoPtr_GetUpperBound_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666701);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666702);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666703);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666704);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666705);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666706);
			Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666707);
			Array.NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666708);
			Array.NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666709);
			Array.NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666710);
			Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666711);
			Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666712);
			Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666713);
			Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666714);
			Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666715);
			Array.NativeMethodInfoPtr_Clear_Public_Static_Void_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666716);
			Array.NativeMethodInfoPtr_ClearInternal_Private_Static_Void_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666717);
			Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666718);
			Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666719);
			Array.NativeMethodInfoPtr_CreateArrayTypeMismatchException_Private_Static_ArrayTypeMismatchException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666720);
			Array.NativeMethodInfoPtr_CanAssignArrayElement_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666721);
			Array.NativeMethodInfoPtr_ConstrainedCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666722);
			Array.NativeMethodInfoPtr_Empty_Public_Static_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666723);
			Array.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666724);
			Array.NativeMethodInfoPtr_IndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666725);
			Array.NativeMethodInfoPtr_LastIndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666726);
			Array.NativeMethodInfoPtr_SortImpl_Private_Static_Void_Array_Array_Int32_Int32_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666727);
			Array.NativeMethodInfoPtr_UnsafeLoad_Internal_Static_T_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666728);
			Array.NativeMethodInfoPtr_UnsafeStore_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666729);
			Array.NativeMethodInfoPtr_UnsafeMov_Internal_Static_R_S_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666730);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00080D64 File Offset: 0x0007EF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335324, XrefRangeEnd = 1335350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstance(Type elementType, [Optional] Il2CppStructArray<long> lengths)
		{
			if (lengths == null)
			{
				lengths = new Il2CppStructArray<long>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00080DC8 File Offset: 0x0007EFC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1335354, RefRangeEnd = 1335357, XrefRangeStart = 1335350, XrefRangeEnd = 1335354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<T> AsReadOnly<T>(Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_AsReadOnly_Public_Static_ReadOnlyCollection_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00080E0C File Offset: 0x0007F00C
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 1335362, RefRangeEnd = 1335462, XrefRangeStart = 1335357, XrefRangeEnd = 1335362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Resize<T>(ref Il2CppArrayBase<T> array, int newSize)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x00080E68 File Offset: 0x0007F068
		public unsafe virtual int System.Collections.ICollection.Count
		{
			[CallerCount(143)]
			[CachedScanResults(RefRangeStart = 1335466, RefRangeEnd = 1335609, XrefRangeStart = 1335462, XrefRangeEnd = 1335466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00080EA4 File Offset: 0x0007F0A4
		public unsafe virtual bool System.Collections.IList.IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x00080EE0 File Offset: 0x0007F0E0
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x00080F2C File Offset: 0x0007F12C
		public unsafe virtual Object System.Collections.IList.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335609, XrefRangeEnd = 1335610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335610, XrefRangeEnd = 1335611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00080F7C File Offset: 0x0007F17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335611, XrefRangeEnd = 1335617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00080FCC File Offset: 0x0007F1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335617, XrefRangeEnd = 1335623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IList_Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0008101C File Offset: 0x0007F21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335623, XrefRangeEnd = 1335655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00081050 File Offset: 0x0007F250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1335661, RefRangeEnd = 1335662, XrefRangeStart = 1335655, XrefRangeEnd = 1335661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x000810A0 File Offset: 0x0007F2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335662, XrefRangeEnd = 1335668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Insert(int index, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x000810F0 File Offset: 0x0007F2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335668, XrefRangeEnd = 1335674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00081134 File Offset: 0x0007F334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335674, XrefRangeEnd = 1335680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00081174 File Offset: 0x0007F374
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 1335687, RefRangeEnd = 1335724, XrefRangeStart = 1335680, XrefRangeEnd = 1335687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x000811C4 File Offset: 0x0007F3C4
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00081204 File Offset: 0x0007F404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335724, XrefRangeEnd = 1335739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IStructuralComparable_CompareTo(Object other, IComparer comparer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00081264 File Offset: 0x0007F464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335739, XrefRangeEnd = 1335755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IStructuralEquatable_Equals(Object other, IEqualityComparer comparer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x000812C4 File Offset: 0x0007F4C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786824, RefRangeEnd = 786825, XrefRangeStart = 786824, XrefRangeEnd = 786825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00081310 File Offset: 0x0007F510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335755, XrefRangeEnd = 1335771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IStructuralEquatable_GetHashCode(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00081360 File Offset: 0x0007F560
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1335777, RefRangeEnd = 1335782, XrefRangeStart = 1335771, XrefRangeEnd = 1335777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch(Array array, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x000813B4 File Offset: 0x0007F5B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1335787, RefRangeEnd = 1335790, XrefRangeStart = 1335782, XrefRangeEnd = 1335787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<TOutput> ConvertAll<TInput, TOutput>(Il2CppArrayBase<TInput> array, Converter<TInput, TOutput> converter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_ConvertAll_Public_Static_Il2CppArrayBase_1_TOutput_Il2CppArrayBase_1_TInput_Converter_2_TInput_TOutput_0<TInput, TOutput>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<TOutput>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00081404 File Offset: 0x0007F604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335790, XrefRangeEnd = 1335793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Array sourceArray, Array destinationArray, long length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationArray);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Array_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0008145C File Offset: 0x0007F65C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1335815, RefRangeEnd = 1335818, XrefRangeStart = 1335793, XrefRangeEnd = 1335815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationArray);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Int64_Array_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x000814D0 File Offset: 0x0007F6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335818, XrefRangeEnd = 1335825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Array array, long index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CopyTo_Public_Void_Array_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00081520 File Offset: 0x0007F720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1335827, RefRangeEnd = 1335829, XrefRangeStart = 1335825, XrefRangeEnd = 1335827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForEach<T>(Il2CppArrayBase<T> array, Action<T> action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_ForEach_Public_Static_Void_Il2CppArrayBase_1_T_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00081568 File Offset: 0x0007F768
		public unsafe long LongLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335829, XrefRangeEnd = 1335833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_LongLength_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x000815A4 File Offset: 0x0007F7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335833, XrefRangeEnd = 1335834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetLongLength(int dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimension;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetLongLength_Public_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x000815F0 File Offset: 0x0007F7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335834, XrefRangeEnd = 1335842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(long index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0008163C File Offset: 0x0007F83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335842, XrefRangeEnd = 1335862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(long index1, long index2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00081698 File Offset: 0x0007F898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335862, XrefRangeEnd = 1335889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(long index1, long index2, long index3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00081700 File Offset: 0x0007F900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335889, XrefRangeEnd = 1335916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue([Optional] Il2CppStructArray<long> indices)
		{
			if (indices == null)
			{
				indices = new Il2CppStructArray<long>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00081760 File Offset: 0x0007F960
		public unsafe virtual bool IsFixedSize
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x0008179C File Offset: 0x0007F99C
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x000817D8 File Offset: 0x0007F9D8
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00081814 File Offset: 0x0007FA14
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00081854 File Offset: 0x0007FA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335916, XrefRangeEnd = 1335917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch(Array array, int index, int length, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Int32_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000818C4 File Offset: 0x0007FAC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1335923, RefRangeEnd = 1335925, XrefRangeStart = 1335917, XrefRangeEnd = 1335923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch(Array array, Object value, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Object_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0008192C File Offset: 0x0007FB2C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1335944, RefRangeEnd = 1335951, XrefRangeStart = 1335925, XrefRangeEnd = 1335944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch(Array array, int index, int length, Object value, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Int32_Int32_Object_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x000819B0 File Offset: 0x0007FBB0
		[CallerCount(0)]
		public unsafe static int GetMedian(int low, int hi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref low;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetMedian_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x000819FC File Offset: 0x0007FBFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1335953, RefRangeEnd = 1335958, XrefRangeStart = 1335951, XrefRangeEnd = 1335953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch<T>(Il2CppArrayBase<T> array, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00081A88 File Offset: 0x0007FC88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1335960, RefRangeEnd = 1335964, XrefRangeStart = 1335958, XrefRangeEnd = 1335960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch<T>(Il2CppArrayBase<T> array, T value, IComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00081B24 File Offset: 0x0007FD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335964, XrefRangeEnd = 1335967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch<T>(Il2CppArrayBase<T> array, int index, int length, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00081BCC File Offset: 0x0007FDCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1335976, RefRangeEnd = 1335979, XrefRangeStart = 1335967, XrefRangeEnd = 1335976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch<T>(Il2CppArrayBase<T> array, int index, int length, T value, IComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00081C84 File Offset: 0x0007FE84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1335661, RefRangeEnd = 1335662, XrefRangeStart = 1335661, XrefRangeEnd = 1335662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Array array, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00081CD8 File Offset: 0x0007FED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335979, XrefRangeEnd = 1335985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Array array, Object value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00081D3C File Offset: 0x0007FF3C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1335993, RefRangeEnd = 1335998, XrefRangeStart = 1335985, XrefRangeEnd = 1335993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Array array, Object value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00081DAC File Offset: 0x0007FFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336000, RefRangeEnd = 1336001, XrefRangeStart = 1335998, XrefRangeEnd = 1336000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf<T>(Il2CppArrayBase<T> array, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00081E38 File Offset: 0x00080038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336001, XrefRangeEnd = 1336004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf<T>(Il2CppArrayBase<T> array, T value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00081ED0 File Offset: 0x000800D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1336006, RefRangeEnd = 1336009, XrefRangeStart = 1336004, XrefRangeEnd = 1336006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf<T>(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00081F78 File Offset: 0x00080178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336009, XrefRangeEnd = 1336018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOf(Array array, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00081FCC File Offset: 0x000801CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336018, XrefRangeEnd = 1336019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOf(Array array, Object value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00082030 File Offset: 0x00080230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1336029, RefRangeEnd = 1336031, XrefRangeStart = 1336019, XrefRangeEnd = 1336029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOf(Array array, Object value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000820A0 File Offset: 0x000802A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336031, XrefRangeEnd = 1336033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOf<T>(Il2CppArrayBase<T> array, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0008212C File Offset: 0x0008032C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336033, XrefRangeEnd = 1336035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOf<T>(Il2CppArrayBase<T> array, T value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x000821C4 File Offset: 0x000803C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1336037, RefRangeEnd = 1336039, XrefRangeStart = 1336035, XrefRangeEnd = 1336037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOf<T>(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0008226C File Offset: 0x0008046C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336039, XrefRangeEnd = 1336051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reverse(Array array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000822A4 File Offset: 0x000804A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1336062, RefRangeEnd = 1336064, XrefRangeStart = 1336051, XrefRangeEnd = 1336062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reverse(Array array, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000822F8 File Offset: 0x000804F8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1336065, RefRangeEnd = 1336088, XrefRangeStart = 1336064, XrefRangeEnd = 1336065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reverse<T>(Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00082330 File Offset: 0x00080530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1336090, RefRangeEnd = 1336092, XrefRangeStart = 1336088, XrefRangeEnd = 1336090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reverse<T>(Il2CppArrayBase<T> array, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00082384 File Offset: 0x00080584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336092, XrefRangeEnd = 1336100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, long index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x000823D4 File Offset: 0x000805D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336100, XrefRangeEnd = 1336120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, long index1, long index2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00082434 File Offset: 0x00080634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336120, XrefRangeEnd = 1336147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, long index1, long index2, long index3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000824A0 File Offset: 0x000806A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336147, XrefRangeEnd = 1336174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, [Optional] Il2CppStructArray<long> indices)
		{
			if (indices == null)
			{
				indices = new Il2CppStructArray<long>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00082504 File Offset: 0x00080704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336174, XrefRangeEnd = 1336180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0008253C File Offset: 0x0008073C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336180, XrefRangeEnd = 1336181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array array, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00082590 File Offset: 0x00080790
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1336187, RefRangeEnd = 1336192, XrefRangeStart = 1336181, XrefRangeEnd = 1336187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array array, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x000825D8 File Offset: 0x000807D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1336193, RefRangeEnd = 1336196, XrefRangeStart = 1336192, XrefRangeEnd = 1336193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array array, int index, int length, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Int32_Int32_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0008263C File Offset: 0x0008083C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336202, RefRangeEnd = 1336203, XrefRangeStart = 1336196, XrefRangeEnd = 1336202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array keys, Array items)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00082684 File Offset: 0x00080884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336203, XrefRangeEnd = 1336209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array keys, Array items, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x000826E0 File Offset: 0x000808E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336209, XrefRangeEnd = 1336210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array keys, Array items, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00082744 File Offset: 0x00080944
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1336223, RefRangeEnd = 1336230, XrefRangeStart = 1336210, XrefRangeEnd = 1336223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Array keys, Array items, int index, int length, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_Int32_Int32_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x000827BC File Offset: 0x000809BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336232, RefRangeEnd = 1336233, XrefRangeStart = 1336230, XrefRangeEnd = 1336232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort<T>(Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000827F4 File Offset: 0x000809F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336235, RefRangeEnd = 1336236, XrefRangeStart = 1336233, XrefRangeEnd = 1336235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort<T>(Il2CppArrayBase<T> array, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00082848 File Offset: 0x00080A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336238, RefRangeEnd = 1336239, XrefRangeStart = 1336236, XrefRangeEnd = 1336238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort<T>(Il2CppArrayBase<T> array, IComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00082890 File Offset: 0x00080A90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1336248, RefRangeEnd = 1336251, XrefRangeStart = 1336239, XrefRangeEnd = 1336248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort<T>(Il2CppArrayBase<T> array, int index, int length, IComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x000828F4 File Offset: 0x00080AF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1336255, RefRangeEnd = 1336257, XrefRangeStart = 1336251, XrefRangeEnd = 1336255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort<T>(Il2CppArrayBase<T> array, Comparison<T> comparison)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparison);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0008293C File Offset: 0x00080B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336259, RefRangeEnd = 1336260, XrefRangeStart = 1336257, XrefRangeEnd = 1336259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort<TKey, TValue>(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> items)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00082984 File Offset: 0x00080B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336260, XrefRangeEnd = 1336261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort<TKey, TValue>(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> items, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000829E8 File Offset: 0x00080BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336263, RefRangeEnd = 1336264, XrefRangeStart = 1336261, XrefRangeEnd = 1336263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort<TKey, TValue>(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> items, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00082A44 File Offset: 0x00080C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336273, RefRangeEnd = 1336274, XrefRangeStart = 1336264, XrefRangeEnd = 1336273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort<TKey, TValue>(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> items, int index, int length, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00082ABC File Offset: 0x00080CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336277, RefRangeEnd = 1336278, XrefRangeStart = 1336274, XrefRangeEnd = 1336277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Exists<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Exists_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00082B10 File Offset: 0x00080D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336278, XrefRangeEnd = 1336285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Fill<T>(Il2CppArrayBase<T> array, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00082B90 File Offset: 0x00080D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336285, XrefRangeEnd = 1336291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Fill<T>(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00082C2C File Offset: 0x00080E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336291, XrefRangeEnd = 1336299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Find<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00082C7C File Offset: 0x00080E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336299, XrefRangeEnd = 1336311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FindAll<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindAll_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00082CCC File Offset: 0x00080ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336313, RefRangeEnd = 1336314, XrefRangeStart = 1336311, XrefRangeEnd = 1336313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIndex<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00082D20 File Offset: 0x00080F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336314, XrefRangeEnd = 1336315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIndex<T>(Il2CppArrayBase<T> array, int startIndex, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00082D84 File Offset: 0x00080F84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1336316, RefRangeEnd = 1336318, XrefRangeStart = 1336315, XrefRangeEnd = 1336316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindIndex<T>(Il2CppArrayBase<T> array, int startIndex, int count, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00082DF4 File Offset: 0x00080FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336318, XrefRangeEnd = 1336327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindLast<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindLast_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00082E44 File Offset: 0x00081044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336327, XrefRangeEnd = 1336328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindLastIndex<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00082E98 File Offset: 0x00081098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336328, XrefRangeEnd = 1336329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindLastIndex<T>(Il2CppArrayBase<T> array, int startIndex, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00082EFC File Offset: 0x000810FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336329, XrefRangeEnd = 1336333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindLastIndex<T>(Il2CppArrayBase<T> array, int startIndex, int count, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00082F6C File Offset: 0x0008116C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336333, XrefRangeEnd = 1336337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrueForAll<T>(Il2CppArrayBase<T> array, Predicate<T> match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_TrueForAll_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00082FC0 File Offset: 0x000811C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1336341, RefRangeEnd = 1336348, XrefRangeStart = 1336337, XrefRangeEnd = 1336341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00083000 File Offset: 0x00081200
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0008303C File Offset: 0x0008123C
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 1335466, RefRangeEnd = 1335609, XrefRangeStart = 1335466, XrefRangeEnd = 1335609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalArray__ICollection_get_Count()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_InternalArray__ICollection_get_Count_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00083078 File Offset: 0x00081278
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalArray__ICollection_get_IsReadOnly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_InternalArray__ICollection_get_IsReadOnly_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x000830B4 File Offset: 0x000812B4
		[CallerCount(0)]
		public unsafe ref byte GetRawSzArrayData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetRawSzArrayData_Internal_byref_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x000830E8 File Offset: 0x000812E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336348, XrefRangeEnd = 1336352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__IEnumerable_GetEnumerator_Internal_IEnumerator_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00083128 File Offset: 0x00081328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336352, XrefRangeEnd = 1336358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalArray__ICollection_Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_InternalArray__ICollection_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0008315C File Offset: 0x0008135C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336358, XrefRangeEnd = 1336363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalArray__ICollection_Add<T>(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__ICollection_Add_Internal_Void_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x000831D4 File Offset: 0x000813D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalArray__ICollection_Remove<T>(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__ICollection_Remove_Internal_Boolean_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00083258 File Offset: 0x00081458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336363, XrefRangeEnd = 1336371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalArray__ICollection_Contains<T>(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__ICollection_Contains_Internal_Boolean_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x000832DC File Offset: 0x000814DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336371, XrefRangeEnd = 1336374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalArray__ICollection_CopyTo<T>(Il2CppArrayBase<T> array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__ICollection_CopyTo_Internal_Void_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0008332C File Offset: 0x0008152C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336376, RefRangeEnd = 1336377, XrefRangeStart = 1336374, XrefRangeEnd = 1336376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T InternalArray__IReadOnlyList_get_Item<T>(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__IReadOnlyList_get_Item_Internal_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00083374 File Offset: 0x00081574
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 1335466, RefRangeEnd = 1335609, XrefRangeStart = 1335466, XrefRangeEnd = 1335609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalArray__IReadOnlyCollection_get_Count()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_InternalArray__IReadOnlyCollection_get_Count_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000833B0 File Offset: 0x000815B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336377, XrefRangeEnd = 1336388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalArray__Insert<T>(int index, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__Insert_Internal_Void_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00083438 File Offset: 0x00081638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336388, XrefRangeEnd = 1336394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalArray__RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_InternalArray__RemoveAt_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00083478 File Offset: 0x00081678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336394, XrefRangeEnd = 1336403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalArray__IndexOf<T>(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__IndexOf_Internal_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x000834FC File Offset: 0x000816FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336376, RefRangeEnd = 1336377, XrefRangeStart = 1336376, XrefRangeEnd = 1336377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T InternalArray__get_Item<T>(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__get_Item_Internal_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00083544 File Offset: 0x00081744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336403, XrefRangeEnd = 1336409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalArray__set_Item<T>(int index, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_InternalArray__set_Item_Internal_Void_Int32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000835CC File Offset: 0x000817CC
		[CallerCount(0)]
		public unsafe void GetGenericValueImpl<T>(int pos, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_GetGenericValueImpl_Internal_Void_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00083658 File Offset: 0x00081858
		[CallerCount(0)]
		public unsafe void SetGenericValueImpl<T>(int pos, ref T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_SetGenericValueImpl_Internal_Void_Int32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x000836C0 File Offset: 0x000818C0
		public unsafe int Length
		{
			[CallerCount(143)]
			[CachedScanResults(RefRangeStart = 1335466, RefRangeEnd = 1335609, XrefRangeStart = 1335466, XrefRangeEnd = 1335609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x000836FC File Offset: 0x000818FC
		public unsafe int Rank
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 1336410, RefRangeEnd = 1336460, XrefRangeStart = 1336409, XrefRangeEnd = 1336410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_Rank_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00083738 File Offset: 0x00081938
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 1336410, RefRangeEnd = 1336460, XrefRangeStart = 1336410, XrefRangeEnd = 1336460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetRank_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00083774 File Offset: 0x00081974
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1336461, RefRangeEnd = 1336480, XrefRangeStart = 1336460, XrefRangeEnd = 1336461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLength(int dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimension;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetLength_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x000837C0 File Offset: 0x000819C0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1336481, RefRangeEnd = 1336505, XrefRangeStart = 1336480, XrefRangeEnd = 1336481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLowerBound(int dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimension;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetLowerBound_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0008380C File Offset: 0x00081A0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1336506, RefRangeEnd = 1336508, XrefRangeStart = 1336505, XrefRangeEnd = 1336506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue([Optional] Il2CppStructArray<int> indices)
		{
			if (indices == null)
			{
				indices = new Il2CppStructArray<int>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0008386C File Offset: 0x00081A6C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1336509, RefRangeEnd = 1336516, XrefRangeStart = 1336508, XrefRangeEnd = 1336509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, [Optional] Il2CppStructArray<int> indices)
		{
			if (indices == null)
			{
				indices = new Il2CppStructArray<int>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x000838D0 File Offset: 0x00081AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336517, RefRangeEnd = 1336518, XrefRangeStart = 1336516, XrefRangeEnd = 1336517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValueImpl(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValueImpl_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0008391C File Offset: 0x00081B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336518, XrefRangeEnd = 1336519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValueImpl(Object value, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValueImpl_Internal_Void_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0008396C File Offset: 0x00081B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336520, RefRangeEnd = 1336521, XrefRangeStart = 1336519, XrefRangeEnd = 1336520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source_idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest_idx;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_FastCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x000839EC File Offset: 0x00081BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336521, XrefRangeEnd = 1336522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstanceImpl(Type elementType, Il2CppStructArray<int> lengths, Il2CppStructArray<int> bounds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengths);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstanceImpl_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00083A54 File Offset: 0x00081C54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1336524, RefRangeEnd = 1336526, XrefRangeStart = 1336522, XrefRangeEnd = 1336524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUpperBound(int dimension)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimension;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetUpperBound_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00083AA0 File Offset: 0x00081CA0
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 1336551, RefRangeEnd = 1336613, XrefRangeStart = 1336526, XrefRangeEnd = 1336551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00083AEC File Offset: 0x00081CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336613, XrefRangeEnd = 1336619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index1, int index2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00083B48 File Offset: 0x00081D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336619, XrefRangeEnd = 1336625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index1, int index2, int index3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00083BB0 File Offset: 0x00081DB0
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 1336650, RefRangeEnd = 1336714, XrefRangeStart = 1336625, XrefRangeEnd = 1336650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00083C00 File Offset: 0x00081E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336720, RefRangeEnd = 1336721, XrefRangeStart = 1336714, XrefRangeEnd = 1336720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, int index1, int index2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00083C60 File Offset: 0x00081E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336727, RefRangeEnd = 1336728, XrefRangeStart = 1336721, XrefRangeEnd = 1336727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(Object value, int index1, int index2, int index3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00083CCC File Offset: 0x00081ECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1336729, RefRangeEnd = 1336731, XrefRangeStart = 1336728, XrefRangeEnd = 1336729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array UnsafeCreateInstance(Type elementType, Il2CppStructArray<int> lengths, Il2CppStructArray<int> lowerBounds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengths);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBounds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00083D34 File Offset: 0x00081F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336731, XrefRangeEnd = 1336737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array UnsafeCreateInstance(Type elementType, int length1, int length2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00083D94 File Offset: 0x00081F94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1336738, RefRangeEnd = 1336741, XrefRangeStart = 1336737, XrefRangeEnd = 1336738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array UnsafeCreateInstance(Type elementType, [Optional] Il2CppStructArray<int> lengths)
		{
			if (lengths == null)
			{
				lengths = new Il2CppStructArray<int>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00083DF8 File Offset: 0x00081FF8
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 1336747, RefRangeEnd = 1336782, XrefRangeStart = 1336741, XrefRangeEnd = 1336747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstance(Type elementType, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00083E4C File Offset: 0x0008204C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstance(Type elementType, int length1, int length2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00083EAC File Offset: 0x000820AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336782, XrefRangeEnd = 1336788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstance(Type elementType, int length1, int length2, int length3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00083F1C File Offset: 0x0008211C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1336839, RefRangeEnd = 1336848, XrefRangeStart = 1336788, XrefRangeEnd = 1336839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstance(Type elementType, [Optional] Il2CppStructArray<int> lengths)
		{
			if (lengths == null)
			{
				lengths = new Il2CppStructArray<int>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00083F80 File Offset: 0x00082180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1336933, RefRangeEnd = 1336934, XrefRangeStart = 1336848, XrefRangeEnd = 1336933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreateInstance(Type elementType, Il2CppStructArray<int> lengths, Il2CppStructArray<int> lowerBounds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengths);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBounds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00083FE8 File Offset: 0x000821E8
		[CallerCount(591)]
		[CachedScanResults(RefRangeStart = 1336961, RefRangeEnd = 1337552, XrefRangeStart = 1336934, XrefRangeEnd = 1336961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear(Array array, int index, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Clear_Public_Static_Void_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0008403C File Offset: 0x0008223C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337552, XrefRangeEnd = 1337553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearInternal(Array a, int index, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_ClearInternal_Private_Static_Void_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00084090 File Offset: 0x00082290
		[CallerCount(78)]
		[CachedScanResults(RefRangeStart = 1337556, RefRangeEnd = 1337634, XrefRangeStart = 1337553, XrefRangeEnd = 1337556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Array sourceArray, Array destinationArray, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationArray);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Array_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x000840E8 File Offset: 0x000822E8
		[CallerCount(285)]
		[CachedScanResults(RefRangeStart = 1337653, RefRangeEnd = 1337938, XrefRangeStart = 1337634, XrefRangeEnd = 1337653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationArray);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0008415C File Offset: 0x0008235C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337938, XrefRangeEnd = 1337942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArrayTypeMismatchException CreateArrayTypeMismatchException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateArrayTypeMismatchException_Private_Static_ArrayTypeMismatchException_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayTypeMismatchException>(intPtr3) : null;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00084190 File Offset: 0x00082390
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1337944, RefRangeEnd = 1337946, XrefRangeStart = 1337942, XrefRangeEnd = 1337944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanAssignArrayElement(Type source, Type target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CanAssignArrayElement_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x000841E4 File Offset: 0x000823E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1337947, RefRangeEnd = 1337948, XrefRangeStart = 1337946, XrefRangeEnd = 1337947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationArray);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_ConstrainedCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00084258 File Offset: 0x00082458
		[CallerCount(495)]
		[CachedScanResults(RefRangeStart = 739664, RefRangeEnd = 740159, XrefRangeStart = 739664, XrefRangeEnd = 740159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> Empty<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_Empty_Public_Static_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00084284 File Offset: 0x00082484
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x000842B8 File Offset: 0x000824B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1337960, RefRangeEnd = 1337961, XrefRangeStart = 1337948, XrefRangeEnd = 1337960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfImpl<T>(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_IndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00084360 File Offset: 0x00082560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1337973, RefRangeEnd = 1337974, XrefRangeStart = 1337961, XrefRangeEnd = 1337973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOfImpl<T>(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_LastIndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00084408 File Offset: 0x00082608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337974, XrefRangeEnd = 1337984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SortImpl_Private_Static_Void_Array_Array_Int32_Int32_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00084480 File Offset: 0x00082680
		[CallerCount(0)]
		public unsafe static T UnsafeLoad<T>(Il2CppArrayBase<T> array, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_UnsafeLoad_Internal_Static_T_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x000844CC File Offset: 0x000826CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337984, XrefRangeEnd = 1337990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnsafeStore<T>(Il2CppArrayBase<T> array, int index, T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_UnsafeStore_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00084558 File Offset: 0x00082758
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1064852, RefRangeEnd = 1064854, XrefRangeStart = 1064852, XrefRangeEnd = 1064854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static R UnsafeMov<S, R>(S instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(S).IsValueType)
				{
					S s = instance;
					intPtr = ((s is string) ? IL2CPP.ManagedStringToIl2Cpp(s as string) : IL2CPP.Il2CppObjectBaseToPtr(s as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instance;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Array.MethodInfoStoreGeneric_UnsafeMov_Internal_Static_R_S_0<S, R>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<R>(intPtr2, false, true);
			}
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00006288 File Offset: 0x00004488
		public static Array CreateInstance(Type elementType, params long[] lengths)
		{
			return Array.CreateInstance(elementType, new Il2CppStructArray<long>(lengths));
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00006296 File Offset: 0x00004496
		public Object GetValue(params long[] indices)
		{
			return this.GetValue(new Il2CppStructArray<long>(indices));
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x000062A4 File Offset: 0x000044A4
		public void SetValue(Object value, params long[] indices)
		{
			this.SetValue(value, new Il2CppStructArray<long>(indices));
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x000062B3 File Offset: 0x000044B3
		public Object GetValue(params int[] indices)
		{
			return this.GetValue(new Il2CppStructArray<int>(indices));
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x000062C1 File Offset: 0x000044C1
		public void SetValue(Object value, params int[] indices)
		{
			this.SetValue(value, new Il2CppStructArray<int>(indices));
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x000062D0 File Offset: 0x000044D0
		public static Array UnsafeCreateInstance(Type elementType, params int[] lengths)
		{
			return Array.UnsafeCreateInstance(elementType, new Il2CppStructArray<int>(lengths));
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x000062DE File Offset: 0x000044DE
		public static Array CreateInstance(Type elementType, params int[] lengths)
		{
			return Array.CreateInstance(elementType, new Il2CppStructArray<int>(lengths));
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x000062EC File Offset: 0x000044EC
		public Array(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int64_0;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeMethodInfoPtr_AsReadOnly_Public_Static_ReadOnlyCollection_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Object_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_ConvertAll_Public_Static_Il2CppArrayBase_1_TOutput_Il2CppArrayBase_1_TInput_Converter_2_TInput_TOutput_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Array_Int64_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Int64_Array_Int64_Int64_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Array_Int64_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_ForEach_Public_Static_Void_Il2CppArrayBase_1_T_Action_1_T_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_get_LongLength_Public_get_Int64_0;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_GetLongLength_Public_Int64_Int32_0;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int64_0;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int64_Int64_0;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int64_Int64_Int64_0;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Il2CppStructArray_1_Int64_0;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Int32_Int32_Object_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Object_IComparer_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Array_Int32_Int32_Object_IComparer_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_GetMedian_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_IComparer_1_T_0;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_Int32_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Array_Object_Int32_Int32_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_Int32_0;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Array_Object_Int32_Int32_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Static_Void_Array_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Static_Void_Array_Int32_Int32_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_Int64_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Int64_Int64_Int64_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Il2CppStructArray_1_Int64_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Int32_Int32_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_IComparer_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Int32_Int32_IComparer_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_0;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_IComparer_0;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_Int32_Int32_0;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Array_Array_Int32_Int32_IComparer_0;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_IComparer_1_T_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_0;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_0;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_0;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeMethodInfoPtr_FindAll_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr_FindLast_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_TrueForAll_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_get_Count_Internal_Int32_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_get_IsReadOnly_Internal_Boolean_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_GetRawSzArrayData_Internal_byref_Byte_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__IEnumerable_GetEnumerator_Internal_IEnumerator_1_T_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_Clear_Internal_Void_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_Add_Internal_Void_T_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_Remove_Internal_Boolean_T_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_Contains_Internal_Boolean_T_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__ICollection_CopyTo_Internal_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__IReadOnlyList_get_Item_Internal_T_Int32_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__IReadOnlyCollection_get_Count_Internal_Int32_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__Insert_Internal_Void_Int32_T_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__RemoveAt_Internal_Void_Int32_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__IndexOf_Internal_Int32_T_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__get_Item_Internal_T_Int32_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_InternalArray__set_Item_Internal_Void_Int32_T_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericValueImpl_Internal_Void_Int32_byref_T_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_SetGenericValueImpl_Internal_Void_Int32_byref_T_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_get_Rank_Public_get_Int32_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_GetRank_Private_Int32_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_GetLength_Public_Int32_Int32_0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr_GetLowerBound_Public_Int32_Int32_0;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr_GetValueImpl_Internal_Object_Int32_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr_SetValueImpl_Internal_Void_Object_Int32_0;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr_FastCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceImpl_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeMethodInfoPtr_GetUpperBound_Public_Int32_Int32_0;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int32_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int32_Int32_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int32_Int32_Int32_0;

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_Int32_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Int32_Int32_Int32_0;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Int32_Int32_0;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeCreateInstance_Internal_Static_Array_Type_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_Int32_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Int32_Int32_Int32_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Array_Int32_Int32_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_ClearInternal_Private_Static_Void_Array_Int32_Int32_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Array_Int32_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_CreateArrayTypeMismatchException_Private_Static_ArrayTypeMismatchException_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_CanAssignArrayElement_Private_Static_Boolean_Type_Type_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_ConstrainedCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_Empty_Public_Static_Il2CppArrayBase_1_T_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_SortImpl_Private_Static_Void_Array_Array_Int32_Int32_IComparer_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeLoad_Internal_Static_T_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeStore_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_T_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeMov_Internal_Static_R_S_0;

		// Token: 0x020005A5 RID: 1445
		public sealed class ArrayEnumerator : Object
		{
			// Token: 0x060056C7 RID: 22215 RVA: 0x00190640 File Offset: 0x0018E840
			// Note: this type is marked as 'beforefieldinit'.
			static ArrayEnumerator()
			{
				Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Array>.NativeClassPtr, "ArrayEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr);
				Array.ArrayEnumerator.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, "_array");
				Array.ArrayEnumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, "_index");
				Array.ArrayEnumerator.NativeFieldInfoPtr__endIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, "_endIndex");
				Array.ArrayEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, 100666731);
				Array.ArrayEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, 100666732);
				Array.ArrayEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, 100666733);
				Array.ArrayEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, 100666734);
				Array.ArrayEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr, 100666735);
			}

			// Token: 0x060056C8 RID: 22216 RVA: 0x0019070C File Offset: 0x0018E90C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1335006, RefRangeEnd = 1335007, XrefRangeStart = 1335003, XrefRangeEnd = 1335006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArrayEnumerator(Array array)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.ArrayEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.ArrayEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056C9 RID: 22217 RVA: 0x00190758 File Offset: 0x0018E958
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.ArrayEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060056CA RID: 22218 RVA: 0x00190794 File Offset: 0x0018E994
			[CallerCount(0)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.ArrayEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056CB RID: 22219 RVA: 0x001907C8 File Offset: 0x0018E9C8
			[CallerCount(105)]
			[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.ArrayEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x1700162E RID: 5678
			// (get) Token: 0x060056CC RID: 22220 RVA: 0x00190808 File Offset: 0x0018EA08
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335007, XrefRangeEnd = 1335029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.ArrayEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060056CD RID: 22221 RVA: 0x0001EDCE File Offset: 0x0001CFCE
			public ArrayEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700162B RID: 5675
			// (get) Token: 0x060056CE RID: 22222 RVA: 0x00190848 File Offset: 0x0018EA48
			// (set) Token: 0x060056CF RID: 22223 RVA: 0x0001EDD7 File Offset: 0x0001CFD7
			public unsafe Array _array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.ArrayEnumerator.NativeFieldInfoPtr__array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.ArrayEnumerator.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700162C RID: 5676
			// (get) Token: 0x060056D0 RID: 22224 RVA: 0x00190878 File Offset: 0x0018EA78
			// (set) Token: 0x060056D1 RID: 22225 RVA: 0x0001EDF6 File Offset: 0x0001CFF6
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.ArrayEnumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.ArrayEnumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x1700162D RID: 5677
			// (get) Token: 0x060056D2 RID: 22226 RVA: 0x001908A0 File Offset: 0x0018EAA0
			// (set) Token: 0x060056D3 RID: 22227 RVA: 0x0001EE11 File Offset: 0x0001D011
			public unsafe int _endIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.ArrayEnumerator.NativeFieldInfoPtr__endIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.ArrayEnumerator.NativeFieldInfoPtr__endIndex)) = value;
				}
			}

			// Token: 0x04004731 RID: 18225
			private static readonly IntPtr NativeFieldInfoPtr__array;

			// Token: 0x04004732 RID: 18226
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04004733 RID: 18227
			private static readonly IntPtr NativeFieldInfoPtr__endIndex;

			// Token: 0x04004734 RID: 18228
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Array_0;

			// Token: 0x04004735 RID: 18229
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004736 RID: 18230
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004737 RID: 18231
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x04004738 RID: 18232
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020005A6 RID: 1446
		public class RawData : Object
		{
			// Token: 0x060056D4 RID: 22228 RVA: 0x001908C8 File Offset: 0x0018EAC8
			// Note: this type is marked as 'beforefieldinit'.
			static RawData()
			{
				Il2CppClassPointerStore<Array.RawData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Array>.NativeClassPtr, "RawData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array.RawData>.NativeClassPtr);
				Array.RawData.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.RawData>.NativeClassPtr, "Bounds");
				Array.RawData.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.RawData>.NativeClassPtr, "Count");
				Array.RawData.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.RawData>.NativeClassPtr, "Data");
			}

			// Token: 0x060056D5 RID: 22229 RVA: 0x0001EE2C File Offset: 0x0001D02C
			public RawData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700162F RID: 5679
			// (get) Token: 0x060056D6 RID: 22230 RVA: 0x00190930 File Offset: 0x0018EB30
			// (set) Token: 0x060056D7 RID: 22231 RVA: 0x0001EE35 File Offset: 0x0001D035
			public unsafe IntPtr Bounds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.RawData.NativeFieldInfoPtr_Bounds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.RawData.NativeFieldInfoPtr_Bounds)) = value;
				}
			}

			// Token: 0x17001630 RID: 5680
			// (get) Token: 0x060056D8 RID: 22232 RVA: 0x00190958 File Offset: 0x0018EB58
			// (set) Token: 0x060056D9 RID: 22233 RVA: 0x0001EE50 File Offset: 0x0001D050
			public unsafe IntPtr Count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.RawData.NativeFieldInfoPtr_Count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.RawData.NativeFieldInfoPtr_Count)) = value;
				}
			}

			// Token: 0x17001631 RID: 5681
			// (get) Token: 0x060056DA RID: 22234 RVA: 0x00190980 File Offset: 0x0018EB80
			// (set) Token: 0x060056DB RID: 22235 RVA: 0x0001EE6B File Offset: 0x0001D06B
			public unsafe byte Data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.RawData.NativeFieldInfoPtr_Data);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.RawData.NativeFieldInfoPtr_Data)) = value;
				}
			}

			// Token: 0x04004739 RID: 18233
			private static readonly IntPtr NativeFieldInfoPtr_Bounds;

			// Token: 0x0400473A RID: 18234
			private static readonly IntPtr NativeFieldInfoPtr_Count;

			// Token: 0x0400473B RID: 18235
			private static readonly IntPtr NativeFieldInfoPtr_Data;
		}

		// Token: 0x020005A7 RID: 1447
		public sealed class InternalEnumerator<T> : ValueType
		{
			// Token: 0x060056DC RID: 22236 RVA: 0x001909A8 File Offset: 0x0018EBA8
			// Note: this type is marked as 'beforefieldinit'.
			static InternalEnumerator()
			{
				Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Array>.NativeClassPtr, "InternalEnumerator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr);
				Array.InternalEnumerator<T>.NativeFieldInfoPtr_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, "array");
				Array.InternalEnumerator<T>.NativeFieldInfoPtr_idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, "idx");
				Array.InternalEnumerator<T>.NativeMethodInfoPtr__ctor_Internal_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, 100666736);
				Array.InternalEnumerator<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, 100666737);
				Array.InternalEnumerator<T>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, 100666738);
				Array.InternalEnumerator<T>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, 100666739);
				Array.InternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, 100666740);
				Array.InternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr, 100666741);
			}

			// Token: 0x060056DD RID: 22237 RVA: 0x00190AB0 File Offset: 0x0018ECB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1335030, RefRangeEnd = 1335031, XrefRangeStart = 1335029, XrefRangeEnd = 1335030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalEnumerator(Array array)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.InternalEnumerator<T>.NativeMethodInfoPtr__ctor_Internal_Void_Array_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060056DE RID: 22238 RVA: 0x00190B00 File Offset: 0x0018ED00
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.InternalEnumerator<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056DF RID: 22239 RVA: 0x00190B38 File Offset: 0x0018ED38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335031, XrefRangeEnd = 1335032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.InternalEnumerator<T>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001634 RID: 5684
			// (get) Token: 0x060056E0 RID: 22240 RVA: 0x00190B7C File Offset: 0x0018ED7C
			public unsafe T Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335032, XrefRangeEnd = 1335035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.InternalEnumerator<T>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060056E1 RID: 22241 RVA: 0x00190BBC File Offset: 0x0018EDBC
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.InternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001635 RID: 5685
			// (get) Token: 0x060056E2 RID: 22242 RVA: 0x00190BF4 File Offset: 0x0018EDF4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335035, XrefRangeEnd = 1335039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.InternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060056E3 RID: 22243 RVA: 0x0001EE86 File Offset: 0x0001D086
			public InternalEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060056E4 RID: 22244 RVA: 0x0001EE8F File Offset: 0x0001D08F
			public InternalEnumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.InternalEnumerator<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17001632 RID: 5682
			// (get) Token: 0x060056E5 RID: 22245 RVA: 0x00190C38 File Offset: 0x0018EE38
			// (set) Token: 0x060056E6 RID: 22246 RVA: 0x0001EEA1 File Offset: 0x0001D0A1
			public unsafe Array array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.InternalEnumerator<T>.NativeFieldInfoPtr_array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.InternalEnumerator<T>.NativeFieldInfoPtr_array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001633 RID: 5683
			// (get) Token: 0x060056E7 RID: 22247 RVA: 0x00190C68 File Offset: 0x0018EE68
			// (set) Token: 0x060056E8 RID: 22248 RVA: 0x0001EEC0 File Offset: 0x0001D0C0
			public unsafe int idx
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.InternalEnumerator<T>.NativeFieldInfoPtr_idx);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.InternalEnumerator<T>.NativeFieldInfoPtr_idx)) = value;
				}
			}

			// Token: 0x0400473C RID: 18236
			private static readonly IntPtr NativeFieldInfoPtr_array;

			// Token: 0x0400473D RID: 18237
			private static readonly IntPtr NativeFieldInfoPtr_idx;

			// Token: 0x0400473E RID: 18238
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Array_0;

			// Token: 0x0400473F RID: 18239
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004740 RID: 18240
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004741 RID: 18241
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04004742 RID: 18242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004743 RID: 18243
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020005A8 RID: 1448
		public class EmptyInternalEnumerator<T> : Object
		{
			// Token: 0x060056E9 RID: 22249 RVA: 0x00190C90 File Offset: 0x0018EE90
			// Note: this type is marked as 'beforefieldinit'.
			static EmptyInternalEnumerator()
			{
				Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Array>.NativeClassPtr, "EmptyInternalEnumerator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr);
				Array.EmptyInternalEnumerator<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, "Value");
				Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, 100666742);
				Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, 100666743);
				Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, 100666744);
				Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, 100666745);
				Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, 100666746);
				Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr, 100666747);
			}

			// Token: 0x060056EA RID: 22250 RVA: 0x00190D84 File Offset: 0x0018EF84
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056EB RID: 22251 RVA: 0x00190DB8 File Offset: 0x0018EFB8
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001637 RID: 5687
			// (get) Token: 0x060056EC RID: 22252 RVA: 0x00190DF4 File Offset: 0x0018EFF4
			public unsafe virtual T Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335039, XrefRangeEnd = 1335072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x17001638 RID: 5688
			// (get) Token: 0x060056ED RID: 22253 RVA: 0x00190E30 File Offset: 0x0018F030
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335072, XrefRangeEnd = 1335108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060056EE RID: 22254 RVA: 0x00190E70 File Offset: 0x0018F070
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056EF RID: 22255 RVA: 0x00190EA4 File Offset: 0x0018F0A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmptyInternalEnumerator()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.EmptyInternalEnumerator<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.EmptyInternalEnumerator<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056F0 RID: 22256 RVA: 0x0001EEDB File Offset: 0x0001D0DB
			public EmptyInternalEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001636 RID: 5686
			// (get) Token: 0x060056F1 RID: 22257 RVA: 0x00190EE0 File Offset: 0x0018F0E0
			// (set) Token: 0x060056F2 RID: 22258 RVA: 0x0001EEE4 File Offset: 0x0001D0E4
			public unsafe static Array.EmptyInternalEnumerator<T> Value
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Array.EmptyInternalEnumerator<T>.NativeFieldInfoPtr_Value, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array.EmptyInternalEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Array.EmptyInternalEnumerator<T>.NativeFieldInfoPtr_Value, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004744 RID: 18244
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04004745 RID: 18245
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004746 RID: 18246
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004747 RID: 18247
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04004748 RID: 18248
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004749 RID: 18249
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400474A RID: 18250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020005A9 RID: 1449
		public sealed class SorterObjectArray : ValueType
		{
			// Token: 0x060056F3 RID: 22259 RVA: 0x00190F08 File Offset: 0x0018F108
			// Note: this type is marked as 'beforefieldinit'.
			static SorterObjectArray()
			{
				Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Array>.NativeClassPtr, "SorterObjectArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr);
				Array.SorterObjectArray.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, "keys");
				Array.SorterObjectArray.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, "items");
				Array.SorterObjectArray.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, "comparer");
				Array.SorterObjectArray.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100666749);
				Array.SorterObjectArray.NativeMethodInfoPtr_SwapIfGreaterWithItems_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100666750);
				Array.SorterObjectArray.NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100666751);
				Array.SorterObjectArray.NativeMethodInfoPtr_Sort_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100666752);
				Array.SorterObjectArray.NativeMethodInfoPtr_IntrospectiveSort_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100666753);
				Array.SorterObjectArray.NativeMethodInfoPtr_IntroSort_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100666754);
				Array.SorterObjectArray.NativeMethodInfoPtr_PickPivotAndPartition_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100666755);
				Array.SorterObjectArray.NativeMethodInfoPtr_Heapsort_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100666756);
				Array.SorterObjectArray.NativeMethodInfoPtr_DownHeap_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100666757);
				Array.SorterObjectArray.NativeMethodInfoPtr_InsertionSort_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr, 100666758);
			}

			// Token: 0x060056F4 RID: 22260 RVA: 0x00191038 File Offset: 0x0018F238
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1335115, RefRangeEnd = 1335117, XrefRangeStart = 1335108, XrefRangeEnd = 1335115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SorterObjectArray(Il2CppReferenceArray<Object> keys, Il2CppReferenceArray<Object> items, IComparer comparer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_IComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056F5 RID: 22261 RVA: 0x001910AC File Offset: 0x0018F2AC
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1335128, RefRangeEnd = 1335134, XrefRangeStart = 1335117, XrefRangeEnd = 1335128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SwapIfGreaterWithItems(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_SwapIfGreaterWithItems_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056F6 RID: 22262 RVA: 0x00191100 File Offset: 0x0018F300
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1335142, RefRangeEnd = 1335146, XrefRangeStart = 1335134, XrefRangeEnd = 1335142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Swap(int i, int j)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056F7 RID: 22263 RVA: 0x00191154 File Offset: 0x0018F354
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1335147, RefRangeEnd = 1335149, XrefRangeStart = 1335146, XrefRangeEnd = 1335147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Sort(int left, int length)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref left;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_Sort_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056F8 RID: 22264 RVA: 0x001911A8 File Offset: 0x0018F3A8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1335153, RefRangeEnd = 1335154, XrefRangeStart = 1335149, XrefRangeEnd = 1335153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void IntrospectiveSort(int left, int length)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref left;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_IntrospectiveSort_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056F9 RID: 22265 RVA: 0x001911FC File Offset: 0x0018F3FC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1335164, RefRangeEnd = 1335166, XrefRangeStart = 1335154, XrefRangeEnd = 1335164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void IntroSort(int lo, int hi, int depthLimit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLimit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_IntroSort_Private_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056FA RID: 22266 RVA: 0x0019125C File Offset: 0x0018F45C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1335178, RefRangeEnd = 1335179, XrefRangeStart = 1335166, XrefRangeEnd = 1335178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int PickPivotAndPartition(int lo, int hi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_PickPivotAndPartition_Private_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060056FB RID: 22267 RVA: 0x001912B8 File Offset: 0x0018F4B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1335182, RefRangeEnd = 1335183, XrefRangeStart = 1335179, XrefRangeEnd = 1335182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Heapsort(int lo, int hi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_Heapsort_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056FC RID: 22268 RVA: 0x0019130C File Offset: 0x0018F50C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1335197, RefRangeEnd = 1335199, XrefRangeStart = 1335183, XrefRangeEnd = 1335197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DownHeap(int i, int n, int lo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_DownHeap_Private_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056FD RID: 22269 RVA: 0x0019136C File Offset: 0x0018F56C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1335211, RefRangeEnd = 1335212, XrefRangeStart = 1335199, XrefRangeEnd = 1335211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void InsertionSort(int lo, int hi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterObjectArray.NativeMethodInfoPtr_InsertionSort_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060056FE RID: 22270 RVA: 0x0001EEF6 File Offset: 0x0001D0F6
			public SorterObjectArray(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060056FF RID: 22271 RVA: 0x0001EEFF File Offset: 0x0001D0FF
			public SorterObjectArray()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.SorterObjectArray>.NativeClassPtr))
			{
			}

			// Token: 0x17001639 RID: 5689
			// (get) Token: 0x06005700 RID: 22272 RVA: 0x001913C0 File Offset: 0x0018F5C0
			// (set) Token: 0x06005701 RID: 22273 RVA: 0x0001EF11 File Offset: 0x0001D111
			public unsafe Il2CppReferenceArray<Object> keys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterObjectArray.NativeFieldInfoPtr_keys);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterObjectArray.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163A RID: 5690
			// (get) Token: 0x06005702 RID: 22274 RVA: 0x001913F0 File Offset: 0x0018F5F0
			// (set) Token: 0x06005703 RID: 22275 RVA: 0x0001EF30 File Offset: 0x0001D130
			public unsafe Il2CppReferenceArray<Object> items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterObjectArray.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterObjectArray.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163B RID: 5691
			// (get) Token: 0x06005704 RID: 22276 RVA: 0x00191420 File Offset: 0x0018F620
			// (set) Token: 0x06005705 RID: 22277 RVA: 0x0001EF4F File Offset: 0x0001D14F
			public unsafe IComparer comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterObjectArray.NativeFieldInfoPtr_comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterObjectArray.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400474B RID: 18251
			private static readonly IntPtr NativeFieldInfoPtr_keys;

			// Token: 0x0400474C RID: 18252
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x0400474D RID: 18253
			private static readonly IntPtr NativeFieldInfoPtr_comparer;

			// Token: 0x0400474E RID: 18254
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_IComparer_0;

			// Token: 0x0400474F RID: 18255
			private static readonly IntPtr NativeMethodInfoPtr_SwapIfGreaterWithItems_Internal_Void_Int32_Int32_0;

			// Token: 0x04004750 RID: 18256
			private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0;

			// Token: 0x04004751 RID: 18257
			private static readonly IntPtr NativeMethodInfoPtr_Sort_Internal_Void_Int32_Int32_0;

			// Token: 0x04004752 RID: 18258
			private static readonly IntPtr NativeMethodInfoPtr_IntrospectiveSort_Private_Void_Int32_Int32_0;

			// Token: 0x04004753 RID: 18259
			private static readonly IntPtr NativeMethodInfoPtr_IntroSort_Private_Void_Int32_Int32_Int32_0;

			// Token: 0x04004754 RID: 18260
			private static readonly IntPtr NativeMethodInfoPtr_PickPivotAndPartition_Private_Int32_Int32_Int32_0;

			// Token: 0x04004755 RID: 18261
			private static readonly IntPtr NativeMethodInfoPtr_Heapsort_Private_Void_Int32_Int32_0;

			// Token: 0x04004756 RID: 18262
			private static readonly IntPtr NativeMethodInfoPtr_DownHeap_Private_Void_Int32_Int32_Int32_0;

			// Token: 0x04004757 RID: 18263
			private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Private_Void_Int32_Int32_0;
		}

		// Token: 0x020005AA RID: 1450
		public sealed class SorterGenericArray : ValueType
		{
			// Token: 0x06005706 RID: 22278 RVA: 0x00191450 File Offset: 0x0018F650
			// Note: this type is marked as 'beforefieldinit'.
			static SorterGenericArray()
			{
				Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Array>.NativeClassPtr, "SorterGenericArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr);
				Array.SorterGenericArray.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, "keys");
				Array.SorterGenericArray.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, "items");
				Array.SorterGenericArray.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, "comparer");
				Array.SorterGenericArray.NativeMethodInfoPtr__ctor_Internal_Void_Array_Array_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100666759);
				Array.SorterGenericArray.NativeMethodInfoPtr_SwapIfGreaterWithItems_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100666760);
				Array.SorterGenericArray.NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100666761);
				Array.SorterGenericArray.NativeMethodInfoPtr_Sort_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100666762);
				Array.SorterGenericArray.NativeMethodInfoPtr_IntrospectiveSort_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100666763);
				Array.SorterGenericArray.NativeMethodInfoPtr_IntroSort_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100666764);
				Array.SorterGenericArray.NativeMethodInfoPtr_PickPivotAndPartition_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100666765);
				Array.SorterGenericArray.NativeMethodInfoPtr_Heapsort_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100666766);
				Array.SorterGenericArray.NativeMethodInfoPtr_DownHeap_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100666767);
				Array.SorterGenericArray.NativeMethodInfoPtr_InsertionSort_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr, 100666768);
			}

			// Token: 0x06005707 RID: 22279 RVA: 0x00191580 File Offset: 0x0018F780
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1335219, RefRangeEnd = 1335220, XrefRangeStart = 1335212, XrefRangeEnd = 1335219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SorterGenericArray(Array keys, Array items, IComparer comparer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr__ctor_Internal_Void_Array_Array_IComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005708 RID: 22280 RVA: 0x001915F4 File Offset: 0x0018F7F4
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1335233, RefRangeEnd = 1335239, XrefRangeStart = 1335220, XrefRangeEnd = 1335233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SwapIfGreaterWithItems(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_SwapIfGreaterWithItems_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005709 RID: 22281 RVA: 0x00191648 File Offset: 0x0018F848
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1335247, RefRangeEnd = 1335251, XrefRangeStart = 1335239, XrefRangeEnd = 1335247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Swap(int i, int j)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600570A RID: 22282 RVA: 0x0019169C File Offset: 0x0018F89C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1335252, RefRangeEnd = 1335253, XrefRangeStart = 1335251, XrefRangeEnd = 1335252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Sort(int left, int length)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref left;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_Sort_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600570B RID: 22283 RVA: 0x001916F0 File Offset: 0x0018F8F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1335258, RefRangeEnd = 1335259, XrefRangeStart = 1335253, XrefRangeEnd = 1335258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void IntrospectiveSort(int left, int length)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref left;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_IntrospectiveSort_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600570C RID: 22284 RVA: 0x00191744 File Offset: 0x0018F944
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1335269, RefRangeEnd = 1335271, XrefRangeStart = 1335259, XrefRangeEnd = 1335269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void IntroSort(int lo, int hi, int depthLimit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLimit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_IntroSort_Private_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600570D RID: 22285 RVA: 0x001917A4 File Offset: 0x0018F9A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1335286, RefRangeEnd = 1335287, XrefRangeStart = 1335271, XrefRangeEnd = 1335286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int PickPivotAndPartition(int lo, int hi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_PickPivotAndPartition_Private_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600570E RID: 22286 RVA: 0x00191800 File Offset: 0x0018FA00
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1335290, RefRangeEnd = 1335291, XrefRangeStart = 1335287, XrefRangeEnd = 1335290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Heapsort(int lo, int hi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_Heapsort_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600570F RID: 22287 RVA: 0x00191854 File Offset: 0x0018FA54
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1335308, RefRangeEnd = 1335310, XrefRangeStart = 1335291, XrefRangeEnd = 1335308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DownHeap(int i, int n, int lo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_DownHeap_Private_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005710 RID: 22288 RVA: 0x001918B4 File Offset: 0x0018FAB4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1335323, RefRangeEnd = 1335324, XrefRangeStart = 1335310, XrefRangeEnd = 1335323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void InsertionSort(int lo, int hi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.SorterGenericArray.NativeMethodInfoPtr_InsertionSort_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005711 RID: 22289 RVA: 0x0001EF6E File Offset: 0x0001D16E
			public SorterGenericArray(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005712 RID: 22290 RVA: 0x0001EF77 File Offset: 0x0001D177
			public SorterGenericArray()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array.SorterGenericArray>.NativeClassPtr))
			{
			}

			// Token: 0x1700163C RID: 5692
			// (get) Token: 0x06005713 RID: 22291 RVA: 0x00191908 File Offset: 0x0018FB08
			// (set) Token: 0x06005714 RID: 22292 RVA: 0x0001EF89 File Offset: 0x0001D189
			public unsafe Array keys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterGenericArray.NativeFieldInfoPtr_keys);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterGenericArray.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163D RID: 5693
			// (get) Token: 0x06005715 RID: 22293 RVA: 0x00191938 File Offset: 0x0018FB38
			// (set) Token: 0x06005716 RID: 22294 RVA: 0x0001EFA8 File Offset: 0x0001D1A8
			public unsafe Array items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterGenericArray.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterGenericArray.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163E RID: 5694
			// (get) Token: 0x06005717 RID: 22295 RVA: 0x00191968 File Offset: 0x0018FB68
			// (set) Token: 0x06005718 RID: 22296 RVA: 0x0001EFC7 File Offset: 0x0001D1C7
			public unsafe IComparer comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterGenericArray.NativeFieldInfoPtr_comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.SorterGenericArray.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004758 RID: 18264
			private static readonly IntPtr NativeFieldInfoPtr_keys;

			// Token: 0x04004759 RID: 18265
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x0400475A RID: 18266
			private static readonly IntPtr NativeFieldInfoPtr_comparer;

			// Token: 0x0400475B RID: 18267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Array_Array_IComparer_0;

			// Token: 0x0400475C RID: 18268
			private static readonly IntPtr NativeMethodInfoPtr_SwapIfGreaterWithItems_Internal_Void_Int32_Int32_0;

			// Token: 0x0400475D RID: 18269
			private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0;

			// Token: 0x0400475E RID: 18270
			private static readonly IntPtr NativeMethodInfoPtr_Sort_Internal_Void_Int32_Int32_0;

			// Token: 0x0400475F RID: 18271
			private static readonly IntPtr NativeMethodInfoPtr_IntrospectiveSort_Private_Void_Int32_Int32_0;

			// Token: 0x04004760 RID: 18272
			private static readonly IntPtr NativeMethodInfoPtr_IntroSort_Private_Void_Int32_Int32_Int32_0;

			// Token: 0x04004761 RID: 18273
			private static readonly IntPtr NativeMethodInfoPtr_PickPivotAndPartition_Private_Int32_Int32_Int32_0;

			// Token: 0x04004762 RID: 18274
			private static readonly IntPtr NativeMethodInfoPtr_Heapsort_Private_Void_Int32_Int32_0;

			// Token: 0x04004763 RID: 18275
			private static readonly IntPtr NativeMethodInfoPtr_DownHeap_Private_Void_Int32_Int32_Int32_0;

			// Token: 0x04004764 RID: 18276
			private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Private_Void_Int32_Int32_0;
		}

		// Token: 0x020005AB RID: 1451
		private sealed class MethodInfoStoreGeneric_AsReadOnly_Public_Static_ReadOnlyCollection_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04004765 RID: 18277
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_AsReadOnly_Public_Static_ReadOnlyCollection_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005AC RID: 1452
		private sealed class MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04004766 RID: 18278
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Resize_Public_Static_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005AD RID: 1453
		private sealed class MethodInfoStoreGeneric_ConvertAll_Public_Static_Il2CppArrayBase_1_TOutput_Il2CppArrayBase_1_TInput_Converter_2_TInput_TOutput_0<TInput, TOutput>
		{
			// Token: 0x04004767 RID: 18279
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_ConvertAll_Public_Static_Il2CppArrayBase_1_TOutput_Il2CppArrayBase_1_TInput_Converter_2_TInput_TOutput_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInput>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutput>.NativeClassPtr))
			}))));
		}

		// Token: 0x020005AE RID: 1454
		private sealed class MethodInfoStoreGeneric_ForEach_Public_Static_Void_Il2CppArrayBase_1_T_Action_1_T_0<T>
		{
			// Token: 0x04004768 RID: 18280
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_ForEach_Public_Static_Void_Il2CppArrayBase_1_T_Action_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005AF RID: 1455
		private sealed class MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04004769 RID: 18281
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005B0 RID: 1456
		private sealed class MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_IComparer_1_T_0<T>
		{
			// Token: 0x0400476A RID: 18282
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_T_IComparer_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005B1 RID: 1457
		private sealed class MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_0<T>
		{
			// Token: 0x0400476B RID: 18283
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005B2 RID: 1458
		private sealed class MethodInfoStoreGeneric_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0<T>
		{
			// Token: 0x0400476C RID: 18284
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005B3 RID: 1459
		private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x0400476D RID: 18285
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005B4 RID: 1460
		private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0<T>
		{
			// Token: 0x0400476E RID: 18286
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005B5 RID: 1461
		private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>
		{
			// Token: 0x0400476F RID: 18287
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005B6 RID: 1462
		private sealed class MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x04004770 RID: 18288
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005B7 RID: 1463
		private sealed class MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0<T>
		{
			// Token: 0x04004771 RID: 18289
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005B8 RID: 1464
		private sealed class MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>
		{
			// Token: 0x04004772 RID: 18290
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005B9 RID: 1465
		private sealed class MethodInfoStoreGeneric_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04004773 RID: 18291
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005BA RID: 1466
		private sealed class MethodInfoStoreGeneric_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04004774 RID: 18292
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Reverse_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005BB RID: 1467
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04004775 RID: 18293
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005BC RID: 1468
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04004776 RID: 18294
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005BD RID: 1469
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_IComparer_1_T_0<T>
		{
			// Token: 0x04004777 RID: 18295
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_IComparer_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005BE RID: 1470
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0<T>
		{
			// Token: 0x04004778 RID: 18296
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005BF RID: 1471
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_0<T>
		{
			// Token: 0x04004779 RID: 18297
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005C0 RID: 1472
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_0<TKey, TValue>
		{
			// Token: 0x0400477A RID: 18298
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x020005C1 RID: 1473
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0<TKey, TValue>
		{
			// Token: 0x0400477B RID: 18299
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x020005C2 RID: 1474
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_0<TKey, TValue>
		{
			// Token: 0x0400477C RID: 18300
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x020005C3 RID: 1475
		private sealed class MethodInfoStoreGeneric_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0<TKey, TValue>
		{
			// Token: 0x0400477D RID: 18301
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x020005C4 RID: 1476
		private sealed class MethodInfoStoreGeneric_Exists_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x0400477E RID: 18302
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Exists_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005C5 RID: 1477
		private sealed class MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x0400477F RID: 18303
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005C6 RID: 1478
		private sealed class MethodInfoStoreGeneric_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>
		{
			// Token: 0x04004780 RID: 18304
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Fill_Public_Static_Void_Il2CppArrayBase_1_T_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005C7 RID: 1479
		private sealed class MethodInfoStoreGeneric_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04004781 RID: 18305
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Find_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005C8 RID: 1480
		private sealed class MethodInfoStoreGeneric_FindAll_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04004782 RID: 18306
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindAll_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005C9 RID: 1481
		private sealed class MethodInfoStoreGeneric_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04004783 RID: 18307
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005CA RID: 1482
		private sealed class MethodInfoStoreGeneric_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0<T>
		{
			// Token: 0x04004784 RID: 18308
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005CB RID: 1483
		private sealed class MethodInfoStoreGeneric_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0<T>
		{
			// Token: 0x04004785 RID: 18309
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005CC RID: 1484
		private sealed class MethodInfoStoreGeneric_FindLast_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04004786 RID: 18310
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindLast_Public_Static_T_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005CD RID: 1485
		private sealed class MethodInfoStoreGeneric_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04004787 RID: 18311
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005CE RID: 1486
		private sealed class MethodInfoStoreGeneric_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0<T>
		{
			// Token: 0x04004788 RID: 18312
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005CF RID: 1487
		private sealed class MethodInfoStoreGeneric_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0<T>
		{
			// Token: 0x04004789 RID: 18313
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_FindLastIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005D0 RID: 1488
		private sealed class MethodInfoStoreGeneric_TrueForAll_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x0400478A RID: 18314
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_TrueForAll_Public_Static_Boolean_Il2CppArrayBase_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005D1 RID: 1489
		private sealed class MethodInfoStoreGeneric_InternalArray__IEnumerable_GetEnumerator_Internal_IEnumerator_1_T_0<T>
		{
			// Token: 0x0400478B RID: 18315
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__IEnumerable_GetEnumerator_Internal_IEnumerator_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005D2 RID: 1490
		private sealed class MethodInfoStoreGeneric_InternalArray__ICollection_Add_Internal_Void_T_0<T>
		{
			// Token: 0x0400478C RID: 18316
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__ICollection_Add_Internal_Void_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005D3 RID: 1491
		private sealed class MethodInfoStoreGeneric_InternalArray__ICollection_Remove_Internal_Boolean_T_0<T>
		{
			// Token: 0x0400478D RID: 18317
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__ICollection_Remove_Internal_Boolean_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005D4 RID: 1492
		private sealed class MethodInfoStoreGeneric_InternalArray__ICollection_Contains_Internal_Boolean_T_0<T>
		{
			// Token: 0x0400478E RID: 18318
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__ICollection_Contains_Internal_Boolean_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005D5 RID: 1493
		private sealed class MethodInfoStoreGeneric_InternalArray__ICollection_CopyTo_Internal_Void_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x0400478F RID: 18319
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__ICollection_CopyTo_Internal_Void_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005D6 RID: 1494
		private sealed class MethodInfoStoreGeneric_InternalArray__IReadOnlyList_get_Item_Internal_T_Int32_0<T>
		{
			// Token: 0x04004790 RID: 18320
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__IReadOnlyList_get_Item_Internal_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005D7 RID: 1495
		private sealed class MethodInfoStoreGeneric_InternalArray__Insert_Internal_Void_Int32_T_0<T>
		{
			// Token: 0x04004791 RID: 18321
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__Insert_Internal_Void_Int32_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005D8 RID: 1496
		private sealed class MethodInfoStoreGeneric_InternalArray__IndexOf_Internal_Int32_T_0<T>
		{
			// Token: 0x04004792 RID: 18322
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__IndexOf_Internal_Int32_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005D9 RID: 1497
		private sealed class MethodInfoStoreGeneric_InternalArray__get_Item_Internal_T_Int32_0<T>
		{
			// Token: 0x04004793 RID: 18323
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__get_Item_Internal_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005DA RID: 1498
		private sealed class MethodInfoStoreGeneric_InternalArray__set_Item_Internal_Void_Int32_T_0<T>
		{
			// Token: 0x04004794 RID: 18324
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_InternalArray__set_Item_Internal_Void_Int32_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005DB RID: 1499
		private sealed class MethodInfoStoreGeneric_GetGenericValueImpl_Internal_Void_Int32_byref_T_0<T>
		{
			// Token: 0x04004795 RID: 18325
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_GetGenericValueImpl_Internal_Void_Int32_byref_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005DC RID: 1500
		private sealed class MethodInfoStoreGeneric_SetGenericValueImpl_Internal_Void_Int32_byref_T_0<T>
		{
			// Token: 0x04004796 RID: 18326
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_SetGenericValueImpl_Internal_Void_Int32_byref_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005DD RID: 1501
		private sealed class MethodInfoStoreGeneric_Empty_Public_Static_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04004797 RID: 18327
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_Empty_Public_Static_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005DE RID: 1502
		private sealed class MethodInfoStoreGeneric_IndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>
		{
			// Token: 0x04004798 RID: 18328
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_IndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005DF RID: 1503
		private sealed class MethodInfoStoreGeneric_LastIndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0<T>
		{
			// Token: 0x04004799 RID: 18329
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_LastIndexOfImpl_Private_Static_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005E0 RID: 1504
		private sealed class MethodInfoStoreGeneric_UnsafeLoad_Internal_Static_T_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x0400479A RID: 18330
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_UnsafeLoad_Internal_Static_T_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005E1 RID: 1505
		private sealed class MethodInfoStoreGeneric_UnsafeStore_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_T_0<T>
		{
			// Token: 0x0400479B RID: 18331
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_UnsafeStore_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_T_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005E2 RID: 1506
		private sealed class MethodInfoStoreGeneric_UnsafeMov_Internal_Static_R_S_0<S, R>
		{
			// Token: 0x0400479C RID: 18332
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Array.NativeMethodInfoPtr_UnsafeMov_Internal_Static_R_S_0, Il2CppClassPointerStore<Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<S>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<R>.NativeClassPtr))
			}))));
		}
	}
}
