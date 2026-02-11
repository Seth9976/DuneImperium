using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001D4 RID: 468
	public class Scout : WormArchetype
	{
		// Token: 0x0600147B RID: 5243 RVA: 0x000A6E38 File Offset: 0x000A5038
		// Note: this type is marked as 'beforefieldinit'.
		static Scout()
		{
			Il2CppClassPointerStore<Scout>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "Scout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scout>.NativeClassPtr);
			Scout.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scout>.NativeClassPtr, "archID");
			Scout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scout>.NativeClassPtr, 100666568);
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x000A6E90 File Offset: 0x000A5090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114204, XrefRangeEnd = 114385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Scout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00009DE2 File Offset: 0x00007FE2
		public Scout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x000A6ECC File Offset: 0x000A50CC
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x00009DEB File Offset: 0x00007FEB
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Scout.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Scout.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
