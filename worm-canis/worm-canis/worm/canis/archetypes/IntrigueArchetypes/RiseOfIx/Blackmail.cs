using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x02000139 RID: 313
	public class Blackmail : WormArchetype
	{
		// Token: 0x06001174 RID: 4468 RVA: 0x0009FC64 File Offset: 0x0009DE64
		// Note: this type is marked as 'beforefieldinit'.
		static Blackmail()
		{
			Il2CppClassPointerStore<Blackmail>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "Blackmail");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Blackmail>.NativeClassPtr);
			Blackmail.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blackmail>.NativeClassPtr, "archID");
			Blackmail.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blackmail>.NativeClassPtr, 100666258);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0009FCBC File Offset: 0x0009DEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88949, XrefRangeEnd = 89062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Blackmail()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Blackmail>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Blackmail.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00008D89 File Offset: 0x00006F89
		public Blackmail(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x0009FCF8 File Offset: 0x0009DEF8
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x00008D92 File Offset: 0x00006F92
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Blackmail.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Blackmail.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
