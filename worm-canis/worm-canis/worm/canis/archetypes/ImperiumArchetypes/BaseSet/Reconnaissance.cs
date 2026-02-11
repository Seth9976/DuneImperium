using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001D0 RID: 464
	public class Reconnaissance : WormArchetype
	{
		// Token: 0x06001467 RID: 5223 RVA: 0x000A6B48 File Offset: 0x000A4D48
		// Note: this type is marked as 'beforefieldinit'.
		static Reconnaissance()
		{
			Il2CppClassPointerStore<Reconnaissance>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "Reconnaissance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Reconnaissance>.NativeClassPtr);
			Reconnaissance.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Reconnaissance>.NativeClassPtr, "archID");
			Reconnaissance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reconnaissance>.NativeClassPtr, 100666560);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x000A6BA0 File Offset: 0x000A4DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113488, XrefRangeEnd = 113628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Reconnaissance()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Reconnaissance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Reconnaissance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00009D76 File Offset: 0x00007F76
		public Reconnaissance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x000A6BDC File Offset: 0x000A4DDC
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x00009D7F File Offset: 0x00007F7F
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Reconnaissance.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Reconnaissance.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
