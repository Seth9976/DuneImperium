using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x0200018C RID: 396
	public class Sayyadina : WormArchetype
	{
		// Token: 0x06001313 RID: 4883 RVA: 0x000A3958 File Offset: 0x000A1B58
		// Note: this type is marked as 'beforefieldinit'.
		static Sayyadina()
		{
			Il2CppClassPointerStore<Sayyadina>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "Sayyadina");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sayyadina>.NativeClassPtr);
			Sayyadina.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sayyadina>.NativeClassPtr, "archID");
			Sayyadina.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sayyadina>.NativeClassPtr, 100666424);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x000A39B0 File Offset: 0x000A1BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100218, XrefRangeEnd = 100429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sayyadina()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sayyadina>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sayyadina.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0000964A File Offset: 0x0000784A
		public Sayyadina(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x000A39EC File Offset: 0x000A1BEC
		// (set) Token: 0x06001317 RID: 4887 RVA: 0x00009653 File Offset: 0x00007853
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Sayyadina.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sayyadina.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
