using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000121 RID: 289
	public class SecureContract : WormArchetype
	{
		// Token: 0x060010FC RID: 4348 RVA: 0x0009EAC4 File Offset: 0x0009CCC4
		// Note: this type is marked as 'beforefieldinit'.
		static SecureContract()
		{
			Il2CppClassPointerStore<SecureContract>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "SecureContract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecureContract>.NativeClassPtr);
			SecureContract.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureContract>.NativeClassPtr, "archID");
			SecureContract.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureContract>.NativeClassPtr, 100666210);
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0009EB1C File Offset: 0x0009CD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86202, XrefRangeEnd = 86308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecureContract()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureContract>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureContract.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00008B01 File Offset: 0x00006D01
		public SecureContract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0009EB58 File Offset: 0x0009CD58
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x00008B0A File Offset: 0x00006D0A
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecureContract.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecureContract.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
