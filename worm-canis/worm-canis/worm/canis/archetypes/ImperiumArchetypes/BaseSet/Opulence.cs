using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001CC RID: 460
	public class Opulence : WormArchetype
	{
		// Token: 0x06001453 RID: 5203 RVA: 0x000A6858 File Offset: 0x000A4A58
		// Note: this type is marked as 'beforefieldinit'.
		static Opulence()
		{
			Il2CppClassPointerStore<Opulence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "Opulence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Opulence>.NativeClassPtr);
			Opulence.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Opulence>.NativeClassPtr, "archID");
			Opulence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Opulence>.NativeClassPtr, 100666552);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x000A68B0 File Offset: 0x000A4AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112724, XrefRangeEnd = 112911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Opulence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Opulence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Opulence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00009D0A File Offset: 0x00007F0A
		public Opulence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x000A68EC File Offset: 0x000A4AEC
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x00009D13 File Offset: 0x00007F13
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Opulence.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Opulence.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
