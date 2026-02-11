using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001D1 RID: 465
	public class ReverendMotherMohiam : WormArchetype
	{
		// Token: 0x0600146C RID: 5228 RVA: 0x000A6C04 File Offset: 0x000A4E04
		// Note: this type is marked as 'beforefieldinit'.
		static ReverendMotherMohiam()
		{
			Il2CppClassPointerStore<ReverendMotherMohiam>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "ReverendMotherMohiam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReverendMotherMohiam>.NativeClassPtr);
			ReverendMotherMohiam.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReverendMotherMohiam>.NativeClassPtr, "archID");
			ReverendMotherMohiam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReverendMotherMohiam>.NativeClassPtr, 100666562);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000A6C5C File Offset: 0x000A4E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113628, XrefRangeEnd = 113840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReverendMotherMohiam()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReverendMotherMohiam>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReverendMotherMohiam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00009D91 File Offset: 0x00007F91
		public ReverendMotherMohiam(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x000A6C98 File Offset: 0x000A4E98
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x00009D9A File Offset: 0x00007F9A
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReverendMotherMohiam.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReverendMotherMohiam.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
