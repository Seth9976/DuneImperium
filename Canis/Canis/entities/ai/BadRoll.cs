using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities.ai
{
	// Token: 0x0200010D RID: 269
	public sealed class BadRoll<T> : ValueType
	{
		// Token: 0x06000C37 RID: 3127 RVA: 0x0004E02C File Offset: 0x0004C22C
		// Note: this type is marked as 'beforefieldinit'.
		static BadRoll()
		{
			Il2CppClassPointerStore<BadRoll<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "BadRoll`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BadRoll<T>>.NativeClassPtr);
			BadRoll<T>.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BadRoll<T>>.NativeClassPtr, "Instance");
			BadRoll<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadRoll<T>>.NativeClassPtr, 100665946);
			BadRoll<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadRoll<T>>.NativeClassPtr, 100665947);
			BadRoll<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadRoll<T>>.NativeClassPtr, 100665948);
			BadRoll<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadRoll<T>>.NativeClassPtr, 100665949);
			BadRoll<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadRoll<T>>.NativeClassPtr, 100665950);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0004E110 File Offset: 0x0004C310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572122, XrefRangeEnd = 572124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> Roll(Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(random);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadRoll<T>.NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0004E168 File Offset: 0x0004C368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572124, XrefRangeEnd = 572126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> All()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadRoll<T>.NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0004E1AC File Offset: 0x0004C3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 572126, XrefRangeEnd = 572128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRolls<T> Filtered(Func<T, bool> predicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadRoll<T>.NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0004E204 File Offset: 0x0004C404
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadRoll<T>.NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0004E25C File Offset: 0x0004C45C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadRoll<T>.NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRolls<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00006506 File Offset: 0x00004706
		public BadRoll(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0000650F File Offset: 0x0000470F
		public BadRoll()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BadRoll<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0004E2B4 File Offset: 0x0004C4B4
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x00006521 File Offset: 0x00004721
		public unsafe static BadRoll<T> Instance
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BadRoll<T>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(BadRoll<T>.NativeFieldInfoPtr_Instance, intPtr);
				return new BadRoll<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BadRoll<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BadRoll<T>.NativeFieldInfoPtr_Instance, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_Roll_Public_Virtual_Final_New_IEnumerable_1_T_Random_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_All_Public_Virtual_Final_New_IEnumerable_1_T_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_Filtered_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Boolean_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_Scaled_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_Double_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_Rekeyed_Public_Virtual_Final_New_IRolls_1_T_Func_2_T_T_0;
	}
}
