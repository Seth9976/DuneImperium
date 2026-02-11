using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001A0 RID: 416
	public class SparselyPopulatedArrayFragment<T> : Object where T : class
	{
		// Token: 0x06001B0B RID: 6923 RVA: 0x000A3CA0 File Offset: 0x000A1EA0
		// Note: this type is marked as 'beforefieldinit'.
		static SparselyPopulatedArrayFragment()
		{
			Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SparselyPopulatedArrayFragment`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr);
			SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr__elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, "_elements");
			SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr__freeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, "_freeCount");
			SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, "_next");
			SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr__prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, "_prev");
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100667973);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100667974);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Item_Internal_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100667975);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100667976);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Prev_Internal_get_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100667977);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_SafeAtomicRemove_Internal_T_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100667978);
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x000A3DD4 File Offset: 0x000A1FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352990, XrefRangeEnd = 1352991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArrayFragment(int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x000A3E1C File Offset: 0x000A201C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352991, XrefRangeEnd = 1352998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArrayFragment(int size, SparselyPopulatedArrayFragment<T> prev)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prev);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004E1 RID: 1249
		public unsafe T this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1352999, RefRangeEnd = 1353000, XrefRangeStart = 1352998, XrefRangeEnd = 1352999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Item_Internal_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x000A3EC0 File Offset: 0x000A20C0
		public unsafe int Length
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 320461, RefRangeEnd = 320500, XrefRangeStart = 320461, XrefRangeEnd = 320500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x000A3EFC File Offset: 0x000A20FC
		public unsafe SparselyPopulatedArrayFragment<T> Prev
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1353001, RefRangeEnd = 1353009, XrefRangeStart = 1353000, XrefRangeEnd = 1353001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Prev_Internal_get_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x000A3F3C File Offset: 0x000A213C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1353010, RefRangeEnd = 1353013, XrefRangeStart = 1353009, XrefRangeEnd = 1353010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T SafeAtomicRemove(int index, T expectedElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = expectedElement;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref expectedElement;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_SafeAtomicRemove_Internal_T_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00008ABD File Offset: 0x00006CBD
		public SparselyPopulatedArrayFragment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x000A3FCC File Offset: 0x000A21CC
		// (set) Token: 0x06001B14 RID: 6932 RVA: 0x00008AC6 File Offset: 0x00006CC6
		public unsafe Il2CppArrayBase<T> _elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr__elements);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr__elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x000A3FF4 File Offset: 0x000A21F4
		// (set) Token: 0x06001B16 RID: 6934 RVA: 0x00008AE5 File Offset: 0x00006CE5
		public unsafe int _freeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr__freeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr__freeCount)) = value;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x000A401C File Offset: 0x000A221C
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x00008B00 File Offset: 0x00006D00
		public unsafe SparselyPopulatedArrayFragment<T> _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x000A404C File Offset: 0x000A224C
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x00008B1F File Offset: 0x00006D1F
		public unsafe SparselyPopulatedArrayFragment<T> _prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr__prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr__prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeFieldInfoPtr__elements;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeFieldInfoPtr__freeCount;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeFieldInfoPtr__prev;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_SparselyPopulatedArrayFragment_1_T_0;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_T_Int32_0;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeMethodInfoPtr_get_Prev_Internal_get_SparselyPopulatedArrayFragment_1_T_0;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeMethodInfoPtr_SafeAtomicRemove_Internal_T_Int32_T_0;
	}
}
