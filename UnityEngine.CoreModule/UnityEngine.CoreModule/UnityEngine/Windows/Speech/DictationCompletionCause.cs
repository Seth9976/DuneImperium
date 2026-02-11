using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000199 RID: 409
	public enum DictationCompletionCause
	{
		// Token: 0x04001AC1 RID: 6849
		Complete,
		// Token: 0x04001AC2 RID: 6850
		AudioQualityFailure,
		// Token: 0x04001AC3 RID: 6851
		Canceled,
		// Token: 0x04001AC4 RID: 6852
		TimeoutExceeded,
		// Token: 0x04001AC5 RID: 6853
		PauseLimitExceeded,
		// Token: 0x04001AC6 RID: 6854
		NetworkFailure,
		// Token: 0x04001AC7 RID: 6855
		MicrophoneUnavailable,
		// Token: 0x04001AC8 RID: 6856
		UnknownError
	}
}
