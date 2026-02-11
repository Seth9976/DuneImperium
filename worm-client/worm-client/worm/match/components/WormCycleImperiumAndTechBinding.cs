using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace worm.match.components
{
	// Token: 0x020001E2 RID: 482
	public class WormCycleImperiumAndTechBinding : MonoBehaviour
	{
		// Token: 0x06001547 RID: 5447 RVA: 0x00058B28 File Offset: 0x00056D28
		// Note: this type is marked as 'beforefieldinit'.
		static WormCycleImperiumAndTechBinding()
		{
			Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormCycleImperiumAndTechBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr);
			WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_imperiumRowCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr, "imperiumRowCue");
			WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_techRowCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr, "techRowCue");
			WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_onClickEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr, "onClickEvents");
			WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr, "currentState");
			WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_wormShowImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr, "wormShowImperiumRow");
			WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_wormTechRowManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr, "wormTechRowManager");
			WormCycleImperiumAndTechBinding.NativeMethodInfoPtr_Event_Click_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr, 100666239);
			WormCycleImperiumAndTechBinding.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr, 100666240);
			WormCycleImperiumAndTechBinding.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr, 100666241);
			WormCycleImperiumAndTechBinding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr, 100666242);
			WormCycleImperiumAndTechBinding.NativeMethodInfoPtr__Event_Click_b__8_0_Private_Boolean_EventsForBindingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr, 100666243);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00058C34 File Offset: 0x00056E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715147, XrefRangeEnd = 715157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Click()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCycleImperiumAndTechBinding.NativeMethodInfoPtr_Event_Click_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00058C68 File Offset: 0x00056E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715157, XrefRangeEnd = 715165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCycleImperiumAndTechBinding.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00058C9C File Offset: 0x00056E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715165, XrefRangeEnd = 715174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCycleImperiumAndTechBinding.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00058CD0 File Offset: 0x00056ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715174, XrefRangeEnd = 715182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCycleImperiumAndTechBinding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCycleImperiumAndTechBinding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00058D0C File Offset: 0x00056F0C
		[CallerCount(0)]
		public unsafe bool _Event_Click_b__8_0(WormCycleImperiumAndTechBinding.EventsForBindingState bindingEvents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bindingEvents));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCycleImperiumAndTechBinding.NativeMethodInfoPtr__Event_Click_b__8_0_Private_Boolean_EventsForBindingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x0000CF01 File Offset: 0x0000B101
		public WormCycleImperiumAndTechBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x00058D60 File Offset: 0x00056F60
		// (set) Token: 0x0600154F RID: 5455 RVA: 0x0000CF0A File Offset: 0x0000B10A
		public unsafe GameObject imperiumRowCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_imperiumRowCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_imperiumRowCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x00058D90 File Offset: 0x00056F90
		// (set) Token: 0x06001551 RID: 5457 RVA: 0x0000CF29 File Offset: 0x0000B129
		public unsafe GameObject techRowCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_techRowCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_techRowCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x00058DC0 File Offset: 0x00056FC0
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x0000CF48 File Offset: 0x0000B148
		public unsafe Il2CppReferenceArray<WormCycleImperiumAndTechBinding.EventsForBindingState> onClickEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_onClickEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormCycleImperiumAndTechBinding.EventsForBindingState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_onClickEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x00058DF0 File Offset: 0x00056FF0
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x0000CF67 File Offset: 0x0000B167
		public unsafe WormCycleImperiumAndTechBinding.BindingState currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_currentState)) = value;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x00058E18 File Offset: 0x00057018
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x0000CF82 File Offset: 0x0000B182
		public unsafe WormShowImperiumRow wormShowImperiumRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_wormShowImperiumRow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowImperiumRow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_wormShowImperiumRow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x00058E48 File Offset: 0x00057048
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x0000CFA1 File Offset: 0x0000B1A1
		public unsafe WormTechRowManager wormTechRowManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_wormTechRowManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTechRowManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.NativeFieldInfoPtr_wormTechRowManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeFieldInfoPtr_imperiumRowCue;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeFieldInfoPtr_techRowCue;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeFieldInfoPtr_onClickEvents;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeFieldInfoPtr_currentState;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeFieldInfoPtr_wormShowImperiumRow;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeFieldInfoPtr_wormTechRowManager;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_Event_Click_Public_Void_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr__Event_Click_b__8_0_Private_Boolean_EventsForBindingState_0;

		// Token: 0x020003E5 RID: 997
		[Serializable]
		public enum BindingState
		{
			// Token: 0x0400174C RID: 5964
			ShowImperiumRow,
			// Token: 0x0400174D RID: 5965
			ShowTech,
			// Token: 0x0400174E RID: 5966
			HideTech
		}

		// Token: 0x020003E6 RID: 998
		[Serializable]
		public sealed class EventsForBindingState : ValueType
		{
			// Token: 0x06002877 RID: 10359 RVA: 0x00092B1C File Offset: 0x00090D1C
			// Note: this type is marked as 'beforefieldinit'.
			static EventsForBindingState()
			{
				Il2CppClassPointerStore<WormCycleImperiumAndTechBinding.EventsForBindingState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding>.NativeClassPtr, "EventsForBindingState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding.EventsForBindingState>.NativeClassPtr);
				WormCycleImperiumAndTechBinding.EventsForBindingState.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding.EventsForBindingState>.NativeClassPtr, "state");
				WormCycleImperiumAndTechBinding.EventsForBindingState.NativeFieldInfoPtr_onClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding.EventsForBindingState>.NativeClassPtr, "onClick");
			}

			// Token: 0x06002878 RID: 10360 RVA: 0x0001632D File Offset: 0x0001452D
			public EventsForBindingState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002879 RID: 10361 RVA: 0x00016336 File Offset: 0x00014536
			public EventsForBindingState()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCycleImperiumAndTechBinding.EventsForBindingState>.NativeClassPtr))
			{
			}

			// Token: 0x17000B54 RID: 2900
			// (get) Token: 0x0600287A RID: 10362 RVA: 0x00092B70 File Offset: 0x00090D70
			// (set) Token: 0x0600287B RID: 10363 RVA: 0x00016348 File Offset: 0x00014548
			public unsafe WormCycleImperiumAndTechBinding.BindingState state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.EventsForBindingState.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.EventsForBindingState.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x17000B55 RID: 2901
			// (get) Token: 0x0600287C RID: 10364 RVA: 0x00092B98 File Offset: 0x00090D98
			// (set) Token: 0x0600287D RID: 10365 RVA: 0x00016363 File Offset: 0x00014563
			public unsafe UnityEvent onClick
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.EventsForBindingState.NativeFieldInfoPtr_onClick);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCycleImperiumAndTechBinding.EventsForBindingState.NativeFieldInfoPtr_onClick), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400174F RID: 5967
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x04001750 RID: 5968
			private static readonly IntPtr NativeFieldInfoPtr_onClick;
		}
	}
}
