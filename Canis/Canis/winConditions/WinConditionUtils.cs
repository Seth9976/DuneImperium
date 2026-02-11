using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.winConditions
{
	// Token: 0x02000030 RID: 48
	public static class WinConditionUtils : Object
	{
		// Token: 0x06000332 RID: 818 RVA: 0x0002612C File Offset: 0x0002432C
		// Note: this type is marked as 'beforefieldinit'.
		static WinConditionUtils()
		{
			Il2CppClassPointerStore<WinConditionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.winConditions", "WinConditionUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WinConditionUtils>.NativeClassPtr);
			WinConditionUtils.NativeMethodInfoPtr_And_Public_Static_AndWinCondition_IWinCondition_IWinCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinConditionUtils>.NativeClassPtr, 100663965);
			WinConditionUtils.NativeMethodInfoPtr_Or_Public_Static_OrWinCondition_IWinCondition_IWinCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinConditionUtils>.NativeClassPtr, 100663966);
			WinConditionUtils.NativeMethodInfoPtr_XOr_Public_Static_XOrWinCondition_IWinCondition_IWinCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinConditionUtils>.NativeClassPtr, 100663967);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00026198 File Offset: 0x00024398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549499, XrefRangeEnd = 549505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndWinCondition And(this IWinCondition self, IWinCondition other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinConditionUtils.NativeMethodInfoPtr_And_Public_Static_AndWinCondition_IWinCondition_IWinCondition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndWinCondition>(intPtr3) : null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000261F0 File Offset: 0x000243F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549505, XrefRangeEnd = 549511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OrWinCondition Or(this IWinCondition self, IWinCondition other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinConditionUtils.NativeMethodInfoPtr_Or_Public_Static_OrWinCondition_IWinCondition_IWinCondition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OrWinCondition>(intPtr3) : null;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00026248 File Offset: 0x00024448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549511, XrefRangeEnd = 549517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XOrWinCondition XOr(this IWinCondition self, IWinCondition other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinConditionUtils.NativeMethodInfoPtr_XOr_Public_Static_XOrWinCondition_IWinCondition_IWinCondition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XOrWinCondition>(intPtr3) : null;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000036EF File Offset: 0x000018EF
		public WinConditionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_And_Public_Static_AndWinCondition_IWinCondition_IWinCondition_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_Or_Public_Static_OrWinCondition_IWinCondition_IWinCondition_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_XOr_Public_Static_XOrWinCondition_IWinCondition_IWinCondition_0;
	}
}
