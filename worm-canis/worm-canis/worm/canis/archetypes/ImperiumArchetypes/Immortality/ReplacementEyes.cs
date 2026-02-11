using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001A5 RID: 421
	public class ReplacementEyes : WormArchetype
	{
		// Token: 0x06001390 RID: 5008 RVA: 0x000A4BB4 File Offset: 0x000A2DB4
		// Note: this type is marked as 'beforefieldinit'.
		static ReplacementEyes()
		{
			Il2CppClassPointerStore<ReplacementEyes>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "ReplacementEyes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplacementEyes>.NativeClassPtr);
			ReplacementEyes.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplacementEyes>.NativeClassPtr, "archID");
			ReplacementEyes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplacementEyes>.NativeClassPtr, 100666474);
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x000A4C0C File Offset: 0x000A2E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105318, XrefRangeEnd = 105532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReplacementEyes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplacementEyes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplacementEyes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x000098ED File Offset: 0x00007AED
		public ReplacementEyes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x000A4C48 File Offset: 0x000A2E48
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x000098F6 File Offset: 0x00007AF6
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReplacementEyes.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReplacementEyes.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
