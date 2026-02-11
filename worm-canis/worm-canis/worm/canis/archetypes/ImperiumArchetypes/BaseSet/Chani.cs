using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001B4 RID: 436
	public class Chani : WormArchetype
	{
		// Token: 0x060013DB RID: 5083 RVA: 0x000A56B8 File Offset: 0x000A38B8
		// Note: this type is marked as 'beforefieldinit'.
		static Chani()
		{
			Il2CppClassPointerStore<Chani>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "Chani");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chani>.NativeClassPtr);
			Chani.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chani>.NativeClassPtr, "archID");
			Chani.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chani>.NativeClassPtr, 100666504);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x000A5710 File Offset: 0x000A3910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108235, XrefRangeEnd = 108451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Chani()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chani>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chani.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00009A82 File Offset: 0x00007C82
		public Chani(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x000A574C File Offset: 0x000A394C
		// (set) Token: 0x060013DF RID: 5087 RVA: 0x00009A8B File Offset: 0x00007C8B
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Chani.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Chani.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
