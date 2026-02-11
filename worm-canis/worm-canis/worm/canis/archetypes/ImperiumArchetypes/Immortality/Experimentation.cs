using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x0200019A RID: 410
	public class Experimentation : WormArchetype
	{
		// Token: 0x06001359 RID: 4953 RVA: 0x000A43A0 File Offset: 0x000A25A0
		// Note: this type is marked as 'beforefieldinit'.
		static Experimentation()
		{
			Il2CppClassPointerStore<Experimentation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "Experimentation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Experimentation>.NativeClassPtr);
			Experimentation.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Experimentation>.NativeClassPtr, "archID");
			Experimentation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Experimentation>.NativeClassPtr, 100666452);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x000A43F8 File Offset: 0x000A25F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103090, XrefRangeEnd = 103237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Experimentation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Experimentation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Experimentation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x000097C4 File Offset: 0x000079C4
		public Experimentation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x000A4434 File Offset: 0x000A2634
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x000097CD File Offset: 0x000079CD
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Experimentation.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Experimentation.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
