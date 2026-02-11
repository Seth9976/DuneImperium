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
	// Token: 0x0200010E RID: 270
	public sealed class ConstantRoller<T> : ValueType
	{
		// Token: 0x06000C41 RID: 3137 RVA: 0x0004E2F0 File Offset: 0x0004C4F0
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantRoller()
		{
			Il2CppClassPointerStore<ConstantRoller<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "ConstantRoller`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantRoller<T>>.NativeClassPtr);
			ConstantRoller<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantRoller<T>>.NativeClassPtr, "Value");
			ConstantRoller<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantRoller<T>>.NativeClassPtr, 100665952);
			ConstantRoller<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantRoller<T>>.NativeClassPtr, 100665953);
			ConstantRoller<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantRoller<T>>.NativeClassPtr, 100665954);
			ConstantRoller<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantRoller<T>>.NativeClassPtr, 100665955);
			ConstantRoller<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantRoller<T>>.NativeClassPtr, 100665956);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0004E3D4 File Offset: 0x0004C5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572128, XrefRangeEnd = 572139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> Roll(Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(random);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantRoller<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0004E42C File Offset: 0x0004C62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572139, XrefRangeEnd = 572150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> All()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantRoller<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0004E470 File Offset: 0x0004C670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572150, XrefRangeEnd = 572163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Filtered(Func<T, bool> predicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantRoller<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0004E4C8 File Offset: 0x0004C6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572163, XrefRangeEnd = 572176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Scaled(Func<T, double> scaling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaling);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantRoller<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0004E520 File Offset: 0x0004C720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572176, XrefRangeEnd = 572195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Rekeyed(Func<T, T> rekeyer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rekeyer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantRoller<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00006538 File Offset: 0x00004738
		public ConstantRoller(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00006541 File Offset: 0x00004741
		public ConstantRoller()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantRoller<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0004E578 File Offset: 0x0004C778
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x0004E5A0 File Offset: 0x0004C7A0
		public unsafe T Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantRoller<T>.NativeFieldInfoPtr_Value);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantRoller<T>.NativeFieldInfoPtr_Value);
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

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0;
	}
}
