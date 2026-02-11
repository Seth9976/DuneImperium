using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x02000225 RID: 549
	public sealed class BatchCullingContext : ValueType
	{
		// Token: 0x060024AA RID: 9386 RVA: 0x0009D8FC File Offset: 0x0009BAFC
		// Note: this type is marked as 'beforefieldinit'.
		static BatchCullingContext()
		{
			Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchCullingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr);
			BatchCullingContext.NativeFieldInfoPtr_cullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingPlanes");
			BatchCullingContext.NativeFieldInfoPtr_cullingSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingSplits");
			BatchCullingContext.NativeFieldInfoPtr_lodParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "lodParameters");
			BatchCullingContext.NativeFieldInfoPtr_localToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "localToWorldMatrix");
			BatchCullingContext.NativeFieldInfoPtr_viewType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "viewType");
			BatchCullingContext.NativeFieldInfoPtr_projectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "projectionType");
			BatchCullingContext.NativeFieldInfoPtr_cullingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingFlags");
			BatchCullingContext.NativeFieldInfoPtr_viewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "viewID");
			BatchCullingContext.NativeFieldInfoPtr_cullingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingLayerMask");
			BatchCullingContext.NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "sceneCullingMask");
			BatchCullingContext.NativeFieldInfoPtr_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "isOrthographic");
			BatchCullingContext.NativeFieldInfoPtr_receiverPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "receiverPlaneOffset");
			BatchCullingContext.NativeFieldInfoPtr_receiverPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "receiverPlaneCount");
			BatchCullingContext.NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_CullingSplit_LODParameters_Matrix4x4_BatchCullingViewType_BatchCullingProjectionType_BatchCullingFlags_UInt64_UInt32_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, 100668068);
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x0009DA44 File Offset: 0x0009BC44
		[CallerCount(0)]
		public unsafe BatchCullingContext(Unity.Collections.NativeArray<Plane> inCullingPlanes, Unity.Collections.NativeArray<CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, int inReceiverPlaneOffset, int inReceiverPlaneCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inCullingPlanes));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inCullingSplits));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLodParameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLocalToWorldMatrix;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inViewType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inProjectionType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inBatchCullingFlags;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inViewID;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inCullingLayerMask;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inSceneCullingMask;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inReceiverPlaneOffset;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inReceiverPlaneCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchCullingContext.NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_CullingSplit_LODParameters_Matrix4x4_BatchCullingViewType_BatchCullingProjectionType_BatchCullingFlags_UInt64_UInt32_UInt64_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0000E652 File Offset: 0x0000C852
		public BatchCullingContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x0000E65B File Offset: 0x0000C85B
		public BatchCullingContext()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr))
		{
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x0009DB40 File Offset: 0x0009BD40
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x0000E66D File Offset: 0x0000C86D
		public Unity.Collections.NativeArray<Plane> cullingPlanes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingPlanes);
				return new Unity.Collections.NativeArray<Plane>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<Plane>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingPlanes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<Plane>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x0009DB70 File Offset: 0x0009BD70
		// (set) Token: 0x060024B1 RID: 9393 RVA: 0x0000E69B File Offset: 0x0000C89B
		public Unity.Collections.NativeArray<CullingSplit> cullingSplits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingSplits);
				return new Unity.Collections.NativeArray<CullingSplit>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<CullingSplit>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingSplits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<CullingSplit>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x0009DBA0 File Offset: 0x0009BDA0
		// (set) Token: 0x060024B3 RID: 9395 RVA: 0x0000E6C9 File Offset: 0x0000C8C9
		public unsafe LODParameters lodParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_lodParameters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_lodParameters)) = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x0009DBC8 File Offset: 0x0009BDC8
		// (set) Token: 0x060024B5 RID: 9397 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
		public unsafe Matrix4x4 localToWorldMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_localToWorldMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_localToWorldMatrix)) = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x0009DBF0 File Offset: 0x0009BDF0
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x0000E6FF File Offset: 0x0000C8FF
		public unsafe BatchCullingViewType viewType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_viewType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_viewType)) = value;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x0009DC18 File Offset: 0x0009BE18
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x0000E71A File Offset: 0x0000C91A
		public unsafe BatchCullingProjectionType projectionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_projectionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_projectionType)) = value;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x0009DC40 File Offset: 0x0009BE40
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x0000E735 File Offset: 0x0000C935
		public unsafe BatchCullingFlags cullingFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingFlags)) = value;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x0009DC68 File Offset: 0x0009BE68
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x0000E750 File Offset: 0x0000C950
		public unsafe BatchPackedCullingViewID viewID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_viewID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_viewID)) = value;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x0009DC90 File Offset: 0x0009BE90
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x0000E76B File Offset: 0x0000C96B
		public unsafe uint cullingLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingLayerMask)) = value;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x0009DCB8 File Offset: 0x0009BEB8
		// (set) Token: 0x060024C1 RID: 9409 RVA: 0x0000E786 File Offset: 0x0000C986
		public unsafe ulong sceneCullingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_sceneCullingMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_sceneCullingMask)) = value;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x0009DCE0 File Offset: 0x0009BEE0
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x0000E7A1 File Offset: 0x0000C9A1
		public unsafe byte isOrthographic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_isOrthographic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_isOrthographic)) = value;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x0009DD08 File Offset: 0x0009BF08
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x0000E7BC File Offset: 0x0000C9BC
		public unsafe int receiverPlaneOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_receiverPlaneOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_receiverPlaneOffset)) = value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x0009DD30 File Offset: 0x0009BF30
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x0000E7D7 File Offset: 0x0000C9D7
		public unsafe int receiverPlaneCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_receiverPlaneCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_receiverPlaneCount)) = value;
			}
		}

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlanes;

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeFieldInfoPtr_cullingSplits;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeFieldInfoPtr_lodParameters;

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeFieldInfoPtr_localToWorldMatrix;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeFieldInfoPtr_viewType;

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeFieldInfoPtr_projectionType;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeFieldInfoPtr_cullingFlags;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeFieldInfoPtr_viewID;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeFieldInfoPtr_cullingLayerMask;

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeFieldInfoPtr_sceneCullingMask;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeFieldInfoPtr_isOrthographic;

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeFieldInfoPtr_receiverPlaneOffset;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeFieldInfoPtr_receiverPlaneCount;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_CullingSplit_LODParameters_Matrix4x4_BatchCullingViewType_BatchCullingProjectionType_BatchCullingFlags_UInt64_UInt32_UInt64_Int32_Int32_0;
	}
}
