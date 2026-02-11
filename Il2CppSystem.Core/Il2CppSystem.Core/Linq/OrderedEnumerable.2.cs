using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000021 RID: 33
	public class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement>
	{
		// Token: 0x06000155 RID: 341 RVA: 0x00015FCC File Offset: 0x000141CC
		// Note: this type is marked as 'beforefieldinit'.
		static OrderedEnumerable()
		{
			Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "OrderedEnumerable`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr);
			OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr, "parent");
			OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_keySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr, "keySelector");
			OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr, "comparer");
			OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_descending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr, "descending");
			OrderedEnumerable<TElement, TKey>.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr, 100663783);
			OrderedEnumerable<TElement, TKey>.NativeMethodInfoPtr_GetEnumerableSorter_Internal_Virtual_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr, 100663784);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000160C4 File Offset: 0x000142C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1006551, RefRangeEnd = 1006555, XrefRangeStart = 1006545, XrefRangeEnd = 1006551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrderedEnumerable(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref descending;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement, TKey>.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00016144 File Offset: 0x00014344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006555, XrefRangeEnd = 1006559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrderedEnumerable<TElement, TKey>.NativeMethodInfoPtr_GetEnumerableSorter_Internal_Virtual_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnumerableSorter<TElement>>(intPtr3) : null;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000024A0 File Offset: 0x000006A0
		public OrderedEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000161A0 File Offset: 0x000143A0
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000024A9 File Offset: 0x000006A9
		public unsafe OrderedEnumerable<TElement> parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderedEnumerable<TElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000161D0 File Offset: 0x000143D0
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000024C8 File Offset: 0x000006C8
		public unsafe Func<TElement, TKey> keySelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_keySelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TElement, TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_keySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00016200 File Offset: 0x00014400
		// (set) Token: 0x0600015E RID: 350 RVA: 0x000024E7 File Offset: 0x000006E7
		public unsafe IComparer<TKey> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00016230 File Offset: 0x00014430
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002506 File Offset: 0x00000706
		public unsafe bool descending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_descending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_descending)) = value;
			}
		}

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_keySelector;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_descending;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerableSorter_Internal_Virtual_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0;
	}
}
