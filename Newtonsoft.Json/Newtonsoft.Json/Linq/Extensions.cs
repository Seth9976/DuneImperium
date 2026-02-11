using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000B4 RID: 180
	public static class Extensions : Object
	{
		// Token: 0x06000FD7 RID: 4055 RVA: 0x00059244 File Offset: 0x00057444
		// Note: this type is marked as 'beforefieldinit'.
		static Extensions()
		{
			Il2CppClassPointerStore<Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "Extensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions>.NativeClassPtr);
			Extensions.NativeMethodInfoPtr_Ancestors_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666081);
			Extensions.NativeMethodInfoPtr_AncestorsAndSelf_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666082);
			Extensions.NativeMethodInfoPtr_Descendants_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666083);
			Extensions.NativeMethodInfoPtr_DescendantsAndSelf_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666084);
			Extensions.NativeMethodInfoPtr_Properties_Public_Static_IJEnumerable_1_JProperty_IEnumerable_1_JObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666085);
			Extensions.NativeMethodInfoPtr_Values_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666086);
			Extensions.NativeMethodInfoPtr_Values_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666087);
			Extensions.NativeMethodInfoPtr_Values_Public_Static_IEnumerable_1_U_IEnumerable_1_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666088);
			Extensions.NativeMethodInfoPtr_Values_Public_Static_IEnumerable_1_U_IEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666089);
			Extensions.NativeMethodInfoPtr_Value_Public_Static_U_IEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666090);
			Extensions.NativeMethodInfoPtr_Value_Public_Static_U_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666091);
			Extensions.NativeMethodInfoPtr_Values_Internal_Static_IEnumerable_1_U_IEnumerable_1_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666092);
			Extensions.NativeMethodInfoPtr_Children_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666093);
			Extensions.NativeMethodInfoPtr_Children_Public_Static_IEnumerable_1_U_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666094);
			Extensions.NativeMethodInfoPtr_Convert_Internal_Static_IEnumerable_1_U_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666095);
			Extensions.NativeMethodInfoPtr_Convert_Internal_Static_U_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666096);
			Extensions.NativeMethodInfoPtr_AsJEnumerable_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666097);
			Extensions.NativeMethodInfoPtr_AsJEnumerable_Public_Static_IJEnumerable_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100666098);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x000593DC File Offset: 0x000575DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756132, XrefRangeEnd = 756150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IJEnumerable<JToken> Ancestors<T>(this IEnumerable<T> source) where T : JToken
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Ancestors_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00059420 File Offset: 0x00057620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IJEnumerable<JToken> AncestorsAndSelf<T>(this IEnumerable<T> source) where T : JToken
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_AncestorsAndSelf_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00059464 File Offset: 0x00057664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IJEnumerable<JToken> Descendants<T>(this IEnumerable<T> source) where T : JContainer
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Descendants_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000594A8 File Offset: 0x000576A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IJEnumerable<JToken> DescendantsAndSelf<T>(this IEnumerable<T> source) where T : JContainer
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_DescendantsAndSelf_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x000594EC File Offset: 0x000576EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756150, XrefRangeEnd = 756174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IJEnumerable<JProperty> Properties(this IEnumerable<JObject> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.NativeMethodInfoPtr_Properties_Public_Static_IJEnumerable_1_JProperty_IEnumerable_1_JObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<JProperty>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00059530 File Offset: 0x00057730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756174, XrefRangeEnd = 756180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IJEnumerable<JToken> Values(this IEnumerable<JToken> source, Object key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.NativeMethodInfoPtr_Values_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_JToken_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x00059588 File Offset: 0x00057788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756180, XrefRangeEnd = 756186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IJEnumerable<JToken> Values(this IEnumerable<JToken> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.NativeMethodInfoPtr_Values_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x000595CC File Offset: 0x000577CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756186, XrefRangeEnd = 756187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<U> Values<U>(this IEnumerable<JToken> source, Object key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Values_Public_Static_IEnumerable_1_U_IEnumerable_1_JToken_Object_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<U>>(intPtr3) : null;
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00059624 File Offset: 0x00057824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756187, XrefRangeEnd = 756188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<U> Values<U>(this IEnumerable<JToken> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Values_Public_Static_IEnumerable_1_U_IEnumerable_1_JToken_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<U>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00059668 File Offset: 0x00057868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756188, XrefRangeEnd = 756191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static U Value<U>(this IEnumerable<JToken> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Value_Public_Static_U_IEnumerable_1_JToken_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<U>(intPtr, false, true);
			}
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x000596A8 File Offset: 0x000578A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756191, XrefRangeEnd = 756200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static U Value<T, U>(this IEnumerable<T> value) where T : JToken
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Value_Public_Static_U_IEnumerable_1_T_0<T, U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<U>(intPtr, false, true);
			}
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x000596E8 File Offset: 0x000578E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 756206, RefRangeEnd = 756213, XrefRangeStart = 756200, XrefRangeEnd = 756206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<U> Values<T, U>(this IEnumerable<T> source, Object key) where T : JToken
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Values_Internal_Static_IEnumerable_1_U_IEnumerable_1_T_Object_0<T, U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<U>>(intPtr3) : null;
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00059740 File Offset: 0x00057940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756213, XrefRangeEnd = 756279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IJEnumerable<JToken> Children<T>(this IEnumerable<T> source) where T : JToken
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Children_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00059784 File Offset: 0x00057984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 756301, RefRangeEnd = 756302, XrefRangeStart = 756279, XrefRangeEnd = 756301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<U> Children<T, U>(this IEnumerable<T> source) where T : JToken
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Children_Public_Static_IEnumerable_1_U_IEnumerable_1_T_0<T, U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<U>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x000597C8 File Offset: 0x000579C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43475, RefRangeEnd = 43477, XrefRangeStart = 43475, XrefRangeEnd = 43477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<U> Convert<T, U>(this IEnumerable<T> source) where T : JToken
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Convert_Internal_Static_IEnumerable_1_U_IEnumerable_1_T_0<T, U>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<U>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0005980C File Offset: 0x00057A0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 756352, RefRangeEnd = 756356, XrefRangeStart = 756302, XrefRangeEnd = 756352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static U Convert<T, U>(this T token) where T : JToken
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = token;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref token;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_Convert_Internal_Static_U_T_0<T, U>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<U>(intPtr2, false, true);
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00059880 File Offset: 0x00057A80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 756359, RefRangeEnd = 756364, XrefRangeStart = 756356, XrefRangeEnd = 756359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IJEnumerable<JToken> AsJEnumerable(this IEnumerable<JToken> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.NativeMethodInfoPtr_AsJEnumerable_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x000598C4 File Offset: 0x00057AC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 756369, RefRangeEnd = 756373, XrefRangeStart = 756364, XrefRangeEnd = 756369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IJEnumerable<T> AsJEnumerable<T>(this IEnumerable<T> source) where T : JToken
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.MethodInfoStoreGeneric_AsJEnumerable_Public_Static_IJEnumerable_1_T_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x000075C7 File Offset: 0x000057C7
		public Extensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_Ancestors_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_AncestorsAndSelf_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_Descendants_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_DescendantsAndSelf_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_Properties_Public_Static_IJEnumerable_1_JProperty_IEnumerable_1_JObject_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_Values_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_JToken_Object_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_Values_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_JToken_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_Values_Public_Static_IEnumerable_1_U_IEnumerable_1_JToken_Object_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_Values_Public_Static_IEnumerable_1_U_IEnumerable_1_JToken_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_Value_Public_Static_U_IEnumerable_1_JToken_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_Value_Public_Static_U_IEnumerable_1_T_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_Values_Internal_Static_IEnumerable_1_U_IEnumerable_1_T_Object_0;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr_Children_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_Children_Public_Static_IEnumerable_1_U_IEnumerable_1_T_0;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Internal_Static_IEnumerable_1_U_IEnumerable_1_T_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Internal_Static_U_T_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_AsJEnumerable_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_JToken_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_AsJEnumerable_Public_Static_IJEnumerable_1_T_IEnumerable_1_T_0;

		// Token: 0x020001E2 RID: 482
		[ObfuscatedName("Newtonsoft.Json.Linq.Extensions+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001F0D RID: 7949 RVA: 0x0008E5DC File Offset: 0x0008C7DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Extensions.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Extensions>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions.__c>.NativeClassPtr);
				Extensions.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c>.NativeClassPtr, "<>9");
				Extensions.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c>.NativeClassPtr, "<>9__4_0");
				Extensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c>.NativeClassPtr, 100666100);
				Extensions.__c.NativeMethodInfoPtr__Properties_b__4_0_Internal_IEnumerable_1_JProperty_JObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c>.NativeClassPtr, 100666101);
			}

			// Token: 0x06001F0E RID: 7950 RVA: 0x0008E658 File Offset: 0x0008C858
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Extensions.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F0F RID: 7951 RVA: 0x0008E694 File Offset: 0x0008C894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755977, XrefRangeEnd = 755979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<JProperty> _Properties_b__4_0(JObject d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.__c.NativeMethodInfoPtr__Properties_b__4_0_Internal_IEnumerable_1_JProperty_JObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JProperty>>(intPtr3) : null;
				}
			}

			// Token: 0x06001F10 RID: 7952 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B2 RID: 2226
			// (get) Token: 0x06001F11 RID: 7953 RVA: 0x0008E6E4 File Offset: 0x0008C8E4
			// (set) Token: 0x06001F12 RID: 7954 RVA: 0x0000F501 File Offset: 0x0000D701
			public unsafe static Extensions.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extensions.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Extensions.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extensions.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B3 RID: 2227
			// (get) Token: 0x06001F13 RID: 7955 RVA: 0x0008E70C File Offset: 0x0008C90C
			// (set) Token: 0x06001F14 RID: 7956 RVA: 0x0000F513 File Offset: 0x0000D713
			public unsafe static Func<JObject, IEnumerable<JProperty>> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extensions.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JObject, IEnumerable<JProperty>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extensions.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001695 RID: 5781
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001696 RID: 5782
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001697 RID: 5783
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001698 RID: 5784
			private static readonly IntPtr NativeMethodInfoPtr__Properties_b__4_0_Internal_IEnumerable_1_JProperty_JObject_0;
		}

		// Token: 0x020001E3 RID: 483
		[ObfuscatedName("Newtonsoft.Json.Linq.Extensions+<>c__0`1")]
		[Serializable]
		public sealed class __c__0<T> : Object where T : JToken
		{
			// Token: 0x06001F15 RID: 7957 RVA: 0x0008E734 File Offset: 0x0008C934
			// Note: this type is marked as 'beforefieldinit'.
			static __c__0()
			{
				Il2CppClassPointerStore<Extensions.__c__0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Extensions>.NativeClassPtr, "<>c__0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions.__c__0<T>>.NativeClassPtr);
				Extensions.__c__0<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c__0<T>>.NativeClassPtr, "<>9");
				Extensions.__c__0<T>.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c__0<T>>.NativeClassPtr, "<>9__0_0");
				Extensions.__c__0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__0<T>>.NativeClassPtr, 100666103);
				Extensions.__c__0<T>.NativeMethodInfoPtr__Ancestors_b__0_0_Internal_IEnumerable_1_JToken_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__0<T>>.NativeClassPtr, 100666104);
			}

			// Token: 0x06001F16 RID: 7958 RVA: 0x0008E7EC File Offset: 0x0008C9EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Extensions.__c__0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F17 RID: 7959 RVA: 0x0008E828 File Offset: 0x0008CA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755979, XrefRangeEnd = 755981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<JToken> _Ancestors_b__0_0(T j)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = j;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref j;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__0<T>.NativeMethodInfoPtr__Ancestors_b__0_0_Internal_IEnumerable_1_JToken_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr4) : null;
				}
			}

			// Token: 0x06001F18 RID: 7960 RVA: 0x0000F525 File Offset: 0x0000D725
			public __c__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B4 RID: 2228
			// (get) Token: 0x06001F19 RID: 7961 RVA: 0x0008E8B0 File Offset: 0x0008CAB0
			// (set) Token: 0x06001F1A RID: 7962 RVA: 0x0000F52E File Offset: 0x0000D72E
			public unsafe static Extensions.__c__0<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extensions.__c__0<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Extensions.__c__0<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extensions.__c__0<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B5 RID: 2229
			// (get) Token: 0x06001F1B RID: 7963 RVA: 0x0008E8D8 File Offset: 0x0008CAD8
			// (set) Token: 0x06001F1C RID: 7964 RVA: 0x0000F540 File Offset: 0x0000D740
			public unsafe static Func<T, IEnumerable<JToken>> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extensions.__c__0<T>.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerable<JToken>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extensions.__c__0<T>.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001699 RID: 5785
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400169A RID: 5786
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400169B RID: 5787
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400169C RID: 5788
			private static readonly IntPtr NativeMethodInfoPtr__Ancestors_b__0_0_Internal_IEnumerable_1_JToken_T_0;
		}

		// Token: 0x020001E4 RID: 484
		[ObfuscatedName("Newtonsoft.Json.Linq.Extensions+<>c__1`1")]
		[Serializable]
		public sealed class __c__1<T> : Object where T : JToken
		{
			// Token: 0x06001F1D RID: 7965 RVA: 0x0008E900 File Offset: 0x0008CB00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__1()
			{
				Il2CppClassPointerStore<Extensions.__c__1<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Extensions>.NativeClassPtr, "<>c__1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions.__c__1<T>>.NativeClassPtr);
				Extensions.__c__1<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c__1<T>>.NativeClassPtr, "<>9");
				Extensions.__c__1<T>.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c__1<T>>.NativeClassPtr, "<>9__1_0");
				Extensions.__c__1<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__1<T>>.NativeClassPtr, 100666106);
				Extensions.__c__1<T>.NativeMethodInfoPtr__AncestorsAndSelf_b__1_0_Internal_IEnumerable_1_JToken_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__1<T>>.NativeClassPtr, 100666107);
			}

			// Token: 0x06001F1E RID: 7966 RVA: 0x0008E9B8 File Offset: 0x0008CBB8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Extensions.__c__1<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__1<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F1F RID: 7967 RVA: 0x0008E9F4 File Offset: 0x0008CBF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755981, XrefRangeEnd = 755983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<JToken> _AncestorsAndSelf_b__1_0(T j)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = j;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref j;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__1<T>.NativeMethodInfoPtr__AncestorsAndSelf_b__1_0_Internal_IEnumerable_1_JToken_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr4) : null;
				}
			}

			// Token: 0x06001F20 RID: 7968 RVA: 0x0000F552 File Offset: 0x0000D752
			public __c__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B6 RID: 2230
			// (get) Token: 0x06001F21 RID: 7969 RVA: 0x0008EA7C File Offset: 0x0008CC7C
			// (set) Token: 0x06001F22 RID: 7970 RVA: 0x0000F55B File Offset: 0x0000D75B
			public unsafe static Extensions.__c__1<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extensions.__c__1<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Extensions.__c__1<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extensions.__c__1<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B7 RID: 2231
			// (get) Token: 0x06001F23 RID: 7971 RVA: 0x0008EAA4 File Offset: 0x0008CCA4
			// (set) Token: 0x06001F24 RID: 7972 RVA: 0x0000F56D File Offset: 0x0000D76D
			public unsafe static Func<T, IEnumerable<JToken>> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extensions.__c__1<T>.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerable<JToken>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extensions.__c__1<T>.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400169D RID: 5789
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400169E RID: 5790
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400169F RID: 5791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016A0 RID: 5792
			private static readonly IntPtr NativeMethodInfoPtr__AncestorsAndSelf_b__1_0_Internal_IEnumerable_1_JToken_T_0;
		}

		// Token: 0x020001E5 RID: 485
		[ObfuscatedName("Newtonsoft.Json.Linq.Extensions+<>c__13`2")]
		[Serializable]
		public sealed class __c__13<T, U> : Object where T : JToken
		{
			// Token: 0x06001F25 RID: 7973 RVA: 0x0008EACC File Offset: 0x0008CCCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__13()
			{
				Il2CppClassPointerStore<Extensions.__c__13<T, U>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Extensions>.NativeClassPtr, "<>c__13`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions.__c__13<T, U>>.NativeClassPtr);
				Extensions.__c__13<T, U>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c__13<T, U>>.NativeClassPtr, "<>9");
				Extensions.__c__13<T, U>.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c__13<T, U>>.NativeClassPtr, "<>9__13_0");
				Extensions.__c__13<T, U>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__13<T, U>>.NativeClassPtr, 100666109);
				Extensions.__c__13<T, U>.NativeMethodInfoPtr__Children_b__13_0_Internal_IEnumerable_1_JToken_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__13<T, U>>.NativeClassPtr, 100666110);
			}

			// Token: 0x06001F26 RID: 7974 RVA: 0x0008EB94 File Offset: 0x0008CD94
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__13()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Extensions.__c__13<T, U>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__13<T, U>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F27 RID: 7975 RVA: 0x0008EBD0 File Offset: 0x0008CDD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755983, XrefRangeEnd = 755986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<JToken> _Children_b__13_0(T c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = c;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref c;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__13<T, U>.NativeMethodInfoPtr__Children_b__13_0_Internal_IEnumerable_1_JToken_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr4) : null;
				}
			}

			// Token: 0x06001F28 RID: 7976 RVA: 0x0000F57F File Offset: 0x0000D77F
			public __c__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B8 RID: 2232
			// (get) Token: 0x06001F29 RID: 7977 RVA: 0x0008EC58 File Offset: 0x0008CE58
			// (set) Token: 0x06001F2A RID: 7978 RVA: 0x0000F588 File Offset: 0x0000D788
			public unsafe static Extensions.__c__13<T, U> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extensions.__c__13<T, U>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Extensions.__c__13<T, U>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extensions.__c__13<T, U>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B9 RID: 2233
			// (get) Token: 0x06001F2B RID: 7979 RVA: 0x0008EC80 File Offset: 0x0008CE80
			// (set) Token: 0x06001F2C RID: 7980 RVA: 0x0000F59A File Offset: 0x0000D79A
			public unsafe static Func<T, IEnumerable<JToken>> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extensions.__c__13<T, U>.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerable<JToken>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extensions.__c__13<T, U>.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016A1 RID: 5793
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016A2 RID: 5794
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040016A3 RID: 5795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016A4 RID: 5796
			private static readonly IntPtr NativeMethodInfoPtr__Children_b__13_0_Internal_IEnumerable_1_JToken_T_0;
		}

		// Token: 0x020001E6 RID: 486
		[ObfuscatedName("Newtonsoft.Json.Linq.Extensions+<>c__2`1")]
		[Serializable]
		public sealed class __c__2<T> : Object where T : JContainer
		{
			// Token: 0x06001F2D RID: 7981 RVA: 0x0008ECA8 File Offset: 0x0008CEA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__2()
			{
				Il2CppClassPointerStore<Extensions.__c__2<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Extensions>.NativeClassPtr, "<>c__2`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions.__c__2<T>>.NativeClassPtr);
				Extensions.__c__2<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c__2<T>>.NativeClassPtr, "<>9");
				Extensions.__c__2<T>.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c__2<T>>.NativeClassPtr, "<>9__2_0");
				Extensions.__c__2<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__2<T>>.NativeClassPtr, 100666112);
				Extensions.__c__2<T>.NativeMethodInfoPtr__Descendants_b__2_0_Internal_IEnumerable_1_JToken_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__2<T>>.NativeClassPtr, 100666113);
			}

			// Token: 0x06001F2E RID: 7982 RVA: 0x0008ED60 File Offset: 0x0008CF60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Extensions.__c__2<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__2<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F2F RID: 7983 RVA: 0x0008ED9C File Offset: 0x0008CF9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755986, XrefRangeEnd = 755988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<JToken> _Descendants_b__2_0(T j)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = j;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref j;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__2<T>.NativeMethodInfoPtr__Descendants_b__2_0_Internal_IEnumerable_1_JToken_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr4) : null;
				}
			}

			// Token: 0x06001F30 RID: 7984 RVA: 0x0000F5AC File Offset: 0x0000D7AC
			public __c__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008BA RID: 2234
			// (get) Token: 0x06001F31 RID: 7985 RVA: 0x0008EE24 File Offset: 0x0008D024
			// (set) Token: 0x06001F32 RID: 7986 RVA: 0x0000F5B5 File Offset: 0x0000D7B5
			public unsafe static Extensions.__c__2<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extensions.__c__2<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Extensions.__c__2<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extensions.__c__2<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BB RID: 2235
			// (get) Token: 0x06001F33 RID: 7987 RVA: 0x0008EE4C File Offset: 0x0008D04C
			// (set) Token: 0x06001F34 RID: 7988 RVA: 0x0000F5C7 File Offset: 0x0000D7C7
			public unsafe static Func<T, IEnumerable<JToken>> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extensions.__c__2<T>.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerable<JToken>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extensions.__c__2<T>.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016A5 RID: 5797
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016A6 RID: 5798
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040016A7 RID: 5799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016A8 RID: 5800
			private static readonly IntPtr NativeMethodInfoPtr__Descendants_b__2_0_Internal_IEnumerable_1_JToken_T_0;
		}

		// Token: 0x020001E7 RID: 487
		[ObfuscatedName("Newtonsoft.Json.Linq.Extensions+<>c__3`1")]
		[Serializable]
		public sealed class __c__3<T> : Object where T : JContainer
		{
			// Token: 0x06001F35 RID: 7989 RVA: 0x0008EE74 File Offset: 0x0008D074
			// Note: this type is marked as 'beforefieldinit'.
			static __c__3()
			{
				Il2CppClassPointerStore<Extensions.__c__3<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Extensions>.NativeClassPtr, "<>c__3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions.__c__3<T>>.NativeClassPtr);
				Extensions.__c__3<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c__3<T>>.NativeClassPtr, "<>9");
				Extensions.__c__3<T>.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions.__c__3<T>>.NativeClassPtr, "<>9__3_0");
				Extensions.__c__3<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__3<T>>.NativeClassPtr, 100666115);
				Extensions.__c__3<T>.NativeMethodInfoPtr__DescendantsAndSelf_b__3_0_Internal_IEnumerable_1_JToken_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions.__c__3<T>>.NativeClassPtr, 100666116);
			}

			// Token: 0x06001F36 RID: 7990 RVA: 0x0008EF2C File Offset: 0x0008D12C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Extensions.__c__3<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__3<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F37 RID: 7991 RVA: 0x0008EF68 File Offset: 0x0008D168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755988, XrefRangeEnd = 755990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<JToken> _DescendantsAndSelf_b__3_0(T j)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = j;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref j;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Extensions.__c__3<T>.NativeMethodInfoPtr__DescendantsAndSelf_b__3_0_Internal_IEnumerable_1_JToken_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr4) : null;
				}
			}

			// Token: 0x06001F38 RID: 7992 RVA: 0x0000F5D9 File Offset: 0x0000D7D9
			public __c__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008BC RID: 2236
			// (get) Token: 0x06001F39 RID: 7993 RVA: 0x0008EFF0 File Offset: 0x0008D1F0
			// (set) Token: 0x06001F3A RID: 7994 RVA: 0x0000F5E2 File Offset: 0x0000D7E2
			public unsafe static Extensions.__c__3<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extensions.__c__3<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Extensions.__c__3<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extensions.__c__3<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BD RID: 2237
			// (get) Token: 0x06001F3B RID: 7995 RVA: 0x0008F018 File Offset: 0x0008D218
			// (set) Token: 0x06001F3C RID: 7996 RVA: 0x0000F5F4 File Offset: 0x0000D7F4
			public unsafe static Func<T, IEnumerable<JToken>> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Extensions.__c__3<T>.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerable<JToken>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Extensions.__c__3<T>.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016A9 RID: 5801
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040016AA RID: 5802
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040016AB RID: 5803
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040016AC RID: 5804
			private static readonly IntPtr NativeMethodInfoPtr__DescendantsAndSelf_b__3_0_Internal_IEnumerable_1_JToken_T_0;
		}

		// Token: 0x020001E8 RID: 488
		[ObfuscatedName("Newtonsoft.Json.Linq.Extensions+<Convert>d__14`2")]
		public sealed class _Convert_d__14<T, U> : Object where T : JToken
		{
			// Token: 0x06001F3D RID: 7997 RVA: 0x0008F040 File Offset: 0x0008D240
			// Note: this type is marked as 'beforefieldinit'.
			static _Convert_d__14()
			{
				Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Extensions>.NativeClassPtr, "<Convert>d__14`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr);
				Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, "<>1__state");
				Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, "<>2__current");
				Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, "<>l__initialThreadId");
				Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, "source");
				Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, "<>3__source");
				Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, "<>7__wrap1");
				Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, 100666117);
				Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, 100666118);
				Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, 100666119);
				Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, 100666120);
				Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_U__get_Current_Private_Virtual_Final_New_get_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, 100666121);
				Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, 100666122);
				Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, 100666123);
				Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_U__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, 100666124);
				Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr, 100666125);
			}

			// Token: 0x06001F3E RID: 7998 RVA: 0x0008F1E4 File Offset: 0x0008D3E4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Convert_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Extensions._Convert_d__14<T, U>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F3F RID: 7999 RVA: 0x0008F22C File Offset: 0x0008D42C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755990, XrefRangeEnd = 755995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F40 RID: 8000 RVA: 0x0008F260 File Offset: 0x0008D460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755995, XrefRangeEnd = 756016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001F41 RID: 8001 RVA: 0x0008F29C File Offset: 0x0008D49C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756016, XrefRangeEnd = 756019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008C4 RID: 2244
			// (get) Token: 0x06001F42 RID: 8002 RVA: 0x0008F2D0 File Offset: 0x0008D4D0
			public unsafe U System.Collections.Generic.IEnumerator<U>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_U__get_Current_Private_Virtual_Final_New_get_U_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<U>(intPtr, false, true);
				}
			}

			// Token: 0x06001F43 RID: 8003 RVA: 0x0008F30C File Offset: 0x0008D50C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008C5 RID: 2245
			// (get) Token: 0x06001F44 RID: 8004 RVA: 0x0008F340 File Offset: 0x0008D540
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F45 RID: 8005 RVA: 0x0008F380 File Offset: 0x0008D580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<U> System_Collections_Generic_IEnumerable_U__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_U__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_U_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<U>>(intPtr3) : null;
			}

			// Token: 0x06001F46 RID: 8006 RVA: 0x0008F3C0 File Offset: 0x0008D5C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756019, XrefRangeEnd = 756026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Convert_d__14<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001F47 RID: 8007 RVA: 0x0000F606 File Offset: 0x0000D806
			public _Convert_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008BE RID: 2238
			// (get) Token: 0x06001F48 RID: 8008 RVA: 0x0008F400 File Offset: 0x0008D600
			// (set) Token: 0x06001F49 RID: 8009 RVA: 0x0000F60F File Offset: 0x0000D80F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008BF RID: 2239
			// (get) Token: 0x06001F4A RID: 8010 RVA: 0x0008F428 File Offset: 0x0008D628
			// (set) Token: 0x06001F4B RID: 8011 RVA: 0x0008F450 File Offset: 0x0008D650
			public unsafe U __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<U>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(U);
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

			// Token: 0x170008C0 RID: 2240
			// (get) Token: 0x06001F4C RID: 8012 RVA: 0x0008F4F8 File Offset: 0x0008D6F8
			// (set) Token: 0x06001F4D RID: 8013 RVA: 0x0000F62A File Offset: 0x0000D82A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170008C1 RID: 2241
			// (get) Token: 0x06001F4E RID: 8014 RVA: 0x0008F520 File Offset: 0x0008D720
			// (set) Token: 0x06001F4F RID: 8015 RVA: 0x0000F645 File Offset: 0x0000D845
			public unsafe IEnumerable<T> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C2 RID: 2242
			// (get) Token: 0x06001F50 RID: 8016 RVA: 0x0008F550 File Offset: 0x0008D750
			// (set) Token: 0x06001F51 RID: 8017 RVA: 0x0000F664 File Offset: 0x0000D864
			public unsafe IEnumerable<T> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C3 RID: 2243
			// (get) Token: 0x06001F52 RID: 8018 RVA: 0x0008F580 File Offset: 0x0008D780
			// (set) Token: 0x06001F53 RID: 8019 RVA: 0x0000F683 File Offset: 0x0000D883
			public unsafe IEnumerator<T> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Convert_d__14<T, U>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016AD RID: 5805
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016AE RID: 5806
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016AF RID: 5807
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040016B0 RID: 5808
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040016B1 RID: 5809
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x040016B2 RID: 5810
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040016B3 RID: 5811
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016B4 RID: 5812
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016B5 RID: 5813
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016B6 RID: 5814
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040016B7 RID: 5815
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_U__get_Current_Private_Virtual_Final_New_get_U_0;

			// Token: 0x040016B8 RID: 5816
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016B9 RID: 5817
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016BA RID: 5818
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_U__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_U_0;

			// Token: 0x040016BB RID: 5819
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020001E9 RID: 489
		[ObfuscatedName("Newtonsoft.Json.Linq.Extensions+<Values>d__11`2")]
		public sealed class _Values_d__11<T, U> : Object where T : JToken
		{
			// Token: 0x06001F54 RID: 8020 RVA: 0x0008F5B0 File Offset: 0x0008D7B0
			// Note: this type is marked as 'beforefieldinit'.
			static _Values_d__11()
			{
				Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Extensions>.NativeClassPtr, "<Values>d__11`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr);
				Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, "<>1__state");
				Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, "<>2__current");
				Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, "<>l__initialThreadId");
				Extensions._Values_d__11<T, U>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, "source");
				Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, "<>3__source");
				Extensions._Values_d__11<T, U>.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, "key");
				Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___3__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, "<>3__key");
				Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, "<>7__wrap1");
				Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, "<>7__wrap2");
				Extensions._Values_d__11<T, U>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, 100666126);
				Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, 100666127);
				Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, 100666128);
				Extensions._Values_d__11<T, U>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, 100666129);
				Extensions._Values_d__11<T, U>.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, 100666130);
				Extensions._Values_d__11<T, U>.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, 100666131);
				Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_U__get_Current_Private_Virtual_Final_New_get_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, 100666132);
				Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, 100666133);
				Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, 100666134);
				Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_U__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, 100666135);
				Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr, 100666136);
			}

			// Token: 0x06001F55 RID: 8021 RVA: 0x0008F7B8 File Offset: 0x0008D9B8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Values_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Extensions._Values_d__11<T, U>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Values_d__11<T, U>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F56 RID: 8022 RVA: 0x0008F800 File Offset: 0x0008DA00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756026, XrefRangeEnd = 756046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F57 RID: 8023 RVA: 0x0008F834 File Offset: 0x0008DA34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756046, XrefRangeEnd = 756107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001F58 RID: 8024 RVA: 0x0008F870 File Offset: 0x0008DA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756107, XrefRangeEnd = 756110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Values_d__11<T, U>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F59 RID: 8025 RVA: 0x0008F8A4 File Offset: 0x0008DAA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756110, XrefRangeEnd = 756113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Values_d__11<T, U>.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F5A RID: 8026 RVA: 0x0008F8D8 File Offset: 0x0008DAD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756113, XrefRangeEnd = 756116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Values_d__11<T, U>.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008CF RID: 2255
			// (get) Token: 0x06001F5B RID: 8027 RVA: 0x0008F90C File Offset: 0x0008DB0C
			public unsafe U System.Collections.Generic.IEnumerator<U>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_U__get_Current_Private_Virtual_Final_New_get_U_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<U>(intPtr, false, true);
				}
			}

			// Token: 0x06001F5C RID: 8028 RVA: 0x0008F948 File Offset: 0x0008DB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008D0 RID: 2256
			// (get) Token: 0x06001F5D RID: 8029 RVA: 0x0008F97C File Offset: 0x0008DB7C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F5E RID: 8030 RVA: 0x0008F9BC File Offset: 0x0008DBBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756116, XrefRangeEnd = 756124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<U> System_Collections_Generic_IEnumerable_U__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_U__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_U_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<U>>(intPtr3) : null;
			}

			// Token: 0x06001F5F RID: 8031 RVA: 0x0008F9FC File Offset: 0x0008DBFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756124, XrefRangeEnd = 756132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Extensions._Values_d__11<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001F60 RID: 8032 RVA: 0x0000F6A2 File Offset: 0x0000D8A2
			public _Values_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008C6 RID: 2246
			// (get) Token: 0x06001F61 RID: 8033 RVA: 0x0008FA3C File Offset: 0x0008DC3C
			// (set) Token: 0x06001F62 RID: 8034 RVA: 0x0000F6AB File Offset: 0x0000D8AB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008C7 RID: 2247
			// (get) Token: 0x06001F63 RID: 8035 RVA: 0x0008FA64 File Offset: 0x0008DC64
			// (set) Token: 0x06001F64 RID: 8036 RVA: 0x0008FA8C File Offset: 0x0008DC8C
			public unsafe U __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<U>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(U);
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

			// Token: 0x170008C8 RID: 2248
			// (get) Token: 0x06001F65 RID: 8037 RVA: 0x0008FB34 File Offset: 0x0008DD34
			// (set) Token: 0x06001F66 RID: 8038 RVA: 0x0000F6C6 File Offset: 0x0000D8C6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170008C9 RID: 2249
			// (get) Token: 0x06001F67 RID: 8039 RVA: 0x0008FB5C File Offset: 0x0008DD5C
			// (set) Token: 0x06001F68 RID: 8040 RVA: 0x0000F6E1 File Offset: 0x0000D8E1
			public unsafe IEnumerable<T> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CA RID: 2250
			// (get) Token: 0x06001F69 RID: 8041 RVA: 0x0008FB8C File Offset: 0x0008DD8C
			// (set) Token: 0x06001F6A RID: 8042 RVA: 0x0000F700 File Offset: 0x0000D900
			public unsafe IEnumerable<T> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CB RID: 2251
			// (get) Token: 0x06001F6B RID: 8043 RVA: 0x0008FBBC File Offset: 0x0008DDBC
			// (set) Token: 0x06001F6C RID: 8044 RVA: 0x0000F71F File Offset: 0x0000D91F
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CC RID: 2252
			// (get) Token: 0x06001F6D RID: 8045 RVA: 0x0008FBEC File Offset: 0x0008DDEC
			// (set) Token: 0x06001F6E RID: 8046 RVA: 0x0000F73E File Offset: 0x0000D93E
			public unsafe Object __3__key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___3__key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___3__key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CD RID: 2253
			// (get) Token: 0x06001F6F RID: 8047 RVA: 0x0008FC1C File Offset: 0x0008DE1C
			// (set) Token: 0x06001F70 RID: 8048 RVA: 0x0000F75D File Offset: 0x0000D95D
			public unsafe IEnumerator<T> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CE RID: 2254
			// (get) Token: 0x06001F71 RID: 8049 RVA: 0x0008FC4C File Offset: 0x0008DE4C
			// (set) Token: 0x06001F72 RID: 8050 RVA: 0x0000F77C File Offset: 0x0000D97C
			public unsafe IEnumerator<JToken> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Extensions._Values_d__11<T, U>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016BC RID: 5820
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016BD RID: 5821
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016BE RID: 5822
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040016BF RID: 5823
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040016C0 RID: 5824
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x040016C1 RID: 5825
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040016C2 RID: 5826
			private static readonly IntPtr NativeFieldInfoPtr___3__key;

			// Token: 0x040016C3 RID: 5827
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040016C4 RID: 5828
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040016C5 RID: 5829
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016C6 RID: 5830
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016C7 RID: 5831
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016C8 RID: 5832
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040016C9 RID: 5833
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040016CA RID: 5834
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x040016CB RID: 5835
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_U__get_Current_Private_Virtual_Final_New_get_U_0;

			// Token: 0x040016CC RID: 5836
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016CD RID: 5837
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016CE RID: 5838
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_U__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_U_0;

			// Token: 0x040016CF RID: 5839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020001EA RID: 490
		private sealed class MethodInfoStoreGeneric_Ancestors_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0<T>
		{
			// Token: 0x040016D0 RID: 5840
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Ancestors_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001EB RID: 491
		private sealed class MethodInfoStoreGeneric_AncestorsAndSelf_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0<T>
		{
			// Token: 0x040016D1 RID: 5841
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_AncestorsAndSelf_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001EC RID: 492
		private sealed class MethodInfoStoreGeneric_Descendants_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0<T>
		{
			// Token: 0x040016D2 RID: 5842
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Descendants_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001ED RID: 493
		private sealed class MethodInfoStoreGeneric_DescendantsAndSelf_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0<T>
		{
			// Token: 0x040016D3 RID: 5843
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_DescendantsAndSelf_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001EE RID: 494
		private sealed class MethodInfoStoreGeneric_Values_Public_Static_IEnumerable_1_U_IEnumerable_1_JToken_Object_0<U>
		{
			// Token: 0x040016D4 RID: 5844
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Values_Public_Static_IEnumerable_1_U_IEnumerable_1_JToken_Object_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020001EF RID: 495
		private sealed class MethodInfoStoreGeneric_Values_Public_Static_IEnumerable_1_U_IEnumerable_1_JToken_0<U>
		{
			// Token: 0x040016D5 RID: 5845
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Values_Public_Static_IEnumerable_1_U_IEnumerable_1_JToken_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020001F0 RID: 496
		private sealed class MethodInfoStoreGeneric_Value_Public_Static_U_IEnumerable_1_JToken_0<U>
		{
			// Token: 0x040016D6 RID: 5846
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Value_Public_Static_U_IEnumerable_1_JToken_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)) }))));
		}

		// Token: 0x020001F1 RID: 497
		private sealed class MethodInfoStoreGeneric_Value_Public_Static_U_IEnumerable_1_T_0<T, U>
		{
			// Token: 0x040016D7 RID: 5847
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Value_Public_Static_U_IEnumerable_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x020001F2 RID: 498
		private sealed class MethodInfoStoreGeneric_Values_Internal_Static_IEnumerable_1_U_IEnumerable_1_T_Object_0<T, U>
		{
			// Token: 0x040016D8 RID: 5848
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Values_Internal_Static_IEnumerable_1_U_IEnumerable_1_T_Object_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x020001F3 RID: 499
		private sealed class MethodInfoStoreGeneric_Children_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0<T>
		{
			// Token: 0x040016D9 RID: 5849
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Children_Public_Static_IJEnumerable_1_JToken_IEnumerable_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001F4 RID: 500
		private sealed class MethodInfoStoreGeneric_Children_Public_Static_IEnumerable_1_U_IEnumerable_1_T_0<T, U>
		{
			// Token: 0x040016DA RID: 5850
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Children_Public_Static_IEnumerable_1_U_IEnumerable_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x020001F5 RID: 501
		private sealed class MethodInfoStoreGeneric_Convert_Internal_Static_IEnumerable_1_U_IEnumerable_1_T_0<T, U>
		{
			// Token: 0x040016DB RID: 5851
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Convert_Internal_Static_IEnumerable_1_U_IEnumerable_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x020001F6 RID: 502
		private sealed class MethodInfoStoreGeneric_Convert_Internal_Static_U_T_0<T, U>
		{
			// Token: 0x040016DC RID: 5852
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_Convert_Internal_Static_U_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x020001F7 RID: 503
		private sealed class MethodInfoStoreGeneric_AsJEnumerable_Public_Static_IJEnumerable_1_T_IEnumerable_1_T_0<T>
		{
			// Token: 0x040016DD RID: 5853
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Extensions.NativeMethodInfoPtr_AsJEnumerable_Public_Static_IJEnumerable_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
