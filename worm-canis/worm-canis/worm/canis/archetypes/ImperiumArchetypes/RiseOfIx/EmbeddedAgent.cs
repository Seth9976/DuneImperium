using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x0200017C RID: 380
	public class EmbeddedAgent : WormArchetype
	{
		// Token: 0x060012C3 RID: 4803 RVA: 0x000A2D98 File Offset: 0x000A0F98
		// Note: this type is marked as 'beforefieldinit'.
		static EmbeddedAgent()
		{
			Il2CppClassPointerStore<EmbeddedAgent>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "EmbeddedAgent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmbeddedAgent>.NativeClassPtr);
			EmbeddedAgent.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedAgent>.NativeClassPtr, "archID");
			EmbeddedAgent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedAgent>.NativeClassPtr, 100666392);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x000A2DF0 File Offset: 0x000A0FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96964, XrefRangeEnd = 97187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmbeddedAgent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmbeddedAgent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedAgent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0000949A File Offset: 0x0000769A
		public EmbeddedAgent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x000A2E2C File Offset: 0x000A102C
		// (set) Token: 0x060012C7 RID: 4807 RVA: 0x000094A3 File Offset: 0x000076A3
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EmbeddedAgent.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmbeddedAgent.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
