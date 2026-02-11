using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace dwd.core.input.compositeModule
{
	// Token: 0x02000082 RID: 130
	public class BoolEventsForSelectionState : MonoBehaviour
	{
		// Token: 0x06000578 RID: 1400 RVA: 0x000182D0 File Offset: 0x000164D0
		// Note: this type is marked as 'beforefieldinit'.
		static BoolEventsForSelectionState()
		{
			Il2CppClassPointerStore<BoolEventsForSelectionState>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "BoolEventsForSelectionState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolEventsForSelectionState>.NativeClassPtr);
			BoolEventsForSelectionState.NativeFieldInfoPtr_onState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolEventsForSelectionState>.NativeClassPtr, "onState");
			BoolEventsForSelectionState.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEventsForSelectionState>.NativeClassPtr, 100663976);
			BoolEventsForSelectionState.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEventsForSelectionState>.NativeClassPtr, 100663977);
			BoolEventsForSelectionState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEventsForSelectionState>.NativeClassPtr, 100663978);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00018350 File Offset: 0x00016550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124365, XrefRangeEnd = 1124367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolEventsForSelectionState.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00018394 File Offset: 0x00016594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124367, XrefRangeEnd = 1124369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolEventsForSelectionState.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000183D8 File Offset: 0x000165D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124369, XrefRangeEnd = 1124375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolEventsForSelectionState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolEventsForSelectionState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolEventsForSelectionState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000502E File Offset: 0x0000322E
		public BoolEventsForSelectionState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00018414 File Offset: 0x00016614
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00005037 File Offset: 0x00003237
		public unsafe BoolUnityEvents onState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEventsForSelectionState.NativeFieldInfoPtr_onState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEventsForSelectionState.NativeFieldInfoPtr_onState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeFieldInfoPtr_onState;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
