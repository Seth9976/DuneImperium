using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities.ai
{
	// Token: 0x02000112 RID: 274
	public class CustomWeightedRoller<T> : Object
	{
		// Token: 0x06000C71 RID: 3185 RVA: 0x0004F0E8 File Offset: 0x0004D2E8
		// Note: this type is marked as 'beforefieldinit'.
		static CustomWeightedRoller()
		{
			Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "CustomWeightedRoller`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr);
			CustomWeightedRoller<T>.NativeFieldInfoPtr_customRoller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr, "customRoller");
			CustomWeightedRoller<T>.NativeFieldInfoPtr_Distribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr, "Distribution");
			CustomWeightedRoller<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_3_WeightedDistribution_1_T_Random_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr, 100666080);
			CustomWeightedRoller<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr, 100666081);
			CustomWeightedRoller<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr, 100666082);
			CustomWeightedRoller<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr, 100666083);
			CustomWeightedRoller<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr, 100666084);
			CustomWeightedRoller<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr, 100666085);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0004F1F4 File Offset: 0x0004D3F4
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomWeightedRoller(Func<WeightedDistribution<T>, Random, IEnumerable<T>> customRoller)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customRoller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_3_WeightedDistribution_1_T_Random_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0004F240 File Offset: 0x0004D440
		[CallerCount(0)]
		public unsafe virtual IEnumerable<T> Roll(Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(random);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0004F290 File Offset: 0x0004D490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573367, XrefRangeEnd = 573372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<T> All()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0004F2D0 File Offset: 0x0004D4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573372, XrefRangeEnd = 573376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IRolls<T> Filtered(Func<T, bool> predicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0004F320 File Offset: 0x0004D520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573376, XrefRangeEnd = 573385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IRolls<T> Scaled(Func<T, double> scaling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaling);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0004F370 File Offset: 0x0004D570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573385, XrefRangeEnd = 573394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IRolls<T> Rekeyed(Func<T, T> rekeyer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rekeyer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0000660E File Offset: 0x0000480E
		public CustomWeightedRoller(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x0004F3C0 File Offset: 0x0004D5C0
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x00006617 File Offset: 0x00004817
		public unsafe Func<WeightedDistribution<T>, Random, IEnumerable<T>> customRoller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>.NativeFieldInfoPtr_customRoller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WeightedDistribution<T>, Random, IEnumerable<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>.NativeFieldInfoPtr_customRoller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0004F3F0 File Offset: 0x0004D5F0
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x00006636 File Offset: 0x00004836
		public unsafe WeightedDistribution<T> Distribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>.NativeFieldInfoPtr_Distribution);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeightedDistribution<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>.NativeFieldInfoPtr_Distribution), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeFieldInfoPtr_customRoller;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeFieldInfoPtr_Distribution;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_3_WeightedDistribution_1_T_Random_IEnumerable_1_T_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0;

		// Token: 0x02000363 RID: 867
		[ObfuscatedName("Canis.entities.ai.CustomWeightedRoller`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060024A8 RID: 9384 RVA: 0x000A2DCC File Offset: 0x000A0FCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr);
				CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr, "<>9");
				CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr, "<>9__6_2");
				CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__6_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr, "<>9__6_3");
				CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__6_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr, "<>9__6_4");
				CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr, "<>9__7_2");
				CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__7_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr, "<>9__7_3");
				CustomWeightedRoller<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr, 100666087);
				CustomWeightedRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__6_2_Internal_Boolean_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr, 100666088);
				CustomWeightedRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__6_3_Internal_T_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr, 100666089);
				CustomWeightedRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__6_4_Internal_Int32_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr, 100666090);
				CustomWeightedRoller<T>.__c.NativeMethodInfoPtr__Rekeyed_b__7_2_Internal_T_ValueTuple_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr, 100666091);
				CustomWeightedRoller<T>.__c.NativeMethodInfoPtr__Rekeyed_b__7_3_Internal_Int32_ValueTuple_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr, 100666092);
			}

			// Token: 0x060024A9 RID: 9385 RVA: 0x000A2F24 File Offset: 0x000A1124
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024AA RID: 9386 RVA: 0x000A2F60 File Offset: 0x000A1160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Scaled_b__6_2(ValueTuple<T, double> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__6_2_Internal_Boolean_ValueTuple_2_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060024AB RID: 9387 RVA: 0x000A2FB4 File Offset: 0x000A11B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _Scaled_b__6_3(ValueTuple<T, double> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__6_3_Internal_T_ValueTuple_2_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060024AC RID: 9388 RVA: 0x000A3004 File Offset: 0x000A1204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573296, XrefRangeEnd = 573307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Scaled_b__6_4(ValueTuple<T, double> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__6_4_Internal_Int32_ValueTuple_2_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060024AD RID: 9389 RVA: 0x000A3058 File Offset: 0x000A1258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _Rekeyed_b__7_2(ValueTuple<T, int> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.__c.NativeMethodInfoPtr__Rekeyed_b__7_2_Internal_T_ValueTuple_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060024AE RID: 9390 RVA: 0x000A30A8 File Offset: 0x000A12A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573307, XrefRangeEnd = 573310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Rekeyed_b__7_3(ValueTuple<T, int> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.__c.NativeMethodInfoPtr__Rekeyed_b__7_3_Internal_Int32_ValueTuple_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060024AF RID: 9391 RVA: 0x00011976 File Offset: 0x0000FB76
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x060024B0 RID: 9392 RVA: 0x000A30FC File Offset: 0x000A12FC
			// (set) Token: 0x060024B1 RID: 9393 RVA: 0x0001197F File Offset: 0x0000FB7F
			public unsafe static CustomWeightedRoller<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomWeightedRoller<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x060024B2 RID: 9394 RVA: 0x000A3124 File Offset: 0x000A1324
			// (set) Token: 0x060024B3 RID: 9395 RVA: 0x00011991 File Offset: 0x0000FB91
			public unsafe static Func<ValueTuple<T, double>, bool> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, double>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x060024B4 RID: 9396 RVA: 0x000A314C File Offset: 0x000A134C
			// (set) Token: 0x060024B5 RID: 9397 RVA: 0x000119A3 File Offset: 0x0000FBA3
			public unsafe static Func<ValueTuple<T, double>, T> __9__6_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__6_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, double>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__6_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090A RID: 2314
			// (get) Token: 0x060024B6 RID: 9398 RVA: 0x000A3174 File Offset: 0x000A1374
			// (set) Token: 0x060024B7 RID: 9399 RVA: 0x000119B5 File Offset: 0x0000FBB5
			public unsafe static Func<ValueTuple<T, double>, int> __9__6_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__6_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, double>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__6_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090B RID: 2315
			// (get) Token: 0x060024B8 RID: 9400 RVA: 0x000A319C File Offset: 0x000A139C
			// (set) Token: 0x060024B9 RID: 9401 RVA: 0x000119C7 File Offset: 0x0000FBC7
			public unsafe static Func<ValueTuple<T, int>, T> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, int>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090C RID: 2316
			// (get) Token: 0x060024BA RID: 9402 RVA: 0x000A31C4 File Offset: 0x000A13C4
			// (set) Token: 0x060024BB RID: 9403 RVA: 0x000119D9 File Offset: 0x0000FBD9
			public unsafe static Func<ValueTuple<T, int>, int> __9__7_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__7_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomWeightedRoller<T>.__c.NativeFieldInfoPtr___9__7_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016F5 RID: 5877
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016F6 RID: 5878
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x040016F7 RID: 5879
			private static readonly IntPtr NativeFieldInfoPtr___9__6_3;

			// Token: 0x040016F8 RID: 5880
			private static readonly IntPtr NativeFieldInfoPtr___9__6_4;

			// Token: 0x040016F9 RID: 5881
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x040016FA RID: 5882
			private static readonly IntPtr NativeFieldInfoPtr___9__7_3;

			// Token: 0x040016FB RID: 5883
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016FC RID: 5884
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__6_2_Internal_Boolean_ValueTuple_2_T_Double_0;

			// Token: 0x040016FD RID: 5885
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__6_3_Internal_T_ValueTuple_2_T_Double_0;

			// Token: 0x040016FE RID: 5886
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__6_4_Internal_Int32_ValueTuple_2_T_Double_0;

			// Token: 0x040016FF RID: 5887
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__7_2_Internal_T_ValueTuple_2_T_Int32_0;

			// Token: 0x04001700 RID: 5888
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__7_3_Internal_Int32_ValueTuple_2_T_Int32_0;
		}

		// Token: 0x02000364 RID: 868
		[ObfuscatedName("Canis.entities.ai.CustomWeightedRoller`1+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x060024BC RID: 9404 RVA: 0x000A31EC File Offset: 0x000A13EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr, "<>c__DisplayClass6_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass6_0>.NativeClassPtr);
				CustomWeightedRoller<T>.__c__DisplayClass6_0.NativeFieldInfoPtr_scaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass6_0>.NativeClassPtr, "scaling");
				CustomWeightedRoller<T>.__c__DisplayClass6_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass6_0>.NativeClassPtr, "<>9__1");
				CustomWeightedRoller<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass6_0>.NativeClassPtr, 100666093);
				CustomWeightedRoller<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__Scaled_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass6_0>.NativeClassPtr, 100666094);
				CustomWeightedRoller<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__Scaled_b__1_Internal_ValueTuple_2_T_Double_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass6_0>.NativeClassPtr, 100666095);
			}

			// Token: 0x060024BD RID: 9405 RVA: 0x000A32B8 File Offset: 0x000A14B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024BE RID: 9406 RVA: 0x000A32F4 File Offset: 0x000A14F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<T, int> _Scaled_b__0(Dictionary<T, int> dict)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__Scaled_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T, int>>(intPtr3) : null;
				}
			}

			// Token: 0x060024BF RID: 9407 RVA: 0x000A3344 File Offset: 0x000A1544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<T, double> _Scaled_b__1(KeyValuePair<T, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__Scaled_b__1_Internal_ValueTuple_2_T_Double_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<T, double>(intPtr);
				}
			}

			// Token: 0x060024C0 RID: 9408 RVA: 0x000119EB File Offset: 0x0000FBEB
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700090D RID: 2317
			// (get) Token: 0x060024C1 RID: 9409 RVA: 0x000A3394 File Offset: 0x000A1594
			// (set) Token: 0x060024C2 RID: 9410 RVA: 0x000119F4 File Offset: 0x0000FBF4
			public unsafe Func<T, double> scaling
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>.__c__DisplayClass6_0.NativeFieldInfoPtr_scaling);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, double>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>.__c__DisplayClass6_0.NativeFieldInfoPtr_scaling), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090E RID: 2318
			// (get) Token: 0x060024C3 RID: 9411 RVA: 0x000A33C4 File Offset: 0x000A15C4
			// (set) Token: 0x060024C4 RID: 9412 RVA: 0x00011A13 File Offset: 0x0000FC13
			public unsafe Func<KeyValuePair<T, int>, ValueTuple<T, double>> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>.__c__DisplayClass6_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<T, int>, ValueTuple<T, double>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>.__c__DisplayClass6_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001701 RID: 5889
			private static readonly IntPtr NativeFieldInfoPtr_scaling;

			// Token: 0x04001702 RID: 5890
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04001703 RID: 5891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001704 RID: 5892
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0;

			// Token: 0x04001705 RID: 5893
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__1_Internal_ValueTuple_2_T_Double_KeyValuePair_2_T_Int32_0;
		}

		// Token: 0x02000365 RID: 869
		[ObfuscatedName("Canis.entities.ai.CustomWeightedRoller`1+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x060024C5 RID: 9413 RVA: 0x000A33F4 File Offset: 0x000A15F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr, "<>c__DisplayClass7_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass7_0>.NativeClassPtr);
				CustomWeightedRoller<T>.__c__DisplayClass7_0.NativeFieldInfoPtr_rekeyer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass7_0>.NativeClassPtr, "rekeyer");
				CustomWeightedRoller<T>.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass7_0>.NativeClassPtr, "<>9__1");
				CustomWeightedRoller<T>.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass7_0>.NativeClassPtr, 100666096);
				CustomWeightedRoller<T>.__c__DisplayClass7_0.NativeMethodInfoPtr__Rekeyed_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass7_0>.NativeClassPtr, 100666097);
				CustomWeightedRoller<T>.__c__DisplayClass7_0.NativeMethodInfoPtr__Rekeyed_b__1_Internal_ValueTuple_2_T_Int32_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass7_0>.NativeClassPtr, 100666098);
			}

			// Token: 0x060024C6 RID: 9414 RVA: 0x000A34C0 File Offset: 0x000A16C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWeightedRoller<T>.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024C7 RID: 9415 RVA: 0x000A34FC File Offset: 0x000A16FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<T, int> _Rekeyed_b__0(Dictionary<T, int> dict)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.__c__DisplayClass7_0.NativeMethodInfoPtr__Rekeyed_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T, int>>(intPtr3) : null;
				}
			}

			// Token: 0x060024C8 RID: 9416 RVA: 0x000A354C File Offset: 0x000A174C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<T, int> _Rekeyed_b__1(KeyValuePair<T, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>.__c__DisplayClass7_0.NativeMethodInfoPtr__Rekeyed_b__1_Internal_ValueTuple_2_T_Int32_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<T, int>(intPtr);
				}
			}

			// Token: 0x060024C9 RID: 9417 RVA: 0x00011A32 File Offset: 0x0000FC32
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700090F RID: 2319
			// (get) Token: 0x060024CA RID: 9418 RVA: 0x000A359C File Offset: 0x000A179C
			// (set) Token: 0x060024CB RID: 9419 RVA: 0x00011A3B File Offset: 0x0000FC3B
			public unsafe Func<T, T> rekeyer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>.__c__DisplayClass7_0.NativeFieldInfoPtr_rekeyer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>.__c__DisplayClass7_0.NativeFieldInfoPtr_rekeyer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000910 RID: 2320
			// (get) Token: 0x060024CC RID: 9420 RVA: 0x000A35CC File Offset: 0x000A17CC
			// (set) Token: 0x060024CD RID: 9421 RVA: 0x00011A5A File Offset: 0x0000FC5A
			public unsafe Func<KeyValuePair<T, int>, ValueTuple<T, int>> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<T, int>, ValueTuple<T, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001706 RID: 5894
			private static readonly IntPtr NativeFieldInfoPtr_rekeyer;

			// Token: 0x04001707 RID: 5895
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04001708 RID: 5896
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001709 RID: 5897
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0;

			// Token: 0x0400170A RID: 5898
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__1_Internal_ValueTuple_2_T_Int32_KeyValuePair_2_T_Int32_0;
		}

		// Token: 0x02000366 RID: 870
		[ObfuscatedName("Canis.entities.ai.CustomWeightedRoller`1+<All>d__4")]
		public sealed class _All_d__4 : Object
		{
			// Token: 0x060024CE RID: 9422 RVA: 0x000A35FC File Offset: 0x000A17FC
			// Note: this type is marked as 'beforefieldinit'.
			static _All_d__4()
			{
				Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomWeightedRoller<T>>.NativeClassPtr, "<All>d__4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr);
				CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, "<>1__state");
				CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, "<>2__current");
				CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, "<>l__initialThreadId");
				CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, "<>4__this");
				CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, "<>7__wrap1");
				CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, 100666099);
				CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, 100666100);
				CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, 100666101);
				CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, 100666102);
				CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, 100666103);
				CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, 100666104);
				CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, 100666105);
				CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, 100666106);
				CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr, 100666107);
			}

			// Token: 0x060024CF RID: 9423 RVA: 0x000A377C File Offset: 0x000A197C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _All_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWeightedRoller<T>._All_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024D0 RID: 9424 RVA: 0x000A37C4 File Offset: 0x000A19C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024D1 RID: 9425 RVA: 0x000A37F8 File Offset: 0x000A19F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573310, XrefRangeEnd = 573347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060024D2 RID: 9426 RVA: 0x000A3834 File Offset: 0x000A1A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573347, XrefRangeEnd = 573355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000916 RID: 2326
			// (get) Token: 0x060024D3 RID: 9427 RVA: 0x000A3868 File Offset: 0x000A1A68
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060024D4 RID: 9428 RVA: 0x000A38A4 File Offset: 0x000A1AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000917 RID: 2327
			// (get) Token: 0x060024D5 RID: 9429 RVA: 0x000A38D8 File Offset: 0x000A1AD8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024D6 RID: 9430 RVA: 0x000A3918 File Offset: 0x000A1B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573355, XrefRangeEnd = 573367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060024D7 RID: 9431 RVA: 0x000A3958 File Offset: 0x000A1B58
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomWeightedRoller<T>._All_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060024D8 RID: 9432 RVA: 0x00011A79 File Offset: 0x0000FC79
			public _All_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000911 RID: 2321
			// (get) Token: 0x060024D9 RID: 9433 RVA: 0x000A3998 File Offset: 0x000A1B98
			// (set) Token: 0x060024DA RID: 9434 RVA: 0x00011A82 File Offset: 0x0000FC82
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000912 RID: 2322
			// (get) Token: 0x060024DB RID: 9435 RVA: 0x000A39C0 File Offset: 0x000A1BC0
			// (set) Token: 0x060024DC RID: 9436 RVA: 0x000A39E8 File Offset: 0x000A1BE8
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000913 RID: 2323
			// (get) Token: 0x060024DD RID: 9437 RVA: 0x000A3A90 File Offset: 0x000A1C90
			// (set) Token: 0x060024DE RID: 9438 RVA: 0x00011A9D File Offset: 0x0000FC9D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000914 RID: 2324
			// (get) Token: 0x060024DF RID: 9439 RVA: 0x000A3AB8 File Offset: 0x000A1CB8
			// (set) Token: 0x060024E0 RID: 9440 RVA: 0x00011AB8 File Offset: 0x0000FCB8
			public unsafe CustomWeightedRoller<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomWeightedRoller<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000915 RID: 2325
			// (get) Token: 0x060024E1 RID: 9441 RVA: 0x000A3AE8 File Offset: 0x000A1CE8
			// (set) Token: 0x060024E2 RID: 9442 RVA: 0x00011AD7 File Offset: 0x0000FCD7
			public unsafe IEnumerator<KeyValuePair<T, int>> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<T, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomWeightedRoller<T>._All_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400170B RID: 5899
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400170C RID: 5900
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400170D RID: 5901
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400170E RID: 5902
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400170F RID: 5903
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001710 RID: 5904
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001711 RID: 5905
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001712 RID: 5906
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001713 RID: 5907
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001714 RID: 5908
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x04001715 RID: 5909
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001716 RID: 5910
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001717 RID: 5911
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x04001718 RID: 5912
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
