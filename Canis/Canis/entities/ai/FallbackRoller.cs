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
	// Token: 0x02000110 RID: 272
	public sealed class FallbackRoller<T> : ValueType
	{
		// Token: 0x06000C57 RID: 3159 RVA: 0x0004E9A0 File Offset: 0x0004CBA0
		// Note: this type is marked as 'beforefieldinit'.
		static FallbackRoller()
		{
			Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "FallbackRoller`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr);
			FallbackRoller<T>.NativeFieldInfoPtr_Rollers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, "Rollers");
			FallbackRoller<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, 100666000);
			FallbackRoller<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, 100666001);
			FallbackRoller<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, 100666002);
			FallbackRoller<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, 100666003);
			FallbackRoller<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, 100666004);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0004EA84 File Offset: 0x0004CC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> Roll(Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(random);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0004EADC File Offset: 0x0004CCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> All()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0004EB20 File Offset: 0x0004CD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572774, XrefRangeEnd = 572793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Filtered(Func<T, bool> predicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0004EB78 File Offset: 0x0004CD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572793, XrefRangeEnd = 572812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Scaled(Func<T, double> scaling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaling);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0004EBD0 File Offset: 0x0004CDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572812, XrefRangeEnd = 572831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Rekeyed(Func<T, T> rekeyer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rekeyer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0000658D File Offset: 0x0000478D
		public FallbackRoller(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00006596 File Offset: 0x00004796
		public FallbackRoller()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0004EC28 File Offset: 0x0004CE28
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x000065A8 File Offset: 0x000047A8
		public unsafe Il2CppReferenceArray<IRolls<T>> Rollers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>.NativeFieldInfoPtr_Rollers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IRolls<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>.NativeFieldInfoPtr_Rollers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeFieldInfoPtr_Rollers;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0;

		// Token: 0x02000359 RID: 857
		[ObfuscatedName("Canis.entities.ai.FallbackRoller`1+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060023EA RID: 9194 RVA: 0x000A0300 File Offset: 0x0009E500
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, "<>c__DisplayClass3_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass3_0>.NativeClassPtr);
				FallbackRoller<T>.__c__DisplayClass3_0.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass3_0>.NativeClassPtr, "predicate");
				FallbackRoller<T>.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass3_0>.NativeClassPtr, 100666005);
				FallbackRoller<T>.__c__DisplayClass3_0.NativeMethodInfoPtr__Filtered_b__0_Internal_IRolls_1_T_IRolls_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass3_0>.NativeClassPtr, 100666006);
			}

			// Token: 0x060023EB RID: 9195 RVA: 0x000A03A4 File Offset: 0x0009E5A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023EC RID: 9196 RVA: 0x000A03E0 File Offset: 0x0009E5E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IRolls<T> _Filtered_b__0(IRolls<T> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>.__c__DisplayClass3_0.NativeMethodInfoPtr__Filtered_b__0_Internal_IRolls_1_T_IRolls_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
				}
			}

			// Token: 0x060023ED RID: 9197 RVA: 0x000113AD File Offset: 0x0000F5AD
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008CA RID: 2250
			// (get) Token: 0x060023EE RID: 9198 RVA: 0x000A0430 File Offset: 0x0009E630
			// (set) Token: 0x060023EF RID: 9199 RVA: 0x000113B6 File Offset: 0x0000F5B6
			public unsafe Func<T, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>.__c__DisplayClass3_0.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>.__c__DisplayClass3_0.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001680 RID: 5760
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04001681 RID: 5761
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001682 RID: 5762
			private static readonly IntPtr NativeMethodInfoPtr__Filtered_b__0_Internal_IRolls_1_T_IRolls_1_T_0;
		}

		// Token: 0x0200035A RID: 858
		[ObfuscatedName("Canis.entities.ai.FallbackRoller`1+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060023F0 RID: 9200 RVA: 0x000A0460 File Offset: 0x0009E660
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, "<>c__DisplayClass4_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass4_0>.NativeClassPtr);
				FallbackRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_scaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, "scaling");
				FallbackRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, 100666007);
				FallbackRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__Scaled_b__0_Internal_IRolls_1_T_IRolls_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, 100666008);
			}

			// Token: 0x060023F1 RID: 9201 RVA: 0x000A0504 File Offset: 0x0009E704
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023F2 RID: 9202 RVA: 0x000A0540 File Offset: 0x0009E740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IRolls<T> _Scaled_b__0(IRolls<T> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__Scaled_b__0_Internal_IRolls_1_T_IRolls_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
				}
			}

			// Token: 0x060023F3 RID: 9203 RVA: 0x000113D5 File Offset: 0x0000F5D5
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008CB RID: 2251
			// (get) Token: 0x060023F4 RID: 9204 RVA: 0x000A0590 File Offset: 0x0009E790
			// (set) Token: 0x060023F5 RID: 9205 RVA: 0x000113DE File Offset: 0x0000F5DE
			public unsafe Func<T, double> scaling
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_scaling);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, double>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_scaling), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001683 RID: 5763
			private static readonly IntPtr NativeFieldInfoPtr_scaling;

			// Token: 0x04001684 RID: 5764
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001685 RID: 5765
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__0_Internal_IRolls_1_T_IRolls_1_T_0;
		}

		// Token: 0x0200035B RID: 859
		[ObfuscatedName("Canis.entities.ai.FallbackRoller`1+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x060023F6 RID: 9206 RVA: 0x000A05C0 File Offset: 0x0009E7C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, "<>c__DisplayClass5_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass5_0>.NativeClassPtr);
				FallbackRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr_rekeyer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, "rekeyer");
				FallbackRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, 100666009);
				FallbackRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__Rekeyed_b__0_Internal_IRolls_1_T_IRolls_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, 100666010);
			}

			// Token: 0x060023F7 RID: 9207 RVA: 0x000A0664 File Offset: 0x0009E864
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackRoller<T>.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023F8 RID: 9208 RVA: 0x000A06A0 File Offset: 0x0009E8A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IRolls<T> _Rekeyed_b__0(IRolls<T> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__Rekeyed_b__0_Internal_IRolls_1_T_IRolls_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
				}
			}

			// Token: 0x060023F9 RID: 9209 RVA: 0x000113FD File Offset: 0x0000F5FD
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008CC RID: 2252
			// (get) Token: 0x060023FA RID: 9210 RVA: 0x000A06F0 File Offset: 0x0009E8F0
			// (set) Token: 0x060023FB RID: 9211 RVA: 0x00011406 File Offset: 0x0000F606
			public unsafe Func<T, T> rekeyer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr_rekeyer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr_rekeyer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001686 RID: 5766
			private static readonly IntPtr NativeFieldInfoPtr_rekeyer;

			// Token: 0x04001687 RID: 5767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001688 RID: 5768
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__0_Internal_IRolls_1_T_IRolls_1_T_0;
		}

		// Token: 0x0200035C RID: 860
		[ObfuscatedName("Canis.entities.ai.FallbackRoller`1+<All>d__2")]
		public sealed class _All_d__2 : Object
		{
			// Token: 0x060023FC RID: 9212 RVA: 0x000A0720 File Offset: 0x0009E920
			// Note: this type is marked as 'beforefieldinit'.
			static _All_d__2()
			{
				Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, "<All>d__2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr);
				FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, "<>1__state");
				FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, "<>2__current");
				FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, "<>l__initialThreadId");
				FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, "<>4__this");
				FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, "<>3__<>4__this");
				FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, "<>7__wrap1");
				FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, "<>7__wrap2");
				FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, "<>7__wrap3");
				FallbackRoller<T>._All_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, 100666011);
				FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, 100666012);
				FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, 100666013);
				FallbackRoller<T>._All_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, 100666014);
				FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, 100666015);
				FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, 100666016);
				FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, 100666017);
				FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, 100666018);
				FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr, 100666019);
			}

			// Token: 0x060023FD RID: 9213 RVA: 0x000A08DC File Offset: 0x0009EADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _All_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackRoller<T>._All_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._All_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023FE RID: 9214 RVA: 0x000A0924 File Offset: 0x0009EB24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023FF RID: 9215 RVA: 0x000A0958 File Offset: 0x0009EB58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572640, XrefRangeEnd = 572698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002400 RID: 9216 RVA: 0x000A0994 File Offset: 0x0009EB94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572698, XrefRangeEnd = 572706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._All_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008D5 RID: 2261
			// (get) Token: 0x06002401 RID: 9217 RVA: 0x000A09C8 File Offset: 0x0009EBC8
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06002402 RID: 9218 RVA: 0x000A0A04 File Offset: 0x0009EC04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008D6 RID: 2262
			// (get) Token: 0x06002403 RID: 9219 RVA: 0x000A0A38 File Offset: 0x0009EC38
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002404 RID: 9220 RVA: 0x000A0A78 File Offset: 0x0009EC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x06002405 RID: 9221 RVA: 0x000A0AB8 File Offset: 0x0009ECB8
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002406 RID: 9222 RVA: 0x00011425 File Offset: 0x0000F625
			public _All_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008CD RID: 2253
			// (get) Token: 0x06002407 RID: 9223 RVA: 0x000A0AF8 File Offset: 0x0009ECF8
			// (set) Token: 0x06002408 RID: 9224 RVA: 0x0001142E File Offset: 0x0000F62E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008CE RID: 2254
			// (get) Token: 0x06002409 RID: 9225 RVA: 0x000A0B20 File Offset: 0x0009ED20
			// (set) Token: 0x0600240A RID: 9226 RVA: 0x000A0B48 File Offset: 0x0009ED48
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___2__current);
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

			// Token: 0x170008CF RID: 2255
			// (get) Token: 0x0600240B RID: 9227 RVA: 0x000A0BF0 File Offset: 0x0009EDF0
			// (set) Token: 0x0600240C RID: 9228 RVA: 0x00011449 File Offset: 0x0000F649
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170008D0 RID: 2256
			// (get) Token: 0x0600240D RID: 9229 RVA: 0x000A0C18 File Offset: 0x0009EE18
			// (set) Token: 0x0600240E RID: 9230 RVA: 0x00011464 File Offset: 0x0000F664
			public FallbackRoller<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___4__this);
					return new FallbackRoller<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D1 RID: 2257
			// (get) Token: 0x0600240F RID: 9231 RVA: 0x000A0C48 File Offset: 0x0009EE48
			// (set) Token: 0x06002410 RID: 9232 RVA: 0x00011492 File Offset: 0x0000F692
			public FallbackRoller<T> __3____4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___3____4__this);
					return new FallbackRoller<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___3____4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008D2 RID: 2258
			// (get) Token: 0x06002411 RID: 9233 RVA: 0x000A0C78 File Offset: 0x0009EE78
			// (set) Token: 0x06002412 RID: 9234 RVA: 0x000114C0 File Offset: 0x0000F6C0
			public unsafe Il2CppReferenceArray<IRolls<T>> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IRolls<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D3 RID: 2259
			// (get) Token: 0x06002413 RID: 9235 RVA: 0x000A0CA8 File Offset: 0x0009EEA8
			// (set) Token: 0x06002414 RID: 9236 RVA: 0x000114DF File Offset: 0x0000F6DF
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x170008D4 RID: 2260
			// (get) Token: 0x06002415 RID: 9237 RVA: 0x000A0CD0 File Offset: 0x0009EED0
			// (set) Token: 0x06002416 RID: 9238 RVA: 0x000114FA File Offset: 0x0000F6FA
			public unsafe IEnumerator<T> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001689 RID: 5769
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400168A RID: 5770
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400168B RID: 5771
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400168C RID: 5772
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400168D RID: 5773
			private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

			// Token: 0x0400168E RID: 5774
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400168F RID: 5775
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001690 RID: 5776
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04001691 RID: 5777
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001692 RID: 5778
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001693 RID: 5779
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001694 RID: 5780
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001695 RID: 5781
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x04001696 RID: 5782
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001697 RID: 5783
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001698 RID: 5784
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x04001699 RID: 5785
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200035D RID: 861
		[ObfuscatedName("Canis.entities.ai.FallbackRoller`1+<Roll>d__1")]
		public sealed class _Roll_d__1 : Object
		{
			// Token: 0x06002417 RID: 9239 RVA: 0x000A0D00 File Offset: 0x0009EF00
			// Note: this type is marked as 'beforefieldinit'.
			static _Roll_d__1()
			{
				Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, "<Roll>d__1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr);
				FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, "<>1__state");
				FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, "<>2__current");
				FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, "<>l__initialThreadId");
				FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, "<>4__this");
				FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, "<>3__<>4__this");
				FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, "random");
				FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___3__random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, "<>3__random");
				FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, "<>7__wrap1");
				FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, "<>7__wrap2");
				FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, "<>7__wrap3");
				FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, 100666020);
				FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, 100666021);
				FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, 100666022);
				FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, 100666023);
				FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, 100666024);
				FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, 100666025);
				FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, 100666026);
				FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, 100666027);
				FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr, 100666028);
			}

			// Token: 0x06002418 RID: 9240 RVA: 0x000A0EE4 File Offset: 0x0009F0E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Roll_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackRoller<T>._Roll_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002419 RID: 9241 RVA: 0x000A0F2C File Offset: 0x0009F12C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600241A RID: 9242 RVA: 0x000A0F60 File Offset: 0x0009F160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572706, XrefRangeEnd = 572766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600241B RID: 9243 RVA: 0x000A0F9C File Offset: 0x0009F19C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572766, XrefRangeEnd = 572774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008E1 RID: 2273
			// (get) Token: 0x0600241C RID: 9244 RVA: 0x000A0FD0 File Offset: 0x0009F1D0
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x0600241D RID: 9245 RVA: 0x000A100C File Offset: 0x0009F20C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008E2 RID: 2274
			// (get) Token: 0x0600241E RID: 9246 RVA: 0x000A1040 File Offset: 0x0009F240
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600241F RID: 9247 RVA: 0x000A1080 File Offset: 0x0009F280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x06002420 RID: 9248 RVA: 0x000A10C0 File Offset: 0x0009F2C0
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002421 RID: 9249 RVA: 0x00011519 File Offset: 0x0000F719
			public _Roll_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008D7 RID: 2263
			// (get) Token: 0x06002422 RID: 9250 RVA: 0x000A1100 File Offset: 0x0009F300
			// (set) Token: 0x06002423 RID: 9251 RVA: 0x00011522 File Offset: 0x0000F722
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008D8 RID: 2264
			// (get) Token: 0x06002424 RID: 9252 RVA: 0x000A1128 File Offset: 0x0009F328
			// (set) Token: 0x06002425 RID: 9253 RVA: 0x000A1150 File Offset: 0x0009F350
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___2__current);
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

			// Token: 0x170008D9 RID: 2265
			// (get) Token: 0x06002426 RID: 9254 RVA: 0x000A11F8 File Offset: 0x0009F3F8
			// (set) Token: 0x06002427 RID: 9255 RVA: 0x0001153D File Offset: 0x0000F73D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170008DA RID: 2266
			// (get) Token: 0x06002428 RID: 9256 RVA: 0x000A1220 File Offset: 0x0009F420
			// (set) Token: 0x06002429 RID: 9257 RVA: 0x00011558 File Offset: 0x0000F758
			public FallbackRoller<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___4__this);
					return new FallbackRoller<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008DB RID: 2267
			// (get) Token: 0x0600242A RID: 9258 RVA: 0x000A1250 File Offset: 0x0009F450
			// (set) Token: 0x0600242B RID: 9259 RVA: 0x00011586 File Offset: 0x0000F786
			public FallbackRoller<T> __3____4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___3____4__this);
					return new FallbackRoller<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___3____4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FallbackRoller<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008DC RID: 2268
			// (get) Token: 0x0600242C RID: 9260 RVA: 0x000A1280 File Offset: 0x0009F480
			// (set) Token: 0x0600242D RID: 9261 RVA: 0x000115B4 File Offset: 0x0000F7B4
			public unsafe Random random
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr_random);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr_random), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x0600242E RID: 9262 RVA: 0x000A12B0 File Offset: 0x0009F4B0
			// (set) Token: 0x0600242F RID: 9263 RVA: 0x000115D3 File Offset: 0x0000F7D3
			public unsafe Random __3__random
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___3__random);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___3__random), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DE RID: 2270
			// (get) Token: 0x06002430 RID: 9264 RVA: 0x000A12E0 File Offset: 0x0009F4E0
			// (set) Token: 0x06002431 RID: 9265 RVA: 0x000115F2 File Offset: 0x0000F7F2
			public unsafe Il2CppReferenceArray<IRolls<T>> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IRolls<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x06002432 RID: 9266 RVA: 0x000A1310 File Offset: 0x0009F510
			// (set) Token: 0x06002433 RID: 9267 RVA: 0x00011611 File Offset: 0x0000F811
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x170008E0 RID: 2272
			// (get) Token: 0x06002434 RID: 9268 RVA: 0x000A1338 File Offset: 0x0009F538
			// (set) Token: 0x06002435 RID: 9269 RVA: 0x0001162C File Offset: 0x0000F82C
			public unsafe IEnumerator<T> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FallbackRoller<T>._Roll_d__1.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400169A RID: 5786
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400169B RID: 5787
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400169C RID: 5788
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400169D RID: 5789
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400169E RID: 5790
			private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

			// Token: 0x0400169F RID: 5791
			private static readonly IntPtr NativeFieldInfoPtr_random;

			// Token: 0x040016A0 RID: 5792
			private static readonly IntPtr NativeFieldInfoPtr___3__random;

			// Token: 0x040016A1 RID: 5793
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040016A2 RID: 5794
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040016A3 RID: 5795
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040016A4 RID: 5796
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016A5 RID: 5797
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016A6 RID: 5798
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016A7 RID: 5799
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040016A8 RID: 5800
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x040016A9 RID: 5801
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016AA RID: 5802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016AB RID: 5803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x040016AC RID: 5804
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
