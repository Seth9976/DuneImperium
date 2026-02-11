using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine
{
	// Token: 0x02000106 RID: 262
	public sealed class TransformDispatchData : ValueType
	{
		// Token: 0x060015F2 RID: 5618 RVA: 0x0006B294 File Offset: 0x00069494
		// Note: this type is marked as 'beforefieldinit'.
		static TransformDispatchData()
		{
			Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TransformDispatchData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr);
			TransformDispatchData.NativeFieldInfoPtr_transformedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, "transformedID");
			TransformDispatchData.NativeFieldInfoPtr_parentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, "parentID");
			TransformDispatchData.NativeFieldInfoPtr_localToWorldMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, "localToWorldMatrices");
			TransformDispatchData.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, "positions");
			TransformDispatchData.NativeFieldInfoPtr_rotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, "rotations");
			TransformDispatchData.NativeFieldInfoPtr_scales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, "scales");
			TransformDispatchData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, 100666371);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x0006B350 File Offset: 0x00069550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659913, XrefRangeEnd = 659929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformDispatchData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00008866 File Offset: 0x00006A66
		public TransformDispatchData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x0000886F File Offset: 0x00006A6F
		public TransformDispatchData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr))
		{
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x0006B388 File Offset: 0x00069588
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x00008881 File Offset: 0x00006A81
		public Unity.Collections.NativeArray<int> transformedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_transformedID);
				return new Unity.Collections.NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_transformedID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x0006B3B8 File Offset: 0x000695B8
		// (set) Token: 0x060015F9 RID: 5625 RVA: 0x000088AF File Offset: 0x00006AAF
		public Unity.Collections.NativeArray<int> parentID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_parentID);
				return new Unity.Collections.NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_parentID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x0006B3E8 File Offset: 0x000695E8
		// (set) Token: 0x060015FB RID: 5627 RVA: 0x000088DD File Offset: 0x00006ADD
		public Unity.Collections.NativeArray<Matrix4x4> localToWorldMatrices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_localToWorldMatrices);
				return new Unity.Collections.NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<Matrix4x4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_localToWorldMatrices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<Matrix4x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x0006B418 File Offset: 0x00069618
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x0000890B File Offset: 0x00006B0B
		public Unity.Collections.NativeArray<Vector3> positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_positions);
				return new Unity.Collections.NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<Vector3>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_positions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<Vector3>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x0006B448 File Offset: 0x00069648
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x00008939 File Offset: 0x00006B39
		public Unity.Collections.NativeArray<Quaternion> rotations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_rotations);
				return new Unity.Collections.NativeArray<Quaternion>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<Quaternion>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_rotations), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<Quaternion>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x0006B478 File Offset: 0x00069678
		// (set) Token: 0x06001601 RID: 5633 RVA: 0x00008967 File Offset: 0x00006B67
		public Unity.Collections.NativeArray<Vector3> scales
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_scales);
				return new Unity.Collections.NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<Vector3>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_scales), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<Vector3>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeFieldInfoPtr_transformedID;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeFieldInfoPtr_parentID;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeFieldInfoPtr_localToWorldMatrices;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeFieldInfoPtr_rotations;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeFieldInfoPtr_scales;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
