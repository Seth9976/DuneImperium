using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020002DA RID: 730
	public sealed class LensFlare : Behaviour
	{
		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x00011D08 File Offset: 0x0000FF08
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x00011D1A File Offset: 0x0000FF1A
		public float brightness
		{
			get
			{
				return LensFlare.get_brightnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LensFlare.set_brightnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x00011D2D File Offset: 0x0000FF2D
		// (set) Token: 0x06002D44 RID: 11588 RVA: 0x00011D3F File Offset: 0x0000FF3F
		public float fadeSpeed
		{
			get
			{
				return LensFlare.get_fadeSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LensFlare.set_fadeSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x000B356C File Offset: 0x000B176C
		// (set) Token: 0x06002D46 RID: 11590 RVA: 0x00011D52 File Offset: 0x0000FF52
		public Color color
		{
			get
			{
				Color color;
				this.get_color_Injected(out color);
				return color;
			}
			set
			{
				this.set_color_Injected(ref value);
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x000B3584 File Offset: 0x000B1784
		// (set) Token: 0x06002D48 RID: 11592 RVA: 0x00011D5C File Offset: 0x0000FF5C
		public Flare flare
		{
			get
			{
				IntPtr intPtr = LensFlare.get_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Flare>(intPtr2) : null;
			}
			set
			{
				LensFlare.set_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x00011D74 File Offset: 0x0000FF74
		public void get_color_Injected(out Color ret)
		{
			LensFlare.get_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x00011D87 File Offset: 0x0000FF87
		public void set_color_Injected(ref Color value)
		{
			LensFlare.set_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04002894 RID: 10388
		private static readonly LensFlare.get_brightnessDelegate get_brightnessDelegateField = IL2CPP.ResolveICall<LensFlare.get_brightnessDelegate>("UnityEngine.LensFlare::get_brightness");

		// Token: 0x04002895 RID: 10389
		private static readonly LensFlare.set_brightnessDelegate set_brightnessDelegateField = IL2CPP.ResolveICall<LensFlare.set_brightnessDelegate>("UnityEngine.LensFlare::set_brightness");

		// Token: 0x04002896 RID: 10390
		private static readonly LensFlare.get_fadeSpeedDelegate get_fadeSpeedDelegateField = IL2CPP.ResolveICall<LensFlare.get_fadeSpeedDelegate>("UnityEngine.LensFlare::get_fadeSpeed");

		// Token: 0x04002897 RID: 10391
		private static readonly LensFlare.set_fadeSpeedDelegate set_fadeSpeedDelegateField = IL2CPP.ResolveICall<LensFlare.set_fadeSpeedDelegate>("UnityEngine.LensFlare::set_fadeSpeed");

		// Token: 0x04002898 RID: 10392
		private static readonly LensFlare.get_flareDelegate get_flareDelegateField = IL2CPP.ResolveICall<LensFlare.get_flareDelegate>("UnityEngine.LensFlare::get_flare");

		// Token: 0x04002899 RID: 10393
		private static readonly LensFlare.set_flareDelegate set_flareDelegateField = IL2CPP.ResolveICall<LensFlare.set_flareDelegate>("UnityEngine.LensFlare::set_flare");

		// Token: 0x0400289A RID: 10394
		private static readonly LensFlare.get_color_InjectedDelegate get_color_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.get_color_InjectedDelegate>("UnityEngine.LensFlare::get_color_Injected");

		// Token: 0x0400289B RID: 10395
		private static readonly LensFlare.set_color_InjectedDelegate set_color_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.set_color_InjectedDelegate>("UnityEngine.LensFlare::set_color_Injected");

		// Token: 0x02000B22 RID: 2850
		// (Invoke) Token: 0x06003F39 RID: 16185
		private delegate float get_brightnessDelegate(IntPtr @this);

		// Token: 0x02000B23 RID: 2851
		// (Invoke) Token: 0x06003F3B RID: 16187
		private delegate void set_brightnessDelegate(IntPtr @this, float value);

		// Token: 0x02000B24 RID: 2852
		// (Invoke) Token: 0x06003F3D RID: 16189
		private delegate float get_fadeSpeedDelegate(IntPtr @this);

		// Token: 0x02000B25 RID: 2853
		// (Invoke) Token: 0x06003F3F RID: 16191
		private delegate void set_fadeSpeedDelegate(IntPtr @this, float value);

		// Token: 0x02000B26 RID: 2854
		// (Invoke) Token: 0x06003F41 RID: 16193
		private delegate IntPtr get_flareDelegate(IntPtr @this);

		// Token: 0x02000B27 RID: 2855
		// (Invoke) Token: 0x06003F43 RID: 16195
		private delegate void set_flareDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B28 RID: 2856
		// (Invoke) Token: 0x06003F45 RID: 16197
		private delegate void get_color_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000B29 RID: 2857
		// (Invoke) Token: 0x06003F47 RID: 16199
		private delegate void set_color_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
