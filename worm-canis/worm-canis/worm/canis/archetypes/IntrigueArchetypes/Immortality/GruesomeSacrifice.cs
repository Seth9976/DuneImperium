using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.Immortality
{
	// Token: 0x0200014D RID: 333
	public class GruesomeSacrifice : WormArchetype
	{
		// Token: 0x060011D8 RID: 4568 RVA: 0x000A0B14 File Offset: 0x0009ED14
		// Note: this type is marked as 'beforefieldinit'.
		static GruesomeSacrifice()
		{
			Il2CppClassPointerStore<GruesomeSacrifice>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.Immortality", "GruesomeSacrifice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GruesomeSacrifice>.NativeClassPtr);
			GruesomeSacrifice.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GruesomeSacrifice>.NativeClassPtr, "archID");
			GruesomeSacrifice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GruesomeSacrifice>.NativeClassPtr, 100666298);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x000A0B6C File Offset: 0x0009ED6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91293, XrefRangeEnd = 91408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GruesomeSacrifice()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GruesomeSacrifice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GruesomeSacrifice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00008FA5 File Offset: 0x000071A5
		public GruesomeSacrifice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x000A0BA8 File Offset: 0x0009EDA8
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x00008FAE File Offset: 0x000071AE
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GruesomeSacrifice.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GruesomeSacrifice.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
