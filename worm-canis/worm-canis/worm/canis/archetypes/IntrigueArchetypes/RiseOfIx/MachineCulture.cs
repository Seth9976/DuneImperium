using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x02000142 RID: 322
	public class MachineCulture : WormArchetype
	{
		// Token: 0x060011A1 RID: 4513 RVA: 0x000A0300 File Offset: 0x0009E500
		// Note: this type is marked as 'beforefieldinit'.
		static MachineCulture()
		{
			Il2CppClassPointerStore<MachineCulture>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "MachineCulture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MachineCulture>.NativeClassPtr);
			MachineCulture.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MachineCulture>.NativeClassPtr, "archID");
			MachineCulture.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MachineCulture>.NativeClassPtr, 100666276);
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x000A0358 File Offset: 0x0009E558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89992, XrefRangeEnd = 90127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MachineCulture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MachineCulture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MachineCulture.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00008E7C File Offset: 0x0000707C
		public MachineCulture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x000A0394 File Offset: 0x0009E594
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x00008E85 File Offset: 0x00007085
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MachineCulture.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MachineCulture.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
