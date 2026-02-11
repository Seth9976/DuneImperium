using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000023 RID: 35
	public class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement>
	{
		// Token: 0x06000168 RID: 360 RVA: 0x000164E4 File Offset: 0x000146E4
		// Note: this type is marked as 'beforefieldinit'.
		static EnumerableSorter()
		{
			Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "EnumerableSorter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr);
			EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_keySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, "keySelector");
			EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, "comparer");
			EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_descending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, "descending");
			EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, "next");
			EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, "keys");
			EnumerableSorter<TElement, TKey>.NativeMethodInfoPtr__ctor_Internal_Void_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_EnumerableSorter_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, 100663790);
			EnumerableSorter<TElement, TKey>.NativeMethodInfoPtr_ComputeKeys_Internal_Virtual_Void_Il2CppArrayBase_1_TElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, 100663791);
			EnumerableSorter<TElement, TKey>.NativeMethodInfoPtr_CompareKeys_Internal_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, 100663792);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00016604 File Offset: 0x00014804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006577, RefRangeEnd = 1006578, XrefRangeStart = 1006571, XrefRangeEnd = 1006577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumerableSorter(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref descending;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableSorter<TElement, TKey>.NativeMethodInfoPtr__ctor_Internal_Void_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_EnumerableSorter_1_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00016684 File Offset: 0x00014884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006578, XrefRangeEnd = 1006581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ComputeKeys(Il2CppArrayBase<TElement> elements, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumerableSorter<TElement, TKey>.NativeMethodInfoPtr_ComputeKeys_Internal_Virtual_Void_Il2CppArrayBase_1_TElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000166E0 File Offset: 0x000148E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006581, XrefRangeEnd = 1006583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CompareKeys(int index1, int index2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumerableSorter<TElement, TKey>.NativeMethodInfoPtr_CompareKeys_Internal_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000252A File Offset: 0x0000072A
		public EnumerableSorter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00016744 File Offset: 0x00014944
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002533 File Offset: 0x00000733
		public unsafe Func<TElement, TKey> keySelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_keySelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TElement, TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_keySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00016774 File Offset: 0x00014974
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002552 File Offset: 0x00000752
		public unsafe IComparer<TKey> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000167A4 File Offset: 0x000149A4
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002571 File Offset: 0x00000771
		public unsafe bool descending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_descending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_descending)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000167CC File Offset: 0x000149CC
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0000258C File Offset: 0x0000078C
		public unsafe EnumerableSorter<TElement> next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumerableSorter<TElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000167FC File Offset: 0x000149FC
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000025AB File Offset: 0x000007AB
		public unsafe Il2CppArrayBase<TKey> keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_keys);
				return Il2CppArrayBase<TKey>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_keySelector;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_descending;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_keys;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_EnumerableSorter_1_TElement_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_ComputeKeys_Internal_Virtual_Void_Il2CppArrayBase_1_TElement_Int32_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_CompareKeys_Internal_Virtual_Int32_Int32_Int32_0;
	}
}
