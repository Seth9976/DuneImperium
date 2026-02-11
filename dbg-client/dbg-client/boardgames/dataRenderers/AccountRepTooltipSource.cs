using System;
using boardgames.moz;
using dwd.core.account;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.datarenderers
{
	// Token: 0x02000167 RID: 359
	public class AccountRepTooltipSource : MonoBehaviour
	{
		// Token: 0x06001008 RID: 4104 RVA: 0x00050500 File Offset: 0x0004E700
		// Note: this type is marked as 'beforefieldinit'.
		static AccountRepTooltipSource()
		{
			Il2CppClassPointerStore<AccountRepTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "AccountRepTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountRepTooltipSource>.NativeClassPtr);
			AccountRepTooltipSource.NativeFieldInfoPtr_accountProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountRepTooltipSource>.NativeClassPtr, "accountProvider");
			AccountRepTooltipSource.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountRepTooltipSource>.NativeClassPtr, "tooltip");
			AccountRepTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountRepTooltipSource>.NativeClassPtr, 100665562);
			AccountRepTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountRepTooltipSource>.NativeClassPtr, 100665563);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00050580 File Offset: 0x0004E780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513798, XrefRangeEnd = 513808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountRepTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x000505B8 File Offset: 0x0004E7B8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountRepTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountRepTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountRepTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00009C30 File Offset: 0x00007E30
		public AccountRepTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x000505F4 File Offset: 0x0004E7F4
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x00009C39 File Offset: 0x00007E39
		public unsafe AccountProvider accountProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountRepTooltipSource.NativeFieldInfoPtr_accountProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountRepTooltipSource.NativeFieldInfoPtr_accountProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00050624 File Offset: 0x0004E824
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x00009C58 File Offset: 0x00007E58
		public unsafe DBGTooltip tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountRepTooltipSource.NativeFieldInfoPtr_tooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountRepTooltipSource.NativeFieldInfoPtr_tooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeFieldInfoPtr_accountProvider;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeFieldInfoPtr_tooltip;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
