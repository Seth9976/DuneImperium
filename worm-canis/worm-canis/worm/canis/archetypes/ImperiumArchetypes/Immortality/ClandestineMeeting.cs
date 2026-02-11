using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x02000197 RID: 407
	public class ClandestineMeeting : WormArchetype
	{
		// Token: 0x0600134A RID: 4938 RVA: 0x000A416C File Offset: 0x000A236C
		// Note: this type is marked as 'beforefieldinit'.
		static ClandestineMeeting()
		{
			Il2CppClassPointerStore<ClandestineMeeting>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "ClandestineMeeting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClandestineMeeting>.NativeClassPtr);
			ClandestineMeeting.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClandestineMeeting>.NativeClassPtr, "archID");
			ClandestineMeeting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClandestineMeeting>.NativeClassPtr, 100666446);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x000A41C4 File Offset: 0x000A23C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102479, XrefRangeEnd = 102683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClandestineMeeting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClandestineMeeting>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClandestineMeeting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00009773 File Offset: 0x00007973
		public ClandestineMeeting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x000A4200 File Offset: 0x000A2400
		// (set) Token: 0x0600134E RID: 4942 RVA: 0x0000977C File Offset: 0x0000797C
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClandestineMeeting.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClandestineMeeting.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
