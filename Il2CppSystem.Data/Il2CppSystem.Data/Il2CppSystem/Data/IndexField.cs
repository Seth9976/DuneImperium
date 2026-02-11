using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000075 RID: 117
	public sealed class IndexField : ValueType
	{
		// Token: 0x06000AA4 RID: 2724 RVA: 0x00036F64 File Offset: 0x00035164
		// Note: this type is marked as 'beforefieldinit'.
		static IndexField()
		{
			Il2CppClassPointerStore<IndexField>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "IndexField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexField>.NativeClassPtr);
			IndexField.NativeFieldInfoPtr_Column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexField>.NativeClassPtr, "Column");
			IndexField.NativeFieldInfoPtr_IsDescending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexField>.NativeClassPtr, "IsDescending");
			IndexField.NativeMethodInfoPtr__ctor_Internal_Void_DataColumn_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexField>.NativeClassPtr, 100665058);
			IndexField.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IndexField_IndexField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexField>.NativeClassPtr, 100665059);
			IndexField.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexField>.NativeClassPtr, 100665060);
			IndexField.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexField>.NativeClassPtr, 100665061);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0003700C File Offset: 0x0003520C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 906460, RefRangeEnd = 906466, XrefRangeStart = 906459, XrefRangeEnd = 906460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexField(DataColumn column, bool isDescending)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexField>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDescending;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexField.NativeMethodInfoPtr__ctor_Internal_Void_DataColumn_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0003706C File Offset: 0x0003526C
		[CallerCount(0)]
		public unsafe static bool operator ==(IndexField if1, IndexField if2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(if1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(if2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexField.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IndexField_IndexField_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000370CC File Offset: 0x000352CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906466, XrefRangeEnd = 906469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexField.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00037120 File Offset: 0x00035320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906469, XrefRangeEnd = 906473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexField.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00005340 File Offset: 0x00003540
		public IndexField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00005349 File Offset: 0x00003549
		public IndexField()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexField>.NativeClassPtr))
		{
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00037164 File Offset: 0x00035364
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0000535B File Offset: 0x0000355B
		public unsafe DataColumn Column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexField.NativeFieldInfoPtr_Column);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexField.NativeFieldInfoPtr_Column), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00037194 File Offset: 0x00035394
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0000537A File Offset: 0x0000357A
		public unsafe bool IsDescending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexField.NativeFieldInfoPtr_IsDescending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexField.NativeFieldInfoPtr_IsDescending)) = value;
			}
		}

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr_Column;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr_IsDescending;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataColumn_Boolean_0;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IndexField_IndexField_0;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
