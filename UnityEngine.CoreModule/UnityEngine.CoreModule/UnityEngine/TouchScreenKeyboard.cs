using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000170 RID: 368
	public class TouchScreenKeyboard : Object
	{
		// Token: 0x06001B8B RID: 7051 RVA: 0x0007E014 File Offset: 0x0007C214
		// Note: this type is marked as 'beforefieldinit'.
		static TouchScreenKeyboard()
		{
			Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TouchScreenKeyboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr);
			TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, "m_Ptr");
			TouchScreenKeyboard.NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, "<disableInPlaceEditing>k__BackingField");
			TouchScreenKeyboard.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667051);
			TouchScreenKeyboard.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667052);
			TouchScreenKeyboard.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667053);
			TouchScreenKeyboard.NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667054);
			TouchScreenKeyboard.NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667055);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667056);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_disableInPlaceEditing_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667057);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667058);
			TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667059);
			TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667060);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667061);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667062);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667063);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667064);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667065);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_status_Public_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667066);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667067);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667068);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667069);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667070);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667071);
			TouchScreenKeyboard.NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667072);
			TouchScreenKeyboard.NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667073);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_visible_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100667074);
			TouchScreenKeyboard.IsRequiredToForceOpenDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.IsRequiredToForceOpenDelegate>("UnityEngine.TouchScreenKeyboard::IsRequiredToForceOpen");
			TouchScreenKeyboard.get_hideInputDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_hideInputDelegate>("UnityEngine.TouchScreenKeyboard::get_hideInput");
			TouchScreenKeyboard.GetDoneDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.GetDoneDelegate>("UnityEngine.TouchScreenKeyboard::GetDone");
			TouchScreenKeyboard.GetWasCanceledDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.GetWasCanceledDelegate>("UnityEngine.TouchScreenKeyboard::GetWasCanceled");
			TouchScreenKeyboard.get_characterLimitDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_characterLimitDelegate>("UnityEngine.TouchScreenKeyboard::get_characterLimit");
			TouchScreenKeyboard.get_typeDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_typeDelegate>("UnityEngine.TouchScreenKeyboard::get_type");
			TouchScreenKeyboard.get_area_InjectedDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_area_InjectedDelegate>("UnityEngine.TouchScreenKeyboard::get_area_Injected");
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0007E2B8 File Offset: 0x0007C4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673970, XrefRangeEnd = 673972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0007E2EC File Offset: 0x0007C4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673972, XrefRangeEnd = 673979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0007E320 File Offset: 0x0007C520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673979, XrefRangeEnd = 673989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchScreenKeyboard.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0007E35C File Offset: 0x0007C55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 673989, XrefRangeEnd = 674003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autocorrection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alert;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0007E410 File Offset: 0x0007C610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 674003, XrefRangeEnd = 674005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &arguments;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x0007E474 File Offset: 0x0007C674
		public unsafe static bool isSupported
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 674009, RefRangeEnd = 674026, XrefRangeStart = 674005, XrefRangeEnd = 674009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x0007E4A4 File Offset: 0x0007C6A4
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x0000AB6E File Offset: 0x00008D6E
		public unsafe static bool disableInPlaceEditing
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 674026, XrefRangeEnd = 674028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_disableInPlaceEditing_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				TouchScreenKeyboard._disableInPlaceEditing_k__BackingField = value;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x0007E4D4 File Offset: 0x0007C6D4
		public unsafe static bool isInPlaceEditingAllowed
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 674029, RefRangeEnd = 674037, XrefRangeStart = 674028, XrefRangeEnd = 674029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0007E504 File Offset: 0x0007C704
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 674054, RefRangeEnd = 674056, XrefRangeStart = 674037, XrefRangeEnd = 674054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autocorrection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alert;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr3) : null;
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0007E5B0 File Offset: 0x0007C7B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 674075, RefRangeEnd = 674076, XrefRangeStart = 674056, XrefRangeEnd = 674075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autocorrection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr3) : null;
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x0007E62C File Offset: 0x0007C82C
		// (set) Token: 0x06001B97 RID: 7063 RVA: 0x0007E664 File Offset: 0x0007C864
		public unsafe string text
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 674078, RefRangeEnd = 674085, XrefRangeStart = 674076, XrefRangeEnd = 674078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 674087, RefRangeEnd = 674096, XrefRangeStart = 674085, XrefRangeEnd = 674087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x0000AB82 File Offset: 0x00008D82
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x0007E6A8 File Offset: 0x0007C8A8
		public unsafe static bool hideInput
		{
			get
			{
				return TouchScreenKeyboard.get_hideInputDelegateField();
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 674098, RefRangeEnd = 674102, XrefRangeStart = 674096, XrefRangeEnd = 674098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0007E6DC File Offset: 0x0007C8DC
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x0007E718 File Offset: 0x0007C918
		public unsafe bool active
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 674104, RefRangeEnd = 674109, XrefRangeStart = 674102, XrefRangeEnd = 674104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 674111, RefRangeEnd = 674117, XrefRangeStart = 674109, XrefRangeEnd = 674111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0007E758 File Offset: 0x0007C958
		public unsafe TouchScreenKeyboard.Status status
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 674119, RefRangeEnd = 674122, XrefRangeStart = 674117, XrefRangeEnd = 674119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_status_Public_get_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0007E794 File Offset: 0x0007C994
		public unsafe int characterLimit
		{
			get
			{
				return TouchScreenKeyboard.get_characterLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 674124, RefRangeEnd = 674126, XrefRangeStart = 674122, XrefRangeEnd = 674124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x0007E7D4 File Offset: 0x0007C9D4
		public unsafe bool canGetSelection
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 674128, RefRangeEnd = 674129, XrefRangeStart = 674126, XrefRangeEnd = 674128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x0007E810 File Offset: 0x0007CA10
		public unsafe bool canSetSelection
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 674131, RefRangeEnd = 674133, XrefRangeStart = 674129, XrefRangeEnd = 674131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x0007E84C File Offset: 0x0007CA4C
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x0007E888 File Offset: 0x0007CA88
		public unsafe RangeInt selection
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 674135, RefRangeEnd = 674138, XrefRangeStart = 674133, XrefRangeEnd = 674135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 674150, RefRangeEnd = 674159, XrefRangeStart = 674138, XrefRangeEnd = 674150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0007E8C8 File Offset: 0x0007CAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 674159, XrefRangeEnd = 674161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSelection(out int start, out int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0007E908 File Offset: 0x0007CB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 674161, XrefRangeEnd = 674163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSelection(int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x0007E948 File Offset: 0x0007CB48
		public unsafe static bool visible
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 674165, RefRangeEnd = 674167, XrefRangeStart = 674163, XrefRangeEnd = 674165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_visible_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0000AB3C File Offset: 0x00008D3C
		public TouchScreenKeyboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x0007E978 File Offset: 0x0007CB78
		// (set) Token: 0x06001BA6 RID: 7078 RVA: 0x0000AB45 File Offset: 0x00008D45
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x0007E9A0 File Offset: 0x0007CBA0
		// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x0000AB60 File Offset: 0x00008D60
		public unsafe static bool _disableInPlaceEditing_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TouchScreenKeyboard.NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchScreenKeyboard.NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x0007E9BC File Offset: 0x0007CBBC
		public static bool isRequiredToForceOpen
		{
			get
			{
				return TouchScreenKeyboard.IsRequiredToForceOpen();
			}
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0000AB76 File Offset: 0x00008D76
		public static bool IsRequiredToForceOpen()
		{
			return TouchScreenKeyboard.IsRequiredToForceOpenDelegateField();
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0007E9D4 File Offset: 0x0007CBD4
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder)
		{
			int num = 0;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, num);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0007E9F8 File Offset: 0x0007CBF8
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert)
		{
			int num = 0;
			string text2 = "";
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, text2, num);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0007EA24 File Offset: 0x0007CC24
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, flag2, flag, text2, num);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0007EA54 File Offset: 0x0007CC54
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, flag3, flag2, flag, text2, num);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0007EA88 File Offset: 0x0007CC88
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = true;
			return TouchScreenKeyboard.Open(text, keyboardType, flag4, flag3, flag2, flag, text2, num);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0007EAC0 File Offset: 0x0007CCC0
		public static TouchScreenKeyboard Open(string text)
		{
			int num = 0;
			string text2 = "";
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = true;
			TouchScreenKeyboardType touchScreenKeyboardType = TouchScreenKeyboardType.Default;
			return TouchScreenKeyboard.Open(text, touchScreenKeyboardType, flag4, flag3, flag2, flag, text2, num);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0000AB8E File Offset: 0x00008D8E
		public static bool GetDone(IntPtr ptr)
		{
			return TouchScreenKeyboard.GetDoneDelegateField(ptr);
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x0007EAFC File Offset: 0x0007CCFC
		public bool done
		{
			get
			{
				return TouchScreenKeyboard.GetDone(this.m_Ptr);
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0000AB9B File Offset: 0x00008D9B
		public static bool GetWasCanceled(IntPtr ptr)
		{
			return TouchScreenKeyboard.GetWasCanceledDelegateField(ptr);
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x0007EB1C File Offset: 0x0007CD1C
		public bool wasCanceled
		{
			get
			{
				return TouchScreenKeyboard.GetWasCanceled(this.m_Ptr);
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x0000ABBA File Offset: 0x00008DBA
		public TouchScreenKeyboardType type
		{
			get
			{
				return TouchScreenKeyboard.get_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x0007EB3C File Offset: 0x0007CD3C
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x0000ABCC File Offset: 0x00008DCC
		public int targetDisplay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x0007EB50 File Offset: 0x0007CD50
		public static Rect area
		{
			get
			{
				Rect rect;
				TouchScreenKeyboard.get_area_Injected(out rect);
				return rect;
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0000ABCF File Offset: 0x00008DCF
		public static void get_area_Injected(out Rect ret)
		{
			TouchScreenKeyboard.get_area_InjectedDelegateField(out ret);
		}

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeMethodInfoPtr_get_disableInPlaceEditing_Internal_Static_get_Boolean_0;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_0;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeMethodInfoPtr_get_status_Public_get_Status_0;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeMethodInfoPtr_get_visible_Public_Static_get_Boolean_0;

		// Token: 0x04001857 RID: 6231
		private static readonly TouchScreenKeyboard.IsRequiredToForceOpenDelegate IsRequiredToForceOpenDelegateField;

		// Token: 0x04001858 RID: 6232
		private static readonly TouchScreenKeyboard.get_hideInputDelegate get_hideInputDelegateField;

		// Token: 0x04001859 RID: 6233
		private static readonly TouchScreenKeyboard.GetDoneDelegate GetDoneDelegateField;

		// Token: 0x0400185A RID: 6234
		private static readonly TouchScreenKeyboard.GetWasCanceledDelegate GetWasCanceledDelegateField;

		// Token: 0x0400185B RID: 6235
		private static readonly TouchScreenKeyboard.get_characterLimitDelegate get_characterLimitDelegateField;

		// Token: 0x0400185C RID: 6236
		private static readonly TouchScreenKeyboard.get_typeDelegate get_typeDelegateField;

		// Token: 0x0400185D RID: 6237
		private static readonly TouchScreenKeyboard.get_area_InjectedDelegate get_area_InjectedDelegateField;

		// Token: 0x020007F3 RID: 2035
		public enum Status
		{
			// Token: 0x04002CA3 RID: 11427
			Visible,
			// Token: 0x04002CA4 RID: 11428
			Done,
			// Token: 0x04002CA5 RID: 11429
			Canceled,
			// Token: 0x04002CA6 RID: 11430
			LostFocus
		}

		// Token: 0x020007F4 RID: 2036
		public class Android
		{
		}

		// Token: 0x020007F5 RID: 2037
		// (Invoke) Token: 0x06003893 RID: 14483
		private delegate bool IsRequiredToForceOpenDelegate();

		// Token: 0x020007F6 RID: 2038
		// (Invoke) Token: 0x06003895 RID: 14485
		private delegate bool get_hideInputDelegate();

		// Token: 0x020007F7 RID: 2039
		// (Invoke) Token: 0x06003897 RID: 14487
		private delegate bool GetDoneDelegate(IntPtr ptr);

		// Token: 0x020007F8 RID: 2040
		// (Invoke) Token: 0x06003899 RID: 14489
		private delegate bool GetWasCanceledDelegate(IntPtr ptr);

		// Token: 0x020007F9 RID: 2041
		// (Invoke) Token: 0x0600389B RID: 14491
		private delegate int get_characterLimitDelegate(IntPtr @this);

		// Token: 0x020007FA RID: 2042
		// (Invoke) Token: 0x0600389D RID: 14493
		private delegate TouchScreenKeyboardType get_typeDelegate(IntPtr @this);

		// Token: 0x020007FB RID: 2043
		// (Invoke) Token: 0x0600389F RID: 14495
		private delegate void get_area_InjectedDelegate([Out] IntPtr ret);
	}
}
