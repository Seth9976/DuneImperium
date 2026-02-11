using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x0200019E RID: 414
	public class InterstellarConspiracy : WormArchetype
	{
		// Token: 0x0600136D RID: 4973 RVA: 0x000A4690 File Offset: 0x000A2890
		// Note: this type is marked as 'beforefieldinit'.
		static InterstellarConspiracy()
		{
			Il2CppClassPointerStore<InterstellarConspiracy>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "InterstellarConspiracy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterstellarConspiracy>.NativeClassPtr);
			InterstellarConspiracy.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterstellarConspiracy>.NativeClassPtr, "archID");
			InterstellarConspiracy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterstellarConspiracy>.NativeClassPtr, 100666460);
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x000A46E8 File Offset: 0x000A28E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103855, XrefRangeEnd = 104042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterstellarConspiracy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterstellarConspiracy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterstellarConspiracy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00009830 File Offset: 0x00007A30
		public InterstellarConspiracy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x000A4724 File Offset: 0x000A2924
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x00009839 File Offset: 0x00007A39
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InterstellarConspiracy.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InterstellarConspiracy.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
