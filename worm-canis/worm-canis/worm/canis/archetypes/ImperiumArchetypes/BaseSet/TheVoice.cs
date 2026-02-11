using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001E0 RID: 480
	public class TheVoice : WormArchetype
	{
		// Token: 0x060014B7 RID: 5303 RVA: 0x000A7708 File Offset: 0x000A5908
		// Note: this type is marked as 'beforefieldinit'.
		static TheVoice()
		{
			Il2CppClassPointerStore<TheVoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "TheVoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheVoice>.NativeClassPtr);
			TheVoice.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheVoice>.NativeClassPtr, "archID");
			TheVoice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheVoice>.NativeClassPtr, 100666592);
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x000A7760 File Offset: 0x000A5960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116461, XrefRangeEnd = 116646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TheVoice()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TheVoice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TheVoice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00009F26 File Offset: 0x00008126
		public TheVoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x000A779C File Offset: 0x000A599C
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x00009F2F File Offset: 0x0000812F
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TheVoice.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TheVoice.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
