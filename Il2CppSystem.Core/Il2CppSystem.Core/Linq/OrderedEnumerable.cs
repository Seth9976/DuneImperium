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
	// Token: 0x02000020 RID: 32
	public class OrderedEnumerable<TElement> : Object
	{
		// Token: 0x0600014C RID: 332 RVA: 0x00015D30 File Offset: 0x00013F30
		// Note: this type is marked as 'beforefieldinit'.
		static OrderedEnumerable()
		{
			Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "OrderedEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr);
			OrderedEnumerable<TElement>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, "source");
			OrderedEnumerable<TElement>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663772);
			OrderedEnumerable<TElement>.NativeMethodInfoPtr_GetEnumerableSorter_Internal_Abstract_Virtual_New_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663773);
			OrderedEnumerable<TElement>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663774);
			OrderedEnumerable<TElement>.NativeMethodInfoPtr_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663775);
			OrderedEnumerable<TElement>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663776);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00015E14 File Offset: 0x00014014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006532, XrefRangeEnd = 1006536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<TElement> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TElement>>(intPtr3) : null;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00015E54 File Offset: 0x00014054
		[CallerCount(0)]
		public unsafe virtual EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrderedEnumerable<TElement>.NativeMethodInfoPtr_GetEnumerableSorter_Internal_Abstract_Virtual_New_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnumerableSorter<TElement>>(intPtr3) : null;
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00015EB0 File Offset: 0x000140B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006536, XrefRangeEnd = 1006540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00015EF0 File Offset: 0x000140F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006540, XrefRangeEnd = 1006545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IOrderedEnumerable<TElement> System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref descending;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TKey>.MethodInfoStoreGeneric_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TElement>>(intPtr3) : null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00015F60 File Offset: 0x00014160
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrderedEnumerable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002478 File Offset: 0x00000678
		public OrderedEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00015F9C File Offset: 0x0001419C
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002481 File Offset: 0x00000681
		public unsafe IEnumerable<TElement> source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerableSorter_Internal_Abstract_Virtual_New_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020001BA RID: 442
		[ObfuscatedName("System.Linq.OrderedEnumerable`1+<GetEnumerator>d__1")]
		public sealed class _GetEnumerator_d__1 : Object
		{
			// Token: 0x060015F7 RID: 5623 RVA: 0x0006D000 File Offset: 0x0006B200
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__1()
			{
				Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, "<GetEnumerator>d__1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<>1__state");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<>2__current");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<>4__this");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__buffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<buffer>5__2");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__map_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<map>5__3");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<i>5__4");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663777);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663778);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663779);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663780);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663781);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663782);
			}

			// Token: 0x060015F8 RID: 5624 RVA: 0x0006D158 File Offset: 0x0006B358
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060015F9 RID: 5625 RVA: 0x0006D1A0 File Offset: 0x0006B3A0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015FA RID: 5626 RVA: 0x0006D1D4 File Offset: 0x0006B3D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006525, XrefRangeEnd = 1006531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x060015FB RID: 5627 RVA: 0x0006D210 File Offset: 0x0006B410
			public unsafe TElement System.Collections.Generic.IEnumerator<TElement>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TElement>(intPtr, false, true);
				}
			}

			// Token: 0x060015FC RID: 5628 RVA: 0x0006D24C File Offset: 0x0006B44C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x060015FD RID: 5629 RVA: 0x0006D280 File Offset: 0x0006B480
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006531, XrefRangeEnd = 1006532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015FE RID: 5630 RVA: 0x0000929D File Offset: 0x0000749D
			public _GetEnumerator_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x060015FF RID: 5631 RVA: 0x0006D2C0 File Offset: 0x0006B4C0
			// (set) Token: 0x06001600 RID: 5632 RVA: 0x000092A6 File Offset: 0x000074A6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x06001601 RID: 5633 RVA: 0x0006D2E8 File Offset: 0x0006B4E8
			// (set) Token: 0x06001602 RID: 5634 RVA: 0x0006D310 File Offset: 0x0006B510
			public unsafe TElement __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TElement>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TElement);
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

			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x06001603 RID: 5635 RVA: 0x0006D3B8 File Offset: 0x0006B5B8
			// (set) Token: 0x06001604 RID: 5636 RVA: 0x000092C1 File Offset: 0x000074C1
			public unsafe OrderedEnumerable<TElement> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderedEnumerable<TElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x06001605 RID: 5637 RVA: 0x0006D3E8 File Offset: 0x0006B5E8
			// (set) Token: 0x06001606 RID: 5638 RVA: 0x000092E0 File Offset: 0x000074E0
			public Buffer<TElement> _buffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__buffer_5__2);
					return new Buffer<TElement>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__buffer_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x06001607 RID: 5639 RVA: 0x0006D418 File Offset: 0x0006B618
			// (set) Token: 0x06001608 RID: 5640 RVA: 0x0000930E File Offset: 0x0000750E
			public unsafe Il2CppStructArray<int> _map_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__map_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__map_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x06001609 RID: 5641 RVA: 0x0006D448 File Offset: 0x0006B648
			// (set) Token: 0x0600160A RID: 5642 RVA: 0x0000932D File Offset: 0x0000752D
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04000F9C RID: 3996
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F9D RID: 3997
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F9E RID: 3998
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F9F RID: 3999
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__2;

			// Token: 0x04000FA0 RID: 4000
			private static readonly IntPtr NativeFieldInfoPtr__map_5__3;

			// Token: 0x04000FA1 RID: 4001
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04000FA2 RID: 4002
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000FA3 RID: 4003
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FA4 RID: 4004
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000FA5 RID: 4005
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0;

			// Token: 0x04000FA6 RID: 4006
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000FA7 RID: 4007
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001BB RID: 443
		private sealed class MethodInfoStoreGeneric_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0
		{
			// Token: 0x04000FA8 RID: 4008
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OrderedEnumerable<TKey>.NativeMethodInfoPtr_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0, Il2CppClassPointerStore<OrderedEnumerable<TKey>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)) }))));
		}
	}
}
