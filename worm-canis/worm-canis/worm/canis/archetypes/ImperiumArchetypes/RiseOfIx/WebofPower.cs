using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000192 RID: 402
	public class WebofPower : WormArchetype
	{
		// Token: 0x06001331 RID: 4913 RVA: 0x000A3DC0 File Offset: 0x000A1FC0
		// Note: this type is marked as 'beforefieldinit'.
		static WebofPower()
		{
			Il2CppClassPointerStore<WebofPower>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "WebofPower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebofPower>.NativeClassPtr);
			WebofPower.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebofPower>.NativeClassPtr, "archID");
			WebofPower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebofPower>.NativeClassPtr, 100666436);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x000A3E18 File Offset: 0x000A2018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101468, XrefRangeEnd = 101710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebofPower()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebofPower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebofPower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x000096EC File Offset: 0x000078EC
		public WebofPower(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x000A3E54 File Offset: 0x000A2054
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x000096F5 File Offset: 0x000078F5
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebofPower.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebofPower.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
