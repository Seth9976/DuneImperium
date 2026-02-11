using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000002 RID: 2
	public class PlayableDirector : Behaviour
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000238C File Offset: 0x0000058C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableDirector()
		{
			Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.DirectorModule.dll", "UnityEngine.Playables", "PlayableDirector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr);
			PlayableDirector.NativeFieldInfoPtr_played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, "played");
			PlayableDirector.NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, "paused");
			PlayableDirector.NativeFieldInfoPtr_stopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, "stopped");
			PlayableDirector.NativeMethodInfoPtr_SendOnPlayableDirectorPlay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663297);
			PlayableDirector.NativeMethodInfoPtr_SendOnPlayableDirectorPause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663298);
			PlayableDirector.NativeMethodInfoPtr_SendOnPlayableDirectorStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirector>.NativeClassPtr, 100663299);
			PlayableDirector.set_timeUpdateModeDelegateField = IL2CPP.ResolveICall<PlayableDirector.set_timeUpdateModeDelegate>("UnityEngine.Playables.PlayableDirector::set_timeUpdateMode");
			PlayableDirector.get_timeUpdateModeDelegateField = IL2CPP.ResolveICall<PlayableDirector.get_timeUpdateModeDelegate>("UnityEngine.Playables.PlayableDirector::get_timeUpdateMode");
			PlayableDirector.set_timeDelegateField = IL2CPP.ResolveICall<PlayableDirector.set_timeDelegate>("UnityEngine.Playables.PlayableDirector::set_time");
			PlayableDirector.get_timeDelegateField = IL2CPP.ResolveICall<PlayableDirector.get_timeDelegate>("UnityEngine.Playables.PlayableDirector::get_time");
			PlayableDirector.set_initialTimeDelegateField = IL2CPP.ResolveICall<PlayableDirector.set_initialTimeDelegate>("UnityEngine.Playables.PlayableDirector::set_initialTime");
			PlayableDirector.get_initialTimeDelegateField = IL2CPP.ResolveICall<PlayableDirector.get_initialTimeDelegate>("UnityEngine.Playables.PlayableDirector::get_initialTime");
			PlayableDirector.get_durationDelegateField = IL2CPP.ResolveICall<PlayableDirector.get_durationDelegate>("UnityEngine.Playables.PlayableDirector::get_duration");
			PlayableDirector.EvaluateDelegateField = IL2CPP.ResolveICall<PlayableDirector.EvaluateDelegate>("UnityEngine.Playables.PlayableDirector::Evaluate");
			PlayableDirector.PlayDelegateField = IL2CPP.ResolveICall<PlayableDirector.PlayDelegate>("UnityEngine.Playables.PlayableDirector::Play");
			PlayableDirector.StopDelegateField = IL2CPP.ResolveICall<PlayableDirector.StopDelegate>("UnityEngine.Playables.PlayableDirector::Stop");
			PlayableDirector.PauseDelegateField = IL2CPP.ResolveICall<PlayableDirector.PauseDelegate>("UnityEngine.Playables.PlayableDirector::Pause");
			PlayableDirector.ResumeDelegateField = IL2CPP.ResolveICall<PlayableDirector.ResumeDelegate>("UnityEngine.Playables.PlayableDirector::Resume");
			PlayableDirector.RebuildGraphDelegateField = IL2CPP.ResolveICall<PlayableDirector.RebuildGraphDelegate>("UnityEngine.Playables.PlayableDirector::RebuildGraph");
			PlayableDirector.GetGenericBindingDelegateField = IL2CPP.ResolveICall<PlayableDirector.GetGenericBindingDelegate>("UnityEngine.Playables.PlayableDirector::GetGenericBinding");
			PlayableDirector.ClearGenericBindingDelegateField = IL2CPP.ResolveICall<PlayableDirector.ClearGenericBindingDelegate>("UnityEngine.Playables.PlayableDirector::ClearGenericBinding");
			PlayableDirector.RebindPlayableGraphOutputsDelegateField = IL2CPP.ResolveICall<PlayableDirector.RebindPlayableGraphOutputsDelegate>("UnityEngine.Playables.PlayableDirector::RebindPlayableGraphOutputs");
			PlayableDirector.ProcessPendingGraphChangesDelegateField = IL2CPP.ResolveICall<PlayableDirector.ProcessPendingGraphChangesDelegate>("UnityEngine.Playables.PlayableDirector::ProcessPendingGraphChanges");
			PlayableDirector.HasGenericBindingDelegateField = IL2CPP.ResolveICall<PlayableDirector.HasGenericBindingDelegate>("UnityEngine.Playables.PlayableDirector::HasGenericBinding");
			PlayableDirector.GetPlayStateDelegateField = IL2CPP.ResolveICall<PlayableDirector.GetPlayStateDelegate>("UnityEngine.Playables.PlayableDirector::GetPlayState");
			PlayableDirector.SetWrapModeDelegateField = IL2CPP.ResolveICall<PlayableDirector.SetWrapModeDelegate>("UnityEngine.Playables.PlayableDirector::SetWrapMode");
			PlayableDirector.GetWrapModeDelegateField = IL2CPP.ResolveICall<PlayableDirector.GetWrapModeDelegate>("UnityEngine.Playables.PlayableDirector::GetWrapMode");
			PlayableDirector.EvaluateNextFrameDelegateField = IL2CPP.ResolveICall<PlayableDirector.EvaluateNextFrameDelegate>("UnityEngine.Playables.PlayableDirector::EvaluateNextFrame");
			PlayableDirector.SetPlayOnAwakeDelegateField = IL2CPP.ResolveICall<PlayableDirector.SetPlayOnAwakeDelegate>("UnityEngine.Playables.PlayableDirector::SetPlayOnAwake");
			PlayableDirector.GetPlayOnAwakeDelegateField = IL2CPP.ResolveICall<PlayableDirector.GetPlayOnAwakeDelegate>("UnityEngine.Playables.PlayableDirector::GetPlayOnAwake");
			PlayableDirector.Internal_SetGenericBindingDelegateField = IL2CPP.ResolveICall<PlayableDirector.Internal_SetGenericBindingDelegate>("UnityEngine.Playables.PlayableDirector::Internal_SetGenericBinding");
			PlayableDirector.SetPlayableAssetDelegateField = IL2CPP.ResolveICall<PlayableDirector.SetPlayableAssetDelegate>("UnityEngine.Playables.PlayableDirector::SetPlayableAsset");
			PlayableDirector.Internal_GetPlayableAssetDelegateField = IL2CPP.ResolveICall<PlayableDirector.Internal_GetPlayableAssetDelegate>("UnityEngine.Playables.PlayableDirector::Internal_GetPlayableAsset");
			PlayableDirector.ResetFrameTimingDelegateField = IL2CPP.ResolveICall<PlayableDirector.ResetFrameTimingDelegate>("UnityEngine.Playables.PlayableDirector::ResetFrameTiming");
			PlayableDirector.ClearReferenceValue_InjectedDelegateField = IL2CPP.ResolveICall<PlayableDirector.ClearReferenceValue_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::ClearReferenceValue_Injected");
			PlayableDirector.SetReferenceValue_InjectedDelegateField = IL2CPP.ResolveICall<PlayableDirector.SetReferenceValue_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::SetReferenceValue_Injected");
			PlayableDirector.GetReferenceValue_InjectedDelegateField = IL2CPP.ResolveICall<PlayableDirector.GetReferenceValue_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::GetReferenceValue_Injected");
			PlayableDirector.GetGraphHandle_InjectedDelegateField = IL2CPP.ResolveICall<PlayableDirector.GetGraphHandle_InjectedDelegate>("UnityEngine.Playables.PlayableDirector::GetGraphHandle_Injected");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002614 File Offset: 0x00000814
		[CallerCount(0)]
		public unsafe void SendOnPlayableDirectorPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_SendOnPlayableDirectorPlay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002648 File Offset: 0x00000848
		[CallerCount(0)]
		public unsafe void SendOnPlayableDirectorPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_SendOnPlayableDirectorPause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000267C File Offset: 0x0000087C
		[CallerCount(0)]
		public unsafe void SendOnPlayableDirectorStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableDirector.NativeMethodInfoPtr_SendOnPlayableDirectorStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public PlayableDirector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000026B0 File Offset: 0x000008B0
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe Action<PlayableDirector> played
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableDirector.NativeFieldInfoPtr_played);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayableDirector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableDirector.NativeFieldInfoPtr_played), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000026E0 File Offset: 0x000008E0
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002078 File Offset: 0x00000278
		public unsafe Action<PlayableDirector> paused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableDirector.NativeFieldInfoPtr_paused);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayableDirector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableDirector.NativeFieldInfoPtr_paused), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002710 File Offset: 0x00000910
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002097 File Offset: 0x00000297
		public unsafe Action<PlayableDirector> stopped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableDirector.NativeFieldInfoPtr_stopped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayableDirector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableDirector.NativeFieldInfoPtr_stopped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002740 File Offset: 0x00000940
		public PlayState state
		{
			get
			{
				return this.GetPlayState();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002758 File Offset: 0x00000958
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000020B6 File Offset: 0x000002B6
		public DirectorWrapMode extrapolationMode
		{
			get
			{
				return this.GetWrapMode();
			}
			set
			{
				this.SetWrapMode(value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002770 File Offset: 0x00000970
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000020C1 File Offset: 0x000002C1
		public PlayableAsset playableAsset
		{
			get
			{
				return this.Internal_GetPlayableAsset().TryCast<PlayableAsset>();
			}
			set
			{
				this.SetPlayableAsset(value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002790 File Offset: 0x00000990
		public PlayableGraph playableGraph
		{
			get
			{
				return this.GetGraphHandle();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000027A8 File Offset: 0x000009A8
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000020CC File Offset: 0x000002CC
		public bool playOnAwake
		{
			get
			{
				return this.GetPlayOnAwake();
			}
			set
			{
				this.SetPlayOnAwake(value);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020D7 File Offset: 0x000002D7
		public void DeferredEvaluate()
		{
			this.EvaluateNextFrame();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000027C0 File Offset: 0x000009C0
		public void Play(PlayableAsset asset)
		{
			bool flag = asset == null;
			if (flag)
			{
				throw new ArgumentNullException("asset");
			}
			this.Play(asset, this.extrapolationMode);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000027F4 File Offset: 0x000009F4
		public void Play(PlayableAsset asset, DirectorWrapMode mode)
		{
			bool flag = asset == null;
			if (flag)
			{
				throw new ArgumentNullException("asset");
			}
			this.playableAsset = asset;
			this.extrapolationMode = mode;
			this.Play();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020E1 File Offset: 0x000002E1
		public void SetGenericBinding(Object key, Object value)
		{
			this.Internal_SetGenericBinding(key, value);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002100 File Offset: 0x00000300
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000020ED File Offset: 0x000002ED
		public DirectorUpdateMode timeUpdateMode
		{
			get
			{
				return PlayableDirector.get_timeUpdateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlayableDirector.set_timeUpdateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002125 File Offset: 0x00000325
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002112 File Offset: 0x00000312
		public double time
		{
			get
			{
				return PlayableDirector.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlayableDirector.set_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0000214A File Offset: 0x0000034A
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002137 File Offset: 0x00000337
		public double initialTime
		{
			get
			{
				return PlayableDirector.get_initialTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlayableDirector.set_initialTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000215C File Offset: 0x0000035C
		public double duration
		{
			get
			{
				return PlayableDirector.get_durationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000216E File Offset: 0x0000036E
		public void Evaluate()
		{
			PlayableDirector.EvaluateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002180 File Offset: 0x00000380
		public void Play()
		{
			PlayableDirector.PlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002192 File Offset: 0x00000392
		public void Stop()
		{
			PlayableDirector.StopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000021A4 File Offset: 0x000003A4
		public void Pause()
		{
			PlayableDirector.PauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021B6 File Offset: 0x000003B6
		public void Resume()
		{
			PlayableDirector.ResumeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000021C8 File Offset: 0x000003C8
		public void RebuildGraph()
		{
			PlayableDirector.RebuildGraphDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000021DA File Offset: 0x000003DA
		public void ClearReferenceValue(PropertyName id)
		{
			this.ClearReferenceValue_Injected(ref id);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000021E4 File Offset: 0x000003E4
		public void SetReferenceValue(PropertyName id, Object value)
		{
			this.SetReferenceValue_Injected(ref id, value);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000021EF File Offset: 0x000003EF
		public Object GetReferenceValue(PropertyName id, out bool idValid)
		{
			return this.GetReferenceValue_Injected(ref id, out idValid);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002830 File Offset: 0x00000A30
		public Object GetGenericBinding(Object key)
		{
			IntPtr intPtr = PlayableDirector.GetGenericBindingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(key));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000021FA File Offset: 0x000003FA
		public void ClearGenericBinding(Object key)
		{
			PlayableDirector.ClearGenericBindingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(key));
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002212 File Offset: 0x00000412
		public void RebindPlayableGraphOutputs()
		{
			PlayableDirector.RebindPlayableGraphOutputsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002224 File Offset: 0x00000424
		public void ProcessPendingGraphChanges()
		{
			PlayableDirector.ProcessPendingGraphChangesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002236 File Offset: 0x00000436
		public bool HasGenericBinding(Object key)
		{
			return PlayableDirector.HasGenericBindingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(key));
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000224E File Offset: 0x0000044E
		public PlayState GetPlayState()
		{
			return PlayableDirector.GetPlayStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002260 File Offset: 0x00000460
		public void SetWrapMode(DirectorWrapMode mode)
		{
			PlayableDirector.SetWrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mode);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002273 File Offset: 0x00000473
		public DirectorWrapMode GetWrapMode()
		{
			return PlayableDirector.GetWrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002285 File Offset: 0x00000485
		public void EvaluateNextFrame()
		{
			PlayableDirector.EvaluateNextFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002864 File Offset: 0x00000A64
		public PlayableGraph GetGraphHandle()
		{
			PlayableGraph playableGraph;
			this.GetGraphHandle_Injected(out playableGraph);
			return playableGraph;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002297 File Offset: 0x00000497
		public void SetPlayOnAwake(bool on)
		{
			PlayableDirector.SetPlayOnAwakeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), on);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000022AA File Offset: 0x000004AA
		public bool GetPlayOnAwake()
		{
			return PlayableDirector.GetPlayOnAwakeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000022BC File Offset: 0x000004BC
		public void Internal_SetGenericBinding(Object key, Object value)
		{
			PlayableDirector.Internal_SetGenericBindingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(key), IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000022DA File Offset: 0x000004DA
		public void SetPlayableAsset(ScriptableObject asset)
		{
			PlayableDirector.SetPlayableAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(asset));
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000287C File Offset: 0x00000A7C
		public ScriptableObject Internal_GetPlayableAsset()
		{
			IntPtr intPtr = PlayableDirector.Internal_GetPlayableAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000022F2 File Offset: 0x000004F2
		public void add_played(Action<PlayableDirector> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000022FF File Offset: 0x000004FF
		public void remove_played(Action<PlayableDirector> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000230C File Offset: 0x0000050C
		public void add_paused(Action<PlayableDirector> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002319 File Offset: 0x00000519
		public void remove_paused(Action<PlayableDirector> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002326 File Offset: 0x00000526
		public void add_stopped(Action<PlayableDirector> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002333 File Offset: 0x00000533
		public void remove_stopped(Action<PlayableDirector> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002340 File Offset: 0x00000540
		public static void ResetFrameTiming()
		{
			PlayableDirector.ResetFrameTimingDelegateField();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000234C File Offset: 0x0000054C
		public void ClearReferenceValue_Injected(ref PropertyName id)
		{
			PlayableDirector.ClearReferenceValue_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref id);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000235F File Offset: 0x0000055F
		public void SetReferenceValue_Injected(ref PropertyName id, Object value)
		{
			PlayableDirector.SetReferenceValue_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref id, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000028A8 File Offset: 0x00000AA8
		public Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid)
		{
			IntPtr intPtr = PlayableDirector.GetReferenceValue_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref id, out idValid);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002378 File Offset: 0x00000578
		public void GetGraphHandle_Injected(out PlayableGraph ret)
		{
			PlayableDirector.GetGraphHandle_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_played;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_paused;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_stopped;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_SendOnPlayableDirectorPlay_Private_Void_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_SendOnPlayableDirectorPause_Private_Void_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_SendOnPlayableDirectorStop_Private_Void_0;

		// Token: 0x04000007 RID: 7
		private static readonly PlayableDirector.set_timeUpdateModeDelegate set_timeUpdateModeDelegateField;

		// Token: 0x04000008 RID: 8
		private static readonly PlayableDirector.get_timeUpdateModeDelegate get_timeUpdateModeDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly PlayableDirector.set_timeDelegate set_timeDelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly PlayableDirector.get_timeDelegate get_timeDelegateField;

		// Token: 0x0400000B RID: 11
		private static readonly PlayableDirector.set_initialTimeDelegate set_initialTimeDelegateField;

		// Token: 0x0400000C RID: 12
		private static readonly PlayableDirector.get_initialTimeDelegate get_initialTimeDelegateField;

		// Token: 0x0400000D RID: 13
		private static readonly PlayableDirector.get_durationDelegate get_durationDelegateField;

		// Token: 0x0400000E RID: 14
		private static readonly PlayableDirector.EvaluateDelegate EvaluateDelegateField;

		// Token: 0x0400000F RID: 15
		private static readonly PlayableDirector.PlayDelegate PlayDelegateField;

		// Token: 0x04000010 RID: 16
		private static readonly PlayableDirector.StopDelegate StopDelegateField;

		// Token: 0x04000011 RID: 17
		private static readonly PlayableDirector.PauseDelegate PauseDelegateField;

		// Token: 0x04000012 RID: 18
		private static readonly PlayableDirector.ResumeDelegate ResumeDelegateField;

		// Token: 0x04000013 RID: 19
		private static readonly PlayableDirector.RebuildGraphDelegate RebuildGraphDelegateField;

		// Token: 0x04000014 RID: 20
		private static readonly PlayableDirector.GetGenericBindingDelegate GetGenericBindingDelegateField;

		// Token: 0x04000015 RID: 21
		private static readonly PlayableDirector.ClearGenericBindingDelegate ClearGenericBindingDelegateField;

		// Token: 0x04000016 RID: 22
		private static readonly PlayableDirector.RebindPlayableGraphOutputsDelegate RebindPlayableGraphOutputsDelegateField;

		// Token: 0x04000017 RID: 23
		private static readonly PlayableDirector.ProcessPendingGraphChangesDelegate ProcessPendingGraphChangesDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly PlayableDirector.HasGenericBindingDelegate HasGenericBindingDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly PlayableDirector.GetPlayStateDelegate GetPlayStateDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly PlayableDirector.SetWrapModeDelegate SetWrapModeDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly PlayableDirector.GetWrapModeDelegate GetWrapModeDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly PlayableDirector.EvaluateNextFrameDelegate EvaluateNextFrameDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly PlayableDirector.SetPlayOnAwakeDelegate SetPlayOnAwakeDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly PlayableDirector.GetPlayOnAwakeDelegate GetPlayOnAwakeDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly PlayableDirector.Internal_SetGenericBindingDelegate Internal_SetGenericBindingDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly PlayableDirector.SetPlayableAssetDelegate SetPlayableAssetDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly PlayableDirector.Internal_GetPlayableAssetDelegate Internal_GetPlayableAssetDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly PlayableDirector.ResetFrameTimingDelegate ResetFrameTimingDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly PlayableDirector.ClearReferenceValue_InjectedDelegate ClearReferenceValue_InjectedDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly PlayableDirector.SetReferenceValue_InjectedDelegate SetReferenceValue_InjectedDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly PlayableDirector.GetReferenceValue_InjectedDelegate GetReferenceValue_InjectedDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly PlayableDirector.GetGraphHandle_InjectedDelegate GetGraphHandle_InjectedDelegateField;

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000043 RID: 67
		private delegate void set_timeUpdateModeDelegate(IntPtr @this, DirectorUpdateMode value);

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000045 RID: 69
		private delegate DirectorUpdateMode get_timeUpdateModeDelegate(IntPtr @this);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000047 RID: 71
		private delegate void set_timeDelegate(IntPtr @this, double value);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000049 RID: 73
		private delegate double get_timeDelegate(IntPtr @this);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600004B RID: 75
		private delegate void set_initialTimeDelegate(IntPtr @this, double value);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600004D RID: 77
		private delegate double get_initialTimeDelegate(IntPtr @this);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x0600004F RID: 79
		private delegate double get_durationDelegate(IntPtr @this);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000051 RID: 81
		private delegate void EvaluateDelegate(IntPtr @this);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000053 RID: 83
		private delegate void PlayDelegate(IntPtr @this);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000055 RID: 85
		private delegate void StopDelegate(IntPtr @this);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000057 RID: 87
		private delegate void PauseDelegate(IntPtr @this);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000059 RID: 89
		private delegate void ResumeDelegate(IntPtr @this);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x0600005B RID: 91
		private delegate void RebuildGraphDelegate(IntPtr @this);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x0600005D RID: 93
		private delegate IntPtr GetGenericBindingDelegate(IntPtr @this, IntPtr key);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600005F RID: 95
		private delegate void ClearGenericBindingDelegate(IntPtr @this, IntPtr key);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000061 RID: 97
		private delegate void RebindPlayableGraphOutputsDelegate(IntPtr @this);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000063 RID: 99
		private delegate void ProcessPendingGraphChangesDelegate(IntPtr @this);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000065 RID: 101
		private delegate bool HasGenericBindingDelegate(IntPtr @this, IntPtr key);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000067 RID: 103
		private delegate PlayState GetPlayStateDelegate(IntPtr @this);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000069 RID: 105
		private delegate void SetWrapModeDelegate(IntPtr @this, DirectorWrapMode mode);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600006B RID: 107
		private delegate DirectorWrapMode GetWrapModeDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x0600006D RID: 109
		private delegate void EvaluateNextFrameDelegate(IntPtr @this);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600006F RID: 111
		private delegate void SetPlayOnAwakeDelegate(IntPtr @this, bool on);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x06000071 RID: 113
		private delegate bool GetPlayOnAwakeDelegate(IntPtr @this);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000073 RID: 115
		private delegate void Internal_SetGenericBindingDelegate(IntPtr @this, IntPtr key, IntPtr value);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000075 RID: 117
		private delegate void SetPlayableAssetDelegate(IntPtr @this, IntPtr asset);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000077 RID: 119
		private delegate IntPtr Internal_GetPlayableAssetDelegate(IntPtr @this);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000079 RID: 121
		private delegate void ResetFrameTimingDelegate();

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x0600007B RID: 123
		private delegate void ClearReferenceValue_InjectedDelegate(IntPtr @this, IntPtr id);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x0600007D RID: 125
		private delegate void SetReferenceValue_InjectedDelegate(IntPtr @this, IntPtr id, IntPtr value);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600007F RID: 127
		private delegate IntPtr GetReferenceValue_InjectedDelegate(IntPtr @this, IntPtr id, [Out] IntPtr idValid);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000081 RID: 129
		private delegate void GetGraphHandle_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
