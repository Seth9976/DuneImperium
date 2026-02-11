using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001AC RID: 428
	public class TleilaxuMaster : WormArchetype
	{
		// Token: 0x060013B3 RID: 5043 RVA: 0x000A50D8 File Offset: 0x000A32D8
		// Note: this type is marked as 'beforefieldinit'.
		static TleilaxuMaster()
		{
			Il2CppClassPointerStore<TleilaxuMaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "TleilaxuMaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TleilaxuMaster>.NativeClassPtr);
			TleilaxuMaster.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuMaster>.NativeClassPtr, "archID");
			TleilaxuMaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuMaster>.NativeClassPtr, 100666488);
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x000A5130 File Offset: 0x000A3330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106751, XrefRangeEnd = 106956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TleilaxuMaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TleilaxuMaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuMaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x000099AA File Offset: 0x00007BAA
		public TleilaxuMaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x000A516C File Offset: 0x000A336C
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x000099B3 File Offset: 0x00007BB3
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TleilaxuMaster.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TleilaxuMaster.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
