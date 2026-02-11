using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000171 RID: 369
	public class TotheVictor : WormArchetype
	{
		// Token: 0x0600128C RID: 4748 RVA: 0x000A2584 File Offset: 0x000A0784
		// Note: this type is marked as 'beforefieldinit'.
		static TotheVictor()
		{
			Il2CppClassPointerStore<TotheVictor>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "TotheVictor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TotheVictor>.NativeClassPtr);
			TotheVictor.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TotheVictor>.NativeClassPtr, "archID");
			TotheVictor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TotheVictor>.NativeClassPtr, 100666370);
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x000A25DC File Offset: 0x000A07DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95294, XrefRangeEnd = 95409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TotheVictor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TotheVictor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TotheVictor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00009371 File Offset: 0x00007571
		public TotheVictor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x000A2618 File Offset: 0x000A0818
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x0000937A File Offset: 0x0000757A
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TotheVictor.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TotheVictor.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
