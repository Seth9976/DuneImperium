using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000021 RID: 33
	[OriginalName("Mono.Security.dll", "Mono.Security.Interface", "AlertDescription")]
	public enum AlertDescription : byte
	{
		// Token: 0x04000180 RID: 384
		CloseNotify,
		// Token: 0x04000181 RID: 385
		UnexpectedMessage = 10,
		// Token: 0x04000182 RID: 386
		BadRecordMAC = 20,
		// Token: 0x04000183 RID: 387
		DecryptionFailed_RESERVED,
		// Token: 0x04000184 RID: 388
		RecordOverflow,
		// Token: 0x04000185 RID: 389
		DecompressionFailure = 30,
		// Token: 0x04000186 RID: 390
		HandshakeFailure = 40,
		// Token: 0x04000187 RID: 391
		NoCertificate_RESERVED,
		// Token: 0x04000188 RID: 392
		BadCertificate,
		// Token: 0x04000189 RID: 393
		UnsupportedCertificate,
		// Token: 0x0400018A RID: 394
		CertificateRevoked,
		// Token: 0x0400018B RID: 395
		CertificateExpired,
		// Token: 0x0400018C RID: 396
		CertificateUnknown,
		// Token: 0x0400018D RID: 397
		IlegalParameter,
		// Token: 0x0400018E RID: 398
		UnknownCA,
		// Token: 0x0400018F RID: 399
		AccessDenied,
		// Token: 0x04000190 RID: 400
		DecodeError,
		// Token: 0x04000191 RID: 401
		DecryptError,
		// Token: 0x04000192 RID: 402
		ExportRestriction = 60,
		// Token: 0x04000193 RID: 403
		ProtocolVersion = 70,
		// Token: 0x04000194 RID: 404
		InsuficientSecurity,
		// Token: 0x04000195 RID: 405
		InternalError = 80,
		// Token: 0x04000196 RID: 406
		UserCancelled = 90,
		// Token: 0x04000197 RID: 407
		NoRenegotiation = 100,
		// Token: 0x04000198 RID: 408
		UnsupportedExtension = 110
	}
}
