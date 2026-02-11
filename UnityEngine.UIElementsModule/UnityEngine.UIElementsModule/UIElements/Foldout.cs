using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005B RID: 91
	public class Foldout : BindableElement
	{
		// Token: 0x0600083B RID: 2107 RVA: 0x0003A614 File Offset: 0x00038814
		// Note: this type is marked as 'beforefieldinit'.
		static Foldout()
		{
			Il2CppClassPointerStore<Foldout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Foldout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Foldout>.NativeClassPtr);
			Foldout.NativeFieldInfoPtr_m_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "m_Toggle");
			Foldout.NativeFieldInfoPtr_m_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "m_Container");
			Foldout.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "m_Value");
			Foldout.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "ussClassName");
			Foldout.NativeFieldInfoPtr_toggleUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "toggleUssClassName");
			Foldout.NativeFieldInfoPtr_contentUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "contentUssClassName");
			Foldout.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "inputUssClassName");
			Foldout.NativeFieldInfoPtr_checkmarkUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "checkmarkUssClassName");
			Foldout.NativeFieldInfoPtr_textUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "textUssClassName");
			Foldout.NativeFieldInfoPtr_toggleInspectorUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "toggleInspectorUssClassName");
			Foldout.NativeFieldInfoPtr_ussFoldoutDepthClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "ussFoldoutDepthClassName");
			Foldout.NativeFieldInfoPtr_ussFoldoutMaxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "ussFoldoutMaxDepth");
			Foldout.NativeFieldInfoPtr_m_NavigationManipulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "m_NavigationManipulator");
			Foldout.NativeMethodInfoPtr_get_toggle_Internal_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout>.NativeClassPtr, 100664500);
			Foldout.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout>.NativeClassPtr, 100664501);
			Foldout.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout>.NativeClassPtr, 100664502);
			Foldout.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout>.NativeClassPtr, 100664503);
			Foldout.NativeMethodInfoPtr_set_value_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout>.NativeClassPtr, 100664504);
			Foldout.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout>.NativeClassPtr, 100664505);
			Foldout.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout>.NativeClassPtr, 100664506);
			Foldout.NativeMethodInfoPtr_Apply_Private_Void_KeyboardNavigationOperation_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout>.NativeClassPtr, 100664507);
			Foldout.NativeMethodInfoPtr_Apply_Private_Boolean_KeyboardNavigationOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout>.NativeClassPtr, 100664508);
			Foldout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout>.NativeClassPtr, 100664509);
			Foldout.NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout>.NativeClassPtr, 100664510);
			Foldout.NativeMethodInfoPtr___ctor_b__29_0_Private_Void_ChangeEvent_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout>.NativeClassPtr, 100664512);
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x0003A838 File Offset: 0x00038A38
		public unsafe Toggle toggle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Foldout.NativeMethodInfoPtr_get_toggle_Internal_get_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr3) : null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0003A878 File Offset: 0x00038A78
		public unsafe override VisualElement contentContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Foldout.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00004ED4 File Offset: 0x000030D4
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x0003A8C4 File Offset: 0x00038AC4
		public unsafe string text
		{
			get
			{
				return this.m_Toggle.text;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 294246, RefRangeEnd = 294248, XrefRangeStart = 294229, XrefRangeEnd = 294246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Foldout.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0003A908 File Offset: 0x00038B08
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x0003A944 File Offset: 0x00038B44
		public unsafe virtual bool value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Foldout.NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 294263, RefRangeEnd = 294265, XrefRangeStart = 294248, XrefRangeEnd = 294263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Foldout.NativeMethodInfoPtr_set_value_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0003A984 File Offset: 0x00038B84
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 294274, RefRangeEnd = 294280, XrefRangeStart = 294265, XrefRangeEnd = 294274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValueWithoutNotify(bool newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Foldout.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0003A9C4 File Offset: 0x00038BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294280, XrefRangeEnd = 294284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewDataReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Foldout.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0003AA00 File Offset: 0x00038C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294284, XrefRangeEnd = 294287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Foldout.NativeMethodInfoPtr_Apply_Private_Void_KeyboardNavigationOperation_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0003AA50 File Offset: 0x00038C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294287, XrefRangeEnd = 294288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Apply(KeyboardNavigationOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Foldout.NativeMethodInfoPtr_Apply_Private_Boolean_KeyboardNavigationOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0003AA9C File Offset: 0x00038C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294361, RefRangeEnd = 294362, XrefRangeStart = 294288, XrefRangeEnd = 294361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Foldout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Foldout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Foldout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0003AAD8 File Offset: 0x00038CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294362, XrefRangeEnd = 294394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAttachToPanel(AttachToPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Foldout.NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0003AB1C File Offset: 0x00038D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294394, XrefRangeEnd = 294454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__29_0(ChangeEvent<bool> evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Foldout.NativeMethodInfoPtr___ctor_b__29_0_Private_Void_ChangeEvent_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00004DB5 File Offset: 0x00002FB5
		public Foldout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0003AB60 File Offset: 0x00038D60
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00004DBE File Offset: 0x00002FBE
		public unsafe Toggle m_Toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Foldout.NativeFieldInfoPtr_m_Toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Foldout.NativeFieldInfoPtr_m_Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0003AB90 File Offset: 0x00038D90
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00004DDD File Offset: 0x00002FDD
		public unsafe VisualElement m_Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Foldout.NativeFieldInfoPtr_m_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Foldout.NativeFieldInfoPtr_m_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0003ABC0 File Offset: 0x00038DC0
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00004DFC File Offset: 0x00002FFC
		public unsafe bool m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Foldout.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Foldout.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0003ABE8 File Offset: 0x00038DE8
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00004E17 File Offset: 0x00003017
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0003AC08 File Offset: 0x00038E08
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00004E29 File Offset: 0x00003029
		public unsafe static string toggleUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_toggleUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_toggleUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x0003AC28 File Offset: 0x00038E28
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00004E3B File Offset: 0x0000303B
		public unsafe static string contentUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_contentUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_contentUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0003AC48 File Offset: 0x00038E48
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00004E4D File Offset: 0x0000304D
		public unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0003AC68 File Offset: 0x00038E68
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00004E5F File Offset: 0x0000305F
		public unsafe static string checkmarkUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_checkmarkUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_checkmarkUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0003AC88 File Offset: 0x00038E88
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00004E71 File Offset: 0x00003071
		public unsafe static string textUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_textUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_textUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0003ACA8 File Offset: 0x00038EA8
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x00004E83 File Offset: 0x00003083
		public unsafe static string toggleInspectorUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_toggleInspectorUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_toggleInspectorUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0003ACC8 File Offset: 0x00038EC8
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00004E95 File Offset: 0x00003095
		public unsafe static string ussFoldoutDepthClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_ussFoldoutDepthClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_ussFoldoutDepthClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0003ACE8 File Offset: 0x00038EE8
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00004EA7 File Offset: 0x000030A7
		public unsafe static int ussFoldoutMaxDepth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Foldout.NativeFieldInfoPtr_ussFoldoutMaxDepth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Foldout.NativeFieldInfoPtr_ussFoldoutMaxDepth, (void*)(&value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0003AD04 File Offset: 0x00038F04
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00004EB5 File Offset: 0x000030B5
		public unsafe KeyboardNavigationManipulator m_NavigationManipulator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Foldout.NativeFieldInfoPtr_m_NavigationManipulator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyboardNavigationManipulator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Foldout.NativeFieldInfoPtr_m_NavigationManipulator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeFieldInfoPtr_m_Toggle;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeFieldInfoPtr_m_Container;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr_toggleUssClassName;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_contentUssClassName;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_checkmarkUssClassName;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr_textUssClassName;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr_toggleInspectorUssClassName;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeFieldInfoPtr_ussFoldoutDepthClassName;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeFieldInfoPtr_ussFoldoutMaxDepth;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeFieldInfoPtr_m_NavigationManipulator;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_get_toggle_Internal_get_Toggle_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Void_KeyboardNavigationOperation_EventBase_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Boolean_KeyboardNavigationOperation_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__29_0_Private_Void_ChangeEvent_1_Boolean_0;

		// Token: 0x02000374 RID: 884
		public new class UxmlFactory : UxmlFactory<Foldout, Foldout.UxmlTraits>
		{
			// Token: 0x060037A2 RID: 14242 RVA: 0x00016FF5 File Offset: 0x000151F5
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Foldout.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Foldout.UxmlFactory>.NativeClassPtr);
				Foldout.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout.UxmlFactory>.NativeClassPtr, 100664513);
			}

			// Token: 0x060037A3 RID: 14243 RVA: 0x000E4008 File Offset: 0x000E2208
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 294187, RefRangeEnd = 294188, XrefRangeStart = 294184, XrefRangeEnd = 294187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Foldout.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Foldout.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037A4 RID: 14244 RVA: 0x00017029 File Offset: 0x00015229
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040027A4 RID: 10148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000375 RID: 885
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x060037A5 RID: 14245 RVA: 0x000E4044 File Offset: 0x000E2244
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Foldout.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Foldout>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Foldout.UxmlTraits>.NativeClassPtr);
				Foldout.UxmlTraits.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout.UxmlTraits>.NativeClassPtr, "m_Text");
				Foldout.UxmlTraits.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Foldout.UxmlTraits>.NativeClassPtr, "m_Value");
				Foldout.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout.UxmlTraits>.NativeClassPtr, 100664514);
				Foldout.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Foldout.UxmlTraits>.NativeClassPtr, 100664515);
			}

			// Token: 0x060037A6 RID: 14246 RVA: 0x000E40C0 File Offset: 0x000E22C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294188, XrefRangeEnd = 294210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Foldout.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037A7 RID: 14247 RVA: 0x000E4138 File Offset: 0x000E2338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294210, XrefRangeEnd = 294229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Foldout.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Foldout.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037A8 RID: 14248 RVA: 0x00017032 File Offset: 0x00015232
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001130 RID: 4400
			// (get) Token: 0x060037A9 RID: 14249 RVA: 0x000E4174 File Offset: 0x000E2374
			// (set) Token: 0x060037AA RID: 14250 RVA: 0x0001703B File Offset: 0x0001523B
			public unsafe UxmlStringAttributeDescription m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Foldout.UxmlTraits.NativeFieldInfoPtr_m_Text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Foldout.UxmlTraits.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001131 RID: 4401
			// (get) Token: 0x060037AB RID: 14251 RVA: 0x000E41A4 File Offset: 0x000E23A4
			// (set) Token: 0x060037AC RID: 14252 RVA: 0x0001705A File Offset: 0x0001525A
			public unsafe UxmlBoolAttributeDescription m_Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Foldout.UxmlTraits.NativeFieldInfoPtr_m_Value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Foldout.UxmlTraits.NativeFieldInfoPtr_m_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040027A5 RID: 10149
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x040027A6 RID: 10150
			private static readonly IntPtr NativeFieldInfoPtr_m_Value;

			// Token: 0x040027A7 RID: 10151
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040027A8 RID: 10152
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
