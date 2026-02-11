using System;
using System.Runtime.InteropServices;
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
	// Token: 0x02000111 RID: 273
	public sealed class RankedRoller<T> : ValueType
	{
		// Token: 0x06000C61 RID: 3169 RVA: 0x0004EC58 File Offset: 0x0004CE58
		// Note: this type is marked as 'beforefieldinit'.
		static RankedRoller()
		{
			Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "RankedRoller`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr);
			RankedRoller<T>.NativeFieldInfoPtr_Distribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, "Distribution");
			RankedRoller<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, 100666029);
			RankedRoller<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, 100666030);
			RankedRoller<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, 100666031);
			RankedRoller<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, 100666032);
			RankedRoller<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, 100666033);
			RankedRoller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_RankedRoller_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, 100666034);
			RankedRoller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_RankedRoller_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, 100666035);
			RankedRoller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_RankedRoller_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, 100666036);
			RankedRoller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_RankedRoller_1_T_Dictionary_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, 100666037);
			RankedRoller<T>.NativeMethodInfoPtr_MakeFromDistribution_Public_Static_RankedRoller_1_T_Il2CppReferenceArray_1_ValueTuple_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, 100666038);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0004EDA0 File Offset: 0x0004CFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573071, XrefRangeEnd = 573080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> Roll(Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(random);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0004EDF8 File Offset: 0x0004CFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> All()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0004EE3C File Offset: 0x0004D03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Filtered(Func<T, bool> predicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0004EE94 File Offset: 0x0004D094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Scaled(Func<T, double> scaling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaling);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0004EEEC File Offset: 0x0004D0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Rekeyed(Func<T, T> rekeyer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rekeyer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0004EF44 File Offset: 0x0004D144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573080, XrefRangeEnd = 573140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RankedRoller<T>(T mt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = mt;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref mt;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_RankedRoller_1_T_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return new RankedRoller<T>(intPtr2);
			}
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0004EFB8 File Offset: 0x0004D1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573140, XrefRangeEnd = 573190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RankedRoller<T>(Il2CppArrayBase<T> mts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_RankedRoller_1_T_Il2CppArrayBase_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RankedRoller<T>(intPtr);
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0004EFF4 File Offset: 0x0004D1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573190, XrefRangeEnd = 573240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RankedRoller<T>(List<T> mts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_RankedRoller_1_T_List_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RankedRoller<T>(intPtr);
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0004F030 File Offset: 0x0004D230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573240, XrefRangeEnd = 573246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RankedRoller<T>(Dictionary<T, int> dict)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_RankedRoller_1_T_Dictionary_2_T_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RankedRoller<T>(intPtr);
			}
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0004F06C File Offset: 0x0004D26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573246, XrefRangeEnd = 573296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RankedRoller<T> MakeFromDistribution([Optional] Il2CppReferenceArray<ValueTuple<T, int>> values)
		{
			if (values == null)
			{
				values = new Il2CppStructArray<ValueTuple<T, int>>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.NativeMethodInfoPtr_MakeFromDistribution_Public_Static_RankedRoller_1_T_Il2CppReferenceArray_1_ValueTuple_2_T_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RankedRoller<T>(intPtr);
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000065C7 File Offset: 0x000047C7
		public static RankedRoller<T> MakeFromDistribution(params ValueTuple<T, int>[] values)
		{
			return RankedRoller.MakeFromDistribution(new Il2CppReferenceArray<ValueTuple<T, int>>(values));
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x000065D4 File Offset: 0x000047D4
		public RankedRoller(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x000065DD File Offset: 0x000047DD
		public RankedRoller()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr))
		{
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0004F0B8 File Offset: 0x0004D2B8
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x000065EF File Offset: 0x000047EF
		public unsafe WeightedDistribution<T> Distribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>.NativeFieldInfoPtr_Distribution);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeightedDistribution<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>.NativeFieldInfoPtr_Distribution), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeFieldInfoPtr_Distribution;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RankedRoller_1_T_T_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RankedRoller_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RankedRoller_1_T_List_1_T_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RankedRoller_1_T_Dictionary_2_T_Int32_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_MakeFromDistribution_Public_Static_RankedRoller_1_T_Il2CppReferenceArray_1_ValueTuple_2_T_Int32_0;

		// Token: 0x0200035E RID: 862
		[ObfuscatedName("Canis.entities.ai.RankedRoller`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002436 RID: 9270 RVA: 0x000A1368 File Offset: 0x0009F568
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr);
				RankedRoller<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__1_0");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__1_1");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__4_2");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__4_3");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__4_4");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__5_2");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__5_3");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__6_0");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__6_1");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__7_0");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__7_1");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__8_0");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__8_1");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__10_0");
				RankedRoller<T>.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, "<>9__10_1");
				RankedRoller<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666040);
				RankedRoller<T>.__c.NativeMethodInfoPtr__Roll_b__1_0_Internal_Int32_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666041);
				RankedRoller<T>.__c.NativeMethodInfoPtr__Roll_b__1_1_Internal_T_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666042);
				RankedRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__4_2_Internal_Boolean_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666043);
				RankedRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__4_3_Internal_T_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666044);
				RankedRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__4_4_Internal_Int32_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666045);
				RankedRoller<T>.__c.NativeMethodInfoPtr__Rekeyed_b__5_2_Internal_T_ValueTuple_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666046);
				RankedRoller<T>.__c.NativeMethodInfoPtr__Rekeyed_b__5_3_Internal_Int32_ValueTuple_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666047);
				RankedRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__6_0_Internal_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666048);
				RankedRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__6_1_Internal_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666049);
				RankedRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__7_0_Internal_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666050);
				RankedRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__7_1_Internal_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666051);
				RankedRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__8_0_Internal_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666052);
				RankedRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__8_1_Internal_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666053);
				RankedRoller<T>.__c.NativeMethodInfoPtr__MakeFromDistribution_b__10_0_Internal_T_ValueTuple_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666054);
				RankedRoller<T>.__c.NativeMethodInfoPtr__MakeFromDistribution_b__10_1_Internal_Int32_ValueTuple_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr, 100666055);
			}

			// Token: 0x06002437 RID: 9271 RVA: 0x000A1650 File Offset: 0x0009F850
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedRoller<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002438 RID: 9272 RVA: 0x000A168C File Offset: 0x0009F88C
			[CallerCount(0)]
			public unsafe int _Roll_b__1_0(KeyValuePair<T, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__Roll_b__1_0_Internal_Int32_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002439 RID: 9273 RVA: 0x000A16E0 File Offset: 0x0009F8E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572831, XrefRangeEnd = 572833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _Roll_b__1_1(KeyValuePair<T, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__Roll_b__1_1_Internal_T_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x0600243A RID: 9274 RVA: 0x000A1730 File Offset: 0x0009F930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572833, XrefRangeEnd = 572836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Scaled_b__4_2(ValueTuple<T, double> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__4_2_Internal_Boolean_ValueTuple_2_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600243B RID: 9275 RVA: 0x000A1784 File Offset: 0x0009F984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572836, XrefRangeEnd = 572842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _Scaled_b__4_3(ValueTuple<T, double> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__4_3_Internal_T_ValueTuple_2_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x0600243C RID: 9276 RVA: 0x000A17D4 File Offset: 0x0009F9D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572842, XrefRangeEnd = 572859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Scaled_b__4_4(ValueTuple<T, double> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__4_4_Internal_Int32_ValueTuple_2_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600243D RID: 9277 RVA: 0x000A1828 File Offset: 0x0009FA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572859, XrefRangeEnd = 572865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _Rekeyed_b__5_2(ValueTuple<T, int> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__Rekeyed_b__5_2_Internal_T_ValueTuple_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x0600243E RID: 9278 RVA: 0x000A1878 File Offset: 0x0009FA78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572865, XrefRangeEnd = 572868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Rekeyed_b__5_3(ValueTuple<T, int> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__Rekeyed_b__5_3_Internal_Int32_ValueTuple_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600243F RID: 9279 RVA: 0x000A18CC File Offset: 0x0009FACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572868, XrefRangeEnd = 572871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _op_Implicit_b__6_0(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__6_0_Internal_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
				}
			}

			// Token: 0x06002440 RID: 9280 RVA: 0x000A194C File Offset: 0x0009FB4C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _op_Implicit_b__6_1(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__6_1_Internal_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06002441 RID: 9281 RVA: 0x000A19D0 File Offset: 0x0009FBD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _op_Implicit_b__7_0(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__7_0_Internal_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
				}
			}

			// Token: 0x06002442 RID: 9282 RVA: 0x000A1A50 File Offset: 0x0009FC50
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _op_Implicit_b__7_1(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__7_1_Internal_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06002443 RID: 9283 RVA: 0x000A1AD4 File Offset: 0x0009FCD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _op_Implicit_b__8_0(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__8_0_Internal_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
				}
			}

			// Token: 0x06002444 RID: 9284 RVA: 0x000A1B54 File Offset: 0x0009FD54
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _op_Implicit_b__8_1(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__8_1_Internal_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06002445 RID: 9285 RVA: 0x000A1BD8 File Offset: 0x0009FDD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _MakeFromDistribution_b__10_0(ValueTuple<T, int> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__MakeFromDistribution_b__10_0_Internal_T_ValueTuple_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06002446 RID: 9286 RVA: 0x000A1C28 File Offset: 0x0009FE28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MakeFromDistribution_b__10_1(ValueTuple<T, int> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c.NativeMethodInfoPtr__MakeFromDistribution_b__10_1_Internal_Int32_ValueTuple_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002447 RID: 9287 RVA: 0x0001164B File Offset: 0x0000F84B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008E3 RID: 2275
			// (get) Token: 0x06002448 RID: 9288 RVA: 0x000A1C7C File Offset: 0x0009FE7C
			// (set) Token: 0x06002449 RID: 9289 RVA: 0x00011654 File Offset: 0x0000F854
			public unsafe static RankedRoller<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedRoller<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E4 RID: 2276
			// (get) Token: 0x0600244A RID: 9290 RVA: 0x000A1CA4 File Offset: 0x0009FEA4
			// (set) Token: 0x0600244B RID: 9291 RVA: 0x00011666 File Offset: 0x0000F866
			public unsafe static Func<KeyValuePair<T, int>, int> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<T, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E5 RID: 2277
			// (get) Token: 0x0600244C RID: 9292 RVA: 0x000A1CCC File Offset: 0x0009FECC
			// (set) Token: 0x0600244D RID: 9293 RVA: 0x00011678 File Offset: 0x0000F878
			public unsafe static Func<KeyValuePair<T, int>, T> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<T, int>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E6 RID: 2278
			// (get) Token: 0x0600244E RID: 9294 RVA: 0x000A1CF4 File Offset: 0x0009FEF4
			// (set) Token: 0x0600244F RID: 9295 RVA: 0x0001168A File Offset: 0x0000F88A
			public unsafe static Func<ValueTuple<T, double>, bool> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, double>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E7 RID: 2279
			// (get) Token: 0x06002450 RID: 9296 RVA: 0x000A1D1C File Offset: 0x0009FF1C
			// (set) Token: 0x06002451 RID: 9297 RVA: 0x0001169C File Offset: 0x0000F89C
			public unsafe static Func<ValueTuple<T, double>, T> __9__4_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, double>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E8 RID: 2280
			// (get) Token: 0x06002452 RID: 9298 RVA: 0x000A1D44 File Offset: 0x0009FF44
			// (set) Token: 0x06002453 RID: 9299 RVA: 0x000116AE File Offset: 0x0000F8AE
			public unsafe static Func<ValueTuple<T, double>, int> __9__4_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, double>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E9 RID: 2281
			// (get) Token: 0x06002454 RID: 9300 RVA: 0x000A1D6C File Offset: 0x0009FF6C
			// (set) Token: 0x06002455 RID: 9301 RVA: 0x000116C0 File Offset: 0x0000F8C0
			public unsafe static Func<ValueTuple<T, int>, T> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, int>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EA RID: 2282
			// (get) Token: 0x06002456 RID: 9302 RVA: 0x000A1D94 File Offset: 0x0009FF94
			// (set) Token: 0x06002457 RID: 9303 RVA: 0x000116D2 File Offset: 0x0000F8D2
			public unsafe static Func<ValueTuple<T, int>, int> __9__5_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EB RID: 2283
			// (get) Token: 0x06002458 RID: 9304 RVA: 0x000A1DBC File Offset: 0x0009FFBC
			// (set) Token: 0x06002459 RID: 9305 RVA: 0x000116E4 File Offset: 0x0000F8E4
			public unsafe static Func<T, T> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EC RID: 2284
			// (get) Token: 0x0600245A RID: 9306 RVA: 0x000A1DE4 File Offset: 0x0009FFE4
			// (set) Token: 0x0600245B RID: 9307 RVA: 0x000116F6 File Offset: 0x0000F8F6
			public unsafe static Func<T, int> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008ED RID: 2285
			// (get) Token: 0x0600245C RID: 9308 RVA: 0x000A1E0C File Offset: 0x000A000C
			// (set) Token: 0x0600245D RID: 9309 RVA: 0x00011708 File Offset: 0x0000F908
			public unsafe static Func<T, T> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EE RID: 2286
			// (get) Token: 0x0600245E RID: 9310 RVA: 0x000A1E34 File Offset: 0x000A0034
			// (set) Token: 0x0600245F RID: 9311 RVA: 0x0001171A File Offset: 0x0000F91A
			public unsafe static Func<T, int> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EF RID: 2287
			// (get) Token: 0x06002460 RID: 9312 RVA: 0x000A1E5C File Offset: 0x000A005C
			// (set) Token: 0x06002461 RID: 9313 RVA: 0x0001172C File Offset: 0x0000F92C
			public unsafe static Func<T, T> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F0 RID: 2288
			// (get) Token: 0x06002462 RID: 9314 RVA: 0x000A1E84 File Offset: 0x000A0084
			// (set) Token: 0x06002463 RID: 9315 RVA: 0x0001173E File Offset: 0x0000F93E
			public unsafe static Func<T, int> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F1 RID: 2289
			// (get) Token: 0x06002464 RID: 9316 RVA: 0x000A1EAC File Offset: 0x000A00AC
			// (set) Token: 0x06002465 RID: 9317 RVA: 0x00011750 File Offset: 0x0000F950
			public unsafe static Func<ValueTuple<T, int>, T> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, int>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F2 RID: 2290
			// (get) Token: 0x06002466 RID: 9318 RVA: 0x000A1ED4 File Offset: 0x000A00D4
			// (set) Token: 0x06002467 RID: 9319 RVA: 0x00011762 File Offset: 0x0000F962
			public unsafe static Func<ValueTuple<T, int>, int> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RankedRoller<T>.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016AD RID: 5805
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016AE RID: 5806
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040016AF RID: 5807
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x040016B0 RID: 5808
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x040016B1 RID: 5809
			private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

			// Token: 0x040016B2 RID: 5810
			private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

			// Token: 0x040016B3 RID: 5811
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x040016B4 RID: 5812
			private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

			// Token: 0x040016B5 RID: 5813
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040016B6 RID: 5814
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x040016B7 RID: 5815
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040016B8 RID: 5816
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x040016B9 RID: 5817
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040016BA RID: 5818
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x040016BB RID: 5819
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x040016BC RID: 5820
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x040016BD RID: 5821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016BE RID: 5822
			private static readonly IntPtr NativeMethodInfoPtr__Roll_b__1_0_Internal_Int32_KeyValuePair_2_T_Int32_0;

			// Token: 0x040016BF RID: 5823
			private static readonly IntPtr NativeMethodInfoPtr__Roll_b__1_1_Internal_T_KeyValuePair_2_T_Int32_0;

			// Token: 0x040016C0 RID: 5824
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__4_2_Internal_Boolean_ValueTuple_2_T_Double_0;

			// Token: 0x040016C1 RID: 5825
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__4_3_Internal_T_ValueTuple_2_T_Double_0;

			// Token: 0x040016C2 RID: 5826
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__4_4_Internal_Int32_ValueTuple_2_T_Double_0;

			// Token: 0x040016C3 RID: 5827
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__5_2_Internal_T_ValueTuple_2_T_Int32_0;

			// Token: 0x040016C4 RID: 5828
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__5_3_Internal_Int32_ValueTuple_2_T_Int32_0;

			// Token: 0x040016C5 RID: 5829
			private static readonly IntPtr NativeMethodInfoPtr__op_Implicit_b__6_0_Internal_T_T_0;

			// Token: 0x040016C6 RID: 5830
			private static readonly IntPtr NativeMethodInfoPtr__op_Implicit_b__6_1_Internal_Int32_T_0;

			// Token: 0x040016C7 RID: 5831
			private static readonly IntPtr NativeMethodInfoPtr__op_Implicit_b__7_0_Internal_T_T_0;

			// Token: 0x040016C8 RID: 5832
			private static readonly IntPtr NativeMethodInfoPtr__op_Implicit_b__7_1_Internal_Int32_T_0;

			// Token: 0x040016C9 RID: 5833
			private static readonly IntPtr NativeMethodInfoPtr__op_Implicit_b__8_0_Internal_T_T_0;

			// Token: 0x040016CA RID: 5834
			private static readonly IntPtr NativeMethodInfoPtr__op_Implicit_b__8_1_Internal_Int32_T_0;

			// Token: 0x040016CB RID: 5835
			private static readonly IntPtr NativeMethodInfoPtr__MakeFromDistribution_b__10_0_Internal_T_ValueTuple_2_T_Int32_0;

			// Token: 0x040016CC RID: 5836
			private static readonly IntPtr NativeMethodInfoPtr__MakeFromDistribution_b__10_1_Internal_Int32_ValueTuple_2_T_Int32_0;
		}

		// Token: 0x0200035F RID: 863
		[ObfuscatedName("Canis.entities.ai.RankedRoller`1+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06002468 RID: 9320 RVA: 0x000A1EFC File Offset: 0x000A00FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, "<>c__DisplayClass4_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass4_0>.NativeClassPtr);
				RankedRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_scaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, "scaling");
				RankedRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, "<>9__1");
				RankedRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, 100666056);
				RankedRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__Scaled_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, 100666057);
				RankedRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__Scaled_b__1_Internal_ValueTuple_2_T_Double_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, 100666058);
			}

			// Token: 0x06002469 RID: 9321 RVA: 0x000A1FC8 File Offset: 0x000A01C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600246A RID: 9322 RVA: 0x000A2004 File Offset: 0x000A0204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572871, XrefRangeEnd = 572907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<T, int> _Scaled_b__0(Dictionary<T, int> dict)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__Scaled_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T, int>>(intPtr3) : null;
				}
			}

			// Token: 0x0600246B RID: 9323 RVA: 0x000A2054 File Offset: 0x000A0254
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__Scaled_b__1_Internal_ValueTuple_2_T_Double_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<T, double>(intPtr);
				}
			}

			// Token: 0x0600246C RID: 9324 RVA: 0x00011774 File Offset: 0x0000F974
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F3 RID: 2291
			// (get) Token: 0x0600246D RID: 9325 RVA: 0x000A20A4 File Offset: 0x000A02A4
			// (set) Token: 0x0600246E RID: 9326 RVA: 0x0001177D File Offset: 0x0000F97D
			public unsafe Func<T, double> scaling
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_scaling);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, double>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_scaling), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F4 RID: 2292
			// (get) Token: 0x0600246F RID: 9327 RVA: 0x000A20D4 File Offset: 0x000A02D4
			// (set) Token: 0x06002470 RID: 9328 RVA: 0x0001179C File Offset: 0x0000F99C
			public unsafe Func<KeyValuePair<T, int>, ValueTuple<T, double>> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<T, int>, ValueTuple<T, double>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016CD RID: 5837
			private static readonly IntPtr NativeFieldInfoPtr_scaling;

			// Token: 0x040016CE RID: 5838
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040016CF RID: 5839
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016D0 RID: 5840
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0;

			// Token: 0x040016D1 RID: 5841
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__1_Internal_ValueTuple_2_T_Double_KeyValuePair_2_T_Int32_0;
		}

		// Token: 0x02000360 RID: 864
		[ObfuscatedName("Canis.entities.ai.RankedRoller`1+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06002471 RID: 9329 RVA: 0x000A2104 File Offset: 0x000A0304
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, "<>c__DisplayClass5_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass5_0>.NativeClassPtr);
				RankedRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr_rekeyer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, "rekeyer");
				RankedRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, "<>9__1");
				RankedRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, 100666059);
				RankedRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__Rekeyed_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, 100666060);
				RankedRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__Rekeyed_b__1_Internal_ValueTuple_2_T_Int32_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, 100666061);
			}

			// Token: 0x06002472 RID: 9330 RVA: 0x000A21D0 File Offset: 0x000A03D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedRoller<T>.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002473 RID: 9331 RVA: 0x000A220C File Offset: 0x000A040C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572907, XrefRangeEnd = 572932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<T, int> _Rekeyed_b__0(Dictionary<T, int> dict)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__Rekeyed_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T, int>>(intPtr3) : null;
				}
			}

			// Token: 0x06002474 RID: 9332 RVA: 0x000A225C File Offset: 0x000A045C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__Rekeyed_b__1_Internal_ValueTuple_2_T_Int32_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<T, int>(intPtr);
				}
			}

			// Token: 0x06002475 RID: 9333 RVA: 0x000117BB File Offset: 0x0000F9BB
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F5 RID: 2293
			// (get) Token: 0x06002476 RID: 9334 RVA: 0x000A22AC File Offset: 0x000A04AC
			// (set) Token: 0x06002477 RID: 9335 RVA: 0x000117C4 File Offset: 0x0000F9C4
			public unsafe Func<T, T> rekeyer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr_rekeyer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr_rekeyer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x06002478 RID: 9336 RVA: 0x000A22DC File Offset: 0x000A04DC
			// (set) Token: 0x06002479 RID: 9337 RVA: 0x000117E3 File Offset: 0x0000F9E3
			public unsafe Func<KeyValuePair<T, int>, ValueTuple<T, int>> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<T, int>, ValueTuple<T, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016D2 RID: 5842
			private static readonly IntPtr NativeFieldInfoPtr_rekeyer;

			// Token: 0x040016D3 RID: 5843
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040016D4 RID: 5844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016D5 RID: 5845
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0;

			// Token: 0x040016D6 RID: 5846
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__1_Internal_ValueTuple_2_T_Int32_KeyValuePair_2_T_Int32_0;
		}

		// Token: 0x02000361 RID: 865
		[ObfuscatedName("Canis.entities.ai.RankedRoller`1+<All>d__2")]
		public sealed class _All_d__2 : Object
		{
			// Token: 0x0600247A RID: 9338 RVA: 0x000A230C File Offset: 0x000A050C
			// Note: this type is marked as 'beforefieldinit'.
			static _All_d__2()
			{
				Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, "<All>d__2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr);
				RankedRoller<T>._All_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, "<>1__state");
				RankedRoller<T>._All_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, "<>2__current");
				RankedRoller<T>._All_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, "<>l__initialThreadId");
				RankedRoller<T>._All_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, "<>4__this");
				RankedRoller<T>._All_d__2.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, "<>3__<>4__this");
				RankedRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, "<>7__wrap1");
				RankedRoller<T>._All_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, 100666062);
				RankedRoller<T>._All_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, 100666063);
				RankedRoller<T>._All_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, 100666064);
				RankedRoller<T>._All_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, 100666065);
				RankedRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, 100666066);
				RankedRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, 100666067);
				RankedRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, 100666068);
				RankedRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, 100666069);
				RankedRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr, 100666070);
			}

			// Token: 0x0600247B RID: 9339 RVA: 0x000A24A0 File Offset: 0x000A06A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _All_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedRoller<T>._All_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._All_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600247C RID: 9340 RVA: 0x000A24E8 File Offset: 0x000A06E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._All_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600247D RID: 9341 RVA: 0x000A251C File Offset: 0x000A071C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572932, XrefRangeEnd = 572969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._All_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600247E RID: 9342 RVA: 0x000A2558 File Offset: 0x000A0758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572969, XrefRangeEnd = 572977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._All_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008FD RID: 2301
			// (get) Token: 0x0600247F RID: 9343 RVA: 0x000A258C File Offset: 0x000A078C
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06002480 RID: 9344 RVA: 0x000A25C8 File Offset: 0x000A07C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008FE RID: 2302
			// (get) Token: 0x06002481 RID: 9345 RVA: 0x000A25FC File Offset: 0x000A07FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002482 RID: 9346 RVA: 0x000A263C File Offset: 0x000A083C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x06002483 RID: 9347 RVA: 0x000A267C File Offset: 0x000A087C
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002484 RID: 9348 RVA: 0x00011802 File Offset: 0x0000FA02
			public _All_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x06002485 RID: 9349 RVA: 0x000A26BC File Offset: 0x000A08BC
			// (set) Token: 0x06002486 RID: 9350 RVA: 0x0001180B File Offset: 0x0000FA0B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._All_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._All_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008F8 RID: 2296
			// (get) Token: 0x06002487 RID: 9351 RVA: 0x000A26E4 File Offset: 0x000A08E4
			// (set) Token: 0x06002488 RID: 9352 RVA: 0x000A270C File Offset: 0x000A090C
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._All_d__2.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._All_d__2.NativeFieldInfoPtr___2__current);
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

			// Token: 0x170008F9 RID: 2297
			// (get) Token: 0x06002489 RID: 9353 RVA: 0x000A27B4 File Offset: 0x000A09B4
			// (set) Token: 0x0600248A RID: 9354 RVA: 0x00011826 File Offset: 0x0000FA26
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._All_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._All_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170008FA RID: 2298
			// (get) Token: 0x0600248B RID: 9355 RVA: 0x000A27DC File Offset: 0x000A09DC
			// (set) Token: 0x0600248C RID: 9356 RVA: 0x00011841 File Offset: 0x0000FA41
			public RankedRoller<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._All_d__2.NativeFieldInfoPtr___4__this);
					return new RankedRoller<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._All_d__2.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008FB RID: 2299
			// (get) Token: 0x0600248D RID: 9357 RVA: 0x000A280C File Offset: 0x000A0A0C
			// (set) Token: 0x0600248E RID: 9358 RVA: 0x0001186F File Offset: 0x0000FA6F
			public RankedRoller<T> __3____4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._All_d__2.NativeFieldInfoPtr___3____4__this);
					return new RankedRoller<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._All_d__2.NativeFieldInfoPtr___3____4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x0600248F RID: 9359 RVA: 0x000A283C File Offset: 0x000A0A3C
			// (set) Token: 0x06002490 RID: 9360 RVA: 0x0001189D File Offset: 0x0000FA9D
			public unsafe IEnumerator<KeyValuePair<T, int>> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<T, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016D7 RID: 5847
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016D8 RID: 5848
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016D9 RID: 5849
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040016DA RID: 5850
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016DB RID: 5851
			private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

			// Token: 0x040016DC RID: 5852
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040016DD RID: 5853
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016DE RID: 5854
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016DF RID: 5855
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016E0 RID: 5856
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040016E1 RID: 5857
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x040016E2 RID: 5858
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016E3 RID: 5859
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016E4 RID: 5860
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x040016E5 RID: 5861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000362 RID: 866
		[ObfuscatedName("Canis.entities.ai.RankedRoller`1+<Roll>d__1")]
		public sealed class _Roll_d__1 : Object
		{
			// Token: 0x06002491 RID: 9361 RVA: 0x000A286C File Offset: 0x000A0A6C
			// Note: this type is marked as 'beforefieldinit'.
			static _Roll_d__1()
			{
				Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, "<Roll>d__1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr);
				RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, "<>1__state");
				RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, "<>2__current");
				RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, "<>l__initialThreadId");
				RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, "<>4__this");
				RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, "<>3__<>4__this");
				RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, "<>7__wrap1");
				RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, 100666071);
				RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, 100666072);
				RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, 100666073);
				RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, 100666074);
				RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, 100666075);
				RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, 100666076);
				RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, 100666077);
				RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, 100666078);
				RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr, 100666079);
			}

			// Token: 0x06002492 RID: 9362 RVA: 0x000A2A00 File Offset: 0x000A0C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Roll_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedRoller<T>._Roll_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002493 RID: 9363 RVA: 0x000A2A48 File Offset: 0x000A0C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002494 RID: 9364 RVA: 0x000A2A7C File Offset: 0x000A0C7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572977, XrefRangeEnd = 573042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002495 RID: 9365 RVA: 0x000A2AB8 File Offset: 0x000A0CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573042, XrefRangeEnd = 573050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000905 RID: 2309
			// (get) Token: 0x06002496 RID: 9366 RVA: 0x000A2AEC File Offset: 0x000A0CEC
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573050, XrefRangeEnd = 573054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06002497 RID: 9367 RVA: 0x000A2B28 File Offset: 0x000A0D28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000906 RID: 2310
			// (get) Token: 0x06002498 RID: 9368 RVA: 0x000A2B5C File Offset: 0x000A0D5C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573054, XrefRangeEnd = 573058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002499 RID: 9369 RVA: 0x000A2B9C File Offset: 0x000A0D9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573058, XrefRangeEnd = 573071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x0600249A RID: 9370 RVA: 0x000A2BDC File Offset: 0x000A0DDC
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600249B RID: 9371 RVA: 0x000118BC File Offset: 0x0000FABC
			public _Roll_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008FF RID: 2303
			// (get) Token: 0x0600249C RID: 9372 RVA: 0x000A2C1C File Offset: 0x000A0E1C
			// (set) Token: 0x0600249D RID: 9373 RVA: 0x000118C5 File Offset: 0x0000FAC5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000900 RID: 2304
			// (get) Token: 0x0600249E RID: 9374 RVA: 0x000A2C44 File Offset: 0x000A0E44
			// (set) Token: 0x0600249F RID: 9375 RVA: 0x000A2C6C File Offset: 0x000A0E6C
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___2__current);
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

			// Token: 0x17000901 RID: 2305
			// (get) Token: 0x060024A0 RID: 9376 RVA: 0x000A2D14 File Offset: 0x000A0F14
			// (set) Token: 0x060024A1 RID: 9377 RVA: 0x000118E0 File Offset: 0x0000FAE0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000902 RID: 2306
			// (get) Token: 0x060024A2 RID: 9378 RVA: 0x000A2D3C File Offset: 0x000A0F3C
			// (set) Token: 0x060024A3 RID: 9379 RVA: 0x000118FB File Offset: 0x0000FAFB
			public RankedRoller<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___4__this);
					return new RankedRoller<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000903 RID: 2307
			// (get) Token: 0x060024A4 RID: 9380 RVA: 0x000A2D6C File Offset: 0x000A0F6C
			// (set) Token: 0x060024A5 RID: 9381 RVA: 0x00011929 File Offset: 0x0000FB29
			public RankedRoller<T> __3____4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___3____4__this);
					return new RankedRoller<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___3____4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RankedRoller<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000904 RID: 2308
			// (get) Token: 0x060024A6 RID: 9382 RVA: 0x000A2D9C File Offset: 0x000A0F9C
			// (set) Token: 0x060024A7 RID: 9383 RVA: 0x00011957 File Offset: 0x0000FB57
			public unsafe IEnumerator<T> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedRoller<T>._Roll_d__1.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016E6 RID: 5862
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016E7 RID: 5863
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016E8 RID: 5864
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040016E9 RID: 5865
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016EA RID: 5866
			private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

			// Token: 0x040016EB RID: 5867
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040016EC RID: 5868
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016ED RID: 5869
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016EE RID: 5870
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016EF RID: 5871
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040016F0 RID: 5872
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x040016F1 RID: 5873
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016F2 RID: 5874
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016F3 RID: 5875
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x040016F4 RID: 5876
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
