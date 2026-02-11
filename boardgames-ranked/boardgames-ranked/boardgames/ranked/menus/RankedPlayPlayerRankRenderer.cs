using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.ranked.menus
{
	// Token: 0x02000024 RID: 36
	public class RankedPlayPlayerRankRenderer : VersionedView<RankedPlayProvider>
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00006644 File Offset: 0x00004844
		// Note: this type is marked as 'beforefieldinit'.
		static RankedPlayPlayerRankRenderer()
		{
			Il2CppClassPointerStore<RankedPlayPlayerRankRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedPlayPlayerRankRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayPlayerRankRenderer>.NativeClassPtr);
			RankedPlayPlayerRankRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayPlayerRankRenderer>.NativeClassPtr, 100663373);
			RankedPlayPlayerRankRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayPlayerRankRenderer>.NativeClassPtr, 100663374);
			RankedPlayPlayerRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayPlayerRankRenderer>.NativeClassPtr, 100663375);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000066B0 File Offset: 0x000048B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225165, XrefRangeEnd = 1225171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayPlayerRankRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000066EC File Offset: 0x000048EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225171, XrefRangeEnd = 1225175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayPlayerRankRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006728 File Offset: 0x00004928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225175, XrefRangeEnd = 1225178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedPlayPlayerRankRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayPlayerRankRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayPlayerRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002C0B File Offset: 0x00000E0B
		public RankedPlayPlayerRankRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
