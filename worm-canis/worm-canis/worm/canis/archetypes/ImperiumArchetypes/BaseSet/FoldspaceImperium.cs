using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001BF RID: 447
	public class FoldspaceImperium : WormArchetype
	{
		// Token: 0x06001412 RID: 5138 RVA: 0x000A5ECC File Offset: 0x000A40CC
		// Note: this type is marked as 'beforefieldinit'.
		static FoldspaceImperium()
		{
			Il2CppClassPointerStore<FoldspaceImperium>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "FoldspaceImperium");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FoldspaceImperium>.NativeClassPtr);
			FoldspaceImperium.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoldspaceImperium>.NativeClassPtr, "archID");
			FoldspaceImperium.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoldspaceImperium>.NativeClassPtr, 100666526);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x000A5F24 File Offset: 0x000A4124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110196, XrefRangeEnd = 110372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FoldspaceImperium()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FoldspaceImperium>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FoldspaceImperium.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00009BAB File Offset: 0x00007DAB
		public FoldspaceImperium(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x000A5F60 File Offset: 0x000A4160
		// (set) Token: 0x06001416 RID: 5142 RVA: 0x00009BB4 File Offset: 0x00007DB4
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FoldspaceImperium.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FoldspaceImperium.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
