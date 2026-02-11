using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities.ai
{
	// Token: 0x02000101 RID: 257
	public static class AIProfileAbsUtils : Object
	{
		// Token: 0x06000B80 RID: 2944 RVA: 0x0004A608 File Offset: 0x00048808
		// Note: this type is marked as 'beforefieldinit'.
		static AIProfileAbsUtils()
		{
			Il2CppClassPointerStore<AIProfileAbsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIProfileAbsUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIProfileAbsUtils>.NativeClassPtr);
			AIProfileAbsUtils.NativeMethodInfoPtr_ThenByIntervalScoreCurried_Public_Static_ValueTuple_3_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbsUtils>.NativeClassPtr, 100665780);
			AIProfileAbsUtils.NativeMethodInfoPtr_ThenByIntervalScore_Public_Static_ValueTuple_3_Int32_Int32_Int32_ValueTuple_3_Int32_Int32_Int32_ValueTuple_3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbsUtils>.NativeClassPtr, 100665781);
			AIProfileAbsUtils.NativeMethodInfoPtr_Multiply_Public_Static_Void_AIValueSummer_1_Double_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbsUtils>.NativeClassPtr, 100665782);
			AIProfileAbsUtils.NativeMethodInfoPtr_get_DoubleValueSummer_Public_Static_get_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbsUtils>.NativeClassPtr, 100665783);
			AIProfileAbsUtils.NativeMethodInfoPtr_get_IntValueSummer_Public_Static_get_AIValueSummer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbsUtils>.NativeClassPtr, 100665784);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0004A69C File Offset: 0x0004889C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 569897, XrefRangeEnd = 569900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<int, int, int> ThenByIntervalScoreCurried(int mainScore, int mainScoreMin, int mainScoreMax, int subScore, int subScoreMin, int subScoreMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mainScore;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainScoreMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainScoreMax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subScore;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subScoreMin;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subScoreMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbsUtils.NativeMethodInfoPtr_ThenByIntervalScoreCurried_Public_Static_ValueTuple_3_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, int, int>(intPtr);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0004A71C File Offset: 0x0004891C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 569900, XrefRangeEnd = 569903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<int, int, int> ThenByIntervalScore(this ValueTuple<int, int, int> main, ValueTuple<int, int, int> sub)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(main));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sub));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbsUtils.NativeMethodInfoPtr_ThenByIntervalScore_Public_Static_ValueTuple_3_Int32_Int32_Int32_ValueTuple_3_Int32_Int32_Int32_ValueTuple_3_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, int, int>(intPtr);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0004A774 File Offset: 0x00048974
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 569916, RefRangeEnd = 569961, XrefRangeStart = 569903, XrefRangeEnd = 569916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Multiply(this AIValueSummer<double> summer, double mod, string reason = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(summer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mod;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbsUtils.NativeMethodInfoPtr_Multiply_Public_Static_Void_AIValueSummer_1_Double_Double_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0004A7CC File Offset: 0x000489CC
		public unsafe static AIValueSummer<double> DoubleValueSummer
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 569982, RefRangeEnd = 569995, XrefRangeStart = 569961, XrefRangeEnd = 569982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbsUtils.NativeMethodInfoPtr_get_DoubleValueSummer_Public_Static_get_AIValueSummer_1_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x0004A800 File Offset: 0x00048A00
		public unsafe static AIValueSummer<int> IntValueSummer
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 570016, RefRangeEnd = 570024, XrefRangeStart = 569995, XrefRangeEnd = 570016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbsUtils.NativeMethodInfoPtr_get_IntValueSummer_Public_Static_get_AIValueSummer_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00006318 File Offset: 0x00004518
		public AIProfileAbsUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_ThenByIntervalScoreCurried_Public_Static_ValueTuple_3_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_ThenByIntervalScore_Public_Static_ValueTuple_3_Int32_Int32_Int32_ValueTuple_3_Int32_Int32_Int32_ValueTuple_3_Int32_Int32_Int32_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Void_AIValueSummer_1_Double_Double_String_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_get_DoubleValueSummer_Public_Static_get_AIValueSummer_1_Double_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_get_IntValueSummer_Public_Static_get_AIValueSummer_1_Int32_0;

		// Token: 0x02000346 RID: 838
		[ObfuscatedName("Canis.entities.ai.AIProfileAbsUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002315 RID: 8981 RVA: 0x0009D2B4 File Offset: 0x0009B4B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AIProfileAbsUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIProfileAbsUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIProfileAbsUtils.__c>.NativeClassPtr);
				AIProfileAbsUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIProfileAbsUtils.__c>.NativeClassPtr, "<>9");
				AIProfileAbsUtils.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIProfileAbsUtils.__c>.NativeClassPtr, "<>9__4_0");
				AIProfileAbsUtils.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIProfileAbsUtils.__c>.NativeClassPtr, "<>9__6_0");
				AIProfileAbsUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbsUtils.__c>.NativeClassPtr, 100665786);
				AIProfileAbsUtils.__c.NativeMethodInfoPtr__get_DoubleValueSummer_b__4_0_Internal_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbsUtils.__c>.NativeClassPtr, 100665787);
				AIProfileAbsUtils.__c.NativeMethodInfoPtr__get_IntValueSummer_b__6_0_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIProfileAbsUtils.__c>.NativeClassPtr, 100665788);
			}

			// Token: 0x06002316 RID: 8982 RVA: 0x0009D358 File Offset: 0x0009B558
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIProfileAbsUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbsUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002317 RID: 8983 RVA: 0x0009D394 File Offset: 0x0009B594
			[CallerCount(0)]
			public unsafe double _get_DoubleValueSummer_b__4_0(double a, double b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbsUtils.__c.NativeMethodInfoPtr__get_DoubleValueSummer_b__4_0_Internal_Double_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002318 RID: 8984 RVA: 0x0009D3EC File Offset: 0x0009B5EC
			[CallerCount(0)]
			public unsafe int _get_IntValueSummer_b__6_0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIProfileAbsUtils.__c.NativeMethodInfoPtr__get_IntValueSummer_b__6_0_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002319 RID: 8985 RVA: 0x00010D93 File Offset: 0x0000EF93
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x0600231A RID: 8986 RVA: 0x0009D444 File Offset: 0x0009B644
			// (set) Token: 0x0600231B RID: 8987 RVA: 0x00010D9C File Offset: 0x0000EF9C
			public unsafe static AIProfileAbsUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIProfileAbsUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AIProfileAbsUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIProfileAbsUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000893 RID: 2195
			// (get) Token: 0x0600231C RID: 8988 RVA: 0x0009D46C File Offset: 0x0009B66C
			// (set) Token: 0x0600231D RID: 8989 RVA: 0x00010DAE File Offset: 0x0000EFAE
			public unsafe static Func<double, double, double> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIProfileAbsUtils.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<double, double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIProfileAbsUtils.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000894 RID: 2196
			// (get) Token: 0x0600231E RID: 8990 RVA: 0x0009D494 File Offset: 0x0009B694
			// (set) Token: 0x0600231F RID: 8991 RVA: 0x00010DC0 File Offset: 0x0000EFC0
			public unsafe static Func<int, int, int> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AIProfileAbsUtils.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AIProfileAbsUtils.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400160A RID: 5642
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400160B RID: 5643
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400160C RID: 5644
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400160D RID: 5645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400160E RID: 5646
			private static readonly IntPtr NativeMethodInfoPtr__get_DoubleValueSummer_b__4_0_Internal_Double_Double_Double_0;

			// Token: 0x0400160F RID: 5647
			private static readonly IntPtr NativeMethodInfoPtr__get_IntValueSummer_b__6_0_Internal_Int32_Int32_Int32_0;
		}
	}
}
