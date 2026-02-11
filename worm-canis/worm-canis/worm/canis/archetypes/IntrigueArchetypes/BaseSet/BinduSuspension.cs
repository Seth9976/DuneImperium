using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000156 RID: 342
	public class BinduSuspension : WormArchetype
	{
		// Token: 0x06001205 RID: 4613 RVA: 0x000A11B0 File Offset: 0x0009F3B0
		// Note: this type is marked as 'beforefieldinit'.
		static BinduSuspension()
		{
			Il2CppClassPointerStore<BinduSuspension>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "BinduSuspension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinduSuspension>.NativeClassPtr);
			BinduSuspension.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinduSuspension>.NativeClassPtr, "archID");
			BinduSuspension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinduSuspension>.NativeClassPtr, 100666316);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x000A1208 File Offset: 0x0009F408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92372, XrefRangeEnd = 92473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinduSuspension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinduSuspension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinduSuspension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00009098 File Offset: 0x00007298
		public BinduSuspension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x000A1244 File Offset: 0x0009F444
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x000090A1 File Offset: 0x000072A1
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinduSuspension.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinduSuspension.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
