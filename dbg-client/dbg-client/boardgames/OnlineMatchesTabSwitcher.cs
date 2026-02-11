using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames
{
	// Token: 0x020000E9 RID: 233
	public class OnlineMatchesTabSwitcher : MonoBehaviour
	{
		// Token: 0x06000A1A RID: 2586 RVA: 0x0003D3FC File Offset: 0x0003B5FC
		// Note: this type is marked as 'beforefieldinit'.
		static OnlineMatchesTabSwitcher()
		{
			Il2CppClassPointerStore<OnlineMatchesTabSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames", "OnlineMatchesTabSwitcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineMatchesTabSwitcher>.NativeClassPtr);
			OnlineMatchesTabSwitcher.NativeFieldInfoPtr_switchingAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesTabSwitcher>.NativeClassPtr, "switchingAnimator");
			OnlineMatchesTabSwitcher.NativeFieldInfoPtr_availableTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesTabSwitcher>.NativeClassPtr, "availableTrigger");
			OnlineMatchesTabSwitcher.NativeFieldInfoPtr_activeTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesTabSwitcher>.NativeClassPtr, "activeTrigger");
			OnlineMatchesTabSwitcher.NativeFieldInfoPtr_availableContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesTabSwitcher>.NativeClassPtr, "availableContainer");
			OnlineMatchesTabSwitcher.NativeFieldInfoPtr_activeContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineMatchesTabSwitcher>.NativeClassPtr, "activeContainer");
			OnlineMatchesTabSwitcher.NativeMethodInfoPtr_Event_ShowAvailableGames_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesTabSwitcher>.NativeClassPtr, 100664765);
			OnlineMatchesTabSwitcher.NativeMethodInfoPtr_Event_ShowActiveGames_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesTabSwitcher>.NativeClassPtr, 100664766);
			OnlineMatchesTabSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineMatchesTabSwitcher>.NativeClassPtr, 100664767);
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0003D4CC File Offset: 0x0003B6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506601, XrefRangeEnd = 506608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowAvailableGames(bool showAvailable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref showAvailable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesTabSwitcher.NativeMethodInfoPtr_Event_ShowAvailableGames_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0003D50C File Offset: 0x0003B70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506608, XrefRangeEnd = 506617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowActiveGames(bool showActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref showActive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesTabSwitcher.NativeMethodInfoPtr_Event_ShowActiveGames_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0003D54C File Offset: 0x0003B74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506617, XrefRangeEnd = 506626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnlineMatchesTabSwitcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineMatchesTabSwitcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineMatchesTabSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00006D31 File Offset: 0x00004F31
		public OnlineMatchesTabSwitcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0003D588 File Offset: 0x0003B788
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00006D3A File Offset: 0x00004F3A
		public unsafe Animator switchingAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesTabSwitcher.NativeFieldInfoPtr_switchingAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesTabSwitcher.NativeFieldInfoPtr_switchingAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0003D5B8 File Offset: 0x0003B7B8
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x00006D59 File Offset: 0x00004F59
		public unsafe string availableTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesTabSwitcher.NativeFieldInfoPtr_availableTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesTabSwitcher.NativeFieldInfoPtr_availableTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x0003D5E0 File Offset: 0x0003B7E0
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00006D78 File Offset: 0x00004F78
		public unsafe string activeTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesTabSwitcher.NativeFieldInfoPtr_activeTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesTabSwitcher.NativeFieldInfoPtr_activeTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0003D608 File Offset: 0x0003B808
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x00006D97 File Offset: 0x00004F97
		public unsafe GameObject availableContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesTabSwitcher.NativeFieldInfoPtr_availableContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesTabSwitcher.NativeFieldInfoPtr_availableContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0003D638 File Offset: 0x0003B838
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x00006DB6 File Offset: 0x00004FB6
		public unsafe GameObject activeContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesTabSwitcher.NativeFieldInfoPtr_activeContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineMatchesTabSwitcher.NativeFieldInfoPtr_activeContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeFieldInfoPtr_switchingAnimator;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeFieldInfoPtr_availableTrigger;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeFieldInfoPtr_activeTrigger;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeFieldInfoPtr_availableContainer;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeFieldInfoPtr_activeContainer;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowAvailableGames_Public_Void_Boolean_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowActiveGames_Public_Void_Boolean_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
