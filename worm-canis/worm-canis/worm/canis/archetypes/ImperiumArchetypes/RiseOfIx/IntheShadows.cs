using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000184 RID: 388
	public class IntheShadows : WormArchetype
	{
		// Token: 0x060012EB RID: 4843 RVA: 0x000A3378 File Offset: 0x000A1578
		// Note: this type is marked as 'beforefieldinit'.
		static IntheShadows()
		{
			Il2CppClassPointerStore<IntheShadows>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "IntheShadows");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntheShadows>.NativeClassPtr);
			IntheShadows.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntheShadows>.NativeClassPtr, "archID");
			IntheShadows.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntheShadows>.NativeClassPtr, 100666408);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x000A33D0 File Offset: 0x000A15D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98633, XrefRangeEnd = 98842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntheShadows()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntheShadows>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntheShadows.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00009572 File Offset: 0x00007772
		public IntheShadows(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x000A340C File Offset: 0x000A160C
		// (set) Token: 0x060012EF RID: 4847 RVA: 0x0000957B File Offset: 0x0000777B
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IntheShadows.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntheShadows.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
