using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Device
{
	// Token: 0x02000360 RID: 864
	public static class Screen
	{
		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06002EAA RID: 11946 RVA: 0x00012A19 File Offset: 0x00010C19
		// (set) Token: 0x06002EAB RID: 11947 RVA: 0x00012A20 File Offset: 0x00010C20
		public static float brightness
		{
			get
			{
				return Screen.brightness;
			}
			set
			{
				Screen.brightness = value;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06002EAC RID: 11948 RVA: 0x00012A29 File Offset: 0x00010C29
		// (set) Token: 0x06002EAD RID: 11949 RVA: 0x00012A30 File Offset: 0x00010C30
		public static bool autorotateToLandscapeLeft
		{
			get
			{
				return Screen.autorotateToLandscapeLeft;
			}
			set
			{
				Screen.autorotateToLandscapeLeft = value;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06002EAE RID: 11950 RVA: 0x00012A39 File Offset: 0x00010C39
		// (set) Token: 0x06002EAF RID: 11951 RVA: 0x00012A40 File Offset: 0x00010C40
		public static bool autorotateToLandscapeRight
		{
			get
			{
				return Screen.autorotateToLandscapeRight;
			}
			set
			{
				Screen.autorotateToLandscapeRight = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x00012A49 File Offset: 0x00010C49
		// (set) Token: 0x06002EB1 RID: 11953 RVA: 0x00012A50 File Offset: 0x00010C50
		public static bool autorotateToPortrait
		{
			get
			{
				return Screen.autorotateToPortrait;
			}
			set
			{
				Screen.autorotateToPortrait = value;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x00012A59 File Offset: 0x00010C59
		// (set) Token: 0x06002EB3 RID: 11955 RVA: 0x00012A60 File Offset: 0x00010C60
		public static bool autorotateToPortraitUpsideDown
		{
			get
			{
				return Screen.autorotateToPortraitUpsideDown;
			}
			set
			{
				Screen.autorotateToPortraitUpsideDown = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x00012A69 File Offset: 0x00010C69
		public static Resolution currentResolution
		{
			get
			{
				return Screen.currentResolution;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06002EB5 RID: 11957 RVA: 0x00012A70 File Offset: 0x00010C70
		public static Il2CppStructArray<Rect> cutouts
		{
			get
			{
				return Screen.cutouts;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06002EB6 RID: 11958 RVA: 0x00012A77 File Offset: 0x00010C77
		public static float dpi
		{
			get
			{
				return Screen.dpi;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x00012A7E File Offset: 0x00010C7E
		// (set) Token: 0x06002EB8 RID: 11960 RVA: 0x00012A85 File Offset: 0x00010C85
		public static bool fullScreen
		{
			get
			{
				return Screen.fullScreen;
			}
			set
			{
				Screen.fullScreen = value;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002EB9 RID: 11961 RVA: 0x00012A8E File Offset: 0x00010C8E
		// (set) Token: 0x06002EBA RID: 11962 RVA: 0x00012A95 File Offset: 0x00010C95
		public static FullScreenMode fullScreenMode
		{
			get
			{
				return Screen.fullScreenMode;
			}
			set
			{
				Screen.fullScreenMode = value;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x00012A9E File Offset: 0x00010C9E
		public static int height
		{
			get
			{
				return Screen.height;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x00012AA5 File Offset: 0x00010CA5
		public static int width
		{
			get
			{
				return Screen.width;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x00012AAC File Offset: 0x00010CAC
		// (set) Token: 0x06002EBE RID: 11966 RVA: 0x00012AB3 File Offset: 0x00010CB3
		public static ScreenOrientation orientation
		{
			get
			{
				return Screen.orientation;
			}
			set
			{
				Screen.orientation = value;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06002EBF RID: 11967 RVA: 0x00012ABC File Offset: 0x00010CBC
		public static Il2CppStructArray<Resolution> resolutions
		{
			get
			{
				return Screen.resolutions;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x00012AC3 File Offset: 0x00010CC3
		public static Rect safeArea
		{
			get
			{
				return Screen.safeArea;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002EC1 RID: 11969 RVA: 0x00012ACA File Offset: 0x00010CCA
		// (set) Token: 0x06002EC2 RID: 11970 RVA: 0x00012AD1 File Offset: 0x00010CD1
		public static int sleepTimeout
		{
			get
			{
				return Screen.sleepTimeout;
			}
			set
			{
				Screen.sleepTimeout = value;
			}
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00012ADA File Offset: 0x00010CDA
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate)
		{
			Screen.SetResolution(width, height, fullscreenMode, preferredRefreshRate);
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x000B58D0 File Offset: 0x000B3AD0
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate)
		{
			bool flag = preferredRefreshRate < 0;
			if (flag)
			{
				preferredRefreshRate = 0;
			}
			Screen.SetResolution(width, height, fullscreenMode, new RefreshRate
			{
				numerator = (uint)preferredRefreshRate,
				denominator = 1U
			});
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x000B590C File Offset: 0x000B3B0C
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode)
		{
			Screen.SetResolution(width, height, fullscreenMode, new RefreshRate
			{
				numerator = 0U,
				denominator = 1U
			});
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x000B593C File Offset: 0x000B3B3C
		public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate)
		{
			bool flag = preferredRefreshRate < 0;
			if (flag)
			{
				preferredRefreshRate = 0;
			}
			Screen.SetResolution(width, height, fullscreen ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed, new RefreshRate
			{
				numerator = (uint)preferredRefreshRate,
				denominator = 1U
			});
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x000B5980 File Offset: 0x000B3B80
		public static void SetResolution(int width, int height, bool fullscreen)
		{
			Screen.SetResolution(width, height, fullscreen ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed, new RefreshRate
			{
				numerator = 0U,
				denominator = 1U
			});
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x00012AE7 File Offset: 0x00010CE7
		public static Vector2Int mainWindowPosition
		{
			get
			{
				return Screen.mainWindowPosition;
			}
		}
	}
}
