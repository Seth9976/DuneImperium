using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000F7 RID: 247
	public class SubjectX137 : WormArchetype
	{
		// Token: 0x0600102A RID: 4138 RVA: 0x0009CBEC File Offset: 0x0009ADEC
		// Note: this type is marked as 'beforefieldinit'.
		static SubjectX137()
		{
			Il2CppClassPointerStore<SubjectX137>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "SubjectX137");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubjectX137>.NativeClassPtr);
			SubjectX137.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubjectX137>.NativeClassPtr, "archID");
			SubjectX137.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubjectX137>.NativeClassPtr, 100666126);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0009CC44 File Offset: 0x0009AE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80672, XrefRangeEnd = 80863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubjectX137()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubjectX137>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubjectX137.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00008693 File Offset: 0x00006893
		public SubjectX137(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x0009CC80 File Offset: 0x0009AE80
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x0000869C File Offset: 0x0000689C
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SubjectX137.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SubjectX137.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
