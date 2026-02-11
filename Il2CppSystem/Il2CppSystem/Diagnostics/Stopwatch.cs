using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020000AB RID: 171
	public class Stopwatch : Object
	{
		// Token: 0x06000C5E RID: 3166 RVA: 0x0004A0B8 File Offset: 0x000482B8
		// Note: this type is marked as 'beforefieldinit'.
		static Stopwatch()
		{
			Il2CppClassPointerStore<Stopwatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "Stopwatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr);
			Stopwatch.NativeFieldInfoPtr_Frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "Frequency");
			Stopwatch.NativeFieldInfoPtr_IsHighResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "IsHighResolution");
			Stopwatch.NativeFieldInfoPtr_elapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "elapsed");
			Stopwatch.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "started");
			Stopwatch.NativeFieldInfoPtr_is_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, "is_running");
			Stopwatch.NativeMethodInfoPtr_GetTimestamp_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100665062);
			Stopwatch.NativeMethodInfoPtr_StartNew_Public_Static_Stopwatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100665063);
			Stopwatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100665064);
			Stopwatch.NativeMethodInfoPtr_get_Elapsed_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100665065);
			Stopwatch.NativeMethodInfoPtr_get_ElapsedMilliseconds_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100665066);
			Stopwatch.NativeMethodInfoPtr_get_ElapsedTicks_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100665067);
			Stopwatch.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr, 100665068);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0004A1D8 File Offset: 0x000483D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451907, XrefRangeEnd = 451908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetTimestamp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_GetTimestamp_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0004A208 File Offset: 0x00048408
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 451916, RefRangeEnd = 451919, XrefRangeStart = 451908, XrefRangeEnd = 451916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stopwatch StartNew()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_StartNew_Public_Static_Stopwatch_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr3) : null;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0004A23C File Offset: 0x0004843C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stopwatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stopwatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0004A278 File Offset: 0x00048478
		public unsafe TimeSpan Elapsed
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 451943, RefRangeEnd = 451947, XrefRangeStart = 451919, XrefRangeEnd = 451943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_Elapsed_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x0004A2B4 File Offset: 0x000484B4
		public unsafe long ElapsedMilliseconds
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 451980, RefRangeEnd = 451982, XrefRangeStart = 451947, XrefRangeEnd = 451980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_ElapsedMilliseconds_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0004A2F0 File Offset: 0x000484F0
		public unsafe long ElapsedTicks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451982, XrefRangeEnd = 451986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_get_ElapsedTicks_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0004A32C File Offset: 0x0004852C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 451990, RefRangeEnd = 451993, XrefRangeStart = 451986, XrefRangeEnd = 451990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stopwatch.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x000069F6 File Offset: 0x00004BF6
		public Stopwatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x0004A360 File Offset: 0x00048560
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x000069FF File Offset: 0x00004BFF
		public unsafe static long Frequency
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Stopwatch.NativeFieldInfoPtr_Frequency, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stopwatch.NativeFieldInfoPtr_Frequency, (void*)(&value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0004A37C File Offset: 0x0004857C
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x00006A0D File Offset: 0x00004C0D
		public unsafe static bool IsHighResolution
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Stopwatch.NativeFieldInfoPtr_IsHighResolution, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stopwatch.NativeFieldInfoPtr_IsHighResolution, (void*)(&value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0004A398 File Offset: 0x00048598
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x00006A1B File Offset: 0x00004C1B
		public unsafe long elapsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_elapsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_elapsed)) = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0004A3C0 File Offset: 0x000485C0
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x00006A36 File Offset: 0x00004C36
		public unsafe long started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0004A3E8 File Offset: 0x000485E8
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x00006A51 File Offset: 0x00004C51
		public unsafe bool is_running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_is_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stopwatch.NativeFieldInfoPtr_is_running)) = value;
			}
		}

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeFieldInfoPtr_Frequency;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeFieldInfoPtr_IsHighResolution;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeFieldInfoPtr_elapsed;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeFieldInfoPtr_is_running;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_GetTimestamp_Public_Static_Int64_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Static_Stopwatch_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_get_Elapsed_Public_get_TimeSpan_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_get_ElapsedMilliseconds_Public_get_Int64_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_get_ElapsedTicks_Public_get_Int64_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;
	}
}
