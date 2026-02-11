using System;
using boardgames.menus.prompts;
using dwd.core.account;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.canis.dbg_client.commands
{
	// Token: 0x02000077 RID: 119
	public class RequestEULAIFNeeded : Command
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x0002B760 File Offset: 0x00029960
		// Note: this type is marked as 'beforefieldinit'.
		static RequestEULAIFNeeded()
		{
			Il2CppClassPointerStore<RequestEULAIFNeeded>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.commands", "RequestEULAIFNeeded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestEULAIFNeeded>.NativeClassPtr);
			RequestEULAIFNeeded.NativeFieldInfoPtr_accountProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestEULAIFNeeded>.NativeClassPtr, "accountProvider");
			RequestEULAIFNeeded.NativeFieldInfoPtr__silent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestEULAIFNeeded>.NativeClassPtr, "_silent");
			RequestEULAIFNeeded.NativeMethodInfoPtr_get_WaitingForEULA_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded>.NativeClassPtr, 100663953);
			RequestEULAIFNeeded.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded>.NativeClassPtr, 100663954);
			RequestEULAIFNeeded.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded>.NativeClassPtr, 100663955);
			RequestEULAIFNeeded.NativeMethodInfoPtr_SetMarketingOptOut_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded>.NativeClassPtr, 100663956);
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0002B808 File Offset: 0x00029A08
		public unsafe bool WaitingForEULA
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500736, XrefRangeEnd = 500747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded.NativeMethodInfoPtr_get_WaitingForEULA_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0002B844 File Offset: 0x00029A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500747, XrefRangeEnd = 500748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestEULAIFNeeded(bool silent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestEULAIFNeeded>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref silent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0002B88C File Offset: 0x00029A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500748, XrefRangeEnd = 500753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestEULAIFNeeded.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0002B8D8 File Offset: 0x00029AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500753, XrefRangeEnd = 500757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetMarketingOptOut(bool updatesRequested)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updatesRequested;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded.NativeMethodInfoPtr_SetMarketingOptOut_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00004001 File Offset: 0x00002201
		public RequestEULAIFNeeded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0002B924 File Offset: 0x00029B24
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x0000400A File Offset: 0x0000220A
		public unsafe AccountProvider accountProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded.NativeFieldInfoPtr_accountProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded.NativeFieldInfoPtr_accountProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0002B954 File Offset: 0x00029B54
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00004029 File Offset: 0x00002229
		public unsafe bool _silent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded.NativeFieldInfoPtr__silent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded.NativeFieldInfoPtr__silent)) = value;
			}
		}

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr_accountProvider;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr__silent;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_get_WaitingForEULA_Public_get_Boolean_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_SetMarketingOptOut_Private_IEnumerator_Boolean_0;

		// Token: 0x020002F2 RID: 754
		[ObfuscatedName("dwd.canis.dbg_client.commands.RequestEULAIFNeeded+<SetMarketingOptOut>d__6")]
		public sealed class _SetMarketingOptOut_d__6 : Object
		{
			// Token: 0x06002391 RID: 9105 RVA: 0x00092DE8 File Offset: 0x00090FE8
			// Note: this type is marked as 'beforefieldinit'.
			static _SetMarketingOptOut_d__6()
			{
				Il2CppClassPointerStore<RequestEULAIFNeeded._SetMarketingOptOut_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RequestEULAIFNeeded>.NativeClassPtr, "<SetMarketingOptOut>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestEULAIFNeeded._SetMarketingOptOut_d__6>.NativeClassPtr);
				RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestEULAIFNeeded._SetMarketingOptOut_d__6>.NativeClassPtr, "<>1__state");
				RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestEULAIFNeeded._SetMarketingOptOut_d__6>.NativeClassPtr, "<>2__current");
				RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeFieldInfoPtr_updatesRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestEULAIFNeeded._SetMarketingOptOut_d__6>.NativeClassPtr, "updatesRequested");
				RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded._SetMarketingOptOut_d__6>.NativeClassPtr, 100663957);
				RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded._SetMarketingOptOut_d__6>.NativeClassPtr, 100663958);
				RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded._SetMarketingOptOut_d__6>.NativeClassPtr, 100663959);
				RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded._SetMarketingOptOut_d__6>.NativeClassPtr, 100663960);
				RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded._SetMarketingOptOut_d__6>.NativeClassPtr, 100663961);
				RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded._SetMarketingOptOut_d__6>.NativeClassPtr, 100663962);
			}

			// Token: 0x06002392 RID: 9106 RVA: 0x00092EC8 File Offset: 0x000910C8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetMarketingOptOut_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestEULAIFNeeded._SetMarketingOptOut_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002393 RID: 9107 RVA: 0x00092F10 File Offset: 0x00091110
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002394 RID: 9108 RVA: 0x00092F44 File Offset: 0x00091144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500674, XrefRangeEnd = 500719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009AB RID: 2475
			// (get) Token: 0x06002395 RID: 9109 RVA: 0x00092F80 File Offset: 0x00091180
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002396 RID: 9110 RVA: 0x00092FC0 File Offset: 0x000911C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500719, XrefRangeEnd = 500724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009AC RID: 2476
			// (get) Token: 0x06002397 RID: 9111 RVA: 0x00092FF4 File Offset: 0x000911F4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002398 RID: 9112 RVA: 0x00012853 File Offset: 0x00010A53
			public _SetMarketingOptOut_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A8 RID: 2472
			// (get) Token: 0x06002399 RID: 9113 RVA: 0x00093034 File Offset: 0x00091234
			// (set) Token: 0x0600239A RID: 9114 RVA: 0x0001285C File Offset: 0x00010A5C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009A9 RID: 2473
			// (get) Token: 0x0600239B RID: 9115 RVA: 0x0009305C File Offset: 0x0009125C
			// (set) Token: 0x0600239C RID: 9116 RVA: 0x00012877 File Offset: 0x00010A77
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009AA RID: 2474
			// (get) Token: 0x0600239D RID: 9117 RVA: 0x0009308C File Offset: 0x0009128C
			// (set) Token: 0x0600239E RID: 9118 RVA: 0x00012896 File Offset: 0x00010A96
			public unsafe bool updatesRequested
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeFieldInfoPtr_updatesRequested);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._SetMarketingOptOut_d__6.NativeFieldInfoPtr_updatesRequested)) = value;
				}
			}

			// Token: 0x0400165A RID: 5722
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400165B RID: 5723
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400165C RID: 5724
			private static readonly IntPtr NativeFieldInfoPtr_updatesRequested;

			// Token: 0x0400165D RID: 5725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400165E RID: 5726
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400165F RID: 5727
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001660 RID: 5728
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001661 RID: 5729
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001662 RID: 5730
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002F3 RID: 755
		[ObfuscatedName("dwd.canis.dbg_client.commands.RequestEULAIFNeeded+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x0600239F RID: 9119 RVA: 0x000930B4 File Offset: 0x000912B4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RequestEULAIFNeeded>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr);
				RequestEULAIFNeeded._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr, "<>1__state");
				RequestEULAIFNeeded._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr, "<>2__current");
				RequestEULAIFNeeded._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr, "<>4__this");
				RequestEULAIFNeeded._execute_d__5.NativeFieldInfoPtr__eulaPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr, "<eulaPrompt>5__2");
				RequestEULAIFNeeded._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr, 100663963);
				RequestEULAIFNeeded._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr, 100663964);
				RequestEULAIFNeeded._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr, 100663965);
				RequestEULAIFNeeded._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr, 100663966);
				RequestEULAIFNeeded._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr, 100663967);
				RequestEULAIFNeeded._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr, 100663968);
			}

			// Token: 0x060023A0 RID: 9120 RVA: 0x000931A8 File Offset: 0x000913A8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestEULAIFNeeded._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023A1 RID: 9121 RVA: 0x000931F0 File Offset: 0x000913F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023A2 RID: 9122 RVA: 0x00093224 File Offset: 0x00091424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500724, XrefRangeEnd = 500731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009B1 RID: 2481
			// (get) Token: 0x060023A3 RID: 9123 RVA: 0x00093260 File Offset: 0x00091460
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023A4 RID: 9124 RVA: 0x000932A0 File Offset: 0x000914A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500731, XrefRangeEnd = 500736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009B2 RID: 2482
			// (get) Token: 0x060023A5 RID: 9125 RVA: 0x000932D4 File Offset: 0x000914D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestEULAIFNeeded._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023A6 RID: 9126 RVA: 0x000128B1 File Offset: 0x00010AB1
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009AD RID: 2477
			// (get) Token: 0x060023A7 RID: 9127 RVA: 0x00093314 File Offset: 0x00091514
			// (set) Token: 0x060023A8 RID: 9128 RVA: 0x000128BA File Offset: 0x00010ABA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009AE RID: 2478
			// (get) Token: 0x060023A9 RID: 9129 RVA: 0x0009333C File Offset: 0x0009153C
			// (set) Token: 0x060023AA RID: 9130 RVA: 0x000128D5 File Offset: 0x00010AD5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009AF RID: 2479
			// (get) Token: 0x060023AB RID: 9131 RVA: 0x0009336C File Offset: 0x0009156C
			// (set) Token: 0x060023AC RID: 9132 RVA: 0x000128F4 File Offset: 0x00010AF4
			public unsafe RequestEULAIFNeeded __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestEULAIFNeeded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B0 RID: 2480
			// (get) Token: 0x060023AD RID: 9133 RVA: 0x0009339C File Offset: 0x0009159C
			// (set) Token: 0x060023AE RID: 9134 RVA: 0x00012913 File Offset: 0x00010B13
			public unsafe EulaPrompt _eulaPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._execute_d__5.NativeFieldInfoPtr__eulaPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EulaPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestEULAIFNeeded._execute_d__5.NativeFieldInfoPtr__eulaPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001663 RID: 5731
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001664 RID: 5732
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001665 RID: 5733
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001666 RID: 5734
			private static readonly IntPtr NativeFieldInfoPtr__eulaPrompt_5__2;

			// Token: 0x04001667 RID: 5735
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001668 RID: 5736
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001669 RID: 5737
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400166A RID: 5738
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400166B RID: 5739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400166C RID: 5740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
