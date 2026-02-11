using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000072 RID: 114
	public class DecalSkipCulledSystem : Object
	{
		// Token: 0x060009C8 RID: 2504 RVA: 0x000370D4 File Offset: 0x000352D4
		// Note: this type is marked as 'beforefieldinit'.
		static DecalSkipCulledSystem()
		{
			Il2CppClassPointerStore<DecalSkipCulledSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalSkipCulledSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalSkipCulledSystem>.NativeClassPtr);
			DecalSkipCulledSystem.NativeFieldInfoPtr_m_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSkipCulledSystem>.NativeClassPtr, "m_EntityManager");
			DecalSkipCulledSystem.NativeFieldInfoPtr_m_Sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSkipCulledSystem>.NativeClassPtr, "m_Sampler");
			DecalSkipCulledSystem.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSkipCulledSystem>.NativeClassPtr, "m_Camera");
			DecalSkipCulledSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSkipCulledSystem>.NativeClassPtr, 100664607);
			DecalSkipCulledSystem.NativeMethodInfoPtr_Execute_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSkipCulledSystem>.NativeClassPtr, 100664608);
			DecalSkipCulledSystem.NativeMethodInfoPtr_Execute_Private_Void_DecalCulledChunk_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSkipCulledSystem>.NativeClassPtr, 100664609);
			DecalSkipCulledSystem.NativeMethodInfoPtr_GetSceneCullingMaskFromCamera_Internal_Static_UInt64_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSkipCulledSystem>.NativeClassPtr, 100664610);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00037190 File Offset: 0x00035390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607673, RefRangeEnd = 607674, XrefRangeStart = 607664, XrefRangeEnd = 607673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalSkipCulledSystem(DecalEntityManager entityManager)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalSkipCulledSystem>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalSkipCulledSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000371DC File Offset: 0x000353DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607689, RefRangeEnd = 607690, XrefRangeStart = 607674, XrefRangeEnd = 607689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalSkipCulledSystem.NativeMethodInfoPtr_Execute_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00037220 File Offset: 0x00035420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607690, XrefRangeEnd = 607694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(DecalCulledChunk culledChunk, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culledChunk);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalSkipCulledSystem.NativeMethodInfoPtr_Execute_Private_Void_DecalCulledChunk_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00037270 File Offset: 0x00035470
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong GetSceneCullingMaskFromCamera(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalSkipCulledSystem.NativeMethodInfoPtr_GetSceneCullingMaskFromCamera_Internal_Static_UInt64_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000064D7 File Offset: 0x000046D7
		public DecalSkipCulledSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x000372B4 File Offset: 0x000354B4
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x000064E0 File Offset: 0x000046E0
		public unsafe DecalEntityManager m_EntityManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSkipCulledSystem.NativeFieldInfoPtr_m_EntityManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalEntityManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSkipCulledSystem.NativeFieldInfoPtr_m_EntityManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x000372E4 File Offset: 0x000354E4
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x000064FF File Offset: 0x000046FF
		public unsafe ProfilingSampler m_Sampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSkipCulledSystem.NativeFieldInfoPtr_m_Sampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSkipCulledSystem.NativeFieldInfoPtr_m_Sampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00037314 File Offset: 0x00035514
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x0000651E File Offset: 0x0000471E
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSkipCulledSystem.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSkipCulledSystem.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeFieldInfoPtr_m_EntityManager;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr_m_Sampler;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_Camera_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_DecalCulledChunk_Int32_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneCullingMaskFromCamera_Internal_Static_UInt64_Camera_0;
	}
}
