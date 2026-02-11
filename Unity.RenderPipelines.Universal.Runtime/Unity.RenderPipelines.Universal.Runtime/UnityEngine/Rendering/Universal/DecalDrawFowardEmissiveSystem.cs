using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000062 RID: 98
	public class DecalDrawFowardEmissiveSystem : DecalDrawSystem
	{
		// Token: 0x06000885 RID: 2181 RVA: 0x00032DF0 File Offset: 0x00030FF0
		// Note: this type is marked as 'beforefieldinit'.
		static DecalDrawFowardEmissiveSystem()
		{
			Il2CppClassPointerStore<DecalDrawFowardEmissiveSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalDrawFowardEmissiveSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalDrawFowardEmissiveSystem>.NativeClassPtr);
			DecalDrawFowardEmissiveSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawFowardEmissiveSystem>.NativeClassPtr, 100664475);
			DecalDrawFowardEmissiveSystem.NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawFowardEmissiveSystem>.NativeClassPtr, 100664476);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00032E48 File Offset: 0x00031048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606469, RefRangeEnd = 606470, XrefRangeStart = 606463, XrefRangeEnd = 606469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalDrawFowardEmissiveSystem(DecalEntityManager entityManager)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalDrawFowardEmissiveSystem>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalDrawFowardEmissiveSystem.NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00032E94 File Offset: 0x00031094
		[CallerCount(0)]
		public unsafe override int GetPassIndex(DecalCachedChunk decalCachedChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decalCachedChunk);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecalDrawFowardEmissiveSystem.NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00005AE9 File Offset: 0x00003CE9
		public DecalDrawFowardEmissiveSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0;
	}
}
