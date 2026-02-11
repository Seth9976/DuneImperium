using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x02000196 RID: 406
	public class BlankSlate : WormArchetype
	{
		// Token: 0x06001345 RID: 4933 RVA: 0x000A40B0 File Offset: 0x000A22B0
		// Note: this type is marked as 'beforefieldinit'.
		static BlankSlate()
		{
			Il2CppClassPointerStore<BlankSlate>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "BlankSlate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlankSlate>.NativeClassPtr);
			BlankSlate.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlankSlate>.NativeClassPtr, "archID");
			BlankSlate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlankSlate>.NativeClassPtr, 100666444);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000A4108 File Offset: 0x000A2308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102286, XrefRangeEnd = 102479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlankSlate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlankSlate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlankSlate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00009758 File Offset: 0x00007958
		public BlankSlate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x000A4144 File Offset: 0x000A2344
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x00009761 File Offset: 0x00007961
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BlankSlate.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlankSlate.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
