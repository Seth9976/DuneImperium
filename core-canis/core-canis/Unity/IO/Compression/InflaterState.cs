using System;

namespace Unity.IO.Compression
{
	// Token: 0x02000077 RID: 119
	public enum InflaterState
	{
		// Token: 0x040006A0 RID: 1696
		ReadingHeader,
		// Token: 0x040006A1 RID: 1697
		ReadingBFinal = 2,
		// Token: 0x040006A2 RID: 1698
		ReadingBType,
		// Token: 0x040006A3 RID: 1699
		ReadingNumLitCodes,
		// Token: 0x040006A4 RID: 1700
		ReadingNumDistCodes,
		// Token: 0x040006A5 RID: 1701
		ReadingNumCodeLengthCodes,
		// Token: 0x040006A6 RID: 1702
		ReadingCodeLengthCodes,
		// Token: 0x040006A7 RID: 1703
		ReadingTreeCodesBefore,
		// Token: 0x040006A8 RID: 1704
		ReadingTreeCodesAfter,
		// Token: 0x040006A9 RID: 1705
		DecodeTop,
		// Token: 0x040006AA RID: 1706
		HaveInitialLength,
		// Token: 0x040006AB RID: 1707
		HaveFullLength,
		// Token: 0x040006AC RID: 1708
		HaveDistCode,
		// Token: 0x040006AD RID: 1709
		UncompressedAligning = 15,
		// Token: 0x040006AE RID: 1710
		UncompressedByte1,
		// Token: 0x040006AF RID: 1711
		UncompressedByte2,
		// Token: 0x040006B0 RID: 1712
		UncompressedByte3,
		// Token: 0x040006B1 RID: 1713
		UncompressedByte4,
		// Token: 0x040006B2 RID: 1714
		DecodingUncompressed,
		// Token: 0x040006B3 RID: 1715
		StartReadingFooter,
		// Token: 0x040006B4 RID: 1716
		ReadingFooter,
		// Token: 0x040006B5 RID: 1717
		VerifyingFooter,
		// Token: 0x040006B6 RID: 1718
		Done
	}
}
