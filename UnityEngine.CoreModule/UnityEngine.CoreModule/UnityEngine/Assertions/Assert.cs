using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Assertions.Comparers;

namespace UnityEngine.Assertions
{
	// Token: 0x02000287 RID: 647
	public static class Assert : Object
	{
		// Token: 0x06002C02 RID: 11266 RVA: 0x000B1444 File Offset: 0x000AF644
		// Note: this type is marked as 'beforefieldinit'.
		static Assert()
		{
			Il2CppClassPointerStore<Assert>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", "Assert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Assert>.NativeClassPtr);
			Assert.NativeFieldInfoPtr_raiseExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assert>.NativeClassPtr, "raiseExceptions");
			Assert.NativeMethodInfoPtr_Fail_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668673);
			Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668674);
			Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668675);
			Assert.NativeMethodInfoPtr_IsFalse_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668676);
			Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668677);
			Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668678);
			Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668679);
			Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668680);
			Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668681);
			Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668682);
			Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668683);
			Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668684);
			Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668685);
			Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668686);
			Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668687);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x000B15B4 File Offset: 0x000AF7B4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 686428, RefRangeEnd = 686438, XrefRangeStart = 686415, XrefRangeEnd = 686428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Fail(string message, string userMessage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_Fail_Private_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x000B15FC File Offset: 0x000AF7FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 686442, RefRangeEnd = 686447, XrefRangeStart = 686438, XrefRangeEnd = 686442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsTrue(bool condition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x000B1630 File Offset: 0x000AF830
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 686460, RefRangeEnd = 686463, XrefRangeStart = 686447, XrefRangeEnd = 686460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsTrue(bool condition, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x000B1674 File Offset: 0x000AF874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686476, RefRangeEnd = 686477, XrefRangeStart = 686463, XrefRangeEnd = 686476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsFalse(bool condition, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsFalse_Public_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x000B16B8 File Offset: 0x000AF8B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686498, RefRangeEnd = 686499, XrefRangeStart = 686477, XrefRangeEnd = 686498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AreEqual<T>(T expected, T actual)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = expected;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref expected;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = actual;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref actual;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x000B176C File Offset: 0x000AF96C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686515, RefRangeEnd = 686516, XrefRangeStart = 686499, XrefRangeEnd = 686515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AreEqual<T>(T expected, T actual, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = expected;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref expected;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = actual;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref actual;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x000B1834 File Offset: 0x000AFA34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686534, RefRangeEnd = 686536, XrefRangeStart = 686516, XrefRangeEnd = 686534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = expected;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref expected;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = actual;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref actual;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x000B190C File Offset: 0x000AFB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686536, XrefRangeEnd = 686545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AreEqual(Object expected, Object actual, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actual);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x000B1968 File Offset: 0x000AFB68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686563, RefRangeEnd = 686565, XrefRangeStart = 686545, XrefRangeEnd = 686563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsNull<T>(T value) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_IsNull_Public_Static_Void_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x000B19D4 File Offset: 0x000AFBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686565, XrefRangeEnd = 686579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsNull<T>(T value, string message) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_IsNull_Public_Static_Void_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x000B1A54 File Offset: 0x000AFC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686579, XrefRangeEnd = 686588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsNull(Object value, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x000B1A9C File Offset: 0x000AFC9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 686606, RefRangeEnd = 686609, XrefRangeStart = 686588, XrefRangeEnd = 686606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsNotNull<T>(T value) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_IsNotNull_Public_Static_Void_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x000B1B08 File Offset: 0x000AFD08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 686623, RefRangeEnd = 686624, XrefRangeStart = 686609, XrefRangeEnd = 686623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsNotNull<T>(T value, string message) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_IsNotNull_Public_Static_Void_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x000B1B88 File Offset: 0x000AFD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686624, XrefRangeEnd = 686633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsNotNull(Object value, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x000B1BD0 File Offset: 0x000AFDD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686639, RefRangeEnd = 686641, XrefRangeStart = 686633, XrefRangeEnd = 686639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AreEqual(int expected, int actual)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expected;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actual;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x00011228 File Offset: 0x0000F428
		public Assert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002C13 RID: 11283 RVA: 0x000B1C10 File Offset: 0x000AFE10
		// (set) Token: 0x06002C14 RID: 11284 RVA: 0x00011231 File Offset: 0x0000F431
		public unsafe static bool raiseExceptions
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Assert.NativeFieldInfoPtr_raiseExceptions, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Assert.NativeFieldInfoPtr_raiseExceptions, (void*)(&value));
			}
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x0001123F File Offset: 0x0000F43F
		public new static bool Equals(Object obj1, Object obj2)
		{
			throw new InvalidOperationException("Assert.Equals should not be used for Assertions");
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x0001124C File Offset: 0x0000F44C
		public new static bool ReferenceEquals(Object obj1, Object obj2)
		{
			throw new InvalidOperationException("Assert.ReferenceEquals should not be used for Assertions");
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x000B1C2C File Offset: 0x000AFE2C
		public static void IsFalse(bool condition)
		{
			if (condition)
			{
				Assert.IsFalse(condition, null);
			}
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x00011259 File Offset: 0x0000F459
		public static void AreApproximatelyEqual(float expected, float actual)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x00011266 File Offset: 0x0000F466
		public static void AreApproximatelyEqual(float expected, float actual, string message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x00011273 File Offset: 0x0000F473
		public static void AreApproximatelyEqual(float expected, float actual, float tolerance)
		{
			Assert.AreApproximatelyEqual(expected, actual, tolerance, null);
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00011280 File Offset: 0x0000F480
		public static void AreApproximatelyEqual(float expected, float actual, float tolerance, string message)
		{
			Assert.AreEqual<float>(expected, actual, message, new UnityEngine.Assertions.Comparers.FloatComparer(tolerance));
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x00011292 File Offset: 0x0000F492
		public static void AreNotApproximatelyEqual(float expected, float actual)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x0001129F File Offset: 0x0000F49F
		public static void AreNotApproximatelyEqual(float expected, float actual, string message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x000112AC File Offset: 0x0000F4AC
		public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance, null);
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x000112B9 File Offset: 0x0000F4B9
		public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance, string message)
		{
			Assert.AreNotEqual<float>(expected, actual, message, new UnityEngine.Assertions.Comparers.FloatComparer(tolerance));
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x000112CB File Offset: 0x0000F4CB
		public static void AreNotEqual<T>(T expected, T actual)
		{
			Assert.AreNotEqual<T>(expected, actual, null);
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x000112D7 File Offset: 0x0000F4D7
		public static void AreNotEqual<T>(T expected, T actual, string message)
		{
			Assert.AreNotEqual<T>(expected, actual, message, EqualityComparer<T>.Default);
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x000B1C48 File Offset: 0x000AFE48
		public static void AreNotEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
			bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()).IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag)
			{
				Assert.AreNotEqual(expected.TryCast<Object>(), actual.TryCast<Object>(), message);
			}
			else
			{
				bool flag2 = comparer.Equals(actual, expected);
				if (flag2)
				{
					Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, false), message);
				}
			}
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x000B1CB8 File Offset: 0x000AFEB8
		public static void AreNotEqual(Object expected, Object actual, string message)
		{
			bool flag = actual == expected;
			if (flag)
			{
				Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, false), message);
			}
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x000B1CE0 File Offset: 0x000AFEE0
		public static void AreEqual(sbyte expected, sbyte actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<sbyte>(expected, actual, null);
			}
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x000B1D04 File Offset: 0x000AFF04
		public static void AreEqual(sbyte expected, sbyte actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<sbyte>(expected, actual, message);
			}
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x000B1D28 File Offset: 0x000AFF28
		public static void AreNotEqual(sbyte expected, sbyte actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<sbyte>(expected, actual, null);
			}
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x000B1D48 File Offset: 0x000AFF48
		public static void AreNotEqual(sbyte expected, sbyte actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<sbyte>(expected, actual, message);
			}
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000B1D68 File Offset: 0x000AFF68
		public static void AreEqual(byte expected, byte actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<byte>(expected, actual, null);
			}
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x000B1D8C File Offset: 0x000AFF8C
		public static void AreEqual(byte expected, byte actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<byte>(expected, actual, message);
			}
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x000B1DB0 File Offset: 0x000AFFB0
		public static void AreNotEqual(byte expected, byte actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<byte>(expected, actual, null);
			}
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000B1DD0 File Offset: 0x000AFFD0
		public static void AreNotEqual(byte expected, byte actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<byte>(expected, actual, message);
			}
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000B1DF0 File Offset: 0x000AFFF0
		public static void AreEqual(char expected, char actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<char>(expected, actual, null);
			}
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x000B1E14 File Offset: 0x000B0014
		public static void AreEqual(char expected, char actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<char>(expected, actual, message);
			}
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000B1E38 File Offset: 0x000B0038
		public static void AreNotEqual(char expected, char actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<char>(expected, actual, null);
			}
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000B1E58 File Offset: 0x000B0058
		public static void AreNotEqual(char expected, char actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<char>(expected, actual, message);
			}
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000B1E78 File Offset: 0x000B0078
		public static void AreEqual(short expected, short actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<short>(expected, actual, null);
			}
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000B1E9C File Offset: 0x000B009C
		public static void AreEqual(short expected, short actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<short>(expected, actual, message);
			}
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x000B1EC0 File Offset: 0x000B00C0
		public static void AreNotEqual(short expected, short actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<short>(expected, actual, null);
			}
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000B1EE0 File Offset: 0x000B00E0
		public static void AreNotEqual(short expected, short actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<short>(expected, actual, message);
			}
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x000B1F00 File Offset: 0x000B0100
		public static void AreEqual(ushort expected, ushort actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ushort>(expected, actual, null);
			}
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x000B1F24 File Offset: 0x000B0124
		public static void AreEqual(ushort expected, ushort actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ushort>(expected, actual, message);
			}
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x000B1F48 File Offset: 0x000B0148
		public static void AreNotEqual(ushort expected, ushort actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ushort>(expected, actual, null);
			}
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x000B1F68 File Offset: 0x000B0168
		public static void AreNotEqual(ushort expected, ushort actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ushort>(expected, actual, message);
			}
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x000B1F88 File Offset: 0x000B0188
		public static void AreEqual(int expected, int actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<int>(expected, actual, message);
			}
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x000B1FAC File Offset: 0x000B01AC
		public static void AreNotEqual(int expected, int actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<int>(expected, actual, null);
			}
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x000B1FCC File Offset: 0x000B01CC
		public static void AreNotEqual(int expected, int actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<int>(expected, actual, message);
			}
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x000B1FEC File Offset: 0x000B01EC
		public static void AreEqual(uint expected, uint actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<uint>(expected, actual, null);
			}
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x000B2010 File Offset: 0x000B0210
		public static void AreEqual(uint expected, uint actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<uint>(expected, actual, message);
			}
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x000B2034 File Offset: 0x000B0234
		public static void AreNotEqual(uint expected, uint actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<uint>(expected, actual, null);
			}
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x000B2054 File Offset: 0x000B0254
		public static void AreNotEqual(uint expected, uint actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<uint>(expected, actual, message);
			}
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x000B2074 File Offset: 0x000B0274
		public static void AreEqual(long expected, long actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<long>(expected, actual, null);
			}
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x000B2098 File Offset: 0x000B0298
		public static void AreEqual(long expected, long actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<long>(expected, actual, message);
			}
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x000B20BC File Offset: 0x000B02BC
		public static void AreNotEqual(long expected, long actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<long>(expected, actual, null);
			}
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x000B20DC File Offset: 0x000B02DC
		public static void AreNotEqual(long expected, long actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<long>(expected, actual, message);
			}
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x000B20FC File Offset: 0x000B02FC
		public static void AreEqual(ulong expected, ulong actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ulong>(expected, actual, null);
			}
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x000B2120 File Offset: 0x000B0320
		public static void AreEqual(ulong expected, ulong actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ulong>(expected, actual, message);
			}
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x000B2144 File Offset: 0x000B0344
		public static void AreNotEqual(ulong expected, ulong actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ulong>(expected, actual, null);
			}
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x000B2164 File Offset: 0x000B0364
		public static void AreNotEqual(ulong expected, ulong actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ulong>(expected, actual, message);
			}
		}

		// Token: 0x0400277E RID: 10110
		private static readonly IntPtr NativeFieldInfoPtr_raiseExceptions;

		// Token: 0x0400277F RID: 10111
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Private_Static_Void_String_String_0;

		// Token: 0x04002780 RID: 10112
		private static readonly IntPtr NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_0;

		// Token: 0x04002781 RID: 10113
		private static readonly IntPtr NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_String_0;

		// Token: 0x04002782 RID: 10114
		private static readonly IntPtr NativeMethodInfoPtr_IsFalse_Public_Static_Void_Boolean_String_0;

		// Token: 0x04002783 RID: 10115
		private static readonly IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_0;

		// Token: 0x04002784 RID: 10116
		private static readonly IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_0;

		// Token: 0x04002785 RID: 10117
		private static readonly IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0;

		// Token: 0x04002786 RID: 10118
		private static readonly IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_Object_Object_String_0;

		// Token: 0x04002787 RID: 10119
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Static_Void_T_0;

		// Token: 0x04002788 RID: 10120
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Static_Void_T_String_0;

		// Token: 0x04002789 RID: 10121
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Static_Void_Object_String_0;

		// Token: 0x0400278A RID: 10122
		private static readonly IntPtr NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_0;

		// Token: 0x0400278B RID: 10123
		private static readonly IntPtr NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_String_0;

		// Token: 0x0400278C RID: 10124
		private static readonly IntPtr NativeMethodInfoPtr_IsNotNull_Public_Static_Void_Object_String_0;

		// Token: 0x0400278D RID: 10125
		private static readonly IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_Int32_Int32_0;

		// Token: 0x0400278E RID: 10126
		public const string UNITY_ASSERTIONS = "UNITY_ASSERTIONS";

		// Token: 0x02000A98 RID: 2712
		private sealed class MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_0<T>
		{
			// Token: 0x04002D56 RID: 11606
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A99 RID: 2713
		private sealed class MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_String_0<T>
		{
			// Token: 0x04002D57 RID: 11607
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A9A RID: 2714
		private sealed class MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0<T>
		{
			// Token: 0x04002D58 RID: 11608
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A9B RID: 2715
		private sealed class MethodInfoStoreGeneric_IsNull_Public_Static_Void_T_0<T>
		{
			// Token: 0x04002D59 RID: 11609
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_T_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A9C RID: 2716
		private sealed class MethodInfoStoreGeneric_IsNull_Public_Static_Void_T_String_0<T>
		{
			// Token: 0x04002D5A RID: 11610
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_T_String_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A9D RID: 2717
		private sealed class MethodInfoStoreGeneric_IsNotNull_Public_Static_Void_T_0<T>
		{
			// Token: 0x04002D5B RID: 11611
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000A9E RID: 2718
		private sealed class MethodInfoStoreGeneric_IsNotNull_Public_Static_Void_T_String_0<T>
		{
			// Token: 0x04002D5C RID: 11612
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_String_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
