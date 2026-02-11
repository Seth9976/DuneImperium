using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000F2 RID: 242
	public class IndustrialEspionage : WormArchetype
	{
		// Token: 0x06001011 RID: 4113 RVA: 0x0009C840 File Offset: 0x0009AA40
		// Note: this type is marked as 'beforefieldinit'.
		static IndustrialEspionage()
		{
			Il2CppClassPointerStore<IndustrialEspionage>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "IndustrialEspionage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndustrialEspionage>.NativeClassPtr);
			IndustrialEspionage.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndustrialEspionage>.NativeClassPtr, "archID");
			IndustrialEspionage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndustrialEspionage>.NativeClassPtr, 100666116);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0009C898 File Offset: 0x0009AA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79821, XrefRangeEnd = 79998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndustrialEspionage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndustrialEspionage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndustrialEspionage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0000860C File Offset: 0x0000680C
		public IndustrialEspionage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0009C8D4 File Offset: 0x0009AAD4
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x00008615 File Offset: 0x00006815
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IndustrialEspionage.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IndustrialEspionage.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
