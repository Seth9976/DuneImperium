using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x0200016E RID: 366
	public class StagedIncident : WormArchetype
	{
		// Token: 0x0600127D RID: 4733 RVA: 0x000A2350 File Offset: 0x000A0550
		// Note: this type is marked as 'beforefieldinit'.
		static StagedIncident()
		{
			Il2CppClassPointerStore<StagedIncident>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "StagedIncident");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StagedIncident>.NativeClassPtr);
			StagedIncident.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StagedIncident>.NativeClassPtr, "archID");
			StagedIncident.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StagedIncident>.NativeClassPtr, 100666364);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000A23A8 File Offset: 0x000A05A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94967, XrefRangeEnd = 95068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StagedIncident()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StagedIncident>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StagedIncident.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00009320 File Offset: 0x00007520
		public StagedIncident(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x000A23E4 File Offset: 0x000A05E4
		// (set) Token: 0x06001281 RID: 4737 RVA: 0x00009329 File Offset: 0x00007529
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StagedIncident.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StagedIncident.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
