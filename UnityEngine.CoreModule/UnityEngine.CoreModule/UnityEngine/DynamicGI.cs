using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x020002CA RID: 714
	public sealed class DynamicGI
	{
		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x000118E1 File Offset: 0x0000FAE1
		// (set) Token: 0x06002CF2 RID: 11506 RVA: 0x000118ED File Offset: 0x0000FAED
		public static float indirectScale
		{
			get
			{
				return DynamicGI.get_indirectScaleDelegateField();
			}
			set
			{
				DynamicGI.set_indirectScaleDelegateField(value);
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x000118FA File Offset: 0x0000FAFA
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x00011906 File Offset: 0x0000FB06
		public static float updateThreshold
		{
			get
			{
				return DynamicGI.get_updateThresholdDelegateField();
			}
			set
			{
				DynamicGI.set_updateThresholdDelegateField(value);
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x00011913 File Offset: 0x0000FB13
		// (set) Token: 0x06002CF6 RID: 11510 RVA: 0x0001191F File Offset: 0x0000FB1F
		public static int materialUpdateTimeSlice
		{
			get
			{
				return DynamicGI.get_materialUpdateTimeSliceDelegateField();
			}
			set
			{
				DynamicGI.set_materialUpdateTimeSliceDelegateField(value);
			}
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x0001192C File Offset: 0x0000FB2C
		public static void SetEmissive(Renderer renderer, Color color)
		{
			DynamicGI.SetEmissive_Injected(renderer, ref color);
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00011936 File Offset: 0x0000FB36
		public static void SetEnvironmentData(Il2CppStructArray<float> input)
		{
			DynamicGI.SetEnvironmentDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(input));
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x00011948 File Offset: 0x0000FB48
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x00011954 File Offset: 0x0000FB54
		public static bool synchronousMode
		{
			get
			{
				return DynamicGI.get_synchronousModeDelegateField();
			}
			set
			{
				DynamicGI.set_synchronousModeDelegateField(value);
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x00011961 File Offset: 0x0000FB61
		public static bool isConverged
		{
			get
			{
				return DynamicGI.get_isConvergedDelegateField();
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x0001196D File Offset: 0x0000FB6D
		public static int scheduledMaterialUpdatesCount
		{
			get
			{
				return DynamicGI.get_scheduledMaterialUpdatesCountDelegateField();
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x00011979 File Offset: 0x0000FB79
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x00011985 File Offset: 0x0000FB85
		public static bool asyncMaterialUpdates
		{
			get
			{
				return DynamicGI.get_asyncMaterialUpdatesDelegateField();
			}
			set
			{
				DynamicGI.set_asyncMaterialUpdatesDelegateField(value);
			}
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x00011992 File Offset: 0x0000FB92
		public static void UpdateEnvironment()
		{
			DynamicGI.UpdateEnvironmentDelegateField();
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x0001199E File Offset: 0x0000FB9E
		public static void UpdateMaterials(Renderer renderer)
		{
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x000119A1 File Offset: 0x0000FBA1
		public static void UpdateMaterials(Object renderer)
		{
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x000119A4 File Offset: 0x0000FBA4
		public static void UpdateMaterials(Object renderer, int x, int y, int width, int height)
		{
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000119A7 File Offset: 0x0000FBA7
		public static void SetEmissive_Injected(Renderer renderer, ref Color color)
		{
			DynamicGI.SetEmissive_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer), ref color);
		}

		// Token: 0x04002857 RID: 10327
		private static readonly DynamicGI.get_indirectScaleDelegate get_indirectScaleDelegateField = IL2CPP.ResolveICall<DynamicGI.get_indirectScaleDelegate>("UnityEngine.DynamicGI::get_indirectScale");

		// Token: 0x04002858 RID: 10328
		private static readonly DynamicGI.set_indirectScaleDelegate set_indirectScaleDelegateField = IL2CPP.ResolveICall<DynamicGI.set_indirectScaleDelegate>("UnityEngine.DynamicGI::set_indirectScale");

		// Token: 0x04002859 RID: 10329
		private static readonly DynamicGI.get_updateThresholdDelegate get_updateThresholdDelegateField = IL2CPP.ResolveICall<DynamicGI.get_updateThresholdDelegate>("UnityEngine.DynamicGI::get_updateThreshold");

		// Token: 0x0400285A RID: 10330
		private static readonly DynamicGI.set_updateThresholdDelegate set_updateThresholdDelegateField = IL2CPP.ResolveICall<DynamicGI.set_updateThresholdDelegate>("UnityEngine.DynamicGI::set_updateThreshold");

		// Token: 0x0400285B RID: 10331
		private static readonly DynamicGI.get_materialUpdateTimeSliceDelegate get_materialUpdateTimeSliceDelegateField = IL2CPP.ResolveICall<DynamicGI.get_materialUpdateTimeSliceDelegate>("UnityEngine.DynamicGI::get_materialUpdateTimeSlice");

		// Token: 0x0400285C RID: 10332
		private static readonly DynamicGI.set_materialUpdateTimeSliceDelegate set_materialUpdateTimeSliceDelegateField = IL2CPP.ResolveICall<DynamicGI.set_materialUpdateTimeSliceDelegate>("UnityEngine.DynamicGI::set_materialUpdateTimeSlice");

		// Token: 0x0400285D RID: 10333
		private static readonly DynamicGI.SetEnvironmentDataDelegate SetEnvironmentDataDelegateField = IL2CPP.ResolveICall<DynamicGI.SetEnvironmentDataDelegate>("UnityEngine.DynamicGI::SetEnvironmentData");

		// Token: 0x0400285E RID: 10334
		private static readonly DynamicGI.get_synchronousModeDelegate get_synchronousModeDelegateField = IL2CPP.ResolveICall<DynamicGI.get_synchronousModeDelegate>("UnityEngine.DynamicGI::get_synchronousMode");

		// Token: 0x0400285F RID: 10335
		private static readonly DynamicGI.set_synchronousModeDelegate set_synchronousModeDelegateField = IL2CPP.ResolveICall<DynamicGI.set_synchronousModeDelegate>("UnityEngine.DynamicGI::set_synchronousMode");

		// Token: 0x04002860 RID: 10336
		private static readonly DynamicGI.get_isConvergedDelegate get_isConvergedDelegateField = IL2CPP.ResolveICall<DynamicGI.get_isConvergedDelegate>("UnityEngine.DynamicGI::get_isConverged");

		// Token: 0x04002861 RID: 10337
		private static readonly DynamicGI.get_scheduledMaterialUpdatesCountDelegate get_scheduledMaterialUpdatesCountDelegateField = IL2CPP.ResolveICall<DynamicGI.get_scheduledMaterialUpdatesCountDelegate>("UnityEngine.DynamicGI::get_scheduledMaterialUpdatesCount");

		// Token: 0x04002862 RID: 10338
		private static readonly DynamicGI.get_asyncMaterialUpdatesDelegate get_asyncMaterialUpdatesDelegateField = IL2CPP.ResolveICall<DynamicGI.get_asyncMaterialUpdatesDelegate>("UnityEngine.DynamicGI::get_asyncMaterialUpdates");

		// Token: 0x04002863 RID: 10339
		private static readonly DynamicGI.set_asyncMaterialUpdatesDelegate set_asyncMaterialUpdatesDelegateField = IL2CPP.ResolveICall<DynamicGI.set_asyncMaterialUpdatesDelegate>("UnityEngine.DynamicGI::set_asyncMaterialUpdates");

		// Token: 0x04002864 RID: 10340
		private static readonly DynamicGI.UpdateEnvironmentDelegate UpdateEnvironmentDelegateField = IL2CPP.ResolveICall<DynamicGI.UpdateEnvironmentDelegate>("UnityEngine.DynamicGI::UpdateEnvironment");

		// Token: 0x04002865 RID: 10341
		private static readonly DynamicGI.SetEmissive_InjectedDelegate SetEmissive_InjectedDelegateField = IL2CPP.ResolveICall<DynamicGI.SetEmissive_InjectedDelegate>("UnityEngine.DynamicGI::SetEmissive_Injected");

		// Token: 0x02000AF1 RID: 2801
		// (Invoke) Token: 0x06003ED7 RID: 16087
		private delegate float get_indirectScaleDelegate();

		// Token: 0x02000AF2 RID: 2802
		// (Invoke) Token: 0x06003ED9 RID: 16089
		private delegate void set_indirectScaleDelegate(float value);

		// Token: 0x02000AF3 RID: 2803
		// (Invoke) Token: 0x06003EDB RID: 16091
		private delegate float get_updateThresholdDelegate();

		// Token: 0x02000AF4 RID: 2804
		// (Invoke) Token: 0x06003EDD RID: 16093
		private delegate void set_updateThresholdDelegate(float value);

		// Token: 0x02000AF5 RID: 2805
		// (Invoke) Token: 0x06003EDF RID: 16095
		private delegate int get_materialUpdateTimeSliceDelegate();

		// Token: 0x02000AF6 RID: 2806
		// (Invoke) Token: 0x06003EE1 RID: 16097
		private delegate void set_materialUpdateTimeSliceDelegate(int value);

		// Token: 0x02000AF7 RID: 2807
		// (Invoke) Token: 0x06003EE3 RID: 16099
		private delegate void SetEnvironmentDataDelegate(IntPtr input);

		// Token: 0x02000AF8 RID: 2808
		// (Invoke) Token: 0x06003EE5 RID: 16101
		private delegate bool get_synchronousModeDelegate();

		// Token: 0x02000AF9 RID: 2809
		// (Invoke) Token: 0x06003EE7 RID: 16103
		private delegate void set_synchronousModeDelegate(bool value);

		// Token: 0x02000AFA RID: 2810
		// (Invoke) Token: 0x06003EE9 RID: 16105
		private delegate bool get_isConvergedDelegate();

		// Token: 0x02000AFB RID: 2811
		// (Invoke) Token: 0x06003EEB RID: 16107
		private delegate int get_scheduledMaterialUpdatesCountDelegate();

		// Token: 0x02000AFC RID: 2812
		// (Invoke) Token: 0x06003EED RID: 16109
		private delegate bool get_asyncMaterialUpdatesDelegate();

		// Token: 0x02000AFD RID: 2813
		// (Invoke) Token: 0x06003EEF RID: 16111
		private delegate void set_asyncMaterialUpdatesDelegate(bool value);

		// Token: 0x02000AFE RID: 2814
		// (Invoke) Token: 0x06003EF1 RID: 16113
		private delegate void UpdateEnvironmentDelegate();

		// Token: 0x02000AFF RID: 2815
		// (Invoke) Token: 0x06003EF3 RID: 16115
		private delegate void SetEmissive_InjectedDelegate(IntPtr renderer, IntPtr color);
	}
}
