using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000078 RID: 120
	public class DecalDrawGBufferSystem : DecalDrawSystem
	{
		// Token: 0x06000A42 RID: 2626 RVA: 0x000385AC File Offset: 0x000367AC
		// Note: this type is marked as 'beforefieldinit'.
		static DecalDrawGBufferSystem()
		{
			Il2CppClassPointerStore<DecalDrawGBufferSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalDrawGBufferSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalDrawGBufferSystem>.NativeClassPtr);
			DecalDrawGBufferSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawGBufferSystem>.NativeClassPtr, 100664635);
			DecalDrawGBufferSystem.NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawGBufferSystem>.NativeClassPtr, 100664636);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00038604 File Offset: 0x00036804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 608057, RefRangeEnd = 608058, XrefRangeStart = 608051, XrefRangeEnd = 608057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalDrawGBufferSystem(DecalEntityManager entityManager)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalDrawGBufferSystem>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawGBufferSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00038650 File Offset: 0x00036850
		[CallerCount(0)]
		public unsafe override int GetPassIndex(DecalCachedChunk decalCachedChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalCachedChunk);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalDrawGBufferSystem.NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00006B19 File Offset: 0x00004D19
		public DecalDrawGBufferSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0;
	}
}
