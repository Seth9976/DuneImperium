using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities.ai
{
	// Token: 0x0200010C RID: 268
	public sealed class Roller<T> : ValueType
	{
		// Token: 0x06000C1E RID: 3102 RVA: 0x0004D81C File Offset: 0x0004BA1C
		// Note: this type is marked as 'beforefieldinit'.
		static Roller()
		{
			Il2CppClassPointerStore<Roller<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "Roller`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr);
			Roller<T>.NativeFieldInfoPtr_Impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, "Impl");
			Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665915);
			Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_WeightedDistribution_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665916);
			Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_Dictionary_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665917);
			Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665918);
			Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665919);
			Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_DistributionRoller_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665920);
			Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_FallbackRoller_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665921);
			Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_ConstantRoller_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665922);
			Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_RankedRoller_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665923);
			Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_CustomWeightedRoller_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665924);
			Roller<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665925);
			Roller<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665926);
			Roller<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665927);
			Roller<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665928);
			Roller<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665929);
			Roller<T>.NativeMethodInfoPtr_Map_Public_Roller_1_T_Func_2_IRolls_1_T_IRolls_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665930);
			Roller<T>.NativeMethodInfoPtr_Constant_Public_Static_Roller_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665931);
			Roller<T>.NativeMethodInfoPtr_get_Bad_Public_Static_get_Roller_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665932);
			Roller<T>.NativeMethodInfoPtr_get_Copy_Public_get_Roller_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665933);
			Roller<T>.NativeMethodInfoPtr_ThenFallbackTo_Public_Roller_1_T_IRolls_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, 100665934);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0004DA2C File Offset: 0x0004BC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571849, XrefRangeEnd = 571864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Roller<T>(T mt)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return new Roller<T>(intPtr2);
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0004DAA0 File Offset: 0x0004BCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571864, XrefRangeEnd = 571868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Roller<T>(WeightedDistribution<T> wd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_WeightedDistribution_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0004DADC File Offset: 0x0004BCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571868, XrefRangeEnd = 571877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Roller<T>(Dictionary<T, int> wd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_Dictionary_2_T_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0004DB18 File Offset: 0x0004BD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571877, XrefRangeEnd = 571906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Roller<T>(Il2CppArrayBase<T> mts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_Il2CppArrayBase_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0004DB54 File Offset: 0x0004BD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571906, XrefRangeEnd = 571935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Roller<T>(List<T> mts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_List_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0004DB90 File Offset: 0x0004BD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571935, XrefRangeEnd = 571938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Roller<T>(DistributionRoller<T> impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(impl));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_DistributionRoller_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0004DBD4 File Offset: 0x0004BDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571938, XrefRangeEnd = 571941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Roller<T>(FallbackRoller<T> impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(impl));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_FallbackRoller_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0004DC18 File Offset: 0x0004BE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571941, XrefRangeEnd = 571947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Roller<T>(ConstantRoller<T> impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(impl));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_ConstantRoller_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0004DC5C File Offset: 0x0004BE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571947, XrefRangeEnd = 571950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Roller<T>(RankedRoller<T> impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(impl));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_RankedRoller_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0004DCA0 File Offset: 0x0004BEA0
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571950, XrefRangeEnd = 571951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Roller<T>(CustomWeightedRoller<T> impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_CustomWeightedRoller_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0004DCDC File Offset: 0x0004BEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572001, XrefRangeEnd = 572006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> Roll(Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(random);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0004DD34 File Offset: 0x0004BF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572006, XrefRangeEnd = 572010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> All()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0004DD78 File Offset: 0x0004BF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572010, XrefRangeEnd = 572026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Filtered(Func<T, bool> predicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0004DDD0 File Offset: 0x0004BFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572026, XrefRangeEnd = 572042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Scaled(Func<T, double> scaling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaling);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0004DE28 File Offset: 0x0004C028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572042, XrefRangeEnd = 572058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Rekeyed(Func<T, T> rekeyer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rekeyer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0004DE80 File Offset: 0x0004C080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572058, XrefRangeEnd = 572061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Roller<T> Map(Func<IRolls<T>, IRolls<T>> mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapping);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_Map_Public_Roller_1_T_Func_2_IRolls_1_T_IRolls_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0004DED0 File Offset: 0x0004C0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572061, XrefRangeEnd = 572068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Roller<T> Constant(T t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_Constant_Public_Static_Roller_1_T_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return new Roller<T>(intPtr2);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0004DF44 File Offset: 0x0004C144
		public unsafe static Roller<T> Bad
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572068, XrefRangeEnd = 572076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_get_Bad_Public_Static_get_Roller_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x0004DF70 File Offset: 0x0004C170
		public unsafe Roller<T> Copy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572076, XrefRangeEnd = 572101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_get_Copy_Public_get_Roller_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0004DFAC File Offset: 0x0004C1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572101, XrefRangeEnd = 572122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Roller<T> ThenFallbackTo(IRolls<T> fallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.NativeMethodInfoPtr_ThenFallbackTo_Public_Roller_1_T_IRolls_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Roller<T>(intPtr);
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000064CC File Offset: 0x000046CC
		public Roller(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x000064D5 File Offset: 0x000046D5
		public Roller()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0004DFFC File Offset: 0x0004C1FC
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x000064E7 File Offset: 0x000046E7
		public unsafe IRolls<T> Impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roller<T>.NativeFieldInfoPtr_Impl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roller<T>.NativeFieldInfoPtr_Impl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeFieldInfoPtr_Impl;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_T_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_WeightedDistribution_1_T_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_Dictionary_2_T_Int32_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_List_1_T_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_DistributionRoller_1_T_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_FallbackRoller_1_T_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_ConstantRoller_1_T_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_RankedRoller_1_T_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Roller_1_T_CustomWeightedRoller_1_T_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_Map_Public_Roller_1_T_Func_2_IRolls_1_T_IRolls_1_T_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_Constant_Public_Static_Roller_1_T_T_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_get_Bad_Public_Static_get_Roller_1_T_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_get_Copy_Public_get_Roller_1_T_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_ThenFallbackTo_Public_Roller_1_T_IRolls_1_T_0;

		// Token: 0x0200034F RID: 847
		[ObfuscatedName("Canis.entities.ai.Roller`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600235F RID: 9055 RVA: 0x0009E27C File Offset: 0x0009C47C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Roller<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Roller<T>.__c>.NativeClassPtr);
				Roller<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Roller<T>.__c>.NativeClassPtr, "<>9");
				Roller<T>.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Roller<T>.__c>.NativeClassPtr, "<>9__4_0");
				Roller<T>.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Roller<T>.__c>.NativeClassPtr, "<>9__5_0");
				Roller<T>.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Roller<T>.__c>.NativeClassPtr, "<>9__21_0");
				Roller<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>.__c>.NativeClassPtr, 100665936);
				Roller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__4_0_Internal_IRolls_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>.__c>.NativeClassPtr, 100665937);
				Roller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__5_0_Internal_IRolls_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>.__c>.NativeClassPtr, 100665938);
				Roller<T>.__c.NativeMethodInfoPtr__get_Copy_b__21_0_Internal_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>.__c>.NativeClassPtr, 100665939);
			}

			// Token: 0x06002360 RID: 9056 RVA: 0x0009E384 File Offset: 0x0009C584
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Roller<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002361 RID: 9057 RVA: 0x0009E3C0 File Offset: 0x0009C5C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571828, XrefRangeEnd = 571837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IRolls<T> _op_Implicit_b__4_0(T mt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Roller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__4_0_Internal_IRolls_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr4) : null;
				}
			}

			// Token: 0x06002362 RID: 9058 RVA: 0x0009E448 File Offset: 0x0009C648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IRolls<T> _op_Implicit_b__5_0(T mt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Roller<T>.__c.NativeMethodInfoPtr__op_Implicit_b__5_0_Internal_IRolls_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr4) : null;
				}
			}

			// Token: 0x06002363 RID: 9059 RVA: 0x0009E4D0 File Offset: 0x0009C6D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571837, XrefRangeEnd = 571840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _get_Copy_b__21_0(T _)
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Roller<T>.__c.NativeMethodInfoPtr__get_Copy_b__21_0_Internal_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
				}
			}

			// Token: 0x06002364 RID: 9060 RVA: 0x00010FBF File Offset: 0x0000F1BF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A1 RID: 2209
			// (get) Token: 0x06002365 RID: 9061 RVA: 0x0009E550 File Offset: 0x0009C750
			// (set) Token: 0x06002366 RID: 9062 RVA: 0x00010FC8 File Offset: 0x0000F1C8
			public unsafe static Roller<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Roller<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Roller<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Roller<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A2 RID: 2210
			// (get) Token: 0x06002367 RID: 9063 RVA: 0x0009E578 File Offset: 0x0009C778
			// (set) Token: 0x06002368 RID: 9064 RVA: 0x00010FDA File Offset: 0x0000F1DA
			public unsafe static Func<T, IRolls<T>> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Roller<T>.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IRolls<T>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Roller<T>.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A3 RID: 2211
			// (get) Token: 0x06002369 RID: 9065 RVA: 0x0009E5A0 File Offset: 0x0009C7A0
			// (set) Token: 0x0600236A RID: 9066 RVA: 0x00010FEC File Offset: 0x0000F1EC
			public unsafe static Func<T, IRolls<T>> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Roller<T>.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IRolls<T>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Roller<T>.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A4 RID: 2212
			// (get) Token: 0x0600236B RID: 9067 RVA: 0x0009E5C8 File Offset: 0x0009C7C8
			// (set) Token: 0x0600236C RID: 9068 RVA: 0x00010FFE File Offset: 0x0000F1FE
			public unsafe static Func<T, T> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Roller<T>.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Roller<T>.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400162E RID: 5678
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400162F RID: 5679
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001630 RID: 5680
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001631 RID: 5681
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x04001632 RID: 5682
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001633 RID: 5683
			private static readonly IntPtr NativeMethodInfoPtr__op_Implicit_b__4_0_Internal_IRolls_1_T_T_0;

			// Token: 0x04001634 RID: 5684
			private static readonly IntPtr NativeMethodInfoPtr__op_Implicit_b__5_0_Internal_IRolls_1_T_T_0;

			// Token: 0x04001635 RID: 5685
			private static readonly IntPtr NativeMethodInfoPtr__get_Copy_b__21_0_Internal_T_T_0;
		}

		// Token: 0x02000350 RID: 848
		[ObfuscatedName("Canis.entities.ai.Roller`1+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600236D RID: 9069 RVA: 0x0009E5F0 File Offset: 0x0009C7F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<Roller<T>.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, "<>c__DisplayClass13_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass13_0>.NativeClassPtr);
				Roller<T>.__c__DisplayClass13_0.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass13_0>.NativeClassPtr, "predicate");
				Roller<T>.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass13_0>.NativeClassPtr, 100665940);
				Roller<T>.__c__DisplayClass13_0.NativeMethodInfoPtr__Filtered_b__0_Internal_IRolls_1_T_IRolls_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass13_0>.NativeClassPtr, 100665941);
			}

			// Token: 0x0600236E RID: 9070 RVA: 0x0009E694 File Offset: 0x0009C894
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600236F RID: 9071 RVA: 0x0009E6D0 File Offset: 0x0009C8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571840, XrefRangeEnd = 571843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IRolls<T> _Filtered_b__0(IRolls<T> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.__c__DisplayClass13_0.NativeMethodInfoPtr__Filtered_b__0_Internal_IRolls_1_T_IRolls_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
				}
			}

			// Token: 0x06002370 RID: 9072 RVA: 0x00011010 File Offset: 0x0000F210
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A5 RID: 2213
			// (get) Token: 0x06002371 RID: 9073 RVA: 0x0009E720 File Offset: 0x0009C920
			// (set) Token: 0x06002372 RID: 9074 RVA: 0x00011019 File Offset: 0x0000F219
			public unsafe Func<T, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roller<T>.__c__DisplayClass13_0.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roller<T>.__c__DisplayClass13_0.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001636 RID: 5686
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x04001637 RID: 5687
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001638 RID: 5688
			private static readonly IntPtr NativeMethodInfoPtr__Filtered_b__0_Internal_IRolls_1_T_IRolls_1_T_0;
		}

		// Token: 0x02000351 RID: 849
		[ObfuscatedName("Canis.entities.ai.Roller`1+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x06002373 RID: 9075 RVA: 0x0009E750 File Offset: 0x0009C950
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<Roller<T>.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, "<>c__DisplayClass14_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass14_0>.NativeClassPtr);
				Roller<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_scaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass14_0>.NativeClassPtr, "scaling");
				Roller<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass14_0>.NativeClassPtr, 100665942);
				Roller<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__Scaled_b__0_Internal_IRolls_1_T_IRolls_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass14_0>.NativeClassPtr, 100665943);
			}

			// Token: 0x06002374 RID: 9076 RVA: 0x0009E7F4 File Offset: 0x0009C9F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002375 RID: 9077 RVA: 0x0009E830 File Offset: 0x0009CA30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571843, XrefRangeEnd = 571846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IRolls<T> _Scaled_b__0(IRolls<T> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__Scaled_b__0_Internal_IRolls_1_T_IRolls_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
				}
			}

			// Token: 0x06002376 RID: 9078 RVA: 0x00011038 File Offset: 0x0000F238
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A6 RID: 2214
			// (get) Token: 0x06002377 RID: 9079 RVA: 0x0009E880 File Offset: 0x0009CA80
			// (set) Token: 0x06002378 RID: 9080 RVA: 0x00011041 File Offset: 0x0000F241
			public unsafe Func<T, double> scaling
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roller<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_scaling);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, double>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roller<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_scaling), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001639 RID: 5689
			private static readonly IntPtr NativeFieldInfoPtr_scaling;

			// Token: 0x0400163A RID: 5690
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400163B RID: 5691
			private static readonly IntPtr NativeMethodInfoPtr__Scaled_b__0_Internal_IRolls_1_T_IRolls_1_T_0;
		}

		// Token: 0x02000352 RID: 850
		[ObfuscatedName("Canis.entities.ai.Roller`1+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x06002379 RID: 9081 RVA: 0x0009E8B0 File Offset: 0x0009CAB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<Roller<T>.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Roller<T>>.NativeClassPtr, "<>c__DisplayClass15_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass15_0>.NativeClassPtr);
				Roller<T>.__c__DisplayClass15_0.NativeFieldInfoPtr_rekeyer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass15_0>.NativeClassPtr, "rekeyer");
				Roller<T>.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass15_0>.NativeClassPtr, 100665944);
				Roller<T>.__c__DisplayClass15_0.NativeMethodInfoPtr__Rekeyed_b__0_Internal_IRolls_1_T_IRolls_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass15_0>.NativeClassPtr, 100665945);
			}

			// Token: 0x0600237A RID: 9082 RVA: 0x0009E954 File Offset: 0x0009CB54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Roller<T>.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600237B RID: 9083 RVA: 0x0009E990 File Offset: 0x0009CB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 571846, XrefRangeEnd = 571849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IRolls<T> _Rekeyed_b__0(IRolls<T> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Roller<T>.__c__DisplayClass15_0.NativeMethodInfoPtr__Rekeyed_b__0_Internal_IRolls_1_T_IRolls_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
				}
			}

			// Token: 0x0600237C RID: 9084 RVA: 0x00011060 File Offset: 0x0000F260
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x0600237D RID: 9085 RVA: 0x0009E9E0 File Offset: 0x0009CBE0
			// (set) Token: 0x0600237E RID: 9086 RVA: 0x00011069 File Offset: 0x0000F269
			public unsafe Func<T, T> rekeyer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roller<T>.__c__DisplayClass15_0.NativeFieldInfoPtr_rekeyer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Roller<T>.__c__DisplayClass15_0.NativeFieldInfoPtr_rekeyer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400163C RID: 5692
			private static readonly IntPtr NativeFieldInfoPtr_rekeyer;

			// Token: 0x0400163D RID: 5693
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400163E RID: 5694
			private static readonly IntPtr NativeMethodInfoPtr__Rekeyed_b__0_Internal_IRolls_1_T_IRolls_1_T_0;
		}
	}
}
