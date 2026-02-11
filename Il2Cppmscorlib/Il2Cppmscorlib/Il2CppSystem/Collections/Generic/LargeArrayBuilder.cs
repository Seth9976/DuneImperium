using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004F3 RID: 1267
	public sealed class LargeArrayBuilder<T> : ValueType
	{
		// Token: 0x06004E32 RID: 20018 RVA: 0x0016B290 File Offset: 0x00169490
		// Note: this type is marked as 'beforefieldinit'.
		static LargeArrayBuilder()
		{
			Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "LargeArrayBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr);
			LargeArrayBuilder<T>.NativeFieldInfoPtr__maxCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, "_maxCapacity");
			LargeArrayBuilder<T>.NativeFieldInfoPtr__first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, "_first");
			LargeArrayBuilder<T>.NativeFieldInfoPtr__buffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, "_buffers");
			LargeArrayBuilder<T>.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, "_current");
			LargeArrayBuilder<T>.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, "_index");
			LargeArrayBuilder<T>.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, "_count");
			LargeArrayBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, 100675063);
			LargeArrayBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, 100675064);
			LargeArrayBuilder<T>.NativeMethodInfoPtr_AddRange_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, 100675065);
			LargeArrayBuilder<T>.NativeMethodInfoPtr_AddWithBufferAllocation_Private_Void_T_byref_Il2CppArrayBase_1_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, 100675066);
			LargeArrayBuilder<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, 100675067);
			LargeArrayBuilder<T>.NativeMethodInfoPtr_GetBuffer_Public_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, 100675068);
			LargeArrayBuilder<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, 100675069);
			LargeArrayBuilder<T>.NativeMethodInfoPtr_TryMove_Public_Boolean_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, 100675070);
			LargeArrayBuilder<T>.NativeMethodInfoPtr_AllocateBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr, 100675071);
		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x0016B428 File Offset: 0x00169628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425285, RefRangeEnd = 1425286, XrefRangeStart = 1425277, XrefRangeEnd = 1425285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LargeArrayBuilder(bool initialize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LargeArrayBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x0016B474 File Offset: 0x00169674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425286, XrefRangeEnd = 1425293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LargeArrayBuilder(int maxCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LargeArrayBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x0016B4C0 File Offset: 0x001696C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425315, RefRangeEnd = 1425316, XrefRangeStart = 1425293, XrefRangeEnd = 1425315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(IEnumerable<T> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LargeArrayBuilder<T>.NativeMethodInfoPtr_AddRange_Public_Void_IEnumerable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x0016B508 File Offset: 0x00169708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425333, RefRangeEnd = 1425334, XrefRangeStart = 1425316, XrefRangeEnd = 1425333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddWithBufferAllocation(T item, ref Il2CppArrayBase<T> destination, ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LargeArrayBuilder<T>.NativeMethodInfoPtr_AddWithBufferAllocation_Private_Void_T_byref_Il2CppArrayBase_1_T_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr2;
			destination = ((intPtr5 == 0) ? null : new Il2CppArrayBase<T>(intPtr5));
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x0016B5BC File Offset: 0x001697BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425334, XrefRangeEnd = 1425345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppArrayBase<T> array, int arrayIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LargeArrayBuilder<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x0016B620 File Offset: 0x00169820
		[CallerCount(0)]
		public unsafe Il2CppArrayBase<T> GetBuffer(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LargeArrayBuilder<T>.NativeMethodInfoPtr_GetBuffer_Public_Il2CppArrayBase_1_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x0016B66C File Offset: 0x0016986C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425352, RefRangeEnd = 1425353, XrefRangeStart = 1425345, XrefRangeEnd = 1425352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LargeArrayBuilder<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x0016B6A8 File Offset: 0x001698A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425353, XrefRangeEnd = 1425354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryMove(out Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LargeArrayBuilder<T>.NativeMethodInfoPtr_TryMove_Public_Boolean_byref_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x0016B70C File Offset: 0x0016990C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425376, RefRangeEnd = 1425377, XrefRangeStart = 1425354, XrefRangeEnd = 1425376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllocateBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LargeArrayBuilder<T>.NativeMethodInfoPtr_AllocateBuffer_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x0001C39F File Offset: 0x0001A59F
		public LargeArrayBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x0001C3A8 File Offset: 0x0001A5A8
		public LargeArrayBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LargeArrayBuilder<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06004E3E RID: 20030 RVA: 0x0016B744 File Offset: 0x00169944
		// (set) Token: 0x06004E3F RID: 20031 RVA: 0x0001C3BA File Offset: 0x0001A5BA
		public unsafe int _maxCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LargeArrayBuilder<T>.NativeFieldInfoPtr__maxCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LargeArrayBuilder<T>.NativeFieldInfoPtr__maxCapacity)) = value;
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06004E40 RID: 20032 RVA: 0x0016B76C File Offset: 0x0016996C
		// (set) Token: 0x06004E41 RID: 20033 RVA: 0x0001C3D5 File Offset: 0x0001A5D5
		public unsafe Il2CppArrayBase<T> _first
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LargeArrayBuilder<T>.NativeFieldInfoPtr__first);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LargeArrayBuilder<T>.NativeFieldInfoPtr__first), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x0016B794 File Offset: 0x00169994
		// (set) Token: 0x06004E43 RID: 20035 RVA: 0x0001C3F4 File Offset: 0x0001A5F4
		public ArrayBuilder<Il2CppArrayBase<T>> _buffers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LargeArrayBuilder<T>.NativeFieldInfoPtr__buffers);
				return new ArrayBuilder<Il2CppArrayBase<T>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArrayBuilder<Il2CppArrayBase<T>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LargeArrayBuilder<T>.NativeFieldInfoPtr__buffers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ArrayBuilder<Il2CppArrayBase<T>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06004E44 RID: 20036 RVA: 0x0016B7C4 File Offset: 0x001699C4
		// (set) Token: 0x06004E45 RID: 20037 RVA: 0x0001C422 File Offset: 0x0001A622
		public unsafe Il2CppArrayBase<T> _current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LargeArrayBuilder<T>.NativeFieldInfoPtr__current);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LargeArrayBuilder<T>.NativeFieldInfoPtr__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06004E46 RID: 20038 RVA: 0x0016B7EC File Offset: 0x001699EC
		// (set) Token: 0x06004E47 RID: 20039 RVA: 0x0001C441 File Offset: 0x0001A641
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LargeArrayBuilder<T>.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LargeArrayBuilder<T>.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06004E48 RID: 20040 RVA: 0x0016B814 File Offset: 0x00169A14
		// (set) Token: 0x06004E49 RID: 20041 RVA: 0x0001C45C File Offset: 0x0001A65C
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LargeArrayBuilder<T>.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LargeArrayBuilder<T>.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x04003FEA RID: 16362
		private static readonly IntPtr NativeFieldInfoPtr__maxCapacity;

		// Token: 0x04003FEB RID: 16363
		private static readonly IntPtr NativeFieldInfoPtr__first;

		// Token: 0x04003FEC RID: 16364
		private static readonly IntPtr NativeFieldInfoPtr__buffers;

		// Token: 0x04003FED RID: 16365
		private static readonly IntPtr NativeFieldInfoPtr__current;

		// Token: 0x04003FEE RID: 16366
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x04003FEF RID: 16367
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04003FF0 RID: 16368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04003FF1 RID: 16369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003FF2 RID: 16370
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Void_IEnumerable_1_T_0;

		// Token: 0x04003FF3 RID: 16371
		private static readonly IntPtr NativeMethodInfoPtr_AddWithBufferAllocation_Private_Void_T_byref_Il2CppArrayBase_1_T_byref_Int32_0;

		// Token: 0x04003FF4 RID: 16372
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x04003FF5 RID: 16373
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffer_Public_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04003FF6 RID: 16374
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04003FF7 RID: 16375
		private static readonly IntPtr NativeMethodInfoPtr_TryMove_Public_Boolean_byref_Il2CppArrayBase_1_T_0;

		// Token: 0x04003FF8 RID: 16376
		private static readonly IntPtr NativeMethodInfoPtr_AllocateBuffer_Private_Void_0;
	}
}
