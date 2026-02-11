using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace platformCore.scoreboard
{
	// Token: 0x02000008 RID: 8
	public class FlushScoreboardEvents : Command
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00003D00 File Offset: 0x00001F00
		// Note: this type is marked as 'beforefieldinit'.
		static FlushScoreboardEvents()
		{
			Il2CppClassPointerStore<FlushScoreboardEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("platformCore.dll", "platformCore.scoreboard", "FlushScoreboardEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlushScoreboardEvents>.NativeClassPtr);
			FlushScoreboardEvents.NativeFieldInfoPtr_account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents>.NativeClassPtr, "account");
			FlushScoreboardEvents.NativeFieldInfoPtr_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents>.NativeClassPtr, "URL");
			FlushScoreboardEvents.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents>.NativeClassPtr, "Client");
			FlushScoreboardEvents.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlushScoreboardEvents>.NativeClassPtr, 100663323);
			FlushScoreboardEvents.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlushScoreboardEvents>.NativeClassPtr, 100663324);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003D94 File Offset: 0x00001F94
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 998618, RefRangeEnd = 998746, XrefRangeStart = 998618, XrefRangeEnd = 998746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlushScoreboardEvents(string account, string url, string client = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlushScoreboardEvents>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(account);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlushScoreboardEvents.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003E04 File Offset: 0x00002004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249950, XrefRangeEnd = 1249955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlushScoreboardEvents.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002232 File Offset: 0x00000432
		public FlushScoreboardEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00003E50 File Offset: 0x00002050
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0000223B File Offset: 0x0000043B
		public unsafe string account
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents.NativeFieldInfoPtr_account);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents.NativeFieldInfoPtr_account), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003E78 File Offset: 0x00002078
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0000225A File Offset: 0x0000045A
		public unsafe string URL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents.NativeFieldInfoPtr_URL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents.NativeFieldInfoPtr_URL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00003EA0 File Offset: 0x000020A0
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002279 File Offset: 0x00000479
		public unsafe string Client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents.NativeFieldInfoPtr_Client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents.NativeFieldInfoPtr_Client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_account;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_URL;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_Client;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000017 RID: 23
		[ObfuscatedName("platformCore.scoreboard.FlushScoreboardEvents+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06000111 RID: 273 RVA: 0x00006550 File Offset: 0x00004750
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlushScoreboardEvents>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr);
				FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, "<>1__state");
				FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, "<>2__current");
				FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, "<>4__this");
				FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__key_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, "<key>5__2");
				FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__failedPosts_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, "<failedPosts>5__3");
				FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, "<>7__wrap3");
				FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__evt_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, "<evt>5__5");
				FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, "<>7__wrap5");
				FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__score_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, "<score>5__7");
				FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__i_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, "<i>5__8");
				FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__post_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, "<post>5__9");
				FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, 100663325);
				FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, 100663326);
				FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, 100663327);
				FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, 100663328);
				FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, 100663329);
				FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, 100663330);
				FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, 100663331);
				FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr, 100663332);
			}

			// Token: 0x06000112 RID: 274 RVA: 0x000066F8 File Offset: 0x000048F8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlushScoreboardEvents._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000113 RID: 275 RVA: 0x00006740 File Offset: 0x00004940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249818, XrefRangeEnd = 1249831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000114 RID: 276 RVA: 0x00006774 File Offset: 0x00004974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249831, XrefRangeEnd = 1249939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000115 RID: 277 RVA: 0x000067B0 File Offset: 0x000049B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249939, XrefRangeEnd = 1249942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000116 RID: 278 RVA: 0x000067E4 File Offset: 0x000049E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249942, XrefRangeEnd = 1249945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000117 RID: 279 RVA: 0x00006818 File Offset: 0x00004A18
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000118 RID: 280 RVA: 0x00006858 File Offset: 0x00004A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249945, XrefRangeEnd = 1249950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000119 RID: 281 RVA: 0x0000688C File Offset: 0x00004A8C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlushScoreboardEvents._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600011A RID: 282 RVA: 0x00002A1A File Offset: 0x00000C1A
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x0600011B RID: 283 RVA: 0x000068CC File Offset: 0x00004ACC
			// (set) Token: 0x0600011C RID: 284 RVA: 0x00002A23 File Offset: 0x00000C23
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x0600011D RID: 285 RVA: 0x000068F4 File Offset: 0x00004AF4
			// (set) Token: 0x0600011E RID: 286 RVA: 0x00002A3E File Offset: 0x00000C3E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x0600011F RID: 287 RVA: 0x00006924 File Offset: 0x00004B24
			// (set) Token: 0x06000120 RID: 288 RVA: 0x00002A5D File Offset: 0x00000C5D
			public unsafe FlushScoreboardEvents __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlushScoreboardEvents>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000121 RID: 289 RVA: 0x00006954 File Offset: 0x00004B54
			// (set) Token: 0x06000122 RID: 290 RVA: 0x00002A7C File Offset: 0x00000C7C
			public unsafe string _key_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__key_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__key_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000123 RID: 291 RVA: 0x0000697C File Offset: 0x00004B7C
			// (set) Token: 0x06000124 RID: 292 RVA: 0x00002A9B File Offset: 0x00000C9B
			public unsafe List<IEnumerator> _failedPosts_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__failedPosts_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__failedPosts_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000125 RID: 293 RVA: 0x000069AC File Offset: 0x00004BAC
			// (set) Token: 0x06000126 RID: 294 RVA: 0x00002ABA File Offset: 0x00000CBA
			public Dictionary<string, Dictionary<int, int>>.Enumerator __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___7__wrap3);
					return new Dictionary<string, Dictionary<int, int>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<string, Dictionary<int, int>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<string, Dictionary<int, int>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000127 RID: 295 RVA: 0x000069DC File Offset: 0x00004BDC
			// (set) Token: 0x06000128 RID: 296 RVA: 0x00002AE8 File Offset: 0x00000CE8
			public KeyValuePair<string, Dictionary<int, int>> _evt_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__evt_5__5);
					return new KeyValuePair<string, Dictionary<int, int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, Dictionary<int, int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__evt_5__5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, Dictionary<int, int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000129 RID: 297 RVA: 0x00006A0C File Offset: 0x00004C0C
			// (set) Token: 0x0600012A RID: 298 RVA: 0x00002B16 File Offset: 0x00000D16
			public Dictionary<int, int>.Enumerator __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___7__wrap5);
					return new Dictionary<int, int>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<int, int>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr___7__wrap5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<int, int>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x0600012B RID: 299 RVA: 0x00006A3C File Offset: 0x00004C3C
			// (set) Token: 0x0600012C RID: 300 RVA: 0x00002B44 File Offset: 0x00000D44
			public KeyValuePair<int, int> _score_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__score_5__7);
					return new KeyValuePair<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<int, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__score_5__7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<int, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x0600012D RID: 301 RVA: 0x00006A6C File Offset: 0x00004C6C
			// (set) Token: 0x0600012E RID: 302 RVA: 0x00002B72 File Offset: 0x00000D72
			public unsafe int _i_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__i_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__i_5__8)) = value;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x0600012F RID: 303 RVA: 0x00006A94 File Offset: 0x00004C94
			// (set) Token: 0x06000130 RID: 304 RVA: 0x00002B8D File Offset: 0x00000D8D
			public unsafe PostScoreboardEvent _post_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__post_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostScoreboardEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlushScoreboardEvents._execute_d__4.NativeFieldInfoPtr__post_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400009E RID: 158
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400009F RID: 159
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000A0 RID: 160
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000A1 RID: 161
			private static readonly IntPtr NativeFieldInfoPtr__key_5__2;

			// Token: 0x040000A2 RID: 162
			private static readonly IntPtr NativeFieldInfoPtr__failedPosts_5__3;

			// Token: 0x040000A3 RID: 163
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040000A4 RID: 164
			private static readonly IntPtr NativeFieldInfoPtr__evt_5__5;

			// Token: 0x040000A5 RID: 165
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x040000A6 RID: 166
			private static readonly IntPtr NativeFieldInfoPtr__score_5__7;

			// Token: 0x040000A7 RID: 167
			private static readonly IntPtr NativeFieldInfoPtr__i_5__8;

			// Token: 0x040000A8 RID: 168
			private static readonly IntPtr NativeFieldInfoPtr__post_5__9;

			// Token: 0x040000A9 RID: 169
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000AA RID: 170
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000AB RID: 171
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000AC RID: 172
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040000AD RID: 173
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040000AE RID: 174
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000AF RID: 175
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000B0 RID: 176
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
