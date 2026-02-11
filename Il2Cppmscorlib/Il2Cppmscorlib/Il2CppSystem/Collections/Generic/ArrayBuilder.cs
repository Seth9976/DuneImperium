using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004F1 RID: 1265
	public sealed class ArrayBuilder<T> : ValueType
	{
		// Token: 0x06004E21 RID: 20001 RVA: 0x0016AE3C File Offset: 0x0016903C
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayBuilder()
		{
			Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ArrayBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr);
			ArrayBuilder<T>.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, "_array");
			ArrayBuilder<T>.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, "_count");
			ArrayBuilder<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, 100675055);
			ArrayBuilder<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, 100675056);
			ArrayBuilder<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, 100675057);
			ArrayBuilder<T>.NativeMethodInfoPtr_Add_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, 100675058);
			ArrayBuilder<T>.NativeMethodInfoPtr_UncheckedAdd_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, 100675059);
			ArrayBuilder<T>.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr, 100675060);
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06004E22 RID: 20002 RVA: 0x0016AF48 File Offset: 0x00169148
		public unsafe int Capacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayBuilder<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06004E23 RID: 20003 RVA: 0x0016AF8C File Offset: 0x0016918C
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayBuilder<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001423 RID: 5155
		public unsafe T this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1425204, RefRangeEnd = 1425205, XrefRangeStart = 1425204, XrefRangeEnd = 1425204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayBuilder<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x0016B01C File Offset: 0x0016921C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425228, RefRangeEnd = 1425229, XrefRangeStart = 1425205, XrefRangeEnd = 1425228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArrayBuilder<T>.NativeMethodInfoPtr_Add_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x0016B09C File Offset: 0x0016929C
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1031280, RefRangeEnd = 1031310, XrefRangeStart = 1031280, XrefRangeEnd = 1031310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06004E27 RID: 20007 RVA: 0x0016B11C File Offset: 0x0016931C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425229, XrefRangeEnd = 1425243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureCapacity(int minimum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minimum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayBuilder<T>.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E28 RID: 20008 RVA: 0x0001C341 File Offset: 0x0001A541
		public ArrayBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x0001C34A File Offset: 0x0001A54A
		public ArrayBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayBuilder<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x0016B160 File Offset: 0x00169360
		// (set) Token: 0x06004E2B RID: 20011 RVA: 0x0001C35C File Offset: 0x0001A55C
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

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06004E2C RID: 20012 RVA: 0x0016B188 File Offset: 0x00169388
		// (set) Token: 0x06004E2D RID: 20013 RVA: 0x0001C37B File Offset: 0x0001A57B
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

		// Token: 0x04003FE0 RID: 16352
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04003FE1 RID: 16353
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04003FE2 RID: 16354
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x04003FE3 RID: 16355
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04003FE4 RID: 16356
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		// Token: 0x04003FE5 RID: 16357
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T_0;

		// Token: 0x04003FE6 RID: 16358
		private static readonly IntPtr NativeMethodInfoPtr_UncheckedAdd_Public_Void_T_0;

		// Token: 0x04003FE7 RID: 16359
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0;
	}
}
