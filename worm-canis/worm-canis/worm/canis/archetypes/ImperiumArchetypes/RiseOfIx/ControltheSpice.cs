using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000179 RID: 377
	public class ControltheSpice : WormArchetype
	{
		// Token: 0x060012B4 RID: 4788 RVA: 0x000A2B64 File Offset: 0x000A0D64
		// Note: this type is marked as 'beforefieldinit'.
		static ControltheSpice()
		{
			Il2CppClassPointerStore<ControltheSpice>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "ControltheSpice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControltheSpice>.NativeClassPtr);
			ControltheSpice.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControltheSpice>.NativeClassPtr, "archID");
			ControltheSpice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControltheSpice>.NativeClassPtr, 100666386);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000A2BBC File Offset: 0x000A0DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96429, XrefRangeEnd = 96576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControltheSpice()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControltheSpice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControltheSpice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00009449 File Offset: 0x00007649
		public ControltheSpice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x000A2BF8 File Offset: 0x000A0DF8
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x00009452 File Offset: 0x00007652
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ControltheSpice.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ControltheSpice.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
