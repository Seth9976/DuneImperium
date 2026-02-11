using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000022 RID: 34
	public class EnumerableSorter<TElement> : Object
	{
		// Token: 0x06000161 RID: 353 RVA: 0x00016258 File Offset: 0x00014458
		// Note: this type is marked as 'beforefieldinit'.
		static EnumerableSorter()
		{
			Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "EnumerableSorter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr);
			EnumerableSorter<TElement>.NativeMethodInfoPtr_ComputeKeys_Internal_Abstract_Virtual_New_Void_Il2CppArrayBase_1_TElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr, 100663785);
			EnumerableSorter<TElement>.NativeMethodInfoPtr_CompareKeys_Internal_Abstract_Virtual_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr, 100663786);
			EnumerableSorter<TElement>.NativeMethodInfoPtr_Sort_Internal_Il2CppStructArray_1_Int32_Il2CppArrayBase_1_TElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr, 100663787);
			EnumerableSorter<TElement>.NativeMethodInfoPtr_QuickSort_Private_Void_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr, 100663788);
			EnumerableSorter<TElement>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr, 100663789);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00016328 File Offset: 0x00014528
		[CallerCount(0)]
		public unsafe virtual void ComputeKeys(Il2CppArrayBase<TElement> elements, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumerableSorter<TElement>.NativeMethodInfoPtr_ComputeKeys_Internal_Abstract_Virtual_New_Void_Il2CppArrayBase_1_TElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00016384 File Offset: 0x00014584
		[CallerCount(0)]
		public unsafe virtual int CompareKeys(int index1, int index2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumerableSorter<TElement>.NativeMethodInfoPtr_CompareKeys_Internal_Abstract_Virtual_New_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000163E8 File Offset: 0x000145E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006563, RefRangeEnd = 1006564, XrefRangeStart = 1006559, XrefRangeEnd = 1006563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> Sort(Il2CppArrayBase<TElement> elements, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableSorter<TElement>.NativeMethodInfoPtr_Sort_Internal_Il2CppStructArray_1_Int32_Il2CppArrayBase_1_TElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00016448 File Offset: 0x00014648
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1006568, RefRangeEnd = 1006571, XrefRangeStart = 1006564, XrefRangeEnd = 1006568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuickSort(Il2CppStructArray<int> map, int left, int right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref left;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableSorter<TElement>.NativeMethodInfoPtr_QuickSort_Private_Void_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000164A8 File Offset: 0x000146A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumerableSorter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumerableSorter<TElement>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableSorter<TElement>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002521 File Offset: 0x00000721
		public EnumerableSorter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_ComputeKeys_Internal_Abstract_Virtual_New_Void_Il2CppArrayBase_1_TElement_Int32_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_CompareKeys_Internal_Abstract_Virtual_New_Int32_Int32_Int32_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Internal_Il2CppStructArray_1_Int32_Il2CppArrayBase_1_TElement_Int32_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_QuickSort_Private_Void_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
