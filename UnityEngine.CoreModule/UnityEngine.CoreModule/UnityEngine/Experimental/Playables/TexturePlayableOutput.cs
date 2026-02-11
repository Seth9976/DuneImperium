using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x0200027D RID: 637
	[StructLayout(2)]
	public struct TexturePlayableOutput
	{
		// Token: 0x06002B67 RID: 11111 RVA: 0x000AFBC4 File Offset: 0x000ADDC4
		// Note: this type is marked as 'beforefieldinit'.
		static TexturePlayableOutput()
		{
			Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "TexturePlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr);
			TexturePlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, "m_Handle");
			TexturePlayableOutput.InternalGetTargetDelegateField = IL2CPP.ResolveICall<TexturePlayableOutput.InternalGetTargetDelegate>("UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalGetTarget");
			TexturePlayableOutput.InternalSetTargetDelegateField = IL2CPP.ResolveICall<TexturePlayableOutput.InternalSetTargetDelegate>("UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalSetTarget");
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x00010F25 File Offset: 0x0000F125
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x000AFC28 File Offset: 0x000ADE28
		public static TexturePlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name, RenderTexture target)
		{
			UnityEngine.Playables.PlayableOutputHandle playableOutputHandle;
			bool flag = !TexturePlayableGraphExtensions.InternalCreateTextureOutput(ref graph, name, out playableOutputHandle);
			TexturePlayableOutput texturePlayableOutput;
			if (flag)
			{
				texturePlayableOutput = TexturePlayableOutput.Null;
			}
			else
			{
				TexturePlayableOutput texturePlayableOutput2 = new TexturePlayableOutput(playableOutputHandle);
				texturePlayableOutput2.SetTarget(target);
				texturePlayableOutput = texturePlayableOutput2;
			}
			return texturePlayableOutput;
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002B6A RID: 11114 RVA: 0x000AFC68 File Offset: 0x000ADE68
		public static TexturePlayableOutput Null
		{
			get
			{
				return new TexturePlayableOutput(UnityEngine.Playables.PlayableOutputHandle.Null);
			}
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x000AFC84 File Offset: 0x000ADE84
		public UnityEngine.Playables.PlayableOutputHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x000AFC9C File Offset: 0x000ADE9C
		public static implicit operator UnityEngine.Playables.PlayableOutput(TexturePlayableOutput output)
		{
			return new UnityEngine.Playables.PlayableOutput(output.GetHandle());
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x000AFCBC File Offset: 0x000ADEBC
		public static explicit operator TexturePlayableOutput(UnityEngine.Playables.PlayableOutput output)
		{
			return new TexturePlayableOutput(output.GetHandle());
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x000AFCDC File Offset: 0x000ADEDC
		public RenderTexture GetTarget()
		{
			return TexturePlayableOutput.InternalGetTarget(ref this.m_Handle);
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x00010F37 File Offset: 0x0000F137
		public void SetTarget(RenderTexture value)
		{
			TexturePlayableOutput.InternalSetTarget(ref this.m_Handle, value);
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x000AFCFC File Offset: 0x000ADEFC
		public static RenderTexture InternalGetTarget(ref UnityEngine.Playables.PlayableOutputHandle output)
		{
			IntPtr intPtr = TexturePlayableOutput.InternalGetTargetDelegateField(ref output);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x00010F47 File Offset: 0x0000F147
		public static void InternalSetTarget(ref UnityEngine.Playables.PlayableOutputHandle output, RenderTexture target)
		{
			TexturePlayableOutput.InternalSetTargetDelegateField(ref output, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x04002671 RID: 9841
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04002672 RID: 9842
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableOutputHandle m_Handle;

		// Token: 0x04002673 RID: 9843
		private static readonly TexturePlayableOutput.InternalGetTargetDelegate InternalGetTargetDelegateField;

		// Token: 0x04002674 RID: 9844
		private static readonly TexturePlayableOutput.InternalSetTargetDelegate InternalSetTargetDelegateField;

		// Token: 0x02000A6D RID: 2669
		// (Invoke) Token: 0x06003DFE RID: 15870
		private delegate IntPtr InternalGetTargetDelegate(IntPtr output);

		// Token: 0x02000A6E RID: 2670
		// (Invoke) Token: 0x06003E00 RID: 15872
		private delegate void InternalSetTargetDelegate(IntPtr output, IntPtr target);
	}
}
