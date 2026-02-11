using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200001C RID: 28
	public class AnimatorOverrideController : RuntimeAnimatorController
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0000E8FC File Offset: 0x0000CAFC
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorOverrideController()
		{
			Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorOverrideController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr);
			AnimatorOverrideController.NativeFieldInfoPtr_OnOverrideControllerDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, "OnOverrideControllerDirty");
			AnimatorOverrideController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663699);
			AnimatorOverrideController.NativeMethodInfoPtr__ctor_Public_Void_RuntimeAnimatorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663700);
			AnimatorOverrideController.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_AnimatorOverrideController_RuntimeAnimatorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663701);
			AnimatorOverrideController.NativeMethodInfoPtr_get_runtimeAnimatorController_Public_get_RuntimeAnimatorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663702);
			AnimatorOverrideController.NativeMethodInfoPtr_set_runtimeAnimatorController_Public_set_Void_RuntimeAnimatorController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663703);
			AnimatorOverrideController.NativeMethodInfoPtr_get_Item_Public_get_AnimationClip_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663704);
			AnimatorOverrideController.NativeMethodInfoPtr_set_Item_Public_set_Void_String_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663705);
			AnimatorOverrideController.NativeMethodInfoPtr_Internal_GetClipByName_Private_AnimationClip_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663706);
			AnimatorOverrideController.NativeMethodInfoPtr_Internal_SetClipByName_Private_Void_String_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663707);
			AnimatorOverrideController.NativeMethodInfoPtr_get_Item_Public_get_AnimationClip_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663708);
			AnimatorOverrideController.NativeMethodInfoPtr_set_Item_Public_set_Void_AnimationClip_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663709);
			AnimatorOverrideController.NativeMethodInfoPtr_GetClip_Private_AnimationClip_AnimationClip_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663710);
			AnimatorOverrideController.NativeMethodInfoPtr_SetClip_Private_Void_AnimationClip_AnimationClip_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663711);
			AnimatorOverrideController.NativeMethodInfoPtr_SendNotification_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663712);
			AnimatorOverrideController.NativeMethodInfoPtr_GetOriginalClip_Private_AnimationClip_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663713);
			AnimatorOverrideController.NativeMethodInfoPtr_GetOverrideClip_Private_AnimationClip_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663714);
			AnimatorOverrideController.NativeMethodInfoPtr_get_overridesCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663715);
			AnimatorOverrideController.NativeMethodInfoPtr_GetOverrides_Public_Void_List_1_KeyValuePair_2_AnimationClip_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663716);
			AnimatorOverrideController.NativeMethodInfoPtr_ApplyOverrides_Public_Void_IList_1_KeyValuePair_2_AnimationClip_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663717);
			AnimatorOverrideController.NativeMethodInfoPtr_get_clips_Public_get_Il2CppReferenceArray_1_AnimationClipPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663718);
			AnimatorOverrideController.NativeMethodInfoPtr_set_clips_Public_set_Void_Il2CppReferenceArray_1_AnimationClipPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663719);
			AnimatorOverrideController.NativeMethodInfoPtr_PerformOverrideClipListCleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663720);
			AnimatorOverrideController.NativeMethodInfoPtr_OnInvalidateOverrideController_Internal_Static_Void_AnimatorOverrideController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663721);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000EB0C File Offset: 0x0000CD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220708, XrefRangeEnd = 1220715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatorOverrideController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000EB48 File Offset: 0x0000CD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220715, XrefRangeEnd = 1220722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatorOverrideController(RuntimeAnimatorController controller)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr__ctor_Public_Void_RuntimeAnimatorController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000EB94 File Offset: 0x0000CD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220722, XrefRangeEnd = 1220724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controller);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_AnimatorOverrideController_RuntimeAnimatorController_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000EBDC File Offset: 0x0000CDDC
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0000EC1C File Offset: 0x0000CE1C
		public unsafe RuntimeAnimatorController runtimeAnimatorController
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220724, XrefRangeEnd = 1220726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_get_runtimeAnimatorController_Public_get_RuntimeAnimatorController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220726, XrefRangeEnd = 1220728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_set_runtimeAnimatorController_Public_set_Void_RuntimeAnimatorController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		public unsafe AnimationClip this[string name]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220728, XrefRangeEnd = 1220730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_get_Item_Public_get_AnimationClip_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220730, XrefRangeEnd = 1220732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_set_Item_Public_set_Void_String_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000ED04 File Offset: 0x0000CF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220732, XrefRangeEnd = 1220734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnEffectiveClip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_Internal_GetClipByName_Private_AnimationClip_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000ED64 File Offset: 0x0000CF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_SetClipByName(string name, AnimationClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_Internal_SetClipByName_Private_Void_String_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000098 RID: 152
		public unsafe AnimationClip this[AnimationClip clip]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220734, XrefRangeEnd = 1220736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_get_Item_Public_get_AnimationClip_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220736, XrefRangeEnd = 1220738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_set_Item_Public_set_Void_AnimationClip_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000EE5C File Offset: 0x0000D05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220738, XrefRangeEnd = 1220740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalClip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnEffectiveClip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_GetClip_Private_AnimationClip_AnimationClip_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000EEBC File Offset: 0x0000D0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220740, XrefRangeEnd = 1220742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalClip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideClip);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_SetClip_Private_Void_AnimationClip_AnimationClip_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000EF20 File Offset: 0x0000D120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220742, XrefRangeEnd = 1220744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_SendNotification_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000EF54 File Offset: 0x0000D154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220744, XrefRangeEnd = 1220746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationClip GetOriginalClip(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_GetOriginalClip_Private_AnimationClip_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220746, XrefRangeEnd = 1220748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationClip GetOverrideClip(AnimationClip originalClip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalClip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_GetOverrideClip_Private_AnimationClip_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000EFF0 File Offset: 0x0000D1F0
		public unsafe int overridesCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220748, XrefRangeEnd = 1220750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_get_overridesCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000F02C File Offset: 0x0000D22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220750, XrefRangeEnd = 1220772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(overrides);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_GetOverrides_Public_Void_List_1_KeyValuePair_2_AnimationClip_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000F070 File Offset: 0x0000D270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220772, XrefRangeEnd = 1220796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(overrides);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_ApplyOverrides_Public_Void_IList_1_KeyValuePair_2_AnimationClip_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000F0B4 File Offset: 0x0000D2B4
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0000F0F4 File Offset: 0x0000D2F4
		public unsafe Il2CppReferenceArray<AnimationClipPair> clips
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220796, XrefRangeEnd = 1220817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_get_clips_Public_get_Il2CppReferenceArray_1_AnimationClipPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationClipPair>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220817, XrefRangeEnd = 1220824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_set_clips_Public_set_Void_Il2CppReferenceArray_1_AnimationClipPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000F138 File Offset: 0x0000D338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220824, XrefRangeEnd = 1220826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformOverrideClipListCleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_PerformOverrideClipListCleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000F16C File Offset: 0x0000D36C
		[CallerCount(0)]
		public unsafe static void OnInvalidateOverrideController(AnimatorOverrideController controller)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_OnInvalidateOverrideController_Internal_Static_Void_AnimatorOverrideController_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002550 File Offset: 0x00000750
		public AnimatorOverrideController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000F1A4 File Offset: 0x0000D3A4
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002559 File Offset: 0x00000759
		public unsafe AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorOverrideController.NativeFieldInfoPtr_OnOverrideControllerDirty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatorOverrideController.OnOverrideControllerDirtyCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorOverrideController.NativeFieldInfoPtr_OnOverrideControllerDirty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr_OnOverrideControllerDirty;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RuntimeAnimatorController_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_AnimatorOverrideController_RuntimeAnimatorController_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_get_runtimeAnimatorController_Public_get_RuntimeAnimatorController_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_set_runtimeAnimatorController_Public_set_Void_RuntimeAnimatorController_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_AnimationClip_String_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_String_AnimationClip_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetClipByName_Private_AnimationClip_String_Boolean_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetClipByName_Private_Void_String_AnimationClip_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_AnimationClip_AnimationClip_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_AnimationClip_AnimationClip_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_GetClip_Private_AnimationClip_AnimationClip_Boolean_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_SetClip_Private_Void_AnimationClip_AnimationClip_Boolean_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_SendNotification_Private_Void_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginalClip_Private_AnimationClip_Int32_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_GetOverrideClip_Private_AnimationClip_AnimationClip_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_get_overridesCount_Public_get_Int32_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_GetOverrides_Public_Void_List_1_KeyValuePair_2_AnimationClip_AnimationClip_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOverrides_Public_Void_IList_1_KeyValuePair_2_AnimationClip_AnimationClip_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_get_clips_Public_get_Il2CppReferenceArray_1_AnimationClipPair_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_set_clips_Public_set_Void_Il2CppReferenceArray_1_AnimationClipPair_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_PerformOverrideClipListCleanup_Internal_Void_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_OnInvalidateOverrideController_Internal_Static_Void_AnimatorOverrideController_0;

		// Token: 0x0200007C RID: 124
		public sealed class OnOverrideControllerDirtyCallback : MulticastDelegate
		{
			// Token: 0x060005CF RID: 1487 RVA: 0x00004826 File Offset: 0x00002A26
			// Note: this type is marked as 'beforefieldinit'.
			static OnOverrideControllerDirtyCallback()
			{
				Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, "OnOverrideControllerDirtyCallback");
				AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr, 100663722);
				AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr, 100663723);
			}

			// Token: 0x060005D0 RID: 1488 RVA: 0x00013E3C File Offset: 0x0001203C
			[CallerCount(288)]
			[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnOverrideControllerDirtyCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005D1 RID: 1489 RVA: 0x00013E98 File Offset: 0x00012098
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005D2 RID: 1490 RVA: 0x00004864 File Offset: 0x00002A64
			public OnOverrideControllerDirtyCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060005D3 RID: 1491 RVA: 0x0000486D File Offset: 0x00002A6D
			public static implicit operator AnimatorOverrideController.OnOverrideControllerDirtyCallback(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<AnimatorOverrideController.OnOverrideControllerDirtyCallback>(A_0);
			}

			// Token: 0x060005D4 RID: 1492 RVA: 0x00004875 File Offset: 0x00002A75
			public static AnimatorOverrideController.OnOverrideControllerDirtyCallback operator +(AnimatorOverrideController.OnOverrideControllerDirtyCallback A_0, AnimatorOverrideController.OnOverrideControllerDirtyCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AnimatorOverrideController.OnOverrideControllerDirtyCallback>();
			}

			// Token: 0x060005D5 RID: 1493 RVA: 0x00004883 File Offset: 0x00002A83
			public static AnimatorOverrideController.OnOverrideControllerDirtyCallback operator -(AnimatorOverrideController.OnOverrideControllerDirtyCallback A_0, AnimatorOverrideController.OnOverrideControllerDirtyCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AnimatorOverrideController.OnOverrideControllerDirtyCallback>();
				}
				return delegate2;
			}

			// Token: 0x040004B3 RID: 1203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040004B4 RID: 1204
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}
	}
}
