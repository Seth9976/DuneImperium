using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000159 RID: 345
	public class CalculatedHire : WormArchetype
	{
		// Token: 0x06001214 RID: 4628 RVA: 0x000A13E4 File Offset: 0x0009F5E4
		// Note: this type is marked as 'beforefieldinit'.
		static CalculatedHire()
		{
			Il2CppClassPointerStore<CalculatedHire>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "CalculatedHire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CalculatedHire>.NativeClassPtr);
			CalculatedHire.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculatedHire>.NativeClassPtr, "archID");
			CalculatedHire.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalculatedHire>.NativeClassPtr, 100666322);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000A143C File Offset: 0x0009F63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92685, XrefRangeEnd = 92786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalculatedHire()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalculatedHire>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalculatedHire.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x000090E9 File Offset: 0x000072E9
		public CalculatedHire(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x000A1478 File Offset: 0x0009F678
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x000090F2 File Offset: 0x000072F2
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CalculatedHire.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CalculatedHire.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
