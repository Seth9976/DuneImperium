using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000158 RID: 344
	public class BypassProtocol : WormArchetype
	{
		// Token: 0x0600120F RID: 4623 RVA: 0x000A1328 File Offset: 0x0009F528
		// Note: this type is marked as 'beforefieldinit'.
		static BypassProtocol()
		{
			Il2CppClassPointerStore<BypassProtocol>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "BypassProtocol");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassProtocol>.NativeClassPtr);
			BypassProtocol.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocol>.NativeClassPtr, "archID");
			BypassProtocol.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocol>.NativeClassPtr, 100666320);
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x000A1380 File Offset: 0x0009F580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92579, XrefRangeEnd = 92685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BypassProtocol()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassProtocol>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocol.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x000090CE File Offset: 0x000072CE
		public BypassProtocol(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x000A13BC File Offset: 0x0009F5BC
		// (set) Token: 0x06001213 RID: 4627 RVA: 0x000090D7 File Offset: 0x000072D7
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BypassProtocol.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BypassProtocol.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
