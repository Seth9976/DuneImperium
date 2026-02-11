using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001DF RID: 479
	public class TheSpiceMustFlow : WormArchetype
	{
		// Token: 0x060014B2 RID: 5298 RVA: 0x000A764C File Offset: 0x000A584C
		// Note: this type is marked as 'beforefieldinit'.
		static TheSpiceMustFlow()
		{
			Il2CppClassPointerStore<TheSpiceMustFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "TheSpiceMustFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheSpiceMustFlow>.NativeClassPtr);
			TheSpiceMustFlow.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheSpiceMustFlow>.NativeClassPtr, "archID");
			TheSpiceMustFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheSpiceMustFlow>.NativeClassPtr, 100666590);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x000A76A4 File Offset: 0x000A58A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116297, XrefRangeEnd = 116461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TheSpiceMustFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TheSpiceMustFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TheSpiceMustFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00009F0B File Offset: 0x0000810B
		public TheSpiceMustFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x000A76E0 File Offset: 0x000A58E0
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x00009F14 File Offset: 0x00008114
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TheSpiceMustFlow.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TheSpiceMustFlow.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
