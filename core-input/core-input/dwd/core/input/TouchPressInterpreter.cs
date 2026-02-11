using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace dwd.core.input
{
	// Token: 0x02000058 RID: 88
	public class TouchPressInterpreter : Object
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x00010270 File Offset: 0x0000E470
		// Note: this type is marked as 'beforefieldinit'.
		static TouchPressInterpreter()
		{
			Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "TouchPressInterpreter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr);
			TouchPressInterpreter.NativeFieldInfoPtr_updatePressesCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, "updatePressesCallback");
			TouchPressInterpreter.NativeFieldInfoPtr_activePresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, "activePresses");
			TouchPressInterpreter.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, "actions");
			TouchPressInterpreter.NativeFieldInfoPtr_readOnlyActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, "readOnlyActions");
			TouchPressInterpreter.NativeFieldInfoPtr_readOnlyActivePresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, "readOnlyActivePresses");
			TouchPressInterpreter.NativeFieldInfoPtr__ActivePresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, "_ActivePresses");
			TouchPressInterpreter.NativeFieldInfoPtr_lastSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, "lastSample");
			TouchPressInterpreter.NativeFieldInfoPtr_temp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, "temp");
			TouchPressInterpreter.NativeMethodInfoPtr__ctor_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, 100663650);
			TouchPressInterpreter.NativeMethodInfoPtr_get_ActivePresses_Public_get_ReadOnlyDictionary_2_Int32_TouchPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, 100663651);
			TouchPressInterpreter.NativeMethodInfoPtr_get_Actions_Public_get_ReadOnlyCollection_1_PressAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, 100663652);
			TouchPressInterpreter.NativeMethodInfoPtr_assertSample_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, 100663653);
			TouchPressInterpreter.NativeMethodInfoPtr_Sample_Public_Void_IList_1_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, 100663654);
			TouchPressInterpreter.NativeMethodInfoPtr_endTouch_Private_Void_MutableTouchPress_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr, 100663655);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000103B8 File Offset: 0x0000E5B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1121219, RefRangeEnd = 1121220, XrefRangeStart = 1121177, XrefRangeEnd = 1121219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchPressInterpreter(Action updatePressesCallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchPressInterpreter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updatePressesCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPressInterpreter.NativeMethodInfoPtr__ctor_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00010404 File Offset: 0x0000E604
		public unsafe global::ReadOnlyDictionary<int, TouchPress> ActivePresses
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121220, XrefRangeEnd = 1121221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPressInterpreter.NativeMethodInfoPtr_get_ActivePresses_Public_get_ReadOnlyDictionary_2_Int32_TouchPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::ReadOnlyDictionary<int, TouchPress>>(intPtr3) : null;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00010444 File Offset: 0x0000E644
		public unsafe ReadOnlyCollection<PressAction> Actions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121221, XrefRangeEnd = 1121222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPressInterpreter.NativeMethodInfoPtr_get_Actions_Public_get_ReadOnlyCollection_1_PressAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<PressAction>>(intPtr3) : null;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00010484 File Offset: 0x0000E684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121222, XrefRangeEnd = 1121223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void assertSample()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPressInterpreter.NativeMethodInfoPtr_assertSample_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000104B8 File Offset: 0x0000E6B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1121328, RefRangeEnd = 1121329, XrefRangeStart = 1121223, XrefRangeEnd = 1121328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sample(IList<Press> outList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPressInterpreter.NativeMethodInfoPtr_Sample_Public_Void_IList_1_Press_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000104FC File Offset: 0x0000E6FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1121343, RefRangeEnd = 1121345, XrefRangeStart = 1121329, XrefRangeEnd = 1121343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void endTouch(MutableTouchPress activePress, InputSample sample)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activePress);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sample));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPressInterpreter.NativeMethodInfoPtr_endTouch_Private_Void_MutableTouchPress_InputSample_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00003B1A File Offset: 0x00001D1A
		public TouchPressInterpreter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00010558 File Offset: 0x0000E758
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00003B23 File Offset: 0x00001D23
		public unsafe Action updatePressesCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_updatePressesCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_updatePressesCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00010588 File Offset: 0x0000E788
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00003B42 File Offset: 0x00001D42
		public unsafe Dictionary<int, MutableTouchPress> activePresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_activePresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, MutableTouchPress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_activePresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000105B8 File Offset: 0x0000E7B8
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00003B61 File Offset: 0x00001D61
		public unsafe List<PressAction> actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PressAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000300 RID: 768 RVA: 0x000105E8 File Offset: 0x0000E7E8
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00003B80 File Offset: 0x00001D80
		public unsafe ReadOnlyCollection<PressAction> readOnlyActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_readOnlyActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<PressAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_readOnlyActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00010618 File Offset: 0x0000E818
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00003B9F File Offset: 0x00001D9F
		public unsafe Dictionary<int, TouchPress> readOnlyActivePresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_readOnlyActivePresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TouchPress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_readOnlyActivePresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00010648 File Offset: 0x0000E848
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00003BBE File Offset: 0x00001DBE
		public unsafe global::ReadOnlyDictionary<int, TouchPress> _ActivePresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr__ActivePresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::ReadOnlyDictionary<int, TouchPress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr__ActivePresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00010678 File Offset: 0x0000E878
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00003BDD File Offset: 0x00001DDD
		public unsafe int lastSample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_lastSample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_lastSample)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000308 RID: 776 RVA: 0x000106A0 File Offset: 0x0000E8A0
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00003BF8 File Offset: 0x00001DF8
		public unsafe HashSet<MutableTouchPress> temp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_temp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<MutableTouchPress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPressInterpreter.NativeFieldInfoPtr_temp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr_updatePressesCallback;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_activePresses;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_actions;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_readOnlyActions;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_readOnlyActivePresses;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr__ActivePresses;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_lastSample;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_temp;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivePresses_Public_get_ReadOnlyDictionary_2_Int32_TouchPress_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_get_Actions_Public_get_ReadOnlyCollection_1_PressAction_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_assertSample_Private_Void_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_Sample_Public_Void_IList_1_Press_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_endTouch_Private_Void_MutableTouchPress_InputSample_0;
	}
}
