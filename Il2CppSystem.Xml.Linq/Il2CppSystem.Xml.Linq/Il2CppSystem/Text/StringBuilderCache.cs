using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x0200001E RID: 30
	public static class StringBuilderCache : Object
	{
		// Token: 0x06000168 RID: 360 RVA: 0x000087B0 File Offset: 0x000069B0
		// Note: this type is marked as 'beforefieldinit'.
		static StringBuilderCache()
		{
			Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Text", "StringBuilderCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr);
			StringBuilderCache.NativeFieldInfoPtr_t_cachedInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, "t_cachedInstance");
			StringBuilderCache.NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100663539);
			StringBuilderCache.NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100663540);
			StringBuilderCache.NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100663541);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00008830 File Offset: 0x00006A30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238655, RefRangeEnd = 1238657, XrefRangeStart = 1238644, XrefRangeEnd = 1238655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600016A RID: 362 RVA: 0x00008870 File Offset: 0x00006A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238657, XrefRangeEnd = 1238664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600016B RID: 363 RVA: 0x000088A8 File Offset: 0x00006AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238664, XrefRangeEnd = 1238671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600016C RID: 364 RVA: 0x0000275C File Offset: 0x0000095C
		public StringBuilderCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000088E4 File Offset: 0x00006AE4
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002765 File Offset: 0x00000965
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

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_t_cachedInstance;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0;
	}
}
