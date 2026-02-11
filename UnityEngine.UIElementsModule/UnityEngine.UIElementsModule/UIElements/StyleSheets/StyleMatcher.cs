using System;
using Il2CppSystem;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002F5 RID: 757
	public class StyleMatcher : BaseStyleMatcher
	{
		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x00015712 File Offset: 0x00013912
		public string current
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x060034B3 RID: 13491 RVA: 0x0001571F File Offset: 0x0001391F
		public override int valueCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x0001572C File Offset: 0x0001392C
		public override bool isCurrentVariable
		{
			get
			{
				return base.hasCurrent && this.current.StartsWith("var(");
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x060034B5 RID: 13493 RVA: 0x00015749 File Offset: 0x00013949
		public override bool isCurrentComma
		{
			get
			{
				return base.hasCurrent && this.current == ",";
			}
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x00015766 File Offset: 0x00013966
		public void Initialize(string propertyValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x000DC80C File Offset: 0x000DAA0C
		public MatchResult Match(UnityEngine.UIElements.StyleSheets.Syntax.Expression exp, string propertyValue)
		{
			MatchResult matchResult = null;
			matchResult.errorCode = MatchResultErrorCode.None;
			MatchResult matchResult2 = matchResult;
			bool flag = String.IsNullOrEmpty(propertyValue);
			MatchResult matchResult3;
			if (flag)
			{
				matchResult2.errorCode = MatchResultErrorCode.EmptyValue;
				matchResult3 = matchResult2;
			}
			else
			{
				this.Initialize(propertyValue);
				string current = this.current;
				bool flag2 = current == "initial" || current.StartsWith("env(");
				bool flag3;
				if (flag2)
				{
					base.MoveNext();
					flag3 = true;
				}
				else
				{
					flag3 = base.Match(exp);
				}
				bool flag4 = !flag3;
				if (flag4)
				{
					matchResult2.errorCode = MatchResultErrorCode.Syntax;
					matchResult2.errorValue = this.current;
				}
				else
				{
					bool hasCurrent = base.hasCurrent;
					if (hasCurrent)
					{
						matchResult2.errorCode = MatchResultErrorCode.ExpectedEndOfValue;
						matchResult2.errorValue = this.current;
					}
				}
				matchResult3 = matchResult2;
			}
			return matchResult3;
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x000DC8E0 File Offset: 0x000DAAE0
		public override bool MatchKeyword(string keyword)
		{
			return String.Compare(this.current, keyword, StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00015773 File Offset: 0x00013973
		public override bool MatchNumber()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00015780 File Offset: 0x00013980
		public override bool MatchInteger()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x0001578D File Offset: 0x0001398D
		public override bool MatchLength()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x0001579A File Offset: 0x0001399A
		public override bool MatchPercentage()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x000157A7 File Offset: 0x000139A7
		public override bool MatchColor()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x000157B4 File Offset: 0x000139B4
		public override bool MatchResource()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x000157C1 File Offset: 0x000139C1
		public override bool MatchUrl()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x000157CE File Offset: 0x000139CE
		public override bool MatchTime()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x000157DB File Offset: 0x000139DB
		public override bool MatchAngle()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x000157E8 File Offset: 0x000139E8
		public override bool MatchCustomIdent()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
