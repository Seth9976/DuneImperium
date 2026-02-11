using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000061 RID: 97
	public sealed class Operators : Object
	{
		// Token: 0x06000979 RID: 2425 RVA: 0x00031840 File Offset: 0x0002FA40
		// Note: this type is marked as 'beforefieldinit'.
		static Operators()
		{
			Il2CppClassPointerStore<Operators>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "Operators");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Operators>.NativeClassPtr);
			Operators.NativeFieldInfoPtr_s_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operators>.NativeClassPtr, "s_priority");
			Operators.NativeFieldInfoPtr_s_looks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operators>.NativeClassPtr, "s_looks");
			Operators.NativeMethodInfoPtr_IsArithmetical_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operators>.NativeClassPtr, 100664857);
			Operators.NativeMethodInfoPtr_IsLogical_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operators>.NativeClassPtr, 100664858);
			Operators.NativeMethodInfoPtr_IsRelational_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operators>.NativeClassPtr, 100664859);
			Operators.NativeMethodInfoPtr_Priority_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operators>.NativeClassPtr, 100664860);
			Operators.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operators>.NativeClassPtr, 100664861);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000318FC File Offset: 0x0002FAFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904646, RefRangeEnd = 904647, XrefRangeStart = 904646, XrefRangeEnd = 904646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsArithmetical(int op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Operators.NativeMethodInfoPtr_IsArithmetical_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0003193C File Offset: 0x0002FB3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 904647, RefRangeEnd = 904649, XrefRangeStart = 904647, XrefRangeEnd = 904647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLogical(int op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Operators.NativeMethodInfoPtr_IsLogical_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0003197C File Offset: 0x0002FB7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 904649, RefRangeEnd = 904652, XrefRangeStart = 904649, XrefRangeEnd = 904649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRelational(int op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Operators.NativeMethodInfoPtr_IsRelational_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000319BC File Offset: 0x0002FBBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 904658, RefRangeEnd = 904661, XrefRangeStart = 904652, XrefRangeEnd = 904658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Priority(int op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Operators.NativeMethodInfoPtr_Priority_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x000319FC File Offset: 0x0002FBFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 904667, RefRangeEnd = 904671, XrefRangeStart = 904661, XrefRangeEnd = 904667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Operators.NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00004DC5 File Offset: 0x00002FC5
		public Operators(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00031A34 File Offset: 0x0002FC34
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x00004DCE File Offset: 0x00002FCE
		public unsafe static Il2CppStructArray<int> s_priority
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Operators.NativeFieldInfoPtr_s_priority, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Operators.NativeFieldInfoPtr_s_priority, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00031A5C File Offset: 0x0002FC5C
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00004DE0 File Offset: 0x00002FE0
		public unsafe static Il2CppStringArray s_looks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Operators.NativeFieldInfoPtr_s_looks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Operators.NativeFieldInfoPtr_s_looks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeFieldInfoPtr_s_priority;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeFieldInfoPtr_s_looks;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_IsArithmetical_Internal_Static_Boolean_Int32_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_IsLogical_Internal_Static_Boolean_Int32_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_IsRelational_Internal_Static_Boolean_Int32_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_Priority_Internal_Static_Int32_Int32_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0;
	}
}
