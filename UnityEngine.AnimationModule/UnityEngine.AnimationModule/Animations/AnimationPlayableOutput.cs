using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations
{
	// Token: 0x0200002D RID: 45
	[StructLayout(2)]
	public struct AnimationPlayableOutput
	{
		// Token: 0x0600038E RID: 910 RVA: 0x000111A0 File Offset: 0x0000F3A0
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPlayableOutput()
		{
			Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationPlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr);
			AnimationPlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, "m_Handle");
			AnimationPlayableOutput.InternalGetTargetDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutput.InternalGetTargetDelegate>("UnityEngine.Animations.AnimationPlayableOutput::InternalGetTarget");
			AnimationPlayableOutput.InternalSetTargetDelegateField = IL2CPP.ResolveICall<AnimationPlayableOutput.InternalSetTargetDelegate>("UnityEngine.Animations.AnimationPlayableOutput::InternalSetTarget");
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00003090 File Offset: 0x00001290
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationPlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00011204 File Offset: 0x0000F404
		public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target)
		{
			PlayableOutputHandle playableOutputHandle;
			bool flag = !AnimationPlayableGraphExtensions.InternalCreateAnimationOutput(ref graph, name, out playableOutputHandle);
			AnimationPlayableOutput animationPlayableOutput;
			if (flag)
			{
				animationPlayableOutput = AnimationPlayableOutput.Null;
			}
			else
			{
				AnimationPlayableOutput animationPlayableOutput2 = new AnimationPlayableOutput(playableOutputHandle);
				animationPlayableOutput2.SetTarget(target);
				animationPlayableOutput = animationPlayableOutput2;
			}
			return animationPlayableOutput;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00011244 File Offset: 0x0000F444
		public static AnimationPlayableOutput Null
		{
			get
			{
				return new AnimationPlayableOutput(PlayableOutputHandle.Null);
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00011260 File Offset: 0x0000F460
		public PlayableOutputHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00011278 File Offset: 0x0000F478
		public static implicit operator PlayableOutput(AnimationPlayableOutput output)
		{
			return new PlayableOutput(output.GetHandle());
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00011298 File Offset: 0x0000F498
		public static explicit operator AnimationPlayableOutput(PlayableOutput output)
		{
			return new AnimationPlayableOutput(output.GetHandle());
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000112B8 File Offset: 0x0000F4B8
		public Animator GetTarget()
		{
			return AnimationPlayableOutput.InternalGetTarget(ref this.m_Handle);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000030A2 File Offset: 0x000012A2
		public void SetTarget(Animator value)
		{
			AnimationPlayableOutput.InternalSetTarget(ref this.m_Handle, value);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000112D8 File Offset: 0x0000F4D8
		public static Animator InternalGetTarget(ref PlayableOutputHandle handle)
		{
			IntPtr intPtr = AnimationPlayableOutput.InternalGetTargetDelegateField(ref handle);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000030B2 File Offset: 0x000012B2
		public static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target)
		{
			AnimationPlayableOutput.InternalSetTargetDelegateField(ref handle, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000304 RID: 772
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;

		// Token: 0x04000305 RID: 773
		private static readonly AnimationPlayableOutput.InternalGetTargetDelegate InternalGetTargetDelegateField;

		// Token: 0x04000306 RID: 774
		private static readonly AnimationPlayableOutput.InternalSetTargetDelegate InternalSetTargetDelegateField;

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x0600068F RID: 1679
		private delegate IntPtr InternalGetTargetDelegate(IntPtr handle);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x06000691 RID: 1681
		private delegate void InternalSetTargetDelegate(IntPtr handle, IntPtr target);
	}
}
