using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x020001AC RID: 428
	public class AvailableTechButtonNavigation : MonoBehaviour
	{
		// Token: 0x060012EF RID: 4847 RVA: 0x000519C0 File Offset: 0x0004FBC0
		// Note: this type is marked as 'beforefieldinit'.
		static AvailableTechButtonNavigation()
		{
			Il2CppClassPointerStore<AvailableTechButtonNavigation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "AvailableTechButtonNavigation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvailableTechButtonNavigation>.NativeClassPtr);
			AvailableTechButtonNavigation.NativeFieldInfoPtr_toMoreButtonNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvailableTechButtonNavigation>.NativeClassPtr, "toMoreButtonNavigation");
			AvailableTechButtonNavigation.NativeFieldInfoPtr_defaultNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvailableTechButtonNavigation>.NativeClassPtr, "defaultNavigation");
			AvailableTechButtonNavigation.NativeMethodInfoPtr_GetNavDataByDirection_Public_Virtual_Final_New_DirectionalNavigationData_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvailableTechButtonNavigation>.NativeClassPtr, 100665882);
			AvailableTechButtonNavigation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvailableTechButtonNavigation>.NativeClassPtr, 100665883);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00051A40 File Offset: 0x0004FC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712553, XrefRangeEnd = 712575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DirectionalNavigationData GetNavDataByDirection(MoveDirection navDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref navDirection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvailableTechButtonNavigation.NativeMethodInfoPtr_GetNavDataByDirection_Public_Virtual_Final_New_DirectionalNavigationData_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectionalNavigationData>(intPtr3) : null;
			}
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00051A8C File Offset: 0x0004FC8C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvailableTechButtonNavigation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvailableTechButtonNavigation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvailableTechButtonNavigation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0000BC82 File Offset: 0x00009E82
		public AvailableTechButtonNavigation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00051AC8 File Offset: 0x0004FCC8
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x0000BC8B File Offset: 0x00009E8B
		public unsafe DirectionalNavigationData toMoreButtonNavigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvailableTechButtonNavigation.NativeFieldInfoPtr_toMoreButtonNavigation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirectionalNavigationData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvailableTechButtonNavigation.NativeFieldInfoPtr_toMoreButtonNavigation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00051AF8 File Offset: 0x0004FCF8
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x0000BCAA File Offset: 0x00009EAA
		public unsafe DirectionalNavigationData defaultNavigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvailableTechButtonNavigation.NativeFieldInfoPtr_defaultNavigation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirectionalNavigationData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvailableTechButtonNavigation.NativeFieldInfoPtr_defaultNavigation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr_toMoreButtonNavigation;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeFieldInfoPtr_defaultNavigation;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_GetNavDataByDirection_Public_Virtual_Final_New_DirectionalNavigationData_MoveDirection_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
