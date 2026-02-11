using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000059 RID: 89
	public class EnumField : BaseField<Enum>
	{
		// Token: 0x06000800 RID: 2048 RVA: 0x0003996C File Offset: 0x00037B6C
		// Note: this type is marked as 'beforefieldinit'.
		static EnumField()
		{
			Il2CppClassPointerStore<EnumField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EnumField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumField>.NativeClassPtr);
			EnumField.NativeFieldInfoPtr_m_EnumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "m_EnumType");
			EnumField.NativeFieldInfoPtr_m_IncludeObsoleteValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "m_IncludeObsoleteValues");
			EnumField.NativeFieldInfoPtr_m_TextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "m_TextElement");
			EnumField.NativeFieldInfoPtr_m_ArrowElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "m_ArrowElement");
			EnumField.NativeFieldInfoPtr_m_EnumData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "m_EnumData");
			EnumField.NativeFieldInfoPtr_createMenuCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "createMenuCallback");
			EnumField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "ussClassName");
			EnumField.NativeFieldInfoPtr_textUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "textUssClassName");
			EnumField.NativeFieldInfoPtr_arrowUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "arrowUssClassName");
			EnumField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "labelUssClassName");
			EnumField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "inputUssClassName");
			EnumField.NativeMethodInfoPtr_get_includeObsoleteValues_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664459);
			EnumField.NativeMethodInfoPtr_Initialize_Private_Void_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664460);
			EnumField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664461);
			EnumField.NativeMethodInfoPtr__ctor_Public_Void_String_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664462);
			EnumField.NativeMethodInfoPtr_Init_Public_Void_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664463);
			EnumField.NativeMethodInfoPtr_Init_Public_Void_Enum_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664464);
			EnumField.NativeMethodInfoPtr_PopulateDataFromType_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664465);
			EnumField.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664466);
			EnumField.NativeMethodInfoPtr_UpdateValueLabel_Private_Void_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664467);
			EnumField.NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664468);
			EnumField.NativeMethodInfoPtr_OnPointerMoveEvent_Private_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664469);
			EnumField.NativeMethodInfoPtr_ContainsPointer_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664470);
			EnumField.NativeMethodInfoPtr_ProcessPointerDown_Private_Void_PointerEventBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664471);
			EnumField.NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664472);
			EnumField.NativeMethodInfoPtr_ShowMenu_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664473);
			EnumField.NativeMethodInfoPtr_ChangeValueFromMenu_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664474);
			EnumField.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664475);
			EnumField.NativeMethodInfoPtr__ShowMenu_b__33_0_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField>.NativeClassPtr, 100664477);
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00039BE0 File Offset: 0x00037DE0
		public unsafe bool includeObsoleteValues
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr_get_includeObsoleteValues_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00039C1C File Offset: 0x00037E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293825, XrefRangeEnd = 293852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Enum defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defaultValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr_Initialize_Private_Void_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00039C5C File Offset: 0x00037E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293852, XrefRangeEnd = 293853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00039C98 File Offset: 0x00037E98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293945, RefRangeEnd = 293946, XrefRangeStart = 293853, XrefRangeEnd = 293945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumField(string label, Enum defaultValue = default(Enum))
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumField>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr__ctor_Public_Void_String_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00039CF4 File Offset: 0x00037EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293946, XrefRangeEnd = 293947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Enum defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defaultValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr_Init_Public_Void_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00039D34 File Offset: 0x00037F34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293954, RefRangeEnd = 293957, XrefRangeStart = 293947, XrefRangeEnd = 293954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Enum defaultValue, bool includeObsoleteValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defaultValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeObsoleteValues;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr_Init_Public_Void_Enum_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00039D80 File Offset: 0x00037F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293963, RefRangeEnd = 293964, XrefRangeStart = 293957, XrefRangeEnd = 293963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateDataFromType(Type enumType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr_PopulateDataFromType_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00039DC4 File Offset: 0x00037FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293964, XrefRangeEnd = 293976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(Enum newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumField.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Enum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00039E10 File Offset: 0x00038010
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293981, RefRangeEnd = 293984, XrefRangeStart = 293976, XrefRangeEnd = 293981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueLabel(Enum value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr_UpdateValueLabel_Private_Void_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00039E50 File Offset: 0x00038050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293984, XrefRangeEnd = 293987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDownEvent(PointerDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00039E94 File Offset: 0x00038094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293987, XrefRangeEnd = 293992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerMoveEvent(PointerMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr_OnPointerMoveEvent_Private_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00039ED8 File Offset: 0x000380D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293994, RefRangeEnd = 293995, XrefRangeStart = 293992, XrefRangeEnd = 293994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPointer(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr_ContainsPointer_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00039F24 File Offset: 0x00038124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293999, RefRangeEnd = 294001, XrefRangeStart = 293995, XrefRangeEnd = 293999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPointerDown<T>(PointerEventBase<T> evt) where T : PointerEventBase<T>, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.MethodInfoStoreGeneric_ProcessPointerDown_Private_Void_PointerEventBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00039F68 File Offset: 0x00038168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294001, XrefRangeEnd = 294004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00039FAC File Offset: 0x000381AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294029, RefRangeEnd = 294031, XrefRangeStart = 294004, XrefRangeEnd = 294029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr_ShowMenu_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00039FE0 File Offset: 0x000381E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294031, XrefRangeEnd = 294035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeValueFromMenu(Object menuItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(menuItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr_ChangeValueFromMenu_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0003A024 File Offset: 0x00038224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294035, XrefRangeEnd = 294052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMixedValueContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumField.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0003A060 File Offset: 0x00038260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ShowMenu_b__33_0(Object contentView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contentView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.NativeMethodInfoPtr__ShowMenu_b__33_0_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00004C46 File Offset: 0x00002E46
		public EnumField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0003A0A4 File Offset: 0x000382A4
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00004C4F File Offset: 0x00002E4F
		public unsafe Type m_EnumType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.NativeFieldInfoPtr_m_EnumType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.NativeFieldInfoPtr_m_EnumType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x0003A0D4 File Offset: 0x000382D4
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00004C6E File Offset: 0x00002E6E
		public unsafe bool m_IncludeObsoleteValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.NativeFieldInfoPtr_m_IncludeObsoleteValues);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.NativeFieldInfoPtr_m_IncludeObsoleteValues)) = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x0003A0FC File Offset: 0x000382FC
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00004C89 File Offset: 0x00002E89
		public unsafe TextElement m_TextElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.NativeFieldInfoPtr_m_TextElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.NativeFieldInfoPtr_m_TextElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x0003A12C File Offset: 0x0003832C
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00004CA8 File Offset: 0x00002EA8
		public unsafe VisualElement m_ArrowElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.NativeFieldInfoPtr_m_ArrowElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.NativeFieldInfoPtr_m_ArrowElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x0003A15C File Offset: 0x0003835C
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x00004CC7 File Offset: 0x00002EC7
		public EnumData m_EnumData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.NativeFieldInfoPtr_m_EnumData);
				return new EnumData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EnumData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.NativeFieldInfoPtr_m_EnumData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EnumData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x0003A18C File Offset: 0x0003838C
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00004CF5 File Offset: 0x00002EF5
		public unsafe Func<IGenericMenu> createMenuCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.NativeFieldInfoPtr_createMenuCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGenericMenu>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.NativeFieldInfoPtr_createMenuCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0003A1BC File Offset: 0x000383BC
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00004D14 File Offset: 0x00002F14
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x0003A1DC File Offset: 0x000383DC
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x00004D26 File Offset: 0x00002F26
		public unsafe static string textUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumField.NativeFieldInfoPtr_textUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumField.NativeFieldInfoPtr_textUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0003A1FC File Offset: 0x000383FC
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x00004D38 File Offset: 0x00002F38
		public unsafe static string arrowUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumField.NativeFieldInfoPtr_arrowUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumField.NativeFieldInfoPtr_arrowUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x0003A21C File Offset: 0x0003841C
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x00004D4A File Offset: 0x00002F4A
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0003A23C File Offset: 0x0003843C
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x00004D5C File Offset: 0x00002F5C
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00004D6E File Offset: 0x00002F6E
		public Type type
		{
			get
			{
				return this.m_EnumType;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x0003A25C File Offset: 0x0003845C
		public string text
		{
			get
			{
				return this.m_TextElement.text;
			}
		}

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_m_EnumType;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_m_IncludeObsoleteValues;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_m_TextElement;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeFieldInfoPtr_m_ArrowElement;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeFieldInfoPtr_m_EnumData;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeFieldInfoPtr_createMenuCallback;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeFieldInfoPtr_textUssClassName;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeFieldInfoPtr_arrowUssClassName;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_get_includeObsoleteValues_Internal_get_Boolean_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Enum_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Enum_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Enum_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Enum_Boolean_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_PopulateDataFromType_Internal_Void_Type_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Enum_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueLabel_Private_Void_Enum_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_PointerDownEvent_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMoveEvent_Private_Void_PointerMoveEvent_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPointer_Private_Boolean_Int32_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPointerDown_Private_Void_PointerEventBase_1_T_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_ShowMenu_Internal_Void_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValueFromMenu_Private_Void_Object_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr__ShowMenu_b__33_0_Private_Void_Object_0;

		// Token: 0x0200036C RID: 876
		public new class UxmlFactory : UxmlFactory<EnumField, EnumField.UxmlTraits>
		{
			// Token: 0x0600377E RID: 14206 RVA: 0x00016EA2 File Offset: 0x000150A2
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<EnumField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumField.UxmlFactory>.NativeClassPtr);
				EnumField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField.UxmlFactory>.NativeClassPtr, 100664478);
			}

			// Token: 0x0600377F RID: 14207 RVA: 0x000E396C File Offset: 0x000E1B6C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 293796, RefRangeEnd = 293797, XrefRangeStart = 293793, XrefRangeEnd = 293796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003780 RID: 14208 RVA: 0x00016ED6 File Offset: 0x000150D6
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002791 RID: 10129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200036D RID: 877
		public new class UxmlTraits : BaseField<Enum>.UxmlTraits
		{
			// Token: 0x06003781 RID: 14209 RVA: 0x000E39A8 File Offset: 0x000E1BA8
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<EnumField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumField.UxmlTraits>.NativeClassPtr);
				EnumField.UxmlTraits.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField.UxmlTraits>.NativeClassPtr, "m_Type");
				EnumField.UxmlTraits.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField.UxmlTraits>.NativeClassPtr, "m_Value");
				EnumField.UxmlTraits.NativeFieldInfoPtr_m_IncludeObsoleteValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField.UxmlTraits>.NativeClassPtr, "m_IncludeObsoleteValues");
				EnumField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField.UxmlTraits>.NativeClassPtr, 100664479);
				EnumField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField.UxmlTraits>.NativeClassPtr, 100664480);
			}

			// Token: 0x06003782 RID: 14210 RVA: 0x000E3A38 File Offset: 0x000E1C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293797, XrefRangeEnd = 293811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003783 RID: 14211 RVA: 0x000E3AB0 File Offset: 0x000E1CB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293811, XrefRangeEnd = 293823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003784 RID: 14212 RVA: 0x00016EDF File Offset: 0x000150DF
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001129 RID: 4393
			// (get) Token: 0x06003785 RID: 14213 RVA: 0x000E3AEC File Offset: 0x000E1CEC
			// (set) Token: 0x06003786 RID: 14214 RVA: 0x00016EE8 File Offset: 0x000150E8
			public unsafe UxmlTypeAttributeDescription<Enum> m_Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.UxmlTraits.NativeFieldInfoPtr_m_Type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlTypeAttributeDescription<Enum>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.UxmlTraits.NativeFieldInfoPtr_m_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700112A RID: 4394
			// (get) Token: 0x06003787 RID: 14215 RVA: 0x000E3B1C File Offset: 0x000E1D1C
			// (set) Token: 0x06003788 RID: 14216 RVA: 0x00016F07 File Offset: 0x00015107
			public unsafe UxmlStringAttributeDescription m_Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.UxmlTraits.NativeFieldInfoPtr_m_Value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.UxmlTraits.NativeFieldInfoPtr_m_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700112B RID: 4395
			// (get) Token: 0x06003789 RID: 14217 RVA: 0x000E3B4C File Offset: 0x000E1D4C
			// (set) Token: 0x0600378A RID: 14218 RVA: 0x00016F26 File Offset: 0x00015126
			public unsafe UxmlBoolAttributeDescription m_IncludeObsoleteValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.UxmlTraits.NativeFieldInfoPtr_m_IncludeObsoleteValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumField.UxmlTraits.NativeFieldInfoPtr_m_IncludeObsoleteValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002792 RID: 10130
			private static readonly IntPtr NativeFieldInfoPtr_m_Type;

			// Token: 0x04002793 RID: 10131
			private static readonly IntPtr NativeFieldInfoPtr_m_Value;

			// Token: 0x04002794 RID: 10132
			private static readonly IntPtr NativeFieldInfoPtr_m_IncludeObsoleteValues;

			// Token: 0x04002795 RID: 10133
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002796 RID: 10134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200036E RID: 878
		[ObfuscatedName("UnityEngine.UIElements.EnumField+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600378B RID: 14219 RVA: 0x000E3B7C File Offset: 0x000E1D7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EnumField.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumField>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumField.__c>.NativeClassPtr);
				EnumField.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField.__c>.NativeClassPtr, "<>9");
				EnumField.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumField.__c>.NativeClassPtr, "<>9__22_0");
				EnumField.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField.__c>.NativeClassPtr, 100664482);
				EnumField.__c.NativeMethodInfoPtr___ctor_b__22_0_Internal_Void_MouseDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumField.__c>.NativeClassPtr, 100664483);
			}

			// Token: 0x0600378C RID: 14220 RVA: 0x000E3BF8 File Offset: 0x000E1DF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumField.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600378D RID: 14221 RVA: 0x000E3C34 File Offset: 0x000E1E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293823, XrefRangeEnd = 293825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__22_0(MouseDownEvent e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumField.__c.NativeMethodInfoPtr___ctor_b__22_0_Internal_Void_MouseDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600378E RID: 14222 RVA: 0x00016F45 File Offset: 0x00015145
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700112C RID: 4396
			// (get) Token: 0x0600378F RID: 14223 RVA: 0x000E3C78 File Offset: 0x000E1E78
			// (set) Token: 0x06003790 RID: 14224 RVA: 0x00016F4E File Offset: 0x0001514E
			public unsafe static EnumField.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumField.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumField.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumField.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700112D RID: 4397
			// (get) Token: 0x06003791 RID: 14225 RVA: 0x000E3CA0 File Offset: 0x000E1EA0
			// (set) Token: 0x06003792 RID: 14226 RVA: 0x00016F60 File Offset: 0x00015160
			public unsafe static EventCallback<MouseDownEvent> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumField.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<MouseDownEvent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumField.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002797 RID: 10135
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002798 RID: 10136
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x04002799 RID: 10137
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400279A RID: 10138
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__22_0_Internal_Void_MouseDownEvent_0;
		}

		// Token: 0x0200036F RID: 879
		private sealed class MethodInfoStoreGeneric_ProcessPointerDown_Private_Void_PointerEventBase_1_T_0<T>
		{
			// Token: 0x0400279B RID: 10139
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumField.NativeMethodInfoPtr_ProcessPointerDown_Private_Void_PointerEventBase_1_T_0, Il2CppClassPointerStore<EnumField>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000370 RID: 880
		[Serializable]
		public new sealed class <>c
		{
		}
	}
}
