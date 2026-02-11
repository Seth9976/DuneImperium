using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Subsystems
{
	// Token: 0x02000015 RID: 21
	public class ExampleSubsystem : IntegratedSubsystem<ExampleSubsystemDescriptor>
	{
		// Token: 0x06000093 RID: 147 RVA: 0x0000257B File Offset: 0x0000077B
		public void PrintExample()
		{
			ExampleSubsystem.PrintExampleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000258D File Offset: 0x0000078D
		public bool GetBool()
		{
			return ExampleSubsystem.GetBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04000035 RID: 53
		private static readonly ExampleSubsystem.PrintExampleDelegate PrintExampleDelegateField = IL2CPP.ResolveICall<ExampleSubsystem.PrintExampleDelegate>("UnityEngine.Subsystems.ExampleSubsystem::PrintExample");

		// Token: 0x04000036 RID: 54
		private static readonly ExampleSubsystem.GetBoolDelegate GetBoolDelegateField = IL2CPP.ResolveICall<ExampleSubsystem.GetBoolDelegate>("UnityEngine.Subsystems.ExampleSubsystem::GetBool");

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x060000A9 RID: 169
		private delegate void PrintExampleDelegate(IntPtr @this);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060000AB RID: 171
		private delegate bool GetBoolDelegate(IntPtr @this);
	}
}
