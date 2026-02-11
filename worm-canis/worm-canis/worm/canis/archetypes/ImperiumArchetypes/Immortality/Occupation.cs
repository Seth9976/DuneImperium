using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001A2 RID: 418
	public class Occupation : WormArchetype
	{
		// Token: 0x06001381 RID: 4993 RVA: 0x000A4980 File Offset: 0x000A2B80
		// Note: this type is marked as 'beforefieldinit'.
		static Occupation()
		{
			Il2CppClassPointerStore<Occupation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "Occupation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Occupation>.NativeClassPtr);
			Occupation.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Occupation>.NativeClassPtr, "archID");
			Occupation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Occupation>.NativeClassPtr, 100666468);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x000A49D8 File Offset: 0x000A2BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104691, XrefRangeEnd = 104941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Occupation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Occupation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Occupation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0000989C File Offset: 0x00007A9C
		public Occupation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x000A4A14 File Offset: 0x000A2C14
		// (set) Token: 0x06001385 RID: 4997 RVA: 0x000098A5 File Offset: 0x00007AA5
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Occupation.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Occupation.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
