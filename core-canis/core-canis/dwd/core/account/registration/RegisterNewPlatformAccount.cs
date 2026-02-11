using System;
using dwd.core.account.messages;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using localization;

namespace dwd.core.account.registration
{
	// Token: 0x02000223 RID: 547
	public class RegisterNewPlatformAccount : Command
	{
		// Token: 0x06001DC6 RID: 7622 RVA: 0x00089618 File Offset: 0x00087818
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterNewPlatformAccount()
		{
			Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account.registration", "RegisterNewPlatformAccount");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr);
			RegisterNewPlatformAccount.NativeFieldInfoPtr_END_POINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, "END_POINT");
			RegisterNewPlatformAccount.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, "request");
			RegisterNewPlatformAccount.NativeFieldInfoPtr_getErrorDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, "getErrorDetails");
			RegisterNewPlatformAccount.NativeFieldInfoPtr__Response_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, "<Response>k__BackingField");
			RegisterNewPlatformAccount.NativeFieldInfoPtr__ErrorDetails_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, "<ErrorDetails>k__BackingField");
			RegisterNewPlatformAccount.NativeFieldInfoPtr_LanguageCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, "LanguageCode");
			RegisterNewPlatformAccount.NativeMethodInfoPtr__ctor_Public_Void_RegistrationRequest_Locale_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, 100668081);
			RegisterNewPlatformAccount.NativeMethodInfoPtr_get_Response_Public_Virtual_Final_New_get_WebResponseData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, 100668082);
			RegisterNewPlatformAccount.NativeMethodInfoPtr_set_Response_Private_set_Void_WebResponseData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, 100668083);
			RegisterNewPlatformAccount.NativeMethodInfoPtr_get_ErrorDetails_Public_Virtual_Final_New_get_RegistrationResponseError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, 100668084);
			RegisterNewPlatformAccount.NativeMethodInfoPtr_set_ErrorDetails_Private_set_Void_RegistrationResponseError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, 100668085);
			RegisterNewPlatformAccount.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, 100668086);
			RegisterNewPlatformAccount.NativeMethodInfoPtr_getLanguageCodeForLocale_Private_Static_String_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, 100668087);
			RegisterNewPlatformAccount.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, 100668088);
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00089760 File Offset: 0x00087960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 886847, RefRangeEnd = 886848, XrefRangeStart = 886845, XrefRangeEnd = 886847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterNewPlatformAccount(RegistrationRequest request, TextLocalization.Locale languageCode = TextLocalization.Locale.en_US, bool getErrorDetails = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref languageCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getErrorDetails;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount.NativeMethodInfoPtr__ctor_Public_Void_RegistrationRequest_Locale_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x000897C8 File Offset: 0x000879C8
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x00089800 File Offset: 0x00087A00
		public unsafe virtual DwdWebRequestCommand.WebResponseData Response
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount.NativeMethodInfoPtr_get_Response_Public_Virtual_Final_New_get_WebResponseData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DwdWebRequestCommand.WebResponseData(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886848, XrefRangeEnd = 886849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount.NativeMethodInfoPtr_set_Response_Private_set_Void_WebResponseData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00089848 File Offset: 0x00087A48
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x00089888 File Offset: 0x00087A88
		public unsafe virtual RegistrationResponseError ErrorDetails
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount.NativeMethodInfoPtr_get_ErrorDetails_Public_Virtual_Final_New_get_RegistrationResponseError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistrationResponseError>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount.NativeMethodInfoPtr_set_ErrorDetails_Private_set_Void_RegistrationResponseError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x000898CC File Offset: 0x00087ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886849, XrefRangeEnd = 886854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterNewPlatformAccount.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00089918 File Offset: 0x00087B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886854, XrefRangeEnd = 886867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string getLanguageCodeForLocale(TextLocalization.Locale languageCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref languageCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount.NativeMethodInfoPtr_getLanguageCodeForLocale_Private_Static_String_Locale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00089950 File Offset: 0x00087B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886867, XrefRangeEnd = 886876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x0000CB07 File Offset: 0x0000AD07
		public RegisterNewPlatformAccount(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00089988 File Offset: 0x00087B88
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x0000CB10 File Offset: 0x0000AD10
		public unsafe static string END_POINT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegisterNewPlatformAccount.NativeFieldInfoPtr_END_POINT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegisterNewPlatformAccount.NativeFieldInfoPtr_END_POINT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x000899A8 File Offset: 0x00087BA8
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x0000CB22 File Offset: 0x0000AD22
		public unsafe RegistrationRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount.NativeFieldInfoPtr_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistrationRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x000899D8 File Offset: 0x00087BD8
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x0000CB41 File Offset: 0x0000AD41
		public unsafe bool getErrorDetails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount.NativeFieldInfoPtr_getErrorDetails);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount.NativeFieldInfoPtr_getErrorDetails)) = value;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x00089A00 File Offset: 0x00087C00
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x0000CB5C File Offset: 0x0000AD5C
		public DwdWebRequestCommand.WebResponseData _Response_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount.NativeFieldInfoPtr__Response_k__BackingField);
				return new DwdWebRequestCommand.WebResponseData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount.NativeFieldInfoPtr__Response_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00089A30 File Offset: 0x00087C30
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x0000CB8A File Offset: 0x0000AD8A
		public unsafe RegistrationResponseError _ErrorDetails_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount.NativeFieldInfoPtr__ErrorDetails_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegistrationResponseError>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount.NativeFieldInfoPtr__ErrorDetails_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x00089A60 File Offset: 0x00087C60
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x0000CBA9 File Offset: 0x0000ADA9
		public unsafe TextLocalization.Locale LanguageCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount.NativeFieldInfoPtr_LanguageCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount.NativeFieldInfoPtr_LanguageCode)) = value;
			}
		}

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeFieldInfoPtr_END_POINT;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeFieldInfoPtr_getErrorDetails;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeFieldInfoPtr__Response_k__BackingField;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeFieldInfoPtr__ErrorDetails_k__BackingField;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeFieldInfoPtr_LanguageCode;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RegistrationRequest_Locale_Boolean_0;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeMethodInfoPtr_get_Response_Public_Virtual_Final_New_get_WebResponseData_0;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeMethodInfoPtr_set_Response_Private_set_Void_WebResponseData_0;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorDetails_Public_Virtual_Final_New_get_RegistrationResponseError_0;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorDetails_Private_set_Void_RegistrationResponseError_0;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeMethodInfoPtr_getLanguageCodeForLocale_Private_Static_String_Locale_0;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x020003A7 RID: 935
		[ObfuscatedName("dwd.core.account.registration.RegisterNewPlatformAccount+<execute>d__13")]
		public sealed class _execute_d__13 : Object
		{
			// Token: 0x06002997 RID: 10647 RVA: 0x000AE3A8 File Offset: 0x000AC5A8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__13()
			{
				Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegisterNewPlatformAccount>.NativeClassPtr, "<execute>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr);
				RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr, "<>1__state");
				RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr, "<>2__current");
				RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr, "<>4__this");
				RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr__url_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr, "<url>5__2");
				RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr__submitCmd_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr, "<submitCmd>5__3");
				RegisterNewPlatformAccount._execute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr, 100668089);
				RegisterNewPlatformAccount._execute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr, 100668090);
				RegisterNewPlatformAccount._execute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr, 100668091);
				RegisterNewPlatformAccount._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr, 100668092);
				RegisterNewPlatformAccount._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr, 100668093);
				RegisterNewPlatformAccount._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr, 100668094);
			}

			// Token: 0x06002998 RID: 10648 RVA: 0x000AE4B0 File Offset: 0x000AC6B0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterNewPlatformAccount._execute_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount._execute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002999 RID: 10649 RVA: 0x000AE4F8 File Offset: 0x000AC6F8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount._execute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600299A RID: 10650 RVA: 0x000AE52C File Offset: 0x000AC72C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886682, XrefRangeEnd = 886840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount._execute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BD5 RID: 3029
			// (get) Token: 0x0600299B RID: 10651 RVA: 0x000AE568 File Offset: 0x000AC768
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600299C RID: 10652 RVA: 0x000AE5A8 File Offset: 0x000AC7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886840, XrefRangeEnd = 886845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BD6 RID: 3030
			// (get) Token: 0x0600299D RID: 10653 RVA: 0x000AE5DC File Offset: 0x000AC7DC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterNewPlatformAccount._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600299E RID: 10654 RVA: 0x00012E99 File Offset: 0x00011099
			public _execute_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BD0 RID: 3024
			// (get) Token: 0x0600299F RID: 10655 RVA: 0x000AE61C File Offset: 0x000AC81C
			// (set) Token: 0x060029A0 RID: 10656 RVA: 0x00012EA2 File Offset: 0x000110A2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BD1 RID: 3025
			// (get) Token: 0x060029A1 RID: 10657 RVA: 0x000AE644 File Offset: 0x000AC844
			// (set) Token: 0x060029A2 RID: 10658 RVA: 0x00012EBD File Offset: 0x000110BD
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD2 RID: 3026
			// (get) Token: 0x060029A3 RID: 10659 RVA: 0x000AE674 File Offset: 0x000AC874
			// (set) Token: 0x060029A4 RID: 10660 RVA: 0x00012EDC File Offset: 0x000110DC
			public unsafe RegisterNewPlatformAccount __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterNewPlatformAccount>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD3 RID: 3027
			// (get) Token: 0x060029A5 RID: 10661 RVA: 0x000AE6A4 File Offset: 0x000AC8A4
			// (set) Token: 0x060029A6 RID: 10662 RVA: 0x00012EFB File Offset: 0x000110FB
			public unsafe string _url_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr__url_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr__url_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000BD4 RID: 3028
			// (get) Token: 0x060029A7 RID: 10663 RVA: 0x000AE6CC File Offset: 0x000AC8CC
			// (set) Token: 0x060029A8 RID: 10664 RVA: 0x00012F1A File Offset: 0x0001111A
			public unsafe SubmitWWWPostingJSON _submitCmd_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr__submitCmd_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubmitWWWPostingJSON>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterNewPlatformAccount._execute_d__13.NativeFieldInfoPtr__submitCmd_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C1D RID: 7197
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C1E RID: 7198
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C1F RID: 7199
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C20 RID: 7200
			private static readonly IntPtr NativeFieldInfoPtr__url_5__2;

			// Token: 0x04001C21 RID: 7201
			private static readonly IntPtr NativeFieldInfoPtr__submitCmd_5__3;

			// Token: 0x04001C22 RID: 7202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C23 RID: 7203
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C24 RID: 7204
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C25 RID: 7205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C26 RID: 7206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C27 RID: 7207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
