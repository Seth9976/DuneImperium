using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001DC RID: 476
	public class ITextEdition : Il2CppObjectBase
	{
		// Token: 0x060025B2 RID: 9650 RVA: 0x000A7F8C File Offset: 0x000A618C
		// Note: this type is marked as 'beforefieldinit'.
		static ITextEdition()
		{
			Il2CppClassPointerStore<ITextEdition>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ITextEdition");
			ITextEdition.NativeMethodInfoPtr_get_multiline_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100668988);
			ITextEdition.NativeMethodInfoPtr_set_multiline_Internal_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100668989);
			ITextEdition.NativeMethodInfoPtr_get_isReadOnly_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100668990);
			ITextEdition.NativeMethodInfoPtr_set_isReadOnly_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100668991);
			ITextEdition.NativeMethodInfoPtr_get_maxLength_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100668992);
			ITextEdition.NativeMethodInfoPtr_set_maxLength_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100668993);
			ITextEdition.NativeMethodInfoPtr_get_isDelayed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100668994);
			ITextEdition.NativeMethodInfoPtr_set_isDelayed_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100668995);
			ITextEdition.NativeMethodInfoPtr_SaveValueAndText_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100668996);
			ITextEdition.NativeMethodInfoPtr_RestoreValueAndText_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100668997);
			ITextEdition.NativeMethodInfoPtr_get_AcceptCharacter_Internal_Abstract_Virtual_New_get_Func_2_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100668998);
			ITextEdition.NativeMethodInfoPtr_set_AcceptCharacter_Internal_Abstract_Virtual_New_set_Void_Func_2_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100668999);
			ITextEdition.NativeMethodInfoPtr_get_UpdateScrollOffset_Internal_Abstract_Virtual_New_get_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669000);
			ITextEdition.NativeMethodInfoPtr_set_UpdateScrollOffset_Internal_Abstract_Virtual_New_set_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669001);
			ITextEdition.NativeMethodInfoPtr_get_UpdateValueFromText_Internal_Abstract_Virtual_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669002);
			ITextEdition.NativeMethodInfoPtr_set_UpdateValueFromText_Internal_Abstract_Virtual_New_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669003);
			ITextEdition.NativeMethodInfoPtr_get_UpdateTextFromValue_Internal_Abstract_Virtual_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669004);
			ITextEdition.NativeMethodInfoPtr_set_UpdateTextFromValue_Internal_Abstract_Virtual_New_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669005);
			ITextEdition.NativeMethodInfoPtr_get_MoveFocusToCompositeRoot_Internal_Abstract_Virtual_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669006);
			ITextEdition.NativeMethodInfoPtr_set_MoveFocusToCompositeRoot_Internal_Abstract_Virtual_New_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669007);
			ITextEdition.NativeMethodInfoPtr_UpdateText_Internal_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669008);
			ITextEdition.NativeMethodInfoPtr_CullString_Internal_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669009);
			ITextEdition.NativeMethodInfoPtr_set_maskChar_Public_Abstract_Virtual_New_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669010);
			ITextEdition.NativeMethodInfoPtr_get_isPassword_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669011);
			ITextEdition.NativeMethodInfoPtr_set_isPassword_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669012);
			ITextEdition.NativeMethodInfoPtr_get_autoCorrection_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669013);
			ITextEdition.NativeMethodInfoPtr_set_autoCorrection_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669014);
			ITextEdition.NativeMethodInfoPtr_get_hideMobileInput_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669015);
			ITextEdition.NativeMethodInfoPtr_set_hideMobileInput_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669016);
			ITextEdition.NativeMethodInfoPtr_get_keyboardType_Public_Virtual_New_get_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669017);
			ITextEdition.NativeMethodInfoPtr_set_keyboardType_Public_Virtual_New_set_Void_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextEdition>.NativeClassPtr, 100669018);
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x000A8220 File Offset: 0x000A6420
		// (set) Token: 0x060025B4 RID: 9652 RVA: 0x000A8268 File Offset: 0x000A6468
		public unsafe virtual bool multiline
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_multiline_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_multiline_Internal_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x000A82B4 File Offset: 0x000A64B4
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x000A82FC File Offset: 0x000A64FC
		public unsafe virtual bool isReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_isReadOnly_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_isReadOnly_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x000A8348 File Offset: 0x000A6548
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x000A8390 File Offset: 0x000A6590
		public unsafe virtual int maxLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_maxLength_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_maxLength_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x000A83DC File Offset: 0x000A65DC
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x000A8424 File Offset: 0x000A6624
		public unsafe virtual bool isDelayed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_isDelayed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_isDelayed_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x000A8470 File Offset: 0x000A6670
		[CallerCount(0)]
		public unsafe virtual void SaveValueAndText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_SaveValueAndText_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x000A84AC File Offset: 0x000A66AC
		[CallerCount(0)]
		public unsafe virtual void RestoreValueAndText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_RestoreValueAndText_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x000A84E8 File Offset: 0x000A66E8
		// (set) Token: 0x060025BE RID: 9662 RVA: 0x000A8534 File Offset: 0x000A6734
		public unsafe virtual Func<char, bool> AcceptCharacter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_AcceptCharacter_Internal_Abstract_Virtual_New_get_Func_2_Char_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<char, bool>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_AcceptCharacter_Internal_Abstract_Virtual_New_set_Void_Func_2_Char_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x000A8584 File Offset: 0x000A6784
		// (set) Token: 0x060025C0 RID: 9664 RVA: 0x000A85D0 File Offset: 0x000A67D0
		public unsafe virtual Action<bool> UpdateScrollOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_UpdateScrollOffset_Internal_Abstract_Virtual_New_get_Action_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_UpdateScrollOffset_Internal_Abstract_Virtual_New_set_Void_Action_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x000A8620 File Offset: 0x000A6820
		// (set) Token: 0x060025C2 RID: 9666 RVA: 0x000A866C File Offset: 0x000A686C
		public unsafe virtual Action UpdateValueFromText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_UpdateValueFromText_Internal_Abstract_Virtual_New_get_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_UpdateValueFromText_Internal_Abstract_Virtual_New_set_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060025C3 RID: 9667 RVA: 0x000A86BC File Offset: 0x000A68BC
		// (set) Token: 0x060025C4 RID: 9668 RVA: 0x000A8708 File Offset: 0x000A6908
		public unsafe virtual Action UpdateTextFromValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_UpdateTextFromValue_Internal_Abstract_Virtual_New_get_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_UpdateTextFromValue_Internal_Abstract_Virtual_New_set_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x000A8758 File Offset: 0x000A6958
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x000A87A4 File Offset: 0x000A69A4
		public unsafe virtual Action MoveFocusToCompositeRoot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_MoveFocusToCompositeRoot_Internal_Abstract_Virtual_New_get_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_MoveFocusToCompositeRoot_Internal_Abstract_Virtual_New_set_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x000A87F4 File Offset: 0x000A69F4
		[CallerCount(0)]
		public unsafe virtual void UpdateText(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_UpdateText_Internal_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x000A8844 File Offset: 0x000A6A44
		[CallerCount(0)]
		public unsafe virtual string CullString(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_CullString_Internal_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (set) Token: 0x060025C9 RID: 9673 RVA: 0x000A8898 File Offset: 0x000A6A98
		public unsafe virtual char maskChar
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_maskChar_Public_Abstract_Virtual_New_set_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x000A88E4 File Offset: 0x000A6AE4
		// (set) Token: 0x060025CB RID: 9675 RVA: 0x000A892C File Offset: 0x000A6B2C
		public unsafe virtual bool isPassword
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_isPassword_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_isPassword_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x000A8978 File Offset: 0x000A6B78
		// (set) Token: 0x060025CD RID: 9677 RVA: 0x000A89C0 File Offset: 0x000A6BC0
		public unsafe virtual bool autoCorrection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339982, XrefRangeEnd = 339992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_autoCorrection_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339992, XrefRangeEnd = 340003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_autoCorrection_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x000A8A0C File Offset: 0x000A6C0C
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x000A8A54 File Offset: 0x000A6C54
		public unsafe virtual bool hideMobileInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340003, XrefRangeEnd = 340013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_hideMobileInput_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340013, XrefRangeEnd = 340024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_hideMobileInput_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x000A8AA0 File Offset: 0x000A6CA0
		// (set) Token: 0x060025D1 RID: 9681 RVA: 0x000A8AE8 File Offset: 0x000A6CE8
		public unsafe virtual TouchScreenKeyboardType keyboardType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340024, XrefRangeEnd = 340034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_get_keyboardType_Public_Virtual_New_get_TouchScreenKeyboardType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340034, XrefRangeEnd = 340045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextEdition.NativeMethodInfoPtr_set_keyboardType_Public_Virtual_New_set_Void_TouchScreenKeyboardType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x0000F787 File Offset: 0x0000D987
		public ITextEdition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x000A8B34 File Offset: 0x000A6D34
		public virtual TouchScreenKeyboard touchScreenKeyboard
		{
			get
			{
				Debug.Log(String.Concat("Type ", base.GetType().Name, " implementing interface ITextEdition is missing the implementation for touchScreenKeyboard. Calling ITextEdition.touchScreenKeyboard of this type will always return null."));
				return null;
			}
		}

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeMethodInfoPtr_get_multiline_Internal_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeMethodInfoPtr_set_multiline_Internal_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadOnly_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeMethodInfoPtr_set_isReadOnly_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeMethodInfoPtr_get_maxLength_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeMethodInfoPtr_set_maxLength_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeMethodInfoPtr_get_isDelayed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeMethodInfoPtr_set_isDelayed_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeMethodInfoPtr_SaveValueAndText_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeMethodInfoPtr_RestoreValueAndText_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeMethodInfoPtr_get_AcceptCharacter_Internal_Abstract_Virtual_New_get_Func_2_Char_Boolean_0;

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeMethodInfoPtr_set_AcceptCharacter_Internal_Abstract_Virtual_New_set_Void_Func_2_Char_Boolean_0;

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateScrollOffset_Internal_Abstract_Virtual_New_get_Action_1_Boolean_0;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateScrollOffset_Internal_Abstract_Virtual_New_set_Void_Action_1_Boolean_0;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateValueFromText_Internal_Abstract_Virtual_New_get_Action_0;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateValueFromText_Internal_Abstract_Virtual_New_set_Void_Action_0;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateTextFromValue_Internal_Abstract_Virtual_New_get_Action_0;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateTextFromValue_Internal_Abstract_Virtual_New_set_Void_Action_0;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveFocusToCompositeRoot_Internal_Abstract_Virtual_New_get_Action_0;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeMethodInfoPtr_set_MoveFocusToCompositeRoot_Internal_Abstract_Virtual_New_set_Void_Action_0;

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeMethodInfoPtr_UpdateText_Internal_Abstract_Virtual_New_Void_String_0;

		// Token: 0x04001B2E RID: 6958
		private static readonly IntPtr NativeMethodInfoPtr_CullString_Internal_Abstract_Virtual_New_String_String_0;

		// Token: 0x04001B2F RID: 6959
		private static readonly IntPtr NativeMethodInfoPtr_set_maskChar_Public_Abstract_Virtual_New_set_Void_Char_0;

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeMethodInfoPtr_get_isPassword_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeMethodInfoPtr_set_isPassword_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeMethodInfoPtr_get_autoCorrection_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeMethodInfoPtr_set_autoCorrection_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeMethodInfoPtr_get_hideMobileInput_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeMethodInfoPtr_set_hideMobileInput_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardType_Public_Virtual_New_get_TouchScreenKeyboardType_0;

		// Token: 0x04001B37 RID: 6967
		private static readonly IntPtr NativeMethodInfoPtr_set_keyboardType_Public_Virtual_New_set_Void_TouchScreenKeyboardType_0;
	}
}
