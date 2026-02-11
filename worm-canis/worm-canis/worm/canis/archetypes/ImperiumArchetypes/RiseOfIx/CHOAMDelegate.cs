using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000178 RID: 376
	public class CHOAMDelegate : WormArchetype
	{
		// Token: 0x060012AF RID: 4783 RVA: 0x000A2AA8 File Offset: 0x000A0CA8
		// Note: this type is marked as 'beforefieldinit'.
		static CHOAMDelegate()
		{
			Il2CppClassPointerStore<CHOAMDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "CHOAMDelegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CHOAMDelegate>.NativeClassPtr);
			CHOAMDelegate.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CHOAMDelegate>.NativeClassPtr, "archID");
			CHOAMDelegate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CHOAMDelegate>.NativeClassPtr, 100666384);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000A2B00 File Offset: 0x000A0D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96234, XrefRangeEnd = 96429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CHOAMDelegate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CHOAMDelegate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CHOAMDelegate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0000942E File Offset: 0x0000762E
		public CHOAMDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x000A2B3C File Offset: 0x000A0D3C
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x00009437 File Offset: 0x00007637
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CHOAMDelegate.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CHOAMDelegate.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
