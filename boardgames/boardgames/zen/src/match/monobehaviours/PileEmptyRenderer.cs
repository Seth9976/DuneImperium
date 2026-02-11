using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace zen.src.match.monobehaviours
{
	// Token: 0x02000073 RID: 115
	public class PileEmptyRenderer : VersionedSubscriber<EntityComponent>
	{
		// Token: 0x06000615 RID: 1557 RVA: 0x00023C28 File Offset: 0x00021E28
		// Note: this type is marked as 'beforefieldinit'.
		static PileEmptyRenderer()
		{
			Il2CppClassPointerStore<PileEmptyRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "PileEmptyRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PileEmptyRenderer>.NativeClassPtr);
			PileEmptyRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileEmptyRenderer>.NativeClassPtr, 100664257);
			PileEmptyRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileEmptyRenderer>.NativeClassPtr, 100664258);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00023C80 File Offset: 0x00021E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988392, XrefRangeEnd = 988401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PileEmptyRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00023CBC File Offset: 0x00021EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988401, XrefRangeEnd = 988404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PileEmptyRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PileEmptyRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileEmptyRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00004C6E File Offset: 0x00002E6E
		public PileEmptyRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
