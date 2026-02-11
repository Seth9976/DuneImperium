using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x02000217 RID: 535
	public class WormSolariCostTooltipSource : MonoBehaviour
	{
		// Token: 0x0600178A RID: 6026 RVA: 0x0005F830 File Offset: 0x0005DA30
		// Note: this type is marked as 'beforefieldinit'.
		static WormSolariCostTooltipSource()
		{
			Il2CppClassPointerStore<WormSolariCostTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormSolariCostTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSolariCostTooltipSource>.NativeClassPtr);
			WormSolariCostTooltipSource.NativeFieldInfoPtr_locString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSolariCostTooltipSource>.NativeClassPtr, "locString");
			WormSolariCostTooltipSource.NativeFieldInfoPtr_displayCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSolariCostTooltipSource>.NativeClassPtr, "displayCost");
			WormSolariCostTooltipSource.NativeMethodInfoPtr_Event_SetCost_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSolariCostTooltipSource>.NativeClassPtr, 100666575);
			WormSolariCostTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSolariCostTooltipSource>.NativeClassPtr, 100666576);
			WormSolariCostTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSolariCostTooltipSource>.NativeClassPtr, 100666577);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0005F8C4 File Offset: 0x0005DAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetCost(string cost)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cost);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSolariCostTooltipSource.NativeMethodInfoPtr_Event_SetCost_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0005F908 File Offset: 0x0005DB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717563, XrefRangeEnd = 717576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSolariCostTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x0005F940 File Offset: 0x0005DB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717576, XrefRangeEnd = 717584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSolariCostTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSolariCostTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSolariCostTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0000E0E0 File Offset: 0x0000C2E0
		public WormSolariCostTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x0005F97C File Offset: 0x0005DB7C
		// (set) Token: 0x06001790 RID: 6032 RVA: 0x0000E0E9 File Offset: 0x0000C2E9
		public unsafe string locString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSolariCostTooltipSource.NativeFieldInfoPtr_locString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSolariCostTooltipSource.NativeFieldInfoPtr_locString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x0005F9A4 File Offset: 0x0005DBA4
		// (set) Token: 0x06001792 RID: 6034 RVA: 0x0000E108 File Offset: 0x0000C308
		public unsafe string displayCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSolariCostTooltipSource.NativeFieldInfoPtr_displayCost);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSolariCostTooltipSource.NativeFieldInfoPtr_displayCost), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeFieldInfoPtr_locString;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeFieldInfoPtr_displayCost;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetCost_Public_Void_String_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
