using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001E1 RID: 481
	public class ThufirHawat : WormArchetype
	{
		// Token: 0x060014BC RID: 5308 RVA: 0x000A77C4 File Offset: 0x000A59C4
		// Note: this type is marked as 'beforefieldinit'.
		static ThufirHawat()
		{
			Il2CppClassPointerStore<ThufirHawat>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "ThufirHawat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThufirHawat>.NativeClassPtr);
			ThufirHawat.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThufirHawat>.NativeClassPtr, "archID");
			ThufirHawat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThufirHawat>.NativeClassPtr, 100666594);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x000A781C File Offset: 0x000A5A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116646, XrefRangeEnd = 116857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThufirHawat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThufirHawat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThufirHawat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00009F41 File Offset: 0x00008141
		public ThufirHawat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x000A7858 File Offset: 0x000A5A58
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x00009F4A File Offset: 0x0000814A
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThufirHawat.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThufirHawat.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
