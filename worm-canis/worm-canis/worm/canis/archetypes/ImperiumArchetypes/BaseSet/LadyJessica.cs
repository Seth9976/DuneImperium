using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001C9 RID: 457
	public class LadyJessica : WormArchetype
	{
		// Token: 0x06001444 RID: 5188 RVA: 0x000A6624 File Offset: 0x000A4824
		// Note: this type is marked as 'beforefieldinit'.
		static LadyJessica()
		{
			Il2CppClassPointerStore<LadyJessica>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "LadyJessica");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LadyJessica>.NativeClassPtr);
			LadyJessica.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadyJessica>.NativeClassPtr, "archID");
			LadyJessica.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadyJessica>.NativeClassPtr, 100666546);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x000A667C File Offset: 0x000A487C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112079, XrefRangeEnd = 112321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LadyJessica()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LadyJessica>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadyJessica.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00009CB9 File Offset: 0x00007EB9
		public LadyJessica(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x000A66B8 File Offset: 0x000A48B8
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LadyJessica.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LadyJessica.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
