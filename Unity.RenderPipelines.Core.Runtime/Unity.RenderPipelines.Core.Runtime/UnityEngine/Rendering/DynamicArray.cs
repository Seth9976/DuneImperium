using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200003F RID: 63
	public class DynamicArray<T> : Object where T : new()
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x0001FF80 File Offset: 0x0001E180
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicArray()
		{
			Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DynamicArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr);
			DynamicArray<T>.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, "m_Array");
			DynamicArray<T>.NativeFieldInfoPtr__size_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, "<size>k__BackingField");
			DynamicArray<T>.NativeMethodInfoPtr_get_size_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663926);
			DynamicArray<T>.NativeMethodInfoPtr_set_size_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663927);
			DynamicArray<T>.NativeMethodInfoPtr_get_capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663928);
			DynamicArray<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663929);
			DynamicArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663930);
			DynamicArray<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663931);
			DynamicArray<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663932);
			DynamicArray<T>.NativeMethodInfoPtr_Add_Public_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663933);
			DynamicArray<T>.NativeMethodInfoPtr_AddRange_Public_Void_DynamicArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663934);
			DynamicArray<T>.NativeMethodInfoPtr_Remove_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663935);
			DynamicArray<T>.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663936);
			DynamicArray<T>.NativeMethodInfoPtr_RemoveRange_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663937);
			DynamicArray<T>.NativeMethodInfoPtr_FindIndex_Public_Int32_Int32_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663938);
			DynamicArray<T>.NativeMethodInfoPtr_IndexOf_Public_Int32_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663939);
			DynamicArray<T>.NativeMethodInfoPtr_IndexOf_Public_Int32_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663940);
			DynamicArray<T>.NativeMethodInfoPtr_IndexOf_Public_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663941);
			DynamicArray<T>.NativeMethodInfoPtr_Resize_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663942);
			DynamicArray<T>.NativeMethodInfoPtr_Reserve_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663943);
			DynamicArray<T>.NativeMethodInfoPtr_get_Item_Public_get_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663944);
			DynamicArray<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Il2CppArrayBase_1_T_DynamicArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663945);
			DynamicArray<T>.NativeMethodInfoPtr_GetEnumerator_Public_Iterator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663946);
			DynamicArray<T>.NativeMethodInfoPtr_SubRange_Public_RangeEnumerable_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663947);
			DynamicArray<T>.NativeMethodInfoPtr_BumpVersion_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, 100663948);
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x000201E0 File Offset: 0x0001E3E0
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x0002021C File Offset: 0x0001E41C
		public unsafe int size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_get_size_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_set_size_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x0002025C File Offset: 0x0001E45C
		public unsafe int capacity
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 320461, RefRangeEnd = 320500, XrefRangeStart = 320461, XrefRangeEnd = 320500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_get_capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00020298 File Offset: 0x0001E498
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 959656, RefRangeEnd = 959670, XrefRangeStart = 959652, XrefRangeEnd = 959656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000202D4 File Offset: 0x0001E4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959670, XrefRangeEnd = 959674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicArray(int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0002031C File Offset: 0x0001E51C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 959674, RefRangeEnd = 959685, XrefRangeStart = 959674, XrefRangeEnd = 959674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00020350 File Offset: 0x0001E550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959685, XrefRangeEnd = 959686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000203D4 File Offset: 0x0001E5D4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 959691, RefRangeEnd = 959702, XrefRangeStart = 959686, XrefRangeEnd = 959691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add([In] ref T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_Add_Public_Int32_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0002043C File Offset: 0x0001E63C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 959708, RefRangeEnd = 959715, XrefRangeStart = 959702, XrefRangeEnd = 959708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(DynamicArray<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_AddRange_Public_Void_DynamicArray_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00020480 File Offset: 0x0001E680
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 959716, RefRangeEnd = 959724, XrefRangeStart = 959715, XrefRangeEnd = 959716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_Remove_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00020504 File Offset: 0x0001E704
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 959725, RefRangeEnd = 959727, XrefRangeStart = 959724, XrefRangeEnd = 959725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00020544 File Offset: 0x0001E744
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 959728, RefRangeEnd = 959732, XrefRangeStart = 959727, XrefRangeEnd = 959728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRange(int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_RemoveRange_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00020590 File Offset: 0x0001E790
		[CallerCount(0)]
		public unsafe int FindIndex(int startIndex, int count, Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_FindIndex_Public_Int32_Int32_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000205FC File Offset: 0x0001E7FC
		[CallerCount(0)]
		public unsafe int IndexOf(T item, int index, int count)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_IndexOf_Public_Int32_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0002069C File Offset: 0x0001E89C
		[CallerCount(0)]
		public unsafe int IndexOf(T item, int index)
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
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_IndexOf_Public_Int32_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00020730 File Offset: 0x0001E930
		[CallerCount(0)]
		public unsafe int IndexOf(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_IndexOf_Public_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000207B4 File Offset: 0x0001E9B4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 959733, RefRangeEnd = 959741, XrefRangeStart = 959732, XrefRangeEnd = 959733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(int newSize, bool keepContent = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepContent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_Resize_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00020800 File Offset: 0x0001EA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959741, XrefRangeEnd = 959744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reserve(int newCapacity, bool keepContent = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newCapacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepContent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_Reserve_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000169 RID: 361
		public unsafe ref T this[int index]
		{
			[CallerCount(57)]
			[CachedScanResults(RefRangeStart = 959744, RefRangeEnd = 959801, XrefRangeStart = 959744, XrefRangeEnd = 959744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_get_Item_Public_get_byref_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0002088C File Offset: 0x0001EA8C
		[CallerCount(0)]
		public unsafe static implicit operator Il2CppArrayBase<T>(DynamicArray<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Il2CppArrayBase_1_T_DynamicArray_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000208C8 File Offset: 0x0001EAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959801, XrefRangeEnd = 959802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicArray<T>.Iterator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_GetEnumerator_Public_Iterator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new DynamicArray<T>.Iterator(intPtr);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00020900 File Offset: 0x0001EB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959802, XrefRangeEnd = 959804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicArray<T>.RangeEnumerable SubRange(int first, int numItems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numItems;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_SubRange_Public_RangeEnumerable_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new DynamicArray<T>.RangeEnumerable(intPtr);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00020954 File Offset: 0x0001EB54
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BumpVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.NativeMethodInfoPtr_BumpVersion_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00004082 File Offset: 0x00002282
		public DynamicArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00020988 File Offset: 0x0001EB88
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x0000408B File Offset: 0x0000228B
		public unsafe Il2CppArrayBase<T> m_Array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.NativeFieldInfoPtr_m_Array);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.NativeFieldInfoPtr_m_Array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x000209B0 File Offset: 0x0001EBB0
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x000040AA File Offset: 0x000022AA
		public unsafe int _size_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.NativeFieldInfoPtr__size_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.NativeFieldInfoPtr__size_k__BackingField)) = value;
			}
		}

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeFieldInfoPtr_m_Array;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeFieldInfoPtr__size_k__BackingField;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Int32_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Private_set_Void_Int32_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_get_capacity_Public_get_Int32_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_byref_T_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Void_DynamicArray_1_T_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_T_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRange_Public_Void_Int32_Int32_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Int32_Int32_Int32_Predicate_1_T_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_T_Int32_Int32_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_T_Int32_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_T_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_Boolean_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_Reserve_Public_Void_Int32_Boolean_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_T_Int32_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Il2CppArrayBase_1_T_DynamicArray_1_T_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Iterator_T_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_SubRange_Public_RangeEnumerable_T_Int32_Int32_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_BumpVersion_Internal_Void_0;

		// Token: 0x02000177 RID: 375
		public sealed class Iterator : ValueType
		{
			// Token: 0x06001617 RID: 5655 RVA: 0x0005FE34 File Offset: 0x0005E034
			// Note: this type is marked as 'beforefieldinit'.
			static Iterator()
			{
				Il2CppClassPointerStore<DynamicArray<T>.Iterator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, "Iterator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicArray<T>.Iterator>.NativeClassPtr);
				DynamicArray<T>.Iterator.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicArray<T>.Iterator>.NativeClassPtr, "owner");
				DynamicArray<T>.Iterator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicArray<T>.Iterator>.NativeClassPtr, "index");
				DynamicArray<T>.Iterator.NativeMethodInfoPtr__ctor_Public_Void_DynamicArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>.Iterator>.NativeClassPtr, 100663949);
				DynamicArray<T>.Iterator.NativeMethodInfoPtr_get_Current_Public_get_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>.Iterator>.NativeClassPtr, 100663950);
				DynamicArray<T>.Iterator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>.Iterator>.NativeClassPtr, 100663951);
				DynamicArray<T>.Iterator.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>.Iterator>.NativeClassPtr, 100663952);
			}

			// Token: 0x06001618 RID: 5656 RVA: 0x0005FF14 File Offset: 0x0005E114
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 959642, RefRangeEnd = 959643, XrefRangeStart = 959641, XrefRangeEnd = 959642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Iterator(DynamicArray<T> setOwner)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicArray<T>.Iterator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(setOwner);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.Iterator.NativeMethodInfoPtr__ctor_Public_Void_DynamicArray_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x06001619 RID: 5657 RVA: 0x0005FF64 File Offset: 0x0005E164
			public unsafe ref T Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959643, XrefRangeEnd = 959649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.Iterator.NativeMethodInfoPtr_get_Current_Public_get_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}

			// Token: 0x0600161A RID: 5658 RVA: 0x0005FF9C File Offset: 0x0005E19C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959649, XrefRangeEnd = 959650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.Iterator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600161B RID: 5659 RVA: 0x0005FFE0 File Offset: 0x0005E1E0
			[CallerCount(0)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.Iterator.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600161C RID: 5660 RVA: 0x0000B208 File Offset: 0x00009408
			public Iterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600161D RID: 5661 RVA: 0x0000B211 File Offset: 0x00009411
			public Iterator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicArray<T>.Iterator>.NativeClassPtr))
			{
			}

			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x0600161E RID: 5662 RVA: 0x00060018 File Offset: 0x0005E218
			// (set) Token: 0x0600161F RID: 5663 RVA: 0x0000B223 File Offset: 0x00009423
			public unsafe DynamicArray<T> owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.Iterator.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.Iterator.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x06001620 RID: 5664 RVA: 0x00060048 File Offset: 0x0005E248
			// (set) Token: 0x06001621 RID: 5665 RVA: 0x0000B242 File Offset: 0x00009442
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.Iterator.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.Iterator.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x04001020 RID: 4128
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x04001021 RID: 4129
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04001022 RID: 4130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DynamicArray_1_T_0;

			// Token: 0x04001023 RID: 4131
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_byref_T_0;

			// Token: 0x04001024 RID: 4132
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

			// Token: 0x04001025 RID: 4133
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
		}

		// Token: 0x02000178 RID: 376
		public sealed class RangeEnumerable : ValueType
		{
			// Token: 0x06001622 RID: 5666 RVA: 0x00060070 File Offset: 0x0005E270
			// Note: this type is marked as 'beforefieldinit'.
			static RangeEnumerable()
			{
				Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicArray<T>>.NativeClassPtr, "RangeEnumerable"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable>.NativeClassPtr);
				DynamicArray<T>.RangeEnumerable.NativeFieldInfoPtr_iterator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable>.NativeClassPtr, "iterator");
				DynamicArray<T>.RangeEnumerable.NativeMethodInfoPtr_GetEnumerator_Public_RangeIterator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable>.NativeClassPtr, 100663953);
			}

			// Token: 0x06001623 RID: 5667 RVA: 0x00060100 File Offset: 0x0005E300
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 681416, RefRangeEnd = 681465, XrefRangeStart = 681416, XrefRangeEnd = 681465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicArray<T>.RangeEnumerable.RangeIterator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.RangeEnumerable.NativeMethodInfoPtr_GetEnumerator_Public_RangeIterator_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DynamicArray<T>.RangeEnumerable.RangeIterator(intPtr);
			}

			// Token: 0x06001624 RID: 5668 RVA: 0x0000B25D File Offset: 0x0000945D
			public RangeEnumerable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001625 RID: 5669 RVA: 0x0000B266 File Offset: 0x00009466
			public RangeEnumerable()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable>.NativeClassPtr))
			{
			}

			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x06001626 RID: 5670 RVA: 0x0006013C File Offset: 0x0005E33C
			// (set) Token: 0x06001627 RID: 5671 RVA: 0x0000B278 File Offset: 0x00009478
			public DynamicArray<T>.RangeEnumerable.RangeIterator iterator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.RangeEnumerable.NativeFieldInfoPtr_iterator);
					return new DynamicArray<T>.RangeEnumerable.RangeIterator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.RangeEnumerable.NativeFieldInfoPtr_iterator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001026 RID: 4134
			private static readonly IntPtr NativeFieldInfoPtr_iterator;

			// Token: 0x04001027 RID: 4135
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_RangeIterator_T_0;

			// Token: 0x02000227 RID: 551
			public sealed class RangeIterator : ValueType
			{
				// Token: 0x06001B82 RID: 7042 RVA: 0x00070034 File Offset: 0x0006E234
				// Note: this type is marked as 'beforefieldinit'.
				static RangeIterator()
				{
					Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable>.NativeClassPtr, "RangeIterator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr);
					DynamicArray<T>.RangeEnumerable.RangeIterator.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr, "owner");
					DynamicArray<T>.RangeEnumerable.RangeIterator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr, "index");
					DynamicArray<T>.RangeEnumerable.RangeIterator.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr, "first");
					DynamicArray<T>.RangeEnumerable.RangeIterator.NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr, "last");
					DynamicArray<T>.RangeEnumerable.RangeIterator.NativeMethodInfoPtr__ctor_Public_Void_DynamicArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr, 100663954);
					DynamicArray<T>.RangeEnumerable.RangeIterator.NativeMethodInfoPtr_get_Current_Public_get_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr, 100663955);
					DynamicArray<T>.RangeEnumerable.RangeIterator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr, 100663956);
					DynamicArray<T>.RangeEnumerable.RangeIterator.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr, 100663957);
				}

				// Token: 0x06001B83 RID: 7043 RVA: 0x0007013C File Offset: 0x0006E33C
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 959651, RefRangeEnd = 959652, XrefRangeStart = 959650, XrefRangeEnd = 959651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe RangeIterator(DynamicArray<T> setOwner, int first, int numItems)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(setOwner);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numItems;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.RangeEnumerable.RangeIterator.NativeMethodInfoPtr__ctor_Public_Void_DynamicArray_1_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170007C1 RID: 1985
				// (get) Token: 0x06001B84 RID: 7044 RVA: 0x000701A8 File Offset: 0x0006E3A8
				public unsafe ref T Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.RangeEnumerable.RangeIterator.NativeMethodInfoPtr_get_Current_Public_get_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return intPtr;
					}
				}

				// Token: 0x06001B85 RID: 7045 RVA: 0x000701E0 File Offset: 0x0006E3E0
				[CallerCount(0)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.RangeEnumerable.RangeIterator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001B86 RID: 7046 RVA: 0x00070224 File Offset: 0x0006E424
				[CallerCount(0)]
				public unsafe void Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicArray<T>.RangeEnumerable.RangeIterator.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001B87 RID: 7047 RVA: 0x0000DC36 File Offset: 0x0000BE36
				public RangeIterator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001B88 RID: 7048 RVA: 0x0000DC3F File Offset: 0x0000BE3F
				public RangeIterator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicArray<T>.RangeEnumerable.RangeIterator>.NativeClassPtr))
				{
				}

				// Token: 0x170007BD RID: 1981
				// (get) Token: 0x06001B89 RID: 7049 RVA: 0x0007025C File Offset: 0x0006E45C
				// (set) Token: 0x06001B8A RID: 7050 RVA: 0x0000DC51 File Offset: 0x0000BE51
				public unsafe DynamicArray<T> owner
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.RangeEnumerable.RangeIterator.NativeFieldInfoPtr_owner);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicArray<T>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.RangeEnumerable.RangeIterator.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170007BE RID: 1982
				// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0007028C File Offset: 0x0006E48C
				// (set) Token: 0x06001B8C RID: 7052 RVA: 0x0000DC70 File Offset: 0x0000BE70
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.RangeEnumerable.RangeIterator.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.RangeEnumerable.RangeIterator.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x170007BF RID: 1983
				// (get) Token: 0x06001B8D RID: 7053 RVA: 0x000702B4 File Offset: 0x0006E4B4
				// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0000DC8B File Offset: 0x0000BE8B
				public unsafe int first
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.RangeEnumerable.RangeIterator.NativeFieldInfoPtr_first);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.RangeEnumerable.RangeIterator.NativeFieldInfoPtr_first)) = value;
					}
				}

				// Token: 0x170007C0 RID: 1984
				// (get) Token: 0x06001B8F RID: 7055 RVA: 0x000702DC File Offset: 0x0006E4DC
				// (set) Token: 0x06001B90 RID: 7056 RVA: 0x0000DCA6 File Offset: 0x0000BEA6
				public unsafe int last
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.RangeEnumerable.RangeIterator.NativeFieldInfoPtr_last);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicArray<T>.RangeEnumerable.RangeIterator.NativeFieldInfoPtr_last)) = value;
					}
				}

				// Token: 0x040013F9 RID: 5113
				private static readonly IntPtr NativeFieldInfoPtr_owner;

				// Token: 0x040013FA RID: 5114
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x040013FB RID: 5115
				private static readonly IntPtr NativeFieldInfoPtr_first;

				// Token: 0x040013FC RID: 5116
				private static readonly IntPtr NativeFieldInfoPtr_last;

				// Token: 0x040013FD RID: 5117
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DynamicArray_1_T_Int32_Int32_0;

				// Token: 0x040013FE RID: 5118
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_byref_T_0;

				// Token: 0x040013FF RID: 5119
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

				// Token: 0x04001400 RID: 5120
				private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
			}
		}
	}
}
