using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace dwd.core.input.context
{
	// Token: 0x02000077 RID: 119
	public class CreateInputContext : UIBehaviour
	{
		// Token: 0x0600048C RID: 1164 RVA: 0x00014FB8 File Offset: 0x000131B8
		// Note: this type is marked as 'beforefieldinit'.
		static CreateInputContext()
		{
			Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.context", "CreateInputContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr);
			CreateInputContext.NativeFieldInfoPtr_initialSelectionPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, "initialSelectionPriority");
			CreateInputContext.NativeFieldInfoPtr_inputActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, "inputActions");
			CreateInputContext.NativeFieldInfoPtr_suppressGlobalInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, "suppressGlobalInput");
			CreateInputContext.NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, "layer");
			CreateInputContext.NativeFieldInfoPtr__createdContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, "<createdContext>k__BackingField");
			CreateInputContext.NativeFieldInfoPtr_contextManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, "contextManager");
			CreateInputContext.NativeFieldInfoPtr_contextCameraTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, "contextCameraTag");
			CreateInputContext.NativeFieldInfoPtr_contextCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, "contextCamera");
			CreateInputContext.NativeFieldInfoPtr_OnContextCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, "OnContextCreated");
			CreateInputContext.NativeMethodInfoPtr_get_availableSelectables_Protected_Abstract_Virtual_New_get_IEnumerable_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663815);
			CreateInputContext.NativeMethodInfoPtr_get_createdContext_Public_get_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663816);
			CreateInputContext.NativeMethodInfoPtr_set_createdContext_Private_set_Void_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663817);
			CreateInputContext.NativeMethodInfoPtr_get_Layer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663818);
			CreateInputContext.NativeMethodInfoPtr_get_onContextCreated_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663819);
			CreateInputContext.NativeMethodInfoPtr_get_InputActions_Public_get_List_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663820);
			CreateInputContext.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663821);
			CreateInputContext.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663822);
			CreateInputContext.NativeMethodInfoPtr_pushContextInOneFrame_Protected_IEnumerator_InputContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663823);
			CreateInputContext.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663824);
			CreateInputContext.NativeMethodInfoPtr_removeContext_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663825);
			CreateInputContext.NativeMethodInfoPtr_UpdateContextLayer_Public_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663826);
			CreateInputContext.NativeMethodInfoPtr_Event_ToggleEnabled_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663827);
			CreateInputContext.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663828);
			CreateInputContext.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663829);
			CreateInputContext.NativeMethodInfoPtr_OnSceneChanged_Private_Void_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663830);
			CreateInputContext.NativeMethodInfoPtr_ReInitialize_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663831);
			CreateInputContext.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, 100663832);
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00015204 File Offset: 0x00013404
		public unsafe virtual IEnumerable<Selectable> availableSelectables
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateInputContext.NativeMethodInfoPtr_get_availableSelectables_Protected_Abstract_Virtual_New_get_IEnumerable_1_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Selectable>>(intPtr3) : null;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00015250 File Offset: 0x00013450
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00015290 File Offset: 0x00013490
		public unsafe InputContext createdContext
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext.NativeMethodInfoPtr_get_createdContext_Public_get_InputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputContext>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext.NativeMethodInfoPtr_set_createdContext_Private_set_Void_InputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x000152D4 File Offset: 0x000134D4
		public unsafe int Layer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext.NativeMethodInfoPtr_get_Layer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00015310 File Offset: 0x00013510
		public unsafe UnityEvent onContextCreated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext.NativeMethodInfoPtr_get_onContextCreated_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00015350 File Offset: 0x00013550
		public unsafe List<InputAction> InputActions
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext.NativeMethodInfoPtr_get_InputActions_Public_get_List_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<InputAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00015390 File Offset: 0x00013590
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1122871, RefRangeEnd = 1122873, XrefRangeStart = 1122838, XrefRangeEnd = 1122871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateInputContext.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000153CC File Offset: 0x000135CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateInputContext.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00015408 File Offset: 0x00013608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1122879, RefRangeEnd = 1122881, XrefRangeStart = 1122873, XrefRangeEnd = 1122879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator pushContextInOneFrame(InputContext inputContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext.NativeMethodInfoPtr_pushContextInOneFrame_Protected_IEnumerator_InputContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00015458 File Offset: 0x00013658
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateInputContext.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00015494 File Offset: 0x00013694
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1122889, RefRangeEnd = 1122895, XrefRangeStart = 1122881, XrefRangeEnd = 1122889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void removeContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext.NativeMethodInfoPtr_removeContext_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000154C8 File Offset: 0x000136C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122895, XrefRangeEnd = 1122903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateContextLayer(int newLayer, bool combineLayers = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newLayer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref combineLayers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateInputContext.NativeMethodInfoPtr_UpdateContextLayer_Public_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00015520 File Offset: 0x00013720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1122905, RefRangeEnd = 1122907, XrefRangeStart = 1122903, XrefRangeEnd = 1122905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext.NativeMethodInfoPtr_Event_ToggleEnabled_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00015554 File Offset: 0x00013754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122907, XrefRangeEnd = 1122918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateInputContext.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00015590 File Offset: 0x00013790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122918, XrefRangeEnd = 1122929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateInputContext.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000155CC File Offset: 0x000137CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122929, XrefRangeEnd = 1122940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSceneChanged(Scene current, Scene next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref next;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext.NativeMethodInfoPtr_OnSceneChanged_Private_Void_Scene_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00015618 File Offset: 0x00013818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122940, XrefRangeEnd = 1122945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ReInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext.NativeMethodInfoPtr_ReInitialize_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00015658 File Offset: 0x00013858
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1122966, RefRangeEnd = 1122970, XrefRangeStart = 1122945, XrefRangeEnd = 1122966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateInputContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000049B0 File Offset: 0x00002BB0
		public CreateInputContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00015694 File Offset: 0x00013894
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x000049B9 File Offset: 0x00002BB9
		public unsafe Il2CppReferenceArray<Selectable> initialSelectionPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_initialSelectionPriority);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_initialSelectionPriority), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000156C4 File Offset: 0x000138C4
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x000049D8 File Offset: 0x00002BD8
		public unsafe List<InputAction> inputActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_inputActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_inputActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x000156F4 File Offset: 0x000138F4
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x000049F7 File Offset: 0x00002BF7
		public unsafe bool suppressGlobalInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_suppressGlobalInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_suppressGlobalInput)) = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0001571C File Offset: 0x0001391C
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00004A12 File Offset: 0x00002C12
		public unsafe int layer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_layer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_layer)) = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00015744 File Offset: 0x00013944
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00004A2D File Offset: 0x00002C2D
		public unsafe InputContext _createdContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr__createdContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr__createdContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00015774 File Offset: 0x00013974
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00004A4C File Offset: 0x00002C4C
		public unsafe InputContextManager contextManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_contextManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputContextManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_contextManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x000157A4 File Offset: 0x000139A4
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00004A6B File Offset: 0x00002C6B
		public unsafe string contextCameraTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_contextCameraTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_contextCameraTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000157CC File Offset: 0x000139CC
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00004A8A File Offset: 0x00002C8A
		public unsafe Camera contextCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_contextCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_contextCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x000157FC File Offset: 0x000139FC
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00004AA9 File Offset: 0x00002CA9
		public unsafe UnityEvent OnContextCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_OnContextCreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext.NativeFieldInfoPtr_OnContextCreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr_initialSelectionPriority;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr_inputActions;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr_suppressGlobalInput;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr_layer;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeFieldInfoPtr__createdContext_k__BackingField;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr_contextManager;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr_contextCameraTag;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr_contextCamera;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeFieldInfoPtr_OnContextCreated;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_get_availableSelectables_Protected_Abstract_Virtual_New_get_IEnumerable_1_Selectable_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_get_createdContext_Public_get_InputContext_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_set_createdContext_Private_set_Void_InputContext_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_get_Layer_Public_get_Int32_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_get_onContextCreated_Public_get_UnityEvent_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_get_InputActions_Public_get_List_1_InputAction_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_pushContextInOneFrame_Protected_IEnumerator_InputContext_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_removeContext_Protected_Void_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_UpdateContextLayer_Public_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleEnabled_Public_Void_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_OnSceneChanged_Private_Void_Scene_Scene_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_ReInitialize_Private_IEnumerator_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000CC RID: 204
		[ObfuscatedName("dwd.core.input.context.CreateInputContext+<ReInitialize>d__30")]
		public sealed class _ReInitialize_d__30 : global::Il2CppSystem.Object
		{
			// Token: 0x06000902 RID: 2306 RVA: 0x000240B0 File Offset: 0x000222B0
			// Note: this type is marked as 'beforefieldinit'.
			static _ReInitialize_d__30()
			{
				Il2CppClassPointerStore<CreateInputContext._ReInitialize_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, "<ReInitialize>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateInputContext._ReInitialize_d__30>.NativeClassPtr);
				CreateInputContext._ReInitialize_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext._ReInitialize_d__30>.NativeClassPtr, "<>1__state");
				CreateInputContext._ReInitialize_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext._ReInitialize_d__30>.NativeClassPtr, "<>2__current");
				CreateInputContext._ReInitialize_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext._ReInitialize_d__30>.NativeClassPtr, "<>4__this");
				CreateInputContext._ReInitialize_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext._ReInitialize_d__30>.NativeClassPtr, 100663833);
				CreateInputContext._ReInitialize_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext._ReInitialize_d__30>.NativeClassPtr, 100663834);
				CreateInputContext._ReInitialize_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext._ReInitialize_d__30>.NativeClassPtr, 100663835);
				CreateInputContext._ReInitialize_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext._ReInitialize_d__30>.NativeClassPtr, 100663836);
				CreateInputContext._ReInitialize_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext._ReInitialize_d__30>.NativeClassPtr, 100663837);
				CreateInputContext._ReInitialize_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext._ReInitialize_d__30>.NativeClassPtr, 100663838);
			}

			// Token: 0x06000903 RID: 2307 RVA: 0x00024190 File Offset: 0x00022390
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ReInitialize_d__30(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateInputContext._ReInitialize_d__30>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext._ReInitialize_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000904 RID: 2308 RVA: 0x000241D8 File Offset: 0x000223D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext._ReInitialize_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000905 RID: 2309 RVA: 0x0002420C File Offset: 0x0002240C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122822, XrefRangeEnd = 1122823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext._ReInitialize_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700029C RID: 668
			// (get) Token: 0x06000906 RID: 2310 RVA: 0x00024248 File Offset: 0x00022448
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext._ReInitialize_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000907 RID: 2311 RVA: 0x00024288 File Offset: 0x00022488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122823, XrefRangeEnd = 1122828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext._ReInitialize_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700029D RID: 669
			// (get) Token: 0x06000908 RID: 2312 RVA: 0x000242BC File Offset: 0x000224BC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext._ReInitialize_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000909 RID: 2313 RVA: 0x00006B2C File Offset: 0x00004D2C
			public _ReInitialize_d__30(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x0600090A RID: 2314 RVA: 0x000242FC File Offset: 0x000224FC
			// (set) Token: 0x0600090B RID: 2315 RVA: 0x00006B35 File Offset: 0x00004D35
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._ReInitialize_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._ReInitialize_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700029A RID: 666
			// (get) Token: 0x0600090C RID: 2316 RVA: 0x00024324 File Offset: 0x00022524
			// (set) Token: 0x0600090D RID: 2317 RVA: 0x00006B50 File Offset: 0x00004D50
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._ReInitialize_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._ReInitialize_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700029B RID: 667
			// (get) Token: 0x0600090E RID: 2318 RVA: 0x00024354 File Offset: 0x00022554
			// (set) Token: 0x0600090F RID: 2319 RVA: 0x00006B6F File Offset: 0x00004D6F
			public unsafe CreateInputContext __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._ReInitialize_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateInputContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._ReInitialize_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000596 RID: 1430
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000597 RID: 1431
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000598 RID: 1432
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000599 RID: 1433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400059A RID: 1434
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400059B RID: 1435
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400059C RID: 1436
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400059D RID: 1437
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400059E RID: 1438
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000CD RID: 205
		[ObfuscatedName("dwd.core.input.context.CreateInputContext+<pushContextInOneFrame>d__22")]
		public sealed class _pushContextInOneFrame_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x06000910 RID: 2320 RVA: 0x00024384 File Offset: 0x00022584
			// Note: this type is marked as 'beforefieldinit'.
			static _pushContextInOneFrame_d__22()
			{
				Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateInputContext>.NativeClassPtr, "<pushContextInOneFrame>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr);
				CreateInputContext._pushContextInOneFrame_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr, "<>1__state");
				CreateInputContext._pushContextInOneFrame_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr, "<>2__current");
				CreateInputContext._pushContextInOneFrame_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr, "<>4__this");
				CreateInputContext._pushContextInOneFrame_d__22.NativeFieldInfoPtr_inputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr, "inputContext");
				CreateInputContext._pushContextInOneFrame_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr, 100663839);
				CreateInputContext._pushContextInOneFrame_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr, 100663840);
				CreateInputContext._pushContextInOneFrame_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr, 100663841);
				CreateInputContext._pushContextInOneFrame_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr, 100663842);
				CreateInputContext._pushContextInOneFrame_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr, 100663843);
				CreateInputContext._pushContextInOneFrame_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr, 100663844);
			}

			// Token: 0x06000911 RID: 2321 RVA: 0x00024478 File Offset: 0x00022678
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _pushContextInOneFrame_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateInputContext._pushContextInOneFrame_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext._pushContextInOneFrame_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000912 RID: 2322 RVA: 0x000244C0 File Offset: 0x000226C0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext._pushContextInOneFrame_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000913 RID: 2323 RVA: 0x000244F4 File Offset: 0x000226F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122828, XrefRangeEnd = 1122833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext._pushContextInOneFrame_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000914 RID: 2324 RVA: 0x00024530 File Offset: 0x00022730
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext._pushContextInOneFrame_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000915 RID: 2325 RVA: 0x00024570 File Offset: 0x00022770
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122833, XrefRangeEnd = 1122838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext._pushContextInOneFrame_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x06000916 RID: 2326 RVA: 0x000245A4 File Offset: 0x000227A4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInputContext._pushContextInOneFrame_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000917 RID: 2327 RVA: 0x00006B8E File Offset: 0x00004D8E
			public _pushContextInOneFrame_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700029E RID: 670
			// (get) Token: 0x06000918 RID: 2328 RVA: 0x000245E4 File Offset: 0x000227E4
			// (set) Token: 0x06000919 RID: 2329 RVA: 0x00006B97 File Offset: 0x00004D97
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._pushContextInOneFrame_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._pushContextInOneFrame_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700029F RID: 671
			// (get) Token: 0x0600091A RID: 2330 RVA: 0x0002460C File Offset: 0x0002280C
			// (set) Token: 0x0600091B RID: 2331 RVA: 0x00006BB2 File Offset: 0x00004DB2
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._pushContextInOneFrame_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._pushContextInOneFrame_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x0600091C RID: 2332 RVA: 0x0002463C File Offset: 0x0002283C
			// (set) Token: 0x0600091D RID: 2333 RVA: 0x00006BD1 File Offset: 0x00004DD1
			public unsafe CreateInputContext __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._pushContextInOneFrame_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateInputContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._pushContextInOneFrame_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x0600091E RID: 2334 RVA: 0x0002466C File Offset: 0x0002286C
			// (set) Token: 0x0600091F RID: 2335 RVA: 0x00006BF0 File Offset: 0x00004DF0
			public unsafe InputContext inputContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._pushContextInOneFrame_d__22.NativeFieldInfoPtr_inputContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateInputContext._pushContextInOneFrame_d__22.NativeFieldInfoPtr_inputContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400059F RID: 1439
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040005A0 RID: 1440
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040005A1 RID: 1441
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040005A2 RID: 1442
			private static readonly IntPtr NativeFieldInfoPtr_inputContext;

			// Token: 0x040005A3 RID: 1443
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040005A4 RID: 1444
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040005A5 RID: 1445
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040005A6 RID: 1446
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040005A7 RID: 1447
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040005A8 RID: 1448
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
