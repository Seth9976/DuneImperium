using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x02000211 RID: 529
	public class TerriblePurpose : WormArchetype
	{
		// Token: 0x060015AC RID: 5548 RVA: 0x000A9B04 File Offset: 0x000A7D04
		// Note: this type is marked as 'beforefieldinit'.
		static TerriblePurpose()
		{
			Il2CppClassPointerStore<TerriblePurpose>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "TerriblePurpose");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerriblePurpose>.NativeClassPtr);
			TerriblePurpose.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerriblePurpose>.NativeClassPtr, "archID");
			TerriblePurpose.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerriblePurpose>.NativeClassPtr, 100666690);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x000A9B5C File Offset: 0x000A7D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122347, XrefRangeEnd = 122452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TerriblePurpose()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerriblePurpose>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerriblePurpose.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x0000A451 File Offset: 0x00008651
		public TerriblePurpose(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x000A9B98 File Offset: 0x000A7D98
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x0000A45A File Offset: 0x0000865A
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TerriblePurpose.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TerriblePurpose.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
