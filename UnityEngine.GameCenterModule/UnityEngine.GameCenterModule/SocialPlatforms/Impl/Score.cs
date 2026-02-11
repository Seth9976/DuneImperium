using System;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x02000014 RID: 20
	public class Score
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x0000269C File Offset: 0x0000089C
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000026A9 File Offset: 0x000008A9
		public void ReportScore(Action<bool> callback)
		{
			ActivePlatform.Instance.ReportScore(this.value, this.leaderboardID, callback);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000026C4 File Offset: 0x000008C4
		public void SetDate(DateTime date)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000026D1 File Offset: 0x000008D1
		public void SetFormattedValue(string value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000026DE File Offset: 0x000008DE
		public void SetUserID(string userID)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000026EB File Offset: 0x000008EB
		public void SetRank(int rank)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000026F8 File Offset: 0x000008F8
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002705 File Offset: 0x00000905
		public string leaderboardID
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002712 File Offset: 0x00000912
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000271F File Offset: 0x0000091F
		public long value
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000272C File Offset: 0x0000092C
		public DateTime date
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002739 File Offset: 0x00000939
		public string formattedValue
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00002746 File Offset: 0x00000946
		public string userID
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002753 File Offset: 0x00000953
		public int rank
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
