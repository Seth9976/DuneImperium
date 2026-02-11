using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public class MeshCollider : Collider
	{
		// Token: 0x0600025D RID: 605 RVA: 0x0000948C File Offset: 0x0000768C
		// Note: this type is marked as 'beforefieldinit'.
		static MeshCollider()
		{
			Il2CppClassPointerStore<MeshCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "MeshCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr);
			MeshCollider.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663386);
			MeshCollider.NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663387);
			MeshCollider.NativeMethodInfoPtr_get_convex_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663388);
			MeshCollider.NativeMethodInfoPtr_set_convex_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663389);
			MeshCollider.NativeMethodInfoPtr_get_cookingOptions_Public_get_MeshColliderCookingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663390);
			MeshCollider.NativeMethodInfoPtr_set_cookingOptions_Public_set_Void_MeshColliderCookingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663391);
			MeshCollider.NativeMethodInfoPtr_get_smoothSphereCollisions_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663392);
			MeshCollider.NativeMethodInfoPtr_set_smoothSphereCollisions_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663393);
			MeshCollider.NativeMethodInfoPtr_get_skinWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663394);
			MeshCollider.NativeMethodInfoPtr_set_skinWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663395);
			MeshCollider.NativeMethodInfoPtr_get_inflateMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663396);
			MeshCollider.NativeMethodInfoPtr_set_inflateMesh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663397);
			MeshCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr, 100663398);
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000095C0 File Offset: 0x000077C0
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00009600 File Offset: 0x00007800
		public unsafe Mesh sharedMesh
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255144, XrefRangeEnd = 1255146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1255148, RefRangeEnd = 1255149, XrefRangeStart = 1255146, XrefRangeEnd = 1255148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00009644 File Offset: 0x00007844
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00009680 File Offset: 0x00007880
		public unsafe bool convex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255149, XrefRangeEnd = 1255151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_get_convex_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255151, XrefRangeEnd = 1255153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_set_convex_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000096C0 File Offset: 0x000078C0
		// (set) Token: 0x06000263 RID: 611 RVA: 0x000096FC File Offset: 0x000078FC
		public unsafe MeshColliderCookingOptions cookingOptions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255153, XrefRangeEnd = 1255155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_get_cookingOptions_Public_get_MeshColliderCookingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255155, XrefRangeEnd = 1255157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_set_cookingOptions_Public_set_Void_MeshColliderCookingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000973C File Offset: 0x0000793C
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00009778 File Offset: 0x00007978
		public unsafe bool smoothSphereCollisions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_get_smoothSphereCollisions_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_set_smoothSphereCollisions_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000266 RID: 614 RVA: 0x000097B8 File Offset: 0x000079B8
		// (set) Token: 0x06000267 RID: 615 RVA: 0x000097F4 File Offset: 0x000079F4
		public unsafe float skinWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_get_skinWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_set_skinWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00009834 File Offset: 0x00007A34
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00009870 File Offset: 0x00007A70
		public unsafe bool inflateMesh
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 291198, RefRangeEnd = 291216, XrefRangeStart = 291198, XrefRangeEnd = 291216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_get_inflateMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr_set_inflateMesh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000098B0 File Offset: 0x00007AB0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshCollider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000334F File Offset: 0x0000154F
		public MeshCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_get_convex_Public_get_Boolean_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_set_convex_Public_set_Void_Boolean_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_get_cookingOptions_Public_get_MeshColliderCookingOptions_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_set_cookingOptions_Public_set_Void_MeshColliderCookingOptions_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_get_smoothSphereCollisions_Public_get_Boolean_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_set_smoothSphereCollisions_Public_set_Void_Boolean_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_get_skinWidth_Public_get_Single_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_set_skinWidth_Public_set_Void_Single_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_get_inflateMesh_Public_get_Boolean_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_set_inflateMesh_Public_set_Void_Boolean_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
