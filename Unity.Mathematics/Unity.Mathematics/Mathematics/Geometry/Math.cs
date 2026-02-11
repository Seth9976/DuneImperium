using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics.Geometry
{
	// Token: 0x0200004C RID: 76
	public static class Math : Object
	{
		// Token: 0x0600258A RID: 9610 RVA: 0x000C23B8 File Offset: 0x000C05B8
		// Note: this type is marked as 'beforefieldinit'.
		static Math()
		{
			Il2CppClassPointerStore<Math>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics.Geometry", "Math");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Math>.NativeClassPtr);
			Math.NativeMethodInfoPtr_Transform_Public_Static_MinMaxAABB_RigidTransform_MinMaxAABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100672615);
			Math.NativeMethodInfoPtr_Transform_Public_Static_MinMaxAABB_float4x4_MinMaxAABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100672616);
			Math.NativeMethodInfoPtr_Transform_Public_Static_MinMaxAABB_float3x3_MinMaxAABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100672617);
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x000C2424 File Offset: 0x000C0624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642822, XrefRangeEnd = 642823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MinMaxAABB Transform(RigidTransform transform, MinMaxAABB aabb)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aabb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Transform_Public_Static_MinMaxAABB_RigidTransform_MinMaxAABB_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x000C2470 File Offset: 0x000C0670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642823, XrefRangeEnd = 642825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MinMaxAABB Transform(float4x4 transform, MinMaxAABB aabb)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aabb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Transform_Public_Static_MinMaxAABB_float4x4_MinMaxAABB_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x000C24BC File Offset: 0x000C06BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642834, RefRangeEnd = 642835, XrefRangeStart = 642825, XrefRangeEnd = 642834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MinMaxAABB Transform(float3x3 transform, MinMaxAABB aabb)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aabb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Transform_Public_Static_MinMaxAABB_float3x3_MinMaxAABB_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00002AC9 File Offset: 0x00000CC9
		public Math(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002626 RID: 9766
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Static_MinMaxAABB_RigidTransform_MinMaxAABB_0;

		// Token: 0x04002627 RID: 9767
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Static_MinMaxAABB_float4x4_MinMaxAABB_0;

		// Token: 0x04002628 RID: 9768
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Static_MinMaxAABB_float3x3_MinMaxAABB_0;
	}
}
