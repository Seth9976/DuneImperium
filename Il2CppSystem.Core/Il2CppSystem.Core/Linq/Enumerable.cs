using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000018 RID: 24
	public static class Enumerable : Object
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x000121D4 File Offset: 0x000103D4
		// Note: this type is marked as 'beforefieldinit'.
		static Enumerable()
		{
			Il2CppClassPointerStore<Enumerable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Enumerable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable>.NativeClassPtr);
			Enumerable.NativeMethodInfoPtr_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663386);
			Enumerable.NativeMethodInfoPtr_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_3_TSource_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663387);
			Enumerable.NativeMethodInfoPtr_WhereIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_3_TSource_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663388);
			Enumerable.NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663389);
			Enumerable.NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663390);
			Enumerable.NativeMethodInfoPtr_SelectIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663391);
			Enumerable.NativeMethodInfoPtr_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663392);
			Enumerable.NativeMethodInfoPtr_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663393);
			Enumerable.NativeMethodInfoPtr_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663394);
			Enumerable.NativeMethodInfoPtr_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663395);
			Enumerable.NativeMethodInfoPtr_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TCollection_Func_3_TSource_TCollection_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663396);
			Enumerable.NativeMethodInfoPtr_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TCollection_Func_3_TSource_TCollection_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663397);
			Enumerable.NativeMethodInfoPtr_Take_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663398);
			Enumerable.NativeMethodInfoPtr_TakeIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663399);
			Enumerable.NativeMethodInfoPtr_TakeWhile_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663400);
			Enumerable.NativeMethodInfoPtr_TakeWhileIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663401);
			Enumerable.NativeMethodInfoPtr_Skip_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663402);
			Enumerable.NativeMethodInfoPtr_SkipIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663403);
			Enumerable.NativeMethodInfoPtr_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663404);
			Enumerable.NativeMethodInfoPtr_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663405);
			Enumerable.NativeMethodInfoPtr_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663406);
			Enumerable.NativeMethodInfoPtr_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663407);
			Enumerable.NativeMethodInfoPtr_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663408);
			Enumerable.NativeMethodInfoPtr_ThenByDescending_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663409);
			Enumerable.NativeMethodInfoPtr_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663410);
			Enumerable.NativeMethodInfoPtr_Concat_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663411);
			Enumerable.NativeMethodInfoPtr_ConcatIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663412);
			Enumerable.NativeMethodInfoPtr_Append_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663413);
			Enumerable.NativeMethodInfoPtr_AppendIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663414);
			Enumerable.NativeMethodInfoPtr_Prepend_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663415);
			Enumerable.NativeMethodInfoPtr_PrependIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663416);
			Enumerable.NativeMethodInfoPtr_Zip_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TFirst_IEnumerable_1_TSecond_Func_3_TFirst_TSecond_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663417);
			Enumerable.NativeMethodInfoPtr_ZipIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TFirst_IEnumerable_1_TSecond_Func_3_TFirst_TSecond_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663418);
			Enumerable.NativeMethodInfoPtr_Distinct_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663419);
			Enumerable.NativeMethodInfoPtr_DistinctIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663420);
			Enumerable.NativeMethodInfoPtr_Union_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663421);
			Enumerable.NativeMethodInfoPtr_UnionIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663422);
			Enumerable.NativeMethodInfoPtr_Intersect_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663423);
			Enumerable.NativeMethodInfoPtr_IntersectIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663424);
			Enumerable.NativeMethodInfoPtr_Except_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663425);
			Enumerable.NativeMethodInfoPtr_ExceptIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663426);
			Enumerable.NativeMethodInfoPtr_Reverse_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663427);
			Enumerable.NativeMethodInfoPtr_ReverseIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663428);
			Enumerable.NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663429);
			Enumerable.NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663430);
			Enumerable.NativeMethodInfoPtr_AsEnumerable_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663431);
			Enumerable.NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663432);
			Enumerable.NativeMethodInfoPtr_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663433);
			Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663434);
			Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663435);
			Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663436);
			Enumerable.NativeMethodInfoPtr_OfType_Public_Static_IEnumerable_1_TResult_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663437);
			Enumerable.NativeMethodInfoPtr_OfTypeIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663438);
			Enumerable.NativeMethodInfoPtr_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663439);
			Enumerable.NativeMethodInfoPtr_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663440);
			Enumerable.NativeMethodInfoPtr_First_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663441);
			Enumerable.NativeMethodInfoPtr_First_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663442);
			Enumerable.NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663443);
			Enumerable.NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663444);
			Enumerable.NativeMethodInfoPtr_Last_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663445);
			Enumerable.NativeMethodInfoPtr_Last_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663446);
			Enumerable.NativeMethodInfoPtr_LastOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663447);
			Enumerable.NativeMethodInfoPtr_LastOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663448);
			Enumerable.NativeMethodInfoPtr_Single_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663449);
			Enumerable.NativeMethodInfoPtr_Single_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663450);
			Enumerable.NativeMethodInfoPtr_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663451);
			Enumerable.NativeMethodInfoPtr_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663452);
			Enumerable.NativeMethodInfoPtr_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663453);
			Enumerable.NativeMethodInfoPtr_ElementAtOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663454);
			Enumerable.NativeMethodInfoPtr_Range_Public_Static_IEnumerable_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663455);
			Enumerable.NativeMethodInfoPtr_RangeIterator_Private_Static_IEnumerable_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663456);
			Enumerable.NativeMethodInfoPtr_Repeat_Public_Static_IEnumerable_1_TResult_TResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663457);
			Enumerable.NativeMethodInfoPtr_RepeatIterator_Private_Static_IEnumerable_1_TResult_TResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663458);
			Enumerable.NativeMethodInfoPtr_Empty_Public_Static_IEnumerable_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663459);
			Enumerable.NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663460);
			Enumerable.NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663461);
			Enumerable.NativeMethodInfoPtr_All_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663462);
			Enumerable.NativeMethodInfoPtr_Count_Public_Static_Int32_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663463);
			Enumerable.NativeMethodInfoPtr_Count_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663464);
			Enumerable.NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663465);
			Enumerable.NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663466);
			Enumerable.NativeMethodInfoPtr_Aggregate_Public_Static_TSource_IEnumerable_1_TSource_Func_3_TSource_TSource_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663467);
			Enumerable.NativeMethodInfoPtr_Aggregate_Public_Static_TAccumulate_IEnumerable_1_TSource_TAccumulate_Func_3_TAccumulate_TSource_TAccumulate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663468);
			Enumerable.NativeMethodInfoPtr_Sum_Public_Static_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663469);
			Enumerable.NativeMethodInfoPtr_Sum_Public_Static_Double_IEnumerable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663470);
			Enumerable.NativeMethodInfoPtr_Sum_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663471);
			Enumerable.NativeMethodInfoPtr_Sum_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663472);
			Enumerable.NativeMethodInfoPtr_Min_Public_Static_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663473);
			Enumerable.NativeMethodInfoPtr_Min_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663474);
			Enumerable.NativeMethodInfoPtr_Min_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663475);
			Enumerable.NativeMethodInfoPtr_Min_Public_Static_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663476);
			Enumerable.NativeMethodInfoPtr_Max_Public_Static_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663477);
			Enumerable.NativeMethodInfoPtr_Max_Public_Static_Int64_IEnumerable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663478);
			Enumerable.NativeMethodInfoPtr_Max_Public_Static_Double_IEnumerable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663479);
			Enumerable.NativeMethodInfoPtr_Max_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663480);
			Enumerable.NativeMethodInfoPtr_Max_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663481);
			Enumerable.NativeMethodInfoPtr_Max_Public_Static_Int64_IEnumerable_1_TSource_Func_2_TSource_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663482);
			Enumerable.NativeMethodInfoPtr_Max_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663483);
			Enumerable.NativeMethodInfoPtr_Max_Public_Static_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663484);
			Enumerable.NativeMethodInfoPtr_Average_Public_Static_Double_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663485);
			Enumerable.NativeMethodInfoPtr_Average_Public_Static_Double_IEnumerable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663486);
			Enumerable.NativeMethodInfoPtr_Average_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663487);
			Enumerable.NativeMethodInfoPtr_Average_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663488);
			Enumerable.NativeMethodInfoPtr_ToHashSet_Public_Static_HashSet_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663489);
			Enumerable.NativeMethodInfoPtr_ToHashSet_Public_Static_HashSet_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663490);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00012A38 File Offset: 0x00010C38
		[CallerCount(516)]
		[CachedScanResults(RefRangeStart = 1003660, RefRangeEnd = 1004176, XrefRangeStart = 1003639, XrefRangeEnd = 1003660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00012A90 File Offset: 0x00010C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004183, RefRangeEnd = 1004184, XrefRangeStart = 1004176, XrefRangeEnd = 1004183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_3_TSource_Int32_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00012AE8 File Offset: 0x00010CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004184, XrefRangeEnd = 1004190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> WhereIterator<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_WhereIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_3_TSource_Int32_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00012B40 File Offset: 0x00010D40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1004212, RefRangeEnd = 1004216, XrefRangeStart = 1004190, XrefRangeEnd = 1004212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00012B98 File Offset: 0x00010D98
		[CallerCount(142)]
		[CachedScanResults(RefRangeStart = 1004223, RefRangeEnd = 1004365, XrefRangeStart = 1004216, XrefRangeEnd = 1004223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00012BF0 File Offset: 0x00010DF0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 756206, RefRangeEnd = 756213, XrefRangeStart = 756206, XrefRangeEnd = 756213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SelectIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00012C48 File Offset: 0x00010E48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1004374, RefRangeEnd = 1004377, XrefRangeStart = 1004365, XrefRangeEnd = 1004374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr3) : null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00012CA0 File Offset: 0x00010EA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1004386, RefRangeEnd = 1004389, XrefRangeStart = 1004377, XrefRangeEnd = 1004386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0<TSource, TMiddle, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr3) : null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00012CF8 File Offset: 0x00010EF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1004396, RefRangeEnd = 1004400, XrefRangeStart = 1004389, XrefRangeEnd = 1004396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00012D50 File Offset: 0x00010F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00012DA8 File Offset: 0x00010FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004408, RefRangeEnd = 1004409, XrefRangeStart = 1004400, XrefRangeEnd = 1004408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultSelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TCollection_Func_3_TSource_TCollection_TResult_0<TSource, TCollection, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00012E10 File Offset: 0x00011010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004409, XrefRangeEnd = 1004416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> SelectManyIterator<TSource, TCollection, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultSelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TCollection_Func_3_TSource_TCollection_TResult_0<TSource, TCollection, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00012E78 File Offset: 0x00011078
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1004422, RefRangeEnd = 1004427, XrefRangeStart = 1004416, XrefRangeEnd = 1004422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Take_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00012ECC File Offset: 0x000110CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004427, XrefRangeEnd = 1004432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_TakeIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00012F20 File Offset: 0x00011120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1004439, RefRangeEnd = 1004441, XrefRangeStart = 1004432, XrefRangeEnd = 1004439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> TakeWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_TakeWhile_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00012F78 File Offset: 0x00011178
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 756206, RefRangeEnd = 756213, XrefRangeStart = 756206, XrefRangeEnd = 756213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> TakeWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_TakeWhileIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00012FD0 File Offset: 0x000111D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1004447, RefRangeEnd = 1004450, XrefRangeStart = 1004441, XrefRangeEnd = 1004447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Skip_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00013024 File Offset: 0x00011224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1004455, RefRangeEnd = 1004457, XrefRangeStart = 1004450, XrefRangeEnd = 1004455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SkipIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00013078 File Offset: 0x00011278
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1004461, RefRangeEnd = 1004488, XrefRangeStart = 1004457, XrefRangeEnd = 1004461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000130D0 File Offset: 0x000112D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004492, RefRangeEnd = 1004493, XrefRangeStart = 1004488, XrefRangeEnd = 1004492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IComparer_1_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00013138 File Offset: 0x00011338
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1004497, RefRangeEnd = 1004528, XrefRangeStart = 1004493, XrefRangeEnd = 1004497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00013190 File Offset: 0x00011390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004532, RefRangeEnd = 1004533, XrefRangeStart = 1004528, XrefRangeEnd = 1004532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IComparer_1_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000131F8 File Offset: 0x000113F8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1004536, RefRangeEnd = 1004544, XrefRangeStart = 1004533, XrefRangeEnd = 1004536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00013250 File Offset: 0x00011450
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1004547, RefRangeEnd = 1004555, XrefRangeStart = 1004544, XrefRangeEnd = 1004547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ThenByDescending_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000132A8 File Offset: 0x000114A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004560, RefRangeEnd = 1004561, XrefRangeStart = 1004555, XrefRangeEnd = 1004560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IGrouping<TKey, TSource>>>(intPtr3) : null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00013300 File Offset: 0x00011500
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1004568, RefRangeEnd = 1004570, XrefRangeStart = 1004561, XrefRangeEnd = 1004568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Concat_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00013358 File Offset: 0x00011558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ConcatIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000133B0 File Offset: 0x000115B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004577, RefRangeEnd = 1004578, XrefRangeStart = 1004570, XrefRangeEnd = 1004577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Append<TSource>(this IEnumerable<TSource> source, TSource element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TSource).IsValueType)
			{
				TSource tsource = element;
				intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref element;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Append_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr4) : null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0001343C File Offset: 0x0001163C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004578, XrefRangeEnd = 1004584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> AppendIterator<TSource>(IEnumerable<TSource> source, TSource element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TSource).IsValueType)
			{
				TSource tsource = element;
				intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref element;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_AppendIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr4) : null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000134C8 File Offset: 0x000116C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004590, RefRangeEnd = 1004591, XrefRangeStart = 1004584, XrefRangeEnd = 1004590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Prepend<TSource>(this IEnumerable<TSource> source, TSource element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TSource).IsValueType)
			{
				TSource tsource = element;
				intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref element;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Prepend_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr4) : null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00013554 File Offset: 0x00011754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004591, XrefRangeEnd = 1004596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> PrependIterator<TSource>(IEnumerable<TSource> source, TSource element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TSource).IsValueType)
			{
				TSource tsource = element;
				intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref element;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_PrependIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr4) : null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000135E0 File Offset: 0x000117E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004604, RefRangeEnd = 1004605, XrefRangeStart = 1004596, XrefRangeEnd = 1004604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultSelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Zip_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TFirst_IEnumerable_1_TSecond_Func_3_TFirst_TSecond_TResult_0<TFirst, TSecond, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00013648 File Offset: 0x00011848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004605, XrefRangeEnd = 1004612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TResult>(IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultSelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ZipIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TFirst_IEnumerable_1_TSecond_Func_3_TFirst_TSecond_TResult_0<TFirst, TSecond, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000136B0 File Offset: 0x000118B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1004619, RefRangeEnd = 1004626, XrefRangeStart = 1004612, XrefRangeEnd = 1004619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Distinct_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000136F4 File Offset: 0x000118F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004626, XrefRangeEnd = 1004632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_DistinctIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0001374C File Offset: 0x0001194C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004632, XrefRangeEnd = 1004640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Union_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000137A4 File Offset: 0x000119A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004640, XrefRangeEnd = 1004647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_UnionIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0001380C File Offset: 0x00011A0C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1004655, RefRangeEnd = 1004673, XrefRangeStart = 1004647, XrefRangeEnd = 1004655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Intersect_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00013864 File Offset: 0x00011A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004673, XrefRangeEnd = 1004680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> IntersectIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_IntersectIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000138CC File Offset: 0x00011ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004688, RefRangeEnd = 1004689, XrefRangeStart = 1004680, XrefRangeEnd = 1004688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Except_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00013924 File Offset: 0x00011B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004689, XrefRangeEnd = 1004696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ExceptIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0001398C File Offset: 0x00011B8C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1004702, RefRangeEnd = 1004710, XrefRangeStart = 1004696, XrefRangeEnd = 1004702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Reverse_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000139D0 File Offset: 0x00011BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43475, RefRangeEnd = 43477, XrefRangeStart = 43475, XrefRangeEnd = 43477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ReverseIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00013A14 File Offset: 0x00011C14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1004712, RefRangeEnd = 1004714, XrefRangeStart = 1004710, XrefRangeEnd = 1004712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SequenceEqual_Public_Static_Boolean_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00013A68 File Offset: 0x00011C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004758, RefRangeEnd = 1004759, XrefRangeStart = 1004714, XrefRangeEnd = 1004758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SequenceEqual_Public_Static_Boolean_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00013AD0 File Offset: 0x00011CD0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> AsEnumerable<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_AsEnumerable_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00013B14 File Offset: 0x00011D14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004762, RefRangeEnd = 1004763, XrefRangeStart = 1004759, XrefRangeEnd = 1004762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<TSource> ToArray<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<TSource>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00013B50 File Offset: 0x00011D50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1004767, RefRangeEnd = 1004769, XrefRangeStart = 1004763, XrefRangeEnd = 1004767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TSource>>(intPtr3) : null;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00013B94 File Offset: 0x00011D94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1004772, RefRangeEnd = 1004776, XrefRangeStart = 1004769, XrefRangeEnd = 1004772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TSource>>(intPtr3) : null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00013BEC File Offset: 0x00011DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004778, RefRangeEnd = 1004779, XrefRangeStart = 1004776, XrefRangeEnd = 1004778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementSelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_0<TSource, TKey, TElement>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TElement>>(intPtr3) : null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00013C54 File Offset: 0x00011E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004799, RefRangeEnd = 1004800, XrefRangeStart = 1004779, XrefRangeEnd = 1004799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementSelector);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0<TSource, TKey, TElement>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TElement>>(intPtr3) : null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00013CD0 File Offset: 0x00011ED0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1004806, RefRangeEnd = 1004809, XrefRangeStart = 1004800, XrefRangeEnd = 1004806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_OfType_Public_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00013D14 File Offset: 0x00011F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004809, XrefRangeEnd = 1004814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_OfTypeIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00013D58 File Offset: 0x00011F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004822, RefRangeEnd = 1004823, XrefRangeStart = 1004814, XrefRangeEnd = 1004822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00013D9C File Offset: 0x00011F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004823, XrefRangeEnd = 1004828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00013DE0 File Offset: 0x00011FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004843, RefRangeEnd = 1004844, XrefRangeStart = 1004828, XrefRangeEnd = 1004843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource First<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_First_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00013E20 File Offset: 0x00012020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004855, RefRangeEnd = 1004856, XrefRangeStart = 1004844, XrefRangeEnd = 1004855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_First_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00013E70 File Offset: 0x00012070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1004878, RefRangeEnd = 1004880, XrefRangeStart = 1004856, XrefRangeEnd = 1004878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00013EB0 File Offset: 0x000120B0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1004891, RefRangeEnd = 1004909, XrefRangeStart = 1004880, XrefRangeEnd = 1004891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00013F00 File Offset: 0x00012100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1004926, RefRangeEnd = 1004927, XrefRangeStart = 1004909, XrefRangeEnd = 1004926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource Last<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Last_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00013F40 File Offset: 0x00012140
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1004943, RefRangeEnd = 1004947, XrefRangeStart = 1004927, XrefRangeEnd = 1004943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource Last<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Last_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00013F90 File Offset: 0x00012190
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1004965, RefRangeEnd = 1004974, XrefRangeStart = 1004947, XrefRangeEnd = 1004965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_LastOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00013FD0 File Offset: 0x000121D0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1004990, RefRangeEnd = 1004999, XrefRangeStart = 1004974, XrefRangeEnd = 1004990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_LastOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00014020 File Offset: 0x00012220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1005016, RefRangeEnd = 1005018, XrefRangeStart = 1004999, XrefRangeEnd = 1005016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource Single<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Single_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00014060 File Offset: 0x00012260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1005034, RefRangeEnd = 1005036, XrefRangeStart = 1005018, XrefRangeEnd = 1005034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Single_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000140B0 File Offset: 0x000122B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005036, XrefRangeEnd = 1005060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000140F0 File Offset: 0x000122F0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1005075, RefRangeEnd = 1005084, XrefRangeStart = 1005060, XrefRangeEnd = 1005075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00014140 File Offset: 0x00012340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1005102, RefRangeEnd = 1005104, XrefRangeStart = 1005084, XrefRangeEnd = 1005102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0001418C File Offset: 0x0001238C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005119, RefRangeEnd = 1005120, XrefRangeStart = 1005104, XrefRangeEnd = 1005119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ElementAtOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000141D8 File Offset: 0x000123D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1005125, RefRangeEnd = 1005130, XrefRangeStart = 1005120, XrefRangeEnd = 1005125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> Range(int start, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.NativeMethodInfoPtr_Range_Public_Static_IEnumerable_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00014228 File Offset: 0x00012428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005130, XrefRangeEnd = 1005135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> RangeIterator(int start, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.NativeMethodInfoPtr_RangeIterator_Private_Static_IEnumerable_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00014278 File Offset: 0x00012478
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 1005141, RefRangeEnd = 1005179, XrefRangeStart = 1005135, XrefRangeEnd = 1005141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = element;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref element;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Repeat_Public_Static_IEnumerable_1_TResult_TResult_Int32_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr4) : null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00014300 File Offset: 0x00012500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> RepeatIterator<TResult>(TResult element, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = element;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref element;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_RepeatIterator_Private_Static_IEnumerable_1_TResult_TResult_Int32_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr4) : null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00014388 File Offset: 0x00012588
		[CallerCount(495)]
		[CachedScanResults(RefRangeStart = 739664, RefRangeEnd = 740159, XrefRangeStart = 739664, XrefRangeEnd = 740159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Empty<TResult>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Empty_Public_Static_IEnumerable_1_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000143BC File Offset: 0x000125BC
		[CallerCount(290)]
		[CachedScanResults(RefRangeStart = 1005191, RefRangeEnd = 1005481, XrefRangeStart = 1005179, XrefRangeEnd = 1005191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Any<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Any_Public_Static_Boolean_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00014400 File Offset: 0x00012600
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1005492, RefRangeEnd = 1005500, XrefRangeStart = 1005481, XrefRangeEnd = 1005492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00014454 File Offset: 0x00012654
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1005511, RefRangeEnd = 1005517, XrefRangeStart = 1005500, XrefRangeEnd = 1005511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_All_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000144A8 File Offset: 0x000126A8
		[CallerCount(166)]
		[CachedScanResults(RefRangeStart = 1005535, RefRangeEnd = 1005701, XrefRangeStart = 1005517, XrefRangeEnd = 1005535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Count_Public_Static_Int32_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000144EC File Offset: 0x000126EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1005717, RefRangeEnd = 1005719, XrefRangeStart = 1005701, XrefRangeEnd = 1005717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Count_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00014540 File Offset: 0x00012740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1005726, RefRangeEnd = 1005728, XrefRangeStart = 1005719, XrefRangeEnd = 1005726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TSource).IsValueType)
			{
				TSource tsource = value;
				intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000145CC File Offset: 0x000127CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005752, RefRangeEnd = 1005753, XrefRangeStart = 1005728, XrefRangeEnd = 1005752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TSource).IsValueType)
			{
				TSource tsource = value;
				intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00014668 File Offset: 0x00012868
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1005772, RefRangeEnd = 1005780, XrefRangeStart = 1005753, XrefRangeEnd = 1005772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Aggregate_Public_Static_TSource_IEnumerable_1_TSource_Func_3_TSource_TSource_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000146B8 File Offset: 0x000128B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005796, RefRangeEnd = 1005797, XrefRangeStart = 1005780, XrefRangeEnd = 1005796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TAccumulate).IsValueType)
			{
				TAccumulate taccumulate = seed;
				intPtr = ((taccumulate is string) ? IL2CPP.ManagedStringToIl2Cpp(taccumulate as string) : IL2CPP.Il2CppObjectBaseToPtr(taccumulate as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref seed;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Aggregate_Public_Static_TAccumulate_IEnumerable_1_TSource_TAccumulate_Func_3_TAccumulate_TSource_TAccumulate_0<TSource, TAccumulate>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TAccumulate>(intPtr2, false, true);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00014750 File Offset: 0x00012950
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1005814, RefRangeEnd = 1005818, XrefRangeStart = 1005797, XrefRangeEnd = 1005814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Sum(this IEnumerable<int> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.NativeMethodInfoPtr_Sum_Public_Static_Int32_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00014794 File Offset: 0x00012994
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1005835, RefRangeEnd = 1005839, XrefRangeStart = 1005818, XrefRangeEnd = 1005835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Sum(this IEnumerable<double> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.NativeMethodInfoPtr_Sum_Public_Static_Double_IEnumerable_1_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000147D8 File Offset: 0x000129D8
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 1005847, RefRangeEnd = 1005897, XrefRangeStart = 1005839, XrefRangeEnd = 1005847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Sum_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0001482C File Offset: 0x00012A2C
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1005900, RefRangeEnd = 1005926, XrefRangeStart = 1005897, XrefRangeEnd = 1005900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Sum_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00014880 File Offset: 0x00012A80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1005944, RefRangeEnd = 1005951, XrefRangeStart = 1005926, XrefRangeEnd = 1005944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Min(this IEnumerable<int> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.NativeMethodInfoPtr_Min_Public_Static_Int32_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000148C4 File Offset: 0x00012AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005968, RefRangeEnd = 1005969, XrefRangeStart = 1005951, XrefRangeEnd = 1005968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource Min<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Min_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00014904 File Offset: 0x00012B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1005972, RefRangeEnd = 1005973, XrefRangeStart = 1005969, XrefRangeEnd = 1005972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Min_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00014958 File Offset: 0x00012B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1005973, XrefRangeEnd = 1005976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TResult Min<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Min_Public_Static_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000149A8 File Offset: 0x00012BA8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1005994, RefRangeEnd = 1006002, XrefRangeStart = 1005976, XrefRangeEnd = 1005994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Max(this IEnumerable<int> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.NativeMethodInfoPtr_Max_Public_Static_Int32_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000149EC File Offset: 0x00012BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006020, RefRangeEnd = 1006021, XrefRangeStart = 1006002, XrefRangeEnd = 1006020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Max(this IEnumerable<long> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.NativeMethodInfoPtr_Max_Public_Static_Int64_IEnumerable_1_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00014A30 File Offset: 0x00012C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006039, RefRangeEnd = 1006040, XrefRangeStart = 1006021, XrefRangeEnd = 1006039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Max(this IEnumerable<double> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.NativeMethodInfoPtr_Max_Public_Static_Double_IEnumerable_1_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00014A74 File Offset: 0x00012C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006058, RefRangeEnd = 1006059, XrefRangeStart = 1006040, XrefRangeEnd = 1006058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource Max<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Max_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00014AB4 File Offset: 0x00012CB4
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1006079, RefRangeEnd = 1006098, XrefRangeStart = 1006059, XrefRangeEnd = 1006079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Max_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00014B08 File Offset: 0x00012D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006166, RefRangeEnd = 1006167, XrefRangeStart = 1006098, XrefRangeEnd = 1006166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Max<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Max_Public_Static_Int64_IEnumerable_1_TSource_Func_2_TSource_Int64_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00014B5C File Offset: 0x00012D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006170, RefRangeEnd = 1006171, XrefRangeStart = 1006167, XrefRangeEnd = 1006170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Max<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Max_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00014BB0 File Offset: 0x00012DB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1006174, RefRangeEnd = 1006177, XrefRangeStart = 1006171, XrefRangeEnd = 1006174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TResult Max<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Max_Public_Static_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00014C00 File Offset: 0x00012E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006194, RefRangeEnd = 1006195, XrefRangeStart = 1006177, XrefRangeEnd = 1006194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Average(this IEnumerable<int> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.NativeMethodInfoPtr_Average_Public_Static_Double_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00014C44 File Offset: 0x00012E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006212, RefRangeEnd = 1006213, XrefRangeStart = 1006195, XrefRangeEnd = 1006212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Average(this IEnumerable<double> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.NativeMethodInfoPtr_Average_Public_Static_Double_IEnumerable_1_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00014C88 File Offset: 0x00012E88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1006216, RefRangeEnd = 1006220, XrefRangeStart = 1006213, XrefRangeEnd = 1006216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Average_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00014CDC File Offset: 0x00012EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006223, RefRangeEnd = 1006224, XrefRangeStart = 1006220, XrefRangeEnd = 1006223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Average_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00014D30 File Offset: 0x00012F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006229, RefRangeEnd = 1006230, XrefRangeStart = 1006224, XrefRangeEnd = 1006229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashSet<TSource> ToHashSet<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToHashSet_Public_Static_HashSet_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<TSource>>(intPtr3) : null;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00014D74 File Offset: 0x00012F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006230, XrefRangeEnd = 1006234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashSet<TSource> ToHashSet<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToHashSet_Public_Static_HashSet_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<TSource>>(intPtr3) : null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002297 File Offset: 0x00000497
		public Enumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_3_TSource_Int32_Boolean_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_WhereIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_3_TSource_Int32_Boolean_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_SelectIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TCollection_Func_3_TSource_TCollection_TResult_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TCollection_Func_3_TSource_TCollection_TResult_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_Take_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_TakeIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_TakeWhile_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_TakeWhileIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_Skip_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_SkipIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IComparer_1_TKey_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IComparer_1_TKey_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_ThenByDescending_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_ConcatIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_AppendIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_Prepend_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_PrependIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_Zip_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TFirst_IEnumerable_1_TSecond_Func_3_TFirst_TSecond_TResult_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_ZipIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TFirst_IEnumerable_1_TSecond_Func_3_TFirst_TSecond_TResult_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_Distinct_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_DistinctIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_Union_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_UnionIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_Intersect_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_IntersectIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_Except_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_ExceptIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_ReverseIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_AsEnumerable_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_OfType_Public_Static_IEnumerable_1_TResult_IEnumerable_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_OfTypeIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_First_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_First_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_Last_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_Last_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_LastOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_LastOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_Single_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_Single_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_ElementAtOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Int32_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_Range_Public_Static_IEnumerable_1_Int32_Int32_Int32_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_RangeIterator_Private_Static_IEnumerable_1_Int32_Int32_Int32_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_Repeat_Public_Static_IEnumerable_1_TResult_TResult_Int32_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_RepeatIterator_Private_Static_IEnumerable_1_TResult_TResult_Int32_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_Empty_Public_Static_IEnumerable_1_TResult_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_All_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_IEnumerable_1_TSource_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_Aggregate_Public_Static_TSource_IEnumerable_1_TSource_Func_3_TSource_TSource_TSource_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_Aggregate_Public_Static_TAccumulate_IEnumerable_1_TSource_TAccumulate_Func_3_TAccumulate_TSource_TAccumulate_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_Sum_Public_Static_Int32_IEnumerable_1_Int32_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_Sum_Public_Static_Double_IEnumerable_1_Double_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_Sum_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_Sum_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int32_IEnumerable_1_Int32_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int32_IEnumerable_1_Int32_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int64_IEnumerable_1_Int64_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Double_IEnumerable_1_Double_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int64_IEnumerable_1_TSource_Func_2_TSource_Int64_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_Average_Public_Static_Double_IEnumerable_1_Int32_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_Average_Public_Static_Double_IEnumerable_1_Double_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_Average_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Int32_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_Average_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_ToHashSet_Public_Static_HashSet_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_ToHashSet_Public_Static_HashSet_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0;

		// Token: 0x02000138 RID: 312
		public class Iterator<TSource> : Object
		{
			// Token: 0x060012A1 RID: 4769 RVA: 0x00060090 File Offset: 0x0005E290
			// Note: this type is marked as 'beforefieldinit'.
			static Iterator()
			{
				Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "Iterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr);
				Enumerable.Iterator<TSource>.NativeFieldInfoPtr_threadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, "threadId");
				Enumerable.Iterator<TSource>.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, "state");
				Enumerable.Iterator<TSource>.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, "current");
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663491);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663492);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663493);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663494);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663495);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663496);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663497);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Where_Public_Abstract_Virtual_New_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663498);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663499);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663500);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663501);
			}

			// Token: 0x060012A2 RID: 4770 RVA: 0x00060210 File Offset: 0x0005E410
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 1002535, RefRangeEnd = 1002559, XrefRangeStart = 1002532, XrefRangeEnd = 1002535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Iterator()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700058F RID: 1423
			// (get) Token: 0x060012A3 RID: 4771 RVA: 0x0006024C File Offset: 0x0005E44C
			public unsafe virtual TSource Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x060012A4 RID: 4772 RVA: 0x00060288 File Offset: 0x0005E488
			[CallerCount(0)]
			public unsafe virtual Enumerable.Iterator<TSource> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TSource>>(intPtr3) : null;
			}

			// Token: 0x060012A5 RID: 4773 RVA: 0x000602D4 File Offset: 0x0005E4D4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1002559, RefRangeEnd = 1002563, XrefRangeStart = 1002559, XrefRangeEnd = 1002559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012A6 RID: 4774 RVA: 0x00060310 File Offset: 0x0005E510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002563, XrefRangeEnd = 1002565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<TSource> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x060012A7 RID: 4775 RVA: 0x00060350 File Offset: 0x0005E550
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060012A8 RID: 4776 RVA: 0x00060398 File Offset: 0x0005E598
			[CallerCount(0)]
			public unsafe virtual IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TResult>.MethodInfoStoreGeneric_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x060012A9 RID: 4777 RVA: 0x000603F4 File Offset: 0x0005E5F4
			[CallerCount(0)]
			public unsafe virtual IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Where_Public_Abstract_Virtual_New_IEnumerable_1_TSource_Func_2_TSource_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
				}
			}

			// Token: 0x17000590 RID: 1424
			// (get) Token: 0x060012AA RID: 4778 RVA: 0x00060450 File Offset: 0x0005E650
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002565, XrefRangeEnd = 1002566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060012AB RID: 4779 RVA: 0x00060490 File Offset: 0x0005E690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002566, XrefRangeEnd = 1002568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060012AC RID: 4780 RVA: 0x000604D0 File Offset: 0x0005E6D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012AD RID: 4781 RVA: 0x00007B70 File Offset: 0x00005D70
			public Iterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700058C RID: 1420
			// (get) Token: 0x060012AE RID: 4782 RVA: 0x00060504 File Offset: 0x0005E704
			// (set) Token: 0x060012AF RID: 4783 RVA: 0x00007B79 File Offset: 0x00005D79
			public unsafe int threadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_threadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_threadId)) = value;
				}
			}

			// Token: 0x1700058D RID: 1421
			// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0006052C File Offset: 0x0005E72C
			// (set) Token: 0x060012B1 RID: 4785 RVA: 0x00007B94 File Offset: 0x00005D94
			public unsafe int state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x1700058E RID: 1422
			// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00060554 File Offset: 0x0005E754
			// (set) Token: 0x060012B3 RID: 4787 RVA: 0x0006057C File Offset: 0x0005E77C
			public unsafe TSource current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x04000D63 RID: 3427
			private static readonly IntPtr NativeFieldInfoPtr_threadId;

			// Token: 0x04000D64 RID: 3428
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x04000D65 RID: 3429
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x04000D66 RID: 3430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000D67 RID: 3431
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000D68 RID: 3432
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Iterator_1_TSource_0;

			// Token: 0x04000D69 RID: 3433
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

			// Token: 0x04000D6A RID: 3434
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000D6B RID: 3435
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0;

			// Token: 0x04000D6C RID: 3436
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0;

			// Token: 0x04000D6D RID: 3437
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Abstract_Virtual_New_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x04000D6E RID: 3438
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D6F RID: 3439
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04000D70 RID: 3440
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0200035F RID: 863
			private sealed class MethodInfoStoreGeneric_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0
			{
				// Token: 0x0400131A RID: 4890
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.Iterator<TResult>.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable.Iterator<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000139 RID: 313
		public class WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x060012B4 RID: 4788 RVA: 0x00060624 File Offset: 0x0005E824
			// Note: this type is marked as 'beforefieldinit'.
			static WhereEnumerableIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereEnumerableIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr);
				Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, "source");
				Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, "predicate");
				Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, "enumerator");
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663502);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663503);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663504);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663505);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663506);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663507);
			}

			// Token: 0x060012B5 RID: 4789 RVA: 0x00060740 File Offset: 0x0005E940
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1002585, RefRangeEnd = 1002588, XrefRangeStart = 1002568, XrefRangeEnd = 1002585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012B6 RID: 4790 RVA: 0x000607A0 File Offset: 0x0005E9A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002588, XrefRangeEnd = 1002593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TSource> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TSource>>(intPtr3) : null;
			}

			// Token: 0x060012B7 RID: 4791 RVA: 0x000607EC File Offset: 0x0005E9EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002593, XrefRangeEnd = 1002610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012B8 RID: 4792 RVA: 0x00060828 File Offset: 0x0005EA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002610, XrefRangeEnd = 1002621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060012B9 RID: 4793 RVA: 0x00060870 File Offset: 0x0005EA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002621, XrefRangeEnd = 1002625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TResult>.MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x060012BA RID: 4794 RVA: 0x000608CC File Offset: 0x0005EACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002625, XrefRangeEnd = 1002631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
				}
			}

			// Token: 0x060012BB RID: 4795 RVA: 0x00007BAF File Offset: 0x00005DAF
			public WhereEnumerableIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000591 RID: 1425
			// (get) Token: 0x060012BC RID: 4796 RVA: 0x00060928 File Offset: 0x0005EB28
			// (set) Token: 0x060012BD RID: 4797 RVA: 0x00007BB8 File Offset: 0x00005DB8
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000592 RID: 1426
			// (get) Token: 0x060012BE RID: 4798 RVA: 0x00060958 File Offset: 0x0005EB58
			// (set) Token: 0x060012BF RID: 4799 RVA: 0x00007BD7 File Offset: 0x00005DD7
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000593 RID: 1427
			// (get) Token: 0x060012C0 RID: 4800 RVA: 0x00060988 File Offset: 0x0005EB88
			// (set) Token: 0x060012C1 RID: 4801 RVA: 0x00007BF6 File Offset: 0x00005DF6
			public unsafe IEnumerator<TSource> enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D71 RID: 3441
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000D72 RID: 3442
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04000D73 RID: 3443
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x04000D74 RID: 3444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x04000D75 RID: 3445
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0;

			// Token: 0x04000D76 RID: 3446
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

			// Token: 0x04000D77 RID: 3447
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x04000D78 RID: 3448
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0;

			// Token: 0x04000D79 RID: 3449
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x02000360 RID: 864
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0
			{
				// Token: 0x0400131B RID: 4891
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.WhereEnumerableIterator<TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x0200013A RID: 314
		public class WhereArrayIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x060012C2 RID: 4802 RVA: 0x000609B8 File Offset: 0x0005EBB8
			// Note: this type is marked as 'beforefieldinit'.
			static WhereArrayIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereArrayIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr);
				Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, "source");
				Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, "predicate");
				Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, "index");
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663508);
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663509);
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663510);
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663511);
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663512);
			}

			// Token: 0x060012C3 RID: 4803 RVA: 0x00060AC0 File Offset: 0x0005ECC0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1002585, RefRangeEnd = 1002588, XrefRangeStart = 1002585, XrefRangeEnd = 1002588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WhereArrayIterator(Il2CppArrayBase<TSource> source, Func<TSource, bool> predicate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012C4 RID: 4804 RVA: 0x00060B20 File Offset: 0x0005ED20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TSource> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TSource>>(intPtr3) : null;
			}

			// Token: 0x060012C5 RID: 4805 RVA: 0x00060B6C File Offset: 0x0005ED6C
			[CallerCount(0)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060012C6 RID: 4806 RVA: 0x00060BB4 File Offset: 0x0005EDB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereArrayIterator<TResult>.MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x060012C7 RID: 4807 RVA: 0x00060C10 File Offset: 0x0005EE10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002631, XrefRangeEnd = 1002637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
				}
			}

			// Token: 0x060012C8 RID: 4808 RVA: 0x00007C15 File Offset: 0x00005E15
			public WhereArrayIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000594 RID: 1428
			// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00060C6C File Offset: 0x0005EE6C
			// (set) Token: 0x060012CA RID: 4810 RVA: 0x00007C1E File Offset: 0x00005E1E
			public unsafe Il2CppArrayBase<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_source);
					return Il2CppArrayBase<TSource>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000595 RID: 1429
			// (get) Token: 0x060012CB RID: 4811 RVA: 0x00060C94 File Offset: 0x0005EE94
			// (set) Token: 0x060012CC RID: 4812 RVA: 0x00007C3D File Offset: 0x00005E3D
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000596 RID: 1430
			// (get) Token: 0x060012CD RID: 4813 RVA: 0x00060CC4 File Offset: 0x0005EEC4
			// (set) Token: 0x060012CE RID: 4814 RVA: 0x00007C5C File Offset: 0x00005E5C
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x04000D7A RID: 3450
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000D7B RID: 3451
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04000D7C RID: 3452
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04000D7D RID: 3453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x04000D7E RID: 3454
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0;

			// Token: 0x04000D7F RID: 3455
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x04000D80 RID: 3456
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0;

			// Token: 0x04000D81 RID: 3457
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x02000361 RID: 865
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0
			{
				// Token: 0x0400131C RID: 4892
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.WhereArrayIterator<TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x0200013B RID: 315
		public class WhereListIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x060012CF RID: 4815 RVA: 0x00060CEC File Offset: 0x0005EEEC
			// Note: this type is marked as 'beforefieldinit'.
			static WhereListIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereListIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr);
				Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, "source");
				Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, "predicate");
				Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, "enumerator");
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663513);
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663514);
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663515);
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663516);
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663517);
			}

			// Token: 0x060012D0 RID: 4816 RVA: 0x00060DF4 File Offset: 0x0005EFF4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1002585, RefRangeEnd = 1002588, XrefRangeStart = 1002585, XrefRangeEnd = 1002588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012D1 RID: 4817 RVA: 0x00060E54 File Offset: 0x0005F054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TSource> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TSource>>(intPtr3) : null;
			}

			// Token: 0x060012D2 RID: 4818 RVA: 0x00060EA0 File Offset: 0x0005F0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002637, XrefRangeEnd = 1002642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060012D3 RID: 4819 RVA: 0x00060EE8 File Offset: 0x0005F0E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereListIterator<TResult>.MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x060012D4 RID: 4820 RVA: 0x00060F44 File Offset: 0x0005F144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002642, XrefRangeEnd = 1002648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
				}
			}

			// Token: 0x060012D5 RID: 4821 RVA: 0x00007C77 File Offset: 0x00005E77
			public WhereListIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000597 RID: 1431
			// (get) Token: 0x060012D6 RID: 4822 RVA: 0x00060FA0 File Offset: 0x0005F1A0
			// (set) Token: 0x060012D7 RID: 4823 RVA: 0x00007C80 File Offset: 0x00005E80
			public unsafe List<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000598 RID: 1432
			// (get) Token: 0x060012D8 RID: 4824 RVA: 0x00060FD0 File Offset: 0x0005F1D0
			// (set) Token: 0x060012D9 RID: 4825 RVA: 0x00007C9F File Offset: 0x00005E9F
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000599 RID: 1433
			// (get) Token: 0x060012DA RID: 4826 RVA: 0x00061000 File Offset: 0x0005F200
			// (set) Token: 0x060012DB RID: 4827 RVA: 0x00007CBE File Offset: 0x00005EBE
			public List<TSource>.Enumerator enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_enumerator);
					return new List<TSource>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<TSource>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_enumerator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<TSource>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000D82 RID: 3458
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000D83 RID: 3459
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04000D84 RID: 3460
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x04000D85 RID: 3461
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x04000D86 RID: 3462
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0;

			// Token: 0x04000D87 RID: 3463
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x04000D88 RID: 3464
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0;

			// Token: 0x04000D89 RID: 3465
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x02000362 RID: 866
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0
			{
				// Token: 0x0400131D RID: 4893
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.WhereListIterator<TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable.WhereListIterator<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x0200013C RID: 316
		public class WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x060012DC RID: 4828 RVA: 0x00061030 File Offset: 0x0005F230
			// Note: this type is marked as 'beforefieldinit'.
			static WhereSelectEnumerableIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereSelectEnumerableIterator`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, "predicate");
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, "enumerator");
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663518);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663519);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663520);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663521);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663522);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663523);
			}

			// Token: 0x060012DD RID: 4829 RVA: 0x00061170 File Offset: 0x0005F370
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1002657, RefRangeEnd = 1002660, XrefRangeStart = 1002648, XrefRangeEnd = 1002657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012DE RID: 4830 RVA: 0x000611E0 File Offset: 0x0005F3E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002660, XrefRangeEnd = 1002666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TResult> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TResult>>(intPtr3) : null;
			}

			// Token: 0x060012DF RID: 4831 RVA: 0x0006122C File Offset: 0x0005F42C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002666, XrefRangeEnd = 1002728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012E0 RID: 4832 RVA: 0x00061268 File Offset: 0x0005F468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002728, XrefRangeEnd = 1002740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060012E1 RID: 4833 RVA: 0x000612B0 File Offset: 0x0005F4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002740, XrefRangeEnd = 1002745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				/*
An exception occurred when decompiling this method (060012E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Collections.Generic.IEnumerable`1<TResult2> Il2CppSystem.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select<TResult2>(Il2CppSystem.Func`2<TResult,TResult2>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x060012E2 RID: 4834 RVA: 0x0006130C File Offset: 0x0005F50C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002745, XrefRangeEnd = 1002748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x060012E3 RID: 4835 RVA: 0x00007CEC File Offset: 0x00005EEC
			public WhereSelectEnumerableIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700059A RID: 1434
			// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00061368 File Offset: 0x0005F568
			// (set) Token: 0x060012E5 RID: 4837 RVA: 0x00007CF5 File Offset: 0x00005EF5
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700059B RID: 1435
			// (get) Token: 0x060012E6 RID: 4838 RVA: 0x00061398 File Offset: 0x0005F598
			// (set) Token: 0x060012E7 RID: 4839 RVA: 0x00007D14 File Offset: 0x00005F14
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700059C RID: 1436
			// (get) Token: 0x060012E8 RID: 4840 RVA: 0x000613C8 File Offset: 0x0005F5C8
			// (set) Token: 0x060012E9 RID: 4841 RVA: 0x00007D33 File Offset: 0x00005F33
			public unsafe Func<TSource, TResult> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700059D RID: 1437
			// (get) Token: 0x060012EA RID: 4842 RVA: 0x000613F8 File Offset: 0x0005F5F8
			// (set) Token: 0x060012EB RID: 4843 RVA: 0x00007D52 File Offset: 0x00005F52
			public unsafe IEnumerator<TSource> enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D8A RID: 3466
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000D8B RID: 3467
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04000D8C RID: 3468
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x04000D8D RID: 3469
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x04000D8E RID: 3470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0;

			// Token: 0x04000D8F RID: 3471
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0;

			// Token: 0x04000D90 RID: 3472
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

			// Token: 0x04000D91 RID: 3473
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x04000D92 RID: 3474
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0;

			// Token: 0x04000D93 RID: 3475
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0;

			// Token: 0x02000363 RID: 867
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0
			{
				// Token: 0x06001C58 RID: 7256 RVA: 0x00085914 File Offset: 0x00083B14
				// Note: this type is marked as 'beforefieldinit'.
				static MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0()
				{
					/*
An exception occurred when decompiling this method (06001C58)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppSystem.Linq.Enumerable/WhereSelectEnumerableIterator`2/MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
				}

				// Token: 0x0400131E RID: 4894
				internal static IntPtr Pointer;
			}
		}

		// Token: 0x0200013D RID: 317
		public class WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x060012EC RID: 4844 RVA: 0x00061428 File Offset: 0x0005F628
			// Note: this type is marked as 'beforefieldinit'.
			static WhereSelectArrayIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereSelectArrayIterator`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, "predicate");
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, "index");
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663524);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663525);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663526);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663527);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663528);
			}

			// Token: 0x060012ED RID: 4845 RVA: 0x00061554 File Offset: 0x0005F754
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1002657, RefRangeEnd = 1002660, XrefRangeStart = 1002657, XrefRangeEnd = 1002660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WhereSelectArrayIterator(Il2CppArrayBase<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012EE RID: 4846 RVA: 0x000615C4 File Offset: 0x0005F7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TResult> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TResult>>(intPtr3) : null;
			}

			// Token: 0x060012EF RID: 4847 RVA: 0x00061610 File Offset: 0x0005F810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002748, XrefRangeEnd = 1002749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060012F0 RID: 4848 RVA: 0x00061658 File Offset: 0x0005F858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				/*
An exception occurred when decompiling this method (060012F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Collections.Generic.IEnumerable`1<TResult2> Il2CppSystem.Linq.Enumerable/WhereSelectArrayIterator`2::Select<TResult2>(Il2CppSystem.Func`2<TResult,TResult2>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x060012F1 RID: 4849 RVA: 0x000616B4 File Offset: 0x0005F8B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002749, XrefRangeEnd = 1002752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x060012F2 RID: 4850 RVA: 0x00007D71 File Offset: 0x00005F71
			public WhereSelectArrayIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700059E RID: 1438
			// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00061710 File Offset: 0x0005F910
			// (set) Token: 0x060012F4 RID: 4852 RVA: 0x00007D7A File Offset: 0x00005F7A
			public unsafe Il2CppArrayBase<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_source);
					return Il2CppArrayBase<TSource>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700059F RID: 1439
			// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00061738 File Offset: 0x0005F938
			// (set) Token: 0x060012F6 RID: 4854 RVA: 0x00007D99 File Offset: 0x00005F99
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A0 RID: 1440
			// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00061768 File Offset: 0x0005F968
			// (set) Token: 0x060012F8 RID: 4856 RVA: 0x00007DB8 File Offset: 0x00005FB8
			public unsafe Func<TSource, TResult> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A1 RID: 1441
			// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00061798 File Offset: 0x0005F998
			// (set) Token: 0x060012FA RID: 4858 RVA: 0x00007DD7 File Offset: 0x00005FD7
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x04000D94 RID: 3476
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000D95 RID: 3477
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04000D96 RID: 3478
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x04000D97 RID: 3479
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04000D98 RID: 3480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0;

			// Token: 0x04000D99 RID: 3481
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0;

			// Token: 0x04000D9A RID: 3482
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x04000D9B RID: 3483
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0;

			// Token: 0x04000D9C RID: 3484
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0;

			// Token: 0x02000364 RID: 868
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0
			{
				// Token: 0x06001C59 RID: 7257 RVA: 0x00085968 File Offset: 0x00083B68
				// Note: this type is marked as 'beforefieldinit'.
				static MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0()
				{
					/*
An exception occurred when decompiling this method (06001C59)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppSystem.Linq.Enumerable/WhereSelectArrayIterator`2/MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
				}

				// Token: 0x0400131F RID: 4895
				internal static IntPtr Pointer;
			}
		}

		// Token: 0x0200013E RID: 318
		public class WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x060012FB RID: 4859 RVA: 0x000617C0 File Offset: 0x0005F9C0
			// Note: this type is marked as 'beforefieldinit'.
			static WhereSelectListIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereSelectListIterator`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, "predicate");
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, "enumerator");
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663529);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663530);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663531);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663532);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663533);
			}

			// Token: 0x060012FC RID: 4860 RVA: 0x000618EC File Offset: 0x0005FAEC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1002657, RefRangeEnd = 1002660, XrefRangeStart = 1002657, XrefRangeEnd = 1002660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WhereSelectListIterator(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012FD RID: 4861 RVA: 0x0006195C File Offset: 0x0005FB5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TResult> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TResult>>(intPtr3) : null;
			}

			// Token: 0x060012FE RID: 4862 RVA: 0x000619A8 File Offset: 0x0005FBA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002752, XrefRangeEnd = 1002758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060012FF RID: 4863 RVA: 0x000619F0 File Offset: 0x0005FBF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				/*
An exception occurred when decompiling this method (060012FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Collections.Generic.IEnumerable`1<TResult2> Il2CppSystem.Linq.Enumerable/WhereSelectListIterator`2::Select<TResult2>(Il2CppSystem.Func`2<TResult,TResult2>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x06001300 RID: 4864 RVA: 0x00061A4C File Offset: 0x0005FC4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002758, XrefRangeEnd = 1002761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x06001301 RID: 4865 RVA: 0x00007DF2 File Offset: 0x00005FF2
			public WhereSelectListIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A2 RID: 1442
			// (get) Token: 0x06001302 RID: 4866 RVA: 0x00061AA8 File Offset: 0x0005FCA8
			// (set) Token: 0x06001303 RID: 4867 RVA: 0x00007DFB File Offset: 0x00005FFB
			public unsafe List<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A3 RID: 1443
			// (get) Token: 0x06001304 RID: 4868 RVA: 0x00061AD8 File Offset: 0x0005FCD8
			// (set) Token: 0x06001305 RID: 4869 RVA: 0x00007E1A File Offset: 0x0000601A
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A4 RID: 1444
			// (get) Token: 0x06001306 RID: 4870 RVA: 0x00061B08 File Offset: 0x0005FD08
			// (set) Token: 0x06001307 RID: 4871 RVA: 0x00007E39 File Offset: 0x00006039
			public unsafe Func<TSource, TResult> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A5 RID: 1445
			// (get) Token: 0x06001308 RID: 4872 RVA: 0x00061B38 File Offset: 0x0005FD38
			// (set) Token: 0x06001309 RID: 4873 RVA: 0x00007E58 File Offset: 0x00006058
			public List<TSource>.Enumerator enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator);
					return new List<TSource>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<TSource>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<TSource>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000D9D RID: 3485
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000D9E RID: 3486
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04000D9F RID: 3487
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x04000DA0 RID: 3488
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x04000DA1 RID: 3489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0;

			// Token: 0x04000DA2 RID: 3490
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0;

			// Token: 0x04000DA3 RID: 3491
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x04000DA4 RID: 3492
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0;

			// Token: 0x04000DA5 RID: 3493
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0;

			// Token: 0x02000365 RID: 869
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0
			{
				// Token: 0x06001C5A RID: 7258 RVA: 0x000859BC File Offset: 0x00083BBC
				// Note: this type is marked as 'beforefieldinit'.
				static MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0()
				{
					/*
An exception occurred when decompiling this method (06001C5A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppSystem.Linq.Enumerable/WhereSelectListIterator`2/MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
				}

				// Token: 0x04001320 RID: 4896
				internal static IntPtr Pointer;
			}
		}

		// Token: 0x0200013F RID: 319
		[ObfuscatedName("System.Linq.Enumerable+<WhereIterator>d__2`1")]
		public sealed class _WhereIterator_d__2<TSource> : Object
		{
			// Token: 0x0600130A RID: 4874 RVA: 0x00061B68 File Offset: 0x0005FD68
			// Note: this type is marked as 'beforefieldinit'.
			static _WhereIterator_d__2()
			{
				Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<WhereIterator>d__2`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr);
				Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, "source");
				Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, "<>3__source");
				Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, "predicate");
				Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___3__predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, "<>3__predicate");
				Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr__index_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, "<index>5__2");
				Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, "<>7__wrap2");
				Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, 100663534);
				Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, 100663535);
				Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, 100663536);
				Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, 100663537);
				Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, 100663538);
				Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, 100663539);
				Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, 100663540);
				Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, 100663541);
				Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr, 100663542);
			}

			// Token: 0x0600130B RID: 4875 RVA: 0x00061D38 File Offset: 0x0005FF38
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WhereIterator_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._WhereIterator_d__2<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600130C RID: 4876 RVA: 0x00061D80 File Offset: 0x0005FF80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002761, XrefRangeEnd = 1002766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600130D RID: 4877 RVA: 0x00061DB4 File Offset: 0x0005FFB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002766, XrefRangeEnd = 1002783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600130E RID: 4878 RVA: 0x00061DF0 File Offset: 0x0005FFF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002783, XrefRangeEnd = 1002786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005AF RID: 1455
			// (get) Token: 0x0600130F RID: 4879 RVA: 0x00061E24 File Offset: 0x00060024
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x06001310 RID: 4880 RVA: 0x00061E60 File Offset: 0x00060060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005B0 RID: 1456
			// (get) Token: 0x06001311 RID: 4881 RVA: 0x00061E94 File Offset: 0x00060094
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002786, XrefRangeEnd = 1002787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001312 RID: 4882 RVA: 0x00061ED4 File Offset: 0x000600D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002787, XrefRangeEnd = 1002795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x06001313 RID: 4883 RVA: 0x00061F14 File Offset: 0x00060114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002795, XrefRangeEnd = 1002803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._WhereIterator_d__2<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001314 RID: 4884 RVA: 0x00007E86 File Offset: 0x00006086
			public _WhereIterator_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A6 RID: 1446
			// (get) Token: 0x06001315 RID: 4885 RVA: 0x00061F54 File Offset: 0x00060154
			// (set) Token: 0x06001316 RID: 4886 RVA: 0x00007E8F File Offset: 0x0000608F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005A7 RID: 1447
			// (get) Token: 0x06001317 RID: 4887 RVA: 0x00061F7C File Offset: 0x0006017C
			// (set) Token: 0x06001318 RID: 4888 RVA: 0x00061FA4 File Offset: 0x000601A4
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x170005A8 RID: 1448
			// (get) Token: 0x06001319 RID: 4889 RVA: 0x0006204C File Offset: 0x0006024C
			// (set) Token: 0x0600131A RID: 4890 RVA: 0x00007EAA File Offset: 0x000060AA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005A9 RID: 1449
			// (get) Token: 0x0600131B RID: 4891 RVA: 0x00062074 File Offset: 0x00060274
			// (set) Token: 0x0600131C RID: 4892 RVA: 0x00007EC5 File Offset: 0x000060C5
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AA RID: 1450
			// (get) Token: 0x0600131D RID: 4893 RVA: 0x000620A4 File Offset: 0x000602A4
			// (set) Token: 0x0600131E RID: 4894 RVA: 0x00007EE4 File Offset: 0x000060E4
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AB RID: 1451
			// (get) Token: 0x0600131F RID: 4895 RVA: 0x000620D4 File Offset: 0x000602D4
			// (set) Token: 0x06001320 RID: 4896 RVA: 0x00007F03 File Offset: 0x00006103
			public unsafe Func<TSource, int, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AC RID: 1452
			// (get) Token: 0x06001321 RID: 4897 RVA: 0x00062104 File Offset: 0x00060304
			// (set) Token: 0x06001322 RID: 4898 RVA: 0x00007F22 File Offset: 0x00006122
			public unsafe Func<TSource, int, bool> __3__predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___3__predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___3__predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AD RID: 1453
			// (get) Token: 0x06001323 RID: 4899 RVA: 0x00062134 File Offset: 0x00060334
			// (set) Token: 0x06001324 RID: 4900 RVA: 0x00007F41 File Offset: 0x00006141
			public unsafe int _index_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr__index_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr__index_5__2)) = value;
				}
			}

			// Token: 0x170005AE RID: 1454
			// (get) Token: 0x06001325 RID: 4901 RVA: 0x0006215C File Offset: 0x0006035C
			// (set) Token: 0x06001326 RID: 4902 RVA: 0x00007F5C File Offset: 0x0000615C
			public unsafe IEnumerator<TSource> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._WhereIterator_d__2<TSource>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DA6 RID: 3494
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000DA7 RID: 3495
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000DA8 RID: 3496
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000DA9 RID: 3497
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000DAA RID: 3498
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000DAB RID: 3499
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04000DAC RID: 3500
			private static readonly IntPtr NativeFieldInfoPtr___3__predicate;

			// Token: 0x04000DAD RID: 3501
			private static readonly IntPtr NativeFieldInfoPtr__index_5__2;

			// Token: 0x04000DAE RID: 3502
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000DAF RID: 3503
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000DB0 RID: 3504
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000DB1 RID: 3505
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000DB2 RID: 3506
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000DB3 RID: 3507
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000DB4 RID: 3508
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000DB5 RID: 3509
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000DB6 RID: 3510
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000DB7 RID: 3511
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000140 RID: 320
		[ObfuscatedName("System.Linq.Enumerable+<SelectIterator>d__5`2")]
		public sealed class _SelectIterator_d__5<TSource, TResult> : Object
		{
			// Token: 0x06001327 RID: 4903 RVA: 0x0006218C File Offset: 0x0006038C
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectIterator_d__5()
			{
				Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<SelectIterator>d__5`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<>1__state");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<>2__current");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<>3__source");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___3__selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<>3__selector");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr__index_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<index>5__2");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<>7__wrap2");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663543);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663544);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663545);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663546);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663547);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663548);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663549);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663550);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663551);
			}

			// Token: 0x06001328 RID: 4904 RVA: 0x0006236C File Offset: 0x0006056C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectIterator_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001329 RID: 4905 RVA: 0x000623B4 File Offset: 0x000605B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002803, XrefRangeEnd = 1002808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600132A RID: 4906 RVA: 0x000623E8 File Offset: 0x000605E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002808, XrefRangeEnd = 1002825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600132B RID: 4907 RVA: 0x00062424 File Offset: 0x00060624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002825, XrefRangeEnd = 1002828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005BA RID: 1466
			// (get) Token: 0x0600132C RID: 4908 RVA: 0x00062458 File Offset: 0x00060658
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x0600132D RID: 4909 RVA: 0x00062494 File Offset: 0x00060694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005BB RID: 1467
			// (get) Token: 0x0600132E RID: 4910 RVA: 0x000624C8 File Offset: 0x000606C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600132F RID: 4911 RVA: 0x00062508 File Offset: 0x00060708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x06001330 RID: 4912 RVA: 0x00062548 File Offset: 0x00060748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002828, XrefRangeEnd = 1002836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001331 RID: 4913 RVA: 0x00007F7B File Offset: 0x0000617B
			public _SelectIterator_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005B1 RID: 1457
			// (get) Token: 0x06001332 RID: 4914 RVA: 0x00062588 File Offset: 0x00060788
			// (set) Token: 0x06001333 RID: 4915 RVA: 0x00007F84 File Offset: 0x00006184
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005B2 RID: 1458
			// (get) Token: 0x06001334 RID: 4916 RVA: 0x000625B0 File Offset: 0x000607B0
			// (set) Token: 0x06001335 RID: 4917 RVA: 0x000625D8 File Offset: 0x000607D8
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x170005B3 RID: 1459
			// (get) Token: 0x06001336 RID: 4918 RVA: 0x00062680 File Offset: 0x00060880
			// (set) Token: 0x06001337 RID: 4919 RVA: 0x00007F9F File Offset: 0x0000619F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005B4 RID: 1460
			// (get) Token: 0x06001338 RID: 4920 RVA: 0x000626A8 File Offset: 0x000608A8
			// (set) Token: 0x06001339 RID: 4921 RVA: 0x00007FBA File Offset: 0x000061BA
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B5 RID: 1461
			// (get) Token: 0x0600133A RID: 4922 RVA: 0x000626D8 File Offset: 0x000608D8
			// (set) Token: 0x0600133B RID: 4923 RVA: 0x00007FD9 File Offset: 0x000061D9
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B6 RID: 1462
			// (get) Token: 0x0600133C RID: 4924 RVA: 0x00062708 File Offset: 0x00060908
			// (set) Token: 0x0600133D RID: 4925 RVA: 0x00007FF8 File Offset: 0x000061F8
			public unsafe Func<TSource, int, TResult> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, int, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B7 RID: 1463
			// (get) Token: 0x0600133E RID: 4926 RVA: 0x00062738 File Offset: 0x00060938
			// (set) Token: 0x0600133F RID: 4927 RVA: 0x00008017 File Offset: 0x00006217
			public unsafe Func<TSource, int, TResult> __3__selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___3__selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, int, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___3__selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B8 RID: 1464
			// (get) Token: 0x06001340 RID: 4928 RVA: 0x00062768 File Offset: 0x00060968
			// (set) Token: 0x06001341 RID: 4929 RVA: 0x00008036 File Offset: 0x00006236
			public unsafe int _index_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr__index_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr__index_5__2)) = value;
				}
			}

			// Token: 0x170005B9 RID: 1465
			// (get) Token: 0x06001342 RID: 4930 RVA: 0x00062790 File Offset: 0x00060990
			// (set) Token: 0x06001343 RID: 4931 RVA: 0x00008051 File Offset: 0x00006251
			public unsafe IEnumerator<TSource> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DB8 RID: 3512
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000DB9 RID: 3513
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000DBA RID: 3514
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000DBB RID: 3515
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000DBC RID: 3516
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000DBD RID: 3517
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x04000DBE RID: 3518
			private static readonly IntPtr NativeFieldInfoPtr___3__selector;

			// Token: 0x04000DBF RID: 3519
			private static readonly IntPtr NativeFieldInfoPtr__index_5__2;

			// Token: 0x04000DC0 RID: 3520
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000DC1 RID: 3521
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000DC2 RID: 3522
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000DC3 RID: 3523
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000DC4 RID: 3524
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000DC5 RID: 3525
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000DC6 RID: 3526
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000DC7 RID: 3527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000DC8 RID: 3528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x04000DC9 RID: 3529
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000141 RID: 321
		[ObfuscatedName("System.Linq.Enumerable+<>c__DisplayClass6_0`1")]
		public sealed class __c__DisplayClass6_0<TSource> : Object
		{
			// Token: 0x06001344 RID: 4932 RVA: 0x000627C0 File Offset: 0x000609C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<>c__DisplayClass6_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr);
				Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr, "predicate1");
				Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr, "predicate2");
				Enumerable.__c__DisplayClass6_0<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr, 100663552);
				Enumerable.__c__DisplayClass6_0<TSource>.NativeMethodInfoPtr__CombinePredicates_b__0_Internal_Boolean_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr, 100663553);
			}

			// Token: 0x06001345 RID: 4933 RVA: 0x00062878 File Offset: 0x00060A78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.__c__DisplayClass6_0<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001346 RID: 4934 RVA: 0x000628B4 File Offset: 0x00060AB4
			[CallerCount(0)]
			public unsafe bool _CombinePredicates_b__0(TSource x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TSource).IsValueType)
					{
						TSource tsource = x;
						intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.__c__DisplayClass6_0<TSource>.NativeMethodInfoPtr__CombinePredicates_b__0_Internal_Boolean_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06001347 RID: 4935 RVA: 0x00008070 File Offset: 0x00006270
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005BC RID: 1468
			// (get) Token: 0x06001348 RID: 4936 RVA: 0x00062938 File Offset: 0x00060B38
			// (set) Token: 0x06001349 RID: 4937 RVA: 0x00008079 File Offset: 0x00006279
			public unsafe Func<TSource, bool> predicate1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005BD RID: 1469
			// (get) Token: 0x0600134A RID: 4938 RVA: 0x00062968 File Offset: 0x00060B68
			// (set) Token: 0x0600134B RID: 4939 RVA: 0x00008098 File Offset: 0x00006298
			public unsafe Func<TSource, bool> predicate2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DCA RID: 3530
			private static readonly IntPtr NativeFieldInfoPtr_predicate1;

			// Token: 0x04000DCB RID: 3531
			private static readonly IntPtr NativeFieldInfoPtr_predicate2;

			// Token: 0x04000DCC RID: 3532
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DCD RID: 3533
			private static readonly IntPtr NativeMethodInfoPtr__CombinePredicates_b__0_Internal_Boolean_TSource_0;
		}

		// Token: 0x02000142 RID: 322
		[ObfuscatedName("System.Linq.Enumerable+<>c__DisplayClass7_0`3")]
		public sealed class __c__DisplayClass7_0<TSource, TMiddle, TResult> : Object
		{
			// Token: 0x0600134C RID: 4940 RVA: 0x00062998 File Offset: 0x00060B98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<>c__DisplayClass7_0`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMiddle>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr);
				Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr, "selector2");
				Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr, "selector1");
				Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr, 100663554);
				Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeMethodInfoPtr__CombineSelectors_b__0_Internal_TResult_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr, 100663555);
			}

			// Token: 0x0600134D RID: 4941 RVA: 0x00062A74 File Offset: 0x00060C74
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600134E RID: 4942 RVA: 0x00062AB0 File Offset: 0x00060CB0
			[CallerCount(0)]
			public unsafe TResult _CombineSelectors_b__0(TSource x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TSource).IsValueType)
					{
						TSource tsource = x;
						intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeMethodInfoPtr__CombineSelectors_b__0_Internal_TResult_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
				}
			}

			// Token: 0x0600134F RID: 4943 RVA: 0x000080B7 File Offset: 0x000062B7
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005BE RID: 1470
			// (get) Token: 0x06001350 RID: 4944 RVA: 0x00062B30 File Offset: 0x00060D30
			// (set) Token: 0x06001351 RID: 4945 RVA: 0x000080C0 File Offset: 0x000062C0
			public unsafe Func<TMiddle, TResult> selector2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMiddle, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005BF RID: 1471
			// (get) Token: 0x06001352 RID: 4946 RVA: 0x00062B60 File Offset: 0x00060D60
			// (set) Token: 0x06001353 RID: 4947 RVA: 0x000080DF File Offset: 0x000062DF
			public unsafe Func<TSource, TMiddle> selector1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TMiddle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DCE RID: 3534
			private static readonly IntPtr NativeFieldInfoPtr_selector2;

			// Token: 0x04000DCF RID: 3535
			private static readonly IntPtr NativeFieldInfoPtr_selector1;

			// Token: 0x04000DD0 RID: 3536
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DD1 RID: 3537
			private static readonly IntPtr NativeMethodInfoPtr__CombineSelectors_b__0_Internal_TResult_TSource_0;
		}

		// Token: 0x02000143 RID: 323
		[ObfuscatedName("System.Linq.Enumerable+<SelectManyIterator>d__17`2")]
		public sealed class _SelectManyIterator_d__17<TSource, TResult> : Object
		{
			// Token: 0x06001354 RID: 4948 RVA: 0x00062B90 File Offset: 0x00060D90
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectManyIterator_d__17()
			{
				Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<SelectManyIterator>d__17`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>1__state");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>2__current");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>3__source");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___3__selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>3__selector");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, "<>7__wrap2");
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663556);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663557);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663558);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663559);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663560);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663561);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663562);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663563);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663564);
				Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr, 100663565);
			}

			// Token: 0x06001355 RID: 4949 RVA: 0x00062D84 File Offset: 0x00060F84
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectManyIterator_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__17<TSource, TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001356 RID: 4950 RVA: 0x00062DCC File Offset: 0x00060FCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002836, XrefRangeEnd = 1002846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001357 RID: 4951 RVA: 0x00062E00 File Offset: 0x00061000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002846, XrefRangeEnd = 1002876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001358 RID: 4952 RVA: 0x00062E3C File Offset: 0x0006103C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002876, XrefRangeEnd = 1002879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001359 RID: 4953 RVA: 0x00062E70 File Offset: 0x00061070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002879, XrefRangeEnd = 1002882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005C9 RID: 1481
			// (get) Token: 0x0600135A RID: 4954 RVA: 0x00062EA4 File Offset: 0x000610A4
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x0600135B RID: 4955 RVA: 0x00062EE0 File Offset: 0x000610E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005CA RID: 1482
			// (get) Token: 0x0600135C RID: 4956 RVA: 0x00062F14 File Offset: 0x00061114
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002882, XrefRangeEnd = 1002883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600135D RID: 4957 RVA: 0x00062F54 File Offset: 0x00061154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x0600135E RID: 4958 RVA: 0x00062F94 File Offset: 0x00061194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002883, XrefRangeEnd = 1002891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600135F RID: 4959 RVA: 0x000080FE File Offset: 0x000062FE
			public _SelectManyIterator_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005C0 RID: 1472
			// (get) Token: 0x06001360 RID: 4960 RVA: 0x00062FD4 File Offset: 0x000611D4
			// (set) Token: 0x06001361 RID: 4961 RVA: 0x00008107 File Offset: 0x00006307
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005C1 RID: 1473
			// (get) Token: 0x06001362 RID: 4962 RVA: 0x00062FFC File Offset: 0x000611FC
			// (set) Token: 0x06001363 RID: 4963 RVA: 0x00063024 File Offset: 0x00061224
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x170005C2 RID: 1474
			// (get) Token: 0x06001364 RID: 4964 RVA: 0x000630CC File Offset: 0x000612CC
			// (set) Token: 0x06001365 RID: 4965 RVA: 0x00008122 File Offset: 0x00006322
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005C3 RID: 1475
			// (get) Token: 0x06001366 RID: 4966 RVA: 0x000630F4 File Offset: 0x000612F4
			// (set) Token: 0x06001367 RID: 4967 RVA: 0x0000813D File Offset: 0x0000633D
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C4 RID: 1476
			// (get) Token: 0x06001368 RID: 4968 RVA: 0x00063124 File Offset: 0x00061324
			// (set) Token: 0x06001369 RID: 4969 RVA: 0x0000815C File Offset: 0x0000635C
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x0600136A RID: 4970 RVA: 0x00063154 File Offset: 0x00061354
			// (set) Token: 0x0600136B RID: 4971 RVA: 0x0000817B File Offset: 0x0000637B
			public unsafe Func<TSource, IEnumerable<TResult>> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, IEnumerable<TResult>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C6 RID: 1478
			// (get) Token: 0x0600136C RID: 4972 RVA: 0x00063184 File Offset: 0x00061384
			// (set) Token: 0x0600136D RID: 4973 RVA: 0x0000819A File Offset: 0x0000639A
			public unsafe Func<TSource, IEnumerable<TResult>> __3__selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___3__selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, IEnumerable<TResult>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___3__selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C7 RID: 1479
			// (get) Token: 0x0600136E RID: 4974 RVA: 0x000631B4 File Offset: 0x000613B4
			// (set) Token: 0x0600136F RID: 4975 RVA: 0x000081B9 File Offset: 0x000063B9
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C8 RID: 1480
			// (get) Token: 0x06001370 RID: 4976 RVA: 0x000631E4 File Offset: 0x000613E4
			// (set) Token: 0x06001371 RID: 4977 RVA: 0x000081D8 File Offset: 0x000063D8
			public unsafe IEnumerator<TResult> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__17<TSource, TResult>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DD2 RID: 3538
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000DD3 RID: 3539
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000DD4 RID: 3540
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000DD5 RID: 3541
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000DD6 RID: 3542
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000DD7 RID: 3543
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x04000DD8 RID: 3544
			private static readonly IntPtr NativeFieldInfoPtr___3__selector;

			// Token: 0x04000DD9 RID: 3545
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000DDA RID: 3546
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000DDB RID: 3547
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000DDC RID: 3548
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000DDD RID: 3549
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000DDE RID: 3550
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000DDF RID: 3551
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04000DE0 RID: 3552
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000DE1 RID: 3553
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000DE2 RID: 3554
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000DE3 RID: 3555
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x04000DE4 RID: 3556
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000144 RID: 324
		[ObfuscatedName("System.Linq.Enumerable+<SelectManyIterator>d__23`3")]
		public sealed class _SelectManyIterator_d__23<TSource, TCollection, TResult> : Object
		{
			// Token: 0x06001372 RID: 4978 RVA: 0x00063214 File Offset: 0x00061414
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectManyIterator_d__23()
			{
				Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<SelectManyIterator>d__23`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr);
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, "<>1__state");
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, "<>2__current");
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, "source");
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, "<>3__source");
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr_collectionSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, "collectionSelector");
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___3__collectionSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, "<>3__collectionSelector");
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr_resultSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, "resultSelector");
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___3__resultSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, "<>3__resultSelector");
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr__element_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, "<element>5__3");
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, "<>7__wrap3");
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, 100663566);
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, 100663567);
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, 100663568);
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, 100663569);
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, 100663570);
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, 100663571);
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, 100663572);
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, 100663573);
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, 100663574);
				Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr, 100663575);
			}

			// Token: 0x06001373 RID: 4979 RVA: 0x00063458 File Offset: 0x00061658
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectManyIterator_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001374 RID: 4980 RVA: 0x000634A0 File Offset: 0x000616A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002891, XrefRangeEnd = 1002901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001375 RID: 4981 RVA: 0x000634D4 File Offset: 0x000616D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002901, XrefRangeEnd = 1002931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001376 RID: 4982 RVA: 0x00063510 File Offset: 0x00061710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002931, XrefRangeEnd = 1002934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001377 RID: 4983 RVA: 0x00063544 File Offset: 0x00061744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002934, XrefRangeEnd = 1002937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005D7 RID: 1495
			// (get) Token: 0x06001378 RID: 4984 RVA: 0x00063578 File Offset: 0x00061778
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x06001379 RID: 4985 RVA: 0x000635B4 File Offset: 0x000617B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005D8 RID: 1496
			// (get) Token: 0x0600137A RID: 4986 RVA: 0x000635E8 File Offset: 0x000617E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600137B RID: 4987 RVA: 0x00063628 File Offset: 0x00061828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002937, XrefRangeEnd = 1002946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x0600137C RID: 4988 RVA: 0x00063668 File Offset: 0x00061868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002946, XrefRangeEnd = 1002955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600137D RID: 4989 RVA: 0x000081F7 File Offset: 0x000063F7
			public _SelectManyIterator_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005CB RID: 1483
			// (get) Token: 0x0600137E RID: 4990 RVA: 0x000636A8 File Offset: 0x000618A8
			// (set) Token: 0x0600137F RID: 4991 RVA: 0x00008200 File Offset: 0x00006400
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005CC RID: 1484
			// (get) Token: 0x06001380 RID: 4992 RVA: 0x000636D0 File Offset: 0x000618D0
			// (set) Token: 0x06001381 RID: 4993 RVA: 0x000636F8 File Offset: 0x000618F8
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x170005CD RID: 1485
			// (get) Token: 0x06001382 RID: 4994 RVA: 0x000637A0 File Offset: 0x000619A0
			// (set) Token: 0x06001383 RID: 4995 RVA: 0x0000821B File Offset: 0x0000641B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005CE RID: 1486
			// (get) Token: 0x06001384 RID: 4996 RVA: 0x000637C8 File Offset: 0x000619C8
			// (set) Token: 0x06001385 RID: 4997 RVA: 0x00008236 File Offset: 0x00006436
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005CF RID: 1487
			// (get) Token: 0x06001386 RID: 4998 RVA: 0x000637F8 File Offset: 0x000619F8
			// (set) Token: 0x06001387 RID: 4999 RVA: 0x00008255 File Offset: 0x00006455
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D0 RID: 1488
			// (get) Token: 0x06001388 RID: 5000 RVA: 0x00063828 File Offset: 0x00061A28
			// (set) Token: 0x06001389 RID: 5001 RVA: 0x00008274 File Offset: 0x00006474
			public unsafe Func<TSource, IEnumerable<TCollection>> collectionSelector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr_collectionSelector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, IEnumerable<TCollection>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr_collectionSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D1 RID: 1489
			// (get) Token: 0x0600138A RID: 5002 RVA: 0x00063858 File Offset: 0x00061A58
			// (set) Token: 0x0600138B RID: 5003 RVA: 0x00008293 File Offset: 0x00006493
			public unsafe Func<TSource, IEnumerable<TCollection>> __3__collectionSelector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___3__collectionSelector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, IEnumerable<TCollection>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___3__collectionSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D2 RID: 1490
			// (get) Token: 0x0600138C RID: 5004 RVA: 0x00063888 File Offset: 0x00061A88
			// (set) Token: 0x0600138D RID: 5005 RVA: 0x000082B2 File Offset: 0x000064B2
			public unsafe Func<TSource, TCollection, TResult> resultSelector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr_resultSelector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TCollection, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr_resultSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D3 RID: 1491
			// (get) Token: 0x0600138E RID: 5006 RVA: 0x000638B8 File Offset: 0x00061AB8
			// (set) Token: 0x0600138F RID: 5007 RVA: 0x000082D1 File Offset: 0x000064D1
			public unsafe Func<TSource, TCollection, TResult> __3__resultSelector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___3__resultSelector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TCollection, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___3__resultSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D4 RID: 1492
			// (get) Token: 0x06001390 RID: 5008 RVA: 0x000638E8 File Offset: 0x00061AE8
			// (set) Token: 0x06001391 RID: 5009 RVA: 0x000082F0 File Offset: 0x000064F0
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D5 RID: 1493
			// (get) Token: 0x06001392 RID: 5010 RVA: 0x00063918 File Offset: 0x00061B18
			// (set) Token: 0x06001393 RID: 5011 RVA: 0x00063940 File Offset: 0x00061B40
			public unsafe TSource _element_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr__element_5__3);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr__element_5__3);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x170005D6 RID: 1494
			// (get) Token: 0x06001394 RID: 5012 RVA: 0x000639E8 File Offset: 0x00061BE8
			// (set) Token: 0x06001395 RID: 5013 RVA: 0x0000830F File Offset: 0x0000650F
			public unsafe IEnumerator<TCollection> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TCollection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectManyIterator_d__23<TSource, TCollection, TResult>.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DE5 RID: 3557
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000DE6 RID: 3558
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000DE7 RID: 3559
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000DE8 RID: 3560
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000DE9 RID: 3561
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000DEA RID: 3562
			private static readonly IntPtr NativeFieldInfoPtr_collectionSelector;

			// Token: 0x04000DEB RID: 3563
			private static readonly IntPtr NativeFieldInfoPtr___3__collectionSelector;

			// Token: 0x04000DEC RID: 3564
			private static readonly IntPtr NativeFieldInfoPtr_resultSelector;

			// Token: 0x04000DED RID: 3565
			private static readonly IntPtr NativeFieldInfoPtr___3__resultSelector;

			// Token: 0x04000DEE RID: 3566
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000DEF RID: 3567
			private static readonly IntPtr NativeFieldInfoPtr__element_5__3;

			// Token: 0x04000DF0 RID: 3568
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04000DF1 RID: 3569
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000DF2 RID: 3570
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000DF3 RID: 3571
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000DF4 RID: 3572
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000DF5 RID: 3573
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04000DF6 RID: 3574
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000DF7 RID: 3575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000DF8 RID: 3576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000DF9 RID: 3577
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x04000DFA RID: 3578
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000145 RID: 325
		[ObfuscatedName("System.Linq.Enumerable+<TakeIterator>d__25`1")]
		public sealed class _TakeIterator_d__25<TSource> : Object
		{
			// Token: 0x06001396 RID: 5014 RVA: 0x00063A18 File Offset: 0x00061C18
			// Note: this type is marked as 'beforefieldinit'.
			static _TakeIterator_d__25()
			{
				Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<TakeIterator>d__25`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr);
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "count");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___3__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "<>3__count");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "source");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "<>3__source");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663576);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663577);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663578);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663579);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663580);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663581);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663582);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663583);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663584);
			}

			// Token: 0x06001397 RID: 5015 RVA: 0x00063BD4 File Offset: 0x00061DD4
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TakeIterator_d__25(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001398 RID: 5016 RVA: 0x00063C1C File Offset: 0x00061E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002955, XrefRangeEnd = 1002960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001399 RID: 5017 RVA: 0x00063C50 File Offset: 0x00061E50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002960, XrefRangeEnd = 1002977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600139A RID: 5018 RVA: 0x00063C8C File Offset: 0x00061E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002977, XrefRangeEnd = 1002980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x0600139B RID: 5019 RVA: 0x00063CC0 File Offset: 0x00061EC0
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x0600139C RID: 5020 RVA: 0x00063CFC File Offset: 0x00061EFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005E2 RID: 1506
			// (get) Token: 0x0600139D RID: 5021 RVA: 0x00063D30 File Offset: 0x00061F30
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600139E RID: 5022 RVA: 0x00063D70 File Offset: 0x00061F70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002980, XrefRangeEnd = 1002987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x0600139F RID: 5023 RVA: 0x00063DB0 File Offset: 0x00061FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002987, XrefRangeEnd = 1002994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060013A0 RID: 5024 RVA: 0x0000832E File Offset: 0x0000652E
			public _TakeIterator_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005D9 RID: 1497
			// (get) Token: 0x060013A1 RID: 5025 RVA: 0x00063DF0 File Offset: 0x00061FF0
			// (set) Token: 0x060013A2 RID: 5026 RVA: 0x00008337 File Offset: 0x00006537
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005DA RID: 1498
			// (get) Token: 0x060013A3 RID: 5027 RVA: 0x00063E18 File Offset: 0x00062018
			// (set) Token: 0x060013A4 RID: 5028 RVA: 0x00063E40 File Offset: 0x00062040
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x170005DB RID: 1499
			// (get) Token: 0x060013A5 RID: 5029 RVA: 0x00063EE8 File Offset: 0x000620E8
			// (set) Token: 0x060013A6 RID: 5030 RVA: 0x00008352 File Offset: 0x00006552
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005DC RID: 1500
			// (get) Token: 0x060013A7 RID: 5031 RVA: 0x00063F10 File Offset: 0x00062110
			// (set) Token: 0x060013A8 RID: 5032 RVA: 0x0000836D File Offset: 0x0000656D
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170005DD RID: 1501
			// (get) Token: 0x060013A9 RID: 5033 RVA: 0x00063F38 File Offset: 0x00062138
			// (set) Token: 0x060013AA RID: 5034 RVA: 0x00008388 File Offset: 0x00006588
			public unsafe int __3__count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___3__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___3__count)) = value;
				}
			}

			// Token: 0x170005DE RID: 1502
			// (get) Token: 0x060013AB RID: 5035 RVA: 0x00063F60 File Offset: 0x00062160
			// (set) Token: 0x060013AC RID: 5036 RVA: 0x000083A3 File Offset: 0x000065A3
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005DF RID: 1503
			// (get) Token: 0x060013AD RID: 5037 RVA: 0x00063F90 File Offset: 0x00062190
			// (set) Token: 0x060013AE RID: 5038 RVA: 0x000083C2 File Offset: 0x000065C2
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005E0 RID: 1504
			// (get) Token: 0x060013AF RID: 5039 RVA: 0x00063FC0 File Offset: 0x000621C0
			// (set) Token: 0x060013B0 RID: 5040 RVA: 0x000083E1 File Offset: 0x000065E1
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DFB RID: 3579
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000DFC RID: 3580
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000DFD RID: 3581
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000DFE RID: 3582
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000DFF RID: 3583
			private static readonly IntPtr NativeFieldInfoPtr___3__count;

			// Token: 0x04000E00 RID: 3584
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000E01 RID: 3585
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000E02 RID: 3586
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000E03 RID: 3587
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E04 RID: 3588
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E05 RID: 3589
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E06 RID: 3590
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000E07 RID: 3591
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000E08 RID: 3592
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E09 RID: 3593
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E0A RID: 3594
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000E0B RID: 3595
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000146 RID: 326
		[ObfuscatedName("System.Linq.Enumerable+<TakeWhileIterator>d__27`1")]
		public sealed class _TakeWhileIterator_d__27<TSource> : Object
		{
			// Token: 0x060013B1 RID: 5041 RVA: 0x00063FF0 File Offset: 0x000621F0
			// Note: this type is marked as 'beforefieldinit'.
			static _TakeWhileIterator_d__27()
			{
				Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<TakeWhileIterator>d__27`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr);
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, "source");
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, "<>3__source");
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, "predicate");
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___3__predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, "<>3__predicate");
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, 100663585);
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, 100663586);
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, 100663587);
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, 100663588);
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, 100663589);
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, 100663590);
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, 100663591);
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, 100663592);
				Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr, 100663593);
			}

			// Token: 0x060013B2 RID: 5042 RVA: 0x000641AC File Offset: 0x000623AC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TakeWhileIterator_d__27(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._TakeWhileIterator_d__27<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060013B3 RID: 5043 RVA: 0x000641F4 File Offset: 0x000623F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002994, XrefRangeEnd = 1002999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060013B4 RID: 5044 RVA: 0x00064228 File Offset: 0x00062428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002999, XrefRangeEnd = 1003016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060013B5 RID: 5045 RVA: 0x00064264 File Offset: 0x00062464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003016, XrefRangeEnd = 1003019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005EB RID: 1515
			// (get) Token: 0x060013B6 RID: 5046 RVA: 0x00064298 File Offset: 0x00062498
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x060013B7 RID: 5047 RVA: 0x000642D4 File Offset: 0x000624D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005EC RID: 1516
			// (get) Token: 0x060013B8 RID: 5048 RVA: 0x00064308 File Offset: 0x00062508
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060013B9 RID: 5049 RVA: 0x00064348 File Offset: 0x00062548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x060013BA RID: 5050 RVA: 0x00064388 File Offset: 0x00062588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003019, XrefRangeEnd = 1003027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeWhileIterator_d__27<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060013BB RID: 5051 RVA: 0x00008400 File Offset: 0x00006600
			public _TakeWhileIterator_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E3 RID: 1507
			// (get) Token: 0x060013BC RID: 5052 RVA: 0x000643C8 File Offset: 0x000625C8
			// (set) Token: 0x060013BD RID: 5053 RVA: 0x00008409 File Offset: 0x00006609
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005E4 RID: 1508
			// (get) Token: 0x060013BE RID: 5054 RVA: 0x000643F0 File Offset: 0x000625F0
			// (set) Token: 0x060013BF RID: 5055 RVA: 0x00064418 File Offset: 0x00062618
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x170005E5 RID: 1509
			// (get) Token: 0x060013C0 RID: 5056 RVA: 0x000644C0 File Offset: 0x000626C0
			// (set) Token: 0x060013C1 RID: 5057 RVA: 0x00008424 File Offset: 0x00006624
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005E6 RID: 1510
			// (get) Token: 0x060013C2 RID: 5058 RVA: 0x000644E8 File Offset: 0x000626E8
			// (set) Token: 0x060013C3 RID: 5059 RVA: 0x0000843F File Offset: 0x0000663F
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005E7 RID: 1511
			// (get) Token: 0x060013C4 RID: 5060 RVA: 0x00064518 File Offset: 0x00062718
			// (set) Token: 0x060013C5 RID: 5061 RVA: 0x0000845E File Offset: 0x0000665E
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005E8 RID: 1512
			// (get) Token: 0x060013C6 RID: 5062 RVA: 0x00064548 File Offset: 0x00062748
			// (set) Token: 0x060013C7 RID: 5063 RVA: 0x0000847D File Offset: 0x0000667D
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005E9 RID: 1513
			// (get) Token: 0x060013C8 RID: 5064 RVA: 0x00064578 File Offset: 0x00062778
			// (set) Token: 0x060013C9 RID: 5065 RVA: 0x0000849C File Offset: 0x0000669C
			public unsafe Func<TSource, bool> __3__predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___3__predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___3__predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005EA RID: 1514
			// (get) Token: 0x060013CA RID: 5066 RVA: 0x000645A8 File Offset: 0x000627A8
			// (set) Token: 0x060013CB RID: 5067 RVA: 0x000084BB File Offset: 0x000066BB
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeWhileIterator_d__27<TSource>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E0C RID: 3596
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E0D RID: 3597
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E0E RID: 3598
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000E0F RID: 3599
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000E10 RID: 3600
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000E11 RID: 3601
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04000E12 RID: 3602
			private static readonly IntPtr NativeFieldInfoPtr___3__predicate;

			// Token: 0x04000E13 RID: 3603
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000E14 RID: 3604
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E15 RID: 3605
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E16 RID: 3606
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E17 RID: 3607
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000E18 RID: 3608
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000E19 RID: 3609
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E1A RID: 3610
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E1B RID: 3611
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000E1C RID: 3612
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000147 RID: 327
		[ObfuscatedName("System.Linq.Enumerable+<SkipIterator>d__31`1")]
		public sealed class _SkipIterator_d__31<TSource> : Object
		{
			// Token: 0x060013CC RID: 5068 RVA: 0x000645D8 File Offset: 0x000627D8
			// Note: this type is marked as 'beforefieldinit'.
			static _SkipIterator_d__31()
			{
				Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<SkipIterator>d__31`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr);
				Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, "source");
				Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, "<>3__source");
				Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, "count");
				Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___3__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, "<>3__count");
				Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr__e_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, "<e>5__2");
				Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, 100663594);
				Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, 100663595);
				Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, 100663596);
				Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, 100663597);
				Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, 100663598);
				Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, 100663599);
				Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, 100663600);
				Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, 100663601);
				Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr, 100663602);
			}

			// Token: 0x060013CD RID: 5069 RVA: 0x00064794 File Offset: 0x00062994
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SkipIterator_d__31(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._SkipIterator_d__31<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060013CE RID: 5070 RVA: 0x000647DC File Offset: 0x000629DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003027, XrefRangeEnd = 1003032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060013CF RID: 5071 RVA: 0x00064810 File Offset: 0x00062A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003032, XrefRangeEnd = 1003054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060013D0 RID: 5072 RVA: 0x0006484C File Offset: 0x00062A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003054, XrefRangeEnd = 1003057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005F5 RID: 1525
			// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00064880 File Offset: 0x00062A80
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x060013D2 RID: 5074 RVA: 0x000648BC File Offset: 0x00062ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005F6 RID: 1526
			// (get) Token: 0x060013D3 RID: 5075 RVA: 0x000648F0 File Offset: 0x00062AF0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060013D4 RID: 5076 RVA: 0x00064930 File Offset: 0x00062B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003057, XrefRangeEnd = 1003064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x060013D5 RID: 5077 RVA: 0x00064970 File Offset: 0x00062B70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003064, XrefRangeEnd = 1003071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SkipIterator_d__31<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060013D6 RID: 5078 RVA: 0x000084DA File Offset: 0x000066DA
			public _SkipIterator_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005ED RID: 1517
			// (get) Token: 0x060013D7 RID: 5079 RVA: 0x000649B0 File Offset: 0x00062BB0
			// (set) Token: 0x060013D8 RID: 5080 RVA: 0x000084E3 File Offset: 0x000066E3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005EE RID: 1518
			// (get) Token: 0x060013D9 RID: 5081 RVA: 0x000649D8 File Offset: 0x00062BD8
			// (set) Token: 0x060013DA RID: 5082 RVA: 0x00064A00 File Offset: 0x00062C00
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x060013DB RID: 5083 RVA: 0x00064AA8 File Offset: 0x00062CA8
			// (set) Token: 0x060013DC RID: 5084 RVA: 0x000084FE File Offset: 0x000066FE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005F0 RID: 1520
			// (get) Token: 0x060013DD RID: 5085 RVA: 0x00064AD0 File Offset: 0x00062CD0
			// (set) Token: 0x060013DE RID: 5086 RVA: 0x00008519 File Offset: 0x00006719
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F1 RID: 1521
			// (get) Token: 0x060013DF RID: 5087 RVA: 0x00064B00 File Offset: 0x00062D00
			// (set) Token: 0x060013E0 RID: 5088 RVA: 0x00008538 File Offset: 0x00006738
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F2 RID: 1522
			// (get) Token: 0x060013E1 RID: 5089 RVA: 0x00064B30 File Offset: 0x00062D30
			// (set) Token: 0x060013E2 RID: 5090 RVA: 0x00008557 File Offset: 0x00006757
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170005F3 RID: 1523
			// (get) Token: 0x060013E3 RID: 5091 RVA: 0x00064B58 File Offset: 0x00062D58
			// (set) Token: 0x060013E4 RID: 5092 RVA: 0x00008572 File Offset: 0x00006772
			public unsafe int __3__count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___3__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr___3__count)) = value;
				}
			}

			// Token: 0x170005F4 RID: 1524
			// (get) Token: 0x060013E5 RID: 5093 RVA: 0x00064B80 File Offset: 0x00062D80
			// (set) Token: 0x060013E6 RID: 5094 RVA: 0x0000858D File Offset: 0x0000678D
			public unsafe IEnumerator<TSource> _e_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr__e_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SkipIterator_d__31<TSource>.NativeFieldInfoPtr__e_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E1D RID: 3613
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E1E RID: 3614
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E1F RID: 3615
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000E20 RID: 3616
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000E21 RID: 3617
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000E22 RID: 3618
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000E23 RID: 3619
			private static readonly IntPtr NativeFieldInfoPtr___3__count;

			// Token: 0x04000E24 RID: 3620
			private static readonly IntPtr NativeFieldInfoPtr__e_5__2;

			// Token: 0x04000E25 RID: 3621
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E26 RID: 3622
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E27 RID: 3623
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E28 RID: 3624
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000E29 RID: 3625
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000E2A RID: 3626
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E2B RID: 3627
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E2C RID: 3628
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000E2D RID: 3629
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000148 RID: 328
		[ObfuscatedName("System.Linq.Enumerable+<ConcatIterator>d__59`1")]
		public sealed class _ConcatIterator_d__59<TSource> : Object
		{
			// Token: 0x060013E7 RID: 5095 RVA: 0x00064BB0 File Offset: 0x00062DB0
			// Note: this type is marked as 'beforefieldinit'.
			static _ConcatIterator_d__59()
			{
				Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<ConcatIterator>d__59`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr);
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "first");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___3__first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "<>3__first");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "second");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___3__second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "<>3__second");
				Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663603);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663604);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663605);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663606);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663607);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663608);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663609);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663610);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663611);
				Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr, 100663612);
			}

			// Token: 0x060013E8 RID: 5096 RVA: 0x00064D80 File Offset: 0x00062F80
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ConcatIterator_d__59(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._ConcatIterator_d__59<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060013E9 RID: 5097 RVA: 0x00064DC8 File Offset: 0x00062FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003071, XrefRangeEnd = 1003081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060013EA RID: 5098 RVA: 0x00064DFC File Offset: 0x00062FFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003081, XrefRangeEnd = 1003112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060013EB RID: 5099 RVA: 0x00064E38 File Offset: 0x00063038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003112, XrefRangeEnd = 1003115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060013EC RID: 5100 RVA: 0x00064E6C File Offset: 0x0006306C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003115, XrefRangeEnd = 1003118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005FF RID: 1535
			// (get) Token: 0x060013ED RID: 5101 RVA: 0x00064EA0 File Offset: 0x000630A0
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x060013EE RID: 5102 RVA: 0x00064EDC File Offset: 0x000630DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000600 RID: 1536
			// (get) Token: 0x060013EF RID: 5103 RVA: 0x00064F10 File Offset: 0x00063110
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003118, XrefRangeEnd = 1003119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060013F0 RID: 5104 RVA: 0x00064F50 File Offset: 0x00063150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x060013F1 RID: 5105 RVA: 0x00064F90 File Offset: 0x00063190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003119, XrefRangeEnd = 1003127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ConcatIterator_d__59<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060013F2 RID: 5106 RVA: 0x000085AC File Offset: 0x000067AC
			public _ConcatIterator_d__59(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005F7 RID: 1527
			// (get) Token: 0x060013F3 RID: 5107 RVA: 0x00064FD0 File Offset: 0x000631D0
			// (set) Token: 0x060013F4 RID: 5108 RVA: 0x000085B5 File Offset: 0x000067B5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005F8 RID: 1528
			// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00064FF8 File Offset: 0x000631F8
			// (set) Token: 0x060013F6 RID: 5110 RVA: 0x00065020 File Offset: 0x00063220
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x170005F9 RID: 1529
			// (get) Token: 0x060013F7 RID: 5111 RVA: 0x000650C8 File Offset: 0x000632C8
			// (set) Token: 0x060013F8 RID: 5112 RVA: 0x000085D0 File Offset: 0x000067D0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005FA RID: 1530
			// (get) Token: 0x060013F9 RID: 5113 RVA: 0x000650F0 File Offset: 0x000632F0
			// (set) Token: 0x060013FA RID: 5114 RVA: 0x000085EB File Offset: 0x000067EB
			public unsafe IEnumerable<TSource> first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr_first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FB RID: 1531
			// (get) Token: 0x060013FB RID: 5115 RVA: 0x00065120 File Offset: 0x00063320
			// (set) Token: 0x060013FC RID: 5116 RVA: 0x0000860A File Offset: 0x0000680A
			public unsafe IEnumerable<TSource> __3__first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___3__first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___3__first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FC RID: 1532
			// (get) Token: 0x060013FD RID: 5117 RVA: 0x00065150 File Offset: 0x00063350
			// (set) Token: 0x060013FE RID: 5118 RVA: 0x00008629 File Offset: 0x00006829
			public unsafe IEnumerable<TSource> second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr_second);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x060013FF RID: 5119 RVA: 0x00065180 File Offset: 0x00063380
			// (set) Token: 0x06001400 RID: 5120 RVA: 0x00008648 File Offset: 0x00006848
			public unsafe IEnumerable<TSource> __3__second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___3__second);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___3__second), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FE RID: 1534
			// (get) Token: 0x06001401 RID: 5121 RVA: 0x000651B0 File Offset: 0x000633B0
			// (set) Token: 0x06001402 RID: 5122 RVA: 0x00008667 File Offset: 0x00006867
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ConcatIterator_d__59<TSource>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E2E RID: 3630
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E2F RID: 3631
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E30 RID: 3632
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000E31 RID: 3633
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x04000E32 RID: 3634
			private static readonly IntPtr NativeFieldInfoPtr___3__first;

			// Token: 0x04000E33 RID: 3635
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04000E34 RID: 3636
			private static readonly IntPtr NativeFieldInfoPtr___3__second;

			// Token: 0x04000E35 RID: 3637
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000E36 RID: 3638
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E37 RID: 3639
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E38 RID: 3640
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E39 RID: 3641
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000E3A RID: 3642
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04000E3B RID: 3643
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000E3C RID: 3644
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E3D RID: 3645
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E3E RID: 3646
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000E3F RID: 3647
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000149 RID: 329
		[ObfuscatedName("System.Linq.Enumerable+<AppendIterator>d__61`1")]
		public sealed class _AppendIterator_d__61<TSource> : Object
		{
			// Token: 0x06001403 RID: 5123 RVA: 0x000651E0 File Offset: 0x000633E0
			// Note: this type is marked as 'beforefieldinit'.
			static _AppendIterator_d__61()
			{
				Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<AppendIterator>d__61`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr);
				Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, "source");
				Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, "<>3__source");
				Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, "element");
				Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___3__element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, "<>3__element");
				Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, 100663613);
				Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, 100663614);
				Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, 100663615);
				Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, 100663616);
				Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, 100663617);
				Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, 100663618);
				Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, 100663619);
				Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, 100663620);
				Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr, 100663621);
			}

			// Token: 0x06001404 RID: 5124 RVA: 0x0006539C File Offset: 0x0006359C
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AppendIterator_d__61(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._AppendIterator_d__61<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001405 RID: 5125 RVA: 0x000653E4 File Offset: 0x000635E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003127, XrefRangeEnd = 1003132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001406 RID: 5126 RVA: 0x00065418 File Offset: 0x00063618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003132, XrefRangeEnd = 1003152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001407 RID: 5127 RVA: 0x00065454 File Offset: 0x00063654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003152, XrefRangeEnd = 1003155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000609 RID: 1545
			// (get) Token: 0x06001408 RID: 5128 RVA: 0x00065488 File Offset: 0x00063688
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x06001409 RID: 5129 RVA: 0x000654C4 File Offset: 0x000636C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700060A RID: 1546
			// (get) Token: 0x0600140A RID: 5130 RVA: 0x000654F8 File Offset: 0x000636F8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600140B RID: 5131 RVA: 0x00065538 File Offset: 0x00063738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003155, XrefRangeEnd = 1003163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x0600140C RID: 5132 RVA: 0x00065578 File Offset: 0x00063778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003163, XrefRangeEnd = 1003171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._AppendIterator_d__61<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600140D RID: 5133 RVA: 0x00008686 File Offset: 0x00006886
			public _AppendIterator_d__61(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x0600140E RID: 5134 RVA: 0x000655B8 File Offset: 0x000637B8
			// (set) Token: 0x0600140F RID: 5135 RVA: 0x0000868F File Offset: 0x0000688F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x06001410 RID: 5136 RVA: 0x000655E0 File Offset: 0x000637E0
			// (set) Token: 0x06001411 RID: 5137 RVA: 0x00065608 File Offset: 0x00063808
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x17000603 RID: 1539
			// (get) Token: 0x06001412 RID: 5138 RVA: 0x000656B0 File Offset: 0x000638B0
			// (set) Token: 0x06001413 RID: 5139 RVA: 0x000086AA File Offset: 0x000068AA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x06001414 RID: 5140 RVA: 0x000656D8 File Offset: 0x000638D8
			// (set) Token: 0x06001415 RID: 5141 RVA: 0x000086C5 File Offset: 0x000068C5
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000605 RID: 1541
			// (get) Token: 0x06001416 RID: 5142 RVA: 0x00065708 File Offset: 0x00063908
			// (set) Token: 0x06001417 RID: 5143 RVA: 0x000086E4 File Offset: 0x000068E4
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x06001418 RID: 5144 RVA: 0x00065738 File Offset: 0x00063938
			// (set) Token: 0x06001419 RID: 5145 RVA: 0x00065760 File Offset: 0x00063960
			public unsafe TSource element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr_element);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr_element);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x17000607 RID: 1543
			// (get) Token: 0x0600141A RID: 5146 RVA: 0x00065808 File Offset: 0x00063A08
			// (set) Token: 0x0600141B RID: 5147 RVA: 0x00065830 File Offset: 0x00063A30
			public unsafe TSource __3__element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___3__element);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___3__element);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x17000608 RID: 1544
			// (get) Token: 0x0600141C RID: 5148 RVA: 0x000658D8 File Offset: 0x00063AD8
			// (set) Token: 0x0600141D RID: 5149 RVA: 0x00008703 File Offset: 0x00006903
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._AppendIterator_d__61<TSource>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E40 RID: 3648
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E41 RID: 3649
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E42 RID: 3650
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000E43 RID: 3651
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000E44 RID: 3652
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000E45 RID: 3653
			private static readonly IntPtr NativeFieldInfoPtr_element;

			// Token: 0x04000E46 RID: 3654
			private static readonly IntPtr NativeFieldInfoPtr___3__element;

			// Token: 0x04000E47 RID: 3655
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000E48 RID: 3656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E49 RID: 3657
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E4A RID: 3658
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E4B RID: 3659
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000E4C RID: 3660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000E4D RID: 3661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E4E RID: 3662
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E4F RID: 3663
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000E50 RID: 3664
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200014A RID: 330
		[ObfuscatedName("System.Linq.Enumerable+<PrependIterator>d__63`1")]
		public sealed class _PrependIterator_d__63<TSource> : Object
		{
			// Token: 0x0600141E RID: 5150 RVA: 0x00065908 File Offset: 0x00063B08
			// Note: this type is marked as 'beforefieldinit'.
			static _PrependIterator_d__63()
			{
				Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<PrependIterator>d__63`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr);
				Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, "element");
				Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___3__element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, "<>3__element");
				Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, "source");
				Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, "<>3__source");
				Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, 100663622);
				Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, 100663623);
				Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, 100663624);
				Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, 100663625);
				Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, 100663626);
				Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, 100663627);
				Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, 100663628);
				Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, 100663629);
				Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr, 100663630);
			}

			// Token: 0x0600141F RID: 5151 RVA: 0x00065AC4 File Offset: 0x00063CC4
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PrependIterator_d__63(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._PrependIterator_d__63<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001420 RID: 5152 RVA: 0x00065B0C File Offset: 0x00063D0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003171, XrefRangeEnd = 1003176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001421 RID: 5153 RVA: 0x00065B40 File Offset: 0x00063D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003176, XrefRangeEnd = 1003194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001422 RID: 5154 RVA: 0x00065B7C File Offset: 0x00063D7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003194, XrefRangeEnd = 1003197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x06001423 RID: 5155 RVA: 0x00065BB0 File Offset: 0x00063DB0
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x06001424 RID: 5156 RVA: 0x00065BEC File Offset: 0x00063DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000614 RID: 1556
			// (get) Token: 0x06001425 RID: 5157 RVA: 0x00065C20 File Offset: 0x00063E20
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003197, XrefRangeEnd = 1003198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001426 RID: 5158 RVA: 0x00065C60 File Offset: 0x00063E60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003198, XrefRangeEnd = 1003205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x06001427 RID: 5159 RVA: 0x00065CA0 File Offset: 0x00063EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003205, XrefRangeEnd = 1003212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._PrependIterator_d__63<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001428 RID: 5160 RVA: 0x00008722 File Offset: 0x00006922
			public _PrependIterator_d__63(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700060B RID: 1547
			// (get) Token: 0x06001429 RID: 5161 RVA: 0x00065CE0 File Offset: 0x00063EE0
			// (set) Token: 0x0600142A RID: 5162 RVA: 0x0000872B File Offset: 0x0000692B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700060C RID: 1548
			// (get) Token: 0x0600142B RID: 5163 RVA: 0x00065D08 File Offset: 0x00063F08
			// (set) Token: 0x0600142C RID: 5164 RVA: 0x00065D30 File Offset: 0x00063F30
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x1700060D RID: 1549
			// (get) Token: 0x0600142D RID: 5165 RVA: 0x00065DD8 File Offset: 0x00063FD8
			// (set) Token: 0x0600142E RID: 5166 RVA: 0x00008746 File Offset: 0x00006946
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x0600142F RID: 5167 RVA: 0x00065E00 File Offset: 0x00064000
			// (set) Token: 0x06001430 RID: 5168 RVA: 0x00065E28 File Offset: 0x00064028
			public unsafe TSource element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr_element);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr_element);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x1700060F RID: 1551
			// (get) Token: 0x06001431 RID: 5169 RVA: 0x00065ED0 File Offset: 0x000640D0
			// (set) Token: 0x06001432 RID: 5170 RVA: 0x00065EF8 File Offset: 0x000640F8
			public unsafe TSource __3__element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___3__element);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___3__element);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x06001433 RID: 5171 RVA: 0x00065FA0 File Offset: 0x000641A0
			// (set) Token: 0x06001434 RID: 5172 RVA: 0x00008761 File Offset: 0x00006961
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x06001435 RID: 5173 RVA: 0x00065FD0 File Offset: 0x000641D0
			// (set) Token: 0x06001436 RID: 5174 RVA: 0x00008780 File Offset: 0x00006980
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x06001437 RID: 5175 RVA: 0x00066000 File Offset: 0x00064200
			// (set) Token: 0x06001438 RID: 5176 RVA: 0x0000879F File Offset: 0x0000699F
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._PrependIterator_d__63<TSource>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E51 RID: 3665
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E52 RID: 3666
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E53 RID: 3667
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000E54 RID: 3668
			private static readonly IntPtr NativeFieldInfoPtr_element;

			// Token: 0x04000E55 RID: 3669
			private static readonly IntPtr NativeFieldInfoPtr___3__element;

			// Token: 0x04000E56 RID: 3670
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000E57 RID: 3671
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000E58 RID: 3672
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000E59 RID: 3673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E5A RID: 3674
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E5B RID: 3675
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E5C RID: 3676
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000E5D RID: 3677
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000E5E RID: 3678
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E5F RID: 3679
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E60 RID: 3680
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000E61 RID: 3681
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200014B RID: 331
		[ObfuscatedName("System.Linq.Enumerable+<ZipIterator>d__65`3")]
		public sealed class _ZipIterator_d__65<TFirst, TSecond, TResult> : Object
		{
			// Token: 0x06001439 RID: 5177 RVA: 0x00066030 File Offset: 0x00064230
			// Note: this type is marked as 'beforefieldinit'.
			static _ZipIterator_d__65()
			{
				Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<ZipIterator>d__65`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFirst>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSecond>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr);
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, "<>1__state");
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, "<>2__current");
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, "first");
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___3__first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, "<>3__first");
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, "second");
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___3__second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, "<>3__second");
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr_resultSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, "resultSelector");
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___3__resultSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, "<>3__resultSelector");
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr__e1_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, "<e1>5__2");
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr__e2_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, "<e2>5__3");
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, 100663631);
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, 100663632);
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, 100663633);
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, 100663634);
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, 100663635);
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, 100663636);
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, 100663637);
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, 100663638);
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, 100663639);
				Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr, 100663640);
			}

			// Token: 0x0600143A RID: 5178 RVA: 0x00066260 File Offset: 0x00064460
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 937091, RefRangeEnd = 937095, XrefRangeStart = 937091, XrefRangeEnd = 937095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ZipIterator_d__65(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600143B RID: 5179 RVA: 0x000662A8 File Offset: 0x000644A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003212, XrefRangeEnd = 1003222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600143C RID: 5180 RVA: 0x000662DC File Offset: 0x000644DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003222, XrefRangeEnd = 1003252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600143D RID: 5181 RVA: 0x00066318 File Offset: 0x00064518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003252, XrefRangeEnd = 1003255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600143E RID: 5182 RVA: 0x0006634C File Offset: 0x0006454C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003255, XrefRangeEnd = 1003258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x0600143F RID: 5183 RVA: 0x00066380 File Offset: 0x00064580
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x06001440 RID: 5184 RVA: 0x000663BC File Offset: 0x000645BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x06001441 RID: 5185 RVA: 0x000663F0 File Offset: 0x000645F0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003258, XrefRangeEnd = 1003259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001442 RID: 5186 RVA: 0x00066430 File Offset: 0x00064630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003259, XrefRangeEnd = 1003268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x06001443 RID: 5187 RVA: 0x00066470 File Offset: 0x00064670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003268, XrefRangeEnd = 1003277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001444 RID: 5188 RVA: 0x000087BE File Offset: 0x000069BE
			public _ZipIterator_d__65(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x06001445 RID: 5189 RVA: 0x000664B0 File Offset: 0x000646B0
			// (set) Token: 0x06001446 RID: 5190 RVA: 0x000087C7 File Offset: 0x000069C7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x06001447 RID: 5191 RVA: 0x000664D8 File Offset: 0x000646D8
			// (set) Token: 0x06001448 RID: 5192 RVA: 0x00066500 File Offset: 0x00064700
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x06001449 RID: 5193 RVA: 0x000665A8 File Offset: 0x000647A8
			// (set) Token: 0x0600144A RID: 5194 RVA: 0x000087E2 File Offset: 0x000069E2
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x0600144B RID: 5195 RVA: 0x000665D0 File Offset: 0x000647D0
			// (set) Token: 0x0600144C RID: 5196 RVA: 0x000087FD File Offset: 0x000069FD
			public unsafe IEnumerable<TFirst> first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr_first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TFirst>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x0600144D RID: 5197 RVA: 0x00066600 File Offset: 0x00064800
			// (set) Token: 0x0600144E RID: 5198 RVA: 0x0000881C File Offset: 0x00006A1C
			public unsafe IEnumerable<TFirst> __3__first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___3__first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TFirst>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___3__first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x0600144F RID: 5199 RVA: 0x00066630 File Offset: 0x00064830
			// (set) Token: 0x06001450 RID: 5200 RVA: 0x0000883B File Offset: 0x00006A3B
			public unsafe IEnumerable<TSecond> second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr_second);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSecond>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x06001451 RID: 5201 RVA: 0x00066660 File Offset: 0x00064860
			// (set) Token: 0x06001452 RID: 5202 RVA: 0x0000885A File Offset: 0x00006A5A
			public unsafe IEnumerable<TSecond> __3__second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___3__second);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSecond>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___3__second), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x06001453 RID: 5203 RVA: 0x00066690 File Offset: 0x00064890
			// (set) Token: 0x06001454 RID: 5204 RVA: 0x00008879 File Offset: 0x00006A79
			public unsafe Func<TFirst, TSecond, TResult> resultSelector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr_resultSelector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TFirst, TSecond, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr_resultSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x06001455 RID: 5205 RVA: 0x000666C0 File Offset: 0x000648C0
			// (set) Token: 0x06001456 RID: 5206 RVA: 0x00008898 File Offset: 0x00006A98
			public unsafe Func<TFirst, TSecond, TResult> __3__resultSelector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___3__resultSelector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TFirst, TSecond, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr___3__resultSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x06001457 RID: 5207 RVA: 0x000666F0 File Offset: 0x000648F0
			// (set) Token: 0x06001458 RID: 5208 RVA: 0x000088B7 File Offset: 0x00006AB7
			public unsafe IEnumerator<TFirst> _e1_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr__e1_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TFirst>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr__e1_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x06001459 RID: 5209 RVA: 0x00066720 File Offset: 0x00064920
			// (set) Token: 0x0600145A RID: 5210 RVA: 0x000088D6 File Offset: 0x00006AD6
			public unsafe IEnumerator<TSecond> _e2_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr__e2_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSecond>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ZipIterator_d__65<TFirst, TSecond, TResult>.NativeFieldInfoPtr__e2_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E62 RID: 3682
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E63 RID: 3683
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E64 RID: 3684
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000E65 RID: 3685
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x04000E66 RID: 3686
			private static readonly IntPtr NativeFieldInfoPtr___3__first;

			// Token: 0x04000E67 RID: 3687
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04000E68 RID: 3688
			private static readonly IntPtr NativeFieldInfoPtr___3__second;

			// Token: 0x04000E69 RID: 3689
			private static readonly IntPtr NativeFieldInfoPtr_resultSelector;

			// Token: 0x04000E6A RID: 3690
			private static readonly IntPtr NativeFieldInfoPtr___3__resultSelector;

			// Token: 0x04000E6B RID: 3691
			private static readonly IntPtr NativeFieldInfoPtr__e1_5__2;

			// Token: 0x04000E6C RID: 3692
			private static readonly IntPtr NativeFieldInfoPtr__e2_5__3;

			// Token: 0x04000E6D RID: 3693
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E6E RID: 3694
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E6F RID: 3695
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E70 RID: 3696
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000E71 RID: 3697
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04000E72 RID: 3698
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000E73 RID: 3699
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E74 RID: 3700
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E75 RID: 3701
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x04000E76 RID: 3702
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200014C RID: 332
		[ObfuscatedName("System.Linq.Enumerable+<DistinctIterator>d__68`1")]
		public sealed class _DistinctIterator_d__68<TSource> : Object
		{
			// Token: 0x0600145B RID: 5211 RVA: 0x00066750 File Offset: 0x00064950
			// Note: this type is marked as 'beforefieldinit'.
			static _DistinctIterator_d__68()
			{
				Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<DistinctIterator>d__68`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr);
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "comparer");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___3__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<>3__comparer");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "source");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<>3__source");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr__set_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<set>5__2");
				Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, "<>7__wrap2");
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663641);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663642);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663643);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663644);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663645);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663646);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663647);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663648);
				Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr, 100663649);
			}

			// Token: 0x0600145C RID: 5212 RVA: 0x00066920 File Offset: 0x00064B20
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 286249, RefRangeEnd = 286258, XrefRangeStart = 286249, XrefRangeEnd = 286258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DistinctIterator_d__68(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._DistinctIterator_d__68<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600145D RID: 5213 RVA: 0x00066968 File Offset: 0x00064B68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003277, XrefRangeEnd = 1003282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600145E RID: 5214 RVA: 0x0006699C File Offset: 0x00064B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003282, XrefRangeEnd = 1003304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600145F RID: 5215 RVA: 0x000669D8 File Offset: 0x00064BD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003304, XrefRangeEnd = 1003307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700062B RID: 1579
			// (get) Token: 0x06001460 RID: 5216 RVA: 0x00066A0C File Offset: 0x00064C0C
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x06001461 RID: 5217 RVA: 0x00066A48 File Offset: 0x00064C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700062C RID: 1580
			// (get) Token: 0x06001462 RID: 5218 RVA: 0x00066A7C File Offset: 0x00064C7C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003307, XrefRangeEnd = 1003308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001463 RID: 5219 RVA: 0x00066ABC File Offset: 0x00064CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003308, XrefRangeEnd = 1003316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x06001464 RID: 5220 RVA: 0x00066AFC File Offset: 0x00064CFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003316, XrefRangeEnd = 1003324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._DistinctIterator_d__68<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001465 RID: 5221 RVA: 0x000088F5 File Offset: 0x00006AF5
			public _DistinctIterator_d__68(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x06001466 RID: 5222 RVA: 0x00066B3C File Offset: 0x00064D3C
			// (set) Token: 0x06001467 RID: 5223 RVA: 0x000088FE File Offset: 0x00006AFE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000623 RID: 1571
			// (get) Token: 0x06001468 RID: 5224 RVA: 0x00066B64 File Offset: 0x00064D64
			// (set) Token: 0x06001469 RID: 5225 RVA: 0x00066B8C File Offset: 0x00064D8C
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x0600146A RID: 5226 RVA: 0x00066C34 File Offset: 0x00064E34
			// (set) Token: 0x0600146B RID: 5227 RVA: 0x00008919 File Offset: 0x00006B19
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x0600146C RID: 5228 RVA: 0x00066C5C File Offset: 0x00064E5C
			// (set) Token: 0x0600146D RID: 5229 RVA: 0x00008934 File Offset: 0x00006B34
			public unsafe IEqualityComparer<TSource> comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr_comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x0600146E RID: 5230 RVA: 0x00066C8C File Offset: 0x00064E8C
			// (set) Token: 0x0600146F RID: 5231 RVA: 0x00008953 File Offset: 0x00006B53
			public unsafe IEqualityComparer<TSource> __3__comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___3__comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___3__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x06001470 RID: 5232 RVA: 0x00066CBC File Offset: 0x00064EBC
			// (set) Token: 0x06001471 RID: 5233 RVA: 0x00008972 File Offset: 0x00006B72
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x06001472 RID: 5234 RVA: 0x00066CEC File Offset: 0x00064EEC
			// (set) Token: 0x06001473 RID: 5235 RVA: 0x00008991 File Offset: 0x00006B91
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x06001474 RID: 5236 RVA: 0x00066D1C File Offset: 0x00064F1C
			// (set) Token: 0x06001475 RID: 5237 RVA: 0x000089B0 File Offset: 0x00006BB0
			public unsafe Set<TSource> _set_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr__set_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Set<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr__set_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x06001476 RID: 5238 RVA: 0x00066D4C File Offset: 0x00064F4C
			// (set) Token: 0x06001477 RID: 5239 RVA: 0x000089CF File Offset: 0x00006BCF
			public unsafe IEnumerator<TSource> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._DistinctIterator_d__68<TSource>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E77 RID: 3703
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E78 RID: 3704
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E79 RID: 3705
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000E7A RID: 3706
			private static readonly IntPtr NativeFieldInfoPtr_comparer;

			// Token: 0x04000E7B RID: 3707
			private static readonly IntPtr NativeFieldInfoPtr___3__comparer;

			// Token: 0x04000E7C RID: 3708
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000E7D RID: 3709
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000E7E RID: 3710
			private static readonly IntPtr NativeFieldInfoPtr__set_5__2;

			// Token: 0x04000E7F RID: 3711
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000E80 RID: 3712
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E81 RID: 3713
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E82 RID: 3714
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E83 RID: 3715
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000E84 RID: 3716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000E85 RID: 3717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E86 RID: 3718
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E87 RID: 3719
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000E88 RID: 3720
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200014D RID: 333
		[ObfuscatedName("System.Linq.Enumerable+<UnionIterator>d__71`1")]
		public sealed class _UnionIterator_d__71<TSource> : Object
		{
			// Token: 0x06001478 RID: 5240 RVA: 0x00066D7C File Offset: 0x00064F7C
			// Note: this type is marked as 'beforefieldinit'.
			static _UnionIterator_d__71()
			{
				Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<UnionIterator>d__71`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr);
				Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, "comparer");
				Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___3__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, "<>3__comparer");
				Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, "first");
				Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___3__first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, "<>3__first");
				Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, "second");
				Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___3__second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, "<>3__second");
				Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr__set_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, "<set>5__2");
				Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, "<>7__wrap2");
				Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, 100663650);
				Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, 100663651);
				Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, 100663652);
				Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, 100663653);
				Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, 100663654);
				Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, 100663655);
				Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, 100663656);
				Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, 100663657);
				Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, 100663658);
				Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr, 100663659);
			}

			// Token: 0x06001479 RID: 5241 RVA: 0x00066F88 File Offset: 0x00065188
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 286249, RefRangeEnd = 286258, XrefRangeStart = 286249, XrefRangeEnd = 286258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UnionIterator_d__71(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._UnionIterator_d__71<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600147A RID: 5242 RVA: 0x00066FD0 File Offset: 0x000651D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003324, XrefRangeEnd = 1003334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600147B RID: 5243 RVA: 0x00067004 File Offset: 0x00065204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003334, XrefRangeEnd = 1003369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600147C RID: 5244 RVA: 0x00067040 File Offset: 0x00065240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003369, XrefRangeEnd = 1003372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600147D RID: 5245 RVA: 0x00067074 File Offset: 0x00065274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003372, XrefRangeEnd = 1003375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000638 RID: 1592
			// (get) Token: 0x0600147E RID: 5246 RVA: 0x000670A8 File Offset: 0x000652A8
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x0600147F RID: 5247 RVA: 0x000670E4 File Offset: 0x000652E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x06001480 RID: 5248 RVA: 0x00067118 File Offset: 0x00065318
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003375, XrefRangeEnd = 1003376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001481 RID: 5249 RVA: 0x00067158 File Offset: 0x00065358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003376, XrefRangeEnd = 1003385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x06001482 RID: 5250 RVA: 0x00067198 File Offset: 0x00065398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003385, XrefRangeEnd = 1003394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._UnionIterator_d__71<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001483 RID: 5251 RVA: 0x000089EE File Offset: 0x00006BEE
			public _UnionIterator_d__71(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700062D RID: 1581
			// (get) Token: 0x06001484 RID: 5252 RVA: 0x000671D8 File Offset: 0x000653D8
			// (set) Token: 0x06001485 RID: 5253 RVA: 0x000089F7 File Offset: 0x00006BF7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700062E RID: 1582
			// (get) Token: 0x06001486 RID: 5254 RVA: 0x00067200 File Offset: 0x00065400
			// (set) Token: 0x06001487 RID: 5255 RVA: 0x00067228 File Offset: 0x00065428
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x06001488 RID: 5256 RVA: 0x000672D0 File Offset: 0x000654D0
			// (set) Token: 0x06001489 RID: 5257 RVA: 0x00008A12 File Offset: 0x00006C12
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000630 RID: 1584
			// (get) Token: 0x0600148A RID: 5258 RVA: 0x000672F8 File Offset: 0x000654F8
			// (set) Token: 0x0600148B RID: 5259 RVA: 0x00008A2D File Offset: 0x00006C2D
			public unsafe IEqualityComparer<TSource> comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr_comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x0600148C RID: 5260 RVA: 0x00067328 File Offset: 0x00065528
			// (set) Token: 0x0600148D RID: 5261 RVA: 0x00008A4C File Offset: 0x00006C4C
			public unsafe IEqualityComparer<TSource> __3__comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___3__comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___3__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x0600148E RID: 5262 RVA: 0x00067358 File Offset: 0x00065558
			// (set) Token: 0x0600148F RID: 5263 RVA: 0x00008A6B File Offset: 0x00006C6B
			public unsafe IEnumerable<TSource> first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr_first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x06001490 RID: 5264 RVA: 0x00067388 File Offset: 0x00065588
			// (set) Token: 0x06001491 RID: 5265 RVA: 0x00008A8A File Offset: 0x00006C8A
			public unsafe IEnumerable<TSource> __3__first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___3__first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___3__first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000634 RID: 1588
			// (get) Token: 0x06001492 RID: 5266 RVA: 0x000673B8 File Offset: 0x000655B8
			// (set) Token: 0x06001493 RID: 5267 RVA: 0x00008AA9 File Offset: 0x00006CA9
			public unsafe IEnumerable<TSource> second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr_second);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x06001494 RID: 5268 RVA: 0x000673E8 File Offset: 0x000655E8
			// (set) Token: 0x06001495 RID: 5269 RVA: 0x00008AC8 File Offset: 0x00006CC8
			public unsafe IEnumerable<TSource> __3__second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___3__second);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___3__second), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x06001496 RID: 5270 RVA: 0x00067418 File Offset: 0x00065618
			// (set) Token: 0x06001497 RID: 5271 RVA: 0x00008AE7 File Offset: 0x00006CE7
			public unsafe Set<TSource> _set_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr__set_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Set<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr__set_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x06001498 RID: 5272 RVA: 0x00067448 File Offset: 0x00065648
			// (set) Token: 0x06001499 RID: 5273 RVA: 0x00008B06 File Offset: 0x00006D06
			public unsafe IEnumerator<TSource> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._UnionIterator_d__71<TSource>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E89 RID: 3721
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E8A RID: 3722
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E8B RID: 3723
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000E8C RID: 3724
			private static readonly IntPtr NativeFieldInfoPtr_comparer;

			// Token: 0x04000E8D RID: 3725
			private static readonly IntPtr NativeFieldInfoPtr___3__comparer;

			// Token: 0x04000E8E RID: 3726
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x04000E8F RID: 3727
			private static readonly IntPtr NativeFieldInfoPtr___3__first;

			// Token: 0x04000E90 RID: 3728
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04000E91 RID: 3729
			private static readonly IntPtr NativeFieldInfoPtr___3__second;

			// Token: 0x04000E92 RID: 3730
			private static readonly IntPtr NativeFieldInfoPtr__set_5__2;

			// Token: 0x04000E93 RID: 3731
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000E94 RID: 3732
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E95 RID: 3733
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E96 RID: 3734
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E97 RID: 3735
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000E98 RID: 3736
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04000E99 RID: 3737
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000E9A RID: 3738
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E9B RID: 3739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E9C RID: 3740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000E9D RID: 3741
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200014E RID: 334
		[ObfuscatedName("System.Linq.Enumerable+<IntersectIterator>d__74`1")]
		public sealed class _IntersectIterator_d__74<TSource> : Object
		{
			// Token: 0x0600149A RID: 5274 RVA: 0x00067478 File Offset: 0x00065678
			// Note: this type is marked as 'beforefieldinit'.
			static _IntersectIterator_d__74()
			{
				Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<IntersectIterator>d__74`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr);
				Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, "comparer");
				Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___3__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, "<>3__comparer");
				Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, "second");
				Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___3__second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, "<>3__second");
				Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, "first");
				Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___3__first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, "<>3__first");
				Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr__set_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, "<set>5__2");
				Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, "<>7__wrap2");
				Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, 100663660);
				Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, 100663661);
				Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, 100663662);
				Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, 100663663);
				Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, 100663664);
				Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, 100663665);
				Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, 100663666);
				Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, 100663667);
				Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr, 100663668);
			}

			// Token: 0x0600149B RID: 5275 RVA: 0x00067670 File Offset: 0x00065870
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IntersectIterator_d__74(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._IntersectIterator_d__74<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600149C RID: 5276 RVA: 0x000676B8 File Offset: 0x000658B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003394, XrefRangeEnd = 1003399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600149D RID: 5277 RVA: 0x000676EC File Offset: 0x000658EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003399, XrefRangeEnd = 1003438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600149E RID: 5278 RVA: 0x00067728 File Offset: 0x00065928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003438, XrefRangeEnd = 1003441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000645 RID: 1605
			// (get) Token: 0x0600149F RID: 5279 RVA: 0x0006775C File Offset: 0x0006595C
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x060014A0 RID: 5280 RVA: 0x00067798 File Offset: 0x00065998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x060014A1 RID: 5281 RVA: 0x000677CC File Offset: 0x000659CC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060014A2 RID: 5282 RVA: 0x0006780C File Offset: 0x00065A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003441, XrefRangeEnd = 1003450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x060014A3 RID: 5283 RVA: 0x0006784C File Offset: 0x00065A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003450, XrefRangeEnd = 1003459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._IntersectIterator_d__74<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060014A4 RID: 5284 RVA: 0x00008B25 File Offset: 0x00006D25
			public _IntersectIterator_d__74(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0006788C File Offset: 0x00065A8C
			// (set) Token: 0x060014A6 RID: 5286 RVA: 0x00008B2E File Offset: 0x00006D2E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700063B RID: 1595
			// (get) Token: 0x060014A7 RID: 5287 RVA: 0x000678B4 File Offset: 0x00065AB4
			// (set) Token: 0x060014A8 RID: 5288 RVA: 0x000678DC File Offset: 0x00065ADC
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x1700063C RID: 1596
			// (get) Token: 0x060014A9 RID: 5289 RVA: 0x00067984 File Offset: 0x00065B84
			// (set) Token: 0x060014AA RID: 5290 RVA: 0x00008B49 File Offset: 0x00006D49
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700063D RID: 1597
			// (get) Token: 0x060014AB RID: 5291 RVA: 0x000679AC File Offset: 0x00065BAC
			// (set) Token: 0x060014AC RID: 5292 RVA: 0x00008B64 File Offset: 0x00006D64
			public unsafe IEqualityComparer<TSource> comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr_comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063E RID: 1598
			// (get) Token: 0x060014AD RID: 5293 RVA: 0x000679DC File Offset: 0x00065BDC
			// (set) Token: 0x060014AE RID: 5294 RVA: 0x00008B83 File Offset: 0x00006D83
			public unsafe IEqualityComparer<TSource> __3__comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___3__comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___3__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063F RID: 1599
			// (get) Token: 0x060014AF RID: 5295 RVA: 0x00067A0C File Offset: 0x00065C0C
			// (set) Token: 0x060014B0 RID: 5296 RVA: 0x00008BA2 File Offset: 0x00006DA2
			public unsafe IEnumerable<TSource> second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr_second);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000640 RID: 1600
			// (get) Token: 0x060014B1 RID: 5297 RVA: 0x00067A3C File Offset: 0x00065C3C
			// (set) Token: 0x060014B2 RID: 5298 RVA: 0x00008BC1 File Offset: 0x00006DC1
			public unsafe IEnumerable<TSource> __3__second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___3__second);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___3__second), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000641 RID: 1601
			// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00067A6C File Offset: 0x00065C6C
			// (set) Token: 0x060014B4 RID: 5300 RVA: 0x00008BE0 File Offset: 0x00006DE0
			public unsafe IEnumerable<TSource> first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr_first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000642 RID: 1602
			// (get) Token: 0x060014B5 RID: 5301 RVA: 0x00067A9C File Offset: 0x00065C9C
			// (set) Token: 0x060014B6 RID: 5302 RVA: 0x00008BFF File Offset: 0x00006DFF
			public unsafe IEnumerable<TSource> __3__first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___3__first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___3__first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000643 RID: 1603
			// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00067ACC File Offset: 0x00065CCC
			// (set) Token: 0x060014B8 RID: 5304 RVA: 0x00008C1E File Offset: 0x00006E1E
			public unsafe Set<TSource> _set_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr__set_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Set<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr__set_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000644 RID: 1604
			// (get) Token: 0x060014B9 RID: 5305 RVA: 0x00067AFC File Offset: 0x00065CFC
			// (set) Token: 0x060014BA RID: 5306 RVA: 0x00008C3D File Offset: 0x00006E3D
			public unsafe IEnumerator<TSource> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._IntersectIterator_d__74<TSource>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E9E RID: 3742
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E9F RID: 3743
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000EA0 RID: 3744
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000EA1 RID: 3745
			private static readonly IntPtr NativeFieldInfoPtr_comparer;

			// Token: 0x04000EA2 RID: 3746
			private static readonly IntPtr NativeFieldInfoPtr___3__comparer;

			// Token: 0x04000EA3 RID: 3747
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04000EA4 RID: 3748
			private static readonly IntPtr NativeFieldInfoPtr___3__second;

			// Token: 0x04000EA5 RID: 3749
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x04000EA6 RID: 3750
			private static readonly IntPtr NativeFieldInfoPtr___3__first;

			// Token: 0x04000EA7 RID: 3751
			private static readonly IntPtr NativeFieldInfoPtr__set_5__2;

			// Token: 0x04000EA8 RID: 3752
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000EA9 RID: 3753
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000EAA RID: 3754
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EAB RID: 3755
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000EAC RID: 3756
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000EAD RID: 3757
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000EAE RID: 3758
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EAF RID: 3759
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000EB0 RID: 3760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000EB1 RID: 3761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200014F RID: 335
		[ObfuscatedName("System.Linq.Enumerable+<ExceptIterator>d__77`1")]
		public sealed class _ExceptIterator_d__77<TSource> : Object
		{
			// Token: 0x060014BB RID: 5307 RVA: 0x00067B2C File Offset: 0x00065D2C
			// Note: this type is marked as 'beforefieldinit'.
			static _ExceptIterator_d__77()
			{
				Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<ExceptIterator>d__77`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr);
				Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, "comparer");
				Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___3__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, "<>3__comparer");
				Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, "second");
				Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___3__second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, "<>3__second");
				Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, "first");
				Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___3__first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, "<>3__first");
				Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr__set_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, "<set>5__2");
				Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, "<>7__wrap2");
				Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, 100663669);
				Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, 100663670);
				Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, 100663671);
				Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, 100663672);
				Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, 100663673);
				Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, 100663674);
				Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, 100663675);
				Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, 100663676);
				Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr, 100663677);
			}

			// Token: 0x060014BC RID: 5308 RVA: 0x00067D24 File Offset: 0x00065F24
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1003461, RefRangeEnd = 1003463, XrefRangeStart = 1003459, XrefRangeEnd = 1003461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExceptIterator_d__77(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._ExceptIterator_d__77<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060014BD RID: 5309 RVA: 0x00067D6C File Offset: 0x00065F6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003463, XrefRangeEnd = 1003468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014BE RID: 5310 RVA: 0x00067DA0 File Offset: 0x00065FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003468, XrefRangeEnd = 1003506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060014BF RID: 5311 RVA: 0x00067DDC File Offset: 0x00065FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003506, XrefRangeEnd = 1003509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000652 RID: 1618
			// (get) Token: 0x060014C0 RID: 5312 RVA: 0x00067E10 File Offset: 0x00066010
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x060014C1 RID: 5313 RVA: 0x00067E4C File Offset: 0x0006604C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000653 RID: 1619
			// (get) Token: 0x060014C2 RID: 5314 RVA: 0x00067E80 File Offset: 0x00066080
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003509, XrefRangeEnd = 1003510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060014C3 RID: 5315 RVA: 0x00067EC0 File Offset: 0x000660C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003510, XrefRangeEnd = 1003519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x060014C4 RID: 5316 RVA: 0x00067F00 File Offset: 0x00066100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003519, XrefRangeEnd = 1003528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ExceptIterator_d__77<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060014C5 RID: 5317 RVA: 0x00008C5C File Offset: 0x00006E5C
			public _ExceptIterator_d__77(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000647 RID: 1607
			// (get) Token: 0x060014C6 RID: 5318 RVA: 0x00067F40 File Offset: 0x00066140
			// (set) Token: 0x060014C7 RID: 5319 RVA: 0x00008C65 File Offset: 0x00006E65
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000648 RID: 1608
			// (get) Token: 0x060014C8 RID: 5320 RVA: 0x00067F68 File Offset: 0x00066168
			// (set) Token: 0x060014C9 RID: 5321 RVA: 0x00067F90 File Offset: 0x00066190
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x060014CA RID: 5322 RVA: 0x00068038 File Offset: 0x00066238
			// (set) Token: 0x060014CB RID: 5323 RVA: 0x00008C80 File Offset: 0x00006E80
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x060014CC RID: 5324 RVA: 0x00068060 File Offset: 0x00066260
			// (set) Token: 0x060014CD RID: 5325 RVA: 0x00008C9B File Offset: 0x00006E9B
			public unsafe IEqualityComparer<TSource> comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr_comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x060014CE RID: 5326 RVA: 0x00068090 File Offset: 0x00066290
			// (set) Token: 0x060014CF RID: 5327 RVA: 0x00008CBA File Offset: 0x00006EBA
			public unsafe IEqualityComparer<TSource> __3__comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___3__comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___3__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x060014D0 RID: 5328 RVA: 0x000680C0 File Offset: 0x000662C0
			// (set) Token: 0x060014D1 RID: 5329 RVA: 0x00008CD9 File Offset: 0x00006ED9
			public unsafe IEnumerable<TSource> second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr_second);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr_second), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x060014D2 RID: 5330 RVA: 0x000680F0 File Offset: 0x000662F0
			// (set) Token: 0x060014D3 RID: 5331 RVA: 0x00008CF8 File Offset: 0x00006EF8
			public unsafe IEnumerable<TSource> __3__second
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___3__second);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___3__second), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x060014D4 RID: 5332 RVA: 0x00068120 File Offset: 0x00066320
			// (set) Token: 0x060014D5 RID: 5333 RVA: 0x00008D17 File Offset: 0x00006F17
			public unsafe IEnumerable<TSource> first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr_first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr_first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x060014D6 RID: 5334 RVA: 0x00068150 File Offset: 0x00066350
			// (set) Token: 0x060014D7 RID: 5335 RVA: 0x00008D36 File Offset: 0x00006F36
			public unsafe IEnumerable<TSource> __3__first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___3__first);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___3__first), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x060014D8 RID: 5336 RVA: 0x00068180 File Offset: 0x00066380
			// (set) Token: 0x060014D9 RID: 5337 RVA: 0x00008D55 File Offset: 0x00006F55
			public unsafe Set<TSource> _set_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr__set_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Set<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr__set_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x060014DA RID: 5338 RVA: 0x000681B0 File Offset: 0x000663B0
			// (set) Token: 0x060014DB RID: 5339 RVA: 0x00008D74 File Offset: 0x00006F74
			public unsafe IEnumerator<TSource> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ExceptIterator_d__77<TSource>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EB2 RID: 3762
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000EB3 RID: 3763
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000EB4 RID: 3764
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000EB5 RID: 3765
			private static readonly IntPtr NativeFieldInfoPtr_comparer;

			// Token: 0x04000EB6 RID: 3766
			private static readonly IntPtr NativeFieldInfoPtr___3__comparer;

			// Token: 0x04000EB7 RID: 3767
			private static readonly IntPtr NativeFieldInfoPtr_second;

			// Token: 0x04000EB8 RID: 3768
			private static readonly IntPtr NativeFieldInfoPtr___3__second;

			// Token: 0x04000EB9 RID: 3769
			private static readonly IntPtr NativeFieldInfoPtr_first;

			// Token: 0x04000EBA RID: 3770
			private static readonly IntPtr NativeFieldInfoPtr___3__first;

			// Token: 0x04000EBB RID: 3771
			private static readonly IntPtr NativeFieldInfoPtr__set_5__2;

			// Token: 0x04000EBC RID: 3772
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000EBD RID: 3773
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000EBE RID: 3774
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EBF RID: 3775
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000EC0 RID: 3776
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000EC1 RID: 3777
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000EC2 RID: 3778
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EC3 RID: 3779
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000EC4 RID: 3780
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000EC5 RID: 3781
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000150 RID: 336
		[ObfuscatedName("System.Linq.Enumerable+<ReverseIterator>d__79`1")]
		public sealed class _ReverseIterator_d__79<TSource> : Object
		{
			// Token: 0x060014DC RID: 5340 RVA: 0x000681E0 File Offset: 0x000663E0
			// Note: this type is marked as 'beforefieldinit'.
			static _ReverseIterator_d__79()
			{
				Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<ReverseIterator>d__79`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr);
				Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, "source");
				Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, "<>3__source");
				Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr__buffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, "<buffer>5__2");
				Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, "<i>5__3");
				Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, 100663678);
				Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, 100663679);
				Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, 100663680);
				Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, 100663681);
				Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, 100663682);
				Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, 100663683);
				Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, 100663684);
				Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr, 100663685);
			}

			// Token: 0x060014DD RID: 5341 RVA: 0x00068374 File Offset: 0x00066574
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ReverseIterator_d__79(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._ReverseIterator_d__79<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060014DE RID: 5342 RVA: 0x000683BC File Offset: 0x000665BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014DF RID: 5343 RVA: 0x000683F0 File Offset: 0x000665F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003528, XrefRangeEnd = 1003532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700065B RID: 1627
			// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0006842C File Offset: 0x0006662C
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x060014E1 RID: 5345 RVA: 0x00068468 File Offset: 0x00066668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700065C RID: 1628
			// (get) Token: 0x060014E2 RID: 5346 RVA: 0x0006849C File Offset: 0x0006669C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060014E3 RID: 5347 RVA: 0x000684DC File Offset: 0x000666DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x060014E4 RID: 5348 RVA: 0x0006851C File Offset: 0x0006671C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003532, XrefRangeEnd = 1003539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._ReverseIterator_d__79<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060014E5 RID: 5349 RVA: 0x00008D93 File Offset: 0x00006F93
			public _ReverseIterator_d__79(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000654 RID: 1620
			// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0006855C File Offset: 0x0006675C
			// (set) Token: 0x060014E7 RID: 5351 RVA: 0x00008D9C File Offset: 0x00006F9C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000655 RID: 1621
			// (get) Token: 0x060014E8 RID: 5352 RVA: 0x00068584 File Offset: 0x00066784
			// (set) Token: 0x060014E9 RID: 5353 RVA: 0x000685AC File Offset: 0x000667AC
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x17000656 RID: 1622
			// (get) Token: 0x060014EA RID: 5354 RVA: 0x00068654 File Offset: 0x00066854
			// (set) Token: 0x060014EB RID: 5355 RVA: 0x00008DB7 File Offset: 0x00006FB7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000657 RID: 1623
			// (get) Token: 0x060014EC RID: 5356 RVA: 0x0006867C File Offset: 0x0006687C
			// (set) Token: 0x060014ED RID: 5357 RVA: 0x00008DD2 File Offset: 0x00006FD2
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000658 RID: 1624
			// (get) Token: 0x060014EE RID: 5358 RVA: 0x000686AC File Offset: 0x000668AC
			// (set) Token: 0x060014EF RID: 5359 RVA: 0x00008DF1 File Offset: 0x00006FF1
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000659 RID: 1625
			// (get) Token: 0x060014F0 RID: 5360 RVA: 0x000686DC File Offset: 0x000668DC
			// (set) Token: 0x060014F1 RID: 5361 RVA: 0x00008E10 File Offset: 0x00007010
			public Buffer<TSource> _buffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr__buffer_5__2);
					return new Buffer<TSource>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buffer<TSource>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr__buffer_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Buffer<TSource>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700065A RID: 1626
			// (get) Token: 0x060014F2 RID: 5362 RVA: 0x0006870C File Offset: 0x0006690C
			// (set) Token: 0x060014F3 RID: 5363 RVA: 0x00008E3E File Offset: 0x0000703E
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._ReverseIterator_d__79<TSource>.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04000EC6 RID: 3782
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000EC7 RID: 3783
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000EC8 RID: 3784
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000EC9 RID: 3785
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000ECA RID: 3786
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000ECB RID: 3787
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__2;

			// Token: 0x04000ECC RID: 3788
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04000ECD RID: 3789
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000ECE RID: 3790
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000ECF RID: 3791
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000ED0 RID: 3792
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000ED1 RID: 3793
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000ED2 RID: 3794
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000ED3 RID: 3795
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000ED4 RID: 3796
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000151 RID: 337
		[ObfuscatedName("System.Linq.Enumerable+<OfTypeIterator>d__97`1")]
		public sealed class _OfTypeIterator_d__97<TResult> : Object
		{
			// Token: 0x060014F4 RID: 5364 RVA: 0x00068734 File Offset: 0x00066934
			// Note: this type is marked as 'beforefieldinit'.
			static _OfTypeIterator_d__97()
			{
				Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<OfTypeIterator>d__97`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr);
				Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, "<>1__state");
				Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, "<>2__current");
				Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, "source");
				Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, "<>3__source");
				Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, 100663686);
				Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, 100663687);
				Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, 100663688);
				Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, 100663689);
				Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, 100663690);
				Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, 100663691);
				Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, 100663692);
				Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, 100663693);
				Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr, 100663694);
			}

			// Token: 0x060014F5 RID: 5365 RVA: 0x000688C8 File Offset: 0x00066AC8
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 286249, RefRangeEnd = 286258, XrefRangeStart = 286249, XrefRangeEnd = 286258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OfTypeIterator_d__97(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._OfTypeIterator_d__97<TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060014F6 RID: 5366 RVA: 0x00068910 File Offset: 0x00066B10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003539, XrefRangeEnd = 1003542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014F7 RID: 5367 RVA: 0x00068944 File Offset: 0x00066B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003542, XrefRangeEnd = 1003561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060014F8 RID: 5368 RVA: 0x00068980 File Offset: 0x00066B80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003561, XrefRangeEnd = 1003566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000663 RID: 1635
			// (get) Token: 0x060014F9 RID: 5369 RVA: 0x000689B4 File Offset: 0x00066BB4
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x060014FA RID: 5370 RVA: 0x000689F0 File Offset: 0x00066BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000664 RID: 1636
			// (get) Token: 0x060014FB RID: 5371 RVA: 0x00068A24 File Offset: 0x00066C24
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003566, XrefRangeEnd = 1003567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060014FC RID: 5372 RVA: 0x00068A64 File Offset: 0x00066C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x060014FD RID: 5373 RVA: 0x00068AA4 File Offset: 0x00066CA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003567, XrefRangeEnd = 1003574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._OfTypeIterator_d__97<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060014FE RID: 5374 RVA: 0x00008E59 File Offset: 0x00007059
			public _OfTypeIterator_d__97(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x060014FF RID: 5375 RVA: 0x00068AE4 File Offset: 0x00066CE4
			// (set) Token: 0x06001500 RID: 5376 RVA: 0x00008E62 File Offset: 0x00007062
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700065E RID: 1630
			// (get) Token: 0x06001501 RID: 5377 RVA: 0x00068B0C File Offset: 0x00066D0C
			// (set) Token: 0x06001502 RID: 5378 RVA: 0x00068B34 File Offset: 0x00066D34
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x1700065F RID: 1631
			// (get) Token: 0x06001503 RID: 5379 RVA: 0x00068BDC File Offset: 0x00066DDC
			// (set) Token: 0x06001504 RID: 5380 RVA: 0x00008E7D File Offset: 0x0000707D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000660 RID: 1632
			// (get) Token: 0x06001505 RID: 5381 RVA: 0x00068C04 File Offset: 0x00066E04
			// (set) Token: 0x06001506 RID: 5382 RVA: 0x00008E98 File Offset: 0x00007098
			public unsafe IEnumerable source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000661 RID: 1633
			// (get) Token: 0x06001507 RID: 5383 RVA: 0x00068C34 File Offset: 0x00066E34
			// (set) Token: 0x06001508 RID: 5384 RVA: 0x00008EB7 File Offset: 0x000070B7
			public unsafe IEnumerable __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000662 RID: 1634
			// (get) Token: 0x06001509 RID: 5385 RVA: 0x00068C64 File Offset: 0x00066E64
			// (set) Token: 0x0600150A RID: 5386 RVA: 0x00008ED6 File Offset: 0x000070D6
			public unsafe IEnumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._OfTypeIterator_d__97<TResult>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000ED5 RID: 3797
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000ED6 RID: 3798
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000ED7 RID: 3799
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000ED8 RID: 3800
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000ED9 RID: 3801
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000EDA RID: 3802
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000EDB RID: 3803
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000EDC RID: 3804
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EDD RID: 3805
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000EDE RID: 3806
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000EDF RID: 3807
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000EE0 RID: 3808
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EE1 RID: 3809
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000EE2 RID: 3810
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x04000EE3 RID: 3811
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000152 RID: 338
		[ObfuscatedName("System.Linq.Enumerable+<CastIterator>d__99`1")]
		public sealed class _CastIterator_d__99<TResult> : Object
		{
			// Token: 0x0600150B RID: 5387 RVA: 0x00068C94 File Offset: 0x00066E94
			// Note: this type is marked as 'beforefieldinit'.
			static _CastIterator_d__99()
			{
				Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<CastIterator>d__99`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr);
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>1__state");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>2__current");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "source");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>3__source");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663695);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663696);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663697);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663698);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663699);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663700);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663701);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663702);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663703);
			}

			// Token: 0x0600150C RID: 5388 RVA: 0x00068E28 File Offset: 0x00067028
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CastIterator_d__99(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600150D RID: 5389 RVA: 0x00068E70 File Offset: 0x00067070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003574, XrefRangeEnd = 1003577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600150E RID: 5390 RVA: 0x00068EA4 File Offset: 0x000670A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003577, XrefRangeEnd = 1003595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600150F RID: 5391 RVA: 0x00068EE0 File Offset: 0x000670E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003595, XrefRangeEnd = 1003600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700066B RID: 1643
			// (get) Token: 0x06001510 RID: 5392 RVA: 0x00068F14 File Offset: 0x00067114
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x06001511 RID: 5393 RVA: 0x00068F50 File Offset: 0x00067150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700066C RID: 1644
			// (get) Token: 0x06001512 RID: 5394 RVA: 0x00068F84 File Offset: 0x00067184
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001513 RID: 5395 RVA: 0x00068FC4 File Offset: 0x000671C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003600, XrefRangeEnd = 1003607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x06001514 RID: 5396 RVA: 0x00069004 File Offset: 0x00067204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003607, XrefRangeEnd = 1003614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001515 RID: 5397 RVA: 0x00008EF5 File Offset: 0x000070F5
			public _CastIterator_d__99(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000665 RID: 1637
			// (get) Token: 0x06001516 RID: 5398 RVA: 0x00069044 File Offset: 0x00067244
			// (set) Token: 0x06001517 RID: 5399 RVA: 0x00008EFE File Offset: 0x000070FE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000666 RID: 1638
			// (get) Token: 0x06001518 RID: 5400 RVA: 0x0006906C File Offset: 0x0006726C
			// (set) Token: 0x06001519 RID: 5401 RVA: 0x00069094 File Offset: 0x00067294
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x17000667 RID: 1639
			// (get) Token: 0x0600151A RID: 5402 RVA: 0x0006913C File Offset: 0x0006733C
			// (set) Token: 0x0600151B RID: 5403 RVA: 0x00008F19 File Offset: 0x00007119
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000668 RID: 1640
			// (get) Token: 0x0600151C RID: 5404 RVA: 0x00069164 File Offset: 0x00067364
			// (set) Token: 0x0600151D RID: 5405 RVA: 0x00008F34 File Offset: 0x00007134
			public unsafe IEnumerable source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000669 RID: 1641
			// (get) Token: 0x0600151E RID: 5406 RVA: 0x00069194 File Offset: 0x00067394
			// (set) Token: 0x0600151F RID: 5407 RVA: 0x00008F53 File Offset: 0x00007153
			public unsafe IEnumerable __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700066A RID: 1642
			// (get) Token: 0x06001520 RID: 5408 RVA: 0x000691C4 File Offset: 0x000673C4
			// (set) Token: 0x06001521 RID: 5409 RVA: 0x00008F72 File Offset: 0x00007172
			public unsafe IEnumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EE4 RID: 3812
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000EE5 RID: 3813
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000EE6 RID: 3814
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000EE7 RID: 3815
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000EE8 RID: 3816
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x04000EE9 RID: 3817
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000EEA RID: 3818
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000EEB RID: 3819
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EEC RID: 3820
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000EED RID: 3821
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000EEE RID: 3822
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000EEF RID: 3823
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EF0 RID: 3824
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000EF1 RID: 3825
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x04000EF2 RID: 3826
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000153 RID: 339
		[ObfuscatedName("System.Linq.Enumerable+<RangeIterator>d__115")]
		public sealed class _RangeIterator_d__115 : Object
		{
			// Token: 0x06001522 RID: 5410 RVA: 0x000691F4 File Offset: 0x000673F4
			// Note: this type is marked as 'beforefieldinit'.
			static _RangeIterator_d__115()
			{
				Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<RangeIterator>d__115");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr);
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "<>1__state");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "<>2__current");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "start");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___3__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "<>3__start");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "count");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___3__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "<>3__count");
				Enumerable._RangeIterator_d__115.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, "<i>5__2");
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663704);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663705);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663706);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663707);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663708);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663709);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663710);
				Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr, 100663711);
			}

			// Token: 0x06001523 RID: 5411 RVA: 0x00069360 File Offset: 0x00067560
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 286249, RefRangeEnd = 286258, XrefRangeStart = 286249, XrefRangeEnd = 286258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RangeIterator_d__115(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._RangeIterator_d__115>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001524 RID: 5412 RVA: 0x000693A8 File Offset: 0x000675A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001525 RID: 5413 RVA: 0x000693DC File Offset: 0x000675DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003614, XrefRangeEnd = 1003615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000675 RID: 1653
			// (get) Token: 0x06001526 RID: 5414 RVA: 0x00069418 File Offset: 0x00067618
			public unsafe int System.Collections.Generic.IEnumerator<System.Int32>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001527 RID: 5415 RVA: 0x00069454 File Offset: 0x00067654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003615, XrefRangeEnd = 1003620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000676 RID: 1654
			// (get) Token: 0x06001528 RID: 5416 RVA: 0x00069488 File Offset: 0x00067688
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003620, XrefRangeEnd = 1003623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001529 RID: 5417 RVA: 0x000694C8 File Offset: 0x000676C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003623, XrefRangeEnd = 1003630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<int> System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<int>>(intPtr3) : null;
			}

			// Token: 0x0600152A RID: 5418 RVA: 0x00069508 File Offset: 0x00067708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RangeIterator_d__115.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600152B RID: 5419 RVA: 0x00008F91 File Offset: 0x00007191
			public _RangeIterator_d__115(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700066D RID: 1645
			// (get) Token: 0x0600152C RID: 5420 RVA: 0x00069548 File Offset: 0x00067748
			// (set) Token: 0x0600152D RID: 5421 RVA: 0x00008F9A File Offset: 0x0000719A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700066E RID: 1646
			// (get) Token: 0x0600152E RID: 5422 RVA: 0x00069570 File Offset: 0x00067770
			// (set) Token: 0x0600152F RID: 5423 RVA: 0x00008FB5 File Offset: 0x000071B5
			public unsafe int __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x1700066F RID: 1647
			// (get) Token: 0x06001530 RID: 5424 RVA: 0x00069598 File Offset: 0x00067798
			// (set) Token: 0x06001531 RID: 5425 RVA: 0x00008FD0 File Offset: 0x000071D0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000670 RID: 1648
			// (get) Token: 0x06001532 RID: 5426 RVA: 0x000695C0 File Offset: 0x000677C0
			// (set) Token: 0x06001533 RID: 5427 RVA: 0x00008FEB File Offset: 0x000071EB
			public unsafe int start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x17000671 RID: 1649
			// (get) Token: 0x06001534 RID: 5428 RVA: 0x000695E8 File Offset: 0x000677E8
			// (set) Token: 0x06001535 RID: 5429 RVA: 0x00009006 File Offset: 0x00007206
			public unsafe int __3__start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___3__start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___3__start)) = value;
				}
			}

			// Token: 0x17000672 RID: 1650
			// (get) Token: 0x06001536 RID: 5430 RVA: 0x00069610 File Offset: 0x00067810
			// (set) Token: 0x06001537 RID: 5431 RVA: 0x00009021 File Offset: 0x00007221
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17000673 RID: 1651
			// (get) Token: 0x06001538 RID: 5432 RVA: 0x00069638 File Offset: 0x00067838
			// (set) Token: 0x06001539 RID: 5433 RVA: 0x0000903C File Offset: 0x0000723C
			public unsafe int __3__count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___3__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr___3__count)) = value;
				}
			}

			// Token: 0x17000674 RID: 1652
			// (get) Token: 0x0600153A RID: 5434 RVA: 0x00069660 File Offset: 0x00067860
			// (set) Token: 0x0600153B RID: 5435 RVA: 0x00009057 File Offset: 0x00007257
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RangeIterator_d__115.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04000EF3 RID: 3827
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000EF4 RID: 3828
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000EF5 RID: 3829
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000EF6 RID: 3830
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04000EF7 RID: 3831
			private static readonly IntPtr NativeFieldInfoPtr___3__start;

			// Token: 0x04000EF8 RID: 3832
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000EF9 RID: 3833
			private static readonly IntPtr NativeFieldInfoPtr___3__count;

			// Token: 0x04000EFA RID: 3834
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04000EFB RID: 3835
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000EFC RID: 3836
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EFD RID: 3837
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000EFE RID: 3838
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Int32__get_Current_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000EFF RID: 3839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F00 RID: 3840
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F01 RID: 3841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Int32__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Int32_0;

			// Token: 0x04000F02 RID: 3842
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000154 RID: 340
		[ObfuscatedName("System.Linq.Enumerable+<RepeatIterator>d__117`1")]
		public sealed class _RepeatIterator_d__117<TResult> : Object
		{
			// Token: 0x0600153C RID: 5436 RVA: 0x00069688 File Offset: 0x00067888
			// Note: this type is marked as 'beforefieldinit'.
			static _RepeatIterator_d__117()
			{
				Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<RepeatIterator>d__117`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr);
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "<>1__state");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "<>2__current");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "element");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___3__element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "<>3__element");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "count");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___3__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "<>3__count");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "<i>5__2");
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663712);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663713);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663714);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663715);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663716);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663717);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663718);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663719);
			}

			// Token: 0x0600153D RID: 5437 RVA: 0x00069830 File Offset: 0x00067A30
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RepeatIterator_d__117(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600153E RID: 5438 RVA: 0x00069878 File Offset: 0x00067A78
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600153F RID: 5439 RVA: 0x000698AC File Offset: 0x00067AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003630, XrefRangeEnd = 1003632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700067F RID: 1663
			// (get) Token: 0x06001540 RID: 5440 RVA: 0x000698E8 File Offset: 0x00067AE8
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x06001541 RID: 5441 RVA: 0x00069924 File Offset: 0x00067B24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000680 RID: 1664
			// (get) Token: 0x06001542 RID: 5442 RVA: 0x00069958 File Offset: 0x00067B58
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001543 RID: 5443 RVA: 0x00069998 File Offset: 0x00067B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x06001544 RID: 5444 RVA: 0x000699D8 File Offset: 0x00067BD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003632, XrefRangeEnd = 1003639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001545 RID: 5445 RVA: 0x00009072 File Offset: 0x00007272
			public _RepeatIterator_d__117(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000677 RID: 1655
			// (get) Token: 0x06001546 RID: 5446 RVA: 0x00069A18 File Offset: 0x00067C18
			// (set) Token: 0x06001547 RID: 5447 RVA: 0x0000907B File Offset: 0x0000727B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000678 RID: 1656
			// (get) Token: 0x06001548 RID: 5448 RVA: 0x00069A40 File Offset: 0x00067C40
			// (set) Token: 0x06001549 RID: 5449 RVA: 0x00069A68 File Offset: 0x00067C68
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x17000679 RID: 1657
			// (get) Token: 0x0600154A RID: 5450 RVA: 0x00069B10 File Offset: 0x00067D10
			// (set) Token: 0x0600154B RID: 5451 RVA: 0x00009096 File Offset: 0x00007296
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700067A RID: 1658
			// (get) Token: 0x0600154C RID: 5452 RVA: 0x00069B38 File Offset: 0x00067D38
			// (set) Token: 0x0600154D RID: 5453 RVA: 0x00069B60 File Offset: 0x00067D60
			public unsafe TResult element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr_element);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr_element);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x1700067B RID: 1659
			// (get) Token: 0x0600154E RID: 5454 RVA: 0x00069C08 File Offset: 0x00067E08
			// (set) Token: 0x0600154F RID: 5455 RVA: 0x00069C30 File Offset: 0x00067E30
			public unsafe TResult __3__element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___3__element);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___3__element);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x1700067C RID: 1660
			// (get) Token: 0x06001550 RID: 5456 RVA: 0x00069CD8 File Offset: 0x00067ED8
			// (set) Token: 0x06001551 RID: 5457 RVA: 0x000090B1 File Offset: 0x000072B1
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x1700067D RID: 1661
			// (get) Token: 0x06001552 RID: 5458 RVA: 0x00069D00 File Offset: 0x00067F00
			// (set) Token: 0x06001553 RID: 5459 RVA: 0x000090CC File Offset: 0x000072CC
			public unsafe int __3__count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___3__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___3__count)) = value;
				}
			}

			// Token: 0x1700067E RID: 1662
			// (get) Token: 0x06001554 RID: 5460 RVA: 0x00069D28 File Offset: 0x00067F28
			// (set) Token: 0x06001555 RID: 5461 RVA: 0x000090E7 File Offset: 0x000072E7
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04000F03 RID: 3843
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F04 RID: 3844
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F05 RID: 3845
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000F06 RID: 3846
			private static readonly IntPtr NativeFieldInfoPtr_element;

			// Token: 0x04000F07 RID: 3847
			private static readonly IntPtr NativeFieldInfoPtr___3__element;

			// Token: 0x04000F08 RID: 3848
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000F09 RID: 3849
			private static readonly IntPtr NativeFieldInfoPtr___3__count;

			// Token: 0x04000F0A RID: 3850
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04000F0B RID: 3851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F0C RID: 3852
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F0D RID: 3853
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F0E RID: 3854
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000F0F RID: 3855
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F10 RID: 3856
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F11 RID: 3857
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x04000F12 RID: 3858
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000155 RID: 341
		private sealed class MethodInfoStoreGeneric_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F13 RID: 3859
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000156 RID: 342
		private sealed class MethodInfoStoreGeneric_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_3_TSource_Int32_Boolean_0<TSource>
		{
			// Token: 0x04000F14 RID: 3860
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_3_TSource_Int32_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000157 RID: 343
		private sealed class MethodInfoStoreGeneric_WhereIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_3_TSource_Int32_Boolean_0<TSource>
		{
			// Token: 0x04000F15 RID: 3861
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_WhereIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_3_TSource_Int32_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000158 RID: 344
		private sealed class MethodInfoStoreGeneric_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0<TSource, TResult>
		{
			// Token: 0x04000F16 RID: 3862
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000159 RID: 345
		private sealed class MethodInfoStoreGeneric_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0<TSource, TResult>
		{
			// Token: 0x04000F17 RID: 3863
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200015A RID: 346
		private sealed class MethodInfoStoreGeneric_SelectIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0<TSource, TResult>
		{
			// Token: 0x04000F18 RID: 3864
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SelectIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200015B RID: 347
		private sealed class MethodInfoStoreGeneric_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F19 RID: 3865
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200015C RID: 348
		private sealed class MethodInfoStoreGeneric_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0<TSource, TMiddle, TResult>
		{
			// Token: 0x04000F1A RID: 3866
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMiddle>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200015D RID: 349
		private sealed class MethodInfoStoreGeneric_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0<TSource, TResult>
		{
			// Token: 0x04000F1B RID: 3867
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200015E RID: 350
		private sealed class MethodInfoStoreGeneric_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0<TSource, TResult>
		{
			// Token: 0x04000F1C RID: 3868
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200015F RID: 351
		private sealed class MethodInfoStoreGeneric_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TCollection_Func_3_TSource_TCollection_TResult_0<TSource, TCollection, TResult>
		{
			// Token: 0x04000F1D RID: 3869
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SelectMany_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TCollection_Func_3_TSource_TCollection_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000160 RID: 352
		private sealed class MethodInfoStoreGeneric_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TCollection_Func_3_TSource_TCollection_TResult_0<TSource, TCollection, TResult>
		{
			// Token: 0x04000F1E RID: 3870
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SelectManyIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_IEnumerable_1_TCollection_Func_3_TSource_TCollection_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000161 RID: 353
		private sealed class MethodInfoStoreGeneric_Take_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0<TSource>
		{
			// Token: 0x04000F1F RID: 3871
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Take_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000162 RID: 354
		private sealed class MethodInfoStoreGeneric_TakeIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0<TSource>
		{
			// Token: 0x04000F20 RID: 3872
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_TakeIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000163 RID: 355
		private sealed class MethodInfoStoreGeneric_TakeWhile_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F21 RID: 3873
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_TakeWhile_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000164 RID: 356
		private sealed class MethodInfoStoreGeneric_TakeWhileIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F22 RID: 3874
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_TakeWhileIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000165 RID: 357
		private sealed class MethodInfoStoreGeneric_Skip_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0<TSource>
		{
			// Token: 0x04000F23 RID: 3875
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Skip_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000166 RID: 358
		private sealed class MethodInfoStoreGeneric_SkipIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0<TSource>
		{
			// Token: 0x04000F24 RID: 3876
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SkipIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000167 RID: 359
		private sealed class MethodInfoStoreGeneric_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x04000F25 RID: 3877
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000168 RID: 360
		private sealed class MethodInfoStoreGeneric_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IComparer_1_TKey_0<TSource, TKey>
		{
			// Token: 0x04000F26 RID: 3878
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IComparer_1_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000169 RID: 361
		private sealed class MethodInfoStoreGeneric_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x04000F27 RID: 3879
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200016A RID: 362
		private sealed class MethodInfoStoreGeneric_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IComparer_1_TKey_0<TSource, TKey>
		{
			// Token: 0x04000F28 RID: 3880
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_OrderByDescending_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_IComparer_1_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200016B RID: 363
		private sealed class MethodInfoStoreGeneric_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x04000F29 RID: 3881
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200016C RID: 364
		private sealed class MethodInfoStoreGeneric_ThenByDescending_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x04000F2A RID: 3882
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ThenByDescending_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200016D RID: 365
		private sealed class MethodInfoStoreGeneric_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x04000F2B RID: 3883
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_GroupBy_Public_Static_IEnumerable_1_IGrouping_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200016E RID: 366
		private sealed class MethodInfoStoreGeneric_Concat_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F2C RID: 3884
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Concat_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200016F RID: 367
		private sealed class MethodInfoStoreGeneric_ConcatIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F2D RID: 3885
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ConcatIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000170 RID: 368
		private sealed class MethodInfoStoreGeneric_Append_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0<TSource>
		{
			// Token: 0x04000F2E RID: 3886
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Append_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000171 RID: 369
		private sealed class MethodInfoStoreGeneric_AppendIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0<TSource>
		{
			// Token: 0x04000F2F RID: 3887
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_AppendIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000172 RID: 370
		private sealed class MethodInfoStoreGeneric_Prepend_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0<TSource>
		{
			// Token: 0x04000F30 RID: 3888
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Prepend_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000173 RID: 371
		private sealed class MethodInfoStoreGeneric_PrependIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0<TSource>
		{
			// Token: 0x04000F31 RID: 3889
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_PrependIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000174 RID: 372
		private sealed class MethodInfoStoreGeneric_Zip_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TFirst_IEnumerable_1_TSecond_Func_3_TFirst_TSecond_TResult_0<TFirst, TSecond, TResult>
		{
			// Token: 0x04000F32 RID: 3890
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Zip_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TFirst_IEnumerable_1_TSecond_Func_3_TFirst_TSecond_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFirst>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSecond>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000175 RID: 373
		private sealed class MethodInfoStoreGeneric_ZipIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TFirst_IEnumerable_1_TSecond_Func_3_TFirst_TSecond_TResult_0<TFirst, TSecond, TResult>
		{
			// Token: 0x04000F33 RID: 3891
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ZipIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TFirst_IEnumerable_1_TSecond_Func_3_TFirst_TSecond_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFirst>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSecond>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000176 RID: 374
		private sealed class MethodInfoStoreGeneric_Distinct_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F34 RID: 3892
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Distinct_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000177 RID: 375
		private sealed class MethodInfoStoreGeneric_DistinctIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>
		{
			// Token: 0x04000F35 RID: 3893
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_DistinctIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000178 RID: 376
		private sealed class MethodInfoStoreGeneric_Union_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F36 RID: 3894
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Union_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000179 RID: 377
		private sealed class MethodInfoStoreGeneric_UnionIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>
		{
			// Token: 0x04000F37 RID: 3895
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_UnionIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017A RID: 378
		private sealed class MethodInfoStoreGeneric_Intersect_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F38 RID: 3896
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Intersect_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017B RID: 379
		private sealed class MethodInfoStoreGeneric_IntersectIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>
		{
			// Token: 0x04000F39 RID: 3897
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_IntersectIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017C RID: 380
		private sealed class MethodInfoStoreGeneric_Except_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F3A RID: 3898
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Except_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017D RID: 381
		private sealed class MethodInfoStoreGeneric_ExceptIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>
		{
			// Token: 0x04000F3B RID: 3899
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ExceptIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017E RID: 382
		private sealed class MethodInfoStoreGeneric_Reverse_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F3C RID: 3900
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Reverse_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017F RID: 383
		private sealed class MethodInfoStoreGeneric_ReverseIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F3D RID: 3901
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ReverseIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000180 RID: 384
		private sealed class MethodInfoStoreGeneric_SequenceEqual_Public_Static_Boolean_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F3E RID: 3902
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000181 RID: 385
		private sealed class MethodInfoStoreGeneric_SequenceEqual_Public_Static_Boolean_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>
		{
			// Token: 0x04000F3F RID: 3903
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SequenceEqual_Public_Static_Boolean_IEnumerable_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000182 RID: 386
		private sealed class MethodInfoStoreGeneric_AsEnumerable_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F40 RID: 3904
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_AsEnumerable_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000183 RID: 387
		private sealed class MethodInfoStoreGeneric_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F41 RID: 3905
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000184 RID: 388
		private sealed class MethodInfoStoreGeneric_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F42 RID: 3906
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000185 RID: 389
		private sealed class MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x04000F43 RID: 3907
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000186 RID: 390
		private sealed class MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_0<TSource, TKey, TElement>
		{
			// Token: 0x04000F44 RID: 3908
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000187 RID: 391
		private sealed class MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0<TSource, TKey, TElement>
		{
			// Token: 0x04000F45 RID: 3909
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000188 RID: 392
		private sealed class MethodInfoStoreGeneric_OfType_Public_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>
		{
			// Token: 0x04000F46 RID: 3910
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_OfType_Public_Static_IEnumerable_1_TResult_IEnumerable_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000189 RID: 393
		private sealed class MethodInfoStoreGeneric_OfTypeIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>
		{
			// Token: 0x04000F47 RID: 3911
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_OfTypeIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200018A RID: 394
		private sealed class MethodInfoStoreGeneric_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>
		{
			// Token: 0x04000F48 RID: 3912
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200018B RID: 395
		private sealed class MethodInfoStoreGeneric_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>
		{
			// Token: 0x04000F49 RID: 3913
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200018C RID: 396
		private sealed class MethodInfoStoreGeneric_First_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F4A RID: 3914
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_First_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200018D RID: 397
		private sealed class MethodInfoStoreGeneric_First_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F4B RID: 3915
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_First_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200018E RID: 398
		private sealed class MethodInfoStoreGeneric_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F4C RID: 3916
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200018F RID: 399
		private sealed class MethodInfoStoreGeneric_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F4D RID: 3917
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000190 RID: 400
		private sealed class MethodInfoStoreGeneric_Last_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F4E RID: 3918
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Last_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000191 RID: 401
		private sealed class MethodInfoStoreGeneric_Last_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F4F RID: 3919
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Last_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000192 RID: 402
		private sealed class MethodInfoStoreGeneric_LastOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F50 RID: 3920
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_LastOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000193 RID: 403
		private sealed class MethodInfoStoreGeneric_LastOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F51 RID: 3921
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_LastOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000194 RID: 404
		private sealed class MethodInfoStoreGeneric_Single_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F52 RID: 3922
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Single_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000195 RID: 405
		private sealed class MethodInfoStoreGeneric_Single_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F53 RID: 3923
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Single_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000196 RID: 406
		private sealed class MethodInfoStoreGeneric_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F54 RID: 3924
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000197 RID: 407
		private sealed class MethodInfoStoreGeneric_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F55 RID: 3925
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000198 RID: 408
		private sealed class MethodInfoStoreGeneric_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0<TSource>
		{
			// Token: 0x04000F56 RID: 3926
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000199 RID: 409
		private sealed class MethodInfoStoreGeneric_ElementAtOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Int32_0<TSource>
		{
			// Token: 0x04000F57 RID: 3927
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ElementAtOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200019A RID: 410
		private sealed class MethodInfoStoreGeneric_Repeat_Public_Static_IEnumerable_1_TResult_TResult_Int32_0<TResult>
		{
			// Token: 0x04000F58 RID: 3928
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Repeat_Public_Static_IEnumerable_1_TResult_TResult_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200019B RID: 411
		private sealed class MethodInfoStoreGeneric_RepeatIterator_Private_Static_IEnumerable_1_TResult_TResult_Int32_0<TResult>
		{
			// Token: 0x04000F59 RID: 3929
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_RepeatIterator_Private_Static_IEnumerable_1_TResult_TResult_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200019C RID: 412
		private sealed class MethodInfoStoreGeneric_Empty_Public_Static_IEnumerable_1_TResult_0<TResult>
		{
			// Token: 0x04000F5A RID: 3930
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Empty_Public_Static_IEnumerable_1_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200019D RID: 413
		private sealed class MethodInfoStoreGeneric_Any_Public_Static_Boolean_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F5B RID: 3931
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200019E RID: 414
		private sealed class MethodInfoStoreGeneric_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F5C RID: 3932
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200019F RID: 415
		private sealed class MethodInfoStoreGeneric_All_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F5D RID: 3933
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_All_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001A0 RID: 416
		private sealed class MethodInfoStoreGeneric_Count_Public_Static_Int32_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F5E RID: 3934
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Count_Public_Static_Int32_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001A1 RID: 417
		private sealed class MethodInfoStoreGeneric_Count_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000F5F RID: 3935
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Count_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001A2 RID: 418
		private sealed class MethodInfoStoreGeneric_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0<TSource>
		{
			// Token: 0x04000F60 RID: 3936
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001A3 RID: 419
		private sealed class MethodInfoStoreGeneric_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0<TSource>
		{
			// Token: 0x04000F61 RID: 3937
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001A4 RID: 420
		private sealed class MethodInfoStoreGeneric_Aggregate_Public_Static_TSource_IEnumerable_1_TSource_Func_3_TSource_TSource_TSource_0<TSource>
		{
			// Token: 0x04000F62 RID: 3938
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Aggregate_Public_Static_TSource_IEnumerable_1_TSource_Func_3_TSource_TSource_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001A5 RID: 421
		private sealed class MethodInfoStoreGeneric_Aggregate_Public_Static_TAccumulate_IEnumerable_1_TSource_TAccumulate_Func_3_TAccumulate_TSource_TAccumulate_0<TSource, TAccumulate>
		{
			// Token: 0x04000F63 RID: 3939
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Aggregate_Public_Static_TAccumulate_IEnumerable_1_TSource_TAccumulate_Func_3_TAccumulate_TSource_TAccumulate_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAccumulate>.NativeClassPtr))
			}))));
		}

		// Token: 0x020001A6 RID: 422
		private sealed class MethodInfoStoreGeneric_Sum_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0<TSource>
		{
			// Token: 0x04000F64 RID: 3940
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Sum_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001A7 RID: 423
		private sealed class MethodInfoStoreGeneric_Sum_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0<TSource>
		{
			// Token: 0x04000F65 RID: 3941
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Sum_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001A8 RID: 424
		private sealed class MethodInfoStoreGeneric_Min_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F66 RID: 3942
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Min_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001A9 RID: 425
		private sealed class MethodInfoStoreGeneric_Min_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0<TSource>
		{
			// Token: 0x04000F67 RID: 3943
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Min_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AA RID: 426
		private sealed class MethodInfoStoreGeneric_Min_Public_Static_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0<TSource, TResult>
		{
			// Token: 0x04000F68 RID: 3944
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Min_Public_Static_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x020001AB RID: 427
		private sealed class MethodInfoStoreGeneric_Max_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F69 RID: 3945
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Max_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AC RID: 428
		private sealed class MethodInfoStoreGeneric_Max_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0<TSource>
		{
			// Token: 0x04000F6A RID: 3946
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Max_Public_Static_Int32_IEnumerable_1_TSource_Func_2_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AD RID: 429
		private sealed class MethodInfoStoreGeneric_Max_Public_Static_Int64_IEnumerable_1_TSource_Func_2_TSource_Int64_0<TSource>
		{
			// Token: 0x04000F6B RID: 3947
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Max_Public_Static_Int64_IEnumerable_1_TSource_Func_2_TSource_Int64_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AE RID: 430
		private sealed class MethodInfoStoreGeneric_Max_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0<TSource>
		{
			// Token: 0x04000F6C RID: 3948
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Max_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AF RID: 431
		private sealed class MethodInfoStoreGeneric_Max_Public_Static_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0<TSource, TResult>
		{
			// Token: 0x04000F6D RID: 3949
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Max_Public_Static_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x020001B0 RID: 432
		private sealed class MethodInfoStoreGeneric_Average_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Int32_0<TSource>
		{
			// Token: 0x04000F6E RID: 3950
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Average_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001B1 RID: 433
		private sealed class MethodInfoStoreGeneric_Average_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0<TSource>
		{
			// Token: 0x04000F6F RID: 3951
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Average_Public_Static_Double_IEnumerable_1_TSource_Func_2_TSource_Double_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001B2 RID: 434
		private sealed class MethodInfoStoreGeneric_ToHashSet_Public_Static_HashSet_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000F70 RID: 3952
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToHashSet_Public_Static_HashSet_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x020001B3 RID: 435
		private sealed class MethodInfoStoreGeneric_ToHashSet_Public_Static_HashSet_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0<TSource>
		{
			// Token: 0x04000F71 RID: 3953
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToHashSet_Public_Static_HashSet_1_TSource_IEnumerable_1_TSource_IEqualityComparer_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}
	}
}
