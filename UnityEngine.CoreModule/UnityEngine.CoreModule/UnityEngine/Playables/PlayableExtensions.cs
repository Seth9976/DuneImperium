using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000358 RID: 856
	public static class PlayableExtensions
	{
		// Token: 0x06002E61 RID: 11873 RVA: 0x000B4E50 File Offset: 0x000B3050
		public static bool IsNull<U>(U playable) where U : struct
		{
			return playable.GetHandle().IsNull();
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x000B4E78 File Offset: 0x000B3078
		public static bool IsValid<U>(U playable) where U : struct
		{
			return playable.GetHandle().IsValid();
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x000B4EA0 File Offset: 0x000B30A0
		public static void Destroy<U>(U playable) where U : struct
		{
			playable.GetHandle().Destroy();
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x000B4EC4 File Offset: 0x000B30C4
		public static PlayableGraph GetGraph<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetGraph();
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x000B4EEC File Offset: 0x000B30EC
		public static void SetPlayState<U>(U playable, PlayState value) where U : struct
		{
			bool flag = value == PlayState.Delayed;
			if (flag)
			{
				throw new ArgumentException("Can't set Delayed: use SetDelay() instead");
			}
			if (value != PlayState.Paused)
			{
				if (value == PlayState.Playing)
				{
					playable.GetHandle().Play();
				}
			}
			else
			{
				playable.GetHandle().Pause();
			}
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x000B4F4C File Offset: 0x000B314C
		public static PlayState GetPlayState<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetPlayState();
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x000B4F74 File Offset: 0x000B3174
		public static void Play<U>(U playable) where U : struct
		{
			playable.GetHandle().Play();
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x000B4F98 File Offset: 0x000B3198
		public static void Pause<U>(U playable) where U : struct
		{
			playable.GetHandle().Pause();
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x000B4FBC File Offset: 0x000B31BC
		public static void SetSpeed<U>(U playable, double value) where U : struct
		{
			playable.GetHandle().SetSpeed(value);
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x000B4FE4 File Offset: 0x000B31E4
		public static double GetSpeed<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetSpeed();
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x000B500C File Offset: 0x000B320C
		public static void SetDuration<U>(U playable, double value) where U : struct
		{
			playable.GetHandle().SetDuration(value);
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x000B5034 File Offset: 0x000B3234
		public static double GetDuration<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetDuration();
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x000B505C File Offset: 0x000B325C
		public static void SetTime<U>(U playable, double value) where U : struct
		{
			playable.GetHandle().SetTime(value);
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x000B5084 File Offset: 0x000B3284
		public static double GetTime<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetTime();
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000B50AC File Offset: 0x000B32AC
		public static double GetPreviousTime<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetPreviousTime();
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x000B50D4 File Offset: 0x000B32D4
		public static void SetDone<U>(U playable, bool value) where U : struct
		{
			playable.GetHandle().SetDone(value);
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x000B50FC File Offset: 0x000B32FC
		public static bool IsDone<U>(U playable) where U : struct
		{
			return playable.GetHandle().IsDone();
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000B5124 File Offset: 0x000B3324
		public static void SetPropagateSetTime<U>(U playable, bool value) where U : struct
		{
			playable.GetHandle().SetPropagateSetTime(value);
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x000B514C File Offset: 0x000B334C
		public static bool GetPropagateSetTime<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetPropagateSetTime();
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x000B5174 File Offset: 0x000B3374
		public static bool CanChangeInputs<U>(U playable) where U : struct
		{
			return playable.GetHandle().CanChangeInputs();
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x000B519C File Offset: 0x000B339C
		public static bool CanSetWeights<U>(U playable) where U : struct
		{
			return playable.GetHandle().CanSetWeights();
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000B51C4 File Offset: 0x000B33C4
		public static bool CanDestroy<U>(U playable) where U : struct
		{
			return playable.GetHandle().CanDestroy();
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x000B51EC File Offset: 0x000B33EC
		public static void SetInputCount<U>(U playable, int value) where U : struct
		{
			playable.GetHandle().SetInputCount(value);
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x000B5214 File Offset: 0x000B3414
		public static int GetInputCount<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetInputCount();
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x000B523C File Offset: 0x000B343C
		public static void SetOutputCount<U>(U playable, int value) where U : struct
		{
			playable.GetHandle().SetOutputCount(value);
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x000B5264 File Offset: 0x000B3464
		public static int GetOutputCount<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetOutputCount();
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x000B528C File Offset: 0x000B348C
		public static Playable GetInput<U>(U playable, int inputPort) where U : struct
		{
			return playable.GetHandle().GetInput(inputPort);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x000B52B4 File Offset: 0x000B34B4
		public static Playable GetOutput<U>(U playable, int outputPort) where U : struct
		{
			return playable.GetHandle().GetOutput(outputPort);
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x000B52DC File Offset: 0x000B34DC
		public static void SetInputWeight<U>(U playable, int inputIndex, float weight) where U : struct
		{
			playable.GetHandle().SetInputWeight(inputIndex, weight);
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x000B5304 File Offset: 0x000B3504
		public static void SetInputWeight<U, V>(U playable, V input, float weight) where U : struct where V : struct
		{
			playable.GetHandle().SetInputWeight(input.GetHandle(), weight);
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x000B5338 File Offset: 0x000B3538
		public static float GetInputWeight<U>(U playable, int inputIndex) where U : struct
		{
			return playable.GetHandle().GetInputWeight(inputIndex);
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00012993 File Offset: 0x00010B93
		public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex) where U : struct where V : struct
		{
			PlayableExtensions.ConnectInput<U, V>(playable, inputIndex, sourcePlayable, sourceOutputIndex, 0f);
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x000B5360 File Offset: 0x000B3560
		public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight) where U : struct where V : struct
		{
			PlayableExtensions.GetGraph<U>(playable).Connect<V, U>(sourcePlayable, sourceOutputIndex, playable, inputIndex);
			PlayableExtensions.SetInputWeight<U>(playable, inputIndex, weight);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x000B538C File Offset: 0x000B358C
		public static void DisconnectInput<U>(U playable, int inputPort) where U : struct
		{
			PlayableExtensions.GetGraph<U>(playable).Disconnect<U>(playable, inputPort);
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x000B53AC File Offset: 0x000B35AC
		public static int AddInput<U, V>(U playable, V sourcePlayable, int sourceOutputIndex, [Optional] float weight) where U : struct where V : struct
		{
			int inputCount = PlayableExtensions.GetInputCount<U>(playable);
			PlayableExtensions.SetInputCount<U>(playable, inputCount + 1);
			PlayableExtensions.ConnectInput<U, V>(playable, inputCount, sourcePlayable, sourceOutputIndex, weight);
			return inputCount;
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x000B53DC File Offset: 0x000B35DC
		public static void SetDelay<U>(U playable, double delay) where U : struct
		{
			playable.GetHandle().SetDelay(delay);
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x000B5404 File Offset: 0x000B3604
		public static double GetDelay<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetDelay();
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x000B542C File Offset: 0x000B362C
		public static bool IsDelayed<U>(U playable) where U : struct
		{
			return playable.GetHandle().IsDelayed();
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x000B5454 File Offset: 0x000B3654
		public static void SetLeadTime<U>(U playable, float value) where U : struct
		{
			playable.GetHandle().SetLeadTime(value);
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x000B547C File Offset: 0x000B367C
		public static float GetLeadTime<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetLeadTime();
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x000B54A4 File Offset: 0x000B36A4
		public static PlayableTraversalMode GetTraversalMode<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetTraversalMode();
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x000B54CC File Offset: 0x000B36CC
		public static void SetTraversalMode<U>(U playable, PlayableTraversalMode mode) where U : struct
		{
			playable.GetHandle().SetTraversalMode(mode);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x000B54F4 File Offset: 0x000B36F4
		public static DirectorWrapMode GetTimeWrapMode<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetTimeWrapMode();
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x000B551C File Offset: 0x000B371C
		public static void SetTimeWrapMode<U>(U playable, DirectorWrapMode value) where U : struct
		{
			playable.GetHandle().SetTimeWrapMode(value);
		}
	}
}
