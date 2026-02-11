using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000161 RID: 353
	public class FavoredSubject : WormArchetype
	{
		// Token: 0x0600123C RID: 4668 RVA: 0x000A19C4 File Offset: 0x0009FBC4
		// Note: this type is marked as 'beforefieldinit'.
		static FavoredSubject()
		{
			Il2CppClassPointerStore<FavoredSubject>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "FavoredSubject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FavoredSubject>.NativeClassPtr);
			FavoredSubject.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FavoredSubject>.NativeClassPtr, "archID");
			FavoredSubject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FavoredSubject>.NativeClassPtr, 100666338);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000A1A1C File Offset: 0x0009FC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93535, XrefRangeEnd = 93649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FavoredSubject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FavoredSubject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FavoredSubject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x000091C1 File Offset: 0x000073C1
		public FavoredSubject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x000A1A58 File Offset: 0x0009FC58
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x000091CA File Offset: 0x000073CA
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FavoredSubject.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FavoredSubject.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
