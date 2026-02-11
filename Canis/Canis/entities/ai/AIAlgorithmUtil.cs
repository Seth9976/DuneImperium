using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.entities.ai
{
	// Token: 0x020000F8 RID: 248
	public static class AIAlgorithmUtil : Object
	{
		// Token: 0x06000AEA RID: 2794 RVA: 0x00047FF0 File Offset: 0x000461F0
		// Note: this type is marked as 'beforefieldinit'.
		static AIAlgorithmUtil()
		{
			Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIAlgorithmUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr);
			AIAlgorithmUtil.NativeMethodInfoPtr_BestRankTimeout_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_TComparable_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr, 100665670);
			AIAlgorithmUtil.NativeMethodInfoPtr_BestRankTimeout_Public_Static_Nullable_1_TSource_IEnumerable_1_TSource_Func_2_Nullable_1_TSource_TComparable_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr, 100665671);
			AIAlgorithmUtil.NativeMethodInfoPtr_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_Int32_Func_2_T_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr, 100665672);
			AIAlgorithmUtil.NativeMethodInfoPtr_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_ValueTuple_3_T_Int32_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr, 100665673);
			AIAlgorithmUtil.NativeMethodInfoPtr_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_KnapsackItem_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr, 100665674);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00048084 File Offset: 0x00046284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568059, XrefRangeEnd = 568100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource BestRankTimeout<TSource, TComparable>(this IEnumerable<TSource> elems, Func<TSource, TComparable> ranker, long timeout = 1000L) where TSource : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elems);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ranker);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil.MethodInfoStoreGeneric_BestRankTimeout_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_TComparable_Int64_0<TSource, TComparable>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x000480E4 File Offset: 0x000462E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568100, XrefRangeEnd = 568163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<TSource> BestRankTimeout<TSource, TComparable>(this IEnumerable<TSource> elems, Func<Nullable<TSource>, TComparable> ranker, long timeout = 1000L) where TSource : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elems);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ranker);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil.MethodInfoStoreGeneric_BestRankTimeout_Public_Static_Nullable_1_TSource_IEnumerable_1_TSource_Func_2_Nullable_1_TSource_TComparable_Int64_0<TSource, TComparable>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<TSource>(intPtr);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00048140 File Offset: 0x00046340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568163, XrefRangeEnd = 568183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> KnapsackSolver<T>(this IEnumerable<T> elems, Func<T, int> weightFunc, Func<T, Decimal> valueFunc, int maxWeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elems);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(weightFunc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFunc);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil.MethodInfoStoreGeneric_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_Int32_Func_2_T_Decimal_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000481B8 File Offset: 0x000463B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568183, XrefRangeEnd = 568188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> KnapsackSolver<T>(this IEnumerable<ValueTuple<T, int, Decimal>> elems, int maxWeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elems);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil.MethodInfoStoreGeneric_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_ValueTuple_3_T_Int32_Decimal_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0004820C File Offset: 0x0004640C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 568207, RefRangeEnd = 568208, XrefRangeStart = 568188, XrefRangeEnd = 568207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> KnapsackSolver<T>(this IEnumerable<AIAlgorithmUtil.KnapsackItem<T>> elems, int maxWeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elems);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil.MethodInfoStoreGeneric_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_KnapsackItem_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00005FAB File Offset: 0x000041AB
		public AIAlgorithmUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_BestRankTimeout_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_TComparable_Int64_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_BestRankTimeout_Public_Static_Nullable_1_TSource_IEnumerable_1_TSource_Func_2_Nullable_1_TSource_TComparable_Int64_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_Int32_Func_2_T_Decimal_Int32_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_ValueTuple_3_T_Int32_Decimal_Int32_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_KnapsackItem_1_T_Int32_0;

		// Token: 0x0200033B RID: 827
		public sealed class KnapsackItem<T> : ValueType
		{
			// Token: 0x060022A8 RID: 8872 RVA: 0x0009BBAC File Offset: 0x00099DAC
			// Note: this type is marked as 'beforefieldinit'.
			static KnapsackItem()
			{
				Il2CppClassPointerStore<AIAlgorithmUtil.KnapsackItem<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr, "KnapsackItem`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIAlgorithmUtil.KnapsackItem<T>>.NativeClassPtr);
				AIAlgorithmUtil.KnapsackItem<T>.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil.KnapsackItem<T>>.NativeClassPtr, "Item");
				AIAlgorithmUtil.KnapsackItem<T>.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil.KnapsackItem<T>>.NativeClassPtr, "Weight");
				AIAlgorithmUtil.KnapsackItem<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil.KnapsackItem<T>>.NativeClassPtr, "Value");
				AIAlgorithmUtil.KnapsackItem<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Int32_IConvertible_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil.KnapsackItem<T>>.NativeClassPtr, 100665675);
				AIAlgorithmUtil.KnapsackItem<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil.KnapsackItem<T>>.NativeClassPtr, 100665676);
			}

			// Token: 0x060022A9 RID: 8873 RVA: 0x0009BC78 File Offset: 0x00099E78
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 310353, RefRangeEnd = 310356, XrefRangeStart = 310353, XrefRangeEnd = 310356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KnapsackItem(T item, int weight, IConvertible value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIAlgorithmUtil.KnapsackItem<T>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
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
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil.KnapsackItem<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Int32_IConvertible_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x060022AA RID: 8874 RVA: 0x0009BD20 File Offset: 0x00099F20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567985, XrefRangeEnd = 567991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil.KnapsackItem<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060022AB RID: 8875 RVA: 0x00010A8C File Offset: 0x0000EC8C
			public KnapsackItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060022AC RID: 8876 RVA: 0x00010A95 File Offset: 0x0000EC95
			public KnapsackItem()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIAlgorithmUtil.KnapsackItem<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17000870 RID: 2160
			// (get) Token: 0x060022AD RID: 8877 RVA: 0x0009BD5C File Offset: 0x00099F5C
			// (set) Token: 0x060022AE RID: 8878 RVA: 0x0009BD84 File Offset: 0x00099F84
			public unsafe T Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil.KnapsackItem<T>.NativeFieldInfoPtr_Item);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil.KnapsackItem<T>.NativeFieldInfoPtr_Item);
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

			// Token: 0x17000871 RID: 2161
			// (get) Token: 0x060022AF RID: 8879 RVA: 0x0009BE2C File Offset: 0x0009A02C
			// (set) Token: 0x060022B0 RID: 8880 RVA: 0x00010AA7 File Offset: 0x0000ECA7
			public unsafe int Weight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil.KnapsackItem<T>.NativeFieldInfoPtr_Weight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil.KnapsackItem<T>.NativeFieldInfoPtr_Weight)) = value;
				}
			}

			// Token: 0x17000872 RID: 2162
			// (get) Token: 0x060022B1 RID: 8881 RVA: 0x0009BE54 File Offset: 0x0009A054
			// (set) Token: 0x060022B2 RID: 8882 RVA: 0x00010AC2 File Offset: 0x0000ECC2
			public unsafe IConvertible Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil.KnapsackItem<T>.NativeFieldInfoPtr_Value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConvertible>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil.KnapsackItem<T>.NativeFieldInfoPtr_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015CA RID: 5578
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x040015CB RID: 5579
			private static readonly IntPtr NativeFieldInfoPtr_Weight;

			// Token: 0x040015CC RID: 5580
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x040015CD RID: 5581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_Int32_IConvertible_0;

			// Token: 0x040015CE RID: 5582
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x0200033C RID: 828
		[ObfuscatedName("Canis.entities.ai.AIAlgorithmUtil+<>c__5`1")]
		[Serializable]
		public sealed class __c__5<T> : Object
		{
			// Token: 0x060022B3 RID: 8883 RVA: 0x0009BE84 File Offset: 0x0009A084
			// Note: this type is marked as 'beforefieldinit'.
			static __c__5()
			{
				Il2CppClassPointerStore<AIAlgorithmUtil.__c__5<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr, "<>c__5`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIAlgorithmUtil.__c__5<T>>.NativeClassPtr);
				AIAlgorithmUtil.__c__5<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil.__c__5<T>>.NativeClassPtr, "<>9");
				AIAlgorithmUtil.__c__5<T>.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil.__c__5<T>>.NativeClassPtr, "<>9__5_0");
				AIAlgorithmUtil.__c__5<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil.__c__5<T>>.NativeClassPtr, 100665678);
				AIAlgorithmUtil.__c__5<T>.NativeMethodInfoPtr__KnapsackSolver_b__5_0_Internal_ValueTuple_3_T_Int32_Decimal_KnapsackItem_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil.__c__5<T>>.NativeClassPtr, 100665679);
			}

			// Token: 0x060022B4 RID: 8884 RVA: 0x0009BF3C File Offset: 0x0009A13C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__5()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIAlgorithmUtil.__c__5<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil.__c__5<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022B5 RID: 8885 RVA: 0x0009BF78 File Offset: 0x0009A178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567991, XrefRangeEnd = 567996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<T, int, Decimal> _KnapsackSolver_b__5_0(AIAlgorithmUtil.KnapsackItem<T> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil.__c__5<T>.NativeMethodInfoPtr__KnapsackSolver_b__5_0_Internal_ValueTuple_3_T_Int32_Decimal_KnapsackItem_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<T, int, Decimal>(intPtr);
				}
			}

			// Token: 0x060022B6 RID: 8886 RVA: 0x00010AE1 File Offset: 0x0000ECE1
			public __c__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000873 RID: 2163
			// (get) Token: 0x060022B7 RID: 8887 RVA: 0x0009BFC8 File Offset: 0x0009A1C8
			// (set) Token: 0x060022B8 RID: 8888 RVA: 0x00010AEA File Offset: 0x0000ECEA
			public unsafe static AIAlgorithmUtil.__c__5<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIAlgorithmUtil.__c__5<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AIAlgorithmUtil.__c__5<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIAlgorithmUtil.__c__5<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000874 RID: 2164
			// (get) Token: 0x060022B9 RID: 8889 RVA: 0x0009BFF0 File Offset: 0x0009A1F0
			// (set) Token: 0x060022BA RID: 8890 RVA: 0x00010AFC File Offset: 0x0000ECFC
			public unsafe static Func<AIAlgorithmUtil.KnapsackItem<T>, ValueTuple<T, int, Decimal>> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIAlgorithmUtil.__c__5<T>.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIAlgorithmUtil.KnapsackItem<T>, ValueTuple<T, int, Decimal>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIAlgorithmUtil.__c__5<T>.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015CF RID: 5583
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015D0 RID: 5584
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040015D1 RID: 5585
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015D2 RID: 5586
			private static readonly IntPtr NativeMethodInfoPtr__KnapsackSolver_b__5_0_Internal_ValueTuple_3_T_Int32_Decimal_KnapsackItem_1_T_0;
		}

		// Token: 0x0200033D RID: 829
		[ObfuscatedName("Canis.entities.ai.AIAlgorithmUtil+<>c__DisplayClass2_0`1")]
		public sealed class __c__DisplayClass2_0<T> : Object
		{
			// Token: 0x060022BB RID: 8891 RVA: 0x0009C018 File Offset: 0x0009A218
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<AIAlgorithmUtil.__c__DisplayClass2_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr, "<>c__DisplayClass2_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIAlgorithmUtil.__c__DisplayClass2_0<T>>.NativeClassPtr);
				AIAlgorithmUtil.__c__DisplayClass2_0<T>.NativeFieldInfoPtr_weightFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil.__c__DisplayClass2_0<T>>.NativeClassPtr, "weightFunc");
				AIAlgorithmUtil.__c__DisplayClass2_0<T>.NativeFieldInfoPtr_valueFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil.__c__DisplayClass2_0<T>>.NativeClassPtr, "valueFunc");
				AIAlgorithmUtil.__c__DisplayClass2_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil.__c__DisplayClass2_0<T>>.NativeClassPtr, 100665680);
				AIAlgorithmUtil.__c__DisplayClass2_0<T>.NativeMethodInfoPtr__KnapsackSolver_b__0_Internal_ValueTuple_3_T_Int32_Decimal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil.__c__DisplayClass2_0<T>>.NativeClassPtr, 100665681);
			}

			// Token: 0x060022BC RID: 8892 RVA: 0x0009C0D0 File Offset: 0x0009A2D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIAlgorithmUtil.__c__DisplayClass2_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil.__c__DisplayClass2_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022BD RID: 8893 RVA: 0x0009C10C File Offset: 0x0009A30C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567996, XrefRangeEnd = 568009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<T, int, Decimal> _KnapsackSolver_b__0(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil.__c__DisplayClass2_0<T>.NativeMethodInfoPtr__KnapsackSolver_b__0_Internal_ValueTuple_3_T_Int32_Decimal_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return new ValueTuple<T, int, Decimal>(intPtr2);
				}
			}

			// Token: 0x060022BE RID: 8894 RVA: 0x00010B0E File Offset: 0x0000ED0E
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000875 RID: 2165
			// (get) Token: 0x060022BF RID: 8895 RVA: 0x0009C18C File Offset: 0x0009A38C
			// (set) Token: 0x060022C0 RID: 8896 RVA: 0x00010B17 File Offset: 0x0000ED17
			public unsafe Func<T, int> weightFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil.__c__DisplayClass2_0<T>.NativeFieldInfoPtr_weightFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil.__c__DisplayClass2_0<T>.NativeFieldInfoPtr_weightFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000876 RID: 2166
			// (get) Token: 0x060022C1 RID: 8897 RVA: 0x0009C1BC File Offset: 0x0009A3BC
			// (set) Token: 0x060022C2 RID: 8898 RVA: 0x00010B36 File Offset: 0x0000ED36
			public unsafe Func<T, Decimal> valueFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil.__c__DisplayClass2_0<T>.NativeFieldInfoPtr_valueFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, Decimal>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil.__c__DisplayClass2_0<T>.NativeFieldInfoPtr_valueFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015D3 RID: 5587
			private static readonly IntPtr NativeFieldInfoPtr_weightFunc;

			// Token: 0x040015D4 RID: 5588
			private static readonly IntPtr NativeFieldInfoPtr_valueFunc;

			// Token: 0x040015D5 RID: 5589
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015D6 RID: 5590
			private static readonly IntPtr NativeMethodInfoPtr__KnapsackSolver_b__0_Internal_ValueTuple_3_T_Int32_Decimal_T_0;
		}

		// Token: 0x0200033E RID: 830
		[ObfuscatedName("Canis.entities.ai.AIAlgorithmUtil+<KnapsackSolver>d__3`1")]
		public sealed class _KnapsackSolver_d__3<T> : Object
		{
			// Token: 0x060022C3 RID: 8899 RVA: 0x0009C1EC File Offset: 0x0009A3EC
			// Note: this type is marked as 'beforefieldinit'.
			static _KnapsackSolver_d__3()
			{
				Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr, "<KnapsackSolver>d__3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr);
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, "<>1__state");
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, "<>2__current");
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, "<>l__initialThreadId");
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr_elems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, "elems");
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___3__elems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, "<>3__elems");
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr_maxWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, "maxWeight");
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___3__maxWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, "<>3__maxWeight");
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__elemArr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, "<elemArr>5__2");
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__valueMatrix_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, "<valueMatrix>5__3");
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__currValue_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, "<currValue>5__4");
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__currWeight_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, "<currWeight>5__5");
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, "<i>5__6");
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, 100665682);
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, 100665683);
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, 100665684);
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, 100665685);
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, 100665686);
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, 100665687);
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, 100665688);
				AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr, 100665689);
			}

			// Token: 0x060022C4 RID: 8900 RVA: 0x0009C3E4 File Offset: 0x0009A5E4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _KnapsackSolver_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIAlgorithmUtil._KnapsackSolver_d__3<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022C5 RID: 8901 RVA: 0x0009C42C File Offset: 0x0009A62C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022C6 RID: 8902 RVA: 0x0009C460 File Offset: 0x0009A660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568009, XrefRangeEnd = 568045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000883 RID: 2179
			// (get) Token: 0x060022C7 RID: 8903 RVA: 0x0009C49C File Offset: 0x0009A69C
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060022C8 RID: 8904 RVA: 0x0009C4D8 File Offset: 0x0009A6D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000884 RID: 2180
			// (get) Token: 0x060022C9 RID: 8905 RVA: 0x0009C50C File Offset: 0x0009A70C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022CA RID: 8906 RVA: 0x0009C54C File Offset: 0x0009A74C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568045, XrefRangeEnd = 568052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060022CB RID: 8907 RVA: 0x0009C58C File Offset: 0x0009A78C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 568052, XrefRangeEnd = 568059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060022CC RID: 8908 RVA: 0x00010B55 File Offset: 0x0000ED55
			public _KnapsackSolver_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000877 RID: 2167
			// (get) Token: 0x060022CD RID: 8909 RVA: 0x0009C5CC File Offset: 0x0009A7CC
			// (set) Token: 0x060022CE RID: 8910 RVA: 0x00010B5E File Offset: 0x0000ED5E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000878 RID: 2168
			// (get) Token: 0x060022CF RID: 8911 RVA: 0x0009C5F4 File Offset: 0x0009A7F4
			// (set) Token: 0x060022D0 RID: 8912 RVA: 0x0009C61C File Offset: 0x0009A81C
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___2__current);
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

			// Token: 0x17000879 RID: 2169
			// (get) Token: 0x060022D1 RID: 8913 RVA: 0x0009C6C4 File Offset: 0x0009A8C4
			// (set) Token: 0x060022D2 RID: 8914 RVA: 0x00010B79 File Offset: 0x0000ED79
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700087A RID: 2170
			// (get) Token: 0x060022D3 RID: 8915 RVA: 0x0009C6EC File Offset: 0x0009A8EC
			// (set) Token: 0x060022D4 RID: 8916 RVA: 0x00010B94 File Offset: 0x0000ED94
			public unsafe IEnumerable<ValueTuple<T, int, Decimal>> elems
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr_elems);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<T, int, Decimal>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr_elems), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087B RID: 2171
			// (get) Token: 0x060022D5 RID: 8917 RVA: 0x0009C71C File Offset: 0x0009A91C
			// (set) Token: 0x060022D6 RID: 8918 RVA: 0x00010BB3 File Offset: 0x0000EDB3
			public unsafe IEnumerable<ValueTuple<T, int, Decimal>> __3__elems
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___3__elems);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<T, int, Decimal>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___3__elems), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087C RID: 2172
			// (get) Token: 0x060022D7 RID: 8919 RVA: 0x0009C74C File Offset: 0x0009A94C
			// (set) Token: 0x060022D8 RID: 8920 RVA: 0x00010BD2 File Offset: 0x0000EDD2
			public unsafe int maxWeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr_maxWeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr_maxWeight)) = value;
				}
			}

			// Token: 0x1700087D RID: 2173
			// (get) Token: 0x060022D9 RID: 8921 RVA: 0x0009C774 File Offset: 0x0009A974
			// (set) Token: 0x060022DA RID: 8922 RVA: 0x00010BED File Offset: 0x0000EDED
			public unsafe int __3__maxWeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___3__maxWeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr___3__maxWeight)) = value;
				}
			}

			// Token: 0x1700087E RID: 2174
			// (get) Token: 0x060022DB RID: 8923 RVA: 0x0009C79C File Offset: 0x0009A99C
			// (set) Token: 0x060022DC RID: 8924 RVA: 0x00010C08 File Offset: 0x0000EE08
			public unsafe Il2CppReferenceArray<ValueTuple<T, int, Decimal>> _elemArr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__elemArr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<T, int, Decimal>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__elemArr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087F RID: 2175
			// (get) Token: 0x060022DD RID: 8925 RVA: 0x0009C7CC File Offset: 0x0009A9CC
			// (set) Token: 0x060022DE RID: 8926 RVA: 0x00010C27 File Offset: 0x0000EE27
			public unsafe Il2CppObjectBase _valueMatrix_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__valueMatrix_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__valueMatrix_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000880 RID: 2176
			// (get) Token: 0x060022DF RID: 8927 RVA: 0x0009C7FC File Offset: 0x0009A9FC
			// (set) Token: 0x060022E0 RID: 8928 RVA: 0x00010C46 File Offset: 0x0000EE46
			public unsafe Decimal _currValue_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__currValue_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__currValue_5__4)) = value;
				}
			}

			// Token: 0x17000881 RID: 2177
			// (get) Token: 0x060022E1 RID: 8929 RVA: 0x0009C824 File Offset: 0x0009AA24
			// (set) Token: 0x060022E2 RID: 8930 RVA: 0x00010C61 File Offset: 0x0000EE61
			public unsafe int _currWeight_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__currWeight_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__currWeight_5__5)) = value;
				}
			}

			// Token: 0x17000882 RID: 2178
			// (get) Token: 0x060022E3 RID: 8931 RVA: 0x0009C84C File Offset: 0x0009AA4C
			// (set) Token: 0x060022E4 RID: 8932 RVA: 0x00010C7C File Offset: 0x0000EE7C
			public unsafe int _i_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AIAlgorithmUtil._KnapsackSolver_d__3<T>.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x040015D7 RID: 5591
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015D8 RID: 5592
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015D9 RID: 5593
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040015DA RID: 5594
			private static readonly IntPtr NativeFieldInfoPtr_elems;

			// Token: 0x040015DB RID: 5595
			private static readonly IntPtr NativeFieldInfoPtr___3__elems;

			// Token: 0x040015DC RID: 5596
			private static readonly IntPtr NativeFieldInfoPtr_maxWeight;

			// Token: 0x040015DD RID: 5597
			private static readonly IntPtr NativeFieldInfoPtr___3__maxWeight;

			// Token: 0x040015DE RID: 5598
			private static readonly IntPtr NativeFieldInfoPtr__elemArr_5__2;

			// Token: 0x040015DF RID: 5599
			private static readonly IntPtr NativeFieldInfoPtr__valueMatrix_5__3;

			// Token: 0x040015E0 RID: 5600
			private static readonly IntPtr NativeFieldInfoPtr__currValue_5__4;

			// Token: 0x040015E1 RID: 5601
			private static readonly IntPtr NativeFieldInfoPtr__currWeight_5__5;

			// Token: 0x040015E2 RID: 5602
			private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x040015E3 RID: 5603
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015E4 RID: 5604
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015E5 RID: 5605
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015E6 RID: 5606
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x040015E7 RID: 5607
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015E8 RID: 5608
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015E9 RID: 5609
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x040015EA RID: 5610
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200033F RID: 831
		private sealed class MethodInfoStoreGeneric_BestRankTimeout_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_TComparable_Int64_0<TSource, TComparable>
		{
			// Token: 0x040015EB RID: 5611
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AIAlgorithmUtil.NativeMethodInfoPtr_BestRankTimeout_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_TComparable_Int64_0, Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComparable>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000340 RID: 832
		private sealed class MethodInfoStoreGeneric_BestRankTimeout_Public_Static_Nullable_1_TSource_IEnumerable_1_TSource_Func_2_Nullable_1_TSource_TComparable_Int64_0<TSource, TComparable>
		{
			// Token: 0x040015EC RID: 5612
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AIAlgorithmUtil.NativeMethodInfoPtr_BestRankTimeout_Public_Static_Nullable_1_TSource_IEnumerable_1_TSource_Func_2_Nullable_1_TSource_TComparable_Int64_0, Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComparable>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000341 RID: 833
		private sealed class MethodInfoStoreGeneric_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_Int32_Func_2_T_Decimal_Int32_0<T>
		{
			// Token: 0x040015ED RID: 5613
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AIAlgorithmUtil.NativeMethodInfoPtr_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_Int32_Func_2_T_Decimal_Int32_0, Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000342 RID: 834
		private sealed class MethodInfoStoreGeneric_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_ValueTuple_3_T_Int32_Decimal_Int32_0<T>
		{
			// Token: 0x040015EE RID: 5614
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AIAlgorithmUtil.NativeMethodInfoPtr_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_ValueTuple_3_T_Int32_Decimal_Int32_0, Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000343 RID: 835
		private sealed class MethodInfoStoreGeneric_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_KnapsackItem_1_T_Int32_0<T>
		{
			// Token: 0x040015EF RID: 5615
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AIAlgorithmUtil.NativeMethodInfoPtr_KnapsackSolver_Public_Static_IEnumerable_1_T_IEnumerable_1_KnapsackItem_1_T_Int32_0, Il2CppClassPointerStore<AIAlgorithmUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
