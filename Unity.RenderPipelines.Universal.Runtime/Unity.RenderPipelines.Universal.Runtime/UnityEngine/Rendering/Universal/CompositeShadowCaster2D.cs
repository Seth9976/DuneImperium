using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000038 RID: 56
	public class CompositeShadowCaster2D : ShadowCasterGroup2D
	{
		// Token: 0x0600050D RID: 1293 RVA: 0x000273C4 File Offset: 0x000255C4
		// Note: this type is marked as 'beforefieldinit'.
		static CompositeShadowCaster2D()
		{
			Il2CppClassPointerStore<CompositeShadowCaster2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "CompositeShadowCaster2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeShadowCaster2D>.NativeClassPtr);
			CompositeShadowCaster2D.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeShadowCaster2D>.NativeClassPtr, 100663887);
			CompositeShadowCaster2D.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeShadowCaster2D>.NativeClassPtr, 100663888);
			CompositeShadowCaster2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeShadowCaster2D>.NativeClassPtr, 100663889);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00027430 File Offset: 0x00025630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602223, XrefRangeEnd = 602224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeShadowCaster2D.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00027464 File Offset: 0x00025664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602224, XrefRangeEnd = 602225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeShadowCaster2D.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00027498 File Offset: 0x00025698
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeShadowCaster2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeShadowCaster2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeShadowCaster2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000043FA File Offset: 0x000025FA
		public CompositeShadowCaster2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
