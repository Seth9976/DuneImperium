using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200004A RID: 74
	public sealed class ListBuffer<T> : ValueType where T : new()
	{
		// Token: 0x06000591 RID: 1425 RVA: 0x000222B4 File Offset: 0x000204B4
		// Note: this type is marked as 'beforefieldinit'.
		static ListBuffer()
		{
			Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ListBuffer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr);
			ListBuffer<T>.NativeFieldInfoPtr_m_BufferPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, "m_BufferPtr");
			ListBuffer<T>.NativeFieldInfoPtr_m_Capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, "m_Capacity");
			ListBuffer<T>.NativeFieldInfoPtr_m_CountPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, "m_CountPtr");
			ListBuffer<T>.NativeMethodInfoPtr_get_BufferPtr_Internal_get_ptr_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, 100664005);
			ListBuffer<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, 100664006);
			ListBuffer<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, 100664007);
			ListBuffer<T>.NativeMethodInfoPtr__ctor_Public_Void_ptr_T_ptr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, 100664008);
			ListBuffer<T>.NativeMethodInfoPtr_get_Item_Public_get_byref_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, 100664009);
			ListBuffer<T>.NativeMethodInfoPtr_GetUnchecked_Public_byref_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, 100664010);
			ListBuffer<T>.NativeMethodInfoPtr_TryAdd_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, 100664011);
			ListBuffer<T>.NativeMethodInfoPtr_CopyTo_Public_Void_ptr_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, 100664012);
			ListBuffer<T>.NativeMethodInfoPtr_TryCopyTo_Public_Boolean_ListBuffer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, 100664013);
			ListBuffer<T>.NativeMethodInfoPtr_TryCopyFrom_Public_Boolean_ptr_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr, 100664014);
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00022424 File Offset: 0x00020624
		public unsafe T* BufferPtr
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBuffer<T>.NativeMethodInfoPtr_get_BufferPtr_Internal_get_ptr_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0002245C File Offset: 0x0002065C
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBuffer<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x000224A0 File Offset: 0x000206A0
		public unsafe int Capacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBuffer<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000224E4 File Offset: 0x000206E4
		[CallerCount(0)]
		public unsafe ListBuffer(T* bufferPtr, int* countPtr, int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bufferPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = countPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBuffer<T>.NativeMethodInfoPtr__ctor_Public_Void_ptr_T_ptr_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000195 RID: 405
		public unsafe ref T this[[In] ref int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960175, XrefRangeEnd = 960178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBuffer<T>.NativeMethodInfoPtr_get_Item_Public_get_byref_T_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00022590 File Offset: 0x00020790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960178, XrefRangeEnd = 960179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ref T GetUnchecked([In] ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBuffer<T>.NativeMethodInfoPtr_GetUnchecked_Public_byref_T_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000225D4 File Offset: 0x000207D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960179, XrefRangeEnd = 960191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAdd([In] ref T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListBuffer<T>.NativeMethodInfoPtr_TryAdd_Public_Boolean_byref_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00022640 File Offset: 0x00020840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960191, XrefRangeEnd = 960195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(T* dstBuffer, int startDstIndex, int copyCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dstBuffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDstIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBuffer<T>.NativeMethodInfoPtr_CopyTo_Public_Void_ptr_T_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000226A0 File Offset: 0x000208A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960195, XrefRangeEnd = 960210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryCopyTo(ListBuffer<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBuffer<T>.NativeMethodInfoPtr_TryCopyTo_Public_Boolean_ListBuffer_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000226F8 File Offset: 0x000208F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960210, XrefRangeEnd = 960218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryCopyFrom(T* srcPtr, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = srcPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBuffer<T>.NativeMethodInfoPtr_TryCopyFrom_Public_Boolean_ptr_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00004443 File Offset: 0x00002643
		public ListBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0000444C File Offset: 0x0000264C
		public ListBuffer()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListBuffer<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00022754 File Offset: 0x00020954
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x0000445E File Offset: 0x0000265E
		public unsafe T* m_BufferPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListBuffer<T>.NativeFieldInfoPtr_m_BufferPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListBuffer<T>.NativeFieldInfoPtr_m_BufferPtr)) = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00022778 File Offset: 0x00020978
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x00004479 File Offset: 0x00002679
		public unsafe int m_Capacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListBuffer<T>.NativeFieldInfoPtr_m_Capacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListBuffer<T>.NativeFieldInfoPtr_m_Capacity)) = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x000227A0 File Offset: 0x000209A0
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00004494 File Offset: 0x00002694
		public unsafe int* m_CountPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListBuffer<T>.NativeFieldInfoPtr_m_CountPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListBuffer<T>.NativeFieldInfoPtr_m_CountPtr)) = value;
			}
		}

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferPtr;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_m_Capacity;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr_m_CountPtr;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_get_BufferPtr_Internal_get_ptr_T_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_T_ptr_Int32_Int32_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_T_byref_Int32_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_GetUnchecked_Public_byref_T_byref_Int32_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_TryAdd_Public_Boolean_byref_T_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_ptr_T_Int32_Int32_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_TryCopyTo_Public_Boolean_ListBuffer_1_T_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_TryCopyFrom_Public_Boolean_ptr_T_Int32_0;
	}
}
