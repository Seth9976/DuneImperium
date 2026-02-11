using System;

namespace dwd.canis
{
	// Token: 0x02000049 RID: 73
	public enum InputType
	{
		// Token: 0x040001B2 RID: 434
		Default,
		// Token: 0x040001B3 RID: 435
		Url,
		// Token: 0x040001B4 RID: 436
		EmailSmtpAddress = 5,
		// Token: 0x040001B5 RID: 437
		Number = 29,
		// Token: 0x040001B6 RID: 438
		Password = 31,
		// Token: 0x040001B7 RID: 439
		TelephoneNumber,
		// Token: 0x040001B8 RID: 440
		Alphanumeric = 40,
		// Token: 0x040001B9 RID: 441
		Search = 50,
		// Token: 0x040001BA RID: 442
		ChatWithoutEmoji = 68
	}
}
