using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x02000096 RID: 150
	public static class TraceInternal : Object
	{
		// Token: 0x06000AEE RID: 2798 RVA: 0x000459B8 File Offset: 0x00043BB8
		// Note: this type is marked as 'beforefieldinit'.
		static TraceInternal()
		{
			Il2CppClassPointerStore<TraceInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "TraceInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceInternal>.NativeClassPtr);
			TraceInternal.NativeFieldInfoPtr_appName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceInternal>.NativeClassPtr, "appName");
			TraceInternal.NativeFieldInfoPtr_listeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceInternal>.NativeClassPtr, "listeners");
			TraceInternal.NativeFieldInfoPtr_autoFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceInternal>.NativeClassPtr, "autoFlush");
			TraceInternal.NativeFieldInfoPtr_indentLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceInternal>.NativeClassPtr, "indentLevel");
			TraceInternal.NativeFieldInfoPtr_indentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceInternal>.NativeClassPtr, "indentSize");
			TraceInternal.NativeFieldInfoPtr_critSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceInternal>.NativeClassPtr, "critSec");
			TraceInternal.NativeMethodInfoPtr_get_Listeners_Public_Static_get_TraceListenerCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceInternal>.NativeClassPtr, 100664928);
			TraceInternal.NativeMethodInfoPtr_get_AutoFlush_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceInternal>.NativeClassPtr, 100664929);
			TraceInternal.NativeMethodInfoPtr_get_IndentLevel_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceInternal>.NativeClassPtr, 100664930);
			TraceInternal.NativeMethodInfoPtr_get_IndentSize_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceInternal>.NativeClassPtr, 100664931);
			TraceInternal.NativeMethodInfoPtr_InitializeSettings_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceInternal>.NativeClassPtr, 100664932);
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00045AC4 File Offset: 0x00043CC4
		public unsafe static TraceListenerCollection Listeners
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 450858, RefRangeEnd = 450859, XrefRangeStart = 450808, XrefRangeEnd = 450858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceInternal.NativeMethodInfoPtr_get_Listeners_Public_Static_get_TraceListenerCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceListenerCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00045AF8 File Offset: 0x00043CF8
		public unsafe static bool AutoFlush
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450859, XrefRangeEnd = 450864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceInternal.NativeMethodInfoPtr_get_AutoFlush_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00045B28 File Offset: 0x00043D28
		public unsafe static int IndentLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450864, XrefRangeEnd = 450869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceInternal.NativeMethodInfoPtr_get_IndentLevel_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00045B58 File Offset: 0x00043D58
		public unsafe static int IndentSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450869, XrefRangeEnd = 450874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceInternal.NativeMethodInfoPtr_get_IndentSize_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00045B88 File Offset: 0x00043D88
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceInternal.NativeMethodInfoPtr_InitializeSettings_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00005D57 File Offset: 0x00003F57
		public TraceInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00045BB0 File Offset: 0x00043DB0
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00005D60 File Offset: 0x00003F60
		public unsafe static string appName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TraceInternal.NativeFieldInfoPtr_appName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TraceInternal.NativeFieldInfoPtr_appName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00045BD0 File Offset: 0x00043DD0
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00005D72 File Offset: 0x00003F72
		public unsafe static TraceListenerCollection listeners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TraceInternal.NativeFieldInfoPtr_listeners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraceListenerCollection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TraceInternal.NativeFieldInfoPtr_listeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00045BF8 File Offset: 0x00043DF8
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00005D84 File Offset: 0x00003F84
		public unsafe static bool autoFlush
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TraceInternal.NativeFieldInfoPtr_autoFlush, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TraceInternal.NativeFieldInfoPtr_autoFlush, (void*)(&value));
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00045C14 File Offset: 0x00043E14
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00005D92 File Offset: 0x00003F92
		public unsafe static int indentLevel
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TraceInternal.NativeFieldInfoPtr_indentLevel, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TraceInternal.NativeFieldInfoPtr_indentLevel, (void*)(&value));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00045C30 File Offset: 0x00043E30
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00005DA0 File Offset: 0x00003FA0
		public unsafe static int indentSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TraceInternal.NativeFieldInfoPtr_indentSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TraceInternal.NativeFieldInfoPtr_indentSize, (void*)(&value));
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00045C4C File Offset: 0x00043E4C
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00005DAE File Offset: 0x00003FAE
		public unsafe static Object critSec
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TraceInternal.NativeFieldInfoPtr_critSec, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TraceInternal.NativeFieldInfoPtr_critSec, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr_appName;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr_listeners;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr_autoFlush;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeFieldInfoPtr_indentLevel;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeFieldInfoPtr_indentSize;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeFieldInfoPtr_critSec;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_get_Listeners_Public_Static_get_TraceListenerCollection_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoFlush_Public_Static_get_Boolean_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_get_IndentLevel_Public_Static_get_Int32_0;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr_get_IndentSize_Public_Static_get_Int32_0;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSettings_Private_Static_Void_0;
	}
}
