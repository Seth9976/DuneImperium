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
	// Token: 0x0200010F RID: 271
	public sealed class DistributionRoller<T> : ValueType
	{
		// Token: 0x06000C4B RID: 3147 RVA: 0x0004E648 File Offset: 0x0004C848
		// Note: this type is marked as 'beforefieldinit'.
		static DistributionRoller()
		{
			Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "DistributionRoller`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr);
			DistributionRoller<T>.NativeFieldInfoPtr_Distribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, "Distribution");
			DistributionRoller<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, 100665957);
			DistributionRoller<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, 100665958);
			DistributionRoller<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, 100665959);
			DistributionRoller<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, 100665960);
			DistributionRoller<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, 100665961);
			DistributionRoller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_DistributionRoller_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, 100665962);
			DistributionRoller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_DistributionRoller_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, 100665963);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0004E754 File Offset: 0x0004C954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572461, XrefRangeEnd = 572474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> Roll(Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(random);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0004E7AC File Offset: 0x0004C9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572474, XrefRangeEnd = 572483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> All()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0004E7F0 File Offset: 0x0004C9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572483, XrefRangeEnd = 572494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Filtered(Func<T, bool> predicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0004E848 File Offset: 0x0004CA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572494, XrefRangeEnd = 572517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Scaled(Func<T, double> scaling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaling);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0004E8A0 File Offset: 0x0004CAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572517, XrefRangeEnd = 572540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Rekeyed(Func<T, T> rekeyer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rekeyer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0004E8F8 File Offset: 0x0004CAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572540, XrefRangeEnd = 572590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DistributionRoller<T>(Il2CppArrayBase<T> mts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_DistributionRoller_1_T_Il2CppArrayBase_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DistributionRoller<T>(intPtr);
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0004E934 File Offset: 0x0004CB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572590, XrefRangeEnd = 572640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DistributionRoller<T>(List<T> mts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_DistributionRoller_1_T_List_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DistributionRoller<T>(intPtr);
			}
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00006553 File Offset: 0x00004753
		public DistributionRoller(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0000655C File Offset: 0x0000475C
		public DistributionRoller()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0004E970 File Offset: 0x0004CB70
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x0000656E File Offset: 0x0000476E
		public unsafe WeightedDistribution<T> Distribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>.NativeFieldInfoPtr_Distribution);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeightedDistribution<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>.NativeFieldInfoPtr_Distribution), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeFieldInfoPtr_Distribution;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DistributionRoller_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DistributionRoller_1_T_List_1_T_0;

		// Token: 0x02000353 RID: 851
		[ObfuscatedName("Canis.entities.ai.DistributionRoller`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600237F RID: 9087 RVA: 0x0009EA10 File Offset: 0x0009CC10
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr);
				DistributionRoller<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, "<>9");
				DistributionRoller<T>.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, "<>9__4_2");
				DistributionRoller<T>.__c.NativeFieldInfoPtr___9__4_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, "<>9__4_3");
				DistributionRoller<T>.__c.NativeFieldInfoPtr___9__4_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, "<>9__4_4");
				DistributionRoller<T>.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, "<>9__5_2");
				DistributionRoller<T>.__c.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, "<>9__5_3");
				DistributionRoller<T>.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, "<>9__6_0");
				DistributionRoller<T>.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, "<>9__6_1");
				DistributionRoller<T>.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, "<>9__7_0");
				DistributionRoller<T>.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, "<>9__7_1");
				DistributionRoller<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, 100665965);
				DistributionRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__4_2_Internal_Boolean_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, 100665966);
				DistributionRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__4_3_Internal_T_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, 100665967);
				DistributionRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__4_4_Internal_Int32_ValueTuple_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, 100665968);
				DistributionRoller<T>.__c.NativeMethodInfoPtr__Rekeyed_b__5_2_Internal_T_ValueTuple_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, 100665969);
				DistributionRoller<T>.__c.NativeMethodInfoPtr__Rekeyed_b__5_3_Internal_Int32_ValueTuple_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, 100665970);
				DistributionRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__6_0_Internal_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, 100665971);
				DistributionRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__6_1_Internal_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, 100665972);
				DistributionRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__7_0_Internal_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, 100665973);
				DistributionRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__7_1_Internal_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr, 100665974);
			}

			// Token: 0x06002380 RID: 9088 RVA: 0x0009EC08 File Offset: 0x0009CE08
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistributionRoller<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002381 RID: 9089 RVA: 0x0009EC44 File Offset: 0x0009CE44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572195, XrefRangeEnd = 572198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Scaled_b__4_2(ValueTuple<T, double> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__4_2_Internal_Boolean_ValueTuple_2_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002382 RID: 9090 RVA: 0x0009EC98 File Offset: 0x0009CE98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572198, XrefRangeEnd = 572204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _Scaled_b__4_3(ValueTuple<T, double> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__4_3_Internal_T_ValueTuple_2_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06002383 RID: 9091 RVA: 0x0009ECE8 File Offset: 0x0009CEE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572204, XrefRangeEnd = 572215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Scaled_b__4_4(ValueTuple<T, double> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c.NativeMethodInfoPtr__Scaled_b__4_4_Internal_Int32_ValueTuple_2_T_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002384 RID: 9092 RVA: 0x0009ED3C File Offset: 0x0009CF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572215, XrefRangeEnd = 572221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _Rekeyed_b__5_2(ValueTuple<T, int> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c.NativeMethodInfoPtr__Rekeyed_b__5_2_Internal_T_ValueTuple_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06002385 RID: 9093 RVA: 0x0009ED8C File Offset: 0x0009CF8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572221, XrefRangeEnd = 572228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Rekeyed_b__5_3(ValueTuple<T, int> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c.NativeMethodInfoPtr__Rekeyed_b__5_3_Internal_Int32_ValueTuple_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002386 RID: 9094 RVA: 0x0009EDE0 File Offset: 0x0009CFE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__6_0_Internal_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
				}
			}

			// Token: 0x06002387 RID: 9095 RVA: 0x0009EE60 File Offset: 0x0009D060
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__6_1_Internal_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06002388 RID: 9096 RVA: 0x0009EEE4 File Offset: 0x0009D0E4
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__7_0_Internal_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
				}
			}

			// Token: 0x06002389 RID: 9097 RVA: 0x0009EF64 File Offset: 0x0009D164
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__7_1_Internal_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x0600238A RID: 9098 RVA: 0x00011088 File Offset: 0x0000F288
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A8 RID: 2216
			// (get) Token: 0x0600238B RID: 9099 RVA: 0x0009EFE8 File Offset: 0x0009D1E8
			// (set) Token: 0x0600238C RID: 9100 RVA: 0x00011091 File Offset: 0x0000F291
			public unsafe static DistributionRoller<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DistributionRoller<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A9 RID: 2217
			// (get) Token: 0x0600238D RID: 9101 RVA: 0x0009F010 File Offset: 0x0009D210
			// (set) Token: 0x0600238E RID: 9102 RVA: 0x000110A3 File Offset: 0x0000F2A3
			public unsafe static Func<ValueTuple<T, double>, bool> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, double>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AA RID: 2218
			// (get) Token: 0x0600238F RID: 9103 RVA: 0x0009F038 File Offset: 0x0009D238
			// (set) Token: 0x06002390 RID: 9104 RVA: 0x000110B5 File Offset: 0x0000F2B5
			public unsafe static Func<ValueTuple<T, double>, T> __9__4_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__4_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, double>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__4_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AB RID: 2219
			// (get) Token: 0x06002391 RID: 9105 RVA: 0x0009F060 File Offset: 0x0009D260
			// (set) Token: 0x06002392 RID: 9106 RVA: 0x000110C7 File Offset: 0x0000F2C7
			public unsafe static Func<ValueTuple<T, double>, int> __9__4_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__4_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, double>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__4_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AC RID: 2220
			// (get) Token: 0x06002393 RID: 9107 RVA: 0x0009F088 File Offset: 0x0009D288
			// (set) Token: 0x06002394 RID: 9108 RVA: 0x000110D9 File Offset: 0x0000F2D9
			public unsafe static Func<ValueTuple<T, int>, T> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, int>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AD RID: 2221
			// (get) Token: 0x06002395 RID: 9109 RVA: 0x0009F0B0 File Offset: 0x0009D2B0
			// (set) Token: 0x06002396 RID: 9110 RVA: 0x000110EB File Offset: 0x0000F2EB
			public unsafe static Func<ValueTuple<T, int>, int> __9__5_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<T, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AE RID: 2222
			// (get) Token: 0x06002397 RID: 9111 RVA: 0x0009F0D8 File Offset: 0x0009D2D8
			// (set) Token: 0x06002398 RID: 9112 RVA: 0x000110FD File Offset: 0x0000F2FD
			public unsafe static Func<T, T> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AF RID: 2223
			// (get) Token: 0x06002399 RID: 9113 RVA: 0x0009F100 File Offset: 0x0009D300
			// (set) Token: 0x0600239A RID: 9114 RVA: 0x0001110F File Offset: 0x0000F30F
			public unsafe static Func<T, int> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B0 RID: 2224
			// (get) Token: 0x0600239B RID: 9115 RVA: 0x0009F128 File Offset: 0x0009D328
			// (set) Token: 0x0600239C RID: 9116 RVA: 0x00011121 File Offset: 0x0000F321
			public unsafe static Func<T, T> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B1 RID: 2225
			// (get) Token: 0x0600239D RID: 9117 RVA: 0x0009F150 File Offset: 0x0009D350
			// (set) Token: 0x0600239E RID: 9118 RVA: 0x00011133 File Offset: 0x0000F333
			public unsafe static Func<T, int> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DistributionRoller<T>.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400163F RID: 5695
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001640 RID: 5696
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x04001641 RID: 5697
			private static readonly IntPtr NativeFieldInfoPtr___9__4_3;

			// Token: 0x04001642 RID: 5698
			private static readonly IntPtr NativeFieldInfoPtr___9__4_4;

			// Token: 0x04001643 RID: 5699
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x04001644 RID: 5700
			private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

			// Token: 0x04001645 RID: 5701
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04001646 RID: 5702
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04001647 RID: 5703
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04001648 RID: 5704
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04001649 RID: 5705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400164A RID: 5706
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__4_2_Internal_Boolean_ValueTuple_2_T_Double_0;

			// Token: 0x0400164B RID: 5707
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__4_3_Internal_T_ValueTuple_2_T_Double_0;

			// Token: 0x0400164C RID: 5708
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__4_4_Internal_Int32_ValueTuple_2_T_Double_0;

			// Token: 0x0400164D RID: 5709
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__5_2_Internal_T_ValueTuple_2_T_Int32_0;

			// Token: 0x0400164E RID: 5710
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__5_3_Internal_Int32_ValueTuple_2_T_Int32_0;

			// Token: 0x0400164F RID: 5711
			private static readonly IntPtr NativeMethodInfoPtr__op_Implicit_b__6_0_Internal_T_T_0;

			// Token: 0x04001650 RID: 5712
			private static readonly IntPtr NativeMethodInfoPtr__op_Implicit_b__6_1_Internal_Int32_T_0;

			// Token: 0x04001651 RID: 5713
			private static readonly IntPtr NativeMethodInfoPtr__op_Implicit_b__7_0_Internal_T_T_0;

			// Token: 0x04001652 RID: 5714
			private static readonly IntPtr NativeMethodInfoPtr__op_Implicit_b__7_1_Internal_Int32_T_0;
		}

		// Token: 0x02000354 RID: 852
		[ObfuscatedName("Canis.entities.ai.DistributionRoller`1+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600239F RID: 9119 RVA: 0x0009F178 File Offset: 0x0009D378
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, "<>c__DisplayClass1_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass1_0>.NativeClassPtr);
				DistributionRoller<T>.__c__DisplayClass1_0.NativeFieldInfoPtr_rolled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass1_0>.NativeClassPtr, "rolled");
				DistributionRoller<T>.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass1_0>.NativeClassPtr, 100665975);
				DistributionRoller<T>.__c__DisplayClass1_0.NativeMethodInfoPtr__Roll_b__0_Internal_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass1_0>.NativeClassPtr, 100665976);
			}

			// Token: 0x060023A0 RID: 9120 RVA: 0x0009F21C File Offset: 0x0009D41C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023A1 RID: 9121 RVA: 0x0009F258 File Offset: 0x0009D458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572228, XrefRangeEnd = 572236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Roll_b__0(T _)
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c__DisplayClass1_0.NativeMethodInfoPtr__Roll_b__0_Internal_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x060023A2 RID: 9122 RVA: 0x00011145 File Offset: 0x0000F345
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B2 RID: 2226
			// (get) Token: 0x060023A3 RID: 9123 RVA: 0x0009F2DC File Offset: 0x0009D4DC
			// (set) Token: 0x060023A4 RID: 9124 RVA: 0x0009F304 File Offset: 0x0009D504
			public unsafe T rolled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>.__c__DisplayClass1_0.NativeFieldInfoPtr_rolled);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>.__c__DisplayClass1_0.NativeFieldInfoPtr_rolled);
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

			// Token: 0x04001653 RID: 5715
			private static readonly IntPtr NativeFieldInfoPtr_rolled;

			// Token: 0x04001654 RID: 5716
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001655 RID: 5717
			private static readonly IntPtr NativeMethodInfoPtr__Roll_b__0_Internal_Boolean_T_0;
		}

		// Token: 0x02000355 RID: 853
		[ObfuscatedName("Canis.entities.ai.DistributionRoller`1+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060023A5 RID: 9125 RVA: 0x0009F3AC File Offset: 0x0009D5AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, "<>c__DisplayClass4_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass4_0>.NativeClassPtr);
				DistributionRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_scaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, "scaling");
				DistributionRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, "<>9__1");
				DistributionRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, 100665977);
				DistributionRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__Scaled_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, 100665978);
				DistributionRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__Scaled_b__1_Internal_ValueTuple_2_T_Double_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass4_0>.NativeClassPtr, 100665979);
			}

			// Token: 0x060023A6 RID: 9126 RVA: 0x0009F478 File Offset: 0x0009D678
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023A7 RID: 9127 RVA: 0x0009F4B4 File Offset: 0x0009D6B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572236, XrefRangeEnd = 572272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<T, int> _Scaled_b__0(Dictionary<T, int> dict)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__Scaled_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T, int>>(intPtr3) : null;
				}
			}

			// Token: 0x060023A8 RID: 9128 RVA: 0x0009F504 File Offset: 0x0009D704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572272, XrefRangeEnd = 572281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<T, double> _Scaled_b__1(KeyValuePair<T, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__Scaled_b__1_Internal_ValueTuple_2_T_Double_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<T, double>(intPtr);
				}
			}

			// Token: 0x060023A9 RID: 9129 RVA: 0x0001114E File Offset: 0x0000F34E
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x060023AA RID: 9130 RVA: 0x0009F554 File Offset: 0x0009D754
			// (set) Token: 0x060023AB RID: 9131 RVA: 0x00011157 File Offset: 0x0000F357
			public unsafe Func<T, double> scaling
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_scaling);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, double>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_scaling), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B4 RID: 2228
			// (get) Token: 0x060023AC RID: 9132 RVA: 0x0009F584 File Offset: 0x0009D784
			// (set) Token: 0x060023AD RID: 9133 RVA: 0x00011176 File Offset: 0x0000F376
			public unsafe Func<KeyValuePair<T, int>, ValueTuple<T, double>> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<T, int>, ValueTuple<T, double>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>.__c__DisplayClass4_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001656 RID: 5718
			private static readonly IntPtr NativeFieldInfoPtr_scaling;

			// Token: 0x04001657 RID: 5719
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04001658 RID: 5720
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001659 RID: 5721
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0;

			// Token: 0x0400165A RID: 5722
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__1_Internal_ValueTuple_2_T_Double_KeyValuePair_2_T_Int32_0;
		}

		// Token: 0x02000356 RID: 854
		[ObfuscatedName("Canis.entities.ai.DistributionRoller`1+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x060023AE RID: 9134 RVA: 0x0009F5B4 File Offset: 0x0009D7B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, "<>c__DisplayClass5_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass5_0>.NativeClassPtr);
				DistributionRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr_rekeyer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, "rekeyer");
				DistributionRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, "<>9__1");
				DistributionRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, 100665980);
				DistributionRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__Rekeyed_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, 100665981);
				DistributionRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__Rekeyed_b__1_Internal_ValueTuple_2_T_Int32_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass5_0>.NativeClassPtr, 100665982);
			}

			// Token: 0x060023AF RID: 9135 RVA: 0x0009F680 File Offset: 0x0009D880
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistributionRoller<T>.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023B0 RID: 9136 RVA: 0x0009F6BC File Offset: 0x0009D8BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572281, XrefRangeEnd = 572306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<T, int> _Rekeyed_b__0(Dictionary<T, int> dict)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__Rekeyed_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T, int>>(intPtr3) : null;
				}
			}

			// Token: 0x060023B1 RID: 9137 RVA: 0x0009F70C File Offset: 0x0009D90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572306, XrefRangeEnd = 572315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<T, int> _Rekeyed_b__1(KeyValuePair<T, int> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__Rekeyed_b__1_Internal_ValueTuple_2_T_Int32_KeyValuePair_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<T, int>(intPtr);
				}
			}

			// Token: 0x060023B2 RID: 9138 RVA: 0x00011195 File Offset: 0x0000F395
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B5 RID: 2229
			// (get) Token: 0x060023B3 RID: 9139 RVA: 0x0009F75C File Offset: 0x0009D95C
			// (set) Token: 0x060023B4 RID: 9140 RVA: 0x0001119E File Offset: 0x0000F39E
			public unsafe Func<T, T> rekeyer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr_rekeyer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr_rekeyer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B6 RID: 2230
			// (get) Token: 0x060023B5 RID: 9141 RVA: 0x0009F78C File Offset: 0x0009D98C
			// (set) Token: 0x060023B6 RID: 9142 RVA: 0x000111BD File Offset: 0x0000F3BD
			public unsafe Func<KeyValuePair<T, int>, ValueTuple<T, int>> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<T, int>, ValueTuple<T, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>.__c__DisplayClass5_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400165B RID: 5723
			private static readonly IntPtr NativeFieldInfoPtr_rekeyer;

			// Token: 0x0400165C RID: 5724
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400165D RID: 5725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400165E RID: 5726
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__0_Internal_Dictionary_2_T_Int32_Dictionary_2_T_Int32_0;

			// Token: 0x0400165F RID: 5727
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__1_Internal_ValueTuple_2_T_Int32_KeyValuePair_2_T_Int32_0;
		}

		// Token: 0x02000357 RID: 855
		[ObfuscatedName("Canis.entities.ai.DistributionRoller`1+<All>d__2")]
		public sealed class _All_d__2 : Object
		{
			// Token: 0x060023B7 RID: 9143 RVA: 0x0009F7BC File Offset: 0x0009D9BC
			// Note: this type is marked as 'beforefieldinit'.
			static _All_d__2()
			{
				Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, "<All>d__2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr);
				DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, "<>1__state");
				DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, "<>2__current");
				DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, "<>l__initialThreadId");
				DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, "<>4__this");
				DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, "<>3__<>4__this");
				DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, "<>7__wrap1");
				DistributionRoller<T>._All_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, 100665983);
				DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, 100665984);
				DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, 100665985);
				DistributionRoller<T>._All_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, 100665986);
				DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, 100665987);
				DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, 100665988);
				DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, 100665989);
				DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, 100665990);
				DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr, 100665991);
			}

			// Token: 0x060023B8 RID: 9144 RVA: 0x0009F950 File Offset: 0x0009DB50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572315, XrefRangeEnd = 572323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _All_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistributionRoller<T>._All_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._All_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023B9 RID: 9145 RVA: 0x0009F998 File Offset: 0x0009DB98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572323, XrefRangeEnd = 572325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023BA RID: 9146 RVA: 0x0009F9CC File Offset: 0x0009DBCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572325, XrefRangeEnd = 572362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023BB RID: 9147 RVA: 0x0009FA08 File Offset: 0x0009DC08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572362, XrefRangeEnd = 572370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._All_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008BD RID: 2237
			// (get) Token: 0x060023BC RID: 9148 RVA: 0x0009FA3C File Offset: 0x0009DC3C
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572370, XrefRangeEnd = 572374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060023BD RID: 9149 RVA: 0x0009FA78 File Offset: 0x0009DC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008BE RID: 2238
			// (get) Token: 0x060023BE RID: 9150 RVA: 0x0009FAAC File Offset: 0x0009DCAC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572374, XrefRangeEnd = 572378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023BF RID: 9151 RVA: 0x0009FAEC File Offset: 0x0009DCEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572378, XrefRangeEnd = 572391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060023C0 RID: 9152 RVA: 0x0009FB2C File Offset: 0x0009DD2C
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._All_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060023C1 RID: 9153 RVA: 0x000111DC File Offset: 0x0000F3DC
			public _All_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B7 RID: 2231
			// (get) Token: 0x060023C2 RID: 9154 RVA: 0x0009FB6C File Offset: 0x0009DD6C
			// (set) Token: 0x060023C3 RID: 9155 RVA: 0x000111E5 File Offset: 0x0000F3E5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008B8 RID: 2232
			// (get) Token: 0x060023C4 RID: 9156 RVA: 0x0009FB94 File Offset: 0x0009DD94
			// (set) Token: 0x060023C5 RID: 9157 RVA: 0x0009FBBC File Offset: 0x0009DDBC
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___2__current);
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

			// Token: 0x170008B9 RID: 2233
			// (get) Token: 0x060023C6 RID: 9158 RVA: 0x0009FC64 File Offset: 0x0009DE64
			// (set) Token: 0x060023C7 RID: 9159 RVA: 0x00011200 File Offset: 0x0000F400
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170008BA RID: 2234
			// (get) Token: 0x060023C8 RID: 9160 RVA: 0x0009FC8C File Offset: 0x0009DE8C
			// (set) Token: 0x060023C9 RID: 9161 RVA: 0x0001121B File Offset: 0x0000F41B
			public DistributionRoller<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___4__this);
					return new DistributionRoller<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008BB RID: 2235
			// (get) Token: 0x060023CA RID: 9162 RVA: 0x0009FCBC File Offset: 0x0009DEBC
			// (set) Token: 0x060023CB RID: 9163 RVA: 0x00011249 File Offset: 0x0000F449
			public DistributionRoller<T> __3____4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___3____4__this);
					return new DistributionRoller<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___3____4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008BC RID: 2236
			// (get) Token: 0x060023CC RID: 9164 RVA: 0x0009FCEC File Offset: 0x0009DEEC
			// (set) Token: 0x060023CD RID: 9165 RVA: 0x00011277 File Offset: 0x0000F477
			public unsafe IEnumerator<KeyValuePair<T, int>> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<T, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._All_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001660 RID: 5728
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001661 RID: 5729
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001662 RID: 5730
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001663 RID: 5731
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001664 RID: 5732
			private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

			// Token: 0x04001665 RID: 5733
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001666 RID: 5734
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001667 RID: 5735
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001668 RID: 5736
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001669 RID: 5737
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400166A RID: 5738
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x0400166B RID: 5739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400166C RID: 5740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400166D RID: 5741
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x0400166E RID: 5742
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000358 RID: 856
		[ObfuscatedName("Canis.entities.ai.DistributionRoller`1+<Roll>d__1")]
		public sealed class _Roll_d__1 : Object
		{
			// Token: 0x060023CE RID: 9166 RVA: 0x0009FD1C File Offset: 0x0009DF1C
			// Note: this type is marked as 'beforefieldinit'.
			static _Roll_d__1()
			{
				Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, "<Roll>d__1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr);
				DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, "<>1__state");
				DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, "<>2__current");
				DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, "<>l__initialThreadId");
				DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, "<>4__this");
				DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, "<>3__<>4__this");
				DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, "random");
				DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___3__random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, "<>3__random");
				DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, "<>8__1");
				DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr__curMoveTypeDistribution_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, "<curMoveTypeDistribution>5__2");
				DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, 100665992);
				DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, 100665993);
				DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, 100665994);
				DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, 100665995);
				DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, 100665996);
				DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, 100665997);
				DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, 100665998);
				DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr, 100665999);
			}

			// Token: 0x060023CF RID: 9167 RVA: 0x0009FED8 File Offset: 0x0009E0D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Roll_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistributionRoller<T>._Roll_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023D0 RID: 9168 RVA: 0x0009FF20 File Offset: 0x0009E120
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023D1 RID: 9169 RVA: 0x0009FF54 File Offset: 0x0009E154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572391, XrefRangeEnd = 572436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008C8 RID: 2248
			// (get) Token: 0x060023D2 RID: 9170 RVA: 0x0009FF90 File Offset: 0x0009E190
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572436, XrefRangeEnd = 572440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060023D3 RID: 9171 RVA: 0x0009FFCC File Offset: 0x0009E1CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008C9 RID: 2249
			// (get) Token: 0x060023D4 RID: 9172 RVA: 0x000A0000 File Offset: 0x0009E200
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572440, XrefRangeEnd = 572444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023D5 RID: 9173 RVA: 0x000A0040 File Offset: 0x0009E240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572444, XrefRangeEnd = 572461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060023D6 RID: 9174 RVA: 0x000A0080 File Offset: 0x0009E280
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributionRoller<T>._Roll_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060023D7 RID: 9175 RVA: 0x00011296 File Offset: 0x0000F496
			public _Roll_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008BF RID: 2239
			// (get) Token: 0x060023D8 RID: 9176 RVA: 0x000A00C0 File Offset: 0x0009E2C0
			// (set) Token: 0x060023D9 RID: 9177 RVA: 0x0001129F File Offset: 0x0000F49F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008C0 RID: 2240
			// (get) Token: 0x060023DA RID: 9178 RVA: 0x000A00E8 File Offset: 0x0009E2E8
			// (set) Token: 0x060023DB RID: 9179 RVA: 0x000A0110 File Offset: 0x0009E310
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___2__current);
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

			// Token: 0x170008C1 RID: 2241
			// (get) Token: 0x060023DC RID: 9180 RVA: 0x000A01B8 File Offset: 0x0009E3B8
			// (set) Token: 0x060023DD RID: 9181 RVA: 0x000112BA File Offset: 0x0000F4BA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170008C2 RID: 2242
			// (get) Token: 0x060023DE RID: 9182 RVA: 0x000A01E0 File Offset: 0x0009E3E0
			// (set) Token: 0x060023DF RID: 9183 RVA: 0x000112D5 File Offset: 0x0000F4D5
			public DistributionRoller<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___4__this);
					return new DistributionRoller<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008C3 RID: 2243
			// (get) Token: 0x060023E0 RID: 9184 RVA: 0x000A0210 File Offset: 0x0009E410
			// (set) Token: 0x060023E1 RID: 9185 RVA: 0x00011303 File Offset: 0x0000F503
			public DistributionRoller<T> __3____4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___3____4__this);
					return new DistributionRoller<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___3____4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DistributionRoller<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008C4 RID: 2244
			// (get) Token: 0x060023E2 RID: 9186 RVA: 0x000A0240 File Offset: 0x0009E440
			// (set) Token: 0x060023E3 RID: 9187 RVA: 0x00011331 File Offset: 0x0000F531
			public unsafe Random random
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr_random);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr_random), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C5 RID: 2245
			// (get) Token: 0x060023E4 RID: 9188 RVA: 0x000A0270 File Offset: 0x0009E470
			// (set) Token: 0x060023E5 RID: 9189 RVA: 0x00011350 File Offset: 0x0000F550
			public unsafe Random __3__random
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___3__random);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___3__random), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C6 RID: 2246
			// (get) Token: 0x060023E6 RID: 9190 RVA: 0x000A02A0 File Offset: 0x0009E4A0
			// (set) Token: 0x060023E7 RID: 9191 RVA: 0x0001136F File Offset: 0x0000F56F
			public unsafe DistributionRoller<T>.__c__DisplayClass1_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DistributionRoller<T>.__c__DisplayClass1_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C7 RID: 2247
			// (get) Token: 0x060023E8 RID: 9192 RVA: 0x000A02D0 File Offset: 0x0009E4D0
			// (set) Token: 0x060023E9 RID: 9193 RVA: 0x0001138E File Offset: 0x0000F58E
			public unsafe WeightedDistribution<T> _curMoveTypeDistribution_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr__curMoveTypeDistribution_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeightedDistribution<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributionRoller<T>._Roll_d__1.NativeFieldInfoPtr__curMoveTypeDistribution_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400166F RID: 5743
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001670 RID: 5744
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001671 RID: 5745
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001672 RID: 5746
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001673 RID: 5747
			private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

			// Token: 0x04001674 RID: 5748
			private static readonly IntPtr NativeFieldInfoPtr_random;

			// Token: 0x04001675 RID: 5749
			private static readonly IntPtr NativeFieldInfoPtr___3__random;

			// Token: 0x04001676 RID: 5750
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001677 RID: 5751
			private static readonly IntPtr NativeFieldInfoPtr__curMoveTypeDistribution_5__2;

			// Token: 0x04001678 RID: 5752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001679 RID: 5753
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400167A RID: 5754
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400167B RID: 5755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x0400167C RID: 5756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400167D RID: 5757
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400167E RID: 5758
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x0400167F RID: 5759
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
