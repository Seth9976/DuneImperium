using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000EC RID: 236
	public class CorrinoGenes : WormArchetype
	{
		// Token: 0x06000FF3 RID: 4083 RVA: 0x0009C3D8 File Offset: 0x0009A5D8
		// Note: this type is marked as 'beforefieldinit'.
		static CorrinoGenes()
		{
			Il2CppClassPointerStore<CorrinoGenes>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "CorrinoGenes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CorrinoGenes>.NativeClassPtr);
			CorrinoGenes.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CorrinoGenes>.NativeClassPtr, "archID");
			CorrinoGenes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorrinoGenes>.NativeClassPtr, 100666104);
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0009C430 File Offset: 0x0009A630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78730, XrefRangeEnd = 78932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CorrinoGenes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CorrinoGenes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CorrinoGenes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0000856A File Offset: 0x0000676A
		public CorrinoGenes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x0009C46C File Offset: 0x0009A66C
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x00008573 File Offset: 0x00006773
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CorrinoGenes.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CorrinoGenes.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
