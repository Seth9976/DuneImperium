using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Burst.CompilerServices
{
	// Token: 0x02000023 RID: 35
	public static class Aliasing : Object
	{
		// Token: 0x06000283 RID: 643 RVA: 0x0000DA60 File Offset: 0x0000BC60
		// Note: this type is marked as 'beforefieldinit'.
		static Aliasing()
		{
			Il2CppClassPointerStore<Aliasing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.CompilerServices", "Aliasing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Aliasing>.NativeClassPtr);
			Aliasing.NativeMethodInfoPtr_ExpectAliased_Public_Static_Void_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aliasing>.NativeClassPtr, 100666922);
			Aliasing.NativeMethodInfoPtr_ExpectAliased_Public_Static_Void_byref_A_byref_B_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aliasing>.NativeClassPtr, 100666923);
			Aliasing.NativeMethodInfoPtr_ExpectAliased_Public_Static_Void_ptr_Void_byref_B_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aliasing>.NativeClassPtr, 100666924);
			Aliasing.NativeMethodInfoPtr_ExpectAliased_Public_Static_Void_byref_A_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aliasing>.NativeClassPtr, 100666925);
			Aliasing.NativeMethodInfoPtr_ExpectNotAliased_Public_Static_Void_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aliasing>.NativeClassPtr, 100666926);
			Aliasing.NativeMethodInfoPtr_ExpectNotAliased_Public_Static_Void_byref_A_byref_B_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aliasing>.NativeClassPtr, 100666927);
			Aliasing.NativeMethodInfoPtr_ExpectNotAliased_Public_Static_Void_ptr_Void_byref_B_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aliasing>.NativeClassPtr, 100666928);
			Aliasing.NativeMethodInfoPtr_ExpectNotAliased_Public_Static_Void_byref_A_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aliasing>.NativeClassPtr, 100666929);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000DB30 File Offset: 0x0000BD30
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExpectAliased(void* a, void* b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Aliasing.NativeMethodInfoPtr_ExpectAliased_Public_Static_Void_ptr_Void_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000DB70 File Offset: 0x0000BD70
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExpectAliased<A, B>([In] ref A a, [In] ref B b) where A : new() where B : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Aliasing.MethodInfoStoreGeneric_ExpectAliased_Public_Static_Void_byref_A_byref_B_0<A, B>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			a = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<A>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			b = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<B>(intPtr6, false, false));
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExpectAliased<B>(void* a, [In] ref B b) where B : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = a;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Aliasing.MethodInfoStoreGeneric_ExpectAliased_Public_Static_Void_ptr_Void_byref_B_0<B>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			b = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<B>(intPtr4, false, false));
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000DC44 File Offset: 0x0000BE44
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExpectAliased<A>([In] ref A a, void* b) where A : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = b;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Aliasing.MethodInfoStoreGeneric_ExpectAliased_Public_Static_Void_byref_A_ptr_Void_0<A>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			a = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<A>(intPtr4, false, false));
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000DCA0 File Offset: 0x0000BEA0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExpectNotAliased(void* a, void* b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Aliasing.NativeMethodInfoPtr_ExpectNotAliased_Public_Static_Void_ptr_Void_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExpectNotAliased<A, B>([In] ref A a, [In] ref B b) where A : new() where B : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Aliasing.MethodInfoStoreGeneric_ExpectNotAliased_Public_Static_Void_byref_A_byref_B_0<A, B>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			a = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<A>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			b = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<B>(intPtr6, false, false));
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000DD58 File Offset: 0x0000BF58
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExpectNotAliased<B>(void* a, [In] ref B b) where B : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = a;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Aliasing.MethodInfoStoreGeneric_ExpectNotAliased_Public_Static_Void_ptr_Void_byref_B_0<B>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			b = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<B>(intPtr4, false, false));
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000DDB4 File Offset: 0x0000BFB4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExpectNotAliased<A>([In] ref A a, void* b) where A : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = b;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Aliasing.MethodInfoStoreGeneric_ExpectNotAliased_Public_Static_Void_byref_A_ptr_Void_0<A>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			a = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<A>(intPtr4, false, false));
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002DBC File Offset: 0x00000FBC
		public Aliasing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_ExpectAliased_Public_Static_Void_ptr_Void_ptr_Void_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_ExpectAliased_Public_Static_Void_byref_A_byref_B_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_ExpectAliased_Public_Static_Void_ptr_Void_byref_B_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_ExpectAliased_Public_Static_Void_byref_A_ptr_Void_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_ExpectNotAliased_Public_Static_Void_ptr_Void_ptr_Void_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_ExpectNotAliased_Public_Static_Void_byref_A_byref_B_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_ExpectNotAliased_Public_Static_Void_ptr_Void_byref_B_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_ExpectNotAliased_Public_Static_Void_byref_A_ptr_Void_0;

		// Token: 0x02000059 RID: 89
		private sealed class MethodInfoStoreGeneric_ExpectAliased_Public_Static_Void_byref_A_byref_B_0<A, B>
		{
			// Token: 0x040011CB RID: 4555
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Aliasing.NativeMethodInfoPtr_ExpectAliased_Public_Static_Void_byref_A_byref_B_0, Il2CppClassPointerStore<Aliasing>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<A>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<B>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200005A RID: 90
		private sealed class MethodInfoStoreGeneric_ExpectAliased_Public_Static_Void_ptr_Void_byref_B_0<B>
		{
			// Token: 0x040011CC RID: 4556
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Aliasing.NativeMethodInfoPtr_ExpectAliased_Public_Static_Void_ptr_Void_byref_B_0, Il2CppClassPointerStore<Aliasing>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<B>.NativeClassPtr)) }))));
		}

		// Token: 0x0200005B RID: 91
		private sealed class MethodInfoStoreGeneric_ExpectAliased_Public_Static_Void_byref_A_ptr_Void_0<A>
		{
			// Token: 0x040011CD RID: 4557
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Aliasing.NativeMethodInfoPtr_ExpectAliased_Public_Static_Void_byref_A_ptr_Void_0, Il2CppClassPointerStore<Aliasing>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<A>.NativeClassPtr)) }))));
		}

		// Token: 0x0200005C RID: 92
		private sealed class MethodInfoStoreGeneric_ExpectNotAliased_Public_Static_Void_byref_A_byref_B_0<A, B>
		{
			// Token: 0x040011CE RID: 4558
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Aliasing.NativeMethodInfoPtr_ExpectNotAliased_Public_Static_Void_byref_A_byref_B_0, Il2CppClassPointerStore<Aliasing>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<A>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<B>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200005D RID: 93
		private sealed class MethodInfoStoreGeneric_ExpectNotAliased_Public_Static_Void_ptr_Void_byref_B_0<B>
		{
			// Token: 0x040011CF RID: 4559
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Aliasing.NativeMethodInfoPtr_ExpectNotAliased_Public_Static_Void_ptr_Void_byref_B_0, Il2CppClassPointerStore<Aliasing>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<B>.NativeClassPtr)) }))));
		}

		// Token: 0x0200005E RID: 94
		private sealed class MethodInfoStoreGeneric_ExpectNotAliased_Public_Static_Void_byref_A_ptr_Void_0<A>
		{
			// Token: 0x040011D0 RID: 4560
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Aliasing.NativeMethodInfoPtr_ExpectNotAliased_Public_Static_Void_byref_A_ptr_Void_0, Il2CppClassPointerStore<Aliasing>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<A>.NativeClassPtr)) }))));
		}
	}
}
