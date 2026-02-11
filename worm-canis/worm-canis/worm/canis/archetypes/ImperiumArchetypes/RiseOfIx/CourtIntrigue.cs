using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x0200017A RID: 378
	public class CourtIntrigue : WormArchetype
	{
		// Token: 0x060012B9 RID: 4793 RVA: 0x000A2C20 File Offset: 0x000A0E20
		// Note: this type is marked as 'beforefieldinit'.
		static CourtIntrigue()
		{
			Il2CppClassPointerStore<CourtIntrigue>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "CourtIntrigue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CourtIntrigue>.NativeClassPtr);
			CourtIntrigue.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CourtIntrigue>.NativeClassPtr, "archID");
			CourtIntrigue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CourtIntrigue>.NativeClassPtr, 100666388);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000A2C78 File Offset: 0x000A0E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96576, XrefRangeEnd = 96782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CourtIntrigue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CourtIntrigue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CourtIntrigue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00009464 File Offset: 0x00007664
		public CourtIntrigue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x000A2CB4 File Offset: 0x000A0EB4
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x0000946D File Offset: 0x0000766D
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CourtIntrigue.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CourtIntrigue.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
