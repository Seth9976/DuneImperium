using System;
using Il2CppInterop.Runtime;

namespace UnityEngineInternal
{
	// Token: 0x0200028D RID: 653
	public static class GIDebugVisualisation
	{
		// Token: 0x06002C5F RID: 11359 RVA: 0x00011366 File Offset: 0x0000F566
		public static void ResetRuntimeInputTextures()
		{
			GIDebugVisualisation.ResetRuntimeInputTexturesDelegateField();
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x00011372 File Offset: 0x0000F572
		public static void PlayCycleMode()
		{
			GIDebugVisualisation.PlayCycleModeDelegateField();
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x0001137E File Offset: 0x0000F57E
		public static void PauseCycleMode()
		{
			GIDebugVisualisation.PauseCycleModeDelegateField();
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x0001138A File Offset: 0x0000F58A
		public static void StopCycleMode()
		{
			GIDebugVisualisation.StopCycleModeDelegateField();
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x00011396 File Offset: 0x0000F596
		public static void CycleSkipSystems(int skip)
		{
			GIDebugVisualisation.CycleSkipSystemsDelegateField(skip);
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x000113A3 File Offset: 0x0000F5A3
		public static void CycleSkipInstances(int skip)
		{
			GIDebugVisualisation.CycleSkipInstancesDelegateField(skip);
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x000113B0 File Offset: 0x0000F5B0
		public static bool cycleMode
		{
			get
			{
				return GIDebugVisualisation.get_cycleModeDelegateField();
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x000113BC File Offset: 0x0000F5BC
		public static bool pauseCycleMode
		{
			get
			{
				return GIDebugVisualisation.get_pauseCycleModeDelegateField();
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x000113C8 File Offset: 0x0000F5C8
		// (set) Token: 0x06002C68 RID: 11368 RVA: 0x000113D4 File Offset: 0x0000F5D4
		public static GITextureType texType
		{
			get
			{
				return GIDebugVisualisation.get_texTypeDelegateField();
			}
			set
			{
				GIDebugVisualisation.set_texTypeDelegateField(value);
			}
		}

		// Token: 0x040027AC RID: 10156
		private static readonly GIDebugVisualisation.ResetRuntimeInputTexturesDelegate ResetRuntimeInputTexturesDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.ResetRuntimeInputTexturesDelegate>("UnityEngineInternal.GIDebugVisualisation::ResetRuntimeInputTextures");

		// Token: 0x040027AD RID: 10157
		private static readonly GIDebugVisualisation.PlayCycleModeDelegate PlayCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.PlayCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::PlayCycleMode");

		// Token: 0x040027AE RID: 10158
		private static readonly GIDebugVisualisation.PauseCycleModeDelegate PauseCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.PauseCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::PauseCycleMode");

		// Token: 0x040027AF RID: 10159
		private static readonly GIDebugVisualisation.StopCycleModeDelegate StopCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.StopCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::StopCycleMode");

		// Token: 0x040027B0 RID: 10160
		private static readonly GIDebugVisualisation.CycleSkipSystemsDelegate CycleSkipSystemsDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.CycleSkipSystemsDelegate>("UnityEngineInternal.GIDebugVisualisation::CycleSkipSystems");

		// Token: 0x040027B1 RID: 10161
		private static readonly GIDebugVisualisation.CycleSkipInstancesDelegate CycleSkipInstancesDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.CycleSkipInstancesDelegate>("UnityEngineInternal.GIDebugVisualisation::CycleSkipInstances");

		// Token: 0x040027B2 RID: 10162
		private static readonly GIDebugVisualisation.get_cycleModeDelegate get_cycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_cycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_cycleMode");

		// Token: 0x040027B3 RID: 10163
		private static readonly GIDebugVisualisation.get_pauseCycleModeDelegate get_pauseCycleModeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_pauseCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_pauseCycleMode");

		// Token: 0x040027B4 RID: 10164
		private static readonly GIDebugVisualisation.get_texTypeDelegate get_texTypeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.get_texTypeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_texType");

		// Token: 0x040027B5 RID: 10165
		private static readonly GIDebugVisualisation.set_texTypeDelegate set_texTypeDelegateField = IL2CPP.ResolveICall<GIDebugVisualisation.set_texTypeDelegate>("UnityEngineInternal.GIDebugVisualisation::set_texType");

		// Token: 0x02000AA3 RID: 2723
		// (Invoke) Token: 0x06003E5F RID: 15967
		private delegate void ResetRuntimeInputTexturesDelegate();

		// Token: 0x02000AA4 RID: 2724
		// (Invoke) Token: 0x06003E61 RID: 15969
		private delegate void PlayCycleModeDelegate();

		// Token: 0x02000AA5 RID: 2725
		// (Invoke) Token: 0x06003E63 RID: 15971
		private delegate void PauseCycleModeDelegate();

		// Token: 0x02000AA6 RID: 2726
		// (Invoke) Token: 0x06003E65 RID: 15973
		private delegate void StopCycleModeDelegate();

		// Token: 0x02000AA7 RID: 2727
		// (Invoke) Token: 0x06003E67 RID: 15975
		private delegate void CycleSkipSystemsDelegate(int skip);

		// Token: 0x02000AA8 RID: 2728
		// (Invoke) Token: 0x06003E69 RID: 15977
		private delegate void CycleSkipInstancesDelegate(int skip);

		// Token: 0x02000AA9 RID: 2729
		// (Invoke) Token: 0x06003E6B RID: 15979
		private delegate bool get_cycleModeDelegate();

		// Token: 0x02000AAA RID: 2730
		// (Invoke) Token: 0x06003E6D RID: 15981
		private delegate bool get_pauseCycleModeDelegate();

		// Token: 0x02000AAB RID: 2731
		// (Invoke) Token: 0x06003E6F RID: 15983
		private delegate GITextureType get_texTypeDelegate();

		// Token: 0x02000AAC RID: 2732
		// (Invoke) Token: 0x06003E71 RID: 15985
		private delegate void set_texTypeDelegate(GITextureType value);
	}
}
