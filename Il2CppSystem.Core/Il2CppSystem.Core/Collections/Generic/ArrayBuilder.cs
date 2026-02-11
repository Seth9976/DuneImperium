using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200012E RID: 302
	[DefaultMember("Item")]
	public sealed class ArrayBuilder<T> : ValueType
	{
		// Token: 0x060011AF RID: 4527 RVA: 0x0005C94C File Offset: 0x0005AB4C
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayBuilder()
		{
			Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Collections.Generic", "ArrayBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr);
			ArrayBuilder<T>.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, "_array");
			ArrayBuilder<T>.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, "_count");
			ArrayBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, 100666661);
			ArrayBuilder<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, 100666662);
			ArrayBuilder<T>.NativeMethodInfoPtr_UncheckedAdd_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, 100666663);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0005CA1C File Offset: 0x0005AC1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1031259, RefRangeEnd = 1031264, XrefRangeStart = 1031255, XrefRangeEnd = 1031259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayBuilder(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0005CA68 File Offset: 0x0005AC68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1031268, RefRangeEnd = 1031269, XrefRangeStart = 1031264, XrefRangeEnd = 1031268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayBuilder<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0005CAA4 File Offset: 0x0005ACA4
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1031280, RefRangeEnd = 1031310, XrefRangeStart = 1031269, XrefRangeEnd = 1031280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UncheckedAdd(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayBuilder<T>.NativeMethodInfoPtr_UncheckedAdd_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00007591 File Offset: 0x00005791
		public ArrayBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0000759A File Offset: 0x0000579A
		public ArrayBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x0005CB24 File Offset: 0x0005AD24
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x000075AC File Offset: 0x000057AC
		public unsafe Il2CppArrayBase<T> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayBuilder<T>.NativeFieldInfoPtr__array);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayBuilder<T>.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x0005CB4C File Offset: 0x0005AD4C
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x000075CB File Offset: 0x000057CB
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayBuilder<T>.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayBuilder<T>.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_UncheckedAdd_Public_Void_T_0;
	}
}
