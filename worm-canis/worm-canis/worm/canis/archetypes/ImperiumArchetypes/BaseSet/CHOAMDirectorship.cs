using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001B5 RID: 437
	public class CHOAMDirectorship : WormArchetype
	{
		// Token: 0x060013E0 RID: 5088 RVA: 0x000A5774 File Offset: 0x000A3974
		// Note: this type is marked as 'beforefieldinit'.
		static CHOAMDirectorship()
		{
			Il2CppClassPointerStore<CHOAMDirectorship>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "CHOAMDirectorship");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CHOAMDirectorship>.NativeClassPtr);
			CHOAMDirectorship.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CHOAMDirectorship>.NativeClassPtr, "archID");
			CHOAMDirectorship.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CHOAMDirectorship>.NativeClassPtr, 100666506);
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x000A57CC File Offset: 0x000A39CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108451, XrefRangeEnd = 108624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CHOAMDirectorship()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CHOAMDirectorship>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CHOAMDirectorship.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00009A9D File Offset: 0x00007C9D
		public CHOAMDirectorship(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x000A5808 File Offset: 0x000A3A08
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x00009AA6 File Offset: 0x00007CA6
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CHOAMDirectorship.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CHOAMDirectorship.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
