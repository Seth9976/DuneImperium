using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Subsystems
{
	// Token: 0x02000016 RID: 22
	public class ExampleSubsystemDescriptor : IntegratedSubsystemDescriptor<ExampleSubsystem>
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000025DD File Offset: 0x000007DD
		public bool supportsEditorMode
		{
			get
			{
				return ExampleSubsystemDescriptor.get_supportsEditorModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000025EF File Offset: 0x000007EF
		public bool disableBackbufferMSAA
		{
			get
			{
				return ExampleSubsystemDescriptor.get_disableBackbufferMSAADelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002601 File Offset: 0x00000801
		public bool stereoscopicBackbuffer
		{
			get
			{
				return ExampleSubsystemDescriptor.get_stereoscopicBackbufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002613 File Offset: 0x00000813
		public bool usePBufferEGL
		{
			get
			{
				return ExampleSubsystemDescriptor.get_usePBufferEGLDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x04000037 RID: 55
		private static readonly ExampleSubsystemDescriptor.get_supportsEditorModeDelegate get_supportsEditorModeDelegateField = IL2CPP.ResolveICall<ExampleSubsystemDescriptor.get_supportsEditorModeDelegate>("UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_supportsEditorMode");

		// Token: 0x04000038 RID: 56
		private static readonly ExampleSubsystemDescriptor.get_disableBackbufferMSAADelegate get_disableBackbufferMSAADelegateField = IL2CPP.ResolveICall<ExampleSubsystemDescriptor.get_disableBackbufferMSAADelegate>("UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_disableBackbufferMSAA");

		// Token: 0x04000039 RID: 57
		private static readonly ExampleSubsystemDescriptor.get_stereoscopicBackbufferDelegate get_stereoscopicBackbufferDelegateField = IL2CPP.ResolveICall<ExampleSubsystemDescriptor.get_stereoscopicBackbufferDelegate>("UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_stereoscopicBackbuffer");

		// Token: 0x0400003A RID: 58
		private static readonly ExampleSubsystemDescriptor.get_usePBufferEGLDelegate get_usePBufferEGLDelegateField = IL2CPP.ResolveICall<ExampleSubsystemDescriptor.get_usePBufferEGLDelegate>("UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_usePBufferEGL");

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060000AD RID: 173
		private delegate bool get_supportsEditorModeDelegate(IntPtr @this);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060000AF RID: 175
		private delegate bool get_disableBackbufferMSAADelegate(IntPtr @this);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x060000B1 RID: 177
		private delegate bool get_stereoscopicBackbufferDelegate(IntPtr @this);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060000B3 RID: 179
		private delegate bool get_usePBufferEGLDelegate(IntPtr @this);
	}
}
