using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000099 RID: 153
	public sealed class LightProbes : Object
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x00034A6C File Offset: 0x00032C6C
		// Note: this type is marked as 'beforefieldinit'.
		static LightProbes()
		{
			Il2CppClassPointerStore<LightProbes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightProbes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbes>.NativeClassPtr);
			LightProbes.NativeFieldInfoPtr_lightProbesUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, "lightProbesUpdated");
			LightProbes.NativeFieldInfoPtr_tetrahedralizationCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, "tetrahedralizationCompleted");
			LightProbes.NativeFieldInfoPtr_needsRetetrahedralization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, "needsRetetrahedralization");
			LightProbes.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664371);
			LightProbes.NativeMethodInfoPtr_Internal_CallLightProbesUpdatedFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664372);
			LightProbes.NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664373);
			LightProbes.NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100664374);
			LightProbes.TetrahedralizeDelegateField = IL2CPP.ResolveICall<LightProbes.TetrahedralizeDelegate>("UnityEngine.LightProbes::Tetrahedralize");
			LightProbes.TetrahedralizeAsyncDelegateField = IL2CPP.ResolveICall<LightProbes.TetrahedralizeAsyncDelegate>("UnityEngine.LightProbes::TetrahedralizeAsync");
			LightProbes.AreLightProbesAllowedDelegateField = IL2CPP.ResolveICall<LightProbes.AreLightProbesAllowedDelegate>("UnityEngine.LightProbes::AreLightProbesAllowed");
			LightProbes.CalculateInterpolatedLightAndOcclusionProbes_InternalDelegateField = IL2CPP.ResolveICall<LightProbes.CalculateInterpolatedLightAndOcclusionProbes_InternalDelegate>("UnityEngine.LightProbes::CalculateInterpolatedLightAndOcclusionProbes_Internal");
			LightProbes.get_positionsDelegateField = IL2CPP.ResolveICall<LightProbes.get_positionsDelegate>("UnityEngine.LightProbes::get_positions");
			LightProbes.get_bakedProbesDelegateField = IL2CPP.ResolveICall<LightProbes.get_bakedProbesDelegate>("UnityEngine.LightProbes::get_bakedProbes");
			LightProbes.set_bakedProbesDelegateField = IL2CPP.ResolveICall<LightProbes.set_bakedProbesDelegate>("UnityEngine.LightProbes::set_bakedProbes");
			LightProbes.get_countDelegateField = IL2CPP.ResolveICall<LightProbes.get_countDelegate>("UnityEngine.LightProbes::get_count");
			LightProbes.get_cellCountDelegateField = IL2CPP.ResolveICall<LightProbes.get_cellCountDelegate>("UnityEngine.LightProbes::get_cellCount");
			LightProbes.GetCountDelegateField = IL2CPP.ResolveICall<LightProbes.GetCountDelegate>("UnityEngine.LightProbes::GetCount");
			LightProbes.GetInterpolatedProbe_InjectedDelegateField = IL2CPP.ResolveICall<LightProbes.GetInterpolatedProbe_InjectedDelegate>("UnityEngine.LightProbes::GetInterpolatedProbe_Injected");
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00034BD0 File Offset: 0x00032DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649994, XrefRangeEnd = 649998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightProbes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightProbes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00034C0C File Offset: 0x00032E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649998, XrefRangeEnd = 650000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CallLightProbesUpdatedFunction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_Internal_CallLightProbesUpdatedFunction_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00034C34 File Offset: 0x00032E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650000, XrefRangeEnd = 650002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CallTetrahedralizationCompletedFunction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00034C5C File Offset: 0x00032E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650002, XrefRangeEnd = 650004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CallNeedsRetetrahedralizationFunction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00005936 File Offset: 0x00003B36
		public LightProbes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x00034C84 File Offset: 0x00032E84
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x0000593F File Offset: 0x00003B3F
		public unsafe static Action lightProbesUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LightProbes.NativeFieldInfoPtr_lightProbesUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightProbes.NativeFieldInfoPtr_lightProbesUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x00034CAC File Offset: 0x00032EAC
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x00005951 File Offset: 0x00003B51
		public unsafe static Action tetrahedralizationCompleted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LightProbes.NativeFieldInfoPtr_tetrahedralizationCompleted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightProbes.NativeFieldInfoPtr_tetrahedralizationCompleted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x00034CD4 File Offset: 0x00032ED4
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x00005963 File Offset: 0x00003B63
		public unsafe static Action needsRetetrahedralization
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LightProbes.NativeFieldInfoPtr_needsRetetrahedralization, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightProbes.NativeFieldInfoPtr_needsRetetrahedralization, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00005975 File Offset: 0x00003B75
		public static void add_lightProbesUpdated(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00005982 File Offset: 0x00003B82
		public static void remove_lightProbesUpdated(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0000598F File Offset: 0x00003B8F
		public static void add_tetrahedralizationCompleted(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0000599C File Offset: 0x00003B9C
		public static void remove_tetrahedralizationCompleted(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000059A9 File Offset: 0x00003BA9
		public static void add_needsRetetrahedralization(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000059B6 File Offset: 0x00003BB6
		public static void remove_needsRetetrahedralization(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x000059C3 File Offset: 0x00003BC3
		public static void Tetrahedralize()
		{
			LightProbes.TetrahedralizeDelegateField();
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x000059CF File Offset: 0x00003BCF
		public static void TetrahedralizeAsync()
		{
			LightProbes.TetrahedralizeAsyncDelegateField();
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000059DB File Offset: 0x00003BDB
		public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, out UnityEngine.Rendering.SphericalHarmonicsL2 probe)
		{
			LightProbes.GetInterpolatedProbe_Injected(ref position, renderer, out probe);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000059E6 File Offset: 0x00003BE6
		public static bool AreLightProbesAllowed(Renderer renderer)
		{
			return LightProbes.AreLightProbesAllowedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00034CFC File Offset: 0x00032EFC
		public static void CalculateInterpolatedLightAndOcclusionProbes(Il2CppStructArray<Vector3> positions, Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, Il2CppStructArray<Vector4> occlusionProbes)
		{
			bool flag = positions == null;
			if (flag)
			{
				throw new ArgumentNullException("positions");
			}
			bool flag2 = lightProbes == null && occlusionProbes == null;
			if (flag2)
			{
				throw new ArgumentException("Argument lightProbes and occlusionProbes cannot both be null.");
			}
			bool flag3 = lightProbes != null && lightProbes.Length < positions.Length;
			if (flag3)
			{
				throw new ArgumentException("lightProbes", "Argument lightProbes has less elements than positions");
			}
			bool flag4 = occlusionProbes != null && occlusionProbes.Length < positions.Length;
			if (flag4)
			{
				throw new ArgumentException("occlusionProbes", "Argument occlusionProbes has less elements than positions");
			}
			LightProbes.CalculateInterpolatedLightAndOcclusionProbes_Internal(positions, positions.Length, lightProbes, occlusionProbes);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00034D9C File Offset: 0x00032F9C
		public static void CalculateInterpolatedLightAndOcclusionProbes(List<Vector3> positions, List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, List<Vector4> occlusionProbes)
		{
			bool flag = positions == null;
			if (flag)
			{
				throw new ArgumentNullException("positions");
			}
			bool flag2 = lightProbes == null && occlusionProbes == null;
			if (flag2)
			{
				throw new ArgumentException("Argument lightProbes and occlusionProbes cannot both be null.");
			}
			bool flag3 = lightProbes != null;
			if (flag3)
			{
				bool flag4 = lightProbes.Capacity < positions.Count;
				if (flag4)
				{
					lightProbes.Capacity = positions.Count;
				}
				bool flag5 = lightProbes.Count < positions.Count;
				if (flag5)
				{
					NoAllocHelpers.ResizeList<UnityEngine.Rendering.SphericalHarmonicsL2>(lightProbes, positions.Count);
				}
			}
			bool flag6 = occlusionProbes != null;
			if (flag6)
			{
				bool flag7 = occlusionProbes.Capacity < positions.Count;
				if (flag7)
				{
					occlusionProbes.Capacity = positions.Count;
				}
				bool flag8 = occlusionProbes.Count < positions.Count;
				if (flag8)
				{
					NoAllocHelpers.ResizeList<Vector4>(occlusionProbes, positions.Count);
				}
			}
			LightProbes.CalculateInterpolatedLightAndOcclusionProbes_Internal(NoAllocHelpers.ExtractArrayFromListT<Vector3>(positions), positions.Count, NoAllocHelpers.ExtractArrayFromListT<UnityEngine.Rendering.SphericalHarmonicsL2>(lightProbes), NoAllocHelpers.ExtractArrayFromListT<Vector4>(occlusionProbes));
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000059F8 File Offset: 0x00003BF8
		public static void CalculateInterpolatedLightAndOcclusionProbes_Internal(Il2CppStructArray<Vector3> positions, int positionsCount, Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, Il2CppStructArray<Vector4> occlusionProbes)
		{
			LightProbes.CalculateInterpolatedLightAndOcclusionProbes_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(positions), positionsCount, IL2CPP.Il2CppObjectBaseToPtr(lightProbes), IL2CPP.Il2CppObjectBaseToPtr(occlusionProbes));
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00034E8C File Offset: 0x0003308C
		public Il2CppStructArray<Vector3> positions
		{
			get
			{
				IntPtr intPtr = LightProbes.get_positionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00034EB8 File Offset: 0x000330B8
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x00005A17 File Offset: 0x00003C17
		public Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2> bakedProbes
		{
			get
			{
				IntPtr intPtr = LightProbes.get_bakedProbesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2>>(intPtr2) : null;
			}
			set
			{
				LightProbes.set_bakedProbesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x00005A2F File Offset: 0x00003C2F
		public int count
		{
			get
			{
				return LightProbes.get_countDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00005A41 File Offset: 0x00003C41
		public int cellCount
		{
			get
			{
				return LightProbes.get_cellCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00005A53 File Offset: 0x00003C53
		public static int GetCount()
		{
			return LightProbes.GetCountDelegateField();
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00005A5F File Offset: 0x00003C5F
		public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, Il2CppStructArray<float> coefficients)
		{
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x00005A62 File Offset: 0x00003C62
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x00005A6F File Offset: 0x00003C6F
		public Il2CppStructArray<float> coefficients
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
			}
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00005A72 File Offset: 0x00003C72
		public static void GetInterpolatedProbe_Injected(ref Vector3 position, Renderer renderer, out UnityEngine.Rendering.SphericalHarmonicsL2 probe)
		{
			LightProbes.GetInterpolatedProbe_InjectedDelegateField(ref position, IL2CPP.Il2CppObjectBaseToPtr(renderer), out probe);
		}

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeFieldInfoPtr_lightProbesUpdated;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeFieldInfoPtr_tetrahedralizationCompleted;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeFieldInfoPtr_needsRetetrahedralization;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CallLightProbesUpdatedFunction_Private_Static_Void_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0;

		// Token: 0x04000763 RID: 1891
		private static readonly LightProbes.TetrahedralizeDelegate TetrahedralizeDelegateField;

		// Token: 0x04000764 RID: 1892
		private static readonly LightProbes.TetrahedralizeAsyncDelegate TetrahedralizeAsyncDelegateField;

		// Token: 0x04000765 RID: 1893
		private static readonly LightProbes.AreLightProbesAllowedDelegate AreLightProbesAllowedDelegateField;

		// Token: 0x04000766 RID: 1894
		private static readonly LightProbes.CalculateInterpolatedLightAndOcclusionProbes_InternalDelegate CalculateInterpolatedLightAndOcclusionProbes_InternalDelegateField;

		// Token: 0x04000767 RID: 1895
		private static readonly LightProbes.get_positionsDelegate get_positionsDelegateField;

		// Token: 0x04000768 RID: 1896
		private static readonly LightProbes.get_bakedProbesDelegate get_bakedProbesDelegateField;

		// Token: 0x04000769 RID: 1897
		private static readonly LightProbes.set_bakedProbesDelegate set_bakedProbesDelegateField;

		// Token: 0x0400076A RID: 1898
		private static readonly LightProbes.get_countDelegate get_countDelegateField;

		// Token: 0x0400076B RID: 1899
		private static readonly LightProbes.get_cellCountDelegate get_cellCountDelegateField;

		// Token: 0x0400076C RID: 1900
		private static readonly LightProbes.GetCountDelegate GetCountDelegateField;

		// Token: 0x0400076D RID: 1901
		private static readonly LightProbes.GetInterpolatedProbe_InjectedDelegate GetInterpolatedProbe_InjectedDelegateField;

		// Token: 0x02000511 RID: 1297
		// (Invoke) Token: 0x06003333 RID: 13107
		private delegate void TetrahedralizeDelegate();

		// Token: 0x02000512 RID: 1298
		// (Invoke) Token: 0x06003335 RID: 13109
		private delegate void TetrahedralizeAsyncDelegate();

		// Token: 0x02000513 RID: 1299
		// (Invoke) Token: 0x06003337 RID: 13111
		private delegate bool AreLightProbesAllowedDelegate(IntPtr renderer);

		// Token: 0x02000514 RID: 1300
		// (Invoke) Token: 0x06003339 RID: 13113
		private delegate void CalculateInterpolatedLightAndOcclusionProbes_InternalDelegate(IntPtr positions, int positionsCount, IntPtr lightProbes, IntPtr occlusionProbes);

		// Token: 0x02000515 RID: 1301
		// (Invoke) Token: 0x0600333B RID: 13115
		private delegate IntPtr get_positionsDelegate(IntPtr @this);

		// Token: 0x02000516 RID: 1302
		// (Invoke) Token: 0x0600333D RID: 13117
		private delegate IntPtr get_bakedProbesDelegate(IntPtr @this);

		// Token: 0x02000517 RID: 1303
		// (Invoke) Token: 0x0600333F RID: 13119
		private delegate void set_bakedProbesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000518 RID: 1304
		// (Invoke) Token: 0x06003341 RID: 13121
		private delegate int get_countDelegate(IntPtr @this);

		// Token: 0x02000519 RID: 1305
		// (Invoke) Token: 0x06003343 RID: 13123
		private delegate int get_cellCountDelegate(IntPtr @this);

		// Token: 0x0200051A RID: 1306
		// (Invoke) Token: 0x06003345 RID: 13125
		private delegate int GetCountDelegate();

		// Token: 0x0200051B RID: 1307
		// (Invoke) Token: 0x06003347 RID: 13127
		private delegate void GetInterpolatedProbe_InjectedDelegate(IntPtr position, IntPtr renderer, [Out] IntPtr probe);
	}
}
