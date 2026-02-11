using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200019F RID: 415
	public sealed class SparselyPopulatedArrayAddInfo<T> : ValueType where T : class
	{
		// Token: 0x06001B01 RID: 6913 RVA: 0x000A3A90 File Offset: 0x000A1C90
		// Note: this type is marked as 'beforefieldinit'.
		static SparselyPopulatedArrayAddInfo()
		{
			Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SparselyPopulatedArrayAddInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr);
			SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, "_source");
			SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, "_index");
			SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr__ctor_Internal_Void_SparselyPopulatedArrayFragment_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, 100667970);
			SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr_get_Source_Internal_get_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, 100667971);
			SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr_get_Index_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, 100667972);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x000A3B60 File Offset: 0x000A1D60
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 336243, RefRangeEnd = 336283, XrefRangeStart = 336243, XrefRangeEnd = 336283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArrayAddInfo(SparselyPopulatedArrayFragment<T> source, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr__ctor_Internal_Void_SparselyPopulatedArrayFragment_1_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x000A3BC0 File Offset: 0x000A1DC0
		public unsafe SparselyPopulatedArrayFragment<T> Source
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr_get_Source_Internal_get_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x000A3C04 File Offset: 0x000A1E04
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr_get_Index_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00008A68 File Offset: 0x00006C68
		public SparselyPopulatedArrayAddInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00008A71 File Offset: 0x00006C71
		public SparselyPopulatedArrayAddInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x000A3C48 File Offset: 0x000A1E48
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x00008A83 File Offset: 0x00006C83
		public unsafe SparselyPopulatedArrayFragment<T> _source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr__source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr__source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x000A3C78 File Offset: 0x000A1E78
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x00008AA2 File Offset: 0x00006CA2
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeFieldInfoPtr__source;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SparselyPopulatedArrayFragment_1_T_Int32_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Internal_get_SparselyPopulatedArrayFragment_1_T_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Internal_get_Int32_0;
	}
}
