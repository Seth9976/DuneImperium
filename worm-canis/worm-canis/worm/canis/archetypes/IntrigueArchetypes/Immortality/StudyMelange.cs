using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.Immortality
{
	// Token: 0x02000151 RID: 337
	public class StudyMelange : WormArchetype
	{
		// Token: 0x060011EC RID: 4588 RVA: 0x000A0E04 File Offset: 0x0009F004
		// Note: this type is marked as 'beforefieldinit'.
		static StudyMelange()
		{
			Il2CppClassPointerStore<StudyMelange>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.Immortality", "StudyMelange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudyMelange>.NativeClassPtr);
			StudyMelange.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudyMelange>.NativeClassPtr, "archID");
			StudyMelange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudyMelange>.NativeClassPtr, 100666306);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000A0E5C File Offset: 0x0009F05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91756, XrefRangeEnd = 91886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StudyMelange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudyMelange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StudyMelange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00009011 File Offset: 0x00007211
		public StudyMelange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x000A0E98 File Offset: 0x0009F098
		// (set) Token: 0x060011F0 RID: 4592 RVA: 0x0000901A File Offset: 0x0000721A
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StudyMelange.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StudyMelange.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
