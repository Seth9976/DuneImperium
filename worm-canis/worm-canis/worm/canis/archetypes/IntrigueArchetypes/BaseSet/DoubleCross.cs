using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000160 RID: 352
	public class DoubleCross : WormArchetype
	{
		// Token: 0x06001237 RID: 4663 RVA: 0x000A1908 File Offset: 0x0009FB08
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleCross()
		{
			Il2CppClassPointerStore<DoubleCross>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "DoubleCross");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleCross>.NativeClassPtr);
			DoubleCross.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleCross>.NativeClassPtr, "archID");
			DoubleCross.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleCross>.NativeClassPtr, 100666336);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000A1960 File Offset: 0x0009FB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93434, XrefRangeEnd = 93535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleCross()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleCross>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleCross.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000091A6 File Offset: 0x000073A6
		public DoubleCross(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x000A199C File Offset: 0x0009FB9C
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x000091AF File Offset: 0x000073AF
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DoubleCross.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoubleCross.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
