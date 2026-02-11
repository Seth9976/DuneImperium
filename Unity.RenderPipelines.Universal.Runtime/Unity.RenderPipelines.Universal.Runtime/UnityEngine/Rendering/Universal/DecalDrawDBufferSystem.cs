using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000060 RID: 96
	public class DecalDrawDBufferSystem : DecalDrawSystem
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x000324E4 File Offset: 0x000306E4
		// Note: this type is marked as 'beforefieldinit'.
		static DecalDrawDBufferSystem()
		{
			Il2CppClassPointerStore<DecalDrawDBufferSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalDrawDBufferSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalDrawDBufferSystem>.NativeClassPtr);
			DecalDrawDBufferSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawDBufferSystem>.NativeClassPtr, 100664460);
			DecalDrawDBufferSystem.NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawDBufferSystem>.NativeClassPtr, 100664461);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0003253C File Offset: 0x0003073C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606305, RefRangeEnd = 606306, XrefRangeStart = 606299, XrefRangeEnd = 606305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalDrawDBufferSystem(DecalEntityManager entityManager)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalDrawDBufferSystem>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawDBufferSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00032588 File Offset: 0x00030788
		[CallerCount(0)]
		public unsafe override int GetPassIndex(DecalCachedChunk decalCachedChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalCachedChunk);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalDrawDBufferSystem.NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00005966 File Offset: 0x00003B66
		public DecalDrawDBufferSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0;
	}
}
