using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000F4 RID: 244
	public class ScientificBreakthrough : WormArchetype
	{
		// Token: 0x0600101B RID: 4123 RVA: 0x0009C9B8 File Offset: 0x0009ABB8
		// Note: this type is marked as 'beforefieldinit'.
		static ScientificBreakthrough()
		{
			Il2CppClassPointerStore<ScientificBreakthrough>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "ScientificBreakthrough");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScientificBreakthrough>.NativeClassPtr);
			ScientificBreakthrough.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScientificBreakthrough>.NativeClassPtr, "archID");
			ScientificBreakthrough.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScientificBreakthrough>.NativeClassPtr, 100666120);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0009CA10 File Offset: 0x0009AC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80128, XrefRangeEnd = 80316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScientificBreakthrough()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScientificBreakthrough>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScientificBreakthrough.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00008642 File Offset: 0x00006842
		public ScientificBreakthrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x0009CA4C File Offset: 0x0009AC4C
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x0000864B File Offset: 0x0000684B
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScientificBreakthrough.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScientificBreakthrough.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
