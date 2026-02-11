using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.Immortality
{
	// Token: 0x0200014A RID: 330
	public class Counterattack : WormArchetype
	{
		// Token: 0x060011C9 RID: 4553 RVA: 0x000A08E0 File Offset: 0x0009EAE0
		// Note: this type is marked as 'beforefieldinit'.
		static Counterattack()
		{
			Il2CppClassPointerStore<Counterattack>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.Immortality", "Counterattack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Counterattack>.NativeClassPtr);
			Counterattack.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Counterattack>.NativeClassPtr, "archID");
			Counterattack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Counterattack>.NativeClassPtr, 100666292);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x000A0938 File Offset: 0x0009EB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90911, XrefRangeEnd = 91036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Counterattack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Counterattack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Counterattack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00008F54 File Offset: 0x00007154
		public Counterattack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x000A0974 File Offset: 0x0009EB74
		// (set) Token: 0x060011CD RID: 4557 RVA: 0x00008F5D File Offset: 0x0000715D
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Counterattack.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Counterattack.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
