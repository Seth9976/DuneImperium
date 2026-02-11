using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000185 RID: 389
	public class IxGuildCompact : WormArchetype
	{
		// Token: 0x060012F0 RID: 4848 RVA: 0x000A3434 File Offset: 0x000A1634
		// Note: this type is marked as 'beforefieldinit'.
		static IxGuildCompact()
		{
			Il2CppClassPointerStore<IxGuildCompact>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "IxGuildCompact");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IxGuildCompact>.NativeClassPtr);
			IxGuildCompact.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IxGuildCompact>.NativeClassPtr, "archID");
			IxGuildCompact.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IxGuildCompact>.NativeClassPtr, 100666410);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x000A348C File Offset: 0x000A168C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98842, XrefRangeEnd = 99050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IxGuildCompact()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IxGuildCompact>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IxGuildCompact.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0000958D File Offset: 0x0000778D
		public IxGuildCompact(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x000A34C8 File Offset: 0x000A16C8
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x00009596 File Offset: 0x00007796
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IxGuildCompact.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IxGuildCompact.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
