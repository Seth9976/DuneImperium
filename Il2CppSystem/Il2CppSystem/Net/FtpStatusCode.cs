using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x020001AC RID: 428
	[OriginalName("System.dll", "System.Net", "FtpStatusCode")]
	public enum FtpStatusCode
	{
		// Token: 0x04001506 RID: 5382
		Undefined,
		// Token: 0x04001507 RID: 5383
		RestartMarker = 110,
		// Token: 0x04001508 RID: 5384
		ServiceTemporarilyNotAvailable = 120,
		// Token: 0x04001509 RID: 5385
		DataAlreadyOpen = 125,
		// Token: 0x0400150A RID: 5386
		OpeningData = 150,
		// Token: 0x0400150B RID: 5387
		CommandOK = 200,
		// Token: 0x0400150C RID: 5388
		CommandExtraneous = 202,
		// Token: 0x0400150D RID: 5389
		DirectoryStatus = 212,
		// Token: 0x0400150E RID: 5390
		FileStatus,
		// Token: 0x0400150F RID: 5391
		SystemType = 215,
		// Token: 0x04001510 RID: 5392
		SendUserCommand = 220,
		// Token: 0x04001511 RID: 5393
		ClosingControl,
		// Token: 0x04001512 RID: 5394
		ClosingData = 226,
		// Token: 0x04001513 RID: 5395
		EnteringPassive,
		// Token: 0x04001514 RID: 5396
		LoggedInProceed = 230,
		// Token: 0x04001515 RID: 5397
		ServerWantsSecureSession = 234,
		// Token: 0x04001516 RID: 5398
		FileActionOK = 250,
		// Token: 0x04001517 RID: 5399
		PathnameCreated = 257,
		// Token: 0x04001518 RID: 5400
		SendPasswordCommand = 331,
		// Token: 0x04001519 RID: 5401
		NeedLoginAccount,
		// Token: 0x0400151A RID: 5402
		FileCommandPending = 350,
		// Token: 0x0400151B RID: 5403
		ServiceNotAvailable = 421,
		// Token: 0x0400151C RID: 5404
		CantOpenData = 425,
		// Token: 0x0400151D RID: 5405
		ConnectionClosed,
		// Token: 0x0400151E RID: 5406
		ActionNotTakenFileUnavailableOrBusy = 450,
		// Token: 0x0400151F RID: 5407
		ActionAbortedLocalProcessingError,
		// Token: 0x04001520 RID: 5408
		ActionNotTakenInsufficientSpace,
		// Token: 0x04001521 RID: 5409
		CommandSyntaxError = 500,
		// Token: 0x04001522 RID: 5410
		ArgumentSyntaxError,
		// Token: 0x04001523 RID: 5411
		CommandNotImplemented,
		// Token: 0x04001524 RID: 5412
		BadCommandSequence,
		// Token: 0x04001525 RID: 5413
		NotLoggedIn = 530,
		// Token: 0x04001526 RID: 5414
		AccountNeeded = 532,
		// Token: 0x04001527 RID: 5415
		ActionNotTakenFileUnavailable = 550,
		// Token: 0x04001528 RID: 5416
		ActionAbortedUnknownPageType,
		// Token: 0x04001529 RID: 5417
		FileActionAborted,
		// Token: 0x0400152A RID: 5418
		ActionNotTakenFilenameNotAllowed
	}
}
