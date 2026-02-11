using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.BaseSet
{
	// Token: 0x02000135 RID: 309
	public class GlossuTheBeastRabban : WormArchetype
	{
		// Token: 0x06001160 RID: 4448 RVA: 0x0009F974 File Offset: 0x0009DB74
		// Note: this type is marked as 'beforefieldinit'.
		static GlossuTheBeastRabban()
		{
			Il2CppClassPointerStore<GlossuTheBeastRabban>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.BaseSet", "GlossuTheBeastRabban");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlossuTheBeastRabban>.NativeClassPtr);
			GlossuTheBeastRabban.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlossuTheBeastRabban>.NativeClassPtr, "archID");
			GlossuTheBeastRabban.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlossuTheBeastRabban>.NativeClassPtr, 100666250);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0009F9CC File Offset: 0x0009DBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88532, XrefRangeEnd = 88637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlossuTheBeastRabban()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlossuTheBeastRabban>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlossuTheBeastRabban.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00008D1D File Offset: 0x00006F1D
		public GlossuTheBeastRabban(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0009FA08 File Offset: 0x0009DC08
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x00008D26 File Offset: 0x00006F26
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GlossuTheBeastRabban.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlossuTheBeastRabban.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
