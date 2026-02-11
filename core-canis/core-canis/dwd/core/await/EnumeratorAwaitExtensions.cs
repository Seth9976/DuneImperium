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
using UnityEngine;
using UnityEngine.Networking;

namespace dwd.core.await
{
	// Token: 0x02000206 RID: 518
	public static class EnumeratorAwaitExtensions : global::Il2CppSystem.Object
	{
		// Token: 0x06001C94 RID: 7316 RVA: 0x00084CEC File Offset: 0x00082EEC
		// Note: this type is marked as 'beforefieldinit'.
		static EnumeratorAwaitExtensions()
		{
			Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.await", "EnumeratorAwaitExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitForSeconds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667848);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitForEndOfFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667849);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitForFixedUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667850);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitForSecondsRealtime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667851);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitUntil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667852);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitWhile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667853);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_AsyncOperation_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667854);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_Object_ResourceRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667855);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_UnityWebRequest_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667856);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_AssetBundle_AssetBundleCreateRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667857);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_Object_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667858);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_T_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667859);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_Object_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667860);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiterReturnVoid_Private_Static_SimpleUnitySafeAwaiter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667861);
			EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiterReturnSelf_Private_Static_SimpleUnitySafeAwaiter_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, 100667862);
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00084E48 File Offset: 0x00083048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885775, XrefRangeEnd = 885776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter GetAwaiter(this WaitForSeconds instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitForSeconds_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter>(intPtr3) : null;
			}
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00084E8C File Offset: 0x0008308C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter GetAwaiter(this WaitForEndOfFrame instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitForEndOfFrame_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter>(intPtr3) : null;
			}
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00084ED0 File Offset: 0x000830D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter GetAwaiter(this WaitForFixedUpdate instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitForFixedUpdate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter>(intPtr3) : null;
			}
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00084F14 File Offset: 0x00083114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter GetAwaiter(this WaitForSecondsRealtime instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitForSecondsRealtime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter>(intPtr3) : null;
			}
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00084F58 File Offset: 0x00083158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter GetAwaiter(this WaitUntil instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitUntil_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter>(intPtr3) : null;
			}
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00084F9C File Offset: 0x0008319C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter GetAwaiter(this WaitWhile instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitWhile_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter>(intPtr3) : null;
			}
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00084FE0 File Offset: 0x000831E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885776, XrefRangeEnd = 885779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter<AsyncOperation> GetAwaiter(this AsyncOperation instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_AsyncOperation_AsyncOperation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<AsyncOperation>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00085024 File Offset: 0x00083224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 885798, RefRangeEnd = 885799, XrefRangeStart = 885779, XrefRangeEnd = 885798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter<global::UnityEngine.Object> GetAwaiter(this ResourceRequest instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_Object_ResourceRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<global::UnityEngine.Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00085068 File Offset: 0x00083268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885799, XrefRangeEnd = 885802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter<UnityWebRequest> GetAwaiter(this UnityWebRequest instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_UnityWebRequest_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<UnityWebRequest>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x000850AC File Offset: 0x000832AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885802, XrefRangeEnd = 885821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter<AssetBundle> GetAwaiter(this AssetBundleCreateRequest instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_AssetBundle_AssetBundleCreateRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<AssetBundle>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x000850F0 File Offset: 0x000832F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885821, XrefRangeEnd = 885840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter<global::UnityEngine.Object> GetAwaiter(this AssetBundleRequest instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_Object_AssetBundleRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<global::UnityEngine.Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00085134 File Offset: 0x00083334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885840, XrefRangeEnd = 885852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter<T> GetAwaiter<T>(this IEnumerator<T> coroutine)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.MethodInfoStoreGeneric_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_T_IEnumerator_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00085178 File Offset: 0x00083378
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 885871, RefRangeEnd = 885877, XrefRangeStart = 885852, XrefRangeEnd = 885871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter<global::Il2CppSystem.Object> GetAwaiter(this IEnumerator coroutine)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_Object_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<global::Il2CppSystem.Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x000851BC File Offset: 0x000833BC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 885894, RefRangeEnd = 885900, XrefRangeStart = 885877, XrefRangeEnd = 885894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter GetAwaiterReturnVoid(global::Il2CppSystem.Object instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiterReturnVoid_Private_Static_SimpleUnitySafeAwaiter_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter>(intPtr3) : null;
			}
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00085200 File Offset: 0x00083400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 885914, RefRangeEnd = 885916, XrefRangeStart = 885900, XrefRangeEnd = 885914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SimpleUnitySafeAwaiter<T> GetAwaiterReturnSelf<T>(T instruction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = instruction;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instruction;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.MethodInfoStoreGeneric_GetAwaiterReturnSelf_Private_Static_SimpleUnitySafeAwaiter_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<T>>(intPtr4) : null;
			}
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0000C45E File Offset: 0x0000A65E
		public EnumeratorAwaitExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitForSeconds_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitForEndOfFrame_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitForFixedUpdate_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitForSecondsRealtime_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitUntil_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_WaitWhile_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_AsyncOperation_AsyncOperation_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_Object_ResourceRequest_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_UnityWebRequest_UnityWebRequest_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_AssetBundle_AssetBundleCreateRequest_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_Object_AssetBundleRequest_0;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_T_IEnumerator_1_T_0;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_Object_IEnumerator_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiterReturnVoid_Private_Static_SimpleUnitySafeAwaiter_Object_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiterReturnSelf_Private_Static_SimpleUnitySafeAwaiter_1_T_T_0;

		// Token: 0x02000392 RID: 914
		public static class InstructionWrappers : global::Il2CppSystem.Object
		{
			// Token: 0x060028F4 RID: 10484 RVA: 0x000AC308 File Offset: 0x000AA508
			// Note: this type is marked as 'beforefieldinit'.
			static InstructionWrappers()
			{
				Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, "InstructionWrappers");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr);
				EnumeratorAwaitExtensions.InstructionWrappers.NativeMethodInfoPtr_ReturnVoid_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr, 100667863);
				EnumeratorAwaitExtensions.InstructionWrappers.NativeMethodInfoPtr_AssetBundleCreateRequest_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_AssetBundle_AssetBundleCreateRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr, 100667864);
				EnumeratorAwaitExtensions.InstructionWrappers.NativeMethodInfoPtr_ReturnSelf_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr, 100667865);
				EnumeratorAwaitExtensions.InstructionWrappers.NativeMethodInfoPtr_AssetBundleRequest_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_Object_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr, 100667866);
				EnumeratorAwaitExtensions.InstructionWrappers.NativeMethodInfoPtr_ResourceRequest_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_Object_ResourceRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr, 100667867);
			}

			// Token: 0x060028F5 RID: 10485 RVA: 0x000AC398 File Offset: 0x000AA598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885664, XrefRangeEnd = 885670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IEnumerator ReturnVoid(SimpleUnitySafeAwaiter awaiter, global::Il2CppSystem.Object instruction)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(awaiter);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers.NativeMethodInfoPtr_ReturnVoid_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060028F6 RID: 10486 RVA: 0x000AC3F0 File Offset: 0x000AA5F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885670, XrefRangeEnd = 885676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IEnumerator AssetBundleCreateRequest(SimpleUnitySafeAwaiter<AssetBundle> awaiter, AssetBundleCreateRequest instruction)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(awaiter);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers.NativeMethodInfoPtr_AssetBundleCreateRequest_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_AssetBundle_AssetBundleCreateRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060028F7 RID: 10487 RVA: 0x000AC448 File Offset: 0x000AA648
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 885682, RefRangeEnd = 885683, XrefRangeStart = 885676, XrefRangeEnd = 885682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IEnumerator ReturnSelf<T>(SimpleUnitySafeAwaiter<T> awaiter, T instruction)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(awaiter);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = instruction;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instruction;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers.MethodInfoStoreGeneric_ReturnSelf_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
			}

			// Token: 0x060028F8 RID: 10488 RVA: 0x000AC4D4 File Offset: 0x000AA6D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885683, XrefRangeEnd = 885689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IEnumerator AssetBundleRequest(SimpleUnitySafeAwaiter<global::UnityEngine.Object> awaiter, AssetBundleRequest instruction)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(awaiter);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers.NativeMethodInfoPtr_AssetBundleRequest_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_Object_AssetBundleRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060028F9 RID: 10489 RVA: 0x000AC52C File Offset: 0x000AA72C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885689, XrefRangeEnd = 885695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IEnumerator ResourceRequest(SimpleUnitySafeAwaiter<global::UnityEngine.Object> awaiter, ResourceRequest instruction)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(awaiter);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers.NativeMethodInfoPtr_ResourceRequest_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_Object_ResourceRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060028FA RID: 10490 RVA: 0x000129E0 File Offset: 0x00010BE0
			public InstructionWrappers(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001BBE RID: 7102
			private static readonly IntPtr NativeMethodInfoPtr_ReturnVoid_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_Object_0;

			// Token: 0x04001BBF RID: 7103
			private static readonly IntPtr NativeMethodInfoPtr_AssetBundleCreateRequest_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_AssetBundle_AssetBundleCreateRequest_0;

			// Token: 0x04001BC0 RID: 7104
			private static readonly IntPtr NativeMethodInfoPtr_ReturnSelf_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_T_T_0;

			// Token: 0x04001BC1 RID: 7105
			private static readonly IntPtr NativeMethodInfoPtr_AssetBundleRequest_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_Object_AssetBundleRequest_0;

			// Token: 0x04001BC2 RID: 7106
			private static readonly IntPtr NativeMethodInfoPtr_ResourceRequest_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_Object_ResourceRequest_0;

			// Token: 0x020003B5 RID: 949
			[ObfuscatedName("dwd.core.await.EnumeratorAwaitExtensions+InstructionWrappers+<AssetBundleCreateRequest>d__1")]
			public sealed class _AssetBundleCreateRequest_d__1 : global::Il2CppSystem.Object
			{
				// Token: 0x060029CF RID: 10703 RVA: 0x000AE9D0 File Offset: 0x000ACBD0
				// Note: this type is marked as 'beforefieldinit'.
				static _AssetBundleCreateRequest_d__1()
				{
					Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr, "<AssetBundleCreateRequest>d__1");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr);
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr, "<>1__state");
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr, "<>2__current");
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeFieldInfoPtr_instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr, "instruction");
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr, "awaiter");
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr, 100667868);
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr, 100667869);
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr, 100667870);
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr, 100667871);
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr, 100667872);
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr, 100667873);
				}

				// Token: 0x060029D0 RID: 10704 RVA: 0x000AEAC4 File Offset: 0x000ACCC4
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _AssetBundleCreateRequest_d__1(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060029D1 RID: 10705 RVA: 0x000AEB0C File Offset: 0x000ACD0C
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060029D2 RID: 10706 RVA: 0x000AEB40 File Offset: 0x000ACD40
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885636, XrefRangeEnd = 885638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000BE0 RID: 3040
				// (get) Token: 0x060029D3 RID: 10707 RVA: 0x000AEB7C File Offset: 0x000ACD7C
				public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060029D4 RID: 10708 RVA: 0x000AEBBC File Offset: 0x000ACDBC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885638, XrefRangeEnd = 885643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000BE1 RID: 3041
				// (get) Token: 0x060029D5 RID: 10709 RVA: 0x000AEBF0 File Offset: 0x000ACDF0
				public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060029D6 RID: 10710 RVA: 0x0001317B File Offset: 0x0001137B
				public _AssetBundleCreateRequest_d__1(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000BDC RID: 3036
				// (get) Token: 0x060029D7 RID: 10711 RVA: 0x000AEC30 File Offset: 0x000ACE30
				// (set) Token: 0x060029D8 RID: 10712 RVA: 0x00013184 File Offset: 0x00011384
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000BDD RID: 3037
				// (get) Token: 0x060029D9 RID: 10713 RVA: 0x000AEC58 File Offset: 0x000ACE58
				// (set) Token: 0x060029DA RID: 10714 RVA: 0x0001319F File Offset: 0x0001139F
				public unsafe global::Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000BDE RID: 3038
				// (get) Token: 0x060029DB RID: 10715 RVA: 0x000AEC88 File Offset: 0x000ACE88
				// (set) Token: 0x060029DC RID: 10716 RVA: 0x000131BE File Offset: 0x000113BE
				public unsafe AssetBundleCreateRequest instruction
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeFieldInfoPtr_instruction);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeFieldInfoPtr_instruction), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000BDF RID: 3039
				// (get) Token: 0x060029DD RID: 10717 RVA: 0x000AECB8 File Offset: 0x000ACEB8
				// (set) Token: 0x060029DE RID: 10718 RVA: 0x000131DD File Offset: 0x000113DD
				public unsafe SimpleUnitySafeAwaiter<AssetBundle> awaiter
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeFieldInfoPtr_awaiter);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<AssetBundle>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleCreateRequest_d__1.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001C31 RID: 7217
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04001C32 RID: 7218
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04001C33 RID: 7219
				private static readonly IntPtr NativeFieldInfoPtr_instruction;

				// Token: 0x04001C34 RID: 7220
				private static readonly IntPtr NativeFieldInfoPtr_awaiter;

				// Token: 0x04001C35 RID: 7221
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04001C36 RID: 7222
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001C37 RID: 7223
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04001C38 RID: 7224
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04001C39 RID: 7225
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001C3A RID: 7226
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x020003B6 RID: 950
			[ObfuscatedName("dwd.core.await.EnumeratorAwaitExtensions+InstructionWrappers+<AssetBundleRequest>d__3")]
			public sealed class _AssetBundleRequest_d__3 : global::Il2CppSystem.Object
			{
				// Token: 0x060029DF RID: 10719 RVA: 0x000AECE8 File Offset: 0x000ACEE8
				// Note: this type is marked as 'beforefieldinit'.
				static _AssetBundleRequest_d__3()
				{
					Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr, "<AssetBundleRequest>d__3");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr);
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr, "<>1__state");
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr, "<>2__current");
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeFieldInfoPtr_instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr, "instruction");
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr, "awaiter");
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr, 100667874);
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr, 100667875);
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr, 100667876);
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr, 100667877);
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr, 100667878);
					EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr, 100667879);
				}

				// Token: 0x060029E0 RID: 10720 RVA: 0x000AEDDC File Offset: 0x000ACFDC
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _AssetBundleRequest_d__3(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060029E1 RID: 10721 RVA: 0x000AEE24 File Offset: 0x000AD024
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060029E2 RID: 10722 RVA: 0x000AEE58 File Offset: 0x000AD058
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885643, XrefRangeEnd = 885645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000BE6 RID: 3046
				// (get) Token: 0x060029E3 RID: 10723 RVA: 0x000AEE94 File Offset: 0x000AD094
				public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060029E4 RID: 10724 RVA: 0x000AEED4 File Offset: 0x000AD0D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885645, XrefRangeEnd = 885650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000BE7 RID: 3047
				// (get) Token: 0x060029E5 RID: 10725 RVA: 0x000AEF08 File Offset: 0x000AD108
				public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060029E6 RID: 10726 RVA: 0x000131FC File Offset: 0x000113FC
				public _AssetBundleRequest_d__3(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000BE2 RID: 3042
				// (get) Token: 0x060029E7 RID: 10727 RVA: 0x000AEF48 File Offset: 0x000AD148
				// (set) Token: 0x060029E8 RID: 10728 RVA: 0x00013205 File Offset: 0x00011405
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000BE3 RID: 3043
				// (get) Token: 0x060029E9 RID: 10729 RVA: 0x000AEF70 File Offset: 0x000AD170
				// (set) Token: 0x060029EA RID: 10730 RVA: 0x00013220 File Offset: 0x00011420
				public unsafe global::Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000BE4 RID: 3044
				// (get) Token: 0x060029EB RID: 10731 RVA: 0x000AEFA0 File Offset: 0x000AD1A0
				// (set) Token: 0x060029EC RID: 10732 RVA: 0x0001323F File Offset: 0x0001143F
				public unsafe AssetBundleRequest instruction
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeFieldInfoPtr_instruction);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeFieldInfoPtr_instruction), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000BE5 RID: 3045
				// (get) Token: 0x060029ED RID: 10733 RVA: 0x000AEFD0 File Offset: 0x000AD1D0
				// (set) Token: 0x060029EE RID: 10734 RVA: 0x0001325E File Offset: 0x0001145E
				public unsafe SimpleUnitySafeAwaiter<global::UnityEngine.Object> awaiter
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeFieldInfoPtr_awaiter);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<global::UnityEngine.Object>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._AssetBundleRequest_d__3.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001C3B RID: 7227
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04001C3C RID: 7228
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04001C3D RID: 7229
				private static readonly IntPtr NativeFieldInfoPtr_instruction;

				// Token: 0x04001C3E RID: 7230
				private static readonly IntPtr NativeFieldInfoPtr_awaiter;

				// Token: 0x04001C3F RID: 7231
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04001C40 RID: 7232
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001C41 RID: 7233
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04001C42 RID: 7234
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04001C43 RID: 7235
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001C44 RID: 7236
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x020003B7 RID: 951
			[ObfuscatedName("dwd.core.await.EnumeratorAwaitExtensions+InstructionWrappers+<ResourceRequest>d__4")]
			public sealed class _ResourceRequest_d__4 : global::Il2CppSystem.Object
			{
				// Token: 0x060029EF RID: 10735 RVA: 0x000AF000 File Offset: 0x000AD200
				// Note: this type is marked as 'beforefieldinit'.
				static _ResourceRequest_d__4()
				{
					Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr, "<ResourceRequest>d__4");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr);
					EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr, "<>1__state");
					EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr, "<>2__current");
					EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeFieldInfoPtr_instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr, "instruction");
					EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr, "awaiter");
					EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr, 100667880);
					EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr, 100667881);
					EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr, 100667882);
					EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr, 100667883);
					EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr, 100667884);
					EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr, 100667885);
				}

				// Token: 0x060029F0 RID: 10736 RVA: 0x000AF0F4 File Offset: 0x000AD2F4
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _ResourceRequest_d__4(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060029F1 RID: 10737 RVA: 0x000AF13C File Offset: 0x000AD33C
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060029F2 RID: 10738 RVA: 0x000AF170 File Offset: 0x000AD370
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885650, XrefRangeEnd = 885652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000BEC RID: 3052
				// (get) Token: 0x060029F3 RID: 10739 RVA: 0x000AF1AC File Offset: 0x000AD3AC
				public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060029F4 RID: 10740 RVA: 0x000AF1EC File Offset: 0x000AD3EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885652, XrefRangeEnd = 885657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000BED RID: 3053
				// (get) Token: 0x060029F5 RID: 10741 RVA: 0x000AF220 File Offset: 0x000AD420
				public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060029F6 RID: 10742 RVA: 0x0001327D File Offset: 0x0001147D
				public _ResourceRequest_d__4(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000BE8 RID: 3048
				// (get) Token: 0x060029F7 RID: 10743 RVA: 0x000AF260 File Offset: 0x000AD460
				// (set) Token: 0x060029F8 RID: 10744 RVA: 0x00013286 File Offset: 0x00011486
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000BE9 RID: 3049
				// (get) Token: 0x060029F9 RID: 10745 RVA: 0x000AF288 File Offset: 0x000AD488
				// (set) Token: 0x060029FA RID: 10746 RVA: 0x000132A1 File Offset: 0x000114A1
				public unsafe global::Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000BEA RID: 3050
				// (get) Token: 0x060029FB RID: 10747 RVA: 0x000AF2B8 File Offset: 0x000AD4B8
				// (set) Token: 0x060029FC RID: 10748 RVA: 0x000132C0 File Offset: 0x000114C0
				public unsafe ResourceRequest instruction
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeFieldInfoPtr_instruction);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeFieldInfoPtr_instruction), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000BEB RID: 3051
				// (get) Token: 0x060029FD RID: 10749 RVA: 0x000AF2E8 File Offset: 0x000AD4E8
				// (set) Token: 0x060029FE RID: 10750 RVA: 0x000132DF File Offset: 0x000114DF
				public unsafe SimpleUnitySafeAwaiter<global::UnityEngine.Object> awaiter
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeFieldInfoPtr_awaiter);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<global::UnityEngine.Object>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ResourceRequest_d__4.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001C45 RID: 7237
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04001C46 RID: 7238
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04001C47 RID: 7239
				private static readonly IntPtr NativeFieldInfoPtr_instruction;

				// Token: 0x04001C48 RID: 7240
				private static readonly IntPtr NativeFieldInfoPtr_awaiter;

				// Token: 0x04001C49 RID: 7241
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04001C4A RID: 7242
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001C4B RID: 7243
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04001C4C RID: 7244
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04001C4D RID: 7245
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001C4E RID: 7246
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x020003B8 RID: 952
			[ObfuscatedName("dwd.core.await.EnumeratorAwaitExtensions+InstructionWrappers+<ReturnSelf>d__2`1")]
			public sealed class _ReturnSelf_d__2<T> : global::Il2CppSystem.Object
			{
				// Token: 0x060029FF RID: 10751 RVA: 0x000AF318 File Offset: 0x000AD518
				// Note: this type is marked as 'beforefieldinit'.
				static _ReturnSelf_d__2()
				{
					Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr, "<ReturnSelf>d__2`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr);
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr, "<>1__state");
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr, "<>2__current");
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeFieldInfoPtr_instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr, "instruction");
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr, "awaiter");
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr, 100667886);
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr, 100667887);
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr, 100667888);
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr, 100667889);
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr, 100667890);
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr, 100667891);
				}

				// Token: 0x06002A00 RID: 10752 RVA: 0x000AF448 File Offset: 0x000AD648
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _ReturnSelf_d__2(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002A01 RID: 10753 RVA: 0x000AF490 File Offset: 0x000AD690
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002A02 RID: 10754 RVA: 0x000AF4C4 File Offset: 0x000AD6C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885657, XrefRangeEnd = 885658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000BF2 RID: 3058
				// (get) Token: 0x06002A03 RID: 10755 RVA: 0x000AF500 File Offset: 0x000AD700
				public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06002A04 RID: 10756 RVA: 0x000AF540 File Offset: 0x000AD740
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000BF3 RID: 3059
				// (get) Token: 0x06002A05 RID: 10757 RVA: 0x000AF574 File Offset: 0x000AD774
				public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06002A06 RID: 10758 RVA: 0x000132FE File Offset: 0x000114FE
				public _ReturnSelf_d__2(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000BEE RID: 3054
				// (get) Token: 0x06002A07 RID: 10759 RVA: 0x000AF5B4 File Offset: 0x000AD7B4
				// (set) Token: 0x06002A08 RID: 10760 RVA: 0x00013307 File Offset: 0x00011507
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000BEF RID: 3055
				// (get) Token: 0x06002A09 RID: 10761 RVA: 0x000AF5DC File Offset: 0x000AD7DC
				// (set) Token: 0x06002A0A RID: 10762 RVA: 0x00013322 File Offset: 0x00011522
				public unsafe global::Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000BF0 RID: 3056
				// (get) Token: 0x06002A0B RID: 10763 RVA: 0x000AF60C File Offset: 0x000AD80C
				// (set) Token: 0x06002A0C RID: 10764 RVA: 0x000AF634 File Offset: 0x000AD834
				public unsafe T instruction
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeFieldInfoPtr_instruction);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeFieldInfoPtr_instruction);
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

				// Token: 0x17000BF1 RID: 3057
				// (get) Token: 0x06002A0D RID: 10765 RVA: 0x000AF6DC File Offset: 0x000AD8DC
				// (set) Token: 0x06002A0E RID: 10766 RVA: 0x00013341 File Offset: 0x00011541
				public unsafe SimpleUnitySafeAwaiter<T> awaiter
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeFieldInfoPtr_awaiter);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<T>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnSelf_d__2<T>.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001C4F RID: 7247
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04001C50 RID: 7248
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04001C51 RID: 7249
				private static readonly IntPtr NativeFieldInfoPtr_instruction;

				// Token: 0x04001C52 RID: 7250
				private static readonly IntPtr NativeFieldInfoPtr_awaiter;

				// Token: 0x04001C53 RID: 7251
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04001C54 RID: 7252
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001C55 RID: 7253
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04001C56 RID: 7254
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04001C57 RID: 7255
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001C58 RID: 7256
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x020003B9 RID: 953
			[ObfuscatedName("dwd.core.await.EnumeratorAwaitExtensions+InstructionWrappers+<ReturnVoid>d__0")]
			public sealed class _ReturnVoid_d__0 : global::Il2CppSystem.Object
			{
				// Token: 0x06002A0F RID: 10767 RVA: 0x000AF70C File Offset: 0x000AD90C
				// Note: this type is marked as 'beforefieldinit'.
				static _ReturnVoid_d__0()
				{
					Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr, "<ReturnVoid>d__0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr);
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr, "<>1__state");
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr, "<>2__current");
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeFieldInfoPtr_instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr, "instruction");
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr, "awaiter");
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr, 100667892);
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr, 100667893);
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr, 100667894);
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr, 100667895);
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr, 100667896);
					EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr, 100667897);
				}

				// Token: 0x06002A10 RID: 10768 RVA: 0x000AF800 File Offset: 0x000ADA00
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _ReturnVoid_d__0(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002A11 RID: 10769 RVA: 0x000AF848 File Offset: 0x000ADA48
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002A12 RID: 10770 RVA: 0x000AF87C File Offset: 0x000ADA7C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885658, XrefRangeEnd = 885659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000BF8 RID: 3064
				// (get) Token: 0x06002A13 RID: 10771 RVA: 0x000AF8B8 File Offset: 0x000ADAB8
				public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06002A14 RID: 10772 RVA: 0x000AF8F8 File Offset: 0x000ADAF8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885659, XrefRangeEnd = 885664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000BF9 RID: 3065
				// (get) Token: 0x06002A15 RID: 10773 RVA: 0x000AF92C File Offset: 0x000ADB2C
				public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06002A16 RID: 10774 RVA: 0x00013360 File Offset: 0x00011560
				public _ReturnVoid_d__0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000BF4 RID: 3060
				// (get) Token: 0x06002A17 RID: 10775 RVA: 0x000AF96C File Offset: 0x000ADB6C
				// (set) Token: 0x06002A18 RID: 10776 RVA: 0x00013369 File Offset: 0x00011569
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000BF5 RID: 3061
				// (get) Token: 0x06002A19 RID: 10777 RVA: 0x000AF994 File Offset: 0x000ADB94
				// (set) Token: 0x06002A1A RID: 10778 RVA: 0x00013384 File Offset: 0x00011584
				public unsafe global::Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000BF6 RID: 3062
				// (get) Token: 0x06002A1B RID: 10779 RVA: 0x000AF9C4 File Offset: 0x000ADBC4
				// (set) Token: 0x06002A1C RID: 10780 RVA: 0x000133A3 File Offset: 0x000115A3
				public unsafe global::Il2CppSystem.Object instruction
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeFieldInfoPtr_instruction);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeFieldInfoPtr_instruction), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000BF7 RID: 3063
				// (get) Token: 0x06002A1D RID: 10781 RVA: 0x000AF9F4 File Offset: 0x000ADBF4
				// (set) Token: 0x06002A1E RID: 10782 RVA: 0x000133C2 File Offset: 0x000115C2
				public unsafe SimpleUnitySafeAwaiter awaiter
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeFieldInfoPtr_awaiter);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.InstructionWrappers._ReturnVoid_d__0.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001C59 RID: 7257
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04001C5A RID: 7258
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04001C5B RID: 7259
				private static readonly IntPtr NativeFieldInfoPtr_instruction;

				// Token: 0x04001C5C RID: 7260
				private static readonly IntPtr NativeFieldInfoPtr_awaiter;

				// Token: 0x04001C5D RID: 7261
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04001C5E RID: 7262
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001C5F RID: 7263
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04001C60 RID: 7264
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04001C61 RID: 7265
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001C62 RID: 7266
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x020003BA RID: 954
			private sealed class MethodInfoStoreGeneric_ReturnSelf_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_T_T_0<T>
			{
				// Token: 0x04001C63 RID: 7267
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumeratorAwaitExtensions.InstructionWrappers.NativeMethodInfoPtr_ReturnSelf_Public_Static_IEnumerator_SimpleUnitySafeAwaiter_1_T_T_0, Il2CppClassPointerStore<EnumeratorAwaitExtensions.InstructionWrappers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000393 RID: 915
		[ObfuscatedName("dwd.core.await.EnumeratorAwaitExtensions+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060028FB RID: 10491 RVA: 0x000AC584 File Offset: 0x000AA784
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass10_0>.NativeClassPtr);
				EnumeratorAwaitExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass10_0>.NativeClassPtr, "awaiter");
				EnumeratorAwaitExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass10_0>.NativeClassPtr, "instruction");
				EnumeratorAwaitExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass10_0>.NativeClassPtr, 100667898);
				EnumeratorAwaitExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass10_0>.NativeClassPtr, 100667899);
			}

			// Token: 0x060028FC RID: 10492 RVA: 0x000AC600 File Offset: 0x000AA800
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028FD RID: 10493 RVA: 0x000AC63C File Offset: 0x000AA83C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885695, XrefRangeEnd = 885702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetAwaiter_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass10_0.NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028FE RID: 10494 RVA: 0x000129E9 File Offset: 0x00010BE9
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BA2 RID: 2978
			// (get) Token: 0x060028FF RID: 10495 RVA: 0x000AC670 File Offset: 0x000AA870
			// (set) Token: 0x06002900 RID: 10496 RVA: 0x000129F2 File Offset: 0x00010BF2
			public unsafe SimpleUnitySafeAwaiter<AssetBundle> awaiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_awaiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<AssetBundle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA3 RID: 2979
			// (get) Token: 0x06002901 RID: 10497 RVA: 0x000AC6A0 File Offset: 0x000AA8A0
			// (set) Token: 0x06002902 RID: 10498 RVA: 0x00012A11 File Offset: 0x00010C11
			public unsafe AssetBundleCreateRequest instruction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_instruction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleCreateRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass10_0.NativeFieldInfoPtr_instruction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BC3 RID: 7107
			private static readonly IntPtr NativeFieldInfoPtr_awaiter;

			// Token: 0x04001BC4 RID: 7108
			private static readonly IntPtr NativeFieldInfoPtr_instruction;

			// Token: 0x04001BC5 RID: 7109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BC6 RID: 7110
			private static readonly IntPtr NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0;
		}

		// Token: 0x02000394 RID: 916
		[ObfuscatedName("dwd.core.await.EnumeratorAwaitExtensions+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002903 RID: 10499 RVA: 0x000AC6D0 File Offset: 0x000AA8D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass11_0>.NativeClassPtr);
				EnumeratorAwaitExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass11_0>.NativeClassPtr, "awaiter");
				EnumeratorAwaitExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass11_0>.NativeClassPtr, "instruction");
				EnumeratorAwaitExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass11_0>.NativeClassPtr, 100667900);
				EnumeratorAwaitExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass11_0>.NativeClassPtr, 100667901);
			}

			// Token: 0x06002904 RID: 10500 RVA: 0x000AC74C File Offset: 0x000AA94C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002905 RID: 10501 RVA: 0x000AC788 File Offset: 0x000AA988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885702, XrefRangeEnd = 885709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetAwaiter_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass11_0.NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002906 RID: 10502 RVA: 0x00012A30 File Offset: 0x00010C30
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BA4 RID: 2980
			// (get) Token: 0x06002907 RID: 10503 RVA: 0x000AC7BC File Offset: 0x000AA9BC
			// (set) Token: 0x06002908 RID: 10504 RVA: 0x00012A39 File Offset: 0x00010C39
			public unsafe SimpleUnitySafeAwaiter<global::UnityEngine.Object> awaiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_awaiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<global::UnityEngine.Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA5 RID: 2981
			// (get) Token: 0x06002909 RID: 10505 RVA: 0x000AC7EC File Offset: 0x000AA9EC
			// (set) Token: 0x0600290A RID: 10506 RVA: 0x00012A58 File Offset: 0x00010C58
			public unsafe AssetBundleRequest instruction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_instruction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass11_0.NativeFieldInfoPtr_instruction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BC7 RID: 7111
			private static readonly IntPtr NativeFieldInfoPtr_awaiter;

			// Token: 0x04001BC8 RID: 7112
			private static readonly IntPtr NativeFieldInfoPtr_instruction;

			// Token: 0x04001BC9 RID: 7113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BCA RID: 7114
			private static readonly IntPtr NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0;
		}

		// Token: 0x02000395 RID: 917
		[ObfuscatedName("dwd.core.await.EnumeratorAwaitExtensions+<>c__DisplayClass12_0`1")]
		public sealed class __c__DisplayClass12_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x0600290B RID: 10507 RVA: 0x000AC81C File Offset: 0x000AAA1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, "<>c__DisplayClass12_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>>.NativeClassPtr);
				EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>>.NativeClassPtr, "coroutine");
				EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>>.NativeClassPtr, "awaiter");
				EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>>.NativeClassPtr, 100667902);
				EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>.NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>>.NativeClassPtr, 100667903);
			}

			// Token: 0x0600290C RID: 10508 RVA: 0x000AC8D4 File Offset: 0x000AAAD4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600290D RID: 10509 RVA: 0x000AC910 File Offset: 0x000AAB10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885709, XrefRangeEnd = 885712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetAwaiter_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>.NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600290E RID: 10510 RVA: 0x00012A77 File Offset: 0x00010C77
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BA6 RID: 2982
			// (get) Token: 0x0600290F RID: 10511 RVA: 0x000AC944 File Offset: 0x000AAB44
			// (set) Token: 0x06002910 RID: 10512 RVA: 0x00012A80 File Offset: 0x00010C80
			public unsafe IEnumerator<T> coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA7 RID: 2983
			// (get) Token: 0x06002911 RID: 10513 RVA: 0x000AC974 File Offset: 0x000AAB74
			// (set) Token: 0x06002912 RID: 10514 RVA: 0x00012A9F File Offset: 0x00010C9F
			public unsafe SimpleUnitySafeAwaiter<T> awaiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>.NativeFieldInfoPtr_awaiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass12_0<T>.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BCB RID: 7115
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04001BCC RID: 7116
			private static readonly IntPtr NativeFieldInfoPtr_awaiter;

			// Token: 0x04001BCD RID: 7117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BCE RID: 7118
			private static readonly IntPtr NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0;
		}

		// Token: 0x02000396 RID: 918
		[ObfuscatedName("dwd.core.await.EnumeratorAwaitExtensions+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002913 RID: 10515 RVA: 0x000AC9A4 File Offset: 0x000AABA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass13_0>.NativeClassPtr);
				EnumeratorAwaitExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass13_0>.NativeClassPtr, "coroutine");
				EnumeratorAwaitExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass13_0>.NativeClassPtr, "awaiter");
				EnumeratorAwaitExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass13_0>.NativeClassPtr, 100667904);
				EnumeratorAwaitExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass13_0>.NativeClassPtr, 100667905);
			}

			// Token: 0x06002914 RID: 10516 RVA: 0x000ACA20 File Offset: 0x000AAC20
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002915 RID: 10517 RVA: 0x000ACA5C File Offset: 0x000AAC5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885712, XrefRangeEnd = 885719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetAwaiter_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass13_0.NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002916 RID: 10518 RVA: 0x00012ABE File Offset: 0x00010CBE
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BA8 RID: 2984
			// (get) Token: 0x06002917 RID: 10519 RVA: 0x000ACA90 File Offset: 0x000AAC90
			// (set) Token: 0x06002918 RID: 10520 RVA: 0x00012AC7 File Offset: 0x00010CC7
			public unsafe IEnumerator coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA9 RID: 2985
			// (get) Token: 0x06002919 RID: 10521 RVA: 0x000ACAC0 File Offset: 0x000AACC0
			// (set) Token: 0x0600291A RID: 10522 RVA: 0x00012AE6 File Offset: 0x00010CE6
			public unsafe SimpleUnitySafeAwaiter<global::Il2CppSystem.Object> awaiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_awaiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<global::Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass13_0.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BCF RID: 7119
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04001BD0 RID: 7120
			private static readonly IntPtr NativeFieldInfoPtr_awaiter;

			// Token: 0x04001BD1 RID: 7121
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BD2 RID: 7122
			private static readonly IntPtr NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0;
		}

		// Token: 0x02000397 RID: 919
		[ObfuscatedName("dwd.core.await.EnumeratorAwaitExtensions+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600291B RID: 10523 RVA: 0x000ACAF0 File Offset: 0x000AACF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass14_0>.NativeClassPtr);
				EnumeratorAwaitExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass14_0>.NativeClassPtr, "awaiter");
				EnumeratorAwaitExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass14_0>.NativeClassPtr, "instruction");
				EnumeratorAwaitExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass14_0>.NativeClassPtr, 100667906);
				EnumeratorAwaitExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__GetAwaiterReturnVoid_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass14_0>.NativeClassPtr, 100667907);
			}

			// Token: 0x0600291C RID: 10524 RVA: 0x000ACB6C File Offset: 0x000AAD6C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600291D RID: 10525 RVA: 0x000ACBA8 File Offset: 0x000AADA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885719, XrefRangeEnd = 885726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetAwaiterReturnVoid_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass14_0.NativeMethodInfoPtr__GetAwaiterReturnVoid_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600291E RID: 10526 RVA: 0x00012B05 File Offset: 0x00010D05
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BAA RID: 2986
			// (get) Token: 0x0600291F RID: 10527 RVA: 0x000ACBDC File Offset: 0x000AADDC
			// (set) Token: 0x06002920 RID: 10528 RVA: 0x00012B0E File Offset: 0x00010D0E
			public unsafe SimpleUnitySafeAwaiter awaiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_awaiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BAB RID: 2987
			// (get) Token: 0x06002921 RID: 10529 RVA: 0x000ACC0C File Offset: 0x000AAE0C
			// (set) Token: 0x06002922 RID: 10530 RVA: 0x00012B2D File Offset: 0x00010D2D
			public unsafe global::Il2CppSystem.Object instruction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_instruction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass14_0.NativeFieldInfoPtr_instruction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BD3 RID: 7123
			private static readonly IntPtr NativeFieldInfoPtr_awaiter;

			// Token: 0x04001BD4 RID: 7124
			private static readonly IntPtr NativeFieldInfoPtr_instruction;

			// Token: 0x04001BD5 RID: 7125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BD6 RID: 7126
			private static readonly IntPtr NativeMethodInfoPtr__GetAwaiterReturnVoid_b__0_Internal_Void_0;
		}

		// Token: 0x02000398 RID: 920
		[ObfuscatedName("dwd.core.await.EnumeratorAwaitExtensions+<>c__DisplayClass15_0`1")]
		public sealed class __c__DisplayClass15_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x06002923 RID: 10531 RVA: 0x000ACC3C File Offset: 0x000AAE3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, "<>c__DisplayClass15_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>>.NativeClassPtr);
				EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>>.NativeClassPtr, "awaiter");
				EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>.NativeFieldInfoPtr_instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>>.NativeClassPtr, "instruction");
				EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>>.NativeClassPtr, 100667908);
				EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>.NativeMethodInfoPtr__GetAwaiterReturnSelf_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>>.NativeClassPtr, 100667909);
			}

			// Token: 0x06002924 RID: 10532 RVA: 0x000ACCF4 File Offset: 0x000AAEF4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002925 RID: 10533 RVA: 0x000ACD30 File Offset: 0x000AAF30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885726, XrefRangeEnd = 885733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetAwaiterReturnSelf_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>.NativeMethodInfoPtr__GetAwaiterReturnSelf_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002926 RID: 10534 RVA: 0x00012B4C File Offset: 0x00010D4C
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BAC RID: 2988
			// (get) Token: 0x06002927 RID: 10535 RVA: 0x000ACD64 File Offset: 0x000AAF64
			// (set) Token: 0x06002928 RID: 10536 RVA: 0x00012B55 File Offset: 0x00010D55
			public unsafe SimpleUnitySafeAwaiter<T> awaiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>.NativeFieldInfoPtr_awaiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BAD RID: 2989
			// (get) Token: 0x06002929 RID: 10537 RVA: 0x000ACD94 File Offset: 0x000AAF94
			// (set) Token: 0x0600292A RID: 10538 RVA: 0x000ACDBC File Offset: 0x000AAFBC
			public unsafe T instruction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>.NativeFieldInfoPtr_instruction);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass15_0<T>.NativeFieldInfoPtr_instruction);
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

			// Token: 0x04001BD7 RID: 7127
			private static readonly IntPtr NativeFieldInfoPtr_awaiter;

			// Token: 0x04001BD8 RID: 7128
			private static readonly IntPtr NativeFieldInfoPtr_instruction;

			// Token: 0x04001BD9 RID: 7129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BDA RID: 7130
			private static readonly IntPtr NativeMethodInfoPtr__GetAwaiterReturnSelf_b__0_Internal_Void_0;
		}

		// Token: 0x02000399 RID: 921
		[ObfuscatedName("dwd.core.await.EnumeratorAwaitExtensions+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600292B RID: 10539 RVA: 0x000ACE64 File Offset: 0x000AB064
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass8_0>.NativeClassPtr);
				EnumeratorAwaitExtensions.__c__DisplayClass8_0.NativeFieldInfoPtr_awaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass8_0>.NativeClassPtr, "awaiter");
				EnumeratorAwaitExtensions.__c__DisplayClass8_0.NativeFieldInfoPtr_instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass8_0>.NativeClassPtr, "instruction");
				EnumeratorAwaitExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass8_0>.NativeClassPtr, 100667910);
				EnumeratorAwaitExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass8_0>.NativeClassPtr, 100667911);
			}

			// Token: 0x0600292C RID: 10540 RVA: 0x000ACEE0 File Offset: 0x000AB0E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumeratorAwaitExtensions.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600292D RID: 10541 RVA: 0x000ACF1C File Offset: 0x000AB11C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885733, XrefRangeEnd = 885775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetAwaiter_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumeratorAwaitExtensions.__c__DisplayClass8_0.NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600292E RID: 10542 RVA: 0x00012B74 File Offset: 0x00010D74
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BAE RID: 2990
			// (get) Token: 0x0600292F RID: 10543 RVA: 0x000ACF50 File Offset: 0x000AB150
			// (set) Token: 0x06002930 RID: 10544 RVA: 0x00012B7D File Offset: 0x00010D7D
			public unsafe SimpleUnitySafeAwaiter<global::UnityEngine.Object> awaiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass8_0.NativeFieldInfoPtr_awaiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleUnitySafeAwaiter<global::UnityEngine.Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass8_0.NativeFieldInfoPtr_awaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BAF RID: 2991
			// (get) Token: 0x06002931 RID: 10545 RVA: 0x000ACF80 File Offset: 0x000AB180
			// (set) Token: 0x06002932 RID: 10546 RVA: 0x00012B9C File Offset: 0x00010D9C
			public unsafe ResourceRequest instruction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass8_0.NativeFieldInfoPtr_instruction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumeratorAwaitExtensions.__c__DisplayClass8_0.NativeFieldInfoPtr_instruction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BDB RID: 7131
			private static readonly IntPtr NativeFieldInfoPtr_awaiter;

			// Token: 0x04001BDC RID: 7132
			private static readonly IntPtr NativeFieldInfoPtr_instruction;

			// Token: 0x04001BDD RID: 7133
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BDE RID: 7134
			private static readonly IntPtr NativeMethodInfoPtr__GetAwaiter_b__0_Internal_Void_0;
		}

		// Token: 0x0200039A RID: 922
		private sealed class MethodInfoStoreGeneric_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_T_IEnumerator_1_T_0<T>
		{
			// Token: 0x04001BDF RID: 7135
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiter_Public_Static_SimpleUnitySafeAwaiter_1_T_IEnumerator_1_T_0, Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200039B RID: 923
		private sealed class MethodInfoStoreGeneric_GetAwaiterReturnSelf_Private_Static_SimpleUnitySafeAwaiter_1_T_T_0<T>
		{
			// Token: 0x04001BE0 RID: 7136
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumeratorAwaitExtensions.NativeMethodInfoPtr_GetAwaiterReturnSelf_Private_Static_SimpleUnitySafeAwaiter_1_T_T_0, Il2CppClassPointerStore<EnumeratorAwaitExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
