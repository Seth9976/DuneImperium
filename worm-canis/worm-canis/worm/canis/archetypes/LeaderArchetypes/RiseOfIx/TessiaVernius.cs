using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.RiseOfIx
{
	// Token: 0x0200012D RID: 301
	public class TessiaVernius : WormArchetype
	{
		// Token: 0x06001138 RID: 4408 RVA: 0x0009F394 File Offset: 0x0009D594
		// Note: this type is marked as 'beforefieldinit'.
		static TessiaVernius()
		{
			Il2CppClassPointerStore<TessiaVernius>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.RiseOfIx", "TessiaVernius");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TessiaVernius>.NativeClassPtr);
			TessiaVernius.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TessiaVernius>.NativeClassPtr, "archID");
			TessiaVernius.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessiaVernius>.NativeClassPtr, 100666234);
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0009F3EC File Offset: 0x0009D5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87651, XrefRangeEnd = 87803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TessiaVernius()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TessiaVernius>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TessiaVernius.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00008C45 File Offset: 0x00006E45
		public TessiaVernius(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x0009F428 File Offset: 0x0009D628
		// (set) Token: 0x0600113C RID: 4412 RVA: 0x00008C4E File Offset: 0x00006E4E
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TessiaVernius.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TessiaVernius.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
