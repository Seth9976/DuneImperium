using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x02000141 RID: 321
	public class IxianProbe : WormArchetype
	{
		// Token: 0x0600119C RID: 4508 RVA: 0x000A0244 File Offset: 0x0009E444
		// Note: this type is marked as 'beforefieldinit'.
		static IxianProbe()
		{
			Il2CppClassPointerStore<IxianProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "IxianProbe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IxianProbe>.NativeClassPtr);
			IxianProbe.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IxianProbe>.NativeClassPtr, "archID");
			IxianProbe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IxianProbe>.NativeClassPtr, 100666274);
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000A029C File Offset: 0x0009E49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89872, XrefRangeEnd = 89992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IxianProbe()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IxianProbe>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IxianProbe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00008E61 File Offset: 0x00007061
		public IxianProbe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x000A02D8 File Offset: 0x0009E4D8
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x00008E6A File Offset: 0x0000706A
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IxianProbe.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IxianProbe.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
