using System;
using boardgames.menu.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace zen.src.menus
{
	// Token: 0x02000057 RID: 87
	public class DialogRenderer : MonoBehaviour
	{
		// Token: 0x0600046B RID: 1131 RVA: 0x0001DCBC File Offset: 0x0001BEBC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogRenderer()
		{
			Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus", "DialogRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr);
			DialogRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "animator");
			DialogRenderer.NativeFieldInfoPtr_continueTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "continueTo");
			DialogRenderer.NativeFieldInfoPtr_postContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "postContinue");
			DialogRenderer.NativeFieldInfoPtr_returnTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "returnTo");
			DialogRenderer.NativeFieldInfoPtr_isModal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "isModal");
			DialogRenderer.NativeFieldInfoPtr_isInterstitial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "isInterstitial");
			DialogRenderer.NativeFieldInfoPtr_visibleParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "visibleParam");
			DialogRenderer.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "model");
			DialogRenderer.NativeFieldInfoPtr_blockingClicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "blockingClicks");
			DialogRenderer.NativeFieldInfoPtr_canBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "canBack");
			DialogRenderer.NativeFieldInfoPtr__Top_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "<Top>k__BackingField");
			DialogRenderer.NativeMethodInfoPtr_get_ContinueTo_Protected_get_DialogRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663858);
			DialogRenderer.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663859);
			DialogRenderer.NativeMethodInfoPtr_get_Top_Public_Static_get_DialogRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663860);
			DialogRenderer.NativeMethodInfoPtr_set_Top_Protected_Static_set_Void_DialogRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663861);
			DialogRenderer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663862);
			DialogRenderer.NativeMethodInfoPtr_IsOpen_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663863);
			DialogRenderer.NativeMethodInfoPtr_configureData_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663864);
			DialogRenderer.NativeMethodInfoPtr_addDataToModel_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663865);
			DialogRenderer.NativeMethodInfoPtr_republish_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663866);
			DialogRenderer.NativeMethodInfoPtr_GetViewModel_Public_DialogRendererViewModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663867);
			DialogRenderer.NativeMethodInfoPtr_Push_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663868);
			DialogRenderer.NativeMethodInfoPtr_Goto_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663869);
			DialogRenderer.NativeMethodInfoPtr_Goto_Public_Void_DialogRenderer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663870);
			DialogRenderer.NativeMethodInfoPtr_Show_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663871);
			DialogRenderer.NativeMethodInfoPtr_WaitUntilHidden_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663872);
			DialogRenderer.NativeMethodInfoPtr_ShowOnStack_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663873);
			DialogRenderer.NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663874);
			DialogRenderer.NativeMethodInfoPtr_ThenContinueTo_Public_T_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663875);
			DialogRenderer.NativeMethodInfoPtr_ThenContinueTo_Public_T_T_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663876);
			DialogRenderer.NativeMethodInfoPtr_HideAndWait_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663877);
			DialogRenderer.NativeMethodInfoPtr_GoBack_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663878);
			DialogRenderer.NativeMethodInfoPtr_show_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663879);
			DialogRenderer.NativeMethodInfoPtr_gotoInternal_Private_IEnumerator_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663880);
			DialogRenderer.NativeMethodInfoPtr_ContinueOrHide_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663881);
			DialogRenderer.NativeMethodInfoPtr_ContinueOrGoto_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663882);
			DialogRenderer.NativeMethodInfoPtr_ToggleVisibility_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663883);
			DialogRenderer.NativeMethodInfoPtr_ReactToBackKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663884);
			DialogRenderer.NativeMethodInfoPtr_reactToBackKey_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663885);
			DialogRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663886);
			DialogRenderer.NativeMethodInfoPtr__ContinueOrHide_b__37_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663887);
			DialogRenderer.NativeMethodInfoPtr__ContinueOrGoto_b__38_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, 100663888);
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0001E034 File Offset: 0x0001C234
		public unsafe DialogRenderer ContinueTo
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr_get_ContinueTo_Protected_get_DialogRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogRenderer>(intPtr3) : null;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0001E074 File Offset: 0x0001C274
		public unsafe bool Visible
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 986007, RefRangeEnd = 986008, XrefRangeStart = 986007, XrefRangeEnd = 986007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001E0B0 File Offset: 0x0001C2B0
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x0001E0E4 File Offset: 0x0001C2E4
		public unsafe static DialogRenderer Top
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986008, XrefRangeEnd = 986010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr_get_Top_Public_Static_get_DialogRenderer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogRenderer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986010, XrefRangeEnd = 986014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr_set_Top_Protected_Static_set_Void_DialogRenderer_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0001E11C File Offset: 0x0001C31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986014, XrefRangeEnd = 986018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogRenderer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0001E158 File Offset: 0x0001C358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986018, XrefRangeEnd = 986022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOpen<T>() where T : DialogRenderer
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.MethodInfoStoreGeneric_IsOpen_Public_Static_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0001E188 File Offset: 0x0001C388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 986044, RefRangeEnd = 986045, XrefRangeStart = 986022, XrefRangeEnd = 986044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void configureData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr_configureData_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0001E1BC File Offset: 0x0001C3BC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void addDataToModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogRenderer.NativeMethodInfoPtr_addDataToModel_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986045, XrefRangeEnd = 986053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void republish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr_republish_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0001E22C File Offset: 0x0001C42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986053, XrefRangeEnd = 986054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogRendererViewModel GetViewModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr_GetViewModel_Public_DialogRendererViewModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogRendererViewModel>(intPtr3) : null;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001E26C File Offset: 0x0001C46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986054, XrefRangeEnd = 986063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Push<T>() where T : DialogRenderer
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.MethodInfoStoreGeneric_Push_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001E2A8 File Offset: 0x0001C4A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 986066, RefRangeEnd = 986067, XrefRangeStart = 986063, XrefRangeEnd = 986066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Goto<T>(bool skipOnReturn = false) where T : DialogRenderer
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipOnReturn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.MethodInfoStoreGeneric_Goto_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001E2F0 File Offset: 0x0001C4F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 986080, RefRangeEnd = 986081, XrefRangeStart = 986067, XrefRangeEnd = 986080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Goto(DialogRenderer dialog, bool skipOnReturn = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialog);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipOnReturn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr_Goto_Public_Void_DialogRenderer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001E340 File Offset: 0x0001C540
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 986086, RefRangeEnd = 986088, XrefRangeStart = 986081, XrefRangeEnd = 986086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogRenderer.NativeMethodInfoPtr_Show_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001E38C File Offset: 0x0001C58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986088, XrefRangeEnd = 986093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitUntilHidden()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr_WaitUntilHidden_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0001E3CC File Offset: 0x0001C5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986093, XrefRangeEnd = 986098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator ShowOnStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogRenderer.NativeMethodInfoPtr_ShowOnStack_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0001E418 File Offset: 0x0001C618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986098, XrefRangeEnd = 986114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogRenderer.NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001E454 File Offset: 0x0001C654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986114, XrefRangeEnd = 986118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T ThenContinueTo<T>(Action postContinue = null) where T : DialogRenderer
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(postContinue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.MethodInfoStoreGeneric_ThenContinueTo_Public_T_Action_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0001E4A0 File Offset: 0x0001C6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986118, XrefRangeEnd = 986120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T ThenContinueTo<T>(T dialog, Action postContinue = null) where T : DialogRenderer
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = dialog;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref dialog;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postContinue);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.MethodInfoStoreGeneric_ThenContinueTo_Public_T_T_Action_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001E534 File Offset: 0x0001C734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986120, XrefRangeEnd = 986125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator HideAndWait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogRenderer.NativeMethodInfoPtr_HideAndWait_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001E580 File Offset: 0x0001C780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986125, XrefRangeEnd = 986159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GoBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogRenderer.NativeMethodInfoPtr_GoBack_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001E5BC File Offset: 0x0001C7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986159, XrefRangeEnd = 986163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogRenderer.NativeMethodInfoPtr_show_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001E608 File Offset: 0x0001C808
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 986169, RefRangeEnd = 986177, XrefRangeStart = 986163, XrefRangeEnd = 986169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator gotoInternal<T>(T dialog, bool setReturnTo = true) where T : DialogRenderer
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = dialog;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref dialog;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setReturnTo;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.MethodInfoStoreGeneric_gotoInternal_Private_IEnumerator_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0001E69C File Offset: 0x0001C89C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 986201, RefRangeEnd = 986203, XrefRangeStart = 986177, XrefRangeEnd = 986201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueOrHide(bool setReturnTo = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setReturnTo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr_ContinueOrHide_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0001E6DC File Offset: 0x0001C8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986203, XrefRangeEnd = 986226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueOrGoto<T>() where T : DialogRenderer
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.MethodInfoStoreGeneric_ContinueOrGoto_Protected_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001E710 File Offset: 0x0001C910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986226, XrefRangeEnd = 986228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ToggleVisibility(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogRenderer.NativeMethodInfoPtr_ToggleVisibility_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001E75C File Offset: 0x0001C95C
		[CallerCount(0)]
		public unsafe void ReactToBackKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr_ReactToBackKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0001E790 File Offset: 0x0001C990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986228, XrefRangeEnd = 986235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void reactToBackKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogRenderer.NativeMethodInfoPtr_reactToBackKey_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0001E7CC File Offset: 0x0001C9CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 985903, RefRangeEnd = 985904, XrefRangeStart = 985903, XrefRangeEnd = 985904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001E808 File Offset: 0x0001CA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ContinueOrHide_b__37_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.NativeMethodInfoPtr__ContinueOrHide_b__37_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001E83C File Offset: 0x0001CA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ContinueOrGoto_b__38_0<T>() where T : DialogRenderer
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer.MethodInfoStoreGeneric__ContinueOrGoto_b__38_0_Private_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000409D File Offset: 0x0000229D
		public DialogRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0001E870 File Offset: 0x0001CA70
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x000040A6 File Offset: 0x000022A6
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0001E8A0 File Offset: 0x0001CAA0
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x000040C5 File Offset: 0x000022C5
		public unsafe DialogRenderer continueTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_continueTo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_continueTo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0001E8D0 File Offset: 0x0001CAD0
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x000040E4 File Offset: 0x000022E4
		public unsafe Action postContinue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_postContinue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_postContinue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0001E900 File Offset: 0x0001CB00
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00004103 File Offset: 0x00002303
		public unsafe DialogRenderer returnTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_returnTo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_returnTo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0001E930 File Offset: 0x0001CB30
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00004122 File Offset: 0x00002322
		public unsafe bool isModal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_isModal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_isModal)) = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0001E958 File Offset: 0x0001CB58
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x0000413D File Offset: 0x0000233D
		public unsafe bool isInterstitial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_isInterstitial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_isInterstitial)) = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0001E980 File Offset: 0x0001CB80
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00004158 File Offset: 0x00002358
		public unsafe int visibleParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_visibleParam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_visibleParam)) = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0001E9A8 File Offset: 0x0001CBA8
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00004173 File Offset: 0x00002373
		public unsafe DialogRendererViewModel model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRendererViewModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0001E9D8 File Offset: 0x0001CBD8
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00004192 File Offset: 0x00002392
		public unsafe bool blockingClicks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_blockingClicks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_blockingClicks)) = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0001EA00 File Offset: 0x0001CC00
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x000041AD File Offset: 0x000023AD
		public unsafe bool canBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_canBack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer.NativeFieldInfoPtr_canBack)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0001EA28 File Offset: 0x0001CC28
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x000041C8 File Offset: 0x000023C8
		public unsafe static DialogRenderer _Top_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DialogRenderer.NativeFieldInfoPtr__Top_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRenderer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogRenderer.NativeFieldInfoPtr__Top_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr_continueTo;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr_postContinue;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr_returnTo;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr_isModal;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr_isInterstitial;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr_visibleParam;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr_model;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr_blockingClicks;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeFieldInfoPtr_canBack;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr__Top_k__BackingField;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_get_ContinueTo_Protected_get_DialogRenderer_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_get_Visible_Public_get_Boolean_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_get_Top_Public_Static_get_DialogRenderer_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_set_Top_Protected_Static_set_Void_DialogRenderer_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_IsOpen_Public_Static_Boolean_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_configureData_Protected_Void_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_addDataToModel_Protected_Virtual_New_Void_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_republish_Protected_Void_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_GetViewModel_Public_DialogRendererViewModel_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_T_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_Goto_Public_T_Boolean_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_Goto_Public_Void_DialogRenderer_Boolean_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Virtual_New_IEnumerator_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_WaitUntilHidden_Public_IEnumerator_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_ShowOnStack_Public_Virtual_New_IEnumerator_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_ThenContinueTo_Public_T_Action_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_ThenContinueTo_Public_T_T_Action_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_HideAndWait_Public_Virtual_New_IEnumerator_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_GoBack_Public_Virtual_New_Void_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_show_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_gotoInternal_Private_IEnumerator_T_Boolean_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_ContinueOrHide_Protected_Void_Boolean_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_ContinueOrGoto_Protected_Void_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_ToggleVisibility_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_ReactToBackKey_Public_Void_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_reactToBackKey_Protected_Virtual_New_Void_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr__ContinueOrHide_b__37_0_Private_Void_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr__ContinueOrGoto_b__38_0_Private_Void_0;

		// Token: 0x020001BA RID: 442
		[ObfuscatedName("zen.src.menus.DialogRenderer+<HideAndWait>d__33")]
		public sealed class _HideAndWait_d__33 : global::Il2CppSystem.Object
		{
			// Token: 0x06001538 RID: 5432 RVA: 0x000526C0 File Offset: 0x000508C0
			// Note: this type is marked as 'beforefieldinit'.
			static _HideAndWait_d__33()
			{
				Il2CppClassPointerStore<DialogRenderer._HideAndWait_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "<HideAndWait>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogRenderer._HideAndWait_d__33>.NativeClassPtr);
				DialogRenderer._HideAndWait_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._HideAndWait_d__33>.NativeClassPtr, "<>1__state");
				DialogRenderer._HideAndWait_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._HideAndWait_d__33>.NativeClassPtr, "<>2__current");
				DialogRenderer._HideAndWait_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._HideAndWait_d__33>.NativeClassPtr, "<>4__this");
				DialogRenderer._HideAndWait_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._HideAndWait_d__33>.NativeClassPtr, 100663889);
				DialogRenderer._HideAndWait_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._HideAndWait_d__33>.NativeClassPtr, 100663890);
				DialogRenderer._HideAndWait_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._HideAndWait_d__33>.NativeClassPtr, 100663891);
				DialogRenderer._HideAndWait_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._HideAndWait_d__33>.NativeClassPtr, 100663892);
				DialogRenderer._HideAndWait_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._HideAndWait_d__33>.NativeClassPtr, 100663893);
				DialogRenderer._HideAndWait_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._HideAndWait_d__33>.NativeClassPtr, 100663894);
			}

			// Token: 0x06001539 RID: 5433 RVA: 0x000527A0 File Offset: 0x000509A0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HideAndWait_d__33(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogRenderer._HideAndWait_d__33>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._HideAndWait_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600153A RID: 5434 RVA: 0x000527E8 File Offset: 0x000509E8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._HideAndWait_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600153B RID: 5435 RVA: 0x0005281C File Offset: 0x00050A1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985958, XrefRangeEnd = 985971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._HideAndWait_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x0600153C RID: 5436 RVA: 0x00052858 File Offset: 0x00050A58
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._HideAndWait_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600153D RID: 5437 RVA: 0x00052898 File Offset: 0x00050A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985971, XrefRangeEnd = 985976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._HideAndWait_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700060F RID: 1551
			// (get) Token: 0x0600153E RID: 5438 RVA: 0x000528CC File Offset: 0x00050ACC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._HideAndWait_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600153F RID: 5439 RVA: 0x0000BF20 File Offset: 0x0000A120
			public _HideAndWait_d__33(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700060B RID: 1547
			// (get) Token: 0x06001540 RID: 5440 RVA: 0x0005290C File Offset: 0x00050B0C
			// (set) Token: 0x06001541 RID: 5441 RVA: 0x0000BF29 File Offset: 0x0000A129
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._HideAndWait_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._HideAndWait_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700060C RID: 1548
			// (get) Token: 0x06001542 RID: 5442 RVA: 0x00052934 File Offset: 0x00050B34
			// (set) Token: 0x06001543 RID: 5443 RVA: 0x0000BF44 File Offset: 0x0000A144
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._HideAndWait_d__33.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._HideAndWait_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700060D RID: 1549
			// (get) Token: 0x06001544 RID: 5444 RVA: 0x00052964 File Offset: 0x00050B64
			// (set) Token: 0x06001545 RID: 5445 RVA: 0x0000BF63 File Offset: 0x0000A163
			public unsafe DialogRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._HideAndWait_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._HideAndWait_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000CD9 RID: 3289
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000CDA RID: 3290
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000CDB RID: 3291
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000CDC RID: 3292
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000CDD RID: 3293
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CDE RID: 3294
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000CDF RID: 3295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000CE0 RID: 3296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CE1 RID: 3297
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001BB RID: 443
		[ObfuscatedName("zen.src.menus.DialogRenderer+<Show>d__27")]
		public sealed class _Show_d__27 : global::Il2CppSystem.Object
		{
			// Token: 0x06001546 RID: 5446 RVA: 0x00052994 File Offset: 0x00050B94
			// Note: this type is marked as 'beforefieldinit'.
			static _Show_d__27()
			{
				Il2CppClassPointerStore<DialogRenderer._Show_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "<Show>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogRenderer._Show_d__27>.NativeClassPtr);
				DialogRenderer._Show_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._Show_d__27>.NativeClassPtr, "<>1__state");
				DialogRenderer._Show_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._Show_d__27>.NativeClassPtr, "<>2__current");
				DialogRenderer._Show_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._Show_d__27>.NativeClassPtr, "<>4__this");
				DialogRenderer._Show_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._Show_d__27>.NativeClassPtr, 100663895);
				DialogRenderer._Show_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._Show_d__27>.NativeClassPtr, 100663896);
				DialogRenderer._Show_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._Show_d__27>.NativeClassPtr, 100663897);
				DialogRenderer._Show_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._Show_d__27>.NativeClassPtr, 100663898);
				DialogRenderer._Show_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._Show_d__27>.NativeClassPtr, 100663899);
				DialogRenderer._Show_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._Show_d__27>.NativeClassPtr, 100663900);
			}

			// Token: 0x06001547 RID: 5447 RVA: 0x00052A74 File Offset: 0x00050C74
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Show_d__27(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogRenderer._Show_d__27>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._Show_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001548 RID: 5448 RVA: 0x00052ABC File Offset: 0x00050CBC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._Show_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001549 RID: 5449 RVA: 0x00052AF0 File Offset: 0x00050CF0
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._Show_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x0600154A RID: 5450 RVA: 0x00052B2C File Offset: 0x00050D2C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._Show_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600154B RID: 5451 RVA: 0x00052B6C File Offset: 0x00050D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985976, XrefRangeEnd = 985981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._Show_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000614 RID: 1556
			// (get) Token: 0x0600154C RID: 5452 RVA: 0x00052BA0 File Offset: 0x00050DA0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._Show_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600154D RID: 5453 RVA: 0x0000BF82 File Offset: 0x0000A182
			public _Show_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x0600154E RID: 5454 RVA: 0x00052BE0 File Offset: 0x00050DE0
			// (set) Token: 0x0600154F RID: 5455 RVA: 0x0000BF8B File Offset: 0x0000A18B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._Show_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._Show_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x06001550 RID: 5456 RVA: 0x00052C08 File Offset: 0x00050E08
			// (set) Token: 0x06001551 RID: 5457 RVA: 0x0000BFA6 File Offset: 0x0000A1A6
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._Show_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._Show_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x06001552 RID: 5458 RVA: 0x00052C38 File Offset: 0x00050E38
			// (set) Token: 0x06001553 RID: 5459 RVA: 0x0000BFC5 File Offset: 0x0000A1C5
			public unsafe DialogRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._Show_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._Show_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000CE2 RID: 3298
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000CE3 RID: 3299
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000CE4 RID: 3300
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000CE5 RID: 3301
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000CE6 RID: 3302
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CE7 RID: 3303
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000CE8 RID: 3304
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000CE9 RID: 3305
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CEA RID: 3306
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001BC RID: 444
		[ObfuscatedName("zen.src.menus.DialogRenderer+<ShowOnStack>d__29")]
		public sealed class _ShowOnStack_d__29 : global::Il2CppSystem.Object
		{
			// Token: 0x06001554 RID: 5460 RVA: 0x00052C68 File Offset: 0x00050E68
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowOnStack_d__29()
			{
				Il2CppClassPointerStore<DialogRenderer._ShowOnStack_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "<ShowOnStack>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogRenderer._ShowOnStack_d__29>.NativeClassPtr);
				DialogRenderer._ShowOnStack_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._ShowOnStack_d__29>.NativeClassPtr, "<>1__state");
				DialogRenderer._ShowOnStack_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._ShowOnStack_d__29>.NativeClassPtr, "<>2__current");
				DialogRenderer._ShowOnStack_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._ShowOnStack_d__29>.NativeClassPtr, "<>4__this");
				DialogRenderer._ShowOnStack_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._ShowOnStack_d__29>.NativeClassPtr, 100663901);
				DialogRenderer._ShowOnStack_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._ShowOnStack_d__29>.NativeClassPtr, 100663902);
				DialogRenderer._ShowOnStack_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._ShowOnStack_d__29>.NativeClassPtr, 100663903);
				DialogRenderer._ShowOnStack_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._ShowOnStack_d__29>.NativeClassPtr, 100663904);
				DialogRenderer._ShowOnStack_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._ShowOnStack_d__29>.NativeClassPtr, 100663905);
				DialogRenderer._ShowOnStack_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._ShowOnStack_d__29>.NativeClassPtr, 100663906);
			}

			// Token: 0x06001555 RID: 5461 RVA: 0x00052D48 File Offset: 0x00050F48
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowOnStack_d__29(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogRenderer._ShowOnStack_d__29>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._ShowOnStack_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001556 RID: 5462 RVA: 0x00052D90 File Offset: 0x00050F90
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._ShowOnStack_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001557 RID: 5463 RVA: 0x00052DC4 File Offset: 0x00050FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985981, XrefRangeEnd = 985983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._ShowOnStack_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x06001558 RID: 5464 RVA: 0x00052E00 File Offset: 0x00051000
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._ShowOnStack_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001559 RID: 5465 RVA: 0x00052E40 File Offset: 0x00051040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985983, XrefRangeEnd = 985988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._ShowOnStack_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x0600155A RID: 5466 RVA: 0x00052E74 File Offset: 0x00051074
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._ShowOnStack_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600155B RID: 5467 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
			public _ShowOnStack_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x0600155C RID: 5468 RVA: 0x00052EB4 File Offset: 0x000510B4
			// (set) Token: 0x0600155D RID: 5469 RVA: 0x0000BFED File Offset: 0x0000A1ED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._ShowOnStack_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._ShowOnStack_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x0600155E RID: 5470 RVA: 0x00052EDC File Offset: 0x000510DC
			// (set) Token: 0x0600155F RID: 5471 RVA: 0x0000C008 File Offset: 0x0000A208
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._ShowOnStack_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._ShowOnStack_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x06001560 RID: 5472 RVA: 0x00052F0C File Offset: 0x0005110C
			// (set) Token: 0x06001561 RID: 5473 RVA: 0x0000C027 File Offset: 0x0000A227
			public unsafe DialogRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._ShowOnStack_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._ShowOnStack_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000CEB RID: 3307
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000CEC RID: 3308
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000CED RID: 3309
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000CEE RID: 3310
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000CEF RID: 3311
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CF0 RID: 3312
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000CF1 RID: 3313
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000CF2 RID: 3314
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CF3 RID: 3315
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001BD RID: 445
		[ObfuscatedName("zen.src.menus.DialogRenderer+<WaitUntilHidden>d__28")]
		public sealed class _WaitUntilHidden_d__28 : global::Il2CppSystem.Object
		{
			// Token: 0x06001562 RID: 5474 RVA: 0x00052F3C File Offset: 0x0005113C
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitUntilHidden_d__28()
			{
				Il2CppClassPointerStore<DialogRenderer._WaitUntilHidden_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "<WaitUntilHidden>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogRenderer._WaitUntilHidden_d__28>.NativeClassPtr);
				DialogRenderer._WaitUntilHidden_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._WaitUntilHidden_d__28>.NativeClassPtr, "<>1__state");
				DialogRenderer._WaitUntilHidden_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._WaitUntilHidden_d__28>.NativeClassPtr, "<>2__current");
				DialogRenderer._WaitUntilHidden_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._WaitUntilHidden_d__28>.NativeClassPtr, "<>4__this");
				DialogRenderer._WaitUntilHidden_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._WaitUntilHidden_d__28>.NativeClassPtr, 100663907);
				DialogRenderer._WaitUntilHidden_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._WaitUntilHidden_d__28>.NativeClassPtr, 100663908);
				DialogRenderer._WaitUntilHidden_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._WaitUntilHidden_d__28>.NativeClassPtr, 100663909);
				DialogRenderer._WaitUntilHidden_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._WaitUntilHidden_d__28>.NativeClassPtr, 100663910);
				DialogRenderer._WaitUntilHidden_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._WaitUntilHidden_d__28>.NativeClassPtr, 100663911);
				DialogRenderer._WaitUntilHidden_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._WaitUntilHidden_d__28>.NativeClassPtr, 100663912);
			}

			// Token: 0x06001563 RID: 5475 RVA: 0x0005301C File Offset: 0x0005121C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitUntilHidden_d__28(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogRenderer._WaitUntilHidden_d__28>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._WaitUntilHidden_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001564 RID: 5476 RVA: 0x00053064 File Offset: 0x00051264
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._WaitUntilHidden_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001565 RID: 5477 RVA: 0x00053098 File Offset: 0x00051298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985988, XrefRangeEnd = 985989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._WaitUntilHidden_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x06001566 RID: 5478 RVA: 0x000530D4 File Offset: 0x000512D4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._WaitUntilHidden_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001567 RID: 5479 RVA: 0x00053114 File Offset: 0x00051314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985989, XrefRangeEnd = 985994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._WaitUntilHidden_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x06001568 RID: 5480 RVA: 0x00053148 File Offset: 0x00051348
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._WaitUntilHidden_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001569 RID: 5481 RVA: 0x0000C046 File Offset: 0x0000A246
			public _WaitUntilHidden_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x0600156A RID: 5482 RVA: 0x00053188 File Offset: 0x00051388
			// (set) Token: 0x0600156B RID: 5483 RVA: 0x0000C04F File Offset: 0x0000A24F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._WaitUntilHidden_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._WaitUntilHidden_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x0600156C RID: 5484 RVA: 0x000531B0 File Offset: 0x000513B0
			// (set) Token: 0x0600156D RID: 5485 RVA: 0x0000C06A File Offset: 0x0000A26A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._WaitUntilHidden_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._WaitUntilHidden_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x0600156E RID: 5486 RVA: 0x000531E0 File Offset: 0x000513E0
			// (set) Token: 0x0600156F RID: 5487 RVA: 0x0000C089 File Offset: 0x0000A289
			public unsafe DialogRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._WaitUntilHidden_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._WaitUntilHidden_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000CF4 RID: 3316
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000CF5 RID: 3317
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000CF6 RID: 3318
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000CF7 RID: 3319
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000CF8 RID: 3320
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CF9 RID: 3321
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000CFA RID: 3322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000CFB RID: 3323
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CFC RID: 3324
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001BE RID: 446
		[ObfuscatedName("zen.src.menus.DialogRenderer+<gotoInternal>d__36`1")]
		public sealed class _gotoInternal_d__36<T> : global::Il2CppSystem.Object where T : DialogRenderer
		{
			// Token: 0x06001570 RID: 5488 RVA: 0x00053210 File Offset: 0x00051410
			// Note: this type is marked as 'beforefieldinit'.
			static _gotoInternal_d__36()
			{
				Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "<gotoInternal>d__36`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr);
				DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr, "<>1__state");
				DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr, "<>2__current");
				DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr, "<>4__this");
				DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr_setReturnTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr, "setReturnTo");
				DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr_dialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr, "dialog");
				DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr__shield_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr, "<shield>5__2");
				DialogRenderer._gotoInternal_d__36<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr, 100663913);
				DialogRenderer._gotoInternal_d__36<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr, 100663914);
				DialogRenderer._gotoInternal_d__36<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr, 100663915);
				DialogRenderer._gotoInternal_d__36<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr, 100663916);
				DialogRenderer._gotoInternal_d__36<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr, 100663917);
				DialogRenderer._gotoInternal_d__36<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr, 100663918);
			}

			// Token: 0x06001571 RID: 5489 RVA: 0x00053368 File Offset: 0x00051568
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _gotoInternal_d__36(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogRenderer._gotoInternal_d__36<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._gotoInternal_d__36<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001572 RID: 5490 RVA: 0x000533B0 File Offset: 0x000515B0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._gotoInternal_d__36<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001573 RID: 5491 RVA: 0x000533E4 File Offset: 0x000515E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985994, XrefRangeEnd = 986002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._gotoInternal_d__36<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x06001574 RID: 5492 RVA: 0x00053420 File Offset: 0x00051620
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._gotoInternal_d__36<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001575 RID: 5493 RVA: 0x00053460 File Offset: 0x00051660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._gotoInternal_d__36<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x06001576 RID: 5494 RVA: 0x00053494 File Offset: 0x00051694
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._gotoInternal_d__36<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001577 RID: 5495 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
			public _gotoInternal_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x06001578 RID: 5496 RVA: 0x000534D4 File Offset: 0x000516D4
			// (set) Token: 0x06001579 RID: 5497 RVA: 0x0000C0B1 File Offset: 0x0000A2B1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x0600157A RID: 5498 RVA: 0x000534FC File Offset: 0x000516FC
			// (set) Token: 0x0600157B RID: 5499 RVA: 0x0000C0CC File Offset: 0x0000A2CC
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x0600157C RID: 5500 RVA: 0x0005352C File Offset: 0x0005172C
			// (set) Token: 0x0600157D RID: 5501 RVA: 0x0000C0EB File Offset: 0x0000A2EB
			public unsafe DialogRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x0600157E RID: 5502 RVA: 0x0005355C File Offset: 0x0005175C
			// (set) Token: 0x0600157F RID: 5503 RVA: 0x0000C10A File Offset: 0x0000A30A
			public unsafe bool setReturnTo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr_setReturnTo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr_setReturnTo)) = value;
				}
			}

			// Token: 0x17000623 RID: 1571
			// (get) Token: 0x06001580 RID: 5504 RVA: 0x00053584 File Offset: 0x00051784
			// (set) Token: 0x06001581 RID: 5505 RVA: 0x000535AC File Offset: 0x000517AC
			public unsafe T dialog
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr_dialog);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr_dialog);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x06001582 RID: 5506 RVA: 0x00053654 File Offset: 0x00051854
			// (set) Token: 0x06001583 RID: 5507 RVA: 0x0000C125 File Offset: 0x0000A325
			public unsafe ClickShield _shield_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr__shield_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClickShield>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._gotoInternal_d__36<T>.NativeFieldInfoPtr__shield_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000CFD RID: 3325
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000CFE RID: 3326
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000CFF RID: 3327
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D00 RID: 3328
			private static readonly IntPtr NativeFieldInfoPtr_setReturnTo;

			// Token: 0x04000D01 RID: 3329
			private static readonly IntPtr NativeFieldInfoPtr_dialog;

			// Token: 0x04000D02 RID: 3330
			private static readonly IntPtr NativeFieldInfoPtr__shield_5__2;

			// Token: 0x04000D03 RID: 3331
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D04 RID: 3332
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D05 RID: 3333
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D06 RID: 3334
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D07 RID: 3335
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D08 RID: 3336
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001BF RID: 447
		[ObfuscatedName("zen.src.menus.DialogRenderer+<show>d__35")]
		public sealed class _show_d__35 : global::Il2CppSystem.Object
		{
			// Token: 0x06001584 RID: 5508 RVA: 0x00053684 File Offset: 0x00051884
			// Note: this type is marked as 'beforefieldinit'.
			static _show_d__35()
			{
				Il2CppClassPointerStore<DialogRenderer._show_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr, "<show>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogRenderer._show_d__35>.NativeClassPtr);
				DialogRenderer._show_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._show_d__35>.NativeClassPtr, "<>1__state");
				DialogRenderer._show_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogRenderer._show_d__35>.NativeClassPtr, "<>2__current");
				DialogRenderer._show_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._show_d__35>.NativeClassPtr, 100663919);
				DialogRenderer._show_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._show_d__35>.NativeClassPtr, 100663920);
				DialogRenderer._show_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._show_d__35>.NativeClassPtr, 100663921);
				DialogRenderer._show_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._show_d__35>.NativeClassPtr, 100663922);
				DialogRenderer._show_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._show_d__35>.NativeClassPtr, 100663923);
				DialogRenderer._show_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogRenderer._show_d__35>.NativeClassPtr, 100663924);
			}

			// Token: 0x06001585 RID: 5509 RVA: 0x00053750 File Offset: 0x00051950
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _show_d__35(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogRenderer._show_d__35>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._show_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001586 RID: 5510 RVA: 0x00053798 File Offset: 0x00051998
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._show_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001587 RID: 5511 RVA: 0x000537CC File Offset: 0x000519CC
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._show_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x06001588 RID: 5512 RVA: 0x00053808 File Offset: 0x00051A08
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._show_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001589 RID: 5513 RVA: 0x00053848 File Offset: 0x00051A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986002, XrefRangeEnd = 986007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._show_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x0600158A RID: 5514 RVA: 0x0005387C File Offset: 0x00051A7C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogRenderer._show_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600158B RID: 5515 RVA: 0x0000C144 File Offset: 0x0000A344
			public _show_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x0600158C RID: 5516 RVA: 0x000538BC File Offset: 0x00051ABC
			// (set) Token: 0x0600158D RID: 5517 RVA: 0x0000C14D File Offset: 0x0000A34D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._show_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._show_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x0600158E RID: 5518 RVA: 0x000538E4 File Offset: 0x00051AE4
			// (set) Token: 0x0600158F RID: 5519 RVA: 0x0000C168 File Offset: 0x0000A368
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._show_d__35.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogRenderer._show_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D09 RID: 3337
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D0A RID: 3338
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D0B RID: 3339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D0C RID: 3340
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D0D RID: 3341
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D0E RID: 3342
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D0F RID: 3343
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D10 RID: 3344
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001C0 RID: 448
		private sealed class MethodInfoStoreGeneric_IsOpen_Public_Static_Boolean_0<T>
		{
			// Token: 0x04000D11 RID: 3345
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DialogRenderer.NativeMethodInfoPtr_IsOpen_Public_Static_Boolean_0, Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001C1 RID: 449
		private sealed class MethodInfoStoreGeneric_Push_Public_T_0<T>
		{
			// Token: 0x04000D12 RID: 3346
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DialogRenderer.NativeMethodInfoPtr_Push_Public_T_0, Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001C2 RID: 450
		private sealed class MethodInfoStoreGeneric_Goto_Public_T_Boolean_0<T>
		{
			// Token: 0x04000D13 RID: 3347
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DialogRenderer.NativeMethodInfoPtr_Goto_Public_T_Boolean_0, Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001C3 RID: 451
		private sealed class MethodInfoStoreGeneric_ThenContinueTo_Public_T_Action_0<T>
		{
			// Token: 0x04000D14 RID: 3348
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DialogRenderer.NativeMethodInfoPtr_ThenContinueTo_Public_T_Action_0, Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001C4 RID: 452
		private sealed class MethodInfoStoreGeneric_ThenContinueTo_Public_T_T_Action_0<T>
		{
			// Token: 0x04000D15 RID: 3349
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DialogRenderer.NativeMethodInfoPtr_ThenContinueTo_Public_T_T_Action_0, Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001C5 RID: 453
		private sealed class MethodInfoStoreGeneric_gotoInternal_Private_IEnumerator_T_Boolean_0<T>
		{
			// Token: 0x04000D16 RID: 3350
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DialogRenderer.NativeMethodInfoPtr_gotoInternal_Private_IEnumerator_T_Boolean_0, Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001C6 RID: 454
		private sealed class MethodInfoStoreGeneric_ContinueOrGoto_Protected_Void_0<T>
		{
			// Token: 0x04000D17 RID: 3351
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DialogRenderer.NativeMethodInfoPtr_ContinueOrGoto_Protected_Void_0, Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001C7 RID: 455
		private sealed class MethodInfoStoreGeneric__ContinueOrGoto_b__38_0_Private_Void_0<T>
		{
			// Token: 0x04000D18 RID: 3352
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DialogRenderer.NativeMethodInfoPtr__ContinueOrGoto_b__38_0_Private_Void_0, Il2CppClassPointerStore<DialogRenderer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
