using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000161 RID: 353
	public class BaseRuntimePanel : Panel
	{
		// Token: 0x06001A0E RID: 6670 RVA: 0x00079188 File Offset: 0x00077388
		// Note: this type is marked as 'beforefieldinit'.
		static BaseRuntimePanel()
		{
			Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseRuntimePanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr);
			BaseRuntimePanel.NativeFieldInfoPtr_m_SelectableGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "m_SelectableGameObject");
			BaseRuntimePanel.NativeFieldInfoPtr_s_CurrentRuntimePanelCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "s_CurrentRuntimePanelCounter");
			BaseRuntimePanel.NativeFieldInfoPtr_m_RuntimePanelCreationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "m_RuntimePanelCreationIndex");
			BaseRuntimePanel.NativeFieldInfoPtr_m_SortingPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "m_SortingPriority");
			BaseRuntimePanel.NativeFieldInfoPtr_resolvedSortingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "resolvedSortingIndex");
			BaseRuntimePanel.NativeFieldInfoPtr_destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "destroyed");
			BaseRuntimePanel.NativeFieldInfoPtr_m_StandardWorldSpaceShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "m_StandardWorldSpaceShader");
			BaseRuntimePanel.NativeFieldInfoPtr_m_DrawToCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "m_DrawToCameras");
			BaseRuntimePanel.NativeFieldInfoPtr_targetTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "targetTexture");
			BaseRuntimePanel.NativeFieldInfoPtr_panelToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "panelToWorld");
			BaseRuntimePanel.NativeFieldInfoPtr__targetDisplay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "<targetDisplay>k__BackingField");
			BaseRuntimePanel.NativeFieldInfoPtr_DefaultScreenToPanelSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "DefaultScreenToPanelSpace");
			BaseRuntimePanel.NativeFieldInfoPtr_m_ScreenToPanelSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "m_ScreenToPanelSpace");
			BaseRuntimePanel.NativeMethodInfoPtr_get_selectableGameObject_Public_Virtual_Final_New_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667103);
			BaseRuntimePanel.NativeMethodInfoPtr_set_selectableGameObject_Public_Virtual_Final_New_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667104);
			BaseRuntimePanel.NativeMethodInfoPtr_get_sortingPriority_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667105);
			BaseRuntimePanel.NativeMethodInfoPtr_set_sortingPriority_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667106);
			BaseRuntimePanel.NativeMethodInfoPtr_add_destroyed_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667107);
			BaseRuntimePanel.NativeMethodInfoPtr_remove_destroyed_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667108);
			BaseRuntimePanel.NativeMethodInfoPtr__ctor_Protected_Void_ScriptableObject_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667109);
			BaseRuntimePanel.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667110);
			BaseRuntimePanel.NativeMethodInfoPtr_get_standardWorldSpaceShader_Internal_Virtual_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667111);
			BaseRuntimePanel.NativeMethodInfoPtr_get_drawToCameras_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667112);
			BaseRuntimePanel.NativeMethodInfoPtr_set_drawToCameras_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667113);
			BaseRuntimePanel.NativeMethodInfoPtr_get_targetDisplay_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667114);
			BaseRuntimePanel.NativeMethodInfoPtr_set_targetDisplay_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667115);
			BaseRuntimePanel.NativeMethodInfoPtr_get_screenRenderingWidth_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667116);
			BaseRuntimePanel.NativeMethodInfoPtr_get_screenRenderingHeight_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667117);
			BaseRuntimePanel.NativeMethodInfoPtr_getScreenRenderingHeight_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667118);
			BaseRuntimePanel.NativeMethodInfoPtr_getScreenRenderingWidth_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667119);
			BaseRuntimePanel.NativeMethodInfoPtr_Repaint_Public_Virtual_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667120);
			BaseRuntimePanel.NativeMethodInfoPtr_get_screenToPanelSpace_Public_get_Func_2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667121);
			BaseRuntimePanel.NativeMethodInfoPtr_set_screenToPanelSpace_Public_set_Void_Func_2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667122);
			BaseRuntimePanel.NativeMethodInfoPtr_ScreenToPanel_Internal_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667123);
			BaseRuntimePanel.NativeMethodInfoPtr_ScreenToPanel_Internal_Boolean_Vector2_Vector2_byref_Vector2_byref_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667124);
			BaseRuntimePanel.NativeMethodInfoPtr_AssignPanelToComponents_Private_Void_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667125);
			BaseRuntimePanel.NativeMethodInfoPtr_PointerLeavesPanel_Internal_Void_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667126);
			BaseRuntimePanel.NativeMethodInfoPtr_PointerEntersPanel_Internal_Void_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, 100667127);
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x000794B0 File Offset: 0x000776B0
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x000794F0 File Offset: 0x000776F0
		public unsafe virtual GameObject selectableGameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_get_selectableGameObject_Public_Virtual_Final_New_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 321600, RefRangeEnd = 321601, XrefRangeStart = 321593, XrefRangeEnd = 321600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_set_selectableGameObject_Public_Virtual_Final_New_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x00079534 File Offset: 0x00077734
		// (set) Token: 0x06001A12 RID: 6674 RVA: 0x00079570 File Offset: 0x00077770
		public unsafe float sortingPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_get_sortingPriority_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 321606, RefRangeEnd = 321610, XrefRangeStart = 321601, XrefRangeEnd = 321606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_set_sortingPriority_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x000795B0 File Offset: 0x000777B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 321614, RefRangeEnd = 321619, XrefRangeStart = 321610, XrefRangeEnd = 321614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_destroyed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_add_destroyed_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x000795F4 File Offset: 0x000777F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 321623, RefRangeEnd = 321627, XrefRangeStart = 321619, XrefRangeEnd = 321623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_destroyed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_remove_destroyed_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00079638 File Offset: 0x00077838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321640, RefRangeEnd = 321641, XrefRangeStart = 321627, XrefRangeEnd = 321640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseRuntimePanel(ScriptableObject ownerObject, EventDispatcher dispatcher = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ownerObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dispatcher);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr__ctor_Protected_Void_ScriptableObject_EventDispatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00079698 File Offset: 0x00077898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321641, XrefRangeEnd = 321642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRuntimePanel.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x000796E4 File Offset: 0x000778E4
		// (set) Token: 0x06001A43 RID: 6723 RVA: 0x00079DC4 File Offset: 0x00077FC4
		public unsafe override Shader standardWorldSpaceShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRuntimePanel.NativeMethodInfoPtr_get_standardWorldSpaceShader_Internal_Virtual_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
			set
			{
				bool flag = this.m_StandardWorldSpaceShader != value;
				if (flag)
				{
					this.m_StandardWorldSpaceShader = value;
					base.InvokeStandardWorldSpaceShaderChanged();
				}
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x00079730 File Offset: 0x00077930
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x0007976C File Offset: 0x0007796C
		public unsafe bool drawToCameras
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 321642, RefRangeEnd = 321643, XrefRangeStart = 321642, XrefRangeEnd = 321642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_get_drawToCameras_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 321647, RefRangeEnd = 321648, XrefRangeStart = 321643, XrefRangeEnd = 321647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_set_drawToCameras_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x000797AC File Offset: 0x000779AC
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x000797E8 File Offset: 0x000779E8
		public unsafe int targetDisplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_get_targetDisplay_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_set_targetDisplay_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00079828 File Offset: 0x00077A28
		public unsafe int screenRenderingWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321648, XrefRangeEnd = 321658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_get_screenRenderingWidth_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x00079864 File Offset: 0x00077A64
		public unsafe int screenRenderingHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321658, XrefRangeEnd = 321668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_get_screenRenderingHeight_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000798A0 File Offset: 0x00077AA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321675, RefRangeEnd = 321677, XrefRangeStart = 321668, XrefRangeEnd = 321675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int getScreenRenderingHeight(int display)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref display;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_getScreenRenderingHeight_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x000798E0 File Offset: 0x00077AE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321684, RefRangeEnd = 321686, XrefRangeStart = 321677, XrefRangeEnd = 321684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int getScreenRenderingWidth(int display)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref display;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_getScreenRenderingWidth_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00079920 File Offset: 0x00077B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321686, XrefRangeEnd = 321734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Repaint(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRuntimePanel.NativeMethodInfoPtr_Repaint_Public_Virtual_Void_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x00079970 File Offset: 0x00077B70
		// (set) Token: 0x06001A22 RID: 6690 RVA: 0x000799B0 File Offset: 0x00077BB0
		public unsafe Func<Vector2, Vector2> screenToPanelSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_get_screenToPanelSpace_Public_get_Func_2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Vector2, Vector2>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 321740, RefRangeEnd = 321742, XrefRangeStart = 321734, XrefRangeEnd = 321740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_set_screenToPanelSpace_Public_set_Void_Func_2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000799F4 File Offset: 0x00077BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321743, RefRangeEnd = 321744, XrefRangeStart = 321742, XrefRangeEnd = 321743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ScreenToPanel(Vector2 screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_ScreenToPanel_Internal_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00079A40 File Offset: 0x00077C40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 321749, RefRangeEnd = 321753, XrefRangeStart = 321744, XrefRangeEnd = 321749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenDelta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &panelPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &panelDelta;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowOutside;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_ScreenToPanel_Internal_Boolean_Vector2_Vector2_byref_Vector2_byref_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00079AC4 File Offset: 0x00077CC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321791, RefRangeEnd = 321793, XrefRangeStart = 321753, XrefRangeEnd = 321791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignPanelToComponents(BaseRuntimePanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_AssignPanelToComponents_Private_Void_BaseRuntimePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00079B08 File Offset: 0x00077D08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321799, RefRangeEnd = 321801, XrefRangeStart = 321793, XrefRangeEnd = 321799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PointerLeavesPanel(int pointerId, Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_PointerLeavesPanel_Internal_Void_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00079B54 File Offset: 0x00077D54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321805, RefRangeEnd = 321807, XrefRangeStart = 321801, XrefRangeEnd = 321805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PointerEntersPanel(int pointerId, Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.NativeMethodInfoPtr_PointerEntersPanel_Internal_Void_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0000BDAB File Offset: 0x00009FAB
		public BaseRuntimePanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x00079BA0 File Offset: 0x00077DA0
		// (set) Token: 0x06001A2A RID: 6698 RVA: 0x0000BDB4 File Offset: 0x00009FB4
		public unsafe GameObject m_SelectableGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_SelectableGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_SelectableGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x00079BD0 File Offset: 0x00077DD0
		// (set) Token: 0x06001A2C RID: 6700 RVA: 0x0000BDD3 File Offset: 0x00009FD3
		public unsafe static int s_CurrentRuntimePanelCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BaseRuntimePanel.NativeFieldInfoPtr_s_CurrentRuntimePanelCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseRuntimePanel.NativeFieldInfoPtr_s_CurrentRuntimePanelCounter, (void*)(&value));
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x00079BEC File Offset: 0x00077DEC
		// (set) Token: 0x06001A2E RID: 6702 RVA: 0x0000BDE1 File Offset: 0x00009FE1
		public unsafe int m_RuntimePanelCreationIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_RuntimePanelCreationIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_RuntimePanelCreationIndex)) = value;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x00079C14 File Offset: 0x00077E14
		// (set) Token: 0x06001A30 RID: 6704 RVA: 0x0000BDFC File Offset: 0x00009FFC
		public unsafe float m_SortingPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_SortingPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_SortingPriority)) = value;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00079C3C File Offset: 0x00077E3C
		// (set) Token: 0x06001A32 RID: 6706 RVA: 0x0000BE17 File Offset: 0x0000A017
		public unsafe int resolvedSortingIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_resolvedSortingIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_resolvedSortingIndex)) = value;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x00079C64 File Offset: 0x00077E64
		// (set) Token: 0x06001A34 RID: 6708 RVA: 0x0000BE32 File Offset: 0x0000A032
		public unsafe Action destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_destroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_destroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00079C94 File Offset: 0x00077E94
		// (set) Token: 0x06001A36 RID: 6710 RVA: 0x0000BE51 File Offset: 0x0000A051
		public unsafe Shader m_StandardWorldSpaceShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_StandardWorldSpaceShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_StandardWorldSpaceShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x00079CC4 File Offset: 0x00077EC4
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x0000BE70 File Offset: 0x0000A070
		public unsafe bool m_DrawToCameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_DrawToCameras);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_DrawToCameras)) = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x00079CEC File Offset: 0x00077EEC
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0000BE8B File Offset: 0x0000A08B
		public unsafe RenderTexture targetTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_targetTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_targetTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x00079D1C File Offset: 0x00077F1C
		// (set) Token: 0x06001A3C RID: 6716 RVA: 0x0000BEAA File Offset: 0x0000A0AA
		public unsafe Matrix4x4 panelToWorld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_panelToWorld);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_panelToWorld)) = value;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x00079D44 File Offset: 0x00077F44
		// (set) Token: 0x06001A3E RID: 6718 RVA: 0x0000BEC5 File Offset: 0x0000A0C5
		public unsafe int _targetDisplay_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr__targetDisplay_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr__targetDisplay_k__BackingField)) = value;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x00079D6C File Offset: 0x00077F6C
		// (set) Token: 0x06001A40 RID: 6720 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		public unsafe static Func<Vector2, Vector2> DefaultScreenToPanelSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseRuntimePanel.NativeFieldInfoPtr_DefaultScreenToPanelSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2, Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseRuntimePanel.NativeFieldInfoPtr_DefaultScreenToPanelSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001A41 RID: 6721 RVA: 0x00079D94 File Offset: 0x00077F94
		// (set) Token: 0x06001A42 RID: 6722 RVA: 0x0000BEF2 File Offset: 0x0000A0F2
		public unsafe Func<Vector2, Vector2> m_ScreenToPanelSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_ScreenToPanelSpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRuntimePanel.NativeFieldInfoPtr_m_ScreenToPanelSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectableGameObject;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentRuntimePanelCounter;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeFieldInfoPtr_m_RuntimePanelCreationIndex;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingPriority;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeFieldInfoPtr_resolvedSortingIndex;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeFieldInfoPtr_destroyed;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeFieldInfoPtr_m_StandardWorldSpaceShader;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawToCameras;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeFieldInfoPtr_targetTexture;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeFieldInfoPtr_panelToWorld;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeFieldInfoPtr__targetDisplay_k__BackingField;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeFieldInfoPtr_DefaultScreenToPanelSpace;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenToPanelSpace;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeMethodInfoPtr_get_selectableGameObject_Public_Virtual_Final_New_get_GameObject_0;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeMethodInfoPtr_set_selectableGameObject_Public_Virtual_Final_New_set_Void_GameObject_0;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingPriority_Public_get_Single_0;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingPriority_Public_set_Void_Single_0;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr_add_destroyed_Public_add_Void_Action_0;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr_remove_destroyed_Public_rem_Void_Action_0;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ScriptableObject_EventDispatcher_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_get_standardWorldSpaceShader_Internal_Virtual_get_Shader_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_get_drawToCameras_Internal_get_Boolean_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr_set_drawToCameras_Internal_set_Void_Boolean_0;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_get_targetDisplay_Internal_get_Int32_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr_set_targetDisplay_Internal_set_Void_Int32_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_get_screenRenderingWidth_Internal_get_Int32_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_get_screenRenderingHeight_Internal_get_Int32_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_getScreenRenderingHeight_Internal_Static_Int32_Int32_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_getScreenRenderingWidth_Internal_Static_Int32_Int32_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_Repaint_Public_Virtual_Void_Event_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_get_screenToPanelSpace_Public_get_Func_2_Vector2_Vector2_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_set_screenToPanelSpace_Public_set_Void_Func_2_Vector2_Vector2_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToPanel_Internal_Vector2_Vector2_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToPanel_Internal_Boolean_Vector2_Vector2_byref_Vector2_byref_Vector2_Boolean_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_AssignPanelToComponents_Private_Void_BaseRuntimePanel_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_PointerLeavesPanel_Internal_Void_Int32_Vector2_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_PointerEntersPanel_Internal_Void_Int32_Vector2_0;

		// Token: 0x02000491 RID: 1169
		[ObfuscatedName("UnityEngine.UIElements.BaseRuntimePanel+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003C6A RID: 15466 RVA: 0x000F20CC File Offset: 0x000F02CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BaseRuntimePanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseRuntimePanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseRuntimePanel.__c>.NativeClassPtr);
				BaseRuntimePanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRuntimePanel.__c>.NativeClassPtr, "<>9");
				BaseRuntimePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel.__c>.NativeClassPtr, 100667130);
				BaseRuntimePanel.__c.NativeMethodInfoPtr___cctor_b__47_0_Internal_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRuntimePanel.__c>.NativeClassPtr, 100667131);
			}

			// Token: 0x06003C6B RID: 15467 RVA: 0x000F2134 File Offset: 0x000F0334
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseRuntimePanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C6C RID: 15468 RVA: 0x000F2170 File Offset: 0x000F0370
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 __cctor_b__47_0(Vector2 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref p;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRuntimePanel.__c.NativeMethodInfoPtr___cctor_b__47_0_Internal_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003C6D RID: 15469 RVA: 0x000194E7 File Offset: 0x000176E7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700123F RID: 4671
			// (get) Token: 0x06003C6E RID: 15470 RVA: 0x000F21BC File Offset: 0x000F03BC
			// (set) Token: 0x06003C6F RID: 15471 RVA: 0x000194F0 File Offset: 0x000176F0
			public unsafe static BaseRuntimePanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BaseRuntimePanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BaseRuntimePanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002AC3 RID: 10947
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002AC4 RID: 10948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002AC5 RID: 10949
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__47_0_Internal_Vector2_Vector2_0;
		}

		// Token: 0x02000492 RID: 1170
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
