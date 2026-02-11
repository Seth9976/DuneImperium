using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Extensions.Logging;
using Il2CppSystem;
using ZLogger;

// Token: 0x02000005 RID: 5
public static class UnityZLoggerShim : Object
{
	// Token: 0x0600000F RID: 15 RVA: 0x00002640 File Offset: 0x00000840
	// Note: this type is marked as 'beforefieldinit'.
	static UnityZLoggerShim()
	{
		Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr = IL2CPP.GetIl2CppClass("Logging.dll", "", "UnityZLoggerShim");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr);
		UnityZLoggerShim.NativeMethodInfoPtr_ZLogDebug_Public_Static_Void_ILogger_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr, 100663301);
		UnityZLoggerShim.NativeMethodInfoPtr_ZLogInformation_Public_Static_Void_ILogger_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr, 100663302);
		UnityZLoggerShim.NativeMethodInfoPtr_ZLogWarning_Public_Static_Void_ILogger_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr, 100663303);
		UnityZLoggerShim.NativeMethodInfoPtr_ZLogError_Public_Static_Void_ILogger_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr, 100663304);
		UnityZLoggerShim.NativeMethodInfoPtr_ZLogInformation_Public_Static_Void_ILogger_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr, 100663305);
		UnityZLoggerShim.NativeMethodInfoPtr_ZLogWarning_Public_Static_Void_ILogger_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr, 100663306);
		UnityZLoggerShim.NativeMethodInfoPtr_ZLogError_Public_Static_Void_ILogger_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr, 100663307);
		UnityZLoggerShim.NativeMethodInfoPtr_ZLogError_Public_Static_Void_ILogger_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr, 100663308);
		UnityZLoggerShim.NativeMethodInfoPtr_ZLogCritical_Public_Static_Void_ILogger_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr, 100663309);
		UnityZLoggerShim.NativeMethodInfoPtr_AddZLoggerUnityDebug_Public_Static_ILoggingBuilder_ILoggingBuilder_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr, 100663310);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002738 File Offset: 0x00000938
	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 1270815, RefRangeEnd = 1270841, XrefRangeStart = 1270811, XrefRangeEnd = 1270815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZLogDebug(this ILogger _, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityZLoggerShim.NativeMethodInfoPtr_ZLogDebug_Public_Static_Void_ILogger_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002780 File Offset: 0x00000980
	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 1270845, RefRangeEnd = 1270881, XrefRangeStart = 1270841, XrefRangeEnd = 1270845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZLogInformation(this ILogger _, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityZLoggerShim.NativeMethodInfoPtr_ZLogInformation_Public_Static_Void_ILogger_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000027C8 File Offset: 0x000009C8
	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1270885, RefRangeEnd = 1270903, XrefRangeStart = 1270881, XrefRangeEnd = 1270885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZLogWarning(this ILogger _, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityZLoggerShim.NativeMethodInfoPtr_ZLogWarning_Public_Static_Void_ILogger_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002810 File Offset: 0x00000A10
	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 1270907, RefRangeEnd = 1270936, XrefRangeStart = 1270903, XrefRangeEnd = 1270907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZLogError(this ILogger _, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityZLoggerShim.NativeMethodInfoPtr_ZLogError_Public_Static_Void_ILogger_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002858 File Offset: 0x00000A58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270936, XrefRangeEnd = 1270945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZLogInformation(this ILogger _, Exception exception, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityZLoggerShim.NativeMethodInfoPtr_ZLogInformation_Public_Static_Void_ILogger_Exception_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000028B4 File Offset: 0x00000AB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270945, XrefRangeEnd = 1270954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZLogWarning(this ILogger _, Exception exception, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityZLoggerShim.NativeMethodInfoPtr_ZLogWarning_Public_Static_Void_ILogger_Exception_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002910 File Offset: 0x00000B10
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1270963, RefRangeEnd = 1270969, XrefRangeStart = 1270954, XrefRangeEnd = 1270963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZLogError(this ILogger _, Exception exception, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityZLoggerShim.NativeMethodInfoPtr_ZLogError_Public_Static_Void_ILogger_Exception_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x0000296C File Offset: 0x00000B6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270969, XrefRangeEnd = 1270978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZLogError(this ILogger _, string message, Exception exception)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityZLoggerShim.NativeMethodInfoPtr_ZLogError_Public_Static_Void_ILogger_String_Exception_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000029C8 File Offset: 0x00000BC8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1270987, RefRangeEnd = 1270989, XrefRangeStart = 1270978, XrefRangeEnd = 1270987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZLogCritical(this ILogger _, Exception exception, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityZLoggerShim.NativeMethodInfoPtr_ZLogCritical_Public_Static_Void_ILogger_Exception_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002A24 File Offset: 0x00000C24
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1271010, RefRangeEnd = 1271012, XrefRangeStart = 1270989, XrefRangeEnd = 1271010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ILoggingBuilder AddZLoggerUnityDebug(this ILoggingBuilder builder, Action<Object> _)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityZLoggerShim.NativeMethodInfoPtr_AddZLoggerUnityDebug_Public_Static_ILoggingBuilder_ILoggingBuilder_Action_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILoggingBuilder>(intPtr3) : null;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000020DE File Offset: 0x000002DE
	public UnityZLoggerShim(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr_ZLogDebug_Public_Static_Void_ILogger_String_0;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_ZLogInformation_Public_Static_Void_ILogger_String_0;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr_ZLogWarning_Public_Static_Void_ILogger_String_0;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeMethodInfoPtr_ZLogError_Public_Static_Void_ILogger_String_0;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeMethodInfoPtr_ZLogInformation_Public_Static_Void_ILogger_Exception_String_0;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeMethodInfoPtr_ZLogWarning_Public_Static_Void_ILogger_Exception_String_0;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeMethodInfoPtr_ZLogError_Public_Static_Void_ILogger_Exception_String_0;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeMethodInfoPtr_ZLogError_Public_Static_Void_ILogger_String_Exception_0;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeMethodInfoPtr_ZLogCritical_Public_Static_Void_ILogger_Exception_String_0;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeMethodInfoPtr_AddZLoggerUnityDebug_Public_Static_ILoggingBuilder_ILoggingBuilder_Action_1_Object_0;

	// Token: 0x0200000C RID: 12
	[ObfuscatedName("UnityZLoggerShim+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00004EC8 File Offset: 0x000030C8
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<UnityZLoggerShim.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityZLoggerShim>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityZLoggerShim.__c>.NativeClassPtr);
			UnityZLoggerShim.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityZLoggerShim.__c>.NativeClassPtr, "<>9");
			UnityZLoggerShim.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityZLoggerShim.__c>.NativeClassPtr, "<>9__9_0");
			UnityZLoggerShim.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityZLoggerShim.__c>.NativeClassPtr, 100663312);
			UnityZLoggerShim.__c.NativeMethodInfoPtr__AddZLoggerUnityDebug_b__9_0_Internal_ZLoggerProviderShim_IServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityZLoggerShim.__c>.NativeClassPtr, 100663313);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004F44 File Offset: 0x00003144
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityZLoggerShim.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityZLoggerShim.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004F80 File Offset: 0x00003180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270807, XrefRangeEnd = 1270811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ZLoggerProviderShim _AddZLoggerUnityDebug_b__9_0(IServiceProvider _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityZLoggerShim.__c.NativeMethodInfoPtr__AddZLoggerUnityDebug_b__9_0_Internal_ZLoggerProviderShim_IServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ZLoggerProviderShim>(intPtr3) : null;
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002282 File Offset: 0x00000482
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00004FD0 File Offset: 0x000031D0
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0000228B File Offset: 0x0000048B
		public unsafe static UnityZLoggerShim.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityZLoggerShim.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityZLoggerShim.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityZLoggerShim.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00004FF8 File Offset: 0x000031F8
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000229D File Offset: 0x0000049D
		public unsafe static Func<IServiceProvider, ZLoggerProviderShim> __9__9_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityZLoggerShim.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IServiceProvider, ZLoggerProviderShim>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityZLoggerShim.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr__AddZLoggerUnityDebug_b__9_0_Internal_ZLoggerProviderShim_IServiceProvider_0;
	}
}
