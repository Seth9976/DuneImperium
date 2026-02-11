using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001C7 RID: 455
	public class ImperialSpy : WormArchetype
	{
		// Token: 0x0600143A RID: 5178 RVA: 0x000A64AC File Offset: 0x000A46AC
		// Note: this type is marked as 'beforefieldinit'.
		static ImperialSpy()
		{
			Il2CppClassPointerStore<ImperialSpy>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "ImperialSpy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImperialSpy>.NativeClassPtr);
			ImperialSpy.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImperialSpy>.NativeClassPtr, "archID");
			ImperialSpy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImperialSpy>.NativeClassPtr, 100666542);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000A6504 File Offset: 0x000A4704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111705, XrefRangeEnd = 111897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImperialSpy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImperialSpy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImperialSpy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00009C83 File Offset: 0x00007E83
		public ImperialSpy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x000A6540 File Offset: 0x000A4740
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x00009C8C File Offset: 0x00007E8C
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImperialSpy.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImperialSpy.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
