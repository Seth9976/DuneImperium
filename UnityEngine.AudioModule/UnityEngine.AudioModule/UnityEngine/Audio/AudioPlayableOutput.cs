using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Audio
{
	// Token: 0x02000012 RID: 18
	[StructLayout(2)]
	public struct AudioPlayableOutput
	{
		// Token: 0x06000145 RID: 325 RVA: 0x00007598 File Offset: 0x00005798
		// Note: this type is marked as 'beforefieldinit'.
		static AudioPlayableOutput()
		{
			Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioPlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr);
			AudioPlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, "m_Handle");
			AudioPlayableOutput.InternalGetTargetDelegateField = IL2CPP.ResolveICall<AudioPlayableOutput.InternalGetTargetDelegate>("UnityEngine.Audio.AudioPlayableOutput::InternalGetTarget");
			AudioPlayableOutput.InternalSetTargetDelegateField = IL2CPP.ResolveICall<AudioPlayableOutput.InternalSetTargetDelegate>("UnityEngine.Audio.AudioPlayableOutput::InternalSetTarget");
			AudioPlayableOutput.InternalGetEvaluateOnSeekDelegateField = IL2CPP.ResolveICall<AudioPlayableOutput.InternalGetEvaluateOnSeekDelegate>("UnityEngine.Audio.AudioPlayableOutput::InternalGetEvaluateOnSeek");
			AudioPlayableOutput.InternalSetEvaluateOnSeekDelegateField = IL2CPP.ResolveICall<AudioPlayableOutput.InternalSetEvaluateOnSeekDelegate>("UnityEngine.Audio.AudioPlayableOutput::InternalSetEvaluateOnSeek");
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002733 File Offset: 0x00000933
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00007618 File Offset: 0x00005818
		public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target)
		{
			PlayableOutputHandle playableOutputHandle;
			bool flag = !AudioPlayableGraphExtensions.InternalCreateAudioOutput(ref graph, name, out playableOutputHandle);
			AudioPlayableOutput audioPlayableOutput;
			if (flag)
			{
				audioPlayableOutput = AudioPlayableOutput.Null;
			}
			else
			{
				AudioPlayableOutput audioPlayableOutput2 = new AudioPlayableOutput(playableOutputHandle);
				audioPlayableOutput2.SetTarget(target);
				audioPlayableOutput = audioPlayableOutput2;
			}
			return audioPlayableOutput;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00007658 File Offset: 0x00005858
		public static AudioPlayableOutput Null
		{
			get
			{
				return new AudioPlayableOutput(PlayableOutputHandle.Null);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00007674 File Offset: 0x00005874
		public PlayableOutputHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000768C File Offset: 0x0000588C
		public static implicit operator PlayableOutput(AudioPlayableOutput output)
		{
			return new PlayableOutput(output.GetHandle());
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000076AC File Offset: 0x000058AC
		public static explicit operator AudioPlayableOutput(PlayableOutput output)
		{
			return new AudioPlayableOutput(output.GetHandle());
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000076CC File Offset: 0x000058CC
		public AudioSource GetTarget()
		{
			return AudioPlayableOutput.InternalGetTarget(ref this.m_Handle);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002745 File Offset: 0x00000945
		public void SetTarget(AudioSource value)
		{
			AudioPlayableOutput.InternalSetTarget(ref this.m_Handle, value);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000076EC File Offset: 0x000058EC
		public bool GetEvaluateOnSeek()
		{
			return AudioPlayableOutput.InternalGetEvaluateOnSeek(ref this.m_Handle);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002755 File Offset: 0x00000955
		public void SetEvaluateOnSeek(bool value)
		{
			AudioPlayableOutput.InternalSetEvaluateOnSeek(ref this.m_Handle, value);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000770C File Offset: 0x0000590C
		public static AudioSource InternalGetTarget(ref PlayableOutputHandle output)
		{
			IntPtr intPtr = AudioPlayableOutput.InternalGetTargetDelegateField(ref output);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002765 File Offset: 0x00000965
		public static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target)
		{
			AudioPlayableOutput.InternalSetTargetDelegateField(ref output, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002778 File Offset: 0x00000978
		public static bool InternalGetEvaluateOnSeek(ref PlayableOutputHandle output)
		{
			return AudioPlayableOutput.InternalGetEvaluateOnSeekDelegateField(ref output);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002785 File Offset: 0x00000985
		public static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value)
		{
			AudioPlayableOutput.InternalSetEvaluateOnSeekDelegateField(ref output, value);
		}

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040000F0 RID: 240
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;

		// Token: 0x040000F1 RID: 241
		private static readonly AudioPlayableOutput.InternalGetTargetDelegate InternalGetTargetDelegateField;

		// Token: 0x040000F2 RID: 242
		private static readonly AudioPlayableOutput.InternalSetTargetDelegate InternalSetTargetDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly AudioPlayableOutput.InternalGetEvaluateOnSeekDelegate InternalGetEvaluateOnSeekDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly AudioPlayableOutput.InternalSetEvaluateOnSeekDelegate InternalSetEvaluateOnSeekDelegateField;

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060002AF RID: 687
		private delegate IntPtr InternalGetTargetDelegate(IntPtr output);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060002B1 RID: 689
		private delegate void InternalSetTargetDelegate(IntPtr output, IntPtr target);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060002B3 RID: 691
		private delegate bool InternalGetEvaluateOnSeekDelegate(IntPtr output);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060002B5 RID: 693
		private delegate void InternalSetEvaluateOnSeekDelegate(IntPtr output, bool value);
	}
}
