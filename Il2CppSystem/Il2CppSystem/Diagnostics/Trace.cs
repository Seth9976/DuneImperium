using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x02000092 RID: 146
	public sealed class Trace : Object
	{
		// Token: 0x06000ACD RID: 2765 RVA: 0x00045284 File Offset: 0x00043484
		// Note: this type is marked as 'beforefieldinit'.
		static Trace()
		{
			Il2CppClassPointerStore<Trace>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "Trace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Trace>.NativeClassPtr);
			Trace.NativeFieldInfoPtr_correlationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trace>.NativeClassPtr, "correlationManager");
			Trace.NativeMethodInfoPtr_get_Listeners_Public_Static_get_TraceListenerCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trace>.NativeClassPtr, 100664913);
			Trace.NativeMethodInfoPtr_get_AutoFlush_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trace>.NativeClassPtr, 100664914);
			Trace.NativeMethodInfoPtr_get_CorrelationManager_Public_Static_get_CorrelationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trace>.NativeClassPtr, 100664915);
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00045304 File Offset: 0x00043504
		public unsafe static TraceListenerCollection Listeners
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 442792, RefRangeEnd = 442793, XrefRangeStart = 442788, XrefRangeEnd = 442792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trace.NativeMethodInfoPtr_get_Listeners_Public_Static_get_TraceListenerCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceListenerCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00045338 File Offset: 0x00043538
		public unsafe static bool AutoFlush
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 442801, RefRangeEnd = 442802, XrefRangeStart = 442793, XrefRangeEnd = 442801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trace.NativeMethodInfoPtr_get_AutoFlush_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00045368 File Offset: 0x00043568
		public unsafe static CorrelationManager CorrelationManager
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442802, XrefRangeEnd = 442815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trace.NativeMethodInfoPtr_get_CorrelationManager_Public_Static_get_CorrelationManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CorrelationManager>(intPtr3) : null;
			}
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00005CB5 File Offset: 0x00003EB5
		public Trace(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0004539C File Offset: 0x0004359C
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00005CBE File Offset: 0x00003EBE
		public unsafe static CorrelationManager correlationManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Trace.NativeFieldInfoPtr_correlationManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CorrelationManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Trace.NativeFieldInfoPtr_correlationManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeFieldInfoPtr_correlationManager;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_get_Listeners_Public_Static_get_TraceListenerCollection_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoFlush_Public_Static_get_Boolean_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_get_CorrelationManager_Public_Static_get_CorrelationManager_0;
	}
}
