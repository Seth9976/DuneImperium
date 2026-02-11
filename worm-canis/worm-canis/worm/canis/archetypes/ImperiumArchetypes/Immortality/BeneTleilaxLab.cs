using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x02000194 RID: 404
	public class BeneTleilaxLab : WormArchetype
	{
		// Token: 0x0600133B RID: 4923 RVA: 0x000A3F38 File Offset: 0x000A2138
		// Note: this type is marked as 'beforefieldinit'.
		static BeneTleilaxLab()
		{
			Il2CppClassPointerStore<BeneTleilaxLab>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "BeneTleilaxLab");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeneTleilaxLab>.NativeClassPtr);
			BeneTleilaxLab.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeneTleilaxLab>.NativeClassPtr, "archID");
			BeneTleilaxLab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeneTleilaxLab>.NativeClassPtr, 100666440);
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000A3F90 File Offset: 0x000A2190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101895, XrefRangeEnd = 102080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeneTleilaxLab()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeneTleilaxLab>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeneTleilaxLab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00009722 File Offset: 0x00007922
		public BeneTleilaxLab(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x000A3FCC File Offset: 0x000A21CC
		// (set) Token: 0x0600133F RID: 4927 RVA: 0x0000972B File Offset: 0x0000792B
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BeneTleilaxLab.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BeneTleilaxLab.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
