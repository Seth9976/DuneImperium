using System;
using Canis.attributes;
using dwd.core.animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace worm.match.components.stingers
{
	// Token: 0x02000226 RID: 550
	public class WormSequenceStinger : MonoBehaviour
	{
		// Token: 0x0600180D RID: 6157 RVA: 0x00061188 File Offset: 0x0005F388
		// Note: this type is marked as 'beforefieldinit'.
		static WormSequenceStinger()
		{
			Il2CppClassPointerStore<WormSequenceStinger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormSequenceStinger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSequenceStinger>.NativeClassPtr);
			WormSequenceStinger.NativeFieldInfoPtr_displayAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStinger>.NativeClassPtr, "displayAnim");
			WormSequenceStinger.NativeFieldInfoPtr_initializers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStinger>.NativeClassPtr, "initializers");
			WormSequenceStinger.NativeFieldInfoPtr__Completed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSequenceStinger>.NativeClassPtr, "<Completed>k__BackingField");
			WormSequenceStinger.NativeMethodInfoPtr_get_Completed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStinger>.NativeClassPtr, 100666632);
			WormSequenceStinger.NativeMethodInfoPtr_set_Completed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStinger>.NativeClassPtr, 100666633);
			WormSequenceStinger.NativeMethodInfoPtr_Show_Public_IEnumerator_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStinger>.NativeClassPtr, 100666634);
			WormSequenceStinger.NativeMethodInfoPtr_GetAnimation_Protected_Virtual_New_IEnumerator_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStinger>.NativeClassPtr, 100666635);
			WormSequenceStinger.NativeMethodInfoPtr_Event_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStinger>.NativeClassPtr, 100666636);
			WormSequenceStinger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSequenceStinger>.NativeClassPtr, 100666637);
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x0006126C File Offset: 0x0005F46C
		// (set) Token: 0x0600180F RID: 6159 RVA: 0x000612A8 File Offset: 0x0005F4A8
		public unsafe bool Completed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStinger.NativeMethodInfoPtr_get_Completed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStinger.NativeMethodInfoPtr_set_Completed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x000612E8 File Offset: 0x0005F4E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 717938, RefRangeEnd = 717939, XrefRangeStart = 717909, XrefRangeEnd = 717938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Show(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStinger.NativeMethodInfoPtr_Show_Public_IEnumerator_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00061338 File Offset: 0x0005F538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 717941, RefRangeEnd = 717942, XrefRangeStart = 717939, XrefRangeEnd = 717941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetAnimation(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSequenceStinger.NativeMethodInfoPtr_GetAnimation_Protected_Virtual_New_IEnumerator_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00061394 File Offset: 0x0005F594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717942, XrefRangeEnd = 717963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStinger.NativeMethodInfoPtr_Event_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x000613C8 File Offset: 0x0005F5C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 509850, RefRangeEnd = 509851, XrefRangeStart = 509850, XrefRangeEnd = 509851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSequenceStinger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSequenceStinger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSequenceStinger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x0000E4AE File Offset: 0x0000C6AE
		public WormSequenceStinger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x00061404 File Offset: 0x0005F604
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x0000E4B7 File Offset: 0x0000C6B7
		public unsafe TriggeredBlockingAnimation displayAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStinger.NativeFieldInfoPtr_displayAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStinger.NativeFieldInfoPtr_displayAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x00061434 File Offset: 0x0005F634
		// (set) Token: 0x06001818 RID: 6168 RVA: 0x0000E4D6 File Offset: 0x0000C6D6
		public unsafe IReadOnlyList<IStingerInitializer> initializers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStinger.NativeFieldInfoPtr_initializers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<IStingerInitializer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStinger.NativeFieldInfoPtr_initializers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00061464 File Offset: 0x0005F664
		// (set) Token: 0x0600181A RID: 6170 RVA: 0x0000E4F5 File Offset: 0x0000C6F5
		public unsafe bool _Completed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStinger.NativeFieldInfoPtr__Completed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSequenceStinger.NativeFieldInfoPtr__Completed_k__BackingField)) = value;
			}
		}

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeFieldInfoPtr_displayAnim;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeFieldInfoPtr_initializers;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeFieldInfoPtr__Completed_k__BackingField;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_get_Completed_Public_get_Boolean_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_set_Completed_Private_set_Void_Boolean_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_IEnumerator_IHasAttributes_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimation_Protected_Virtual_New_IEnumerator_IHasAttributes_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_Event_Complete_Public_Void_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
