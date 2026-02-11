using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000116 RID: 278
	public class FoldspaceSpace : WormArchetype
	{
		// Token: 0x060010C5 RID: 4293 RVA: 0x0009E2B0 File Offset: 0x0009C4B0
		// Note: this type is marked as 'beforefieldinit'.
		static FoldspaceSpace()
		{
			Il2CppClassPointerStore<FoldspaceSpace>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "FoldspaceSpace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FoldspaceSpace>.NativeClassPtr);
			FoldspaceSpace.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoldspaceSpace>.NativeClassPtr, "archID");
			FoldspaceSpace.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoldspaceSpace>.NativeClassPtr, 100666188);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0009E308 File Offset: 0x0009C508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84682, XrefRangeEnd = 84843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FoldspaceSpace()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FoldspaceSpace>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoldspaceSpace.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x000089D8 File Offset: 0x00006BD8
		public FoldspaceSpace(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x0009E344 File Offset: 0x0009C544
		// (set) Token: 0x060010C9 RID: 4297 RVA: 0x000089E1 File Offset: 0x00006BE1
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FoldspaceSpace.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FoldspaceSpace.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
