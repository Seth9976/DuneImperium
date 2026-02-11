using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000038 RID: 56
	public class ReusableTreeViewItem : ReusableCollectionItem
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x0002D390 File Offset: 0x0002B590
		// Note: this type is marked as 'beforefieldinit'.
		static ReusableTreeViewItem()
		{
			Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ReusableTreeViewItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr);
			ReusableTreeViewItem.NativeFieldInfoPtr_m_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, "m_Toggle");
			ReusableTreeViewItem.NativeFieldInfoPtr_m_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, "m_Container");
			ReusableTreeViewItem.NativeFieldInfoPtr_m_IndentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, "m_IndentElement");
			ReusableTreeViewItem.NativeFieldInfoPtr_m_BindableContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, "m_BindableContainer");
			ReusableTreeViewItem.NativeFieldInfoPtr_m_Checkmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, "m_Checkmark");
			ReusableTreeViewItem.NativeFieldInfoPtr_onPointerUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, "onPointerUp");
			ReusableTreeViewItem.NativeFieldInfoPtr_onToggleValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, "onToggleValueChanged");
			ReusableTreeViewItem.NativeFieldInfoPtr_m_Depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, "m_Depth");
			ReusableTreeViewItem.NativeFieldInfoPtr_m_IndentWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, "m_IndentWidth");
			ReusableTreeViewItem.NativeFieldInfoPtr_m_PointerUpCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, "m_PointerUpCallback");
			ReusableTreeViewItem.NativeFieldInfoPtr_m_ToggleValueChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, "m_ToggleValueChangedCallback");
			ReusableTreeViewItem.NativeFieldInfoPtr_m_ToggleGeometryChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, "m_ToggleGeometryChangedCallback");
			ReusableTreeViewItem.NativeMethodInfoPtr_get_rootElement_Public_Virtual_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663920);
			ReusableTreeViewItem.NativeMethodInfoPtr_add_onPointerUp_Public_add_Void_Action_1_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663921);
			ReusableTreeViewItem.NativeMethodInfoPtr_remove_onPointerUp_Public_rem_Void_Action_1_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663922);
			ReusableTreeViewItem.NativeMethodInfoPtr_add_onToggleValueChanged_Public_add_Void_Action_1_ChangeEvent_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663923);
			ReusableTreeViewItem.NativeMethodInfoPtr_remove_onToggleValueChanged_Public_rem_Void_Action_1_ChangeEvent_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663924);
			ReusableTreeViewItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663925);
			ReusableTreeViewItem.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663926);
			ReusableTreeViewItem.NativeMethodInfoPtr_InitExpandHierarchy_Protected_Void_VisualElement_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663927);
			ReusableTreeViewItem.NativeMethodInfoPtr_PreAttachElement_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663928);
			ReusableTreeViewItem.NativeMethodInfoPtr_DetachElement_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663929);
			ReusableTreeViewItem.NativeMethodInfoPtr_Indent_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663930);
			ReusableTreeViewItem.NativeMethodInfoPtr_SetExpandedWithoutNotify_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663931);
			ReusableTreeViewItem.NativeMethodInfoPtr_SetToggleVisibility_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663932);
			ReusableTreeViewItem.NativeMethodInfoPtr_OnToggleGeometryChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663933);
			ReusableTreeViewItem.NativeMethodInfoPtr_UpdateIndentLayout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663934);
			ReusableTreeViewItem.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663935);
			ReusableTreeViewItem.NativeMethodInfoPtr_OnToggleValueChanged_Private_Void_ChangeEvent_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr, 100663936);
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0002D604 File Offset: 0x0002B804
		public unsafe override VisualElement rootElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableTreeViewItem.NativeMethodInfoPtr_get_rootElement_Public_Virtual_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0002D650 File Offset: 0x0002B850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287525, XrefRangeEnd = 287530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onPointerUp(Action<PointerUpEvent> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr_add_onPointerUp_Public_add_Void_Action_1_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0002D694 File Offset: 0x0002B894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287530, XrefRangeEnd = 287535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onPointerUp(Action<PointerUpEvent> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr_remove_onPointerUp_Public_rem_Void_Action_1_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0002D6D8 File Offset: 0x0002B8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287535, XrefRangeEnd = 287540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onToggleValueChanged(Action<ChangeEvent<bool>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr_add_onToggleValueChanged_Public_add_Void_Action_1_ChangeEvent_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0002D71C File Offset: 0x0002B91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287540, XrefRangeEnd = 287545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onToggleValueChanged(Action<ChangeEvent<bool>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr_remove_onToggleValueChanged_Public_rem_Void_Action_1_ChangeEvent_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0002D760 File Offset: 0x0002B960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReusableTreeViewItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReusableTreeViewItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0002D79C File Offset: 0x0002B99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287545, XrefRangeEnd = 287559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(VisualElement item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableTreeViewItem.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0002D7EC File Offset: 0x0002B9EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287630, RefRangeEnd = 287632, XrefRangeStart = 287559, XrefRangeEnd = 287630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitExpandHierarchy(VisualElement root, VisualElement item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr_InitExpandHierarchy_Protected_Void_VisualElement_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0002D840 File Offset: 0x0002BA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287632, XrefRangeEnd = 287658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PreAttachElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableTreeViewItem.NativeMethodInfoPtr_PreAttachElement_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0002D87C File Offset: 0x0002BA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287658, XrefRangeEnd = 287684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DetachElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableTreeViewItem.NativeMethodInfoPtr_DetachElement_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0002D8B8 File Offset: 0x0002BAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287684, XrefRangeEnd = 287685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Indent(int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr_Indent_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0002D8F8 File Offset: 0x0002BAF8
		[CallerCount(0)]
		public unsafe void SetExpandedWithoutNotify(bool expanded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expanded;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr_SetExpandedWithoutNotify_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0002D938 File Offset: 0x0002BB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287685, XrefRangeEnd = 287686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToggleVisibility(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr_SetToggleVisibility_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0002D978 File Offset: 0x0002BB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287686, XrefRangeEnd = 287700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnToggleGeometryChanged(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr_OnToggleGeometryChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0002D9BC File Offset: 0x0002BBBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287712, RefRangeEnd = 287715, XrefRangeStart = 287700, XrefRangeEnd = 287712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIndentLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr_UpdateIndentLayout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
		[CallerCount(0)]
		public unsafe void OnPointerUp(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0002DA34 File Offset: 0x0002BC34
		[CallerCount(0)]
		public unsafe void OnToggleValueChanged(ChangeEvent<bool> evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableTreeViewItem.NativeMethodInfoPtr_OnToggleValueChanged_Private_Void_ChangeEvent_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000032D7 File Offset: 0x000014D7
		public ReusableTreeViewItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0002DA78 File Offset: 0x0002BC78
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x000032E0 File Offset: 0x000014E0
		public unsafe Toggle m_Toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_Toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0002DAA8 File Offset: 0x0002BCA8
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x000032FF File Offset: 0x000014FF
		public unsafe VisualElement m_Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0002DAD8 File Offset: 0x0002BCD8
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0000331E File Offset: 0x0000151E
		public unsafe VisualElement m_IndentElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_IndentElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_IndentElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0002DB08 File Offset: 0x0002BD08
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x0000333D File Offset: 0x0000153D
		public unsafe VisualElement m_BindableContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_BindableContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_BindableContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0002DB38 File Offset: 0x0002BD38
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x0000335C File Offset: 0x0000155C
		public unsafe VisualElement m_Checkmark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_Checkmark);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_Checkmark), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0002DB68 File Offset: 0x0002BD68
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x0000337B File Offset: 0x0000157B
		public unsafe Action<PointerUpEvent> onPointerUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_onPointerUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PointerUpEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_onPointerUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0002DB98 File Offset: 0x0002BD98
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x0000339A File Offset: 0x0000159A
		public unsafe Action<ChangeEvent<bool>> onToggleValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_onToggleValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ChangeEvent<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_onToggleValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0002DBC8 File Offset: 0x0002BDC8
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x000033B9 File Offset: 0x000015B9
		public unsafe int m_Depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_Depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_Depth)) = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0002DBF0 File Offset: 0x0002BDF0
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x000033D4 File Offset: 0x000015D4
		public unsafe float m_IndentWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_IndentWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_IndentWidth)) = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0002DC18 File Offset: 0x0002BE18
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x000033EF File Offset: 0x000015EF
		public unsafe EventCallback<PointerUpEvent> m_PointerUpCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_PointerUpCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<PointerUpEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_PointerUpCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0002DC48 File Offset: 0x0002BE48
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x0000340E File Offset: 0x0000160E
		public unsafe EventCallback<ChangeEvent<bool>> m_ToggleValueChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_ToggleValueChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<ChangeEvent<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_ToggleValueChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0002DC78 File Offset: 0x0002BE78
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x0000342D File Offset: 0x0000162D
		public unsafe EventCallback<GeometryChangedEvent> m_ToggleGeometryChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_ToggleGeometryChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<GeometryChangedEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableTreeViewItem.NativeFieldInfoPtr_m_ToggleGeometryChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0000344C File Offset: 0x0000164C
		public float indentWidth
		{
			get
			{
				return this.m_IndentWidth;
			}
		}

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeFieldInfoPtr_m_Toggle;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeFieldInfoPtr_m_Container;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeFieldInfoPtr_m_IndentElement;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeFieldInfoPtr_m_BindableContainer;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeFieldInfoPtr_m_Checkmark;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr_onPointerUp;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeFieldInfoPtr_onToggleValueChanged;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeFieldInfoPtr_m_Depth;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeFieldInfoPtr_m_IndentWidth;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerUpCallback;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeFieldInfoPtr_m_ToggleValueChangedCallback;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr_m_ToggleGeometryChangedCallback;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_get_rootElement_Public_Virtual_get_VisualElement_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_add_onPointerUp_Public_add_Void_Action_1_PointerUpEvent_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_remove_onPointerUp_Public_rem_Void_Action_1_PointerUpEvent_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_add_onToggleValueChanged_Public_add_Void_Action_1_ChangeEvent_1_Boolean_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_remove_onToggleValueChanged_Public_rem_Void_Action_1_ChangeEvent_1_Boolean_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_InitExpandHierarchy_Protected_Void_VisualElement_VisualElement_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_PreAttachElement_Public_Virtual_Void_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_DetachElement_Public_Virtual_Void_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_Indent_Public_Void_Int32_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_SetExpandedWithoutNotify_Public_Void_Boolean_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_SetToggleVisibility_Public_Void_Boolean_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_OnToggleGeometryChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIndentLayout_Private_Void_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_OnToggleValueChanged_Private_Void_ChangeEvent_1_Boolean_0;
	}
}
