using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x0200018A RID: 394
	public class NegotiatedWithdrawal : WormArchetype
	{
		// Token: 0x06001309 RID: 4873 RVA: 0x000A37E0 File Offset: 0x000A19E0
		// Note: this type is marked as 'beforefieldinit'.
		static NegotiatedWithdrawal()
		{
			Il2CppClassPointerStore<NegotiatedWithdrawal>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "NegotiatedWithdrawal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NegotiatedWithdrawal>.NativeClassPtr);
			NegotiatedWithdrawal.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NegotiatedWithdrawal>.NativeClassPtr, "archID");
			NegotiatedWithdrawal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegotiatedWithdrawal>.NativeClassPtr, 100666420);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000A3838 File Offset: 0x000A1A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99824, XrefRangeEnd = 100007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NegotiatedWithdrawal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NegotiatedWithdrawal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegotiatedWithdrawal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00009614 File Offset: 0x00007814
		public NegotiatedWithdrawal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x000A3874 File Offset: 0x000A1A74
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x0000961D File Offset: 0x0000781D
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NegotiatedWithdrawal.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NegotiatedWithdrawal.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
