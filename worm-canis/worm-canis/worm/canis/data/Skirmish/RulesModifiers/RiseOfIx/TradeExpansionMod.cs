using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.match;

namespace worm.canis.data.Skirmish.RulesModifiers.RiseOfIx
{
	// Token: 0x020000B3 RID: 179
	public class TradeExpansionMod : RulesModifier
	{
		// Token: 0x06000CF4 RID: 3316 RVA: 0x00094C9C File Offset: 0x00092E9C
		// Note: this type is marked as 'beforefieldinit'.
		static TradeExpansionMod()
		{
			Il2CppClassPointerStore<TradeExpansionMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Skirmish.RulesModifiers.RiseOfIx", "TradeExpansionMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TradeExpansionMod>.NativeClassPtr);
			TradeExpansionMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeExpansionMod>.NativeClassPtr, 100665759);
			TradeExpansionMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeExpansionMod>.NativeClassPtr, 100665760);
			TradeExpansionMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeExpansionMod>.NativeClassPtr, 100665761);
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00094D08 File Offset: 0x00092F08
		public unsafe override int RuleID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TradeExpansionMod.NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00094D50 File Offset: 0x00092F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74894, XrefRangeEnd = 74929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TradeExpansionMod.NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00094DC0 File Offset: 0x00092FC0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TradeExpansionMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TradeExpansionMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TradeExpansionMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00006FA1 File Offset: 0x000051A1
		public TradeExpansionMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_get_RuleID_Public_Virtual_get_Int32_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_WormMatchInitData_WormMatchInitData_CanisRandom_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
