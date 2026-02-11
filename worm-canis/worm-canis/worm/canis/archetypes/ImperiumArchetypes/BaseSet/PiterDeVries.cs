using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001CE RID: 462
	public class PiterDeVries : WormArchetype
	{
		// Token: 0x0600145D RID: 5213 RVA: 0x000A69D0 File Offset: 0x000A4BD0
		// Note: this type is marked as 'beforefieldinit'.
		static PiterDeVries()
		{
			Il2CppClassPointerStore<PiterDeVries>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "PiterDeVries");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PiterDeVries>.NativeClassPtr);
			PiterDeVries.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PiterDeVries>.NativeClassPtr, "archID");
			PiterDeVries.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PiterDeVries>.NativeClassPtr, 100666556);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x000A6A28 File Offset: 0x000A4C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113106, XrefRangeEnd = 113306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PiterDeVries()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PiterDeVries>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PiterDeVries.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00009D40 File Offset: 0x00007F40
		public PiterDeVries(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x000A6A64 File Offset: 0x000A4C64
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x00009D49 File Offset: 0x00007F49
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PiterDeVries.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PiterDeVries.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
