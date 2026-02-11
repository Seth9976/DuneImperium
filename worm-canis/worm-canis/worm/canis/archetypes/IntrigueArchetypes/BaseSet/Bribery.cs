using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000157 RID: 343
	public class Bribery : WormArchetype
	{
		// Token: 0x0600120A RID: 4618 RVA: 0x000A126C File Offset: 0x0009F46C
		// Note: this type is marked as 'beforefieldinit'.
		static Bribery()
		{
			Il2CppClassPointerStore<Bribery>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "Bribery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bribery>.NativeClassPtr);
			Bribery.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bribery>.NativeClassPtr, "archID");
			Bribery.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bribery>.NativeClassPtr, 100666318);
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x000A12C4 File Offset: 0x0009F4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92473, XrefRangeEnd = 92579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bribery()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bribery>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bribery.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000090B3 File Offset: 0x000072B3
		public Bribery(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x000A1300 File Offset: 0x0009F500
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x000090BC File Offset: 0x000072BC
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Bribery.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Bribery.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
