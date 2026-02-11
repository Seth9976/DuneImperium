using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001D8 RID: 472
	public class SignetRing : WormArchetype
	{
		// Token: 0x0600148F RID: 5263 RVA: 0x000A7128 File Offset: 0x000A5328
		// Note: this type is marked as 'beforefieldinit'.
		static SignetRing()
		{
			Il2CppClassPointerStore<SignetRing>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "SignetRing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignetRing>.NativeClassPtr);
			SignetRing.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignetRing>.NativeClassPtr, "archID");
			SignetRing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignetRing>.NativeClassPtr, 100666576);
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000A7180 File Offset: 0x000A5380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114928, XrefRangeEnd = 115079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SignetRing()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignetRing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SignetRing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00009E4E File Offset: 0x0000804E
		public SignetRing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x000A71BC File Offset: 0x000A53BC
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x00009E57 File Offset: 0x00008057
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SignetRing.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SignetRing.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
