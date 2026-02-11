using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001A7 RID: 423
	public class ShadoutMapes : WormArchetype
	{
		// Token: 0x0600139A RID: 5018 RVA: 0x000A4D2C File Offset: 0x000A2F2C
		// Note: this type is marked as 'beforefieldinit'.
		static ShadoutMapes()
		{
			Il2CppClassPointerStore<ShadoutMapes>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "ShadoutMapes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadoutMapes>.NativeClassPtr);
			ShadoutMapes.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadoutMapes>.NativeClassPtr, "archID");
			ShadoutMapes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadoutMapes>.NativeClassPtr, 100666478);
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x000A4D84 File Offset: 0x000A2F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105745, XrefRangeEnd = 105944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadoutMapes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadoutMapes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadoutMapes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00009923 File Offset: 0x00007B23
		public ShadoutMapes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x000A4DC0 File Offset: 0x000A2FC0
		// (set) Token: 0x0600139E RID: 5022 RVA: 0x0000992C File Offset: 0x00007B2C
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadoutMapes.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadoutMapes.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
