using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000198 RID: 408
	public enum SpeechError
	{
		// Token: 0x04001AB6 RID: 6838
		NoError,
		// Token: 0x04001AB7 RID: 6839
		TopicLanguageNotSupported,
		// Token: 0x04001AB8 RID: 6840
		GrammarLanguageMismatch,
		// Token: 0x04001AB9 RID: 6841
		GrammarCompilationFailure,
		// Token: 0x04001ABA RID: 6842
		AudioQualityFailure,
		// Token: 0x04001ABB RID: 6843
		PauseLimitExceeded,
		// Token: 0x04001ABC RID: 6844
		TimeoutExceeded,
		// Token: 0x04001ABD RID: 6845
		NetworkFailure,
		// Token: 0x04001ABE RID: 6846
		MicrophoneUnavailable,
		// Token: 0x04001ABF RID: 6847
		UnknownError
	}
}
