using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000268 RID: 616
	[StructLayout(2)]
	public struct ScriptPlayableOutput
	{
		// Token: 0x06002AAD RID: 10925 RVA: 0x00010AF1 File Offset: 0x0000ECF1
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptPlayableOutput()
		{
			Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "ScriptPlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr);
			ScriptPlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, "m_Handle");
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x00010B2A File Offset: 0x0000ED2A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x000ADF24 File Offset: 0x000AC124
		public static ScriptPlayableOutput Create(PlayableGraph graph, string name)
		{
			PlayableOutputHandle playableOutputHandle;
			bool flag = !graph.CreateScriptOutputInternal(name, out playableOutputHandle);
			ScriptPlayableOutput scriptPlayableOutput;
			if (flag)
			{
				scriptPlayableOutput = ScriptPlayableOutput.Null;
			}
			else
			{
				scriptPlayableOutput = new ScriptPlayableOutput(playableOutputHandle);
			}
			return scriptPlayableOutput;
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x000ADF58 File Offset: 0x000AC158
		public static ScriptPlayableOutput Null
		{
			get
			{
				return new ScriptPlayableOutput(PlayableOutputHandle.Null);
			}
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x000ADF74 File Offset: 0x000AC174
		public PlayableOutputHandle GetHandle()
		{
			return this.m_Handle;
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x000ADF8C File Offset: 0x000AC18C
		public static implicit operator PlayableOutput(ScriptPlayableOutput output)
		{
			return new PlayableOutput(output.GetHandle());
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x000ADFAC File Offset: 0x000AC1AC
		public static explicit operator ScriptPlayableOutput(PlayableOutput output)
		{
			return new ScriptPlayableOutput(output.GetHandle());
		}

		// Token: 0x04002565 RID: 9573
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04002566 RID: 9574
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;
	}
}
