using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers
{
	// Token: 0x02000089 RID: 137
	public class LansdraadConflict : RulesModifier
	{
		// Token: 0x06000C1B RID: 3099 RVA: 0x000912B0 File Offset: 0x0008F4B0
		// Note: this type is marked as 'beforefieldinit'.
		static LansdraadConflict()
		{
			Il2CppClassPointerStore<LansdraadConflict>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers", "LansdraadConflict");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LansdraadConflict>.NativeClassPtr);
			LansdraadConflict.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LansdraadConflict>.NativeClassPtr, 100665608);
			LansdraadConflict.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LansdraadConflict>.NativeClassPtr, 100665609);
			LansdraadConflict.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LansdraadConflict>.NativeClassPtr, 100665610);
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0009131C File Offset: 0x0008F51C
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LansdraadConflict.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00091364 File Offset: 0x0008F564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73787, XrefRangeEnd = 73803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormMatchInitData Apply(WormMatchInitData wormMatchInitData, CanisRandom random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatchInitData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LansdraadConflict.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000913D4 File Offset: 0x0008F5D4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LansdraadConflict()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LansdraadConflict>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LansdraadConflict.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00006DEB File Offset: 0x00004FEB
		public LansdraadConflict(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
