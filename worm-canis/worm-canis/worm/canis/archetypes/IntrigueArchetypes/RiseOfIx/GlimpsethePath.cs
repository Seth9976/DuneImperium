using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x0200013F RID: 319
	public class GlimpsethePath : WormArchetype
	{
		// Token: 0x06001192 RID: 4498 RVA: 0x000A00CC File Offset: 0x0009E2CC
		// Note: this type is marked as 'beforefieldinit'.
		static GlimpsethePath()
		{
			Il2CppClassPointerStore<GlimpsethePath>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "GlimpsethePath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlimpsethePath>.NativeClassPtr);
			GlimpsethePath.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlimpsethePath>.NativeClassPtr, "archID");
			GlimpsethePath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlimpsethePath>.NativeClassPtr, 100666270);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x000A0124 File Offset: 0x0009E324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89651, XrefRangeEnd = 89757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlimpsethePath()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlimpsethePath>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlimpsethePath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00008E2B File Offset: 0x0000702B
		public GlimpsethePath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x000A0160 File Offset: 0x0009E360
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x00008E34 File Offset: 0x00007034
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GlimpsethePath.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlimpsethePath.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
