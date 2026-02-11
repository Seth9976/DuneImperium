using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.util
{
	// Token: 0x0200008C RID: 140
	public class ErrorLogCounter : LogProcessor
	{
		// Token: 0x06000A13 RID: 2579 RVA: 0x0003A05C File Offset: 0x0003825C
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorLogCounter()
		{
			Il2CppClassPointerStore<ErrorLogCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "ErrorLogCounter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorLogCounter>.NativeClassPtr);
			ErrorLogCounter.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorLogCounter>.NativeClassPtr, "display");
			ErrorLogCounter.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorLogCounter>.NativeClassPtr, "count");
			ErrorLogCounter.NativeFieldInfoPtr_hideCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorLogCounter>.NativeClassPtr, "hideCoroutine");
			ErrorLogCounter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogCounter>.NativeClassPtr, 100664697);
			ErrorLogCounter.NativeMethodInfoPtr_ProcessLog_Public_Virtual_Void_String_String_byref_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogCounter>.NativeClassPtr, 100664698);
			ErrorLogCounter.NativeMethodInfoPtr_OnError_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogCounter>.NativeClassPtr, 100664699);
			ErrorLogCounter.NativeMethodInfoPtr_Hide_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogCounter>.NativeClassPtr, 100664700);
			ErrorLogCounter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogCounter>.NativeClassPtr, 100664701);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0003A12C File Offset: 0x0003832C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862572, XrefRangeEnd = 862575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorLogCounter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0003A160 File Offset: 0x00038360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862575, XrefRangeEnd = 862586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessLog(string logString, string stackTrace, ref LogType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ErrorLogCounter.NativeMethodInfoPtr_ProcessLog_Public_Virtual_Void_String_String_byref_LogType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0003A1D0 File Offset: 0x000383D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862586, XrefRangeEnd = 862598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorLogCounter.NativeMethodInfoPtr_OnError_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0003A204 File Offset: 0x00038404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862598, XrefRangeEnd = 862603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorLogCounter.NativeMethodInfoPtr_Hide_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0003A244 File Offset: 0x00038444
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorLogCounter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorLogCounter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorLogCounter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000058D5 File Offset: 0x00003AD5
		public ErrorLogCounter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0003A280 File Offset: 0x00038480
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x000058DE File Offset: 0x00003ADE
		public unsafe Text display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorLogCounter.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorLogCounter.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0003A2B0 File Offset: 0x000384B0
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x000058FD File Offset: 0x00003AFD
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorLogCounter.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorLogCounter.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0003A2D8 File Offset: 0x000384D8
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00005918 File Offset: 0x00003B18
		public unsafe Coroutine hideCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorLogCounter.NativeFieldInfoPtr_hideCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorLogCounter.NativeFieldInfoPtr_hideCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeFieldInfoPtr_hideCoroutine;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_ProcessLog_Public_Virtual_Void_String_String_byref_LogType_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_OnError_Private_Void_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Private_IEnumerator_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200028B RID: 651
		[ObfuscatedName("dwd.core.util.ErrorLogCounter+<Hide>d__6")]
		public sealed class _Hide_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06001F42 RID: 8002 RVA: 0x0008E204 File Offset: 0x0008C404
			// Note: this type is marked as 'beforefieldinit'.
			static _Hide_d__6()
			{
				Il2CppClassPointerStore<ErrorLogCounter._Hide_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ErrorLogCounter>.NativeClassPtr, "<Hide>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorLogCounter._Hide_d__6>.NativeClassPtr);
				ErrorLogCounter._Hide_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorLogCounter._Hide_d__6>.NativeClassPtr, "<>1__state");
				ErrorLogCounter._Hide_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorLogCounter._Hide_d__6>.NativeClassPtr, "<>2__current");
				ErrorLogCounter._Hide_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorLogCounter._Hide_d__6>.NativeClassPtr, "<>4__this");
				ErrorLogCounter._Hide_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogCounter._Hide_d__6>.NativeClassPtr, 100664702);
				ErrorLogCounter._Hide_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogCounter._Hide_d__6>.NativeClassPtr, 100664703);
				ErrorLogCounter._Hide_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogCounter._Hide_d__6>.NativeClassPtr, 100664704);
				ErrorLogCounter._Hide_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogCounter._Hide_d__6>.NativeClassPtr, 100664705);
				ErrorLogCounter._Hide_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogCounter._Hide_d__6>.NativeClassPtr, 100664706);
				ErrorLogCounter._Hide_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorLogCounter._Hide_d__6>.NativeClassPtr, 100664707);
			}

			// Token: 0x06001F43 RID: 8003 RVA: 0x0008E2E4 File Offset: 0x0008C4E4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Hide_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorLogCounter._Hide_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorLogCounter._Hide_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F44 RID: 8004 RVA: 0x0008E32C File Offset: 0x0008C52C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorLogCounter._Hide_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F45 RID: 8005 RVA: 0x0008E360 File Offset: 0x0008C560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862562, XrefRangeEnd = 862567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorLogCounter._Hide_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000897 RID: 2199
			// (get) Token: 0x06001F46 RID: 8006 RVA: 0x0008E39C File Offset: 0x0008C59C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorLogCounter._Hide_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F47 RID: 8007 RVA: 0x0008E3DC File Offset: 0x0008C5DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862567, XrefRangeEnd = 862572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorLogCounter._Hide_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000898 RID: 2200
			// (get) Token: 0x06001F48 RID: 8008 RVA: 0x0008E410 File Offset: 0x0008C610
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorLogCounter._Hide_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F49 RID: 8009 RVA: 0x0000D50B File Offset: 0x0000B70B
			public _Hide_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000894 RID: 2196
			// (get) Token: 0x06001F4A RID: 8010 RVA: 0x0008E450 File Offset: 0x0008C650
			// (set) Token: 0x06001F4B RID: 8011 RVA: 0x0000D514 File Offset: 0x0000B714
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorLogCounter._Hide_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorLogCounter._Hide_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000895 RID: 2197
			// (get) Token: 0x06001F4C RID: 8012 RVA: 0x0008E478 File Offset: 0x0008C678
			// (set) Token: 0x06001F4D RID: 8013 RVA: 0x0000D52F File Offset: 0x0000B72F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorLogCounter._Hide_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorLogCounter._Hide_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000896 RID: 2198
			// (get) Token: 0x06001F4E RID: 8014 RVA: 0x0008E4A8 File Offset: 0x0008C6A8
			// (set) Token: 0x06001F4F RID: 8015 RVA: 0x0000D54E File Offset: 0x0000B74E
			public unsafe ErrorLogCounter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorLogCounter._Hide_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ErrorLogCounter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorLogCounter._Hide_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015F6 RID: 5622
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015F7 RID: 5623
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015F8 RID: 5624
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015F9 RID: 5625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015FA RID: 5626
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015FB RID: 5627
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015FC RID: 5628
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015FD RID: 5629
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015FE RID: 5630
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
