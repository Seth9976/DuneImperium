using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x02000108 RID: 264
	public class SonicSnoopers : WormArchetype
	{
		// Token: 0x0600107F RID: 4223 RVA: 0x0009D868 File Offset: 0x0009BA68
		// Note: this type is marked as 'beforefieldinit'.
		static SonicSnoopers()
		{
			Il2CppClassPointerStore<SonicSnoopers>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "SonicSnoopers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SonicSnoopers>.NativeClassPtr);
			SonicSnoopers.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SonicSnoopers>.NativeClassPtr, "archID");
			SonicSnoopers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SonicSnoopers>.NativeClassPtr, 100666160);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0009D8C0 File Offset: 0x0009BAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82909, XrefRangeEnd = 83035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SonicSnoopers()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SonicSnoopers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SonicSnoopers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0000885E File Offset: 0x00006A5E
		public SonicSnoopers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x0009D8FC File Offset: 0x0009BAFC
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x00008867 File Offset: 0x00006A67
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SonicSnoopers.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SonicSnoopers.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
