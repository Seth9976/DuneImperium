using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.Immortality
{
	// Token: 0x02000149 RID: 329
	public class Breakthrough : WormArchetype
	{
		// Token: 0x060011C4 RID: 4548 RVA: 0x000A0824 File Offset: 0x0009EA24
		// Note: this type is marked as 'beforefieldinit'.
		static Breakthrough()
		{
			Il2CppClassPointerStore<Breakthrough>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.Immortality", "Breakthrough");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Breakthrough>.NativeClassPtr);
			Breakthrough.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Breakthrough>.NativeClassPtr, "archID");
			Breakthrough.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Breakthrough>.NativeClassPtr, 100666290);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x000A087C File Offset: 0x0009EA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90805, XrefRangeEnd = 90911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Breakthrough()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Breakthrough>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Breakthrough.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00008F39 File Offset: 0x00007139
		public Breakthrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x000A08B8 File Offset: 0x0009EAB8
		// (set) Token: 0x060011C8 RID: 4552 RVA: 0x00008F42 File Offset: 0x00007142
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Breakthrough.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Breakthrough.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
