using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.Immortality
{
	// Token: 0x0200012F RID: 303
	public class BlankSlateLeader : WormArchetype
	{
		// Token: 0x06001142 RID: 4418 RVA: 0x0009F50C File Offset: 0x0009D70C
		// Note: this type is marked as 'beforefieldinit'.
		static BlankSlateLeader()
		{
			Il2CppClassPointerStore<BlankSlateLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.Immortality", "BlankSlateLeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlankSlateLeader>.NativeClassPtr);
			BlankSlateLeader.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlankSlateLeader>.NativeClassPtr, "archID");
			BlankSlateLeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlankSlateLeader>.NativeClassPtr, 100666238);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0009F564 File Offset: 0x0009D764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87908, XrefRangeEnd = 87962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlankSlateLeader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlankSlateLeader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlankSlateLeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00008C7B File Offset: 0x00006E7B
		public BlankSlateLeader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0009F5A0 File Offset: 0x0009D7A0
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x00008C84 File Offset: 0x00006E84
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BlankSlateLeader.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlankSlateLeader.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
