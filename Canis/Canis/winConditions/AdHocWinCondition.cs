using System;
using Canis.context;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.winConditions
{
	// Token: 0x0200002E RID: 46
	public class AdHocWinCondition : IWinCondition
	{
		// Token: 0x06000327 RID: 807 RVA: 0x00025E90 File Offset: 0x00024090
		// Note: this type is marked as 'beforefieldinit'.
		static AdHocWinCondition()
		{
			Il2CppClassPointerStore<AdHocWinCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.winConditions", "AdHocWinCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdHocWinCondition>.NativeClassPtr);
			AdHocWinCondition.NativeFieldInfoPtr_check = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdHocWinCondition>.NativeClassPtr, "check");
			AdHocWinCondition.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Context_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdHocWinCondition>.NativeClassPtr, 100663960);
			AdHocWinCondition.NativeMethodInfoPtr_DidWin_Public_Virtual_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdHocWinCondition>.NativeClassPtr, 100663961);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00025EFC File Offset: 0x000240FC
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdHocWinCondition(Func<Context, bool> check)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdHocWinCondition>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(check);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdHocWinCondition.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Context_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00025F48 File Offset: 0x00024148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549491, XrefRangeEnd = 549496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DidWin(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AdHocWinCondition.NativeMethodInfoPtr_DidWin_Public_Virtual_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000036BE File Offset: 0x000018BE
		public AdHocWinCondition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00025FA0 File Offset: 0x000241A0
		// (set) Token: 0x0600032C RID: 812 RVA: 0x000036C7 File Offset: 0x000018C7
		public unsafe Func<Context, bool> check
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdHocWinCondition.NativeFieldInfoPtr_check);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdHocWinCondition.NativeFieldInfoPtr_check), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_check;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Context_Boolean_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_DidWin_Public_Virtual_Boolean_PlayerEntity_0;
	}
}
