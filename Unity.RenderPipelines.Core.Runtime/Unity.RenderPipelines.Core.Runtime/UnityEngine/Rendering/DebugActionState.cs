using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000065 RID: 101
	public class DebugActionState : Object
	{
		// Token: 0x0600072E RID: 1838 RVA: 0x00028AD8 File Offset: 0x00026CD8
		// Note: this type is marked as 'beforefieldinit'.
		static DebugActionState()
		{
			Il2CppClassPointerStore<DebugActionState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugActionState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr);
			DebugActionState.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, "m_Type");
			DebugActionState.NativeFieldInfoPtr_m_PressedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, "m_PressedButtons");
			DebugActionState.NativeFieldInfoPtr_m_PressedAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, "m_PressedAxis");
			DebugActionState.NativeFieldInfoPtr_m_PressedKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, "m_PressedKeys");
			DebugActionState.NativeFieldInfoPtr_m_TriggerPressedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, "m_TriggerPressedUp");
			DebugActionState.NativeFieldInfoPtr_m_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, "m_Timer");
			DebugActionState.NativeFieldInfoPtr__runningAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, "<runningAction>k__BackingField");
			DebugActionState.NativeFieldInfoPtr__actionState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, "<actionState>k__BackingField");
			DebugActionState.NativeMethodInfoPtr_get_runningAction_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, 100664286);
			DebugActionState.NativeMethodInfoPtr_set_runningAction_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, 100664287);
			DebugActionState.NativeMethodInfoPtr_get_actionState_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, 100664288);
			DebugActionState.NativeMethodInfoPtr_set_actionState_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, 100664289);
			DebugActionState.NativeMethodInfoPtr_Trigger_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, 100664290);
			DebugActionState.NativeMethodInfoPtr_TriggerWithButton_Public_Void_Il2CppStringArray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, 100664291);
			DebugActionState.NativeMethodInfoPtr_TriggerWithAxis_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, 100664292);
			DebugActionState.NativeMethodInfoPtr_TriggerWithKey_Public_Void_Il2CppStructArray_1_KeyCode_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, 100664293);
			DebugActionState.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, 100664294);
			DebugActionState.NativeMethodInfoPtr_Update_Public_Void_DebugActionDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, 100664295);
			DebugActionState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr, 100664296);
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00028C84 File Offset: 0x00026E84
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00028CC0 File Offset: 0x00026EC0
		public unsafe bool runningAction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugActionState.NativeMethodInfoPtr_get_runningAction_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugActionState.NativeMethodInfoPtr_set_runningAction_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00028D00 File Offset: 0x00026F00
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00028D3C File Offset: 0x00026F3C
		public unsafe float actionState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300360, RefRangeEnd = 300361, XrefRangeStart = 300360, XrefRangeEnd = 300361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugActionState.NativeMethodInfoPtr_get_actionState_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 599561, RefRangeEnd = 599562, XrefRangeStart = 599561, XrefRangeEnd = 599562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugActionState.NativeMethodInfoPtr_set_actionState_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00028D7C File Offset: 0x00026F7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 963508, RefRangeEnd = 963512, XrefRangeStart = 963503, XrefRangeEnd = 963508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger(int triggerCount, float state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref triggerCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugActionState.NativeMethodInfoPtr_Trigger_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00028DC8 File Offset: 0x00026FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 963519, RefRangeEnd = 963520, XrefRangeStart = 963512, XrefRangeEnd = 963519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerWithButton(Il2CppStringArray buttons, float state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buttons);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugActionState.NativeMethodInfoPtr_TriggerWithButton_Public_Void_Il2CppStringArray_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00028E18 File Offset: 0x00027018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963520, XrefRangeEnd = 963522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerWithAxis(string axis, float state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(axis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugActionState.NativeMethodInfoPtr_TriggerWithAxis_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00028E68 File Offset: 0x00027068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 963529, RefRangeEnd = 963530, XrefRangeStart = 963522, XrefRangeEnd = 963529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerWithKey(Il2CppStructArray<KeyCode> keys, float state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugActionState.NativeMethodInfoPtr_TriggerWithKey_Public_Void_Il2CppStructArray_1_KeyCode_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00028EB8 File Offset: 0x000270B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963530, XrefRangeEnd = 963531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugActionState.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00028EEC File Offset: 0x000270EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 963541, RefRangeEnd = 963544, XrefRangeStart = 963531, XrefRangeEnd = 963541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(DebugActionDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugActionState.NativeMethodInfoPtr_Update_Public_Void_DebugActionDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00028F30 File Offset: 0x00027130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963544, XrefRangeEnd = 963549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugActionState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugActionState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugActionState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00004D75 File Offset: 0x00002F75
		public DebugActionState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00028F6C File Offset: 0x0002716C
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00004D7E File Offset: 0x00002F7E
		public unsafe DebugActionState.DebugActionKeyType m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr_m_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr_m_Type)) = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00028F94 File Offset: 0x00027194
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00004D99 File Offset: 0x00002F99
		public unsafe Il2CppStringArray m_PressedButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr_m_PressedButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr_m_PressedButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00028FC4 File Offset: 0x000271C4
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00004DB8 File Offset: 0x00002FB8
		public unsafe string m_PressedAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr_m_PressedAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr_m_PressedAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00028FEC File Offset: 0x000271EC
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00004DD7 File Offset: 0x00002FD7
		public unsafe Il2CppStructArray<KeyCode> m_PressedKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr_m_PressedKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<KeyCode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr_m_PressedKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x0002901C File Offset: 0x0002721C
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00004DF6 File Offset: 0x00002FF6
		public unsafe Il2CppStructArray<bool> m_TriggerPressedUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr_m_TriggerPressedUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr_m_TriggerPressedUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x0002904C File Offset: 0x0002724C
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00004E15 File Offset: 0x00003015
		public unsafe float m_Timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr_m_Timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr_m_Timer)) = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00029074 File Offset: 0x00027274
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00004E30 File Offset: 0x00003030
		public unsafe bool _runningAction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr__runningAction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr__runningAction_k__BackingField)) = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0002909C File Offset: 0x0002729C
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00004E4B File Offset: 0x0000304B
		public unsafe float _actionState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr__actionState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugActionState.NativeFieldInfoPtr__actionState_k__BackingField)) = value;
			}
		}

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_m_PressedButtons;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_m_PressedAxis;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_m_PressedKeys;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeFieldInfoPtr_m_TriggerPressedUp;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr_m_Timer;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr__runningAction_k__BackingField;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr__actionState_k__BackingField;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_get_runningAction_Internal_get_Boolean_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_set_runningAction_Private_set_Void_Boolean_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_get_actionState_Internal_get_Single_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_set_actionState_Private_set_Void_Single_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Private_Void_Int32_Single_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_TriggerWithButton_Public_Void_Il2CppStringArray_Single_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_TriggerWithAxis_Public_Void_String_Single_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_TriggerWithKey_Public_Void_Il2CppStructArray_1_KeyCode_Single_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_DebugActionDesc_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000191 RID: 401
		public enum DebugActionKeyType
		{
			// Token: 0x04001085 RID: 4229
			Button,
			// Token: 0x04001086 RID: 4230
			Axis,
			// Token: 0x04001087 RID: 4231
			Key
		}
	}
}
