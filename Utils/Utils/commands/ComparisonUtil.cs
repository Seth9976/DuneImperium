using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Utils.commands
{
	// Token: 0x0200003E RID: 62
	public static class ComparisonUtil : Object
	{
		// Token: 0x06000286 RID: 646 RVA: 0x0000F05C File Offset: 0x0000D25C
		// Note: this type is marked as 'beforefieldinit'.
		static ComparisonUtil()
		{
			Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils.commands", "ComparisonUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr);
			ComparisonUtil.NativeMethodInfoPtr_ThenBy_Public_Static_IComparer_1_T_IComparer_1_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr, 100663895);
			ComparisonUtil.NativeMethodInfoPtr_OrderingOn_Public_Static_IComparer_1_T_Func_2_T_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr, 100663896);
			ComparisonUtil.NativeMethodInfoPtr_MappedFrom_Public_Static_IComparer_1_T_IComparer_1_U_Func_2_T_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr, 100663897);
			ComparisonUtil.NativeMethodInfoPtr_Descending_Public_Static_IComparer_1_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr, 100663898);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000F0DC File Offset: 0x0000D2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184703, XrefRangeEnd = 1184714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IComparer<T> ThenBy<T>(this IComparer<T> self, IComparer<T> nextComparison)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nextComparison);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComparisonUtil.MethodInfoStoreGeneric_ThenBy_Public_Static_IComparer_1_T_IComparer_1_T_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<T>>(intPtr3) : null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000F134 File Offset: 0x0000D334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184714, XrefRangeEnd = 1184718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IComparer<T> OrderingOn<T, U>(Func<T, U> mapping)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapping);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComparisonUtil.MethodInfoStoreGeneric_OrderingOn_Public_Static_IComparer_1_T_Func_2_T_U_0<T, U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000F178 File Offset: 0x0000D378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184718, XrefRangeEnd = 1184721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IComparer<T> MappedFrom<T, U>(this IComparer<U> comparer, Func<T, U> mapping)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mapping);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComparisonUtil.MethodInfoStoreGeneric_MappedFrom_Public_Static_IComparer_1_T_IComparer_1_U_Func_2_T_U_0<T, U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<T>>(intPtr3) : null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IComparer<T> Descending<T>(this IComparer<T> comparer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComparisonUtil.MethodInfoStoreGeneric_Descending_Public_Static_IComparer_1_T_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002BB3 File Offset: 0x00000DB3
		public ComparisonUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_ThenBy_Public_Static_IComparer_1_T_IComparer_1_T_IComparer_1_T_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_OrderingOn_Public_Static_IComparer_1_T_Func_2_T_U_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_MappedFrom_Public_Static_IComparer_1_T_IComparer_1_U_Func_2_T_U_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_Descending_Public_Static_IComparer_1_T_IComparer_1_T_0;

		// Token: 0x020000BB RID: 187
		public class ComposedComparer<T> : Object
		{
			// Token: 0x060005C1 RID: 1473 RVA: 0x0001A464 File Offset: 0x00018664
			// Note: this type is marked as 'beforefieldinit'.
			static ComposedComparer()
			{
				Il2CppClassPointerStore<ComparisonUtil.ComposedComparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr, "ComposedComparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComparisonUtil.ComposedComparer<T>>.NativeClassPtr);
				ComparisonUtil.ComposedComparer<T>.NativeFieldInfoPtr_comparers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComparisonUtil.ComposedComparer<T>>.NativeClassPtr, "comparers");
				ComparisonUtil.ComposedComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonUtil.ComposedComparer<T>>.NativeClassPtr, 100663899);
				ComparisonUtil.ComposedComparer<T>.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonUtil.ComposedComparer<T>>.NativeClassPtr, 100663900);
				ComparisonUtil.ComposedComparer<T>.NativeMethodInfoPtr_ThenBy_Public_IComparer_1_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonUtil.ComposedComparer<T>>.NativeClassPtr, 100663901);
			}

			// Token: 0x060005C2 RID: 1474 RVA: 0x0001A51C File Offset: 0x0001871C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184657, XrefRangeEnd = 1184662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ComposedComparer(IEnumerable<IComparer<T>> comparers)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComparisonUtil.ComposedComparer<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparers);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComparisonUtil.ComposedComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005C3 RID: 1475 RVA: 0x0001A568 File Offset: 0x00018768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184662, XrefRangeEnd = 1184671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(T x, T y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = x;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					T t2 = y;
					intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref y;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ComparisonUtil.ComposedComparer<T>.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x060005C4 RID: 1476 RVA: 0x0001A634 File Offset: 0x00018834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184671, XrefRangeEnd = 1184676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IComparer<T> ThenBy(IComparer<T> nextComparison)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextComparison);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComparisonUtil.ComposedComparer<T>.NativeMethodInfoPtr_ThenBy_Public_IComparer_1_T_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<T>>(intPtr3) : null;
				}
			}

			// Token: 0x060005C5 RID: 1477 RVA: 0x000044CA File Offset: 0x000026CA
			public ComposedComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0001A684 File Offset: 0x00018884
			// (set) Token: 0x060005C7 RID: 1479 RVA: 0x000044D3 File Offset: 0x000026D3
			public unsafe List<IComparer<T>> comparers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComparisonUtil.ComposedComparer<T>.NativeFieldInfoPtr_comparers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IComparer<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComparisonUtil.ComposedComparer<T>.NativeFieldInfoPtr_comparers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003BE RID: 958
			private static readonly IntPtr NativeFieldInfoPtr_comparers;

			// Token: 0x040003BF RID: 959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IComparer_1_T_0;

			// Token: 0x040003C0 RID: 960
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_T_T_0;

			// Token: 0x040003C1 RID: 961
			private static readonly IntPtr NativeMethodInfoPtr_ThenBy_Public_IComparer_1_T_IComparer_1_T_0;
		}

		// Token: 0x020000BC RID: 188
		public class SimpleComparer<T, U> : Object
		{
			// Token: 0x060005C8 RID: 1480 RVA: 0x0001A6B4 File Offset: 0x000188B4
			// Note: this type is marked as 'beforefieldinit'.
			static SimpleComparer()
			{
				Il2CppClassPointerStore<ComparisonUtil.SimpleComparer<T, U>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr, "SimpleComparer`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComparisonUtil.SimpleComparer<T, U>>.NativeClassPtr);
				ComparisonUtil.SimpleComparer<T, U>.NativeFieldInfoPtr_mapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComparisonUtil.SimpleComparer<T, U>>.NativeClassPtr, "mapping");
				ComparisonUtil.SimpleComparer<T, U>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComparisonUtil.SimpleComparer<T, U>>.NativeClassPtr, "comparer");
				ComparisonUtil.SimpleComparer<T, U>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_T_U_IComparer_1_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonUtil.SimpleComparer<T, U>>.NativeClassPtr, 100663902);
				ComparisonUtil.SimpleComparer<T, U>.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonUtil.SimpleComparer<T, U>>.NativeClassPtr, 100663903);
			}

			// Token: 0x060005C9 RID: 1481 RVA: 0x0001A77C File Offset: 0x0001897C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1184689, RefRangeEnd = 1184690, XrefRangeStart = 1184676, XrefRangeEnd = 1184689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SimpleComparer(Func<T, U> mapping, IComparer<U> comparer = null)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComparisonUtil.SimpleComparer<T, U>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapping);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComparisonUtil.SimpleComparer<T, U>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_T_U_IComparer_1_U_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x0001A7DC File Offset: 0x000189DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184690, XrefRangeEnd = 1184697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(T x, T y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = x;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					T t2 = y;
					intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref y;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ComparisonUtil.SimpleComparer<T, U>.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x000044F2 File Offset: 0x000026F2
			public SimpleComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x060005CC RID: 1484 RVA: 0x0001A8A8 File Offset: 0x00018AA8
			// (set) Token: 0x060005CD RID: 1485 RVA: 0x000044FB File Offset: 0x000026FB
			public unsafe Func<T, U> mapping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComparisonUtil.SimpleComparer<T, U>.NativeFieldInfoPtr_mapping);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, U>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComparisonUtil.SimpleComparer<T, U>.NativeFieldInfoPtr_mapping), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x060005CE RID: 1486 RVA: 0x0001A8D8 File Offset: 0x00018AD8
			// (set) Token: 0x060005CF RID: 1487 RVA: 0x0000451A File Offset: 0x0000271A
			public unsafe IComparer<U> comparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComparisonUtil.SimpleComparer<T, U>.NativeFieldInfoPtr_comparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<U>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComparisonUtil.SimpleComparer<T, U>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003C2 RID: 962
			private static readonly IntPtr NativeFieldInfoPtr_mapping;

			// Token: 0x040003C3 RID: 963
			private static readonly IntPtr NativeFieldInfoPtr_comparer;

			// Token: 0x040003C4 RID: 964
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_T_U_IComparer_1_U_0;

			// Token: 0x040003C5 RID: 965
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_T_T_0;
		}

		// Token: 0x020000BD RID: 189
		public class DescendingComparer<T> : Object
		{
			// Token: 0x060005D0 RID: 1488 RVA: 0x0001A908 File Offset: 0x00018B08
			// Note: this type is marked as 'beforefieldinit'.
			static DescendingComparer()
			{
				Il2CppClassPointerStore<ComparisonUtil.DescendingComparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr, "DescendingComparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComparisonUtil.DescendingComparer<T>>.NativeClassPtr);
				ComparisonUtil.DescendingComparer<T>.NativeFieldInfoPtr_innerComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComparisonUtil.DescendingComparer<T>>.NativeClassPtr, "innerComparer");
				ComparisonUtil.DescendingComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonUtil.DescendingComparer<T>>.NativeClassPtr, 100663904);
				ComparisonUtil.DescendingComparer<T>.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComparisonUtil.DescendingComparer<T>>.NativeClassPtr, 100663905);
			}

			// Token: 0x060005D1 RID: 1489 RVA: 0x0001A9AC File Offset: 0x00018BAC
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DescendingComparer(IComparer<T> comparer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComparisonUtil.DescendingComparer<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComparisonUtil.DescendingComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005D2 RID: 1490 RVA: 0x0001A9F8 File Offset: 0x00018BF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184697, XrefRangeEnd = 1184703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(T x, T y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = x;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					T t2 = y;
					intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref y;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ComparisonUtil.DescendingComparer<T>.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x060005D3 RID: 1491 RVA: 0x00004539 File Offset: 0x00002739
			public DescendingComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0001AAC4 File Offset: 0x00018CC4
			// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00004542 File Offset: 0x00002742
			public unsafe IComparer<T> innerComparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComparisonUtil.DescendingComparer<T>.NativeFieldInfoPtr_innerComparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComparisonUtil.DescendingComparer<T>.NativeFieldInfoPtr_innerComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003C6 RID: 966
			private static readonly IntPtr NativeFieldInfoPtr_innerComparer;

			// Token: 0x040003C7 RID: 967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_T_0;

			// Token: 0x040003C8 RID: 968
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_T_T_0;
		}

		// Token: 0x020000BE RID: 190
		private sealed class MethodInfoStoreGeneric_ThenBy_Public_Static_IComparer_1_T_IComparer_1_T_IComparer_1_T_0<T>
		{
			// Token: 0x040003C9 RID: 969
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ComparisonUtil.NativeMethodInfoPtr_ThenBy_Public_Static_IComparer_1_T_IComparer_1_T_IComparer_1_T_0, Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000BF RID: 191
		private sealed class MethodInfoStoreGeneric_OrderingOn_Public_Static_IComparer_1_T_Func_2_T_U_0<T, U>
		{
			// Token: 0x040003CA RID: 970
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ComparisonUtil.NativeMethodInfoPtr_OrderingOn_Public_Static_IComparer_1_T_Func_2_T_U_0, Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000C0 RID: 192
		private sealed class MethodInfoStoreGeneric_MappedFrom_Public_Static_IComparer_1_T_IComparer_1_U_Func_2_T_U_0<T, U>
		{
			// Token: 0x040003CB RID: 971
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ComparisonUtil.NativeMethodInfoPtr_MappedFrom_Public_Static_IComparer_1_T_IComparer_1_U_Func_2_T_U_0, Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000C1 RID: 193
		private sealed class MethodInfoStoreGeneric_Descending_Public_Static_IComparer_1_T_IComparer_1_T_0<T>
		{
			// Token: 0x040003CC RID: 972
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ComparisonUtil.NativeMethodInfoPtr_Descending_Public_Static_IComparer_1_T_IComparer_1_T_0, Il2CppClassPointerStore<ComparisonUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
