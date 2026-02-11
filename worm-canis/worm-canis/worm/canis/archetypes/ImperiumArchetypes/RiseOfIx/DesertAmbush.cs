using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x0200017B RID: 379
	public class DesertAmbush : WormArchetype
	{
		// Token: 0x060012BE RID: 4798 RVA: 0x000A2CDC File Offset: 0x000A0EDC
		// Note: this type is marked as 'beforefieldinit'.
		static DesertAmbush()
		{
			Il2CppClassPointerStore<DesertAmbush>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "DesertAmbush");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesertAmbush>.NativeClassPtr);
			DesertAmbush.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbush>.NativeClassPtr, "archID");
			DesertAmbush.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbush>.NativeClassPtr, 100666390);
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x000A2D34 File Offset: 0x000A0F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96782, XrefRangeEnd = 96964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DesertAmbush()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertAmbush>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbush.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0000947F File Offset: 0x0000767F
		public DesertAmbush(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x000A2D70 File Offset: 0x000A0F70
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x00009488 File Offset: 0x00007688
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesertAmbush.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesertAmbush.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
