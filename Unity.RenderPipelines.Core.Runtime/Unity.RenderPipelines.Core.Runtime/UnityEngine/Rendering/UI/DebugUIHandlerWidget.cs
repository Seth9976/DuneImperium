using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x0200013E RID: 318
	public class DebugUIHandlerWidget : MonoBehaviour
	{
		// Token: 0x060014D0 RID: 5328 RVA: 0x0005C070 File Offset: 0x0005A270
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerWidget()
		{
			Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerWidget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr);
			DebugUIHandlerWidget.NativeFieldInfoPtr_colorDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, "colorDefault");
			DebugUIHandlerWidget.NativeFieldInfoPtr_colorSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, "colorSelected");
			DebugUIHandlerWidget.NativeFieldInfoPtr__parentUIHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, "<parentUIHandler>k__BackingField");
			DebugUIHandlerWidget.NativeFieldInfoPtr__previousUIHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, "<previousUIHandler>k__BackingField");
			DebugUIHandlerWidget.NativeFieldInfoPtr__nextUIHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, "<nextUIHandler>k__BackingField");
			DebugUIHandlerWidget.NativeFieldInfoPtr_m_Widget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, "m_Widget");
			DebugUIHandlerWidget.NativeMethodInfoPtr_get_parentUIHandler_Public_get_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666288);
			DebugUIHandlerWidget.NativeMethodInfoPtr_set_parentUIHandler_Public_set_Void_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666289);
			DebugUIHandlerWidget.NativeMethodInfoPtr_get_previousUIHandler_Public_get_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666290);
			DebugUIHandlerWidget.NativeMethodInfoPtr_set_previousUIHandler_Public_set_Void_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666291);
			DebugUIHandlerWidget.NativeMethodInfoPtr_get_nextUIHandler_Public_get_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666292);
			DebugUIHandlerWidget.NativeMethodInfoPtr_set_nextUIHandler_Public_set_Void_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666293);
			DebugUIHandlerWidget.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666294);
			DebugUIHandlerWidget.NativeMethodInfoPtr_SetWidget_Internal_Virtual_New_Void_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666295);
			DebugUIHandlerWidget.NativeMethodInfoPtr_GetWidget_Internal_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666296);
			DebugUIHandlerWidget.NativeMethodInfoPtr_CastWidget_Protected_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666297);
			DebugUIHandlerWidget.NativeMethodInfoPtr_OnSelection_Public_Virtual_New_Boolean_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666298);
			DebugUIHandlerWidget.NativeMethodInfoPtr_OnDeselection_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666299);
			DebugUIHandlerWidget.NativeMethodInfoPtr_OnAction_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666300);
			DebugUIHandlerWidget.NativeMethodInfoPtr_OnIncrement_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666301);
			DebugUIHandlerWidget.NativeMethodInfoPtr_OnDecrement_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666302);
			DebugUIHandlerWidget.NativeMethodInfoPtr_Previous_Public_Virtual_New_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666303);
			DebugUIHandlerWidget.NativeMethodInfoPtr_Next_Public_Virtual_New_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666304);
			DebugUIHandlerWidget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr, 100666305);
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x0005C280 File Offset: 0x0005A480
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x0005C2C0 File Offset: 0x0005A4C0
		public unsafe DebugUIHandlerWidget parentUIHandler
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerWidget.NativeMethodInfoPtr_get_parentUIHandler_Public_get_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerWidget.NativeMethodInfoPtr_set_parentUIHandler_Public_set_Void_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0005C304 File Offset: 0x0005A504
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x0005C344 File Offset: 0x0005A544
		public unsafe DebugUIHandlerWidget previousUIHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerWidget.NativeMethodInfoPtr_get_previousUIHandler_Public_get_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerWidget.NativeMethodInfoPtr_set_previousUIHandler_Public_set_Void_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x0005C388 File Offset: 0x0005A588
		// (set) Token: 0x060014D6 RID: 5334 RVA: 0x0005C3C8 File Offset: 0x0005A5C8
		public unsafe DebugUIHandlerWidget nextUIHandler
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerWidget.NativeMethodInfoPtr_get_nextUIHandler_Public_get_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerWidget.NativeMethodInfoPtr_set_nextUIHandler_Public_set_Void_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0005C40C File Offset: 0x0005A60C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerWidget.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0005C448 File Offset: 0x0005A648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetWidget(DebugUI.Widget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerWidget.NativeMethodInfoPtr_SetWidget_Internal_Virtual_New_Void_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0005C498 File Offset: 0x0005A698
		[CallerCount(0)]
		public unsafe DebugUI.Widget GetWidget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerWidget.NativeMethodInfoPtr_GetWidget_Internal_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0005C4D8 File Offset: 0x0005A6D8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 981888, RefRangeEnd = 981908, XrefRangeStart = 981872, XrefRangeEnd = 981888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CastWidget<T>() where T : DebugUI.Widget
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerWidget.MethodInfoStoreGeneric_CastWidget_Protected_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0005C514 File Offset: 0x0005A714
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromNext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previous);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerWidget.NativeMethodInfoPtr_OnSelection_Public_Virtual_New_Boolean_Boolean_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0005C57C File Offset: 0x0005A77C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeselection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerWidget.NativeMethodInfoPtr_OnDeselection_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0005C5B8 File Offset: 0x0005A7B8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerWidget.NativeMethodInfoPtr_OnAction_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0005C5F4 File Offset: 0x0005A7F4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnIncrement(bool fast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fast;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerWidget.NativeMethodInfoPtr_OnIncrement_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0005C640 File Offset: 0x0005A840
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDecrement(bool fast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fast;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerWidget.NativeMethodInfoPtr_OnDecrement_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0005C68C File Offset: 0x0005A88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981908, XrefRangeEnd = 981915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DebugUIHandlerWidget Previous()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerWidget.NativeMethodInfoPtr_Previous_Public_Virtual_New_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr3) : null;
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0005C6D8 File Offset: 0x0005A8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981915, XrefRangeEnd = 981928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DebugUIHandlerWidget Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerWidget.NativeMethodInfoPtr_Next_Public_Virtual_New_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr3) : null;
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0005C724 File Offset: 0x0005A924
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 981929, RefRangeEnd = 981953, XrefRangeStart = 981928, XrefRangeEnd = 981929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerWidget()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerWidget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0000A7D9 File Offset: 0x000089D9
		public DebugUIHandlerWidget(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x0005C760 File Offset: 0x0005A960
		// (set) Token: 0x060014E5 RID: 5349 RVA: 0x0000A7E2 File Offset: 0x000089E2
		public unsafe Color colorDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerWidget.NativeFieldInfoPtr_colorDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerWidget.NativeFieldInfoPtr_colorDefault)) = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0005C788 File Offset: 0x0005A988
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x0000A7FD File Offset: 0x000089FD
		public unsafe Color colorSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerWidget.NativeFieldInfoPtr_colorSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerWidget.NativeFieldInfoPtr_colorSelected)) = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x0005C7B0 File Offset: 0x0005A9B0
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x0000A818 File Offset: 0x00008A18
		public unsafe DebugUIHandlerWidget _parentUIHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerWidget.NativeFieldInfoPtr__parentUIHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerWidget.NativeFieldInfoPtr__parentUIHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x0005C7E0 File Offset: 0x0005A9E0
		// (set) Token: 0x060014EB RID: 5355 RVA: 0x0000A837 File Offset: 0x00008A37
		public unsafe DebugUIHandlerWidget _previousUIHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerWidget.NativeFieldInfoPtr__previousUIHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerWidget.NativeFieldInfoPtr__previousUIHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x0005C810 File Offset: 0x0005AA10
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x0000A856 File Offset: 0x00008A56
		public unsafe DebugUIHandlerWidget _nextUIHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerWidget.NativeFieldInfoPtr__nextUIHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerWidget.NativeFieldInfoPtr__nextUIHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x0005C840 File Offset: 0x0005AA40
		// (set) Token: 0x060014EF RID: 5359 RVA: 0x0000A875 File Offset: 0x00008A75
		public unsafe DebugUI.Widget m_Widget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerWidget.NativeFieldInfoPtr_m_Widget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerWidget.NativeFieldInfoPtr_m_Widget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeFieldInfoPtr_colorDefault;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeFieldInfoPtr_colorSelected;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeFieldInfoPtr__parentUIHandler_k__BackingField;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeFieldInfoPtr__previousUIHandler_k__BackingField;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeFieldInfoPtr__nextUIHandler_k__BackingField;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeFieldInfoPtr_m_Widget;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_get_parentUIHandler_Public_get_DebugUIHandlerWidget_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_set_parentUIHandler_Public_set_Void_DebugUIHandlerWidget_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_get_previousUIHandler_Public_get_DebugUIHandlerWidget_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_set_previousUIHandler_Public_set_Void_DebugUIHandlerWidget_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_get_nextUIHandler_Public_get_DebugUIHandlerWidget_0;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_set_nextUIHandler_Public_set_Void_DebugUIHandlerWidget_0;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr_SetWidget_Internal_Virtual_New_Void_Widget_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr_GetWidget_Internal_Widget_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_CastWidget_Protected_T_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_OnSelection_Public_Virtual_New_Boolean_Boolean_DebugUIHandlerWidget_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselection_Public_Virtual_New_Void_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_OnAction_Public_Virtual_New_Void_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr_OnIncrement_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr_OnDecrement_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr_Previous_Public_Virtual_New_DebugUIHandlerWidget_0;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_New_DebugUIHandlerWidget_0;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200021D RID: 541
		private sealed class MethodInfoStoreGeneric_CastWidget_Protected_T_0<T>
		{
			// Token: 0x040013F7 RID: 5111
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DebugUIHandlerWidget.NativeMethodInfoPtr_CastWidget_Protected_T_0, Il2CppClassPointerStore<DebugUIHandlerWidget>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
