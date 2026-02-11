using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010F RID: 271
	public static class PointerDeviceState : Object
	{
		// Token: 0x060014C9 RID: 5321 RVA: 0x00066810 File Offset: 0x00064A10
		// Note: this type is marked as 'beforefieldinit'.
		static PointerDeviceState()
		{
			Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerDeviceState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr);
			PointerDeviceState.NativeFieldInfoPtr_s_PlayerPointerLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, "s_PlayerPointerLocations");
			PointerDeviceState.NativeFieldInfoPtr_s_PressedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, "s_PressedButtons");
			PointerDeviceState.NativeFieldInfoPtr_s_PlayerPanelWithSoftPointerCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, "s_PlayerPanelWithSoftPointerCapture");
			PointerDeviceState.NativeMethodInfoPtr_RemovePanelData_Internal_Static_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666342);
			PointerDeviceState.NativeMethodInfoPtr_SavePointerPosition_Public_Static_Void_Int32_Vector2_IPanel_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666343);
			PointerDeviceState.NativeMethodInfoPtr_PressButton_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666344);
			PointerDeviceState.NativeMethodInfoPtr_ReleaseButton_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666345);
			PointerDeviceState.NativeMethodInfoPtr_ReleaseAllButtons_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666346);
			PointerDeviceState.NativeMethodInfoPtr_GetPointerPosition_Public_Static_Vector2_Int32_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666347);
			PointerDeviceState.NativeMethodInfoPtr_GetPanel_Public_Static_IPanel_Int32_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666348);
			PointerDeviceState.NativeMethodInfoPtr_HasFlagFast_Private_Static_Boolean_LocationFlag_LocationFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666349);
			PointerDeviceState.NativeMethodInfoPtr_HasLocationFlag_Public_Static_Boolean_Int32_ContextType_LocationFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666350);
			PointerDeviceState.NativeMethodInfoPtr_GetPressedButtons_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666351);
			PointerDeviceState.NativeMethodInfoPtr_HasAdditionalPressedButtons_Internal_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666352);
			PointerDeviceState.NativeMethodInfoPtr_SetPlayerPanelWithSoftPointerCapture_Internal_Static_Void_Int32_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666353);
			PointerDeviceState.NativeMethodInfoPtr_GetPlayerPanelWithSoftPointerCapture_Internal_Static_IPanel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100666354);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00066980 File Offset: 0x00064B80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315714, RefRangeEnd = 315716, XrefRangeStart = 315692, XrefRangeEnd = 315714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemovePanelData(IPanel panel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_RemovePanelData_Internal_Static_Void_IPanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x000669B8 File Offset: 0x00064BB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315721, RefRangeEnd = 315725, XrefRangeStart = 315716, XrefRangeEnd = 315721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_SavePointerPosition_Public_Static_Void_Int32_Vector2_IPanel_ContextType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00066A18 File Offset: 0x00064C18
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 315734, RefRangeEnd = 315744, XrefRangeStart = 315725, XrefRangeEnd = 315734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PressButton(int pointerId, int buttonId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_PressButton_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00066A58 File Offset: 0x00064C58
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 315753, RefRangeEnd = 315764, XrefRangeStart = 315744, XrefRangeEnd = 315753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseButton(int pointerId, int buttonId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_ReleaseButton_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00066A98 File Offset: 0x00064C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315764, XrefRangeEnd = 315768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseAllButtons(int pointerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_ReleaseAllButtons_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00066ACC File Offset: 0x00064CCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315772, RefRangeEnd = 315774, XrefRangeStart = 315768, XrefRangeEnd = 315772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetPointerPosition(int pointerId, ContextType contextType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_GetPointerPosition_Public_Static_Vector2_Int32_ContextType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00066B18 File Offset: 0x00064D18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315778, RefRangeEnd = 315780, XrefRangeStart = 315774, XrefRangeEnd = 315778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPanel GetPanel(int pointerId, ContextType contextType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_GetPanel_Public_Static_IPanel_Int32_ContextType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr3) : null;
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00066B68 File Offset: 0x00064D68
		[CallerCount(0)]
		public unsafe static bool HasFlagFast(PointerDeviceState.LocationFlag flagSet, PointerDeviceState.LocationFlag flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flagSet;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_HasFlagFast_Private_Static_Boolean_LocationFlag_LocationFlag_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00066BB4 File Offset: 0x00064DB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315784, RefRangeEnd = 315786, XrefRangeStart = 315780, XrefRangeEnd = 315784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasLocationFlag(int pointerId, ContextType contextType, PointerDeviceState.LocationFlag flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_HasLocationFlag_Public_Static_Boolean_Int32_ContextType_LocationFlag_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00066C10 File Offset: 0x00064E10
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 315790, RefRangeEnd = 315799, XrefRangeStart = 315786, XrefRangeEnd = 315790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPressedButtons(int pointerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_GetPressedButtons_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00066C50 File Offset: 0x00064E50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315803, RefRangeEnd = 315806, XrefRangeStart = 315799, XrefRangeEnd = 315803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptButtonId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_HasAdditionalPressedButtons_Internal_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00066C9C File Offset: 0x00064E9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315841, RefRangeEnd = 315844, XrefRangeStart = 315806, XrefRangeEnd = 315841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_SetPlayerPanelWithSoftPointerCapture_Internal_Static_Void_Int32_IPanel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00066CE0 File Offset: 0x00064EE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315848, RefRangeEnd = 315850, XrefRangeStart = 315844, XrefRangeEnd = 315848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_GetPlayerPanelWithSoftPointerCapture_Internal_Static_IPanel_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr3) : null;
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00009DB1 File Offset: 0x00007FB1
		public PointerDeviceState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x00066D20 File Offset: 0x00064F20
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x00009DBA File Offset: 0x00007FBA
		public unsafe static Il2CppReferenceArray<PointerDeviceState.PointerLocation> s_PlayerPointerLocations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerDeviceState.NativeFieldInfoPtr_s_PlayerPointerLocations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PointerDeviceState.PointerLocation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerDeviceState.NativeFieldInfoPtr_s_PlayerPointerLocations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x00066D48 File Offset: 0x00064F48
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x00009DCC File Offset: 0x00007FCC
		public unsafe static Il2CppStructArray<int> s_PressedButtons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerDeviceState.NativeFieldInfoPtr_s_PressedButtons, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerDeviceState.NativeFieldInfoPtr_s_PressedButtons, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x00066D70 File Offset: 0x00064F70
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x00009DDE File Offset: 0x00007FDE
		public unsafe static Il2CppReferenceArray<IPanel> s_PlayerPanelWithSoftPointerCapture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerDeviceState.NativeFieldInfoPtr_s_PlayerPanelWithSoftPointerCapture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPanel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerDeviceState.NativeFieldInfoPtr_s_PlayerPanelWithSoftPointerCapture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00009DF0 File Offset: 0x00007FF0
		public static void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeFieldInfoPtr_s_PlayerPointerLocations;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeFieldInfoPtr_s_PressedButtons;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeFieldInfoPtr_s_PlayerPanelWithSoftPointerCapture;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_RemovePanelData_Internal_Static_Void_IPanel_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_SavePointerPosition_Public_Static_Void_Int32_Vector2_IPanel_ContextType_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_PressButton_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseButton_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAllButtons_Public_Static_Void_Int32_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_GetPointerPosition_Public_Static_Vector2_Int32_ContextType_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_GetPanel_Public_Static_IPanel_Int32_ContextType_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_HasFlagFast_Private_Static_Boolean_LocationFlag_LocationFlag_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_HasLocationFlag_Public_Static_Boolean_Int32_ContextType_LocationFlag_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_GetPressedButtons_Public_Static_Int32_Int32_0;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr_HasAdditionalPressedButtons_Internal_Static_Boolean_Int32_Int32_0;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerPanelWithSoftPointerCapture_Internal_Static_Void_Int32_IPanel_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerPanelWithSoftPointerCapture_Internal_Static_IPanel_Int32_0;

		// Token: 0x0200043D RID: 1085
		[Flags]
		public enum LocationFlag
		{
			// Token: 0x040029EE RID: 10734
			None = 0,
			// Token: 0x040029EF RID: 10735
			OutsidePanel = 1
		}

		// Token: 0x0200043E RID: 1086
		public sealed class PointerLocation : ValueType
		{
			// Token: 0x06003B5D RID: 15197 RVA: 0x000EF594 File Offset: 0x000ED794
			// Note: this type is marked as 'beforefieldinit'.
			static PointerLocation()
			{
				Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, "PointerLocation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr);
				PointerDeviceState.PointerLocation.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr, "<Position>k__BackingField");
				PointerDeviceState.PointerLocation.NativeFieldInfoPtr__Panel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr, "<Panel>k__BackingField");
				PointerDeviceState.PointerLocation.NativeFieldInfoPtr__Flags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr, "<Flags>k__BackingField");
				PointerDeviceState.PointerLocation.NativeMethodInfoPtr_get_Position_Internal_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr, 100666356);
				PointerDeviceState.PointerLocation.NativeMethodInfoPtr_set_Position_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr, 100666357);
				PointerDeviceState.PointerLocation.NativeMethodInfoPtr_get_Panel_Internal_get_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr, 100666358);
				PointerDeviceState.PointerLocation.NativeMethodInfoPtr_set_Panel_Private_set_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr, 100666359);
				PointerDeviceState.PointerLocation.NativeMethodInfoPtr_get_Flags_Internal_get_LocationFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr, 100666360);
				PointerDeviceState.PointerLocation.NativeMethodInfoPtr_set_Flags_Private_set_Void_LocationFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr, 100666361);
				PointerDeviceState.PointerLocation.NativeMethodInfoPtr_SetLocation_Internal_Void_Vector2_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr, 100666362);
			}

			// Token: 0x17001218 RID: 4632
			// (get) Token: 0x06003B5E RID: 15198 RVA: 0x000EF688 File Offset: 0x000ED888
			// (set) Token: 0x06003B5F RID: 15199 RVA: 0x000EF6CC File Offset: 0x000ED8CC
			public unsafe Vector2 Position
			{
				[CallerCount(99)]
				[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.PointerLocation.NativeMethodInfoPtr_get_Position_Internal_get_Vector2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(44)]
				[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.PointerLocation.NativeMethodInfoPtr_set_Position_Private_set_Void_Vector2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001219 RID: 4633
			// (get) Token: 0x06003B60 RID: 15200 RVA: 0x000EF710 File Offset: 0x000ED910
			// (set) Token: 0x06003B61 RID: 15201 RVA: 0x000EF754 File Offset: 0x000ED954
			public unsafe IPanel Panel
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.PointerLocation.NativeMethodInfoPtr_get_Panel_Internal_get_IPanel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315684, XrefRangeEnd = 315685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.PointerLocation.NativeMethodInfoPtr_set_Panel_Private_set_Void_IPanel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700121A RID: 4634
			// (get) Token: 0x06003B62 RID: 15202 RVA: 0x000EF79C File Offset: 0x000ED99C
			// (set) Token: 0x06003B63 RID: 15203 RVA: 0x000EF7E0 File Offset: 0x000ED9E0
			public unsafe PointerDeviceState.LocationFlag Flags
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.PointerLocation.NativeMethodInfoPtr_get_Flags_Internal_get_LocationFlag_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.PointerLocation.NativeMethodInfoPtr_set_Flags_Private_set_Void_LocationFlag_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06003B64 RID: 15204 RVA: 0x000EF824 File Offset: 0x000EDA24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315691, RefRangeEnd = 315692, XrefRangeStart = 315686, XrefRangeEnd = 315691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetLocation(Vector2 position, IPanel panel)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref position;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.PointerLocation.NativeMethodInfoPtr_SetLocation_Internal_Void_Vector2_IPanel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B65 RID: 15205 RVA: 0x00018F52 File Offset: 0x00017152
			public PointerLocation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003B66 RID: 15206 RVA: 0x00018F5B File Offset: 0x0001715B
			public PointerLocation()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerDeviceState.PointerLocation>.NativeClassPtr))
			{
			}

			// Token: 0x17001215 RID: 4629
			// (get) Token: 0x06003B67 RID: 15207 RVA: 0x000EF87C File Offset: 0x000EDA7C
			// (set) Token: 0x06003B68 RID: 15208 RVA: 0x00018F6D File Offset: 0x0001716D
			public unsafe Vector2 _Position_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDeviceState.PointerLocation.NativeFieldInfoPtr__Position_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDeviceState.PointerLocation.NativeFieldInfoPtr__Position_k__BackingField)) = value;
				}
			}

			// Token: 0x17001216 RID: 4630
			// (get) Token: 0x06003B69 RID: 15209 RVA: 0x000EF8A4 File Offset: 0x000EDAA4
			// (set) Token: 0x06003B6A RID: 15210 RVA: 0x00018F88 File Offset: 0x00017188
			public unsafe IPanel _Panel_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDeviceState.PointerLocation.NativeFieldInfoPtr__Panel_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDeviceState.PointerLocation.NativeFieldInfoPtr__Panel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001217 RID: 4631
			// (get) Token: 0x06003B6B RID: 15211 RVA: 0x000EF8D4 File Offset: 0x000EDAD4
			// (set) Token: 0x06003B6C RID: 15212 RVA: 0x00018FA7 File Offset: 0x000171A7
			public unsafe PointerDeviceState.LocationFlag _Flags_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDeviceState.PointerLocation.NativeFieldInfoPtr__Flags_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerDeviceState.PointerLocation.NativeFieldInfoPtr__Flags_k__BackingField)) = value;
				}
			}

			// Token: 0x040029F0 RID: 10736
			private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;

			// Token: 0x040029F1 RID: 10737
			private static readonly IntPtr NativeFieldInfoPtr__Panel_k__BackingField;

			// Token: 0x040029F2 RID: 10738
			private static readonly IntPtr NativeFieldInfoPtr__Flags_k__BackingField;

			// Token: 0x040029F3 RID: 10739
			private static readonly IntPtr NativeMethodInfoPtr_get_Position_Internal_get_Vector2_0;

			// Token: 0x040029F4 RID: 10740
			private static readonly IntPtr NativeMethodInfoPtr_set_Position_Private_set_Void_Vector2_0;

			// Token: 0x040029F5 RID: 10741
			private static readonly IntPtr NativeMethodInfoPtr_get_Panel_Internal_get_IPanel_0;

			// Token: 0x040029F6 RID: 10742
			private static readonly IntPtr NativeMethodInfoPtr_set_Panel_Private_set_Void_IPanel_0;

			// Token: 0x040029F7 RID: 10743
			private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Internal_get_LocationFlag_0;

			// Token: 0x040029F8 RID: 10744
			private static readonly IntPtr NativeMethodInfoPtr_set_Flags_Private_set_Void_LocationFlag_0;

			// Token: 0x040029F9 RID: 10745
			private static readonly IntPtr NativeMethodInfoPtr_SetLocation_Internal_Void_Vector2_IPanel_0;
		}
	}
}
