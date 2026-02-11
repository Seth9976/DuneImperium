using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000364 RID: 868
	public class RenderSettings
	{
		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002F36 RID: 12086 RVA: 0x00012E0E File Offset: 0x0001100E
		// (set) Token: 0x06002F37 RID: 12087 RVA: 0x00012E1A File Offset: 0x0001101A
		public static bool useRadianceAmbientProbe
		{
			get
			{
				return RenderSettings.get_useRadianceAmbientProbeDelegateField();
			}
			set
			{
				RenderSettings.set_useRadianceAmbientProbeDelegateField(value);
			}
		}

		// Token: 0x04002A61 RID: 10849
		private static readonly RenderSettings.get_useRadianceAmbientProbeDelegate get_useRadianceAmbientProbeDelegateField = IL2CPP.ResolveICall<RenderSettings.get_useRadianceAmbientProbeDelegate>("UnityEngine.Experimental.GlobalIllumination.RenderSettings::get_useRadianceAmbientProbe");

		// Token: 0x04002A62 RID: 10850
		private static readonly RenderSettings.set_useRadianceAmbientProbeDelegate set_useRadianceAmbientProbeDelegateField = IL2CPP.ResolveICall<RenderSettings.set_useRadianceAmbientProbeDelegate>("UnityEngine.Experimental.GlobalIllumination.RenderSettings::set_useRadianceAmbientProbe");

		// Token: 0x02000BA8 RID: 2984
		// (Invoke) Token: 0x06004041 RID: 16449
		private delegate bool get_useRadianceAmbientProbeDelegate();

		// Token: 0x02000BA9 RID: 2985
		// (Invoke) Token: 0x06004043 RID: 16451
		private delegate void set_useRadianceAmbientProbeDelegate(bool value);
	}
}
