using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x02000265 RID: 613
	[StructLayout(2)]
	public struct PlayableHandle
	{
		// Token: 0x06002A0D RID: 10765 RVA: 0x000AD0D0 File Offset: 0x000AB2D0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableHandle()
		{
			Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr);
			PlayableHandle.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Handle");
			PlayableHandle.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Version");
			PlayableHandle.NativeFieldInfoPtr_m_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Null");
			PlayableHandle.NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100668558);
			PlayableHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100668559);
			PlayableHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100668560);
			PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100668561);
			PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100668562);
			PlayableHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100668563);
			PlayableHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100668564);
			PlayableHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100668565);
			PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100668566);
			PlayableHandle.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100668568);
			PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Injected_Private_Static_Type_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100668569);
			PlayableHandle.IsNull_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.IsNull_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::IsNull_Injected");
			PlayableHandle.GetJobType_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetJobType_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetJobType_Injected");
			PlayableHandle.SetScriptInstance_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetScriptInstance_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetScriptInstance_Injected");
			PlayableHandle.CanChangeInputs_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanChangeInputs_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::CanChangeInputs_Injected");
			PlayableHandle.CanSetWeights_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanSetWeights_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::CanSetWeights_Injected");
			PlayableHandle.CanDestroy_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanDestroy_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::CanDestroy_Injected");
			PlayableHandle.GetPlayState_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetPlayState_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetPlayState_Injected");
			PlayableHandle.Play_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.Play_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::Play_Injected");
			PlayableHandle.Pause_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.Pause_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::Pause_Injected");
			PlayableHandle.GetSpeed_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetSpeed_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetSpeed_Injected");
			PlayableHandle.SetSpeed_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetSpeed_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetSpeed_Injected");
			PlayableHandle.GetTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetTime_Injected");
			PlayableHandle.SetTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetTime_Injected");
			PlayableHandle.IsDone_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.IsDone_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::IsDone_Injected");
			PlayableHandle.SetDone_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetDone_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetDone_Injected");
			PlayableHandle.GetDuration_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetDuration_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetDuration_Injected");
			PlayableHandle.SetDuration_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetDuration_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetDuration_Injected");
			PlayableHandle.GetPropagateSetTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetPropagateSetTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetPropagateSetTime_Injected");
			PlayableHandle.SetPropagateSetTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetPropagateSetTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetPropagateSetTime_Injected");
			PlayableHandle.GetGraph_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetGraph_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetGraph_Injected");
			PlayableHandle.GetInputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetInputCount_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetInputCount_Injected");
			PlayableHandle.SetInputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetInputCount_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetInputCount_Injected");
			PlayableHandle.GetOutputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetOutputCount_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetOutputCount_Injected");
			PlayableHandle.SetOutputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetOutputCount_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetOutputCount_Injected");
			PlayableHandle.SetInputWeight_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetInputWeight_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetInputWeight_Injected");
			PlayableHandle.SetDelay_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetDelay_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetDelay_Injected");
			PlayableHandle.GetDelay_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetDelay_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetDelay_Injected");
			PlayableHandle.IsDelayed_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.IsDelayed_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::IsDelayed_Injected");
			PlayableHandle.GetPreviousTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetPreviousTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetPreviousTime_Injected");
			PlayableHandle.SetLeadTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetLeadTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetLeadTime_Injected");
			PlayableHandle.GetLeadTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetLeadTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetLeadTime_Injected");
			PlayableHandle.GetTraversalMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetTraversalMode_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetTraversalMode_Injected");
			PlayableHandle.SetTraversalMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetTraversalMode_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetTraversalMode_Injected");
			PlayableHandle.GetJobData_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetJobData_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetJobData_Injected");
			PlayableHandle.GetTimeWrapMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetTimeWrapMode_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetTimeWrapMode_Injected");
			PlayableHandle.SetTimeWrapMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetTimeWrapMode_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetTimeWrapMode_Injected");
			PlayableHandle.GetScriptInstance_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetScriptInstance_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetScriptInstance_Injected");
			PlayableHandle.GetInputHandle_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetInputHandle_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetInputHandle_Injected");
			PlayableHandle.GetOutputHandle_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetOutputHandle_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetOutputHandle_Injected");
			PlayableHandle.SetInputWeightFromIndex_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetInputWeightFromIndex_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetInputWeightFromIndex_Injected");
			PlayableHandle.GetInputWeightFromIndex_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetInputWeightFromIndex_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetInputWeightFromIndex_Injected");
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x000AD480 File Offset: 0x000AB680
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 685794, RefRangeEnd = 685802, XrefRangeStart = 685768, XrefRangeEnd = 685794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayableOfType<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.MethodInfoStoreGeneric_IsPlayableOfType_Internal_Boolean_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x000AD4B0 File Offset: 0x000AB6B0
		public unsafe static PlayableHandle Null
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685806, RefRangeEnd = 685808, XrefRangeStart = 685802, XrefRangeEnd = 685806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x000AD4E0 File Offset: 0x000AB6E0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 685812, RefRangeEnd = 685821, XrefRangeStart = 685808, XrefRangeEnd = 685812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PlayableHandle x, PlayableHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x000AD52C File Offset: 0x000AB72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685821, XrefRangeEnd = 685830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x000AD570 File Offset: 0x000AB770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685830, XrefRangeEnd = 685834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PlayableHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x000AD5B0 File Offset: 0x000AB7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685834, XrefRangeEnd = 685836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x000AD5E0 File Offset: 0x000AB7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685836, XrefRangeEnd = 685837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x000AD62C File Offset: 0x000AB82C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 685844, RefRangeEnd = 685853, XrefRangeStart = 685837, XrefRangeEnd = 685844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000AD65C File Offset: 0x000AB85C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685858, RefRangeEnd = 685859, XrefRangeStart = 685853, XrefRangeEnd = 685858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetPlayableType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Internal_Type_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x000AD690 File Offset: 0x000AB890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685859, XrefRangeEnd = 685861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x000AD6D0 File Offset: 0x000AB8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685861, XrefRangeEnd = 685863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetPlayableType_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Injected_Private_Static_Type_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x000105E3 File Offset: 0x0000E7E3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06002A1A RID: 10778 RVA: 0x000AD710 File Offset: 0x000AB910
		// (set) Token: 0x06002A1B RID: 10779 RVA: 0x000105F5 File Offset: 0x0000E7F5
		public unsafe static PlayableHandle m_Null
		{
			get
			{
				PlayableHandle playableHandle;
				IL2CPP.il2cpp_field_static_get_value(PlayableHandle.NativeFieldInfoPtr_m_Null, (void*)(&playableHandle));
				return playableHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableHandle.NativeFieldInfoPtr_m_Null, (void*)(&value));
			}
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000AD72C File Offset: 0x000AB92C
		public T GetObject<T>() where T : class
		{
			bool flag = !this.IsValid();
			T t;
			if (flag)
			{
				t = default(T);
			}
			else
			{
				Object scriptInstance = this.GetScriptInstance();
				bool flag2 = scriptInstance == null;
				if (flag2)
				{
					t = default(T);
				}
				else
				{
					t = scriptInstance.Cast<T>();
				}
			}
			return t;
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000AD77C File Offset: 0x000AB97C
		public Playable GetInput(int inputPort)
		{
			return new Playable(this.GetInputHandle(inputPort));
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000AD79C File Offset: 0x000AB99C
		public Playable GetOutput(int outputPort)
		{
			return new Playable(this.GetOutputHandle(outputPort));
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x000AD7BC File Offset: 0x000AB9BC
		public bool SetInputWeight(int inputIndex, float weight)
		{
			bool flag = this.CheckInputBounds(inputIndex);
			bool flag2;
			if (flag)
			{
				this.SetInputWeightFromIndex(inputIndex, weight);
				flag2 = true;
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x000AD7E8 File Offset: 0x000AB9E8
		public float GetInputWeight(int inputIndex)
		{
			bool flag = this.CheckInputBounds(inputIndex);
			float num;
			if (flag)
			{
				num = this.GetInputWeightFromIndex(inputIndex);
			}
			else
			{
				num = 0f;
			}
			return num;
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x000AD818 File Offset: 0x000ABA18
		public void Destroy()
		{
			this.GetGraph().DestroyPlayable<Playable>(new Playable(this));
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x000AD840 File Offset: 0x000ABA40
		public static bool operator !=(PlayableHandle x, PlayableHandle y)
		{
			return !PlayableHandle.CompareVersion(x, y);
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x000AD85C File Offset: 0x000ABA5C
		public bool CheckInputBounds(int inputIndex)
		{
			return this.CheckInputBounds(inputIndex, false);
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x00010603 File Offset: 0x0000E803
		public bool CheckInputBounds(int inputIndex, bool acceptAny)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x00010610 File Offset: 0x0000E810
		public bool IsNull()
		{
			return PlayableHandle.IsNull_Injected(ref this);
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x00010618 File Offset: 0x0000E818
		public Type GetJobType()
		{
			return PlayableHandle.GetJobType_Injected(ref this);
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x00010620 File Offset: 0x0000E820
		public void SetScriptInstance(Object scriptInstance)
		{
			PlayableHandle.SetScriptInstance_Injected(ref this, scriptInstance);
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x00010629 File Offset: 0x0000E829
		public bool CanChangeInputs()
		{
			return PlayableHandle.CanChangeInputs_Injected(ref this);
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00010631 File Offset: 0x0000E831
		public bool CanSetWeights()
		{
			return PlayableHandle.CanSetWeights_Injected(ref this);
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00010639 File Offset: 0x0000E839
		public bool CanDestroy()
		{
			return PlayableHandle.CanDestroy_Injected(ref this);
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00010641 File Offset: 0x0000E841
		public PlayState GetPlayState()
		{
			return PlayableHandle.GetPlayState_Injected(ref this);
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00010649 File Offset: 0x0000E849
		public void Play()
		{
			PlayableHandle.Play_Injected(ref this);
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x00010651 File Offset: 0x0000E851
		public void Pause()
		{
			PlayableHandle.Pause_Injected(ref this);
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x00010659 File Offset: 0x0000E859
		public double GetSpeed()
		{
			return PlayableHandle.GetSpeed_Injected(ref this);
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00010661 File Offset: 0x0000E861
		public void SetSpeed(double value)
		{
			PlayableHandle.SetSpeed_Injected(ref this, value);
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x0001066A File Offset: 0x0000E86A
		public double GetTime()
		{
			return PlayableHandle.GetTime_Injected(ref this);
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00010672 File Offset: 0x0000E872
		public void SetTime(double value)
		{
			PlayableHandle.SetTime_Injected(ref this, value);
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x0001067B File Offset: 0x0000E87B
		public bool IsDone()
		{
			return PlayableHandle.IsDone_Injected(ref this);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x00010683 File Offset: 0x0000E883
		public void SetDone(bool value)
		{
			PlayableHandle.SetDone_Injected(ref this, value);
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x0001068C File Offset: 0x0000E88C
		public double GetDuration()
		{
			return PlayableHandle.GetDuration_Injected(ref this);
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00010694 File Offset: 0x0000E894
		public void SetDuration(double value)
		{
			PlayableHandle.SetDuration_Injected(ref this, value);
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x0001069D File Offset: 0x0000E89D
		public bool GetPropagateSetTime()
		{
			return PlayableHandle.GetPropagateSetTime_Injected(ref this);
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000106A5 File Offset: 0x0000E8A5
		public void SetPropagateSetTime(bool value)
		{
			PlayableHandle.SetPropagateSetTime_Injected(ref this, value);
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000AD878 File Offset: 0x000ABA78
		public PlayableGraph GetGraph()
		{
			PlayableGraph playableGraph;
			PlayableHandle.GetGraph_Injected(ref this, out playableGraph);
			return playableGraph;
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000106AE File Offset: 0x0000E8AE
		public int GetInputCount()
		{
			return PlayableHandle.GetInputCount_Injected(ref this);
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000106B6 File Offset: 0x0000E8B6
		public void SetInputCount(int value)
		{
			PlayableHandle.SetInputCount_Injected(ref this, value);
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x000106BF File Offset: 0x0000E8BF
		public int GetOutputCount()
		{
			return PlayableHandle.GetOutputCount_Injected(ref this);
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x000106C7 File Offset: 0x0000E8C7
		public void SetOutputCount(int value)
		{
			PlayableHandle.SetOutputCount_Injected(ref this, value);
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x000106D0 File Offset: 0x0000E8D0
		public void SetInputWeight(PlayableHandle input, float weight)
		{
			PlayableHandle.SetInputWeight_Injected(ref this, ref input, weight);
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x000106DB File Offset: 0x0000E8DB
		public void SetDelay(double delay)
		{
			PlayableHandle.SetDelay_Injected(ref this, delay);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x000106E4 File Offset: 0x0000E8E4
		public double GetDelay()
		{
			return PlayableHandle.GetDelay_Injected(ref this);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x000106EC File Offset: 0x0000E8EC
		public bool IsDelayed()
		{
			return PlayableHandle.IsDelayed_Injected(ref this);
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x000106F4 File Offset: 0x0000E8F4
		public double GetPreviousTime()
		{
			return PlayableHandle.GetPreviousTime_Injected(ref this);
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x000106FC File Offset: 0x0000E8FC
		public void SetLeadTime(float value)
		{
			PlayableHandle.SetLeadTime_Injected(ref this, value);
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00010705 File Offset: 0x0000E905
		public float GetLeadTime()
		{
			return PlayableHandle.GetLeadTime_Injected(ref this);
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x0001070D File Offset: 0x0000E90D
		public PlayableTraversalMode GetTraversalMode()
		{
			return PlayableHandle.GetTraversalMode_Injected(ref this);
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00010715 File Offset: 0x0000E915
		public void SetTraversalMode(PlayableTraversalMode mode)
		{
			PlayableHandle.SetTraversalMode_Injected(ref this, mode);
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x0001071E File Offset: 0x0000E91E
		public IntPtr GetJobData()
		{
			return PlayableHandle.GetJobData_Injected(ref this);
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00010726 File Offset: 0x0000E926
		public DirectorWrapMode GetTimeWrapMode()
		{
			return PlayableHandle.GetTimeWrapMode_Injected(ref this);
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x0001072E File Offset: 0x0000E92E
		public void SetTimeWrapMode(DirectorWrapMode mode)
		{
			PlayableHandle.SetTimeWrapMode_Injected(ref this, mode);
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00010737 File Offset: 0x0000E937
		public Object GetScriptInstance()
		{
			return PlayableHandle.GetScriptInstance_Injected(ref this);
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x000AD890 File Offset: 0x000ABA90
		public PlayableHandle GetInputHandle(int index)
		{
			PlayableHandle playableHandle;
			PlayableHandle.GetInputHandle_Injected(ref this, index, out playableHandle);
			return playableHandle;
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x000AD8A8 File Offset: 0x000ABAA8
		public PlayableHandle GetOutputHandle(int index)
		{
			PlayableHandle playableHandle;
			PlayableHandle.GetOutputHandle_Injected(ref this, index, out playableHandle);
			return playableHandle;
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x0001073F File Offset: 0x0000E93F
		public void SetInputWeightFromIndex(int index, float weight)
		{
			PlayableHandle.SetInputWeightFromIndex_Injected(ref this, index, weight);
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x00010749 File Offset: 0x0000E949
		public float GetInputWeightFromIndex(int index)
		{
			return PlayableHandle.GetInputWeightFromIndex_Injected(ref this, index);
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00010752 File Offset: 0x0000E952
		public static bool IsNull_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.IsNull_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x000AD8C0 File Offset: 0x000ABAC0
		public static Type GetJobType_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr intPtr = PlayableHandle.GetJobType_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x0001075F File Offset: 0x0000E95F
		public static void SetScriptInstance_Injected(ref PlayableHandle _unity_self, Object scriptInstance)
		{
			PlayableHandle.SetScriptInstance_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(scriptInstance));
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x00010772 File Offset: 0x0000E972
		public static bool CanChangeInputs_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.CanChangeInputs_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x0001077F File Offset: 0x0000E97F
		public static bool CanSetWeights_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.CanSetWeights_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x0001078C File Offset: 0x0000E98C
		public static bool CanDestroy_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.CanDestroy_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x00010799 File Offset: 0x0000E999
		public static PlayState GetPlayState_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetPlayState_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x000107A6 File Offset: 0x0000E9A6
		public static void Play_Injected(ref PlayableHandle _unity_self)
		{
			PlayableHandle.Play_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x000107B3 File Offset: 0x0000E9B3
		public static void Pause_Injected(ref PlayableHandle _unity_self)
		{
			PlayableHandle.Pause_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x000107C0 File Offset: 0x0000E9C0
		public static double GetSpeed_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetSpeed_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x000107CD File Offset: 0x0000E9CD
		public static void SetSpeed_Injected(ref PlayableHandle _unity_self, double value)
		{
			PlayableHandle.SetSpeed_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x000107DB File Offset: 0x0000E9DB
		public static double GetTime_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x000107E8 File Offset: 0x0000E9E8
		public static void SetTime_Injected(ref PlayableHandle _unity_self, double value)
		{
			PlayableHandle.SetTime_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x000107F6 File Offset: 0x0000E9F6
		public static bool IsDone_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.IsDone_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x00010803 File Offset: 0x0000EA03
		public static void SetDone_Injected(ref PlayableHandle _unity_self, bool value)
		{
			PlayableHandle.SetDone_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x00010811 File Offset: 0x0000EA11
		public static double GetDuration_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetDuration_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x0001081E File Offset: 0x0000EA1E
		public static void SetDuration_Injected(ref PlayableHandle _unity_self, double value)
		{
			PlayableHandle.SetDuration_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x0001082C File Offset: 0x0000EA2C
		public static bool GetPropagateSetTime_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetPropagateSetTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x00010839 File Offset: 0x0000EA39
		public static void SetPropagateSetTime_Injected(ref PlayableHandle _unity_self, bool value)
		{
			PlayableHandle.SetPropagateSetTime_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x00010847 File Offset: 0x0000EA47
		public static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret)
		{
			PlayableHandle.GetGraph_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x00010855 File Offset: 0x0000EA55
		public static int GetInputCount_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetInputCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x00010862 File Offset: 0x0000EA62
		public static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value)
		{
			PlayableHandle.SetInputCount_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x00010870 File Offset: 0x0000EA70
		public static int GetOutputCount_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetOutputCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x0001087D File Offset: 0x0000EA7D
		public static void SetOutputCount_Injected(ref PlayableHandle _unity_self, int value)
		{
			PlayableHandle.SetOutputCount_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x0001088B File Offset: 0x0000EA8B
		public static void SetInputWeight_Injected(ref PlayableHandle _unity_self, ref PlayableHandle input, float weight)
		{
			PlayableHandle.SetInputWeight_InjectedDelegateField(ref _unity_self, ref input, weight);
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x0001089A File Offset: 0x0000EA9A
		public static void SetDelay_Injected(ref PlayableHandle _unity_self, double delay)
		{
			PlayableHandle.SetDelay_InjectedDelegateField(ref _unity_self, delay);
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x000108A8 File Offset: 0x0000EAA8
		public static double GetDelay_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetDelay_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x000108B5 File Offset: 0x0000EAB5
		public static bool IsDelayed_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.IsDelayed_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x000108C2 File Offset: 0x0000EAC2
		public static double GetPreviousTime_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetPreviousTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x000108CF File Offset: 0x0000EACF
		public static void SetLeadTime_Injected(ref PlayableHandle _unity_self, float value)
		{
			PlayableHandle.SetLeadTime_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x000108DD File Offset: 0x0000EADD
		public static float GetLeadTime_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetLeadTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x000108EA File Offset: 0x0000EAEA
		public static PlayableTraversalMode GetTraversalMode_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetTraversalMode_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x000108F7 File Offset: 0x0000EAF7
		public static void SetTraversalMode_Injected(ref PlayableHandle _unity_self, PlayableTraversalMode mode)
		{
			PlayableHandle.SetTraversalMode_InjectedDelegateField(ref _unity_self, mode);
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x00010905 File Offset: 0x0000EB05
		public static IntPtr GetJobData_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetJobData_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x00010912 File Offset: 0x0000EB12
		public static DirectorWrapMode GetTimeWrapMode_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetTimeWrapMode_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x0001091F File Offset: 0x0000EB1F
		public static void SetTimeWrapMode_Injected(ref PlayableHandle _unity_self, DirectorWrapMode mode)
		{
			PlayableHandle.SetTimeWrapMode_InjectedDelegateField(ref _unity_self, mode);
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x000AD8E8 File Offset: 0x000ABAE8
		public static Object GetScriptInstance_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr intPtr = PlayableHandle.GetScriptInstance_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x0001092D File Offset: 0x0000EB2D
		public static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret)
		{
			PlayableHandle.GetInputHandle_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x0001093C File Offset: 0x0000EB3C
		public static void GetOutputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret)
		{
			PlayableHandle.GetOutputHandle_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x0001094B File Offset: 0x0000EB4B
		public static void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight)
		{
			PlayableHandle.SetInputWeightFromIndex_InjectedDelegateField(ref _unity_self, index, weight);
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x0001095A File Offset: 0x0000EB5A
		public static float GetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index)
		{
			return PlayableHandle.GetInputWeightFromIndex_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x0400250B RID: 9483
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400250C RID: 9484
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x0400250D RID: 9485
		private static readonly IntPtr NativeFieldInfoPtr_m_Null;

		// Token: 0x0400250E RID: 9486
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0;

		// Token: 0x0400250F RID: 9487
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0;

		// Token: 0x04002510 RID: 9488
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0;

		// Token: 0x04002511 RID: 9489
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002512 RID: 9490
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0;

		// Token: 0x04002513 RID: 9491
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002514 RID: 9492
		private static readonly IntPtr NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0;

		// Token: 0x04002515 RID: 9493
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_0;

		// Token: 0x04002516 RID: 9494
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableType_Internal_Type_0;

		// Token: 0x04002517 RID: 9495
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableHandle_0;

		// Token: 0x04002518 RID: 9496
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableType_Injected_Private_Static_Type_byref_PlayableHandle_0;

		// Token: 0x04002519 RID: 9497
		[FieldOffset(0)]
		public IntPtr m_Handle;

		// Token: 0x0400251A RID: 9498
		[FieldOffset(8)]
		public uint m_Version;

		// Token: 0x0400251B RID: 9499
		private static readonly PlayableHandle.IsNull_InjectedDelegate IsNull_InjectedDelegateField;

		// Token: 0x0400251C RID: 9500
		private static readonly PlayableHandle.GetJobType_InjectedDelegate GetJobType_InjectedDelegateField;

		// Token: 0x0400251D RID: 9501
		private static readonly PlayableHandle.SetScriptInstance_InjectedDelegate SetScriptInstance_InjectedDelegateField;

		// Token: 0x0400251E RID: 9502
		private static readonly PlayableHandle.CanChangeInputs_InjectedDelegate CanChangeInputs_InjectedDelegateField;

		// Token: 0x0400251F RID: 9503
		private static readonly PlayableHandle.CanSetWeights_InjectedDelegate CanSetWeights_InjectedDelegateField;

		// Token: 0x04002520 RID: 9504
		private static readonly PlayableHandle.CanDestroy_InjectedDelegate CanDestroy_InjectedDelegateField;

		// Token: 0x04002521 RID: 9505
		private static readonly PlayableHandle.GetPlayState_InjectedDelegate GetPlayState_InjectedDelegateField;

		// Token: 0x04002522 RID: 9506
		private static readonly PlayableHandle.Play_InjectedDelegate Play_InjectedDelegateField;

		// Token: 0x04002523 RID: 9507
		private static readonly PlayableHandle.Pause_InjectedDelegate Pause_InjectedDelegateField;

		// Token: 0x04002524 RID: 9508
		private static readonly PlayableHandle.GetSpeed_InjectedDelegate GetSpeed_InjectedDelegateField;

		// Token: 0x04002525 RID: 9509
		private static readonly PlayableHandle.SetSpeed_InjectedDelegate SetSpeed_InjectedDelegateField;

		// Token: 0x04002526 RID: 9510
		private static readonly PlayableHandle.GetTime_InjectedDelegate GetTime_InjectedDelegateField;

		// Token: 0x04002527 RID: 9511
		private static readonly PlayableHandle.SetTime_InjectedDelegate SetTime_InjectedDelegateField;

		// Token: 0x04002528 RID: 9512
		private static readonly PlayableHandle.IsDone_InjectedDelegate IsDone_InjectedDelegateField;

		// Token: 0x04002529 RID: 9513
		private static readonly PlayableHandle.SetDone_InjectedDelegate SetDone_InjectedDelegateField;

		// Token: 0x0400252A RID: 9514
		private static readonly PlayableHandle.GetDuration_InjectedDelegate GetDuration_InjectedDelegateField;

		// Token: 0x0400252B RID: 9515
		private static readonly PlayableHandle.SetDuration_InjectedDelegate SetDuration_InjectedDelegateField;

		// Token: 0x0400252C RID: 9516
		private static readonly PlayableHandle.GetPropagateSetTime_InjectedDelegate GetPropagateSetTime_InjectedDelegateField;

		// Token: 0x0400252D RID: 9517
		private static readonly PlayableHandle.SetPropagateSetTime_InjectedDelegate SetPropagateSetTime_InjectedDelegateField;

		// Token: 0x0400252E RID: 9518
		private static readonly PlayableHandle.GetGraph_InjectedDelegate GetGraph_InjectedDelegateField;

		// Token: 0x0400252F RID: 9519
		private static readonly PlayableHandle.GetInputCount_InjectedDelegate GetInputCount_InjectedDelegateField;

		// Token: 0x04002530 RID: 9520
		private static readonly PlayableHandle.SetInputCount_InjectedDelegate SetInputCount_InjectedDelegateField;

		// Token: 0x04002531 RID: 9521
		private static readonly PlayableHandle.GetOutputCount_InjectedDelegate GetOutputCount_InjectedDelegateField;

		// Token: 0x04002532 RID: 9522
		private static readonly PlayableHandle.SetOutputCount_InjectedDelegate SetOutputCount_InjectedDelegateField;

		// Token: 0x04002533 RID: 9523
		private static readonly PlayableHandle.SetInputWeight_InjectedDelegate SetInputWeight_InjectedDelegateField;

		// Token: 0x04002534 RID: 9524
		private static readonly PlayableHandle.SetDelay_InjectedDelegate SetDelay_InjectedDelegateField;

		// Token: 0x04002535 RID: 9525
		private static readonly PlayableHandle.GetDelay_InjectedDelegate GetDelay_InjectedDelegateField;

		// Token: 0x04002536 RID: 9526
		private static readonly PlayableHandle.IsDelayed_InjectedDelegate IsDelayed_InjectedDelegateField;

		// Token: 0x04002537 RID: 9527
		private static readonly PlayableHandle.GetPreviousTime_InjectedDelegate GetPreviousTime_InjectedDelegateField;

		// Token: 0x04002538 RID: 9528
		private static readonly PlayableHandle.SetLeadTime_InjectedDelegate SetLeadTime_InjectedDelegateField;

		// Token: 0x04002539 RID: 9529
		private static readonly PlayableHandle.GetLeadTime_InjectedDelegate GetLeadTime_InjectedDelegateField;

		// Token: 0x0400253A RID: 9530
		private static readonly PlayableHandle.GetTraversalMode_InjectedDelegate GetTraversalMode_InjectedDelegateField;

		// Token: 0x0400253B RID: 9531
		private static readonly PlayableHandle.SetTraversalMode_InjectedDelegate SetTraversalMode_InjectedDelegateField;

		// Token: 0x0400253C RID: 9532
		private static readonly PlayableHandle.GetJobData_InjectedDelegate GetJobData_InjectedDelegateField;

		// Token: 0x0400253D RID: 9533
		private static readonly PlayableHandle.GetTimeWrapMode_InjectedDelegate GetTimeWrapMode_InjectedDelegateField;

		// Token: 0x0400253E RID: 9534
		private static readonly PlayableHandle.SetTimeWrapMode_InjectedDelegate SetTimeWrapMode_InjectedDelegateField;

		// Token: 0x0400253F RID: 9535
		private static readonly PlayableHandle.GetScriptInstance_InjectedDelegate GetScriptInstance_InjectedDelegateField;

		// Token: 0x04002540 RID: 9536
		private static readonly PlayableHandle.GetInputHandle_InjectedDelegate GetInputHandle_InjectedDelegateField;

		// Token: 0x04002541 RID: 9537
		private static readonly PlayableHandle.GetOutputHandle_InjectedDelegate GetOutputHandle_InjectedDelegateField;

		// Token: 0x04002542 RID: 9538
		private static readonly PlayableHandle.SetInputWeightFromIndex_InjectedDelegate SetInputWeightFromIndex_InjectedDelegateField;

		// Token: 0x04002543 RID: 9539
		private static readonly PlayableHandle.GetInputWeightFromIndex_InjectedDelegate GetInputWeightFromIndex_InjectedDelegateField;

		// Token: 0x02000A23 RID: 2595
		private sealed class MethodInfoStoreGeneric_IsPlayableOfType_Internal_Boolean_0<T>
		{
			// Token: 0x04002D50 RID: 11600
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableHandle.NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0, Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A24 RID: 2596
		// (Invoke) Token: 0x06003D65 RID: 15717
		private delegate bool IsNull_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A25 RID: 2597
		// (Invoke) Token: 0x06003D67 RID: 15719
		private delegate IntPtr GetJobType_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A26 RID: 2598
		// (Invoke) Token: 0x06003D69 RID: 15721
		private delegate void SetScriptInstance_InjectedDelegate(IntPtr _unity_self, IntPtr scriptInstance);

		// Token: 0x02000A27 RID: 2599
		// (Invoke) Token: 0x06003D6B RID: 15723
		private delegate bool CanChangeInputs_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A28 RID: 2600
		// (Invoke) Token: 0x06003D6D RID: 15725
		private delegate bool CanSetWeights_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A29 RID: 2601
		// (Invoke) Token: 0x06003D6F RID: 15727
		private delegate bool CanDestroy_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A2A RID: 2602
		// (Invoke) Token: 0x06003D71 RID: 15729
		private delegate PlayState GetPlayState_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A2B RID: 2603
		// (Invoke) Token: 0x06003D73 RID: 15731
		private delegate void Play_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A2C RID: 2604
		// (Invoke) Token: 0x06003D75 RID: 15733
		private delegate void Pause_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A2D RID: 2605
		// (Invoke) Token: 0x06003D77 RID: 15735
		private delegate double GetSpeed_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A2E RID: 2606
		// (Invoke) Token: 0x06003D79 RID: 15737
		private delegate void SetSpeed_InjectedDelegate(IntPtr _unity_self, double value);

		// Token: 0x02000A2F RID: 2607
		// (Invoke) Token: 0x06003D7B RID: 15739
		private delegate double GetTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A30 RID: 2608
		// (Invoke) Token: 0x06003D7D RID: 15741
		private delegate void SetTime_InjectedDelegate(IntPtr _unity_self, double value);

		// Token: 0x02000A31 RID: 2609
		// (Invoke) Token: 0x06003D7F RID: 15743
		private delegate bool IsDone_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A32 RID: 2610
		// (Invoke) Token: 0x06003D81 RID: 15745
		private delegate void SetDone_InjectedDelegate(IntPtr _unity_self, bool value);

		// Token: 0x02000A33 RID: 2611
		// (Invoke) Token: 0x06003D83 RID: 15747
		private delegate double GetDuration_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A34 RID: 2612
		// (Invoke) Token: 0x06003D85 RID: 15749
		private delegate void SetDuration_InjectedDelegate(IntPtr _unity_self, double value);

		// Token: 0x02000A35 RID: 2613
		// (Invoke) Token: 0x06003D87 RID: 15751
		private delegate bool GetPropagateSetTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A36 RID: 2614
		// (Invoke) Token: 0x06003D89 RID: 15753
		private delegate void SetPropagateSetTime_InjectedDelegate(IntPtr _unity_self, bool value);

		// Token: 0x02000A37 RID: 2615
		// (Invoke) Token: 0x06003D8B RID: 15755
		private delegate void GetGraph_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000A38 RID: 2616
		// (Invoke) Token: 0x06003D8D RID: 15757
		private delegate int GetInputCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A39 RID: 2617
		// (Invoke) Token: 0x06003D8F RID: 15759
		private delegate void SetInputCount_InjectedDelegate(IntPtr _unity_self, int value);

		// Token: 0x02000A3A RID: 2618
		// (Invoke) Token: 0x06003D91 RID: 15761
		private delegate int GetOutputCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A3B RID: 2619
		// (Invoke) Token: 0x06003D93 RID: 15763
		private delegate void SetOutputCount_InjectedDelegate(IntPtr _unity_self, int value);

		// Token: 0x02000A3C RID: 2620
		// (Invoke) Token: 0x06003D95 RID: 15765
		private delegate void SetInputWeight_InjectedDelegate(IntPtr _unity_self, IntPtr input, float weight);

		// Token: 0x02000A3D RID: 2621
		// (Invoke) Token: 0x06003D97 RID: 15767
		private delegate void SetDelay_InjectedDelegate(IntPtr _unity_self, double delay);

		// Token: 0x02000A3E RID: 2622
		// (Invoke) Token: 0x06003D99 RID: 15769
		private delegate double GetDelay_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A3F RID: 2623
		// (Invoke) Token: 0x06003D9B RID: 15771
		private delegate bool IsDelayed_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A40 RID: 2624
		// (Invoke) Token: 0x06003D9D RID: 15773
		private delegate double GetPreviousTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A41 RID: 2625
		// (Invoke) Token: 0x06003D9F RID: 15775
		private delegate void SetLeadTime_InjectedDelegate(IntPtr _unity_self, float value);

		// Token: 0x02000A42 RID: 2626
		// (Invoke) Token: 0x06003DA1 RID: 15777
		private delegate float GetLeadTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A43 RID: 2627
		// (Invoke) Token: 0x06003DA3 RID: 15779
		private delegate PlayableTraversalMode GetTraversalMode_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A44 RID: 2628
		// (Invoke) Token: 0x06003DA5 RID: 15781
		private delegate void SetTraversalMode_InjectedDelegate(IntPtr _unity_self, PlayableTraversalMode mode);

		// Token: 0x02000A45 RID: 2629
		// (Invoke) Token: 0x06003DA7 RID: 15783
		private delegate IntPtr GetJobData_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A46 RID: 2630
		// (Invoke) Token: 0x06003DA9 RID: 15785
		private delegate DirectorWrapMode GetTimeWrapMode_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A47 RID: 2631
		// (Invoke) Token: 0x06003DAB RID: 15787
		private delegate void SetTimeWrapMode_InjectedDelegate(IntPtr _unity_self, DirectorWrapMode mode);

		// Token: 0x02000A48 RID: 2632
		// (Invoke) Token: 0x06003DAD RID: 15789
		private delegate IntPtr GetScriptInstance_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A49 RID: 2633
		// (Invoke) Token: 0x06003DAF RID: 15791
		private delegate void GetInputHandle_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr ret);

		// Token: 0x02000A4A RID: 2634
		// (Invoke) Token: 0x06003DB1 RID: 15793
		private delegate void GetOutputHandle_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr ret);

		// Token: 0x02000A4B RID: 2635
		// (Invoke) Token: 0x06003DB3 RID: 15795
		private delegate void SetInputWeightFromIndex_InjectedDelegate(IntPtr _unity_self, int index, float weight);

		// Token: 0x02000A4C RID: 2636
		// (Invoke) Token: 0x06003DB5 RID: 15797
		private delegate float GetInputWeightFromIndex_InjectedDelegate(IntPtr _unity_self, int index);
	}
}
