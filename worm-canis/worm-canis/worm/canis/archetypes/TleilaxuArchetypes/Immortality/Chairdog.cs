using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000EA RID: 234
	public class Chairdog : WormArchetype
	{
		// Token: 0x06000FE9 RID: 4073 RVA: 0x0009C260 File Offset: 0x0009A460
		// Note: this type is marked as 'beforefieldinit'.
		static Chairdog()
		{
			Il2CppClassPointerStore<Chairdog>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "Chairdog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chairdog>.NativeClassPtr);
			Chairdog.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chairdog>.NativeClassPtr, "archID");
			Chairdog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chairdog>.NativeClassPtr, 100666100);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0009C2B8 File Offset: 0x0009A4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78385, XrefRangeEnd = 78548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Chairdog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chairdog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chairdog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00008534 File Offset: 0x00006734
		public Chairdog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0009C2F4 File Offset: 0x0009A4F4
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x0000853D File Offset: 0x0000673D
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Chairdog.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Chairdog.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
