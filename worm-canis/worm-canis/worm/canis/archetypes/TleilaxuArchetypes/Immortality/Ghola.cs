using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000F0 RID: 240
	public class Ghola : WormArchetype
	{
		// Token: 0x06001007 RID: 4103 RVA: 0x0009C6C8 File Offset: 0x0009A8C8
		// Note: this type is marked as 'beforefieldinit'.
		static Ghola()
		{
			Il2CppClassPointerStore<Ghola>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "Ghola");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ghola>.NativeClassPtr);
			Ghola.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ghola>.NativeClassPtr, "archID");
			Ghola.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ghola>.NativeClassPtr, 100666112);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0009C720 File Offset: 0x0009A920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79467, XrefRangeEnd = 79631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ghola()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ghola>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ghola.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x000085D6 File Offset: 0x000067D6
		public Ghola(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x0009C75C File Offset: 0x0009A95C
		// (set) Token: 0x0600100B RID: 4107 RVA: 0x000085DF File Offset: 0x000067DF
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Ghola.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ghola.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
