using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006D RID: 109
	public class TouchInputModule : PointerInputModule
	{
		// Token: 0x06000B25 RID: 2853 RVA: 0x000326B8 File Offset: 0x000308B8
		// Note: this type is marked as 'beforefieldinit'.
		static TouchInputModule()
		{
			Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "TouchInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr);
			TouchInputModule.NativeFieldInfoPtr_m_LastMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "m_LastMousePosition");
			TouchInputModule.NativeFieldInfoPtr_m_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "m_MousePosition");
			TouchInputModule.NativeFieldInfoPtr_m_InputPointerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "m_InputPointerEvent");
			TouchInputModule.NativeFieldInfoPtr_m_ForceModuleActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, "m_ForceModuleActive");
			TouchInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665131);
			TouchInputModule.NativeMethodInfoPtr_get_allowActivationOnStandalone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665132);
			TouchInputModule.NativeMethodInfoPtr_set_allowActivationOnStandalone_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665133);
			TouchInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665134);
			TouchInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665135);
			TouchInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665136);
			TouchInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665137);
			TouchInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665138);
			TouchInputModule.NativeMethodInfoPtr_UseFakeInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665139);
			TouchInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665140);
			TouchInputModule.NativeMethodInfoPtr_FakeTouches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665141);
			TouchInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665142);
			TouchInputModule.NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665143);
			TouchInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665144);
			TouchInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr, 100665145);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00032864 File Offset: 0x00030A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097223, XrefRangeEnd = 1097224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x000328A0 File Offset: 0x00030AA0
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x000328DC File Offset: 0x00030ADC
		public unsafe bool allowActivationOnStandalone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_get_allowActivationOnStandalone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_set_allowActivationOnStandalone_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0003291C File Offset: 0x00030B1C
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00032958 File Offset: 0x00030B58
		public unsafe bool forceModuleActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00032998 File Offset: 0x00030B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097224, XrefRangeEnd = 1097237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x000329D4 File Offset: 0x00030BD4
		[CallerCount(0)]
		public unsafe override bool IsModuleSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00032A1C File Offset: 0x00030C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097237, XrefRangeEnd = 1097242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00032A64 File Offset: 0x00030C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097242, XrefRangeEnd = 1097243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UseFakeInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_UseFakeInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00032AA0 File Offset: 0x00030CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097243, XrefRangeEnd = 1097245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00032ADC File Offset: 0x00030CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097245, XrefRangeEnd = 1097250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FakeTouches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_FakeTouches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00032B10 File Offset: 0x00030D10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1097355, RefRangeEnd = 1097356, XrefRangeStart = 1097250, XrefRangeEnd = 1097355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTouchEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00032B44 File Offset: 0x00030D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1097464, RefRangeEnd = 1097465, XrefRangeStart = 1097356, XrefRangeEnd = 1097464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref released;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchInputModule.NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00032BA4 File Offset: 0x00030DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeactivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00032BE0 File Offset: 0x00030DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097465, XrefRangeEnd = 1097497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00005F3C File Offset: 0x0000413C
		public TouchInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00032C24 File Offset: 0x00030E24
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x00005F45 File Offset: 0x00004145
		public unsafe Vector2 m_LastMousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_LastMousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_LastMousePosition)) = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00032C4C File Offset: 0x00030E4C
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00005F60 File Offset: 0x00004160
		public unsafe Vector2 m_MousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_MousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_MousePosition)) = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x00032C74 File Offset: 0x00030E74
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x00005F7B File Offset: 0x0000417B
		public unsafe PointerEventData m_InputPointerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_InputPointerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_InputPointerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00032CA4 File Offset: 0x00030EA4
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x00005F9A File Offset: 0x0000419A
		public unsafe bool m_ForceModuleActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_ForceModuleActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchInputModule.NativeFieldInfoPtr_m_ForceModuleActive)) = value;
			}
		}

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMousePosition;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeFieldInfoPtr_m_MousePosition;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeFieldInfoPtr_m_InputPointerEvent;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceModuleActive;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_get_allowActivationOnStandalone_Public_get_Boolean_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_set_allowActivationOnStandalone_Public_set_Void_Boolean_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_Boolean_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_UseFakeInput_Private_Boolean_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_FakeTouches_Private_Void_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchEvents_Private_Void_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
