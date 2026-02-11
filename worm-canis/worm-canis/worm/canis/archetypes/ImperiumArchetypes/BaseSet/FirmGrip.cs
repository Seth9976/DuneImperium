using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001BE RID: 446
	public class FirmGrip : WormArchetype
	{
		// Token: 0x0600140D RID: 5133 RVA: 0x000A5E10 File Offset: 0x000A4010
		// Note: this type is marked as 'beforefieldinit'.
		static FirmGrip()
		{
			Il2CppClassPointerStore<FirmGrip>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "FirmGrip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FirmGrip>.NativeClassPtr);
			FirmGrip.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FirmGrip>.NativeClassPtr, "archID");
			FirmGrip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FirmGrip>.NativeClassPtr, 100666524);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x000A5E68 File Offset: 0x000A4068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109988, XrefRangeEnd = 110196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FirmGrip()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FirmGrip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FirmGrip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00009B90 File Offset: 0x00007D90
		public FirmGrip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x000A5EA4 File Offset: 0x000A40A4
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x00009B99 File Offset: 0x00007D99
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FirmGrip.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FirmGrip.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
