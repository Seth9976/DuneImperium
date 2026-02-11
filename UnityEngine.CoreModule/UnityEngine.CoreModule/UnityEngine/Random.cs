using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200011A RID: 282
	public static class Random : Object
	{
		// Token: 0x060016D2 RID: 5842 RVA: 0x0006D7C8 File Offset: 0x0006B9C8
		// Note: this type is marked as 'beforefieldinit'.
		static Random()
		{
			Il2CppClassPointerStore<Random>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Random");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random>.NativeClassPtr);
			Random.NativeMethodInfoPtr_InitState_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666449);
			Random.NativeMethodInfoPtr_get_state_Public_Static_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666450);
			Random.NativeMethodInfoPtr_set_state_Public_Static_set_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666451);
			Random.NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666452);
			Random.NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666453);
			Random.NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666454);
			Random.NativeMethodInfoPtr_get_value_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666455);
			Random.NativeMethodInfoPtr_get_state_Injected_Private_Static_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666456);
			Random.NativeMethodInfoPtr_set_state_Injected_Private_Static_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666457);
			Random.GetRandomUnitCircleDelegateField = IL2CPP.ResolveICall<Random.GetRandomUnitCircleDelegate>("UnityEngine.Random::GetRandomUnitCircle");
			Random.get_seedDelegateField = IL2CPP.ResolveICall<Random.get_seedDelegate>("UnityEngine.Random::get_seed");
			Random.set_seedDelegateField = IL2CPP.ResolveICall<Random.set_seedDelegate>("UnityEngine.Random::set_seed");
			Random.get_insideUnitSphere_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_insideUnitSphere_InjectedDelegate>("UnityEngine.Random::get_insideUnitSphere_Injected");
			Random.get_onUnitSphere_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_onUnitSphere_InjectedDelegate>("UnityEngine.Random::get_onUnitSphere_Injected");
			Random.get_rotation_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_rotation_InjectedDelegate>("UnityEngine.Random::get_rotation_Injected");
			Random.get_rotationUniform_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_rotationUniform_InjectedDelegate>("UnityEngine.Random::get_rotationUniform_Injected");
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x0006D918 File Offset: 0x0006BB18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 660214, RefRangeEnd = 660220, XrefRangeStart = 660212, XrefRangeEnd = 660214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitState(int seed)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_InitState_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0006D94C File Offset: 0x0006BB4C
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x0006D97C File Offset: 0x0006BB7C
		public unsafe static Random.State state
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 660222, RefRangeEnd = 660226, XrefRangeStart = 660220, XrefRangeEnd = 660222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_state_Public_Static_get_State_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 660228, RefRangeEnd = 660233, XrefRangeStart = 660226, XrefRangeEnd = 660228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_set_state_Public_Static_set_Void_State_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0006D9B0 File Offset: 0x0006BBB0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 660235, RefRangeEnd = 660258, XrefRangeStart = 660233, XrefRangeEnd = 660235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Range(float minInclusive, float maxInclusive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxInclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0006D9FC File Offset: 0x0006BBFC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 660260, RefRangeEnd = 660276, XrefRangeStart = 660258, XrefRangeEnd = 660260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Range(int minInclusive, int maxExclusive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxExclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0006DA48 File Offset: 0x0006BC48
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 660260, RefRangeEnd = 660276, XrefRangeStart = 660260, XrefRangeEnd = 660276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RandomRangeInt(int minInclusive, int maxExclusive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxExclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0006DA94 File Offset: 0x0006BC94
		public unsafe static float value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 660278, RefRangeEnd = 660285, XrefRangeStart = 660276, XrefRangeEnd = 660278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_value_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x0006DAC4 File Offset: 0x0006BCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660285, XrefRangeEnd = 660287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_state_Injected(out Random.State ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_state_Injected_Private_Static_Void_byref_State_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x0006DAF8 File Offset: 0x0006BCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660287, XrefRangeEnd = 660289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_state_Injected(ref Random.State value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_set_state_Injected_Private_Static_Void_byref_State_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00009035 File Offset: 0x00007235
		public Random(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x0006DB2C File Offset: 0x0006BD2C
		public static Vector3 insideUnitSphere
		{
			get
			{
				Vector3 vector;
				Random.get_insideUnitSphere_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0000903E File Offset: 0x0000723E
		public static void GetRandomUnitCircle(out Vector2 output)
		{
			Random.GetRandomUnitCircleDelegateField(out output);
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x0006DB44 File Offset: 0x0006BD44
		public static Vector2 insideUnitCircle
		{
			get
			{
				Vector2 vector;
				Random.GetRandomUnitCircle(out vector);
				return vector;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x0006DB60 File Offset: 0x0006BD60
		public static Vector3 onUnitSphere
		{
			get
			{
				Vector3 vector;
				Random.get_onUnitSphere_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x0006DB78 File Offset: 0x0006BD78
		public static Quaternion rotation
		{
			get
			{
				Quaternion quaternion;
				Random.get_rotation_Injected(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0006DB90 File Offset: 0x0006BD90
		public static Quaternion rotationUniform
		{
			get
			{
				Quaternion quaternion;
				Random.get_rotationUniform_Injected(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x0000904B File Offset: 0x0000724B
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x00009057 File Offset: 0x00007257
		public static int seed
		{
			get
			{
				return Random.get_seedDelegateField();
			}
			set
			{
				Random.set_seedDelegateField(value);
			}
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0006DBA8 File Offset: 0x0006BDA8
		public static float RandomRange(float min, float max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0006DBC4 File Offset: 0x0006BDC4
		public static int RandomRange(int min, int max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x0006DBE0 File Offset: 0x0006BDE0
		public static Color ColorHSV()
		{
			return Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x0006DC20 File Offset: 0x0006BE20
		public static Color ColorHSV(float hueMin, float hueMax)
		{
			return Random.ColorHSV(hueMin, hueMax, 0f, 1f, 0f, 1f, 1f, 1f);
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x0006DC58 File Offset: 0x0006BE58
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax)
		{
			return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, 0f, 1f, 1f, 1f);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x0006DC88 File Offset: 0x0006BE88
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax)
		{
			return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, 1f, 1f);
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x0006DCB4 File Offset: 0x0006BEB4
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax)
		{
			float num = Mathf.Lerp(hueMin, hueMax, Random.value);
			float num2 = Mathf.Lerp(saturationMin, saturationMax, Random.value);
			float num3 = Mathf.Lerp(valueMin, valueMax, Random.value);
			Color color = Color.HSVToRGB(num, num2, num3, true);
			color.a = Mathf.Lerp(alphaMin, alphaMax, Random.value);
			return color;
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00009064 File Offset: 0x00007264
		public static void get_insideUnitSphere_Injected(out Vector3 ret)
		{
			Random.get_insideUnitSphere_InjectedDelegateField(out ret);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00009071 File Offset: 0x00007271
		public static void get_onUnitSphere_Injected(out Vector3 ret)
		{
			Random.get_onUnitSphere_InjectedDelegateField(out ret);
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x0000907E File Offset: 0x0000727E
		public static void get_rotation_Injected(out Quaternion ret)
		{
			Random.get_rotation_InjectedDelegateField(out ret);
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x0000908B File Offset: 0x0000728B
		public static void get_rotationUniform_Injected(out Quaternion ret)
		{
			Random.get_rotationUniform_InjectedDelegateField(out ret);
		}

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr_InitState_Public_Static_Void_Int32_0;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeMethodInfoPtr_get_state_Public_Static_get_State_0;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeMethodInfoPtr_set_state_Public_Static_set_Void_State_0;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Static_get_Single_0;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr_get_state_Injected_Private_Static_Void_byref_State_0;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeMethodInfoPtr_set_state_Injected_Private_Static_Void_byref_State_0;

		// Token: 0x040014E5 RID: 5349
		private static readonly Random.GetRandomUnitCircleDelegate GetRandomUnitCircleDelegateField;

		// Token: 0x040014E6 RID: 5350
		private static readonly Random.get_seedDelegate get_seedDelegateField;

		// Token: 0x040014E7 RID: 5351
		private static readonly Random.set_seedDelegate set_seedDelegateField;

		// Token: 0x040014E8 RID: 5352
		private static readonly Random.get_insideUnitSphere_InjectedDelegate get_insideUnitSphere_InjectedDelegateField;

		// Token: 0x040014E9 RID: 5353
		private static readonly Random.get_onUnitSphere_InjectedDelegate get_onUnitSphere_InjectedDelegateField;

		// Token: 0x040014EA RID: 5354
		private static readonly Random.get_rotation_InjectedDelegate get_rotation_InjectedDelegateField;

		// Token: 0x040014EB RID: 5355
		private static readonly Random.get_rotationUniform_InjectedDelegate get_rotationUniform_InjectedDelegateField;

		// Token: 0x0200070C RID: 1804
		[Serializable]
		[StructLayout(2)]
		public struct State
		{
			// Token: 0x060036EB RID: 14059 RVA: 0x000BA81C File Offset: 0x000B8A1C
			// Note: this type is marked as 'beforefieldinit'.
			static State()
			{
				Il2CppClassPointerStore<Random.State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Random>.NativeClassPtr, "State");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random.State>.NativeClassPtr);
				Random.State.NativeFieldInfoPtr_s0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random.State>.NativeClassPtr, "s0");
				Random.State.NativeFieldInfoPtr_s1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random.State>.NativeClassPtr, "s1");
				Random.State.NativeFieldInfoPtr_s2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random.State>.NativeClassPtr, "s2");
				Random.State.NativeFieldInfoPtr_s3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Random.State>.NativeClassPtr, "s3");
			}

			// Token: 0x060036EC RID: 14060 RVA: 0x00013E02 File Offset: 0x00012002
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Random.State>.NativeClassPtr, ref this));
			}

			// Token: 0x04002C24 RID: 11300
			private static readonly IntPtr NativeFieldInfoPtr_s0;

			// Token: 0x04002C25 RID: 11301
			private static readonly IntPtr NativeFieldInfoPtr_s1;

			// Token: 0x04002C26 RID: 11302
			private static readonly IntPtr NativeFieldInfoPtr_s2;

			// Token: 0x04002C27 RID: 11303
			private static readonly IntPtr NativeFieldInfoPtr_s3;

			// Token: 0x04002C28 RID: 11304
			[FieldOffset(0)]
			public int s0;

			// Token: 0x04002C29 RID: 11305
			[FieldOffset(4)]
			public int s1;

			// Token: 0x04002C2A RID: 11306
			[FieldOffset(8)]
			public int s2;

			// Token: 0x04002C2B RID: 11307
			[FieldOffset(12)]
			public int s3;
		}

		// Token: 0x0200070D RID: 1805
		// (Invoke) Token: 0x060036EE RID: 14062
		private delegate void GetRandomUnitCircleDelegate([Out] IntPtr output);

		// Token: 0x0200070E RID: 1806
		// (Invoke) Token: 0x060036F0 RID: 14064
		private delegate int get_seedDelegate();

		// Token: 0x0200070F RID: 1807
		// (Invoke) Token: 0x060036F2 RID: 14066
		private delegate void set_seedDelegate(int value);

		// Token: 0x02000710 RID: 1808
		// (Invoke) Token: 0x060036F4 RID: 14068
		private delegate void get_insideUnitSphere_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000711 RID: 1809
		// (Invoke) Token: 0x060036F6 RID: 14070
		private delegate void get_onUnitSphere_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000712 RID: 1810
		// (Invoke) Token: 0x060036F8 RID: 14072
		private delegate void get_rotation_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000713 RID: 1811
		// (Invoke) Token: 0x060036FA RID: 14074
		private delegate void get_rotationUniform_InjectedDelegate([Out] IntPtr ret);
	}
}
