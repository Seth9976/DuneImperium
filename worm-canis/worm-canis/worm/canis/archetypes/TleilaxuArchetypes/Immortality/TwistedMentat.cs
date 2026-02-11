using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000F9 RID: 249
	public class TwistedMentat : WormArchetype
	{
		// Token: 0x06001034 RID: 4148 RVA: 0x0009CD64 File Offset: 0x0009AF64
		// Note: this type is marked as 'beforefieldinit'.
		static TwistedMentat()
		{
			Il2CppClassPointerStore<TwistedMentat>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "TwistedMentat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwistedMentat>.NativeClassPtr);
			TwistedMentat.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwistedMentat>.NativeClassPtr, "archID");
			TwistedMentat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwistedMentat>.NativeClassPtr, 100666130);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0009CDBC File Offset: 0x0009AFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81043, XrefRangeEnd = 81219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TwistedMentat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwistedMentat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwistedMentat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x000086C9 File Offset: 0x000068C9
		public TwistedMentat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0009CDF8 File Offset: 0x0009AFF8
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x000086D2 File Offset: 0x000068D2
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwistedMentat.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwistedMentat.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
