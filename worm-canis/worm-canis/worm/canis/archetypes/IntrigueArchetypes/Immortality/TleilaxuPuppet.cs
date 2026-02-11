using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.Immortality
{
	// Token: 0x02000152 RID: 338
	public class TleilaxuPuppet : WormArchetype
	{
		// Token: 0x060011F1 RID: 4593 RVA: 0x000A0EC0 File Offset: 0x0009F0C0
		// Note: this type is marked as 'beforefieldinit'.
		static TleilaxuPuppet()
		{
			Il2CppClassPointerStore<TleilaxuPuppet>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.Immortality", "TleilaxuPuppet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TleilaxuPuppet>.NativeClassPtr);
			TleilaxuPuppet.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuPuppet>.NativeClassPtr, "archID");
			TleilaxuPuppet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuPuppet>.NativeClassPtr, 100666308);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x000A0F18 File Offset: 0x0009F118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91886, XrefRangeEnd = 92016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TleilaxuPuppet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TleilaxuPuppet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuPuppet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0000902C File Offset: 0x0000722C
		public TleilaxuPuppet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x000A0F54 File Offset: 0x0009F154
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x00009035 File Offset: 0x00007235
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TleilaxuPuppet.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TleilaxuPuppet.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
