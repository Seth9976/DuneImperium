using System;
using UnityEngine.Animations;

namespace UnityEngine.Playables
{
	// Token: 0x02000047 RID: 71
	public static class AnimationPlayableUtilities
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x00012B00 File Offset: 0x00010D00
		public static void Play(Animator animator, Playable playable, PlayableGraph graph)
		{
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "AnimationClip", animator);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, Playable>(animationPlayableOutput, playable, 0);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00012B34 File Offset: 0x00010D34
		public static AnimationClipPlayable PlayClip(Animator animator, AnimationClip clip, out PlayableGraph graph)
		{
			graph = PlayableGraph.Create();
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "AnimationClip", animator);
			AnimationClipPlayable animationClipPlayable = AnimationClipPlayable.Create(graph, clip);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimationClipPlayable>(animationPlayableOutput, animationClipPlayable);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
			return animationClipPlayable;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00012B90 File Offset: 0x00010D90
		public static AnimationMixerPlayable PlayMixer(Animator animator, int inputCount, out PlayableGraph graph)
		{
			graph = PlayableGraph.Create();
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "Mixer", animator);
			AnimationMixerPlayable animationMixerPlayable = AnimationMixerPlayable.Create(graph, inputCount);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimationMixerPlayable>(animationPlayableOutput, animationMixerPlayable);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
			return animationMixerPlayable;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00012BEC File Offset: 0x00010DEC
		public static AnimationLayerMixerPlayable PlayLayerMixer(Animator animator, int inputCount, out PlayableGraph graph)
		{
			graph = PlayableGraph.Create();
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "Mixer", animator);
			AnimationLayerMixerPlayable animationLayerMixerPlayable = AnimationLayerMixerPlayable.Create(graph, inputCount);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimationLayerMixerPlayable>(animationPlayableOutput, animationLayerMixerPlayable);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
			return animationLayerMixerPlayable;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00012C48 File Offset: 0x00010E48
		public static AnimatorControllerPlayable PlayAnimatorController(Animator animator, RuntimeAnimatorController controller, out PlayableGraph graph)
		{
			graph = PlayableGraph.Create();
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, "AnimatorControllerPlayable", animator);
			AnimatorControllerPlayable animatorControllerPlayable = AnimatorControllerPlayable.Create(graph, controller);
			PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimatorControllerPlayable>(animationPlayableOutput, animatorControllerPlayable);
			AnimationPlayableGraphExtensions.SyncUpdateAndTimeMode(graph, animator);
			graph.Play();
			return animatorControllerPlayable;
		}
	}
}
