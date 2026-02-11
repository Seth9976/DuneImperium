using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001DD RID: 477
	public class Stilgar : WormArchetype
	{
		// Token: 0x060014A8 RID: 5288 RVA: 0x000A74D4 File Offset: 0x000A56D4
		// Note: this type is marked as 'beforefieldinit'.
		static Stilgar()
		{
			Il2CppClassPointerStore<Stilgar>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "Stilgar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stilgar>.NativeClassPtr);
			Stilgar.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stilgar>.NativeClassPtr, "archID");
			Stilgar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stilgar>.NativeClassPtr, 100666586);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x000A752C File Offset: 0x000A572C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115891, XrefRangeEnd = 116099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stilgar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stilgar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stilgar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00009ED5 File Offset: 0x000080D5
		public Stilgar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x000A7568 File Offset: 0x000A5768
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x00009EDE File Offset: 0x000080DE
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Stilgar.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stilgar.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
