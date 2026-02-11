using System;
using Canis.json.events;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.session.commands
{
	// Token: 0x020000F9 RID: 249
	public sealed class WriteToSessionAndAwaitResponse<TResponse> : FailableCommand where TResponse : NetworkMessageEvent
	{
		// Token: 0x06000E95 RID: 3733 RVA: 0x0004D8F4 File Offset: 0x0004BAF4
		// Note: this type is marked as 'beforefieldinit'.
		static WriteToSessionAndAwaitResponse()
		{
			Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.session.commands", "WriteToSessionAndAwaitResponse`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr);
			WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr, "response");
			WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_sessionProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr, "sessionProvider");
			WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_messageToWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr, "messageToWrite");
			WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_responseFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr, "responseFilter");
			WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_dispatchOffline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr, "dispatchOffline");
			WriteToSessionAndAwaitResponse<TResponse>.NativeMethodInfoPtr_get_Response_Public_get_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr, 100665413);
			WriteToSessionAndAwaitResponse<TResponse>.NativeMethodInfoPtr__ctor_Public_Void_SessionProvider_Object_Func_2_TResponse_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr, 100665414);
			WriteToSessionAndAwaitResponse<TResponse>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr, 100665415);
			WriteToSessionAndAwaitResponse<TResponse>.NativeMethodInfoPtr_onResponse_Private_Void_TResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr, 100665416);
			WriteToSessionAndAwaitResponse<TResponse>.NativeMethodInfoPtr_onDisconnected_Private_Void_Disconnected_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr, 100665417);
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0004DA28 File Offset: 0x0004BC28
		public unsafe TResponse Response
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TResponse>.NativeMethodInfoPtr_get_Response_Public_get_TResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResponse>(intPtr, false, true);
			}
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0004DA64 File Offset: 0x0004BC64
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 867689, RefRangeEnd = 867695, XrefRangeStart = 867685, XrefRangeEnd = 867689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteToSessionAndAwaitResponse(SessionProvider sessionProvider, Object messageToWrite, Func<TResponse, bool> responseFilter = null, bool dispatchOffline = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sessionProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messageToWrite);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseFilter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchOffline;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TResponse>.NativeMethodInfoPtr__ctor_Public_Void_SessionProvider_Object_Func_2_TResponse_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0004DAE4 File Offset: 0x0004BCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867695, XrefRangeEnd = 867699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TResponse>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0004DB24 File Offset: 0x0004BD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867699, XrefRangeEnd = 867700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onResponse(TResponse gotResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResponse).IsValueType)
				{
					TResponse tresponse = gotResponse;
					intPtr = ((tresponse is string) ? IL2CPP.ManagedStringToIl2Cpp(tresponse as string) : IL2CPP.Il2CppObjectBaseToPtr(tresponse as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref gotResponse;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TResponse>.NativeMethodInfoPtr_onResponse_Private_Void_TResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0004DB9C File Offset: 0x0004BD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867700, XrefRangeEnd = 867712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onDisconnected(SessionProvider.Disconnected evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TResponse>.NativeMethodInfoPtr_onDisconnected_Private_Void_Disconnected_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00006ED3 File Offset: 0x000050D3
		public WriteToSessionAndAwaitResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0004DBE0 File Offset: 0x0004BDE0
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x0004DC08 File Offset: 0x0004BE08
		public unsafe TResponse response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_response);
				return IL2CPP.PointerToValueGeneric<TResponse>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_response);
				Type typeFromHandle = typeof(TResponse);
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

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x0004DCB0 File Offset: 0x0004BEB0
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x00006EDC File Offset: 0x000050DC
		public unsafe SessionProvider sessionProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_sessionProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_sessionProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0004DCE0 File Offset: 0x0004BEE0
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00006EFB File Offset: 0x000050FB
		public unsafe Object messageToWrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_messageToWrite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_messageToWrite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0004DD10 File Offset: 0x0004BF10
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x00006F1A File Offset: 0x0000511A
		public unsafe Func<TResponse, bool> responseFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_responseFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TResponse, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_responseFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0004DD40 File Offset: 0x0004BF40
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x00006F39 File Offset: 0x00005139
		public unsafe bool dispatchOffline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_dispatchOffline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>.NativeFieldInfoPtr_dispatchOffline)) = value;
			}
		}

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeFieldInfoPtr_response;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeFieldInfoPtr_sessionProvider;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeFieldInfoPtr_messageToWrite;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeFieldInfoPtr_responseFilter;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeFieldInfoPtr_dispatchOffline;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_get_Response_Public_get_TResponse_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SessionProvider_Object_Func_2_TResponse_Boolean_Boolean_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_onResponse_Private_Void_TResponse_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_onDisconnected_Private_Void_Disconnected_0;

		// Token: 0x020002B7 RID: 695
		[ObfuscatedName("dwd.core.session.commands.WriteToSessionAndAwaitResponse`1+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x06002077 RID: 8311 RVA: 0x00092B0C File Offset: 0x00090D0C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>._execute_d__8>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>>.NativeClassPtr, "<execute>d__8"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResponse>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>._execute_d__8>.NativeClassPtr);
				WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>._execute_d__8>.NativeClassPtr, "<>1__state");
				WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>._execute_d__8>.NativeClassPtr, "<>2__current");
				WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>._execute_d__8>.NativeClassPtr, "<>4__this");
				WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>._execute_d__8>.NativeClassPtr, 100665418);
				WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>._execute_d__8>.NativeClassPtr, 100665419);
				WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>._execute_d__8>.NativeClassPtr, 100665420);
				WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>._execute_d__8>.NativeClassPtr, 100665421);
				WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>._execute_d__8>.NativeClassPtr, 100665422);
				WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>._execute_d__8>.NativeClassPtr, 100665423);
			}

			// Token: 0x06002078 RID: 8312 RVA: 0x00092C28 File Offset: 0x00090E28
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TResponse>._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002079 RID: 8313 RVA: 0x00092C70 File Offset: 0x00090E70
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600207A RID: 8314 RVA: 0x00092CA4 File Offset: 0x00090EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867653, XrefRangeEnd = 867685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008D2 RID: 2258
			// (get) Token: 0x0600207B RID: 8315 RVA: 0x00092CE0 File Offset: 0x00090EE0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600207C RID: 8316 RVA: 0x00092D20 File Offset: 0x00090F20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008D3 RID: 2259
			// (get) Token: 0x0600207D RID: 8317 RVA: 0x00092D54 File Offset: 0x00090F54
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600207E RID: 8318 RVA: 0x0000DCEC File Offset: 0x0000BEEC
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008CF RID: 2255
			// (get) Token: 0x0600207F RID: 8319 RVA: 0x00092D94 File Offset: 0x00090F94
			// (set) Token: 0x06002080 RID: 8320 RVA: 0x0000DCF5 File Offset: 0x0000BEF5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008D0 RID: 2256
			// (get) Token: 0x06002081 RID: 8321 RVA: 0x00092DBC File Offset: 0x00090FBC
			// (set) Token: 0x06002082 RID: 8322 RVA: 0x0000DD10 File Offset: 0x0000BF10
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D1 RID: 2257
			// (get) Token: 0x06002083 RID: 8323 RVA: 0x00092DEC File Offset: 0x00090FEC
			// (set) Token: 0x06002084 RID: 8324 RVA: 0x0000DD2F File Offset: 0x0000BF2F
			public unsafe WriteToSessionAndAwaitResponse<TResponse> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<TResponse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TResponse>._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001697 RID: 5783
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001698 RID: 5784
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001699 RID: 5785
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400169A RID: 5786
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400169B RID: 5787
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400169C RID: 5788
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400169D RID: 5789
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400169E RID: 5790
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400169F RID: 5791
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
