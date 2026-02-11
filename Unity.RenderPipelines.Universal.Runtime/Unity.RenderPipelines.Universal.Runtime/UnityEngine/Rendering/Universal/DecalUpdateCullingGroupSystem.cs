using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000077 RID: 119
	public class DecalUpdateCullingGroupSystem : Object
	{
		// Token: 0x06000A32 RID: 2610 RVA: 0x00038230 File Offset: 0x00036430
		// Note: this type is marked as 'beforefieldinit'.
		static DecalUpdateCullingGroupSystem()
		{
			Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalUpdateCullingGroupSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr);
			DecalUpdateCullingGroupSystem.NativeFieldInfoPtr_m_BoundingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr, "m_BoundingDistance");
			DecalUpdateCullingGroupSystem.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr, "m_Camera");
			DecalUpdateCullingGroupSystem.NativeFieldInfoPtr_m_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr, "m_EntityManager");
			DecalUpdateCullingGroupSystem.NativeFieldInfoPtr_m_Sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr, "m_Sampler");
			DecalUpdateCullingGroupSystem.NativeMethodInfoPtr_get_boundingDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr, 100664629);
			DecalUpdateCullingGroupSystem.NativeMethodInfoPtr_set_boundingDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr, 100664630);
			DecalUpdateCullingGroupSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr, 100664631);
			DecalUpdateCullingGroupSystem.NativeMethodInfoPtr_Execute_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr, 100664632);
			DecalUpdateCullingGroupSystem.NativeMethodInfoPtr_Execute_Public_Void_DecalCachedChunk_DecalCulledChunk_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr, 100664633);
			DecalUpdateCullingGroupSystem.NativeMethodInfoPtr_GetSceneCullingMaskFromCamera_Internal_Static_UInt64_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr, 100664634);
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00038328 File Offset: 0x00036528
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00038364 File Offset: 0x00036564
		public unsafe float boundingDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCullingGroupSystem.NativeMethodInfoPtr_get_boundingDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCullingGroupSystem.NativeMethodInfoPtr_set_boundingDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000383A4 File Offset: 0x000365A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 608007, RefRangeEnd = 608008, XrefRangeStart = 607992, XrefRangeEnd = 608007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalUpdateCullingGroupSystem(DecalEntityManager entityManager, float drawDistance)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalUpdateCullingGroupSystem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityManager);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCullingGroupSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00038400 File Offset: 0x00036600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 608036, RefRangeEnd = 608037, XrefRangeStart = 608008, XrefRangeEnd = 608036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCullingGroupSystem.NativeMethodInfoPtr_Execute_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00038444 File Offset: 0x00036644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 608037, XrefRangeEnd = 608051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(DecalCachedChunk cachedChunk, DecalCulledChunk culledChunk, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cachedChunk);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culledChunk);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCullingGroupSystem.NativeMethodInfoPtr_Execute_Public_Void_DecalCachedChunk_DecalCulledChunk_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x000384A8 File Offset: 0x000366A8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong GetSceneCullingMaskFromCamera(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCullingGroupSystem.NativeMethodInfoPtr_GetSceneCullingMaskFromCamera_Internal_Static_UInt64_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00006A94 File Offset: 0x00004C94
		public DecalUpdateCullingGroupSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x000384EC File Offset: 0x000366EC
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x00006A9D File Offset: 0x00004C9D
		public unsafe Il2CppStructArray<float> m_BoundingDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCullingGroupSystem.NativeFieldInfoPtr_m_BoundingDistance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCullingGroupSystem.NativeFieldInfoPtr_m_BoundingDistance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0003851C File Offset: 0x0003671C
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x00006ABC File Offset: 0x00004CBC
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCullingGroupSystem.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCullingGroupSystem.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0003854C File Offset: 0x0003674C
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x00006ADB File Offset: 0x00004CDB
		public unsafe DecalEntityManager m_EntityManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCullingGroupSystem.NativeFieldInfoPtr_m_EntityManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalEntityManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCullingGroupSystem.NativeFieldInfoPtr_m_EntityManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0003857C File Offset: 0x0003677C
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00006AFA File Offset: 0x00004CFA
		public unsafe ProfilingSampler m_Sampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCullingGroupSystem.NativeFieldInfoPtr_m_Sampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCullingGroupSystem.NativeFieldInfoPtr_m_Sampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeFieldInfoPtr_m_BoundingDistance;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_m_EntityManager;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_m_Sampler;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_get_boundingDistance_Public_get_Single_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_set_boundingDistance_Public_set_Void_Single_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_Single_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_Camera_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_DecalCachedChunk_DecalCulledChunk_Int32_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneCullingMaskFromCamera_Internal_Static_UInt64_Camera_0;
	}
}
