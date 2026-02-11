using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000167 RID: 359
	public class PoisonSnooper : WormArchetype
	{
		// Token: 0x0600125A RID: 4698 RVA: 0x000A1E2C File Offset: 0x000A002C
		// Note: this type is marked as 'beforefieldinit'.
		static PoisonSnooper()
		{
			Il2CppClassPointerStore<PoisonSnooper>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "PoisonSnooper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoisonSnooper>.NativeClassPtr);
			PoisonSnooper.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoisonSnooper>.NativeClassPtr, "archID");
			PoisonSnooper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoisonSnooper>.NativeClassPtr, 100666350);
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x000A1E84 File Offset: 0x000A0084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94206, XrefRangeEnd = 94312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoisonSnooper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoisonSnooper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoisonSnooper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00009263 File Offset: 0x00007463
		public PoisonSnooper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x000A1EC0 File Offset: 0x000A00C0
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x0000926C File Offset: 0x0000746C
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoisonSnooper.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoisonSnooper.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
