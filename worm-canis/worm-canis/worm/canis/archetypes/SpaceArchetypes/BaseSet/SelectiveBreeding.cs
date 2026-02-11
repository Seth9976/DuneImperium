using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000122 RID: 290
	public class SelectiveBreeding : WormArchetype
	{
		// Token: 0x06001101 RID: 4353 RVA: 0x0009EB80 File Offset: 0x0009CD80
		// Note: this type is marked as 'beforefieldinit'.
		static SelectiveBreeding()
		{
			Il2CppClassPointerStore<SelectiveBreeding>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "SelectiveBreeding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectiveBreeding>.NativeClassPtr);
			SelectiveBreeding.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectiveBreeding>.NativeClassPtr, "archID");
			SelectiveBreeding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectiveBreeding>.NativeClassPtr, 100666212);
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0009EBD8 File Offset: 0x0009CDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86308, XrefRangeEnd = 86460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectiveBreeding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectiveBreeding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectiveBreeding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00008B1C File Offset: 0x00006D1C
		public SelectiveBreeding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x0009EC14 File Offset: 0x0009CE14
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x00008B25 File Offset: 0x00006D25
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SelectiveBreeding.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SelectiveBreeding.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
