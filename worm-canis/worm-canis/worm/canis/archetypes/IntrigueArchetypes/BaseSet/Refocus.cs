using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x0200016B RID: 363
	public class Refocus : WormArchetype
	{
		// Token: 0x0600126E RID: 4718 RVA: 0x000A211C File Offset: 0x000A031C
		// Note: this type is marked as 'beforefieldinit'.
		static Refocus()
		{
			Il2CppClassPointerStore<Refocus>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "Refocus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Refocus>.NativeClassPtr);
			Refocus.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refocus>.NativeClassPtr, "archID");
			Refocus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Refocus>.NativeClassPtr, 100666358);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x000A2174 File Offset: 0x000A0374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94641, XrefRangeEnd = 94747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Refocus()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Refocus>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Refocus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x000092CF File Offset: 0x000074CF
		public Refocus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x000A21B0 File Offset: 0x000A03B0
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x000092D8 File Offset: 0x000074D8
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Refocus.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Refocus.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
