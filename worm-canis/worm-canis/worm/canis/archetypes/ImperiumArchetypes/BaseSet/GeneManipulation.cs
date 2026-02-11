using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001C1 RID: 449
	public class GeneManipulation : WormArchetype
	{
		// Token: 0x0600141C RID: 5148 RVA: 0x000A6044 File Offset: 0x000A4244
		// Note: this type is marked as 'beforefieldinit'.
		static GeneManipulation()
		{
			Il2CppClassPointerStore<GeneManipulation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "GeneManipulation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneManipulation>.NativeClassPtr);
			GeneManipulation.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneManipulation>.NativeClassPtr, "archID");
			GeneManipulation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneManipulation>.NativeClassPtr, 100666530);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x000A609C File Offset: 0x000A429C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110559, XrefRangeEnd = 110749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneManipulation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneManipulation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneManipulation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00009BE1 File Offset: 0x00007DE1
		public GeneManipulation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x000A60D8 File Offset: 0x000A42D8
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x00009BEA File Offset: 0x00007DEA
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GeneManipulation.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GeneManipulation.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
