using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.mathLib
{
	// Token: 0x02000073 RID: 115
	public sealed class CircularPartition<T> : ValueType
	{
		// Token: 0x06000635 RID: 1589 RVA: 0x00031F38 File Offset: 0x00030138
		// Note: this type is marked as 'beforefieldinit'.
		static CircularPartition()
		{
			Il2CppClassPointerStore<CircularPartition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.mathLib", "CircularPartition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircularPartition<T>>.NativeClassPtr);
			CircularPartition<T>.NativeFieldInfoPtr_PartitionedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularPartition<T>>.NativeClassPtr, "PartitionedInfo");
			CircularPartition<T>.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AngleRadians_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularPartition<T>>.NativeClassPtr, 100664577);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00031FCC File Offset: 0x000301CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CircularPartition(Dictionary<AngleRadians, T> partitionedInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircularPartition<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(partitionedInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularPartition<T>.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AngleRadians_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00004928 File Offset: 0x00002B28
		public CircularPartition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00004931 File Offset: 0x00002B31
		public CircularPartition()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircularPartition<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0003201C File Offset: 0x0003021C
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x00004943 File Offset: 0x00002B43
		public unsafe Dictionary<AngleRadians, T> PartitionedInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularPartition<T>.NativeFieldInfoPtr_PartitionedInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AngleRadians, T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularPartition<T>.NativeFieldInfoPtr_PartitionedInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_PartitionedInfo;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AngleRadians_T_0;
	}
}
