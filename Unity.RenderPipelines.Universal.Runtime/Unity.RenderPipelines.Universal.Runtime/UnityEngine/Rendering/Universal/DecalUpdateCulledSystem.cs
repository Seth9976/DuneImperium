using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000075 RID: 117
	public class DecalUpdateCulledSystem : Object
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x00037D20 File Offset: 0x00035F20
		// Note: this type is marked as 'beforefieldinit'.
		static DecalUpdateCulledSystem()
		{
			Il2CppClassPointerStore<DecalUpdateCulledSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalUpdateCulledSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalUpdateCulledSystem>.NativeClassPtr);
			DecalUpdateCulledSystem.NativeFieldInfoPtr_m_EntityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCulledSystem>.NativeClassPtr, "m_EntityManager");
			DecalUpdateCulledSystem.NativeFieldInfoPtr_m_Sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalUpdateCulledSystem>.NativeClassPtr, "m_Sampler");
			DecalUpdateCulledSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCulledSystem>.NativeClassPtr, 100664622);
			DecalUpdateCulledSystem.NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCulledSystem>.NativeClassPtr, 100664623);
			DecalUpdateCulledSystem.NativeMethodInfoPtr_Execute_Private_Void_DecalCulledChunk_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalUpdateCulledSystem>.NativeClassPtr, 100664624);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00037DB4 File Offset: 0x00035FB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607947, RefRangeEnd = 607948, XrefRangeStart = 607938, XrefRangeEnd = 607947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalUpdateCulledSystem(DecalEntityManager entityManager)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalUpdateCulledSystem>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCulledSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00037E00 File Offset: 0x00036000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 607963, RefRangeEnd = 607964, XrefRangeStart = 607948, XrefRangeEnd = 607963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCulledSystem.NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00037E34 File Offset: 0x00036034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 607964, XrefRangeEnd = 607969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalUpdateCulledSystem.NativeMethodInfoPtr_Execute_Private_Void_DecalCulledChunk_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0000696C File Offset: 0x00004B6C
		public DecalUpdateCulledSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00037E84 File Offset: 0x00036084
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00006975 File Offset: 0x00004B75
		public unsafe DecalEntityManager m_EntityManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCulledSystem.NativeFieldInfoPtr_m_EntityManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalEntityManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCulledSystem.NativeFieldInfoPtr_m_EntityManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00037EB4 File Offset: 0x000360B4
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00006994 File Offset: 0x00004B94
		public unsafe ProfilingSampler m_Sampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCulledSystem.NativeFieldInfoPtr_m_Sampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalUpdateCulledSystem.NativeFieldInfoPtr_m_Sampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr_m_EntityManager;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr_m_Sampler;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_DecalCulledChunk_Int32_0;
	}
}
