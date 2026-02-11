using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.input
{
	// Token: 0x0200004C RID: 76
	public class MinimizeAndDisableInputOnButtonPress : MonoBehaviour
	{
		// Token: 0x06000271 RID: 625 RVA: 0x0000E844 File Offset: 0x0000CA44
		// Note: this type is marked as 'beforefieldinit'.
		static MinimizeAndDisableInputOnButtonPress()
		{
			Il2CppClassPointerStore<MinimizeAndDisableInputOnButtonPress>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "MinimizeAndDisableInputOnButtonPress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimizeAndDisableInputOnButtonPress>.NativeClassPtr);
			MinimizeAndDisableInputOnButtonPress.NativeFieldInfoPtr_minimizeFunctionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizeAndDisableInputOnButtonPress>.NativeClassPtr, "minimizeFunctionStack");
			MinimizeAndDisableInputOnButtonPress.NativeMethodInfoPtr_registerFunction_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizeAndDisableInputOnButtonPress>.NativeClassPtr, 100663600);
			MinimizeAndDisableInputOnButtonPress.NativeMethodInfoPtr_unregisterFunction_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizeAndDisableInputOnButtonPress>.NativeClassPtr, 100663601);
			MinimizeAndDisableInputOnButtonPress.NativeMethodInfoPtr_Event_ToggleMinimizeAndDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizeAndDisableInputOnButtonPress>.NativeClassPtr, 100663602);
			MinimizeAndDisableInputOnButtonPress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizeAndDisableInputOnButtonPress>.NativeClassPtr, 100663603);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000E8D8 File Offset: 0x0000CAD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1120797, RefRangeEnd = 1120798, XrefRangeStart = 1120791, XrefRangeEnd = 1120797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void registerFunction(Action function)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizeAndDisableInputOnButtonPress.NativeMethodInfoPtr_registerFunction_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000E91C File Offset: 0x0000CB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1120802, RefRangeEnd = 1120803, XrefRangeStart = 1120798, XrefRangeEnd = 1120802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void unregisterFunction(Action function)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizeAndDisableInputOnButtonPress.NativeMethodInfoPtr_unregisterFunction_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000E960 File Offset: 0x0000CB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120803, XrefRangeEnd = 1120807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleMinimizeAndDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizeAndDisableInputOnButtonPress.NativeMethodInfoPtr_Event_ToggleMinimizeAndDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000E994 File Offset: 0x0000CB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120807, XrefRangeEnd = 1120815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinimizeAndDisableInputOnButtonPress()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinimizeAndDisableInputOnButtonPress>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizeAndDisableInputOnButtonPress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000036BC File Offset: 0x000018BC
		public MinimizeAndDisableInputOnButtonPress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		// (set) Token: 0x06000278 RID: 632 RVA: 0x000036C5 File Offset: 0x000018C5
		public unsafe List<Action> minimizeFunctionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizeAndDisableInputOnButtonPress.NativeFieldInfoPtr_minimizeFunctionStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizeAndDisableInputOnButtonPress.NativeFieldInfoPtr_minimizeFunctionStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_minimizeFunctionStack;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_registerFunction_Public_Void_Action_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_unregisterFunction_Public_Void_Action_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleMinimizeAndDisable_Public_Void_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
