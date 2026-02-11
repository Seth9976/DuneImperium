using System;
using dwd.core.commands;
using dwd.core.networking.commands;
using dwd.core.platform.authentication;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.core.platform.auth
{
	// Token: 0x02000053 RID: 83
	public class GetPlatformTokenBase : FailableCommand
	{
		// Token: 0x06000348 RID: 840 RVA: 0x00010314 File Offset: 0x0000E514
		// Note: this type is marked as 'beforefieldinit'.
		static GetPlatformTokenBase()
		{
			Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.auth", "GetPlatformTokenBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr);
			GetPlatformTokenBase.NativeFieldInfoPtr_authServerURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, "authServerURL");
			GetPlatformTokenBase.NativeFieldInfoPtr__ResponseCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, "<ResponseCode>k__BackingField");
			GetPlatformTokenBase.NativeFieldInfoPtr__ResponseError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, "<ResponseError>k__BackingField");
			GetPlatformTokenBase.NativeFieldInfoPtr__PlatformToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, "<PlatformToken>k__BackingField");
			GetPlatformTokenBase.NativeMethodInfoPtr_get_ResponseCode_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, 100663806);
			GetPlatformTokenBase.NativeMethodInfoPtr_set_ResponseCode_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, 100663807);
			GetPlatformTokenBase.NativeMethodInfoPtr_get_ResponseError_Public_get_AuthResponseError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, 100663808);
			GetPlatformTokenBase.NativeMethodInfoPtr_set_ResponseError_Private_set_Void_AuthResponseError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, 100663809);
			GetPlatformTokenBase.NativeMethodInfoPtr_get_PlatformToken_Public_get_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, 100663810);
			GetPlatformTokenBase.NativeMethodInfoPtr_set_PlatformToken_Private_set_Void_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, 100663811);
			GetPlatformTokenBase.NativeMethodInfoPtr__ctor_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, 100663812);
			GetPlatformTokenBase.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, 100663813);
			GetPlatformTokenBase.NativeMethodInfoPtr_generateHttpPostRequest_Protected_Abstract_Virtual_New_HttpPostRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, 100663814);
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00010448 File Offset: 0x0000E648
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00010484 File Offset: 0x0000E684
		public unsafe long ResponseCode
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase.NativeMethodInfoPtr_get_ResponseCode_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase.NativeMethodInfoPtr_set_ResponseCode_Private_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600034B RID: 843 RVA: 0x000104C4 File Offset: 0x0000E6C4
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00010504 File Offset: 0x0000E704
		public unsafe AuthResponseError ResponseError
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase.NativeMethodInfoPtr_get_ResponseError_Public_get_AuthResponseError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AuthResponseError>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase.NativeMethodInfoPtr_set_ResponseError_Private_set_Void_AuthResponseError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00010548 File Offset: 0x0000E748
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00010588 File Offset: 0x0000E788
		public unsafe PlatformToken PlatformToken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase.NativeMethodInfoPtr_get_PlatformToken_Public_get_PlatformToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase.NativeMethodInfoPtr_set_PlatformToken_Private_set_Void_PlatformToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000105CC File Offset: 0x0000E7CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 539238, RefRangeEnd = 539243, XrefRangeStart = 539238, XrefRangeEnd = 539243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetPlatformTokenBase(string authServerURL)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authServerURL);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase.NativeMethodInfoPtr__ctor_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00010618 File Offset: 0x0000E818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170002, XrefRangeEnd = 1170007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetPlatformTokenBase.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00010664 File Offset: 0x0000E864
		[CallerCount(0)]
		public unsafe virtual HttpPostRequest generateHttpPostRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetPlatformTokenBase.NativeMethodInfoPtr_generateHttpPostRequest_Protected_Abstract_Virtual_New_HttpPostRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpPostRequest>(intPtr3) : null;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00003860 File Offset: 0x00001A60
		public GetPlatformTokenBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000353 RID: 851 RVA: 0x000106B0 File Offset: 0x0000E8B0
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00003869 File Offset: 0x00001A69
		public unsafe string authServerURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase.NativeFieldInfoPtr_authServerURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase.NativeFieldInfoPtr_authServerURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000355 RID: 853 RVA: 0x000106D8 File Offset: 0x0000E8D8
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00003888 File Offset: 0x00001A88
		public unsafe long _ResponseCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase.NativeFieldInfoPtr__ResponseCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase.NativeFieldInfoPtr__ResponseCode_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00010700 File Offset: 0x0000E900
		// (set) Token: 0x06000358 RID: 856 RVA: 0x000038A3 File Offset: 0x00001AA3
		public unsafe AuthResponseError _ResponseError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase.NativeFieldInfoPtr__ResponseError_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthResponseError>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase.NativeFieldInfoPtr__ResponseError_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00010730 File Offset: 0x0000E930
		// (set) Token: 0x0600035A RID: 858 RVA: 0x000038C2 File Offset: 0x00001AC2
		public unsafe PlatformToken _PlatformToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase.NativeFieldInfoPtr__PlatformToken_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase.NativeFieldInfoPtr__PlatformToken_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeFieldInfoPtr_authServerURL;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeFieldInfoPtr__ResponseCode_k__BackingField;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr__ResponseError_k__BackingField;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr__PlatformToken_k__BackingField;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseCode_Public_get_Int64_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseCode_Private_set_Void_Int64_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseError_Public_get_AuthResponseError_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseError_Private_set_Void_AuthResponseError_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformToken_Public_get_PlatformToken_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_set_PlatformToken_Private_set_Void_PlatformToken_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_generateHttpPostRequest_Protected_Abstract_Virtual_New_HttpPostRequest_0;

		// Token: 0x02000085 RID: 133
		[ObfuscatedName("dwd.core.platform.auth.GetPlatformTokenBase+<execute>d__14")]
		public sealed class _execute_d__14 : Object
		{
			// Token: 0x060004EA RID: 1258 RVA: 0x0001534C File Offset: 0x0001354C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__14()
			{
				Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetPlatformTokenBase>.NativeClassPtr, "<execute>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr);
				GetPlatformTokenBase._execute_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr, "<>1__state");
				GetPlatformTokenBase._execute_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr, "<>2__current");
				GetPlatformTokenBase._execute_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr, "<>4__this");
				GetPlatformTokenBase._execute_d__14.NativeFieldInfoPtr__httpPostRequest_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr, "<httpPostRequest>5__2");
				GetPlatformTokenBase._execute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr, 100663815);
				GetPlatformTokenBase._execute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr, 100663816);
				GetPlatformTokenBase._execute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr, 100663817);
				GetPlatformTokenBase._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr, 100663818);
				GetPlatformTokenBase._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr, 100663819);
				GetPlatformTokenBase._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr, 100663820);
			}

			// Token: 0x060004EB RID: 1259 RVA: 0x00015440 File Offset: 0x00013640
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetPlatformTokenBase._execute_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase._execute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004EC RID: 1260 RVA: 0x00015488 File Offset: 0x00013688
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase._execute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004ED RID: 1261 RVA: 0x000154BC File Offset: 0x000136BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169974, XrefRangeEnd = 1169997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase._execute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x060004EE RID: 1262 RVA: 0x000154F8 File Offset: 0x000136F8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x00015538 File Offset: 0x00013738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169997, XrefRangeEnd = 1170002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0001556C File Offset: 0x0001376C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenBase._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004F1 RID: 1265 RVA: 0x0000461E File Offset: 0x0000281E
			public _execute_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x060004F2 RID: 1266 RVA: 0x000155AC File Offset: 0x000137AC
			// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00004627 File Offset: 0x00002827
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase._execute_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase._execute_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x060004F4 RID: 1268 RVA: 0x000155D4 File Offset: 0x000137D4
			// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00004642 File Offset: 0x00002842
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase._execute_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase._execute_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00015604 File Offset: 0x00013804
			// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00004661 File Offset: 0x00002861
			public unsafe GetPlatformTokenBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase._execute_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetPlatformTokenBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase._execute_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00015634 File Offset: 0x00013834
			// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00004680 File Offset: 0x00002880
			public unsafe HttpPostRequest _httpPostRequest_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase._execute_d__14.NativeFieldInfoPtr__httpPostRequest_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpPostRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenBase._execute_d__14.NativeFieldInfoPtr__httpPostRequest_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400031B RID: 795
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400031C RID: 796
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400031D RID: 797
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400031E RID: 798
			private static readonly IntPtr NativeFieldInfoPtr__httpPostRequest_5__2;

			// Token: 0x0400031F RID: 799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000320 RID: 800
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000321 RID: 801
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000322 RID: 802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000323 RID: 803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000324 RID: 804
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
