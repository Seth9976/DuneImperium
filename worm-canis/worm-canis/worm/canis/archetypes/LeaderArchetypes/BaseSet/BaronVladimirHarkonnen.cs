using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.BaseSet
{
	// Token: 0x02000130 RID: 304
	public class BaronVladimirHarkonnen : WormArchetype
	{
		// Token: 0x06001147 RID: 4423 RVA: 0x0009F5C8 File Offset: 0x0009D7C8
		// Note: this type is marked as 'beforefieldinit'.
		static BaronVladimirHarkonnen()
		{
			Il2CppClassPointerStore<BaronVladimirHarkonnen>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.BaseSet", "BaronVladimirHarkonnen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaronVladimirHarkonnen>.NativeClassPtr);
			BaronVladimirHarkonnen.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaronVladimirHarkonnen>.NativeClassPtr, "archID");
			BaronVladimirHarkonnen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaronVladimirHarkonnen>.NativeClassPtr, 100666240);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0009F620 File Offset: 0x0009D820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87962, XrefRangeEnd = 88076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaronVladimirHarkonnen()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaronVladimirHarkonnen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaronVladimirHarkonnen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00008C96 File Offset: 0x00006E96
		public BaronVladimirHarkonnen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0009F65C File Offset: 0x0009D85C
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x00008C9F File Offset: 0x00006E9F
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaronVladimirHarkonnen.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaronVladimirHarkonnen.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
