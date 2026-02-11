using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001B7 RID: 439
	public class Crysknife : WormArchetype
	{
		// Token: 0x060013EA RID: 5098 RVA: 0x000A58EC File Offset: 0x000A3AEC
		// Note: this type is marked as 'beforefieldinit'.
		static Crysknife()
		{
			Il2CppClassPointerStore<Crysknife>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "Crysknife");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Crysknife>.NativeClassPtr);
			Crysknife.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crysknife>.NativeClassPtr, "archID");
			Crysknife.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crysknife>.NativeClassPtr, 100666510);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x000A5944 File Offset: 0x000A3B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108750, XrefRangeEnd = 108959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Crysknife()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Crysknife>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Crysknife.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00009AD3 File Offset: 0x00007CD3
		public Crysknife(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x000A5980 File Offset: 0x000A3B80
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x00009ADC File Offset: 0x00007CDC
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Crysknife.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Crysknife.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
