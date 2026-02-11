using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x02000032 RID: 50
	[StructLayout(2)]
	public struct AnimatorControllerPlayable
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x00011F08 File Offset: 0x00010108
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorControllerPlayable()
		{
			Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimatorControllerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr);
			AnimatorControllerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, "m_Handle");
			AnimatorControllerPlayable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, "m_NullPlayable");
			AnimatorControllerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, 100663763);
			AnimatorControllerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, 100663764);
			AnimatorControllerPlayable.NativeMethodInfoPtr_SetHandle_Public_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, 100663765);
			AnimatorControllerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimatorControllerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, 100663766);
			AnimatorControllerPlayable.GetAnimatorClipInfoInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetAnimatorClipInfoInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoInternal");
			AnimatorControllerPlayable.GetAnimatorControllerInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetAnimatorControllerInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorControllerInternal");
			AnimatorControllerPlayable.GetLayerCountInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetLayerCountInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerCountInternal");
			AnimatorControllerPlayable.GetLayerNameInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetLayerNameInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerNameInternal");
			AnimatorControllerPlayable.GetLayerIndexInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetLayerIndexInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerIndexInternal");
			AnimatorControllerPlayable.GetLayerWeightInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetLayerWeightInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetLayerWeightInternal");
			AnimatorControllerPlayable.SetLayerWeightInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetLayerWeightInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetLayerWeightInternal");
			AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorClipInfoInternal");
			AnimatorControllerPlayable.GetAnimatorClipInfoCountInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetAnimatorClipInfoCountInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorClipInfoCountInternal");
			AnimatorControllerPlayable.GetNextAnimatorClipInfoInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetNextAnimatorClipInfoInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorClipInfoInternal");
			AnimatorControllerPlayable.ResolveHashInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.ResolveHashInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::ResolveHashInternal");
			AnimatorControllerPlayable.IsInTransitionInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.IsInTransitionInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::IsInTransitionInternal");
			AnimatorControllerPlayable.GetParameterInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetParameterInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetParameterInternal");
			AnimatorControllerPlayable.GetParameterCountInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetParameterCountInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetParameterCountInternal");
			AnimatorControllerPlayable.StringToHashDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.StringToHashDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::StringToHash");
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.CrossFadeInFixedTimeInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInFixedTimeInternal");
			AnimatorControllerPlayable.CrossFadeInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.CrossFadeInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::CrossFadeInternal");
			AnimatorControllerPlayable.PlayInFixedTimeInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.PlayInFixedTimeInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::PlayInFixedTimeInternal");
			AnimatorControllerPlayable.PlayInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.PlayInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::PlayInternal");
			AnimatorControllerPlayable.HasStateInternalDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.HasStateInternalDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::HasStateInternal");
			AnimatorControllerPlayable.SetFloatStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetFloatStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetFloatString");
			AnimatorControllerPlayable.SetFloatIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetFloatIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetFloatID");
			AnimatorControllerPlayable.GetFloatStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetFloatStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetFloatString");
			AnimatorControllerPlayable.GetFloatIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetFloatIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetFloatID");
			AnimatorControllerPlayable.SetBoolStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetBoolStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetBoolString");
			AnimatorControllerPlayable.SetBoolIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetBoolIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetBoolID");
			AnimatorControllerPlayable.GetBoolStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetBoolStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetBoolString");
			AnimatorControllerPlayable.GetBoolIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetBoolIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetBoolID");
			AnimatorControllerPlayable.SetIntegerStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetIntegerStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerString");
			AnimatorControllerPlayable.SetIntegerIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetIntegerIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetIntegerID");
			AnimatorControllerPlayable.GetIntegerStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetIntegerStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerString");
			AnimatorControllerPlayable.GetIntegerIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetIntegerIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetIntegerID");
			AnimatorControllerPlayable.SetTriggerStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetTriggerStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerString");
			AnimatorControllerPlayable.SetTriggerIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.SetTriggerIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::SetTriggerID");
			AnimatorControllerPlayable.ResetTriggerStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.ResetTriggerStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerString");
			AnimatorControllerPlayable.ResetTriggerIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.ResetTriggerIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::ResetTriggerID");
			AnimatorControllerPlayable.IsParameterControlledByCurveStringDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.IsParameterControlledByCurveStringDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveString");
			AnimatorControllerPlayable.IsParameterControlledByCurveIDDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.IsParameterControlledByCurveIDDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::IsParameterControlledByCurveID");
			AnimatorControllerPlayable.CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.CreateHandleInternal_InjectedDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::CreateHandleInternal_Injected");
			AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_InjectedDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetCurrentAnimatorStateInfoInternal_Injected");
			AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_InjectedDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetNextAnimatorStateInfoInternal_Injected");
			AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_InjectedDelegate>("UnityEngine.Animations.AnimatorControllerPlayable::GetAnimatorTransitionInfoInternal_Injected");
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00012228 File Offset: 0x00010428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220980, XrefRangeEnd = 1220988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatorControllerPlayable(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerPlayable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0001225C File Offset: 0x0001045C
		[CallerCount(0)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0001228C File Offset: 0x0001048C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1221000, RefRangeEnd = 1221001, XrefRangeStart = 1220988, XrefRangeEnd = 1221000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandle(PlayableHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerPlayable.NativeMethodInfoPtr_SetHandle_Public_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000122C0 File Offset: 0x000104C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221001, XrefRangeEnd = 1221008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AnimatorControllerPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimatorControllerPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000033CA File Offset: 0x000015CA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorControllerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00012300 File Offset: 0x00010500
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x000033DC File Offset: 0x000015DC
		public unsafe static AnimatorControllerPlayable m_NullPlayable
		{
			get
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				IL2CPP.il2cpp_field_static_get_value(AnimatorControllerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&animatorControllerPlayable));
				return animatorControllerPlayable;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimatorControllerPlayable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0001231C File Offset: 0x0001051C
		public static AnimatorControllerPlayable Null
		{
			get
			{
				return AnimatorControllerPlayable.m_NullPlayable;
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00012334 File Offset: 0x00010534
		public static AnimatorControllerPlayable Create(PlayableGraph graph, RuntimeAnimatorController controller)
		{
			PlayableHandle playableHandle = AnimatorControllerPlayable.CreateHandle(graph, controller);
			return new AnimatorControllerPlayable(playableHandle);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00012354 File Offset: 0x00010554
		public static PlayableHandle CreateHandle(PlayableGraph graph, RuntimeAnimatorController controller)
		{
			PlayableHandle @null = PlayableHandle.Null;
			bool flag = !AnimatorControllerPlayable.CreateHandleInternal(graph, controller, ref @null);
			PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00012388 File Offset: 0x00010588
		public static implicit operator Playable(AnimatorControllerPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000123A8 File Offset: 0x000105A8
		public static explicit operator AnimatorControllerPlayable(Playable playable)
		{
			return new AnimatorControllerPlayable(playable.GetHandle());
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000123C8 File Offset: 0x000105C8
		public float GetFloat(string name)
		{
			return AnimatorControllerPlayable.GetFloatString(ref this.m_Handle, name);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000123E8 File Offset: 0x000105E8
		public float GetFloat(int id)
		{
			return AnimatorControllerPlayable.GetFloatID(ref this.m_Handle, id);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000033EA File Offset: 0x000015EA
		public void SetFloat(string name, float value)
		{
			AnimatorControllerPlayable.SetFloatString(ref this.m_Handle, name, value);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000033FB File Offset: 0x000015FB
		public void SetFloat(int id, float value)
		{
			AnimatorControllerPlayable.SetFloatID(ref this.m_Handle, id, value);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00012408 File Offset: 0x00010608
		public bool GetBool(string name)
		{
			return AnimatorControllerPlayable.GetBoolString(ref this.m_Handle, name);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00012428 File Offset: 0x00010628
		public bool GetBool(int id)
		{
			return AnimatorControllerPlayable.GetBoolID(ref this.m_Handle, id);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000340C File Offset: 0x0000160C
		public void SetBool(string name, bool value)
		{
			AnimatorControllerPlayable.SetBoolString(ref this.m_Handle, name, value);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000341D File Offset: 0x0000161D
		public void SetBool(int id, bool value)
		{
			AnimatorControllerPlayable.SetBoolID(ref this.m_Handle, id, value);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00012448 File Offset: 0x00010648
		public int GetInteger(string name)
		{
			return AnimatorControllerPlayable.GetIntegerString(ref this.m_Handle, name);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00012468 File Offset: 0x00010668
		public int GetInteger(int id)
		{
			return AnimatorControllerPlayable.GetIntegerID(ref this.m_Handle, id);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000342E File Offset: 0x0000162E
		public void SetInteger(string name, int value)
		{
			AnimatorControllerPlayable.SetIntegerString(ref this.m_Handle, name, value);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000343F File Offset: 0x0000163F
		public void SetInteger(int id, int value)
		{
			AnimatorControllerPlayable.SetIntegerID(ref this.m_Handle, id, value);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00003450 File Offset: 0x00001650
		public void SetTrigger(string name)
		{
			AnimatorControllerPlayable.SetTriggerString(ref this.m_Handle, name);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00003460 File Offset: 0x00001660
		public void SetTrigger(int id)
		{
			AnimatorControllerPlayable.SetTriggerID(ref this.m_Handle, id);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00003470 File Offset: 0x00001670
		public void ResetTrigger(string name)
		{
			AnimatorControllerPlayable.ResetTriggerString(ref this.m_Handle, name);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00003480 File Offset: 0x00001680
		public void ResetTrigger(int id)
		{
			AnimatorControllerPlayable.ResetTriggerID(ref this.m_Handle, id);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00012488 File Offset: 0x00010688
		public bool IsParameterControlledByCurve(string name)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveString(ref this.m_Handle, name);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000124A8 File Offset: 0x000106A8
		public bool IsParameterControlledByCurve(int id)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveID(ref this.m_Handle, id);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000124C8 File Offset: 0x000106C8
		public int GetLayerCount()
		{
			return AnimatorControllerPlayable.GetLayerCountInternal(ref this.m_Handle);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000124E8 File Offset: 0x000106E8
		public string GetLayerName(int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerNameInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00012508 File Offset: 0x00010708
		public int GetLayerIndex(string layerName)
		{
			return AnimatorControllerPlayable.GetLayerIndexInternal(ref this.m_Handle, layerName);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00012528 File Offset: 0x00010728
		public float GetLayerWeight(int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerWeightInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00003490 File Offset: 0x00001690
		public void SetLayerWeight(int layerIndex, float weight)
		{
			AnimatorControllerPlayable.SetLayerWeightInternal(ref this.m_Handle, layerIndex, weight);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00012548 File Offset: 0x00010748
		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00012568 File Offset: 0x00010768
		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00012588 File Offset: 0x00010788
		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000125A8 File Offset: 0x000107A8
		public Il2CppStructArray<AnimatorClipInfo> GetCurrentAnimatorClipInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000125C8 File Offset: 0x000107C8
		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			bool flag = clips == null;
			if (flag)
			{
				throw new ArgumentNullException("clips");
			}
			AnimatorControllerPlayable.GetAnimatorClipInfoInternal(ref this.m_Handle, layerIndex, true, clips);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000125F8 File Offset: 0x000107F8
		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			bool flag = clips == null;
			if (flag)
			{
				throw new ArgumentNullException("clips");
			}
			AnimatorControllerPlayable.GetAnimatorClipInfoInternal(ref this.m_Handle, layerIndex, false, clips);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000034A1 File Offset: 0x000016A1
		public static void GetAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex, bool isCurrent, Object clips)
		{
			AnimatorControllerPlayable.GetAnimatorClipInfoInternalDelegateField(ref handle, layerIndex, isCurrent, IL2CPP.Il2CppObjectBaseToPtr(clips));
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00012628 File Offset: 0x00010828
		public int GetCurrentAnimatorClipInfoCount(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternal(ref this.m_Handle, layerIndex, true);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00012648 File Offset: 0x00010848
		public int GetNextAnimatorClipInfoCount(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternal(ref this.m_Handle, layerIndex, false);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00012668 File Offset: 0x00010868
		public Il2CppStructArray<AnimatorClipInfo> GetNextAnimatorClipInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetNextAnimatorClipInfoInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00012688 File Offset: 0x00010888
		public bool IsInTransition(int layerIndex)
		{
			return AnimatorControllerPlayable.IsInTransitionInternal(ref this.m_Handle, layerIndex);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000126A8 File Offset: 0x000108A8
		public int GetParameterCount()
		{
			return AnimatorControllerPlayable.GetParameterCountInternal(ref this.m_Handle);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000126C8 File Offset: 0x000108C8
		public AnimatorControllerParameter GetParameter(int index)
		{
			AnimatorControllerParameter parameterInternal = AnimatorControllerPlayable.GetParameterInternal(ref this.m_Handle, index);
			bool flag = parameterInternal.m_Type == (AnimatorControllerParameterType)0;
			if (flag)
			{
				throw new IndexOutOfRangeException("Invalid parameter index.");
			}
			return parameterInternal;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000034B6 File Offset: 0x000016B6
		public void CrossFadeInFixedTime(string stateName, float transitionDuration)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, -1, 0f);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000034D2 File Offset: 0x000016D2
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, 0f);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000034EE File Offset: 0x000016EE
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, fixedTime);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00003507 File Offset: 0x00001707
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, stateNameHash, transitionDuration, -1, 0f);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000351E File Offset: 0x0000171E
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, 0f);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00003535 File Offset: 0x00001735
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00003549 File Offset: 0x00001749
		public void CrossFade(string stateName, float transitionDuration)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, -1, float.NegativeInfinity);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00003565 File Offset: 0x00001765
		public void CrossFade(string stateName, float transitionDuration, int layer)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, float.NegativeInfinity);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00003581 File Offset: 0x00001781
		public void CrossFade(string stateName, float transitionDuration, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, normalizedTime);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000359A File Offset: 0x0000179A
		public void CrossFade(int stateNameHash, float transitionDuration)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, stateNameHash, transitionDuration, -1, float.NegativeInfinity);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000035B1 File Offset: 0x000017B1
		public void CrossFade(int stateNameHash, float transitionDuration, int layer)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, float.NegativeInfinity);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000035C8 File Offset: 0x000017C8
		public void CrossFade(int stateNameHash, float transitionDuration, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, normalizedTime);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000035DC File Offset: 0x000017DC
		public void PlayInFixedTime(string stateName)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), -1, float.NegativeInfinity);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000035F7 File Offset: 0x000017F7
		public void PlayInFixedTime(string stateName, int layer)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, float.NegativeInfinity);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00003612 File Offset: 0x00001812
		public void PlayInFixedTime(string stateName, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, fixedTime);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00003629 File Offset: 0x00001829
		public void PlayInFixedTime(int stateNameHash)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, stateNameHash, -1, float.NegativeInfinity);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000363F File Offset: 0x0000183F
		public void PlayInFixedTime(int stateNameHash, int layer)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, stateNameHash, layer, float.NegativeInfinity);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00003655 File Offset: 0x00001855
		public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, stateNameHash, layer, fixedTime);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00003667 File Offset: 0x00001867
		public void Play(string stateName)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), -1, float.NegativeInfinity);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00003682 File Offset: 0x00001882
		public void Play(string stateName, int layer)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, float.NegativeInfinity);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000369D File Offset: 0x0000189D
		public void Play(string stateName, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, normalizedTime);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000036B4 File Offset: 0x000018B4
		public void Play(int stateNameHash)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, stateNameHash, -1, float.NegativeInfinity);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000036CA File Offset: 0x000018CA
		public void Play(int stateNameHash, int layer)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, stateNameHash, layer, float.NegativeInfinity);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000036E0 File Offset: 0x000018E0
		public void Play(int stateNameHash, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, stateNameHash, layer, normalizedTime);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00012700 File Offset: 0x00010900
		public bool HasState(int layerIndex, int stateID)
		{
			return AnimatorControllerPlayable.HasStateInternal(ref this.m_Handle, layerIndex, stateID);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00012720 File Offset: 0x00010920
		public string ResolveHash(int hash)
		{
			return AnimatorControllerPlayable.ResolveHashInternal(ref this.m_Handle, hash);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000036F2 File Offset: 0x000018F2
		public static bool CreateHandleInternal(PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.CreateHandleInternal_Injected(ref graph, controller, ref handle);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00012740 File Offset: 0x00010940
		public static RuntimeAnimatorController GetAnimatorControllerInternal(ref PlayableHandle handle)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetAnimatorControllerInternalDelegateField(ref handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000036FD File Offset: 0x000018FD
		public static int GetLayerCountInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.GetLayerCountInternalDelegateField(ref handle);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00012768 File Offset: 0x00010968
		public static string GetLayerNameInternal(ref PlayableHandle handle, int layerIndex)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetLayerNameInternalDelegateField(ref handle, layerIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000370A File Offset: 0x0000190A
		public static int GetLayerIndexInternal(ref PlayableHandle handle, string layerName)
		{
			return AnimatorControllerPlayable.GetLayerIndexInternalDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(layerName));
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000371D File Offset: 0x0000191D
		public static float GetLayerWeightInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerWeightInternalDelegateField(ref handle, layerIndex);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000372B File Offset: 0x0000192B
		public static void SetLayerWeightInternal(ref PlayableHandle handle, int layerIndex, float weight)
		{
			AnimatorControllerPlayable.SetLayerWeightInternalDelegateField(ref handle, layerIndex, weight);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00012788 File Offset: 0x00010988
		public static AnimatorStateInfo GetCurrentAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			AnimatorStateInfo animatorStateInfo;
			AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_Injected(ref handle, layerIndex, out animatorStateInfo);
			return animatorStateInfo;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000127A0 File Offset: 0x000109A0
		public static AnimatorStateInfo GetNextAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			AnimatorStateInfo animatorStateInfo;
			AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_Injected(ref handle, layerIndex, out animatorStateInfo);
			return animatorStateInfo;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000127B8 File Offset: 0x000109B8
		public static AnimatorTransitionInfo GetAnimatorTransitionInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_Injected(ref handle, layerIndex, out animatorTransitionInfo);
			return animatorTransitionInfo;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000127D0 File Offset: 0x000109D0
		public static Il2CppStructArray<AnimatorClipInfo> GetCurrentAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternalDelegateField(ref handle, layerIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AnimatorClipInfo>>(intPtr2) : null;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000373A File Offset: 0x0000193A
		public static int GetAnimatorClipInfoCountInternal(ref PlayableHandle handle, int layerIndex, bool current)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternalDelegateField(ref handle, layerIndex, current);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000127F8 File Offset: 0x000109F8
		public static Il2CppStructArray<AnimatorClipInfo> GetNextAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetNextAnimatorClipInfoInternalDelegateField(ref handle, layerIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AnimatorClipInfo>>(intPtr2) : null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00012820 File Offset: 0x00010A20
		public static string ResolveHashInternal(ref PlayableHandle handle, int hash)
		{
			IntPtr intPtr = AnimatorControllerPlayable.ResolveHashInternalDelegateField(ref handle, hash);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00003749 File Offset: 0x00001949
		public static bool IsInTransitionInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.IsInTransitionInternalDelegateField(ref handle, layerIndex);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00012840 File Offset: 0x00010A40
		public static AnimatorControllerParameter GetParameterInternal(ref PlayableHandle handle, int index)
		{
			IntPtr intPtr = AnimatorControllerPlayable.GetParameterInternalDelegateField(ref handle, index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatorControllerParameter>(intPtr2) : null;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00003757 File Offset: 0x00001957
		public static int GetParameterCountInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.GetParameterCountInternalDelegateField(ref handle);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00003764 File Offset: 0x00001964
		public static int StringToHash(string name)
		{
			return AnimatorControllerPlayable.StringToHashDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00003776 File Offset: 0x00001976
		public static void CrossFadeInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternalDelegateField(ref handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00003788 File Offset: 0x00001988
		public static void CrossFadeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternalDelegateField(ref handle, stateNameHash, transitionDuration, layer, normalizedTime);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000379A File Offset: 0x0000199A
		public static void PlayInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, int layer, float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternalDelegateField(ref handle, stateNameHash, layer, fixedTime);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000037AA File Offset: 0x000019AA
		public static void PlayInternal(ref PlayableHandle handle, int stateNameHash, int layer, float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternalDelegateField(ref handle, stateNameHash, layer, normalizedTime);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000037BA File Offset: 0x000019BA
		public static bool HasStateInternal(ref PlayableHandle handle, int layerIndex, int stateID)
		{
			return AnimatorControllerPlayable.HasStateInternalDelegateField(ref handle, layerIndex, stateID);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000037C9 File Offset: 0x000019C9
		public static void SetFloatString(ref PlayableHandle handle, string name, float value)
		{
			AnimatorControllerPlayable.SetFloatStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000037DD File Offset: 0x000019DD
		public static void SetFloatID(ref PlayableHandle handle, int id, float value)
		{
			AnimatorControllerPlayable.SetFloatIDDelegateField(ref handle, id, value);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000037EC File Offset: 0x000019EC
		public static float GetFloatString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.GetFloatStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000037FF File Offset: 0x000019FF
		public static float GetFloatID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.GetFloatIDDelegateField(ref handle, id);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000380D File Offset: 0x00001A0D
		public static void SetBoolString(ref PlayableHandle handle, string name, bool value)
		{
			AnimatorControllerPlayable.SetBoolStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00003821 File Offset: 0x00001A21
		public static void SetBoolID(ref PlayableHandle handle, int id, bool value)
		{
			AnimatorControllerPlayable.SetBoolIDDelegateField(ref handle, id, value);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00003830 File Offset: 0x00001A30
		public static bool GetBoolString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.GetBoolStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00003843 File Offset: 0x00001A43
		public static bool GetBoolID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.GetBoolIDDelegateField(ref handle, id);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00003851 File Offset: 0x00001A51
		public static void SetIntegerString(ref PlayableHandle handle, string name, int value)
		{
			AnimatorControllerPlayable.SetIntegerStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name), value);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00003865 File Offset: 0x00001A65
		public static void SetIntegerID(ref PlayableHandle handle, int id, int value)
		{
			AnimatorControllerPlayable.SetIntegerIDDelegateField(ref handle, id, value);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00003874 File Offset: 0x00001A74
		public static int GetIntegerString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.GetIntegerStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00003887 File Offset: 0x00001A87
		public static int GetIntegerID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.GetIntegerIDDelegateField(ref handle, id);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00003895 File Offset: 0x00001A95
		public static void SetTriggerString(ref PlayableHandle handle, string name)
		{
			AnimatorControllerPlayable.SetTriggerStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000038A8 File Offset: 0x00001AA8
		public static void SetTriggerID(ref PlayableHandle handle, int id)
		{
			AnimatorControllerPlayable.SetTriggerIDDelegateField(ref handle, id);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000038B6 File Offset: 0x00001AB6
		public static void ResetTriggerString(ref PlayableHandle handle, string name)
		{
			AnimatorControllerPlayable.ResetTriggerStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000038C9 File Offset: 0x00001AC9
		public static void ResetTriggerID(ref PlayableHandle handle, int id)
		{
			AnimatorControllerPlayable.ResetTriggerIDDelegateField(ref handle, id);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000038D7 File Offset: 0x00001AD7
		public static bool IsParameterControlledByCurveString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveStringDelegateField(ref handle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000038EA File Offset: 0x00001AEA
		public static bool IsParameterControlledByCurveID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveIDDelegateField(ref handle, id);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000038F8 File Offset: 0x00001AF8
		public static bool CreateHandleInternal_Injected(ref PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.CreateHandleInternal_InjectedDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(controller), ref handle);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000390C File Offset: 0x00001B0C
		public static void GetCurrentAnimatorStateInfoInternal_Injected(ref PlayableHandle handle, int layerIndex, out AnimatorStateInfo ret)
		{
			AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_InjectedDelegateField(ref handle, layerIndex, out ret);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000391B File Offset: 0x00001B1B
		public static void GetNextAnimatorStateInfoInternal_Injected(ref PlayableHandle handle, int layerIndex, out AnimatorStateInfo ret)
		{
			AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_InjectedDelegateField(ref handle, layerIndex, out ret);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000392A File Offset: 0x00001B2A
		public static void GetAnimatorTransitionInfoInternal_Injected(ref PlayableHandle handle, int layerIndex, out AnimatorTransitionInfo ret)
		{
			AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_InjectedDelegateField(ref handle, layerIndex, out ret);
		}

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_SetHandle_Public_Void_PlayableHandle_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimatorControllerPlayable_0;

		// Token: 0x04000348 RID: 840
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x04000349 RID: 841
		private static readonly AnimatorControllerPlayable.GetAnimatorClipInfoInternalDelegate GetAnimatorClipInfoInternalDelegateField;

		// Token: 0x0400034A RID: 842
		private static readonly AnimatorControllerPlayable.GetAnimatorControllerInternalDelegate GetAnimatorControllerInternalDelegateField;

		// Token: 0x0400034B RID: 843
		private static readonly AnimatorControllerPlayable.GetLayerCountInternalDelegate GetLayerCountInternalDelegateField;

		// Token: 0x0400034C RID: 844
		private static readonly AnimatorControllerPlayable.GetLayerNameInternalDelegate GetLayerNameInternalDelegateField;

		// Token: 0x0400034D RID: 845
		private static readonly AnimatorControllerPlayable.GetLayerIndexInternalDelegate GetLayerIndexInternalDelegateField;

		// Token: 0x0400034E RID: 846
		private static readonly AnimatorControllerPlayable.GetLayerWeightInternalDelegate GetLayerWeightInternalDelegateField;

		// Token: 0x0400034F RID: 847
		private static readonly AnimatorControllerPlayable.SetLayerWeightInternalDelegate SetLayerWeightInternalDelegateField;

		// Token: 0x04000350 RID: 848
		private static readonly AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternalDelegate GetCurrentAnimatorClipInfoInternalDelegateField;

		// Token: 0x04000351 RID: 849
		private static readonly AnimatorControllerPlayable.GetAnimatorClipInfoCountInternalDelegate GetAnimatorClipInfoCountInternalDelegateField;

		// Token: 0x04000352 RID: 850
		private static readonly AnimatorControllerPlayable.GetNextAnimatorClipInfoInternalDelegate GetNextAnimatorClipInfoInternalDelegateField;

		// Token: 0x04000353 RID: 851
		private static readonly AnimatorControllerPlayable.ResolveHashInternalDelegate ResolveHashInternalDelegateField;

		// Token: 0x04000354 RID: 852
		private static readonly AnimatorControllerPlayable.IsInTransitionInternalDelegate IsInTransitionInternalDelegateField;

		// Token: 0x04000355 RID: 853
		private static readonly AnimatorControllerPlayable.GetParameterInternalDelegate GetParameterInternalDelegateField;

		// Token: 0x04000356 RID: 854
		private static readonly AnimatorControllerPlayable.GetParameterCountInternalDelegate GetParameterCountInternalDelegateField;

		// Token: 0x04000357 RID: 855
		private static readonly AnimatorControllerPlayable.StringToHashDelegate StringToHashDelegateField;

		// Token: 0x04000358 RID: 856
		private static readonly AnimatorControllerPlayable.CrossFadeInFixedTimeInternalDelegate CrossFadeInFixedTimeInternalDelegateField;

		// Token: 0x04000359 RID: 857
		private static readonly AnimatorControllerPlayable.CrossFadeInternalDelegate CrossFadeInternalDelegateField;

		// Token: 0x0400035A RID: 858
		private static readonly AnimatorControllerPlayable.PlayInFixedTimeInternalDelegate PlayInFixedTimeInternalDelegateField;

		// Token: 0x0400035B RID: 859
		private static readonly AnimatorControllerPlayable.PlayInternalDelegate PlayInternalDelegateField;

		// Token: 0x0400035C RID: 860
		private static readonly AnimatorControllerPlayable.HasStateInternalDelegate HasStateInternalDelegateField;

		// Token: 0x0400035D RID: 861
		private static readonly AnimatorControllerPlayable.SetFloatStringDelegate SetFloatStringDelegateField;

		// Token: 0x0400035E RID: 862
		private static readonly AnimatorControllerPlayable.SetFloatIDDelegate SetFloatIDDelegateField;

		// Token: 0x0400035F RID: 863
		private static readonly AnimatorControllerPlayable.GetFloatStringDelegate GetFloatStringDelegateField;

		// Token: 0x04000360 RID: 864
		private static readonly AnimatorControllerPlayable.GetFloatIDDelegate GetFloatIDDelegateField;

		// Token: 0x04000361 RID: 865
		private static readonly AnimatorControllerPlayable.SetBoolStringDelegate SetBoolStringDelegateField;

		// Token: 0x04000362 RID: 866
		private static readonly AnimatorControllerPlayable.SetBoolIDDelegate SetBoolIDDelegateField;

		// Token: 0x04000363 RID: 867
		private static readonly AnimatorControllerPlayable.GetBoolStringDelegate GetBoolStringDelegateField;

		// Token: 0x04000364 RID: 868
		private static readonly AnimatorControllerPlayable.GetBoolIDDelegate GetBoolIDDelegateField;

		// Token: 0x04000365 RID: 869
		private static readonly AnimatorControllerPlayable.SetIntegerStringDelegate SetIntegerStringDelegateField;

		// Token: 0x04000366 RID: 870
		private static readonly AnimatorControllerPlayable.SetIntegerIDDelegate SetIntegerIDDelegateField;

		// Token: 0x04000367 RID: 871
		private static readonly AnimatorControllerPlayable.GetIntegerStringDelegate GetIntegerStringDelegateField;

		// Token: 0x04000368 RID: 872
		private static readonly AnimatorControllerPlayable.GetIntegerIDDelegate GetIntegerIDDelegateField;

		// Token: 0x04000369 RID: 873
		private static readonly AnimatorControllerPlayable.SetTriggerStringDelegate SetTriggerStringDelegateField;

		// Token: 0x0400036A RID: 874
		private static readonly AnimatorControllerPlayable.SetTriggerIDDelegate SetTriggerIDDelegateField;

		// Token: 0x0400036B RID: 875
		private static readonly AnimatorControllerPlayable.ResetTriggerStringDelegate ResetTriggerStringDelegateField;

		// Token: 0x0400036C RID: 876
		private static readonly AnimatorControllerPlayable.ResetTriggerIDDelegate ResetTriggerIDDelegateField;

		// Token: 0x0400036D RID: 877
		private static readonly AnimatorControllerPlayable.IsParameterControlledByCurveStringDelegate IsParameterControlledByCurveStringDelegateField;

		// Token: 0x0400036E RID: 878
		private static readonly AnimatorControllerPlayable.IsParameterControlledByCurveIDDelegate IsParameterControlledByCurveIDDelegateField;

		// Token: 0x0400036F RID: 879
		private static readonly AnimatorControllerPlayable.CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField;

		// Token: 0x04000370 RID: 880
		private static readonly AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal_InjectedDelegate GetCurrentAnimatorStateInfoInternal_InjectedDelegateField;

		// Token: 0x04000371 RID: 881
		private static readonly AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal_InjectedDelegate GetNextAnimatorStateInfoInternal_InjectedDelegateField;

		// Token: 0x04000372 RID: 882
		private static readonly AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal_InjectedDelegate GetAnimatorTransitionInfoInternal_InjectedDelegateField;

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x060006C7 RID: 1735
		private delegate void GetAnimatorClipInfoInternalDelegate(IntPtr handle, int layerIndex, bool isCurrent, IntPtr clips);

		// Token: 0x020000F6 RID: 246
		// (Invoke) Token: 0x060006C9 RID: 1737
		private delegate IntPtr GetAnimatorControllerInternalDelegate(IntPtr handle);

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x060006CB RID: 1739
		private delegate int GetLayerCountInternalDelegate(IntPtr handle);

		// Token: 0x020000F8 RID: 248
		// (Invoke) Token: 0x060006CD RID: 1741
		private delegate IntPtr GetLayerNameInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x060006CF RID: 1743
		private delegate int GetLayerIndexInternalDelegate(IntPtr handle, IntPtr layerName);

		// Token: 0x020000FA RID: 250
		// (Invoke) Token: 0x060006D1 RID: 1745
		private delegate float GetLayerWeightInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x060006D3 RID: 1747
		private delegate void SetLayerWeightInternalDelegate(IntPtr handle, int layerIndex, float weight);

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x060006D5 RID: 1749
		private delegate IntPtr GetCurrentAnimatorClipInfoInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x060006D7 RID: 1751
		private delegate int GetAnimatorClipInfoCountInternalDelegate(IntPtr handle, int layerIndex, bool current);

		// Token: 0x020000FE RID: 254
		// (Invoke) Token: 0x060006D9 RID: 1753
		private delegate IntPtr GetNextAnimatorClipInfoInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x060006DB RID: 1755
		private delegate IntPtr ResolveHashInternalDelegate(IntPtr handle, int hash);

		// Token: 0x02000100 RID: 256
		// (Invoke) Token: 0x060006DD RID: 1757
		private delegate bool IsInTransitionInternalDelegate(IntPtr handle, int layerIndex);

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x060006DF RID: 1759
		private delegate IntPtr GetParameterInternalDelegate(IntPtr handle, int index);

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x060006E1 RID: 1761
		private delegate int GetParameterCountInternalDelegate(IntPtr handle);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x060006E3 RID: 1763
		private delegate int StringToHashDelegate(IntPtr name);

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x060006E5 RID: 1765
		private delegate void CrossFadeInFixedTimeInternalDelegate(IntPtr handle, int stateNameHash, float transitionDuration, int layer, float fixedTime);

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x060006E7 RID: 1767
		private delegate void CrossFadeInternalDelegate(IntPtr handle, int stateNameHash, float transitionDuration, int layer, float normalizedTime);

		// Token: 0x02000106 RID: 262
		// (Invoke) Token: 0x060006E9 RID: 1769
		private delegate void PlayInFixedTimeInternalDelegate(IntPtr handle, int stateNameHash, int layer, float fixedTime);

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x060006EB RID: 1771
		private delegate void PlayInternalDelegate(IntPtr handle, int stateNameHash, int layer, float normalizedTime);

		// Token: 0x02000108 RID: 264
		// (Invoke) Token: 0x060006ED RID: 1773
		private delegate bool HasStateInternalDelegate(IntPtr handle, int layerIndex, int stateID);

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x060006EF RID: 1775
		private delegate void SetFloatStringDelegate(IntPtr handle, IntPtr name, float value);

		// Token: 0x0200010A RID: 266
		// (Invoke) Token: 0x060006F1 RID: 1777
		private delegate void SetFloatIDDelegate(IntPtr handle, int id, float value);

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x060006F3 RID: 1779
		private delegate float GetFloatStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x060006F5 RID: 1781
		private delegate float GetFloatIDDelegate(IntPtr handle, int id);

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x060006F7 RID: 1783
		private delegate void SetBoolStringDelegate(IntPtr handle, IntPtr name, bool value);

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x060006F9 RID: 1785
		private delegate void SetBoolIDDelegate(IntPtr handle, int id, bool value);

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x060006FB RID: 1787
		private delegate bool GetBoolStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x060006FD RID: 1789
		private delegate bool GetBoolIDDelegate(IntPtr handle, int id);

		// Token: 0x02000111 RID: 273
		// (Invoke) Token: 0x060006FF RID: 1791
		private delegate void SetIntegerStringDelegate(IntPtr handle, IntPtr name, int value);

		// Token: 0x02000112 RID: 274
		// (Invoke) Token: 0x06000701 RID: 1793
		private delegate void SetIntegerIDDelegate(IntPtr handle, int id, int value);

		// Token: 0x02000113 RID: 275
		// (Invoke) Token: 0x06000703 RID: 1795
		private delegate int GetIntegerStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x02000114 RID: 276
		// (Invoke) Token: 0x06000705 RID: 1797
		private delegate int GetIntegerIDDelegate(IntPtr handle, int id);

		// Token: 0x02000115 RID: 277
		// (Invoke) Token: 0x06000707 RID: 1799
		private delegate void SetTriggerStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x02000116 RID: 278
		// (Invoke) Token: 0x06000709 RID: 1801
		private delegate void SetTriggerIDDelegate(IntPtr handle, int id);

		// Token: 0x02000117 RID: 279
		// (Invoke) Token: 0x0600070B RID: 1803
		private delegate void ResetTriggerStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x02000118 RID: 280
		// (Invoke) Token: 0x0600070D RID: 1805
		private delegate void ResetTriggerIDDelegate(IntPtr handle, int id);

		// Token: 0x02000119 RID: 281
		// (Invoke) Token: 0x0600070F RID: 1807
		private delegate bool IsParameterControlledByCurveStringDelegate(IntPtr handle, IntPtr name);

		// Token: 0x0200011A RID: 282
		// (Invoke) Token: 0x06000711 RID: 1809
		private delegate bool IsParameterControlledByCurveIDDelegate(IntPtr handle, int id);

		// Token: 0x0200011B RID: 283
		// (Invoke) Token: 0x06000713 RID: 1811
		private delegate bool CreateHandleInternal_InjectedDelegate(IntPtr graph, IntPtr controller, IntPtr handle);

		// Token: 0x0200011C RID: 284
		// (Invoke) Token: 0x06000715 RID: 1813
		private delegate void GetCurrentAnimatorStateInfoInternal_InjectedDelegate(IntPtr handle, int layerIndex, [Out] IntPtr ret);

		// Token: 0x0200011D RID: 285
		// (Invoke) Token: 0x06000717 RID: 1815
		private delegate void GetNextAnimatorStateInfoInternal_InjectedDelegate(IntPtr handle, int layerIndex, [Out] IntPtr ret);

		// Token: 0x0200011E RID: 286
		// (Invoke) Token: 0x06000719 RID: 1817
		private delegate void GetAnimatorTransitionInfoInternal_InjectedDelegate(IntPtr handle, int layerIndex, [Out] IntPtr ret);
	}
}
