using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000176 RID: 374
	public class Appropriate : WormArchetype
	{
		// Token: 0x060012A5 RID: 4773 RVA: 0x000A2930 File Offset: 0x000A0B30
		// Note: this type is marked as 'beforefieldinit'.
		static Appropriate()
		{
			Il2CppClassPointerStore<Appropriate>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "Appropriate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Appropriate>.NativeClassPtr);
			Appropriate.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Appropriate>.NativeClassPtr, "archID");
			Appropriate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Appropriate>.NativeClassPtr, 100666380);
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x000A2988 File Offset: 0x000A0B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95818, XrefRangeEnd = 96037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Appropriate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Appropriate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Appropriate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x000093F8 File Offset: 0x000075F8
		public Appropriate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x000A29C4 File Offset: 0x000A0BC4
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x00009401 File Offset: 0x00007601
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Appropriate.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Appropriate.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
