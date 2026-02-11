using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace dwd.core.input
{
	// Token: 0x02000050 RID: 80
	public sealed class MousePressInterpreter : Object
	{
		// Token: 0x06000297 RID: 663 RVA: 0x0000F030 File Offset: 0x0000D230
		// Note: this type is marked as 'beforefieldinit'.
		static MousePressInterpreter()
		{
			Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "MousePressInterpreter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr);
			MousePressInterpreter.NativeFieldInfoPtr_updatePressesCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, "updatePressesCallback");
			MousePressInterpreter.NativeFieldInfoPtr_getMouseActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, "getMouseActions");
			MousePressInterpreter.NativeFieldInfoPtr_activePresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, "activePresses");
			MousePressInterpreter.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, "buttons");
			MousePressInterpreter.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, "actions");
			MousePressInterpreter.NativeFieldInfoPtr_readOnlyActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, "readOnlyActions");
			MousePressInterpreter.NativeFieldInfoPtr_readOnlyActivePresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, "readOnlyActivePresses");
			MousePressInterpreter.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, "current");
			MousePressInterpreter.NativeFieldInfoPtr__ActivePresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, "_ActivePresses");
			MousePressInterpreter.NativeFieldInfoPtr_lastSampleFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, "lastSampleFrame");
			MousePressInterpreter.NativeMethodInfoPtr__ctor_Public_Void_Action_GetMouseActionsDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, 100663616);
			MousePressInterpreter.NativeMethodInfoPtr_get_Current_Public_get_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, 100663617);
			MousePressInterpreter.NativeMethodInfoPtr_get_ActivePresses_Public_get_ReadOnlyDictionary_2_Int32_MousePress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, 100663618);
			MousePressInterpreter.NativeMethodInfoPtr_get_Actions_Public_get_ReadOnlyCollection_1_PressAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, 100663619);
			MousePressInterpreter.NativeMethodInfoPtr_assertSample_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, 100663620);
			MousePressInterpreter.NativeMethodInfoPtr_Sample_Public_Void_IList_1_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, 100663621);
			MousePressInterpreter.NativeMethodInfoPtr_Default_GetMouseActions_Private_Static_Void_IList_1_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, 100663622);
			MousePressInterpreter.NativeMethodInfoPtr_GetActionUp_Public_Static_PressAction_InputSample_byref_MutableMousePress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, 100663623);
			MousePressInterpreter.NativeMethodInfoPtr_GetActionDown_Public_Static_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, 100663624);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000F1DC File Offset: 0x0000D3DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1120923, RefRangeEnd = 1120924, XrefRangeStart = 1120869, XrefRangeEnd = 1120923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MousePressInterpreter(Action updatePressesCallback, MousePressInterpreter.GetMouseActionsDelegate getMouseActions = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updatePressesCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getMouseActions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.NativeMethodInfoPtr__ctor_Public_Void_Action_GetMouseActionsDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000F23C File Offset: 0x0000D43C
		public unsafe InputSample Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120924, XrefRangeEnd = 1120925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.NativeMethodInfoPtr_get_Current_Public_get_InputSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new InputSample(intPtr);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000F274 File Offset: 0x0000D474
		public unsafe global::ReadOnlyDictionary<int, MousePress> ActivePresses
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120925, XrefRangeEnd = 1120926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.NativeMethodInfoPtr_get_ActivePresses_Public_get_ReadOnlyDictionary_2_Int32_MousePress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::ReadOnlyDictionary<int, MousePress>>(intPtr3) : null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0000F2B4 File Offset: 0x0000D4B4
		public unsafe ReadOnlyCollection<PressAction> Actions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120926, XrefRangeEnd = 1120927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.NativeMethodInfoPtr_get_Actions_Public_get_ReadOnlyCollection_1_PressAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<PressAction>>(intPtr3) : null;
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120927, XrefRangeEnd = 1120928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void assertSample()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.NativeMethodInfoPtr_assertSample_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000F328 File Offset: 0x0000D528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1120990, RefRangeEnd = 1120991, XrefRangeStart = 1120928, XrefRangeEnd = 1120990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sample(IList<Press> outList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.NativeMethodInfoPtr_Sample_Public_Void_IList_1_Press_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000F36C File Offset: 0x0000D56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120991, XrefRangeEnd = 1121045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Default_GetMouseActions(IList<PressAction> actions, MouseButton button, InputSample sample, Action updatePressesCallback, ref MutableMousePress activePress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref button;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sample));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updatePressesCallback);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(activePress);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.NativeMethodInfoPtr_Default_GetMouseActions_Private_Static_Void_IList_1_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			activePress = ((intPtr4 == 0) ? null : new MutableMousePress(intPtr4));
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000F404 File Offset: 0x0000D604
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1121052, RefRangeEnd = 1121054, XrefRangeStart = 1121045, XrefRangeEnd = 1121052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PressAction GetActionUp(InputSample sample, ref MutableMousePress press)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sample));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(press);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.NativeMethodInfoPtr_GetActionUp_Public_Static_PressAction_InputSample_byref_MutableMousePress_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			press = ((intPtr4 == 0) ? null : new MutableMousePress(intPtr4));
			return new PressAction(intPtr2);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000F470 File Offset: 0x0000D670
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1121061, RefRangeEnd = 1121063, XrefRangeStart = 1121054, XrefRangeEnd = 1121061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PressAction GetActionDown(MouseButton button, InputSample sample, Action updatePressesCallback, out MutableMousePress press)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref button;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sample));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updatePressesCallback);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.NativeMethodInfoPtr_GetActionDown_Public_Static_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			press = ((intPtr4 == 0) ? null : new MutableMousePress(intPtr4));
			return new PressAction(intPtr2);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000037B1 File Offset: 0x000019B1
		public MousePressInterpreter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x000037BA File Offset: 0x000019BA
		public unsafe Action updatePressesCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_updatePressesCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_updatePressesCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000F524 File Offset: 0x0000D724
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x000037D9 File Offset: 0x000019D9
		public unsafe MousePressInterpreter.GetMouseActionsDelegate getMouseActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_getMouseActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MousePressInterpreter.GetMouseActionsDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_getMouseActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000F554 File Offset: 0x0000D754
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x000037F8 File Offset: 0x000019F8
		public unsafe Dictionary<int, MutableMousePress> activePresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_activePresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, MutableMousePress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_activePresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000F584 File Offset: 0x0000D784
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00003817 File Offset: 0x00001A17
		public unsafe IList<int> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000F5B4 File Offset: 0x0000D7B4
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00003836 File Offset: 0x00001A36
		public unsafe List<PressAction> actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PressAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00003855 File Offset: 0x00001A55
		public unsafe ReadOnlyCollection<PressAction> readOnlyActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_readOnlyActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<PressAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_readOnlyActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000F614 File Offset: 0x0000D814
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00003874 File Offset: 0x00001A74
		public unsafe Dictionary<int, MousePress> readOnlyActivePresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_readOnlyActivePresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, MousePress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_readOnlyActivePresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000F644 File Offset: 0x0000D844
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00003893 File Offset: 0x00001A93
		public InputSample current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_current);
				return new InputSample(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputSample>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputSample>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000F674 File Offset: 0x0000D874
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x000038C1 File Offset: 0x00001AC1
		public unsafe global::ReadOnlyDictionary<int, MousePress> _ActivePresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr__ActivePresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::ReadOnlyDictionary<int, MousePress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr__ActivePresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000F6A4 File Offset: 0x0000D8A4
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000038E0 File Offset: 0x00001AE0
		public unsafe int lastSampleFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_lastSampleFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MousePressInterpreter.NativeFieldInfoPtr_lastSampleFrame)) = value;
			}
		}

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_updatePressesCallback;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_getMouseActions;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_activePresses;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_actions;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_readOnlyActions;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_readOnlyActivePresses;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr__ActivePresses;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_lastSampleFrame;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_GetMouseActionsDelegate_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_InputSample_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivePresses_Public_get_ReadOnlyDictionary_2_Int32_MousePress_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_get_Actions_Public_get_ReadOnlyCollection_1_PressAction_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_assertSample_Private_Void_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_Sample_Public_Void_IList_1_Press_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_Default_GetMouseActions_Private_Static_Void_IList_1_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_GetActionUp_Public_Static_PressAction_InputSample_byref_MutableMousePress_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_GetActionDown_Public_Static_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_0;

		// Token: 0x020000C2 RID: 194
		public sealed class GetMouseActionsDelegate : MulticastDelegate
		{
			// Token: 0x060008B8 RID: 2232 RVA: 0x00023184 File Offset: 0x00021384
			// Note: this type is marked as 'beforefieldinit'.
			static GetMouseActionsDelegate()
			{
				Il2CppClassPointerStore<MousePressInterpreter.GetMouseActionsDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, "GetMouseActionsDelegate");
				MousePressInterpreter.GetMouseActionsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter.GetMouseActionsDelegate>.NativeClassPtr, 100663625);
				MousePressInterpreter.GetMouseActionsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IList_1_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter.GetMouseActionsDelegate>.NativeClassPtr, 100663626);
				MousePressInterpreter.GetMouseActionsDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IList_1_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter.GetMouseActionsDelegate>.NativeClassPtr, 100663627);
				MousePressInterpreter.GetMouseActionsDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_MutableMousePress_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePressInterpreter.GetMouseActionsDelegate>.NativeClassPtr, 100663628);
			}

			// Token: 0x060008B9 RID: 2233 RVA: 0x000231F8 File Offset: 0x000213F8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1120860, RefRangeEnd = 1120862, XrefRangeStart = 1120851, XrefRangeEnd = 1120860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetMouseActionsDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MousePressInterpreter.GetMouseActionsDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.GetMouseActionsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060008BA RID: 2234 RVA: 0x00023254 File Offset: 0x00021454
			[CallerCount(0)]
			public unsafe void Invoke(IList<PressAction> actions, MouseButton button, InputSample sample, Action updatePressesCallback, ref MutableMousePress activePress)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(actions);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref button;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sample));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updatePressesCallback);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(activePress);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.GetMouseActionsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IList_1_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				activePress = ((intPtr4 == 0) ? null : new MutableMousePress(intPtr4));
			}

			// Token: 0x060008BB RID: 2235 RVA: 0x000232F8 File Offset: 0x000214F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120862, XrefRangeEnd = 1120869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IList<PressAction> actions, MouseButton button, InputSample sample, Action updatePressesCallback, ref MutableMousePress activePress, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(actions);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref button;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sample));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updatePressesCallback);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(activePress);
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.GetMouseActionsDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IList_1_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				activePress = ((intPtr4 == 0) ? null : new MutableMousePress(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x060008BC RID: 2236 RVA: 0x000233D4 File Offset: 0x000215D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref MutableMousePress activePress, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(activePress);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MousePressInterpreter.GetMouseActionsDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_MutableMousePress_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				activePress = ((intPtr4 == 0) ? null : new MutableMousePress(intPtr4));
			}

			// Token: 0x060008BD RID: 2237 RVA: 0x00006908 File Offset: 0x00004B08
			public GetMouseActionsDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000562 RID: 1378
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000563 RID: 1379
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IList_1_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_0;

			// Token: 0x04000564 RID: 1380
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IList_1_PressAction_MouseButton_InputSample_Action_byref_MutableMousePress_AsyncCallback_Object_0;

			// Token: 0x04000565 RID: 1381
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_MutableMousePress_IAsyncResult_0;
		}

		// Token: 0x020000C3 RID: 195
		[ObfuscatedName("dwd.core.input.MousePressInterpreter+<>O")]
		public static class __O : Object
		{
			// Token: 0x060008BE RID: 2238 RVA: 0x00006911 File Offset: 0x00004B11
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<MousePressInterpreter.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MousePressInterpreter>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MousePressInterpreter.__O>.NativeClassPtr);
				MousePressInterpreter.__O.NativeFieldInfoPtr__0___Default_GetMouseActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePressInterpreter.__O>.NativeClassPtr, "<0>__Default_GetMouseActions");
			}

			// Token: 0x060008BF RID: 2239 RVA: 0x00006945 File Offset: 0x00004B45
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00023440 File Offset: 0x00021640
			// (set) Token: 0x060008C1 RID: 2241 RVA: 0x0000694E File Offset: 0x00004B4E
			public unsafe static MousePressInterpreter.GetMouseActionsDelegate _0___Default_GetMouseActions
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MousePressInterpreter.__O.NativeFieldInfoPtr__0___Default_GetMouseActions, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MousePressInterpreter.GetMouseActionsDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MousePressInterpreter.__O.NativeFieldInfoPtr__0___Default_GetMouseActions, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000566 RID: 1382
			private static readonly IntPtr NativeFieldInfoPtr__0___Default_GetMouseActions;
		}
	}
}
