using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000166 RID: 358
	public sealed class ValueListBuilder<T> : ValueType
	{
		// Token: 0x060015BD RID: 5565 RVA: 0x000709F4 File Offset: 0x0006EBF4
		// Note: this type is marked as 'beforefieldinit'.
		static ValueListBuilder()
		{
			Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "ValueListBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr);
			ValueListBuilder<T>.NativeFieldInfoPtr__span = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, "_span");
			ValueListBuilder<T>.NativeFieldInfoPtr__arrayFromPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, "_arrayFromPool");
			ValueListBuilder<T>.NativeFieldInfoPtr__pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, "_pos");
			ValueListBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Span_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100666603);
			ValueListBuilder<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100666604);
			ValueListBuilder<T>.NativeMethodInfoPtr_get_Item_Public_get_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100666605);
			ValueListBuilder<T>.NativeMethodInfoPtr_Append_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100666606);
			ValueListBuilder<T>.NativeMethodInfoPtr_AsSpan_Public_ReadOnlySpan_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100666607);
			ValueListBuilder<T>.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100666608);
			ValueListBuilder<T>.NativeMethodInfoPtr_Grow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100666609);
			ValueListBuilder<T>.NativeMethodInfoPtr_Pop_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr, 100666610);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00070B3C File Offset: 0x0006ED3C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 467556, RefRangeEnd = 467567, XrefRangeStart = 467556, XrefRangeEnd = 467556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueListBuilder(Span<T> initialSpan)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(initialSpan));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Span_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x00070B94 File Offset: 0x0006ED94
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000664 RID: 1636
		public unsafe ref T this[int index]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 467567, RefRangeEnd = 467570, XrefRangeStart = 467567, XrefRangeEnd = 467567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr_get_Item_Public_get_byref_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00070C1C File Offset: 0x0006EE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467570, XrefRangeEnd = 467573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr_Append_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00070C9C File Offset: 0x0006EE9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 467578, RefRangeEnd = 467584, XrefRangeStart = 467573, XrefRangeEnd = 467578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlySpan<T> AsSpan()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr_AsSpan_Public_ReadOnlySpan_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ReadOnlySpan<T>(intPtr);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00070CD8 File Offset: 0x0006EED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467584, XrefRangeEnd = 467589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00070D10 File Offset: 0x0006EF10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 467606, RefRangeEnd = 467611, XrefRangeStart = 467589, XrefRangeEnd = 467606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr_Grow_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00070D48 File Offset: 0x0006EF48
		[CallerCount(0)]
		public unsafe T Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueListBuilder<T>.NativeMethodInfoPtr_Pop_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x000098A8 File Offset: 0x00007AA8
		public ValueListBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000098B1 File Offset: 0x00007AB1
		public ValueListBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueListBuilder<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x00070D88 File Offset: 0x0006EF88
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x000098C3 File Offset: 0x00007AC3
		public Span<T> _span
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueListBuilder<T>.NativeFieldInfoPtr__span);
				return new Span<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Span<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueListBuilder<T>.NativeFieldInfoPtr__span), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Span<T>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x00070DB8 File Offset: 0x0006EFB8
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x000098F1 File Offset: 0x00007AF1
		public unsafe Il2CppArrayBase<T> _arrayFromPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueListBuilder<T>.NativeFieldInfoPtr__arrayFromPool);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueListBuilder<T>.NativeFieldInfoPtr__arrayFromPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x00070DE0 File Offset: 0x0006EFE0
		// (set) Token: 0x060015CD RID: 5581 RVA: 0x00009910 File Offset: 0x00007B10
		public unsafe int _pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueListBuilder<T>.NativeFieldInfoPtr__pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueListBuilder<T>.NativeFieldInfoPtr__pos)) = value;
			}
		}

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeFieldInfoPtr__span;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeFieldInfoPtr__arrayFromPool;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeFieldInfoPtr__pos;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Span_1_T_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_T_Int32_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_T_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_AsSpan_Public_ReadOnlySpan_1_T_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr_Grow_Private_Void_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_T_0;
	}
}
