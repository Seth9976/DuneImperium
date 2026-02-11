using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x020001DD RID: 477
	public class ITextSelection : Il2CppObjectBase
	{
		// Token: 0x060025D4 RID: 9684 RVA: 0x000A8B68 File Offset: 0x000A6D68
		// Note: this type is marked as 'beforefieldinit'.
		static ITextSelection()
		{
			Il2CppClassPointerStore<ITextSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ITextSelection");
			ITextSelection.NativeMethodInfoPtr_get_isSelectable_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669019);
			ITextSelection.NativeMethodInfoPtr_set_isSelectable_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669020);
			ITextSelection.NativeMethodInfoPtr_get_cursorColor_Public_Abstract_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669021);
			ITextSelection.NativeMethodInfoPtr_set_cursorColor_Public_Abstract_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669022);
			ITextSelection.NativeMethodInfoPtr_get_cursorIndex_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669023);
			ITextSelection.NativeMethodInfoPtr_set_cursorIndex_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669024);
			ITextSelection.NativeMethodInfoPtr_get_doubleClickSelectsWord_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669025);
			ITextSelection.NativeMethodInfoPtr_get_selectIndex_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669026);
			ITextSelection.NativeMethodInfoPtr_set_selectIndex_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669027);
			ITextSelection.NativeMethodInfoPtr_get_selectionColor_Public_Abstract_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669028);
			ITextSelection.NativeMethodInfoPtr_set_selectionColor_Public_Abstract_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669029);
			ITextSelection.NativeMethodInfoPtr_get_tripleClickSelectsLine_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669030);
			ITextSelection.NativeMethodInfoPtr_HasSelection_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669031);
			ITextSelection.NativeMethodInfoPtr_SelectAll_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669032);
			ITextSelection.NativeMethodInfoPtr_SelectNone_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669033);
			ITextSelection.NativeMethodInfoPtr_get_selectAllOnFocus_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669034);
			ITextSelection.NativeMethodInfoPtr_set_selectAllOnFocus_Internal_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669035);
			ITextSelection.NativeMethodInfoPtr_get_selectAllOnMouseUp_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669036);
			ITextSelection.NativeMethodInfoPtr_set_selectAllOnMouseUp_Internal_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669037);
			ITextSelection.NativeMethodInfoPtr_get_cursorPosition_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669038);
			ITextSelection.NativeMethodInfoPtr_get_lineHeightAtCursorPosition_Internal_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669039);
			ITextSelection.NativeMethodInfoPtr_get_cursorWidth_Internal_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextSelection>.NativeClassPtr, 100669040);
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x060025D5 RID: 9685 RVA: 0x000A8D48 File Offset: 0x000A6F48
		// (set) Token: 0x060025D6 RID: 9686 RVA: 0x000A8D90 File Offset: 0x000A6F90
		public unsafe virtual bool isSelectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_get_isSelectable_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_set_isSelectable_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x000A8DDC File Offset: 0x000A6FDC
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x000A8E24 File Offset: 0x000A7024
		public unsafe virtual Color cursorColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_get_cursorColor_Public_Abstract_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_set_cursorColor_Public_Abstract_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x000A8E70 File Offset: 0x000A7070
		// (set) Token: 0x060025DA RID: 9690 RVA: 0x000A8EB8 File Offset: 0x000A70B8
		public unsafe virtual int cursorIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_get_cursorIndex_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_set_cursorIndex_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x060025DB RID: 9691 RVA: 0x000A8F04 File Offset: 0x000A7104
		public unsafe virtual bool doubleClickSelectsWord
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_get_doubleClickSelectsWord_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x000A8F4C File Offset: 0x000A714C
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x000A8F94 File Offset: 0x000A7194
		public unsafe virtual int selectIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_get_selectIndex_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_set_selectIndex_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x000A8FE0 File Offset: 0x000A71E0
		// (set) Token: 0x060025DF RID: 9695 RVA: 0x000A9028 File Offset: 0x000A7228
		public unsafe virtual Color selectionColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_get_selectionColor_Public_Abstract_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_set_selectionColor_Public_Abstract_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000A9074 File Offset: 0x000A7274
		public unsafe virtual bool tripleClickSelectsLine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_get_tripleClickSelectsLine_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x000A90BC File Offset: 0x000A72BC
		[CallerCount(0)]
		public unsafe virtual bool HasSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_HasSelection_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x000A9104 File Offset: 0x000A7304
		[CallerCount(0)]
		public unsafe virtual void SelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_SelectAll_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x000A9140 File Offset: 0x000A7340
		[CallerCount(0)]
		public unsafe virtual void SelectNone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_SelectNone_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x000A917C File Offset: 0x000A737C
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x000A91C4 File Offset: 0x000A73C4
		public unsafe virtual bool selectAllOnFocus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_get_selectAllOnFocus_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_set_selectAllOnFocus_Internal_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x000A9210 File Offset: 0x000A7410
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x000A9258 File Offset: 0x000A7458
		public unsafe virtual bool selectAllOnMouseUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_get_selectAllOnMouseUp_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_set_selectAllOnMouseUp_Internal_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x000A92A4 File Offset: 0x000A74A4
		public unsafe virtual Vector2 cursorPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_get_cursorPosition_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x000A92EC File Offset: 0x000A74EC
		public unsafe virtual float lineHeightAtCursorPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_get_lineHeightAtCursorPosition_Internal_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x000A9334 File Offset: 0x000A7534
		public unsafe virtual float cursorWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextSelection.NativeMethodInfoPtr_get_cursorWidth_Internal_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x0000F790 File Offset: 0x0000D990
		public ITextSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B38 RID: 6968
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelectable_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeMethodInfoPtr_set_isSelectable_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeMethodInfoPtr_get_cursorColor_Public_Abstract_Virtual_New_get_Color_0;

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeMethodInfoPtr_set_cursorColor_Public_Abstract_Virtual_New_set_Void_Color_0;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeMethodInfoPtr_get_cursorIndex_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeMethodInfoPtr_set_cursorIndex_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeMethodInfoPtr_get_doubleClickSelectsWord_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeMethodInfoPtr_get_selectIndex_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeMethodInfoPtr_set_selectIndex_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionColor_Public_Abstract_Virtual_New_get_Color_0;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionColor_Public_Abstract_Virtual_New_set_Void_Color_0;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeMethodInfoPtr_get_tripleClickSelectsLine_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeMethodInfoPtr_HasSelection_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeMethodInfoPtr_SelectAll_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeMethodInfoPtr_SelectNone_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeMethodInfoPtr_get_selectAllOnFocus_Internal_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeMethodInfoPtr_set_selectAllOnFocus_Internal_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeMethodInfoPtr_get_selectAllOnMouseUp_Internal_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeMethodInfoPtr_set_selectAllOnMouseUp_Internal_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeMethodInfoPtr_get_cursorPosition_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeMethodInfoPtr_get_lineHeightAtCursorPosition_Internal_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeMethodInfoPtr_get_cursorWidth_Internal_Abstract_Virtual_New_get_Single_0;
	}
}
