using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000264 RID: 612
	[StructLayout(2)]
	public struct PlayableGraph
	{
		// Token: 0x060029C6 RID: 10694 RVA: 0x000ACD54 File Offset: 0x000AAF54
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableGraph()
		{
			Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableGraph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr);
			PlayableGraph.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, "m_Handle");
			PlayableGraph.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, "m_Version");
			PlayableGraph.Create_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Create_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Create_Injected");
			PlayableGraph.Destroy_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Destroy_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Destroy_Injected");
			PlayableGraph.IsValid_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.IsValid_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::IsValid_Injected");
			PlayableGraph.IsPlaying_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.IsPlaying_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::IsPlaying_Injected");
			PlayableGraph.IsDone_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.IsDone_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::IsDone_Injected");
			PlayableGraph.Play_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Play_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Play_Injected");
			PlayableGraph.Stop_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Stop_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Stop_Injected");
			PlayableGraph.Evaluate_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Evaluate_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Evaluate_Injected");
			PlayableGraph.GetTimeUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetTimeUpdateMode_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetTimeUpdateMode_Injected");
			PlayableGraph.SetTimeUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.SetTimeUpdateMode_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::SetTimeUpdateMode_Injected");
			PlayableGraph.GetResolver_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetResolver_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetResolver_Injected");
			PlayableGraph.SetResolver_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.SetResolver_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::SetResolver_Injected");
			PlayableGraph.GetPlayableCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetPlayableCount_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetPlayableCount_Injected");
			PlayableGraph.GetRootPlayableCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetRootPlayableCount_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetRootPlayableCount_Injected");
			PlayableGraph.SynchronizeEvaluation_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.SynchronizeEvaluation_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::SynchronizeEvaluation_Injected");
			PlayableGraph.GetOutputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputCount_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputCount_Injected");
			PlayableGraph.CreatePlayableHandle_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.CreatePlayableHandle_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::CreatePlayableHandle_Injected");
			PlayableGraph.CreateScriptOutputInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.CreateScriptOutputInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::CreateScriptOutputInternal_Injected");
			PlayableGraph.GetRootPlayableInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetRootPlayableInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetRootPlayableInternal_Injected");
			PlayableGraph.DestroyOutputInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroyOutputInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroyOutputInternal_Injected");
			PlayableGraph.IsMatchFrameRateEnabled_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.IsMatchFrameRateEnabled_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::IsMatchFrameRateEnabled_Injected");
			PlayableGraph.DisableMatchFrameRate_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DisableMatchFrameRate_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DisableMatchFrameRate_Injected");
			PlayableGraph.GetOutputInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputInternal_Injected");
			PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputCountByTypeInternal_Injected");
			PlayableGraph.GetOutputByTypeInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputByTypeInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputByTypeInternal_Injected");
			PlayableGraph.ConnectInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.ConnectInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::ConnectInternal_Injected");
			PlayableGraph.DisconnectInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DisconnectInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DisconnectInternal_Injected");
			PlayableGraph.DestroyPlayableInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroyPlayableInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroyPlayableInternal_Injected");
			PlayableGraph.DestroySubgraphInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroySubgraphInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroySubgraphInternal_Injected");
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x000102D9 File Offset: 0x0000E4D9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, ref this));
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000ACF60 File Offset: 0x000AB160
		public Playable GetRootPlayable(int index)
		{
			PlayableHandle rootPlayableInternal = this.GetRootPlayableInternal(index);
			return new Playable(rootPlayableInternal);
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000ACF80 File Offset: 0x000AB180
		public bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) where U : struct where V : struct
		{
			return this.ConnectInternal(source.GetHandle(), sourceOutputPort, destination.GetHandle(), destinationInputPort);
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000102EB File Offset: 0x0000E4EB
		public void Disconnect<U>(U input, int inputPort) where U : struct
		{
			this.DisconnectInternal(input.GetHandle(), inputPort);
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x00010303 File Offset: 0x0000E503
		public void DestroyPlayable<U>(U playable) where U : struct
		{
			this.DestroyPlayableInternal(playable.GetHandle());
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x0001031A File Offset: 0x0000E51A
		public void DestroySubgraph<U>(U playable) where U : struct
		{
			this.DestroySubgraphInternal(playable.GetHandle());
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00010331 File Offset: 0x0000E531
		public void DestroyOutput<U>(U output) where U : struct
		{
			this.DestroyOutputInternal(output.GetHandle());
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000ACFB8 File Offset: 0x000AB1B8
		public int GetOutputCountByType<T>() where T : struct
		{
			return this.GetOutputCountByTypeInternal(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000ACFDC File Offset: 0x000AB1DC
		public PlayableOutput GetOutput(int index)
		{
			PlayableOutputHandle playableOutputHandle;
			bool flag = !this.GetOutputInternal(index, out playableOutputHandle);
			PlayableOutput playableOutput;
			if (flag)
			{
				playableOutput = PlayableOutput.Null;
			}
			else
			{
				playableOutput = new PlayableOutput(playableOutputHandle);
			}
			return playableOutput;
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000AD00C File Offset: 0x000AB20C
		public PlayableOutput GetOutputByType<T>(int index) where T : struct
		{
			PlayableOutputHandle playableOutputHandle;
			bool flag = !this.GetOutputByTypeInternal(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), index, out playableOutputHandle);
			PlayableOutput playableOutput;
			if (flag)
			{
				playableOutput = PlayableOutput.Null;
			}
			else
			{
				playableOutput = new PlayableOutput(playableOutputHandle);
			}
			return playableOutput;
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x00010348 File Offset: 0x0000E548
		public void Evaluate()
		{
			this.Evaluate(0f);
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000AD048 File Offset: 0x000AB248
		public static PlayableGraph Create()
		{
			return PlayableGraph.Create(null);
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000AD060 File Offset: 0x000AB260
		public static PlayableGraph Create(string name)
		{
			PlayableGraph playableGraph;
			PlayableGraph.Create_Injected(name, out playableGraph);
			return playableGraph;
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00010357 File Offset: 0x0000E557
		public void Destroy()
		{
			PlayableGraph.Destroy_Injected(ref this);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x0001035F File Offset: 0x0000E55F
		public bool IsValid()
		{
			return PlayableGraph.IsValid_Injected(ref this);
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00010367 File Offset: 0x0000E567
		public bool IsPlaying()
		{
			return PlayableGraph.IsPlaying_Injected(ref this);
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x0001036F File Offset: 0x0000E56F
		public bool IsDone()
		{
			return PlayableGraph.IsDone_Injected(ref this);
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00010377 File Offset: 0x0000E577
		public void Play()
		{
			PlayableGraph.Play_Injected(ref this);
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x0001037F File Offset: 0x0000E57F
		public void Stop()
		{
			PlayableGraph.Stop_Injected(ref this);
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00010387 File Offset: 0x0000E587
		public void Evaluate(float deltaTime)
		{
			PlayableGraph.Evaluate_Injected(ref this, deltaTime);
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00010390 File Offset: 0x0000E590
		public DirectorUpdateMode GetTimeUpdateMode()
		{
			return PlayableGraph.GetTimeUpdateMode_Injected(ref this);
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x00010398 File Offset: 0x0000E598
		public void SetTimeUpdateMode(DirectorUpdateMode value)
		{
			PlayableGraph.SetTimeUpdateMode_Injected(ref this, value);
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x000103A1 File Offset: 0x0000E5A1
		public IExposedPropertyTable GetResolver()
		{
			return PlayableGraph.GetResolver_Injected(ref this);
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000103A9 File Offset: 0x0000E5A9
		public void SetResolver(IExposedPropertyTable value)
		{
			PlayableGraph.SetResolver_Injected(ref this, value);
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000103B2 File Offset: 0x0000E5B2
		public int GetPlayableCount()
		{
			return PlayableGraph.GetPlayableCount_Injected(ref this);
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x000103BA File Offset: 0x0000E5BA
		public int GetRootPlayableCount()
		{
			return PlayableGraph.GetRootPlayableCount_Injected(ref this);
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x000103C2 File Offset: 0x0000E5C2
		public void SynchronizeEvaluation(PlayableGraph playable)
		{
			PlayableGraph.SynchronizeEvaluation_Injected(ref this, ref playable);
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000103CC File Offset: 0x0000E5CC
		public int GetOutputCount()
		{
			return PlayableGraph.GetOutputCount_Injected(ref this);
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000AD078 File Offset: 0x000AB278
		public PlayableHandle CreatePlayableHandle()
		{
			PlayableHandle playableHandle;
			PlayableGraph.CreatePlayableHandle_Injected(ref this, out playableHandle);
			return playableHandle;
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x000103D4 File Offset: 0x0000E5D4
		public bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle)
		{
			return PlayableGraph.CreateScriptOutputInternal_Injected(ref this, name, out handle);
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x000AD090 File Offset: 0x000AB290
		public PlayableHandle GetRootPlayableInternal(int index)
		{
			PlayableHandle playableHandle;
			PlayableGraph.GetRootPlayableInternal_Injected(ref this, index, out playableHandle);
			return playableHandle;
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x000103DE File Offset: 0x0000E5DE
		public void DestroyOutputInternal(PlayableOutputHandle handle)
		{
			PlayableGraph.DestroyOutputInternal_Injected(ref this, ref handle);
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x000103E8 File Offset: 0x0000E5E8
		public bool IsMatchFrameRateEnabled()
		{
			return PlayableGraph.IsMatchFrameRateEnabled_Injected(ref this);
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x000103F0 File Offset: 0x0000E5F0
		public void DisableMatchFrameRate()
		{
			PlayableGraph.DisableMatchFrameRate_Injected(ref this);
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x000103F8 File Offset: 0x0000E5F8
		public bool GetOutputInternal(int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputInternal_Injected(ref this, index, out handle);
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x00010402 File Offset: 0x0000E602
		public int GetOutputCountByTypeInternal(Type outputType)
		{
			return PlayableGraph.GetOutputCountByTypeInternal_Injected(ref this, outputType);
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x0001040B File Offset: 0x0000E60B
		public bool GetOutputByTypeInternal(Type outputType, int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputByTypeInternal_Injected(ref this, outputType, index, out handle);
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x00010416 File Offset: 0x0000E616
		public bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort)
		{
			return PlayableGraph.ConnectInternal_Injected(ref this, ref source, sourceOutputPort, ref destination, destinationInputPort);
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x00010425 File Offset: 0x0000E625
		public void DisconnectInternal(PlayableHandle playable, int inputPort)
		{
			PlayableGraph.DisconnectInternal_Injected(ref this, ref playable, inputPort);
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x00010430 File Offset: 0x0000E630
		public void DestroyPlayableInternal(PlayableHandle playable)
		{
			PlayableGraph.DestroyPlayableInternal_Injected(ref this, ref playable);
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x0001043A File Offset: 0x0000E63A
		public void DestroySubgraphInternal(PlayableHandle playable)
		{
			PlayableGraph.DestroySubgraphInternal_Injected(ref this, ref playable);
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x00010444 File Offset: 0x0000E644
		public static void Create_Injected(string name, out PlayableGraph ret)
		{
			PlayableGraph.Create_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), out ret);
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x00010457 File Offset: 0x0000E657
		public static void Destroy_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.Destroy_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x00010464 File Offset: 0x0000E664
		public static bool IsValid_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.IsValid_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x00010471 File Offset: 0x0000E671
		public static bool IsPlaying_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.IsPlaying_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x0001047E File Offset: 0x0000E67E
		public static bool IsDone_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.IsDone_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x0001048B File Offset: 0x0000E68B
		public static void Play_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.Play_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x00010498 File Offset: 0x0000E698
		public static void Stop_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.Stop_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000104A5 File Offset: 0x0000E6A5
		public static void Evaluate_Injected(ref PlayableGraph _unity_self, float deltaTime)
		{
			PlayableGraph.Evaluate_InjectedDelegateField(ref _unity_self, deltaTime);
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x000104B3 File Offset: 0x0000E6B3
		public static DirectorUpdateMode GetTimeUpdateMode_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.GetTimeUpdateMode_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x000104C0 File Offset: 0x0000E6C0
		public static void SetTimeUpdateMode_Injected(ref PlayableGraph _unity_self, DirectorUpdateMode value)
		{
			PlayableGraph.SetTimeUpdateMode_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x000AD0A8 File Offset: 0x000AB2A8
		public static IExposedPropertyTable GetResolver_Injected(ref PlayableGraph _unity_self)
		{
			IntPtr intPtr = PlayableGraph.GetResolver_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IExposedPropertyTable>(intPtr2) : null;
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x000104CE File Offset: 0x0000E6CE
		public static void SetResolver_Injected(ref PlayableGraph _unity_self, IExposedPropertyTable value)
		{
			PlayableGraph.SetResolver_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x000104E1 File Offset: 0x0000E6E1
		public static int GetPlayableCount_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.GetPlayableCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x000104EE File Offset: 0x0000E6EE
		public static int GetRootPlayableCount_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.GetRootPlayableCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x000104FB File Offset: 0x0000E6FB
		public static void SynchronizeEvaluation_Injected(ref PlayableGraph _unity_self, ref PlayableGraph playable)
		{
			PlayableGraph.SynchronizeEvaluation_InjectedDelegateField(ref _unity_self, ref playable);
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x00010509 File Offset: 0x0000E709
		public static int GetOutputCount_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.GetOutputCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00010516 File Offset: 0x0000E716
		public static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret)
		{
			PlayableGraph.CreatePlayableHandle_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x00010524 File Offset: 0x0000E724
		public static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, string name, out PlayableOutputHandle handle)
		{
			return PlayableGraph.CreateScriptOutputInternal_InjectedDelegateField(ref _unity_self, IL2CPP.ManagedStringToIl2Cpp(name), out handle);
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00010538 File Offset: 0x0000E738
		public static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret)
		{
			PlayableGraph.GetRootPlayableInternal_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x00010547 File Offset: 0x0000E747
		public static void DestroyOutputInternal_Injected(ref PlayableGraph _unity_self, ref PlayableOutputHandle handle)
		{
			PlayableGraph.DestroyOutputInternal_InjectedDelegateField(ref _unity_self, ref handle);
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00010555 File Offset: 0x0000E755
		public static bool IsMatchFrameRateEnabled_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.IsMatchFrameRateEnabled_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x00010562 File Offset: 0x0000E762
		public static void DisableMatchFrameRate_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.DisableMatchFrameRate_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x0001056F File Offset: 0x0000E76F
		public static bool GetOutputInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputInternal_InjectedDelegateField(ref _unity_self, index, out handle);
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x0001057E File Offset: 0x0000E77E
		public static int GetOutputCountByTypeInternal_Injected(ref PlayableGraph _unity_self, Type outputType)
		{
			return PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(outputType));
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x00010591 File Offset: 0x0000E791
		public static bool GetOutputByTypeInternal_Injected(ref PlayableGraph _unity_self, Type outputType, int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputByTypeInternal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(outputType), index, out handle);
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x000105A6 File Offset: 0x0000E7A6
		public static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort)
		{
			return PlayableGraph.ConnectInternal_InjectedDelegateField(ref _unity_self, ref source, sourceOutputPort, ref destination, destinationInputPort);
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x000105B8 File Offset: 0x0000E7B8
		public static void DisconnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable, int inputPort)
		{
			PlayableGraph.DisconnectInternal_InjectedDelegateField(ref _unity_self, ref playable, inputPort);
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x000105C7 File Offset: 0x0000E7C7
		public static void DestroyPlayableInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable)
		{
			PlayableGraph.DestroyPlayableInternal_InjectedDelegateField(ref _unity_self, ref playable);
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x000105D5 File Offset: 0x0000E7D5
		public static void DestroySubgraphInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable)
		{
			PlayableGraph.DestroySubgraphInternal_InjectedDelegateField(ref _unity_self, ref playable);
		}

		// Token: 0x040024EA RID: 9450
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040024EB RID: 9451
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x040024EC RID: 9452
		[FieldOffset(0)]
		public IntPtr m_Handle;

		// Token: 0x040024ED RID: 9453
		[FieldOffset(8)]
		public uint m_Version;

		// Token: 0x040024EE RID: 9454
		private static readonly PlayableGraph.Create_InjectedDelegate Create_InjectedDelegateField;

		// Token: 0x040024EF RID: 9455
		private static readonly PlayableGraph.Destroy_InjectedDelegate Destroy_InjectedDelegateField;

		// Token: 0x040024F0 RID: 9456
		private static readonly PlayableGraph.IsValid_InjectedDelegate IsValid_InjectedDelegateField;

		// Token: 0x040024F1 RID: 9457
		private static readonly PlayableGraph.IsPlaying_InjectedDelegate IsPlaying_InjectedDelegateField;

		// Token: 0x040024F2 RID: 9458
		private static readonly PlayableGraph.IsDone_InjectedDelegate IsDone_InjectedDelegateField;

		// Token: 0x040024F3 RID: 9459
		private static readonly PlayableGraph.Play_InjectedDelegate Play_InjectedDelegateField;

		// Token: 0x040024F4 RID: 9460
		private static readonly PlayableGraph.Stop_InjectedDelegate Stop_InjectedDelegateField;

		// Token: 0x040024F5 RID: 9461
		private static readonly PlayableGraph.Evaluate_InjectedDelegate Evaluate_InjectedDelegateField;

		// Token: 0x040024F6 RID: 9462
		private static readonly PlayableGraph.GetTimeUpdateMode_InjectedDelegate GetTimeUpdateMode_InjectedDelegateField;

		// Token: 0x040024F7 RID: 9463
		private static readonly PlayableGraph.SetTimeUpdateMode_InjectedDelegate SetTimeUpdateMode_InjectedDelegateField;

		// Token: 0x040024F8 RID: 9464
		private static readonly PlayableGraph.GetResolver_InjectedDelegate GetResolver_InjectedDelegateField;

		// Token: 0x040024F9 RID: 9465
		private static readonly PlayableGraph.SetResolver_InjectedDelegate SetResolver_InjectedDelegateField;

		// Token: 0x040024FA RID: 9466
		private static readonly PlayableGraph.GetPlayableCount_InjectedDelegate GetPlayableCount_InjectedDelegateField;

		// Token: 0x040024FB RID: 9467
		private static readonly PlayableGraph.GetRootPlayableCount_InjectedDelegate GetRootPlayableCount_InjectedDelegateField;

		// Token: 0x040024FC RID: 9468
		private static readonly PlayableGraph.SynchronizeEvaluation_InjectedDelegate SynchronizeEvaluation_InjectedDelegateField;

		// Token: 0x040024FD RID: 9469
		private static readonly PlayableGraph.GetOutputCount_InjectedDelegate GetOutputCount_InjectedDelegateField;

		// Token: 0x040024FE RID: 9470
		private static readonly PlayableGraph.CreatePlayableHandle_InjectedDelegate CreatePlayableHandle_InjectedDelegateField;

		// Token: 0x040024FF RID: 9471
		private static readonly PlayableGraph.CreateScriptOutputInternal_InjectedDelegate CreateScriptOutputInternal_InjectedDelegateField;

		// Token: 0x04002500 RID: 9472
		private static readonly PlayableGraph.GetRootPlayableInternal_InjectedDelegate GetRootPlayableInternal_InjectedDelegateField;

		// Token: 0x04002501 RID: 9473
		private static readonly PlayableGraph.DestroyOutputInternal_InjectedDelegate DestroyOutputInternal_InjectedDelegateField;

		// Token: 0x04002502 RID: 9474
		private static readonly PlayableGraph.IsMatchFrameRateEnabled_InjectedDelegate IsMatchFrameRateEnabled_InjectedDelegateField;

		// Token: 0x04002503 RID: 9475
		private static readonly PlayableGraph.DisableMatchFrameRate_InjectedDelegate DisableMatchFrameRate_InjectedDelegateField;

		// Token: 0x04002504 RID: 9476
		private static readonly PlayableGraph.GetOutputInternal_InjectedDelegate GetOutputInternal_InjectedDelegateField;

		// Token: 0x04002505 RID: 9477
		private static readonly PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegate GetOutputCountByTypeInternal_InjectedDelegateField;

		// Token: 0x04002506 RID: 9478
		private static readonly PlayableGraph.GetOutputByTypeInternal_InjectedDelegate GetOutputByTypeInternal_InjectedDelegateField;

		// Token: 0x04002507 RID: 9479
		private static readonly PlayableGraph.ConnectInternal_InjectedDelegate ConnectInternal_InjectedDelegateField;

		// Token: 0x04002508 RID: 9480
		private static readonly PlayableGraph.DisconnectInternal_InjectedDelegate DisconnectInternal_InjectedDelegateField;

		// Token: 0x04002509 RID: 9481
		private static readonly PlayableGraph.DestroyPlayableInternal_InjectedDelegate DestroyPlayableInternal_InjectedDelegateField;

		// Token: 0x0400250A RID: 9482
		private static readonly PlayableGraph.DestroySubgraphInternal_InjectedDelegate DestroySubgraphInternal_InjectedDelegateField;

		// Token: 0x02000A06 RID: 2566
		// (Invoke) Token: 0x06003D2A RID: 15658
		private delegate void Create_InjectedDelegate(IntPtr name, [Out] IntPtr ret);

		// Token: 0x02000A07 RID: 2567
		// (Invoke) Token: 0x06003D2C RID: 15660
		private delegate void Destroy_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A08 RID: 2568
		// (Invoke) Token: 0x06003D2E RID: 15662
		private delegate bool IsValid_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A09 RID: 2569
		// (Invoke) Token: 0x06003D30 RID: 15664
		private delegate bool IsPlaying_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A0A RID: 2570
		// (Invoke) Token: 0x06003D32 RID: 15666
		private delegate bool IsDone_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A0B RID: 2571
		// (Invoke) Token: 0x06003D34 RID: 15668
		private delegate void Play_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A0C RID: 2572
		// (Invoke) Token: 0x06003D36 RID: 15670
		private delegate void Stop_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A0D RID: 2573
		// (Invoke) Token: 0x06003D38 RID: 15672
		private delegate void Evaluate_InjectedDelegate(IntPtr _unity_self, float deltaTime);

		// Token: 0x02000A0E RID: 2574
		// (Invoke) Token: 0x06003D3A RID: 15674
		private delegate DirectorUpdateMode GetTimeUpdateMode_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A0F RID: 2575
		// (Invoke) Token: 0x06003D3C RID: 15676
		private delegate void SetTimeUpdateMode_InjectedDelegate(IntPtr _unity_self, DirectorUpdateMode value);

		// Token: 0x02000A10 RID: 2576
		// (Invoke) Token: 0x06003D3E RID: 15678
		private delegate IntPtr GetResolver_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A11 RID: 2577
		// (Invoke) Token: 0x06003D40 RID: 15680
		private delegate void SetResolver_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x02000A12 RID: 2578
		// (Invoke) Token: 0x06003D42 RID: 15682
		private delegate int GetPlayableCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A13 RID: 2579
		// (Invoke) Token: 0x06003D44 RID: 15684
		private delegate int GetRootPlayableCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A14 RID: 2580
		// (Invoke) Token: 0x06003D46 RID: 15686
		private delegate void SynchronizeEvaluation_InjectedDelegate(IntPtr _unity_self, IntPtr playable);

		// Token: 0x02000A15 RID: 2581
		// (Invoke) Token: 0x06003D48 RID: 15688
		private delegate int GetOutputCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A16 RID: 2582
		// (Invoke) Token: 0x06003D4A RID: 15690
		private delegate void CreatePlayableHandle_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000A17 RID: 2583
		// (Invoke) Token: 0x06003D4C RID: 15692
		private delegate bool CreateScriptOutputInternal_InjectedDelegate(IntPtr _unity_self, IntPtr name, [Out] IntPtr handle);

		// Token: 0x02000A18 RID: 2584
		// (Invoke) Token: 0x06003D4E RID: 15694
		private delegate void GetRootPlayableInternal_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr ret);

		// Token: 0x02000A19 RID: 2585
		// (Invoke) Token: 0x06003D50 RID: 15696
		private delegate void DestroyOutputInternal_InjectedDelegate(IntPtr _unity_self, IntPtr handle);

		// Token: 0x02000A1A RID: 2586
		// (Invoke) Token: 0x06003D52 RID: 15698
		private delegate bool IsMatchFrameRateEnabled_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A1B RID: 2587
		// (Invoke) Token: 0x06003D54 RID: 15700
		private delegate void DisableMatchFrameRate_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A1C RID: 2588
		// (Invoke) Token: 0x06003D56 RID: 15702
		private delegate bool GetOutputInternal_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr handle);

		// Token: 0x02000A1D RID: 2589
		// (Invoke) Token: 0x06003D58 RID: 15704
		private delegate int GetOutputCountByTypeInternal_InjectedDelegate(IntPtr _unity_self, IntPtr outputType);

		// Token: 0x02000A1E RID: 2590
		// (Invoke) Token: 0x06003D5A RID: 15706
		private delegate bool GetOutputByTypeInternal_InjectedDelegate(IntPtr _unity_self, IntPtr outputType, int index, [Out] IntPtr handle);

		// Token: 0x02000A1F RID: 2591
		// (Invoke) Token: 0x06003D5C RID: 15708
		private delegate bool ConnectInternal_InjectedDelegate(IntPtr _unity_self, IntPtr source, int sourceOutputPort, IntPtr destination, int destinationInputPort);

		// Token: 0x02000A20 RID: 2592
		// (Invoke) Token: 0x06003D5E RID: 15710
		private delegate void DisconnectInternal_InjectedDelegate(IntPtr _unity_self, IntPtr playable, int inputPort);

		// Token: 0x02000A21 RID: 2593
		// (Invoke) Token: 0x06003D60 RID: 15712
		private delegate void DestroyPlayableInternal_InjectedDelegate(IntPtr _unity_self, IntPtr playable);

		// Token: 0x02000A22 RID: 2594
		// (Invoke) Token: 0x06003D62 RID: 15714
		private delegate void DestroySubgraphInternal_InjectedDelegate(IntPtr _unity_self, IntPtr playable);
	}
}
