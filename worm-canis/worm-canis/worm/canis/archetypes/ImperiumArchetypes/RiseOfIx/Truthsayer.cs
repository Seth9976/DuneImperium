using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000190 RID: 400
	public class Truthsayer : WormArchetype
	{
		// Token: 0x06001327 RID: 4903 RVA: 0x000A3C48 File Offset: 0x000A1E48
		// Note: this type is marked as 'beforefieldinit'.
		static Truthsayer()
		{
			Il2CppClassPointerStore<Truthsayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "Truthsayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Truthsayer>.NativeClassPtr);
			Truthsayer.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Truthsayer>.NativeClassPtr, "archID");
			Truthsayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Truthsayer>.NativeClassPtr, 100666432);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x000A3CA0 File Offset: 0x000A1EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101071, XrefRangeEnd = 101281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Truthsayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Truthsayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Truthsayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x000096B6 File Offset: 0x000078B6
		public Truthsayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x000A3CDC File Offset: 0x000A1EDC
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x000096BF File Offset: 0x000078BF
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Truthsayer.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Truthsayer.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
