using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001C8 RID: 456
	public class KwisatzHaderach : WormArchetype
	{
		// Token: 0x0600143F RID: 5183 RVA: 0x000A6568 File Offset: 0x000A4768
		// Note: this type is marked as 'beforefieldinit'.
		static KwisatzHaderach()
		{
			Il2CppClassPointerStore<KwisatzHaderach>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "KwisatzHaderach");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KwisatzHaderach>.NativeClassPtr);
			KwisatzHaderach.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KwisatzHaderach>.NativeClassPtr, "archID");
			KwisatzHaderach.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KwisatzHaderach>.NativeClassPtr, 100666544);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000A65C0 File Offset: 0x000A47C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111897, XrefRangeEnd = 112079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KwisatzHaderach()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KwisatzHaderach>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KwisatzHaderach.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00009C9E File Offset: 0x00007E9E
		public KwisatzHaderach(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x000A65FC File Offset: 0x000A47FC
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x00009CA7 File Offset: 0x00007EA7
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KwisatzHaderach.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KwisatzHaderach.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
