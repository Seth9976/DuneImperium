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
	// Token: 0x020000FA RID: 250
	public sealed class WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse> : FailableCommand where TSuccessResponse : NetworkMessageEvent where TFailureResponse : NetworkMessageEvent
	{
		// Token: 0x06000EA6 RID: 3750 RVA: 0x0004DD68 File Offset: 0x0004BF68
		// Note: this type is marked as 'beforefieldinit'.
		static WriteToSessionAndAwaitResponse()
		{
			Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.session.commands", "WriteToSessionAndAwaitResponse`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSuccessResponse>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFailureResponse>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr);
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr__SuccessResponse_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, "<SuccessResponse>k__BackingField");
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr__FailureResponse_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, "<FailureResponse>k__BackingField");
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr__ResponseResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, "<ResponseResult>k__BackingField");
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_sessionProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, "sessionProvider");
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_messageToWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, "messageToWrite");
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_successFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, "successFilter");
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_failureFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, "failureFilter");
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_dispatchOffline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, "dispatchOffline");
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_get_SuccessResponse_Public_get_TSuccessResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, 100665424);
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_set_SuccessResponse_Private_set_Void_TSuccessResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, 100665425);
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_get_FailureResponse_Public_get_TFailureResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, 100665426);
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_set_FailureResponse_Private_set_Void_TFailureResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, 100665427);
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_get_ErrorInfo_Public_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, 100665428);
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_get_ResponseResult_Public_get_SessionResponseResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, 100665429);
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_set_ResponseResult_Private_set_Void_SessionResponseResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, 100665430);
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr__ctor_Public_Void_SessionProvider_Object_Func_2_TSuccessResponse_Boolean_Func_2_TFailureResponse_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, 100665431);
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, 100665432);
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_onSuccess_Private_Void_TSuccessResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, 100665433);
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_onFailure_Private_Void_TFailureResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, 100665434);
			WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_onDisconnected_Private_Void_Disconnected_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, 100665435);
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0004DF78 File Offset: 0x0004C178
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x0004DFB4 File Offset: 0x0004C1B4
		public unsafe TSuccessResponse SuccessResponse
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_get_SuccessResponse_Public_get_TSuccessResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSuccessResponse>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TSuccessResponse).IsValueType)
					{
						TSuccessResponse tsuccessResponse = value;
						intPtr = ((tsuccessResponse is string) ? IL2CPP.ManagedStringToIl2Cpp(tsuccessResponse as string) : IL2CPP.Il2CppObjectBaseToPtr(tsuccessResponse as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_set_SuccessResponse_Private_set_Void_TSuccessResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x0004E02C File Offset: 0x0004C22C
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x0004E068 File Offset: 0x0004C268
		public unsafe TFailureResponse FailureResponse
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_get_FailureResponse_Public_get_TFailureResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TFailureResponse>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TFailureResponse).IsValueType)
					{
						TFailureResponse tfailureResponse = value;
						intPtr = ((tfailureResponse is string) ? IL2CPP.ManagedStringToIl2Cpp(tfailureResponse as string) : IL2CPP.Il2CppObjectBaseToPtr(tfailureResponse as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_set_FailureResponse_Private_set_Void_TFailureResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0004E0E0 File Offset: 0x0004C2E0
		public unsafe ErrorInfo ErrorInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_get_ErrorInfo_Public_get_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0004E118 File Offset: 0x0004C318
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x0004E154 File Offset: 0x0004C354
		public unsafe SessionResponseResult ResponseResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_get_ResponseResult_Public_get_SessionResponseResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_set_ResponseResult_Private_set_Void_SessionResponseResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0004E194 File Offset: 0x0004C394
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 867753, RefRangeEnd = 867757, XrefRangeStart = 867748, XrefRangeEnd = 867753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteToSessionAndAwaitResponse(SessionProvider sessionProvider, Object messageToWrite, Func<TSuccessResponse, bool> successFilter = null, Func<TFailureResponse, bool> failureFilter = null, bool dispatchOffline = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sessionProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messageToWrite);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(successFilter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureFilter);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchOffline;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr__ctor_Public_Void_SessionProvider_Object_Func_2_TSuccessResponse_Boolean_Func_2_TFailureResponse_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0004E224 File Offset: 0x0004C424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0004E264 File Offset: 0x0004C464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867757, XrefRangeEnd = 867758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onSuccess(TSuccessResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TSuccessResponse).IsValueType)
				{
					TSuccessResponse tsuccessResponse = response;
					intPtr = ((tsuccessResponse is string) ? IL2CPP.ManagedStringToIl2Cpp(tsuccessResponse as string) : IL2CPP.Il2CppObjectBaseToPtr(tsuccessResponse as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref response;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_onSuccess_Private_Void_TSuccessResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0004E2DC File Offset: 0x0004C4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867758, XrefRangeEnd = 867759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onFailure(TFailureResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TFailureResponse).IsValueType)
				{
					TFailureResponse tfailureResponse = response;
					intPtr = ((tfailureResponse is string) ? IL2CPP.ManagedStringToIl2Cpp(tfailureResponse as string) : IL2CPP.Il2CppObjectBaseToPtr(tfailureResponse as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref response;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_onFailure_Private_Void_TFailureResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0004E354 File Offset: 0x0004C554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867759, XrefRangeEnd = 867771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onDisconnected(SessionProvider.Disconnected evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeMethodInfoPtr_onDisconnected_Private_Void_Disconnected_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00006F54 File Offset: 0x00005154
		public WriteToSessionAndAwaitResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x0004E398 File Offset: 0x0004C598
		// (set) Token: 0x06000EB5 RID: 3765 RVA: 0x0004E3C0 File Offset: 0x0004C5C0
		public unsafe TSuccessResponse _SuccessResponse_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr__SuccessResponse_k__BackingField);
				return IL2CPP.PointerToValueGeneric<TSuccessResponse>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr__SuccessResponse_k__BackingField);
				Type typeFromHandle = typeof(TSuccessResponse);
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

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0004E468 File Offset: 0x0004C668
		// (set) Token: 0x06000EB7 RID: 3767 RVA: 0x0004E490 File Offset: 0x0004C690
		public unsafe TFailureResponse _FailureResponse_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr__FailureResponse_k__BackingField);
				return IL2CPP.PointerToValueGeneric<TFailureResponse>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr__FailureResponse_k__BackingField);
				Type typeFromHandle = typeof(TFailureResponse);
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

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0004E538 File Offset: 0x0004C738
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x00006F5D File Offset: 0x0000515D
		public unsafe SessionResponseResult _ResponseResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr__ResponseResult_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr__ResponseResult_k__BackingField)) = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0004E560 File Offset: 0x0004C760
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x00006F78 File Offset: 0x00005178
		public unsafe SessionProvider sessionProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_sessionProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_sessionProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x0004E590 File Offset: 0x0004C790
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x00006F97 File Offset: 0x00005197
		public unsafe Object messageToWrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_messageToWrite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_messageToWrite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0004E5C0 File Offset: 0x0004C7C0
		// (set) Token: 0x06000EBF RID: 3775 RVA: 0x00006FB6 File Offset: 0x000051B6
		public unsafe Func<TSuccessResponse, bool> successFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_successFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSuccessResponse, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_successFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0004E5F0 File Offset: 0x0004C7F0
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x00006FD5 File Offset: 0x000051D5
		public unsafe Func<TFailureResponse, bool> failureFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_failureFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TFailureResponse, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_failureFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0004E620 File Offset: 0x0004C820
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x00006FF4 File Offset: 0x000051F4
		public unsafe bool dispatchOffline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_dispatchOffline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>.NativeFieldInfoPtr_dispatchOffline)) = value;
			}
		}

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeFieldInfoPtr__SuccessResponse_k__BackingField;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeFieldInfoPtr__FailureResponse_k__BackingField;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeFieldInfoPtr__ResponseResult_k__BackingField;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeFieldInfoPtr_sessionProvider;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeFieldInfoPtr_messageToWrite;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeFieldInfoPtr_successFilter;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeFieldInfoPtr_failureFilter;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr_dispatchOffline;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr_get_SuccessResponse_Public_get_TSuccessResponse_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr_set_SuccessResponse_Private_set_Void_TSuccessResponse_0;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_get_FailureResponse_Public_get_TFailureResponse_0;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr_set_FailureResponse_Private_set_Void_TFailureResponse_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorInfo_Public_get_ErrorInfo_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseResult_Public_get_SessionResponseResult_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseResult_Private_set_Void_SessionResponseResult_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SessionProvider_Object_Func_2_TSuccessResponse_Boolean_Func_2_TFailureResponse_Boolean_Boolean_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_onSuccess_Private_Void_TSuccessResponse_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_onFailure_Private_Void_TFailureResponse_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_onDisconnected_Private_Void_Disconnected_0;

		// Token: 0x020002B8 RID: 696
		[ObfuscatedName("dwd.core.session.commands.WriteToSessionAndAwaitResponse`2+<execute>d__20")]
		public sealed class _execute_d__20 : Object
		{
			// Token: 0x06002085 RID: 8325 RVA: 0x00092E1C File Offset: 0x0009101C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__20()
			{
				Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>.NativeClassPtr, "<execute>d__20"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSuccessResponse>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFailureResponse>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20>.NativeClassPtr);
				WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20>.NativeClassPtr, "<>1__state");
				WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20>.NativeClassPtr, "<>2__current");
				WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20>.NativeClassPtr, "<>4__this");
				WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20>.NativeClassPtr, 100665436);
				WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20>.NativeClassPtr, 100665437);
				WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20>.NativeClassPtr, 100665438);
				WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20>.NativeClassPtr, 100665439);
				WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20>.NativeClassPtr, 100665440);
				WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20>.NativeClassPtr, 100665441);
			}

			// Token: 0x06002086 RID: 8326 RVA: 0x00092F48 File Offset: 0x00091148
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002087 RID: 8327 RVA: 0x00092F90 File Offset: 0x00091190
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002088 RID: 8328 RVA: 0x00092FC4 File Offset: 0x000911C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867712, XrefRangeEnd = 867748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008D7 RID: 2263
			// (get) Token: 0x06002089 RID: 8329 RVA: 0x00093000 File Offset: 0x00091200
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600208A RID: 8330 RVA: 0x00093040 File Offset: 0x00091240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008D8 RID: 2264
			// (get) Token: 0x0600208B RID: 8331 RVA: 0x00093074 File Offset: 0x00091274
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600208C RID: 8332 RVA: 0x0000DD4E File Offset: 0x0000BF4E
			public _execute_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008D4 RID: 2260
			// (get) Token: 0x0600208D RID: 8333 RVA: 0x000930B4 File Offset: 0x000912B4
			// (set) Token: 0x0600208E RID: 8334 RVA: 0x0000DD57 File Offset: 0x0000BF57
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008D5 RID: 2261
			// (get) Token: 0x0600208F RID: 8335 RVA: 0x000930DC File Offset: 0x000912DC
			// (set) Token: 0x06002090 RID: 8336 RVA: 0x0000DD72 File Offset: 0x0000BF72
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008D6 RID: 2262
			// (get) Token: 0x06002091 RID: 8337 RVA: 0x0009310C File Offset: 0x0009130C
			// (set) Token: 0x06002092 RID: 8338 RVA: 0x0000DD91 File Offset: 0x0000BF91
			public unsafe WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteToSessionAndAwaitResponse<TSuccessResponse, TFailureResponse>._execute_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040016A0 RID: 5792
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016A1 RID: 5793
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016A2 RID: 5794
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016A3 RID: 5795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016A4 RID: 5796
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016A5 RID: 5797
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016A6 RID: 5798
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016A7 RID: 5799
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016A8 RID: 5800
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
