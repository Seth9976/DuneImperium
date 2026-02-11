using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dwd.core.input.compositeModule.navigation
{
	// Token: 0x02000093 RID: 147
	public sealed class AxialSelectionNavigator : SelectionNavigator
	{
		// Token: 0x06000640 RID: 1600 RVA: 0x0001AB30 File Offset: 0x00018D30
		// Note: this type is marked as 'beforefieldinit'.
		static AxialSelectionNavigator()
		{
			Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.navigation", "AxialSelectionNavigator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr);
			AxialSelectionNavigator.NativeFieldInfoPtr_horizontalMoveAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "horizontalMoveAxis");
			AxialSelectionNavigator.NativeFieldInfoPtr_verticalMoveAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "verticalMoveAxis");
			AxialSelectionNavigator.NativeFieldInfoPtr_repeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "repeatDelay");
			AxialSelectionNavigator.NativeFieldInfoPtr_navActionsAllowedPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "navActionsAllowedPerSecond");
			AxialSelectionNavigator.NativeFieldInfoPtr_navVectorDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "navVectorDeadzone");
			AxialSelectionNavigator.NativeFieldInfoPtr_navVectorDotThreshhold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "navVectorDotThreshhold");
			AxialSelectionNavigator.NativeFieldInfoPtr_preferCardinalDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "preferCardinalDirections");
			AxialSelectionNavigator.NativeFieldInfoPtr_consecutiveMoveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "consecutiveMoveCount");
			AxialSelectionNavigator.NativeFieldInfoPtr_lastMoveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "lastMoveVector");
			AxialSelectionNavigator.NativeFieldInfoPtr_lastSelectedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "lastSelectedPosition");
			AxialSelectionNavigator.NativeFieldInfoPtr_prevActionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "prevActionTime");
			AxialSelectionNavigator.NativeFieldInfoPtr_onScreenKeyboardBlocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "onScreenKeyboardBlocking");
			AxialSelectionNavigator.NativeFieldInfoPtr_showLastNavigationGizmosInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "showLastNavigationGizmosInEditor");
			AxialSelectionNavigator.NativeFieldInfoPtr_fastAndRectless = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "fastAndRectless");
			AxialSelectionNavigator.NativeFieldInfoPtr_navCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "navCamera");
			AxialSelectionNavigator.NativeMethodInfoPtr_get_RepeatDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664070);
			AxialSelectionNavigator.NativeMethodInfoPtr_get_PreferCardinalDirections_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664071);
			AxialSelectionNavigator.NativeMethodInfoPtr_set_PreferCardinalDirections_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664072);
			AxialSelectionNavigator.NativeMethodInfoPtr_get_FastAndRectless_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664073);
			AxialSelectionNavigator.NativeMethodInfoPtr_set_FastAndRectless_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664074);
			AxialSelectionNavigator.NativeMethodInfoPtr_get_NavCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664075);
			AxialSelectionNavigator.NativeMethodInfoPtr_GetSelectionNavigation_Public_Virtual_Boolean_InputDetector_Selectable_ICollection_1_Selectable_byref_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664076);
			AxialSelectionNavigator.NativeMethodInfoPtr_getTransformScreenPosition_Private_Vector2_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664077);
			AxialSelectionNavigator.NativeMethodInfoPtr_getMoveInputVector_Private_Vector2_InputDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664078);
			AxialSelectionNavigator.NativeMethodInfoPtr_shouldAllowMovement_Private_Boolean_InputDetector_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664079);
			AxialSelectionNavigator.NativeMethodInfoPtr_isSelectableValidForNavigation_Private_Static_Boolean_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664080);
			AxialSelectionNavigator.NativeMethodInfoPtr_findSelectable_Private_Boolean_Selectable_Vector2_MoveDirection_ICollection_1_Selectable_byref_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664081);
			AxialSelectionNavigator.NativeMethodInfoPtr_convertToCardinalDirection_Private_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664082);
			AxialSelectionNavigator.NativeMethodInfoPtr_findExplicitNavSelectable_Private_Static_Selectable_Selectable_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664083);
			AxialSelectionNavigator.NativeMethodInfoPtr_findBestSelectableInDirection_Private_Boolean_Transform_Vector2_ICollection_1_Selectable_byref_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664084);
			AxialSelectionNavigator.NativeMethodInfoPtr_GetCenterAndExtents_Private_Boolean_Transform_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664085);
			AxialSelectionNavigator.NativeMethodInfoPtr_determineMoveDirection_Private_Static_MoveDirection_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664086);
			AxialSelectionNavigator.NativeMethodInfoPtr_SetContextCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664087);
			AxialSelectionNavigator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664088);
			AxialSelectionNavigator.NativeMethodInfoPtr__GetSelectionNavigation_b__25_0_Private_Single_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, 100664089);
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x0001AE1C File Offset: 0x0001901C
		public unsafe float RepeatDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_get_RepeatDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0001AE58 File Offset: 0x00019058
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x0001AE94 File Offset: 0x00019094
		public unsafe bool PreferCardinalDirections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_get_PreferCardinalDirections_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_set_PreferCardinalDirections_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0001AED4 File Offset: 0x000190D4
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x0001AF10 File Offset: 0x00019110
		public unsafe bool FastAndRectless
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_get_FastAndRectless_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_set_FastAndRectless_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x0001AF50 File Offset: 0x00019150
		public unsafe Camera NavCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_get_NavCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0001AF90 File Offset: 0x00019190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125289, XrefRangeEnd = 1125320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetSelectionNavigation(InputDetector inputDetector, Selectable currentSelection, ICollection<Selectable> validSelectables, out Selectable newSelection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentSelection);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validSelectables);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_GetSelectionNavigation_Public_Virtual_Boolean_InputDetector_Selectable_ICollection_1_Selectable_byref_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			newSelection = ((intPtr4 == 0) ? null : new Selectable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0001B028 File Offset: 0x00019228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1125345, RefRangeEnd = 1125347, XrefRangeStart = 1125320, XrefRangeEnd = 1125345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 getTransformScreenPosition(Selectable selectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_getTransformScreenPosition_Private_Vector2_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0001B078 File Offset: 0x00019278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1125358, RefRangeEnd = 1125359, XrefRangeStart = 1125347, XrefRangeEnd = 1125358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 getMoveInputVector(InputDetector inputDetector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_getMoveInputVector_Private_Vector2_InputDetector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0001B0C8 File Offset: 0x000192C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125359, XrefRangeEnd = 1125360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool shouldAllowMovement(InputDetector inputDetector, bool isSimilarMovementDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSimilarMovementDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_shouldAllowMovement_Private_Boolean_InputDetector_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0001B124 File Offset: 0x00019324
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1125371, RefRangeEnd = 1125374, XrefRangeStart = 1125360, XrefRangeEnd = 1125371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isSelectableValidForNavigation(Selectable selectable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_isSelectableValidForNavigation_Private_Static_Boolean_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0001B168 File Offset: 0x00019368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1125384, RefRangeEnd = 1125385, XrefRangeStart = 1125374, XrefRangeEnd = 1125384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool findSelectable(Selectable sourceSelectable, Vector2 navVector, MoveDirection navDirection, ICollection<Selectable> validSelectables, out Selectable foundSelectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceSelectable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref navVector;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref navDirection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validSelectables);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_findSelectable_Private_Boolean_Selectable_Vector2_MoveDirection_ICollection_1_Selectable_byref_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			foundSelectable = ((intPtr4 == 0) ? null : new Selectable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0001B208 File Offset: 0x00019408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125385, XrefRangeEnd = 1125387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 convertToCardinalDirection(Vector2 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_convertToCardinalDirection_Private_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0001B254 File Offset: 0x00019454
		[CallerCount(0)]
		public unsafe static Selectable findExplicitNavSelectable(Selectable sourceSelectable, MoveDirection navDirection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceSelectable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref navDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_findExplicitNavSelectable_Private_Static_Selectable_Selectable_MoveDirection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0001B2A8 File Offset: 0x000194A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125387, XrefRangeEnd = 1125540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool findBestSelectableInDirection(Transform sourceTransform, Vector2 screenDirection, ICollection<Selectable> validSelectables, out Selectable foundSelectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenDirection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validSelectables);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_findBestSelectableInDirection_Private_Boolean_Transform_Vector2_ICollection_1_Selectable_byref_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			foundSelectable = ((intPtr4 == 0) ? null : new Selectable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0001B33C File Offset: 0x0001953C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1125557, RefRangeEnd = 1125560, XrefRangeStart = 1125540, XrefRangeEnd = 1125557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCenterAndExtents(Transform obj, out Vector3 objCenter, out Vector3 objExtents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &objCenter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &objExtents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_GetCenterAndExtents_Private_Boolean_Transform_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0001B3A8 File Offset: 0x000195A8
		[CallerCount(0)]
		public unsafe static MoveDirection determineMoveDirection(Vector2 moveVector, float deadZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveVector;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_determineMoveDirection_Private_Static_MoveDirection_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0001B3F4 File Offset: 0x000195F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContextCamera(Camera contextCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contextCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr_SetContextCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0001B438 File Offset: 0x00019638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125560, XrefRangeEnd = 1125575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AxialSelectionNavigator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0001B474 File Offset: 0x00019674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125575, XrefRangeEnd = 1125576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _GetSelectionNavigation_b__25_0(Selectable sel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AxialSelectionNavigator.NativeMethodInfoPtr__GetSelectionNavigation_b__25_0_Private_Single_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00005666 File Offset: 0x00003866
		public AxialSelectionNavigator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0001B4C4 File Offset: 0x000196C4
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x0000566F File Offset: 0x0000386F
		public unsafe string horizontalMoveAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_horizontalMoveAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_horizontalMoveAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0001B4EC File Offset: 0x000196EC
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x0000568E File Offset: 0x0000388E
		public unsafe string verticalMoveAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_verticalMoveAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_verticalMoveAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0001B514 File Offset: 0x00019714
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x000056AD File Offset: 0x000038AD
		public unsafe float repeatDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_repeatDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_repeatDelay)) = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0001B53C File Offset: 0x0001973C
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x000056C8 File Offset: 0x000038C8
		public unsafe float navActionsAllowedPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_navActionsAllowedPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_navActionsAllowedPerSecond)) = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0001B564 File Offset: 0x00019764
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x000056E3 File Offset: 0x000038E3
		public unsafe float navVectorDeadzone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_navVectorDeadzone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_navVectorDeadzone)) = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0001B58C File Offset: 0x0001978C
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x000056FE File Offset: 0x000038FE
		public unsafe float navVectorDotThreshhold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_navVectorDotThreshhold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_navVectorDotThreshhold)) = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0001B5B4 File Offset: 0x000197B4
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00005719 File Offset: 0x00003919
		public unsafe bool preferCardinalDirections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_preferCardinalDirections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_preferCardinalDirections)) = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x0001B5DC File Offset: 0x000197DC
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00005734 File Offset: 0x00003934
		public unsafe int consecutiveMoveCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_consecutiveMoveCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_consecutiveMoveCount)) = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0001B604 File Offset: 0x00019804
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x0000574F File Offset: 0x0000394F
		public unsafe Vector2 lastMoveVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_lastMoveVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_lastMoveVector)) = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x0001B62C File Offset: 0x0001982C
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x0000576A File Offset: 0x0000396A
		public unsafe Vector2 lastSelectedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_lastSelectedPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_lastSelectedPosition)) = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0001B654 File Offset: 0x00019854
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00005785 File Offset: 0x00003985
		public unsafe float prevActionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_prevActionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_prevActionTime)) = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x0001B67C File Offset: 0x0001987C
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x000057A0 File Offset: 0x000039A0
		public unsafe bool onScreenKeyboardBlocking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_onScreenKeyboardBlocking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_onScreenKeyboardBlocking)) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0001B6A4 File Offset: 0x000198A4
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x000057BB File Offset: 0x000039BB
		public unsafe bool showLastNavigationGizmosInEditor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_showLastNavigationGizmosInEditor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_showLastNavigationGizmosInEditor)) = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0001B6CC File Offset: 0x000198CC
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x000057D6 File Offset: 0x000039D6
		public unsafe bool fastAndRectless
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_fastAndRectless);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_fastAndRectless)) = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0001B6F4 File Offset: 0x000198F4
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x000057F1 File Offset: 0x000039F1
		public unsafe Camera navCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_navCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AxialSelectionNavigator.NativeFieldInfoPtr_navCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeFieldInfoPtr_horizontalMoveAxis;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_verticalMoveAxis;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_repeatDelay;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_navActionsAllowedPerSecond;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_navVectorDeadzone;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_navVectorDotThreshhold;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_preferCardinalDirections;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_consecutiveMoveCount;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_lastMoveVector;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_lastSelectedPosition;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_prevActionTime;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_onScreenKeyboardBlocking;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_showLastNavigationGizmosInEditor;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_fastAndRectless;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_navCamera;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_get_RepeatDelay_Public_get_Single_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_get_PreferCardinalDirections_Public_get_Boolean_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_set_PreferCardinalDirections_Public_set_Void_Boolean_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_get_FastAndRectless_Public_get_Boolean_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_set_FastAndRectless_Public_set_Void_Boolean_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_get_NavCamera_Public_get_Camera_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionNavigation_Public_Virtual_Boolean_InputDetector_Selectable_ICollection_1_Selectable_byref_Selectable_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_getTransformScreenPosition_Private_Vector2_Selectable_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_getMoveInputVector_Private_Vector2_InputDetector_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_shouldAllowMovement_Private_Boolean_InputDetector_Boolean_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_isSelectableValidForNavigation_Private_Static_Boolean_Selectable_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_findSelectable_Private_Boolean_Selectable_Vector2_MoveDirection_ICollection_1_Selectable_byref_Selectable_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_convertToCardinalDirection_Private_Vector2_Vector2_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_findExplicitNavSelectable_Private_Static_Selectable_Selectable_MoveDirection_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_findBestSelectableInDirection_Private_Boolean_Transform_Vector2_ICollection_1_Selectable_byref_Selectable_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_GetCenterAndExtents_Private_Boolean_Transform_byref_Vector3_byref_Vector3_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_determineMoveDirection_Private_Static_MoveDirection_Vector2_Single_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_SetContextCamera_Public_Void_Camera_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr__GetSelectionNavigation_b__25_0_Private_Single_Selectable_0;

		// Token: 0x020000DB RID: 219
		[ObfuscatedName("dwd.core.input.compositeModule.navigation.AxialSelectionNavigator+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x060009AE RID: 2478 RVA: 0x00007050 File Offset: 0x00005250
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<AxialSelectionNavigator.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AxialSelectionNavigator>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxialSelectionNavigator.__O>.NativeClassPtr);
				AxialSelectionNavigator.__O.NativeFieldInfoPtr__0___isSelectableValidForNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxialSelectionNavigator.__O>.NativeClassPtr, "<0>__isSelectableValidForNavigation");
			}

			// Token: 0x060009AF RID: 2479 RVA: 0x00007084 File Offset: 0x00005284
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002D1 RID: 721
			// (get) Token: 0x060009B0 RID: 2480 RVA: 0x00026140 File Offset: 0x00024340
			// (set) Token: 0x060009B1 RID: 2481 RVA: 0x0000708D File Offset: 0x0000528D
			public unsafe static Func<Selectable, bool> _0___isSelectableValidForNavigation
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AxialSelectionNavigator.__O.NativeFieldInfoPtr__0___isSelectableValidForNavigation, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Selectable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AxialSelectionNavigator.__O.NativeFieldInfoPtr__0___isSelectableValidForNavigation, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005FC RID: 1532
			private static readonly IntPtr NativeFieldInfoPtr__0___isSelectableValidForNavigation;
		}
	}
}
