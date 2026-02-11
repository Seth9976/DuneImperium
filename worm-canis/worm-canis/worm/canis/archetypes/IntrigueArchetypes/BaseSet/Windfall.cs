using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000175 RID: 373
	public class Windfall : WormArchetype
	{
		// Token: 0x060012A0 RID: 4768 RVA: 0x000A2874 File Offset: 0x000A0A74
		// Note: this type is marked as 'beforefieldinit'.
		static Windfall()
		{
			Il2CppClassPointerStore<Windfall>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "Windfall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Windfall>.NativeClassPtr);
			Windfall.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Windfall>.NativeClassPtr, "archID");
			Windfall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Windfall>.NativeClassPtr, 100666378);
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x000A28CC File Offset: 0x000A0ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95717, XrefRangeEnd = 95818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Windfall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Windfall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Windfall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x000093DD File Offset: 0x000075DD
		public Windfall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x000A2908 File Offset: 0x000A0B08
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x000093E6 File Offset: 0x000075E6
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Windfall.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Windfall.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
