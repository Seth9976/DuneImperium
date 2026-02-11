using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000154 RID: 340
	public class AlliedArmada : WormArchetype
	{
		// Token: 0x060011FB RID: 4603 RVA: 0x000A1038 File Offset: 0x0009F238
		// Note: this type is marked as 'beforefieldinit'.
		static AlliedArmada()
		{
			Il2CppClassPointerStore<AlliedArmada>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "AlliedArmada");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlliedArmada>.NativeClassPtr);
			AlliedArmada.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlliedArmada>.NativeClassPtr, "archID");
			AlliedArmada.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlliedArmada>.NativeClassPtr, 100666312);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x000A1090 File Offset: 0x0009F290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92146, XrefRangeEnd = 92259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AlliedArmada()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlliedArmada>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlliedArmada.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00009062 File Offset: 0x00007262
		public AlliedArmada(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x000A10CC File Offset: 0x0009F2CC
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x0000906B File Offset: 0x0000726B
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AlliedArmada.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AlliedArmada.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
