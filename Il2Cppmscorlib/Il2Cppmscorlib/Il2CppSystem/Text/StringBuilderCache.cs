using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x0200020F RID: 527
	public static class StringBuilderCache : Object
	{
		// Token: 0x0600220B RID: 8715 RVA: 0x000C1308 File Offset: 0x000BF508
		// Note: this type is marked as 'beforefieldinit'.
		static StringBuilderCache()
		{
			Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "StringBuilderCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr);
			StringBuilderCache.NativeFieldInfoPtr_t_cachedInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, "t_cachedInstance");
			StringBuilderCache.NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100669042);
			StringBuilderCache.NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100669043);
			StringBuilderCache.NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100669044);
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x000C1388 File Offset: 0x000BF588
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1366637, RefRangeEnd = 1366669, XrefRangeStart = 1366627, XrefRangeEnd = 1366637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder Acquire(int capacity = 16)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderCache.NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x000C13C8 File Offset: 0x000BF5C8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1366675, RefRangeEnd = 1366686, XrefRangeStart = 1366669, XrefRangeEnd = 1366675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderCache.NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x000C1400 File Offset: 0x000BF600
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1366692, RefRangeEnd = 1366722, XrefRangeStart = 1366686, XrefRangeEnd = 1366692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringAndRelease(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderCache.NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x0000AF40 File Offset: 0x00009140
		public StringBuilderCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x000C143C File Offset: 0x000BF63C
		// (set) Token: 0x06002211 RID: 8721 RVA: 0x0000AF49 File Offset: 0x00009149
		public unsafe static StringBuilder t_cachedInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilderCache.NativeFieldInfoPtr_t_cachedInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilderCache.NativeFieldInfoPtr_t_cachedInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeFieldInfoPtr_t_cachedInstance;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0;

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0;

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0;
	}
}
