using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x0200000D RID: 13
	public class Leaderboard : Object
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00002581 File Offset: 0x00000781
		// Note: this type is marked as 'beforefieldinit'.
		static Leaderboard()
		{
			Il2CppClassPointerStore<Leaderboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.GameCenterModule.dll", "UnityEngine.SocialPlatforms.Impl", "Leaderboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000025A6 File Offset: 0x000007A6
		public Leaderboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000025AF File Offset: 0x000007AF
		public void SetUserFilter(Il2CppStringArray userIDs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000025BC File Offset: 0x000007BC
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000025C9 File Offset: 0x000007C9
		public void LoadScores(Action<bool> callback)
		{
			ActivePlatform.Instance.LoadScores(this, callback);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00003F08 File Offset: 0x00002108
		public bool loading
		{
			get
			{
				return ActivePlatform.Instance.GetLoading(this);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000025D9 File Offset: 0x000007D9
		public void SetLocalUserScore(IScore score)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000025E6 File Offset: 0x000007E6
		public void SetMaxRange(uint maxRange)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000025F3 File Offset: 0x000007F3
		public void SetScores(Il2CppReferenceArray<IScore> scores)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002600 File Offset: 0x00000800
		public void SetTitle(string title)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000260D File Offset: 0x0000080D
		public Il2CppStringArray GetUserFilter()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000261A File Offset: 0x0000081A
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002627 File Offset: 0x00000827
		public string id
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

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00002634 File Offset: 0x00000834
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002641 File Offset: 0x00000841
		public UserScope userScope
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

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000264E File Offset: 0x0000084E
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000265B File Offset: 0x0000085B
		public TimeScope timeScope
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

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00002668 File Offset: 0x00000868
		public IScore localUserScore
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002675 File Offset: 0x00000875
		public uint maxRange
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002682 File Offset: 0x00000882
		public Il2CppReferenceArray<IScore> scores
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000268F File Offset: 0x0000088F
		public string title
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
