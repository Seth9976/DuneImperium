using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001CD RID: 461
	public class OtherMemory : WormArchetype
	{
		// Token: 0x06001458 RID: 5208 RVA: 0x000A6914 File Offset: 0x000A4B14
		// Note: this type is marked as 'beforefieldinit'.
		static OtherMemory()
		{
			Il2CppClassPointerStore<OtherMemory>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "OtherMemory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OtherMemory>.NativeClassPtr);
			OtherMemory.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OtherMemory>.NativeClassPtr, "archID");
			OtherMemory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OtherMemory>.NativeClassPtr, 100666554);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x000A696C File Offset: 0x000A4B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112911, XrefRangeEnd = 113106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OtherMemory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OtherMemory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OtherMemory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00009D25 File Offset: 0x00007F25
		public OtherMemory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x000A69A8 File Offset: 0x000A4BA8
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x00009D2E File Offset: 0x00007F2E
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OtherMemory.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OtherMemory.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
