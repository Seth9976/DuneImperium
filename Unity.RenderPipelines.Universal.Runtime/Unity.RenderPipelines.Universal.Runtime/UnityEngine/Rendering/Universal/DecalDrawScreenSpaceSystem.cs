using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200007A RID: 122
	public class DecalDrawScreenSpaceSystem : DecalDrawSystem
	{
		// Token: 0x06000A5D RID: 2653 RVA: 0x00038B04 File Offset: 0x00036D04
		// Note: this type is marked as 'beforefieldinit'.
		static DecalDrawScreenSpaceSystem()
		{
			Il2CppClassPointerStore<DecalDrawScreenSpaceSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalDrawScreenSpaceSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalDrawScreenSpaceSystem>.NativeClassPtr);
			DecalDrawScreenSpaceSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawScreenSpaceSystem>.NativeClassPtr, 100664642);
			DecalDrawScreenSpaceSystem.NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawScreenSpaceSystem>.NativeClassPtr, 100664643);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00038B5C File Offset: 0x00036D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 608232, RefRangeEnd = 608233, XrefRangeStart = 608226, XrefRangeEnd = 608232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalDrawScreenSpaceSystem(DecalEntityManager entityManager)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalDrawScreenSpaceSystem>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawScreenSpaceSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00038BA8 File Offset: 0x00036DA8
		[CallerCount(0)]
		public unsafe override int GetPassIndex(DecalCachedChunk decalCachedChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalCachedChunk);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalDrawScreenSpaceSystem.NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00006C1B File Offset: 0x00004E1B
		public DecalDrawScreenSpaceSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0;
	}
}
