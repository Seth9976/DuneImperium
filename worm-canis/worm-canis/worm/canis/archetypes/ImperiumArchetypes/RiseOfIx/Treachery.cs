using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x0200018F RID: 399
	public class Treachery : WormArchetype
	{
		// Token: 0x06001322 RID: 4898 RVA: 0x000A3B8C File Offset: 0x000A1D8C
		// Note: this type is marked as 'beforefieldinit'.
		static Treachery()
		{
			Il2CppClassPointerStore<Treachery>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "Treachery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Treachery>.NativeClassPtr);
			Treachery.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Treachery>.NativeClassPtr, "archID");
			Treachery.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Treachery>.NativeClassPtr, 100666430);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x000A3BE4 File Offset: 0x000A1DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100867, XrefRangeEnd = 101071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Treachery()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Treachery>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Treachery.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0000969B File Offset: 0x0000789B
		public Treachery(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x000A3C20 File Offset: 0x000A1E20
		// (set) Token: 0x06001326 RID: 4902 RVA: 0x000096A4 File Offset: 0x000078A4
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Treachery.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Treachery.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
