using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000349 RID: 841
	public class SplashScreen
	{
		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06002E38 RID: 11832 RVA: 0x00012858 File Offset: 0x00010A58
		public static bool isFinished
		{
			get
			{
				return SplashScreen.get_isFinishedDelegateField();
			}
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x00012864 File Offset: 0x00010A64
		public static void CancelSplashScreen()
		{
			SplashScreen.CancelSplashScreenDelegateField();
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x00012870 File Offset: 0x00010A70
		public static void BeginSplashScreenFade()
		{
			SplashScreen.BeginSplashScreenFadeDelegateField();
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x0001287C File Offset: 0x00010A7C
		public static void Begin()
		{
			SplashScreen.BeginDelegateField();
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x000B4BD8 File Offset: 0x000B2DD8
		public static void Stop(SplashScreen.StopBehavior stopBehavior)
		{
			bool flag = stopBehavior == SplashScreen.StopBehavior.FadeOut;
			if (flag)
			{
				SplashScreen.BeginSplashScreenFade();
			}
			else
			{
				SplashScreen.CancelSplashScreen();
			}
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x00012888 File Offset: 0x00010A88
		public static void Draw()
		{
			SplashScreen.DrawDelegateField();
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x00012894 File Offset: 0x00010A94
		public static void SetTime(float time)
		{
			SplashScreen.SetTimeDelegateField(time);
		}

		// Token: 0x04002A17 RID: 10775
		private static readonly SplashScreen.get_isFinishedDelegate get_isFinishedDelegateField = IL2CPP.ResolveICall<SplashScreen.get_isFinishedDelegate>("UnityEngine.Rendering.SplashScreen::get_isFinished");

		// Token: 0x04002A18 RID: 10776
		private static readonly SplashScreen.CancelSplashScreenDelegate CancelSplashScreenDelegateField = IL2CPP.ResolveICall<SplashScreen.CancelSplashScreenDelegate>("UnityEngine.Rendering.SplashScreen::CancelSplashScreen");

		// Token: 0x04002A19 RID: 10777
		private static readonly SplashScreen.BeginSplashScreenFadeDelegate BeginSplashScreenFadeDelegateField = IL2CPP.ResolveICall<SplashScreen.BeginSplashScreenFadeDelegate>("UnityEngine.Rendering.SplashScreen::BeginSplashScreenFade");

		// Token: 0x04002A1A RID: 10778
		private static readonly SplashScreen.BeginDelegate BeginDelegateField = IL2CPP.ResolveICall<SplashScreen.BeginDelegate>("UnityEngine.Rendering.SplashScreen::Begin");

		// Token: 0x04002A1B RID: 10779
		private static readonly SplashScreen.DrawDelegate DrawDelegateField = IL2CPP.ResolveICall<SplashScreen.DrawDelegate>("UnityEngine.Rendering.SplashScreen::Draw");

		// Token: 0x04002A1C RID: 10780
		private static readonly SplashScreen.SetTimeDelegate SetTimeDelegateField = IL2CPP.ResolveICall<SplashScreen.SetTimeDelegate>("UnityEngine.Rendering.SplashScreen::SetTime");

		// Token: 0x02000B8A RID: 2954
		public enum StopBehavior
		{
			// Token: 0x04002DB9 RID: 11705
			StopImmediate,
			// Token: 0x04002DBA RID: 11706
			FadeOut
		}

		// Token: 0x02000B8B RID: 2955
		// (Invoke) Token: 0x06004007 RID: 16391
		private delegate bool get_isFinishedDelegate();

		// Token: 0x02000B8C RID: 2956
		// (Invoke) Token: 0x06004009 RID: 16393
		private delegate void CancelSplashScreenDelegate();

		// Token: 0x02000B8D RID: 2957
		// (Invoke) Token: 0x0600400B RID: 16395
		private delegate void BeginSplashScreenFadeDelegate();

		// Token: 0x02000B8E RID: 2958
		// (Invoke) Token: 0x0600400D RID: 16397
		private delegate void BeginDelegate();

		// Token: 0x02000B8F RID: 2959
		// (Invoke) Token: 0x0600400F RID: 16399
		private delegate void DrawDelegate();

		// Token: 0x02000B90 RID: 2960
		// (Invoke) Token: 0x06004011 RID: 16401
		private delegate void SetTimeDelegate(float time);
	}
}
