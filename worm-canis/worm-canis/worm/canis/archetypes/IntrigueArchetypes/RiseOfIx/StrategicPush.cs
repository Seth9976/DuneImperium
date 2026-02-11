using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x02000146 RID: 326
	public class StrategicPush : WormArchetype
	{
		// Token: 0x060011B5 RID: 4533 RVA: 0x000A05F0 File Offset: 0x0009E7F0
		// Note: this type is marked as 'beforefieldinit'.
		static StrategicPush()
		{
			Il2CppClassPointerStore<StrategicPush>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "StrategicPush");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrategicPush>.NativeClassPtr);
			StrategicPush.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategicPush>.NativeClassPtr, "archID");
			StrategicPush.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategicPush>.NativeClassPtr, 100666284);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x000A0648 File Offset: 0x0009E848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90447, XrefRangeEnd = 90560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StrategicPush()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrategicPush>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategicPush.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00008EE8 File Offset: 0x000070E8
		public StrategicPush(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x000A0684 File Offset: 0x0009E884
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x00008EF1 File Offset: 0x000070F1
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StrategicPush.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StrategicPush.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
