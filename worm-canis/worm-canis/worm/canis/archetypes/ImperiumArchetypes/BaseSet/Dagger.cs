using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001B8 RID: 440
	public class Dagger : WormArchetype
	{
		// Token: 0x060013EF RID: 5103 RVA: 0x000A59A8 File Offset: 0x000A3BA8
		// Note: this type is marked as 'beforefieldinit'.
		static Dagger()
		{
			Il2CppClassPointerStore<Dagger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "Dagger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dagger>.NativeClassPtr);
			Dagger.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dagger>.NativeClassPtr, "archID");
			Dagger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dagger>.NativeClassPtr, 100666512);
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x000A5A00 File Offset: 0x000A3C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108959, XrefRangeEnd = 109099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dagger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dagger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dagger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00009AEE File Offset: 0x00007CEE
		public Dagger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x000A5A3C File Offset: 0x000A3C3C
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x00009AF7 File Offset: 0x00007CF7
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dagger.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dagger.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
