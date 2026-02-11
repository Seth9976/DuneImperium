using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000125 RID: 293
	public class Stillsuits : WormArchetype
	{
		// Token: 0x06001110 RID: 4368 RVA: 0x0009EDB4 File Offset: 0x0009CFB4
		// Note: this type is marked as 'beforefieldinit'.
		static Stillsuits()
		{
			Il2CppClassPointerStore<Stillsuits>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "Stillsuits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stillsuits>.NativeClassPtr);
			Stillsuits.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stillsuits>.NativeClassPtr, "archID");
			Stillsuits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stillsuits>.NativeClassPtr, 100666218);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0009EE0C File Offset: 0x0009D00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86689, XrefRangeEnd = 86843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stillsuits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stillsuits>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stillsuits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00008B6D File Offset: 0x00006D6D
		public Stillsuits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x0009EE48 File Offset: 0x0009D048
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x00008B76 File Offset: 0x00006D76
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Stillsuits.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stillsuits.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
