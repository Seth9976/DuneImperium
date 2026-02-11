using System;
using dwd.core;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace dbgclient.menus.commands
{
	// Token: 0x0200009F RID: 159
	public class RequestDailyChallengeInfo : Command
	{
		// Token: 0x0600064A RID: 1610 RVA: 0x00031880 File Offset: 0x0002FA80
		// Note: this type is marked as 'beforefieldinit'.
		static RequestDailyChallengeInfo()
		{
			Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.menus.commands", "RequestDailyChallengeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr);
			RequestDailyChallengeInfo.NativeFieldInfoPtr__ResponseText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr, "<ResponseText>k__BackingField");
			RequestDailyChallengeInfo.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr, "status");
			RequestDailyChallengeInfo.NativeMethodInfoPtr_get_ResponseText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr, 100664264);
			RequestDailyChallengeInfo.NativeMethodInfoPtr_set_ResponseText_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr, 100664265);
			RequestDailyChallengeInfo.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr, 100664266);
			RequestDailyChallengeInfo.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr, 100664267);
			RequestDailyChallengeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr, 100664268);
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0003193C File Offset: 0x0002FB3C
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00031974 File Offset: 0x0002FB74
		public unsafe string ResponseText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo.NativeMethodInfoPtr_get_ResponseText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo.NativeMethodInfoPtr_set_ResponseText_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000319B8 File Offset: 0x0002FBB8
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000319F0 File Offset: 0x0002FBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503173, XrefRangeEnd = 503178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestDailyChallengeInfo.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00031A3C File Offset: 0x0002FC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503178, XrefRangeEnd = 503187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestDailyChallengeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public RequestDailyChallengeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00031A78 File Offset: 0x0002FC78
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00004DBD File Offset: 0x00002FBD
		public unsafe string _ResponseText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo.NativeFieldInfoPtr__ResponseText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo.NativeFieldInfoPtr__ResponseText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00031AA0 File Offset: 0x0002FCA0
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00004DDC File Offset: 0x00002FDC
		public ErrorInfo status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo.NativeFieldInfoPtr_status);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr__ResponseText_k__BackingField;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseText_Public_get_String_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseText_Private_set_Void_String_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200030E RID: 782
		[ObfuscatedName("dbgclient.menus.commands.RequestDailyChallengeInfo+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002500 RID: 9472 RVA: 0x000971BC File Offset: 0x000953BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RequestDailyChallengeInfo.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c>.NativeClassPtr);
				RequestDailyChallengeInfo.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c>.NativeClassPtr, "<>9");
				RequestDailyChallengeInfo.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c>.NativeClassPtr, "<>9__6_0");
				RequestDailyChallengeInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c>.NativeClassPtr, 100664270);
				RequestDailyChallengeInfo.__c.NativeMethodInfoPtr__execute_b__6_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c>.NativeClassPtr, 100664271);
			}

			// Token: 0x06002501 RID: 9473 RVA: 0x00097238 File Offset: 0x00095438
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002502 RID: 9474 RVA: 0x00097274 File Offset: 0x00095474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503051, XrefRangeEnd = 503059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__6_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo.__c.NativeMethodInfoPtr__execute_b__6_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002503 RID: 9475 RVA: 0x000133DE File Offset: 0x000115DE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A2B RID: 2603
			// (get) Token: 0x06002504 RID: 9476 RVA: 0x000972B8 File Offset: 0x000954B8
			// (set) Token: 0x06002505 RID: 9477 RVA: 0x000133E7 File Offset: 0x000115E7
			public unsafe static RequestDailyChallengeInfo.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RequestDailyChallengeInfo.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestDailyChallengeInfo.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RequestDailyChallengeInfo.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A2C RID: 2604
			// (get) Token: 0x06002506 RID: 9478 RVA: 0x000972E0 File Offset: 0x000954E0
			// (set) Token: 0x06002507 RID: 9479 RVA: 0x000133F9 File Offset: 0x000115F9
			public unsafe static Action<UnityWebRequest> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RequestDailyChallengeInfo.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RequestDailyChallengeInfo.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400173D RID: 5949
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400173E RID: 5950
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400173F RID: 5951
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001740 RID: 5952
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__6_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x0200030F RID: 783
		[ObfuscatedName("dbgclient.menus.commands.RequestDailyChallengeInfo+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06002508 RID: 9480 RVA: 0x00097308 File Offset: 0x00095508
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<RequestDailyChallengeInfo.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c__DisplayClass6_0>.NativeClassPtr);
				RequestDailyChallengeInfo.__c__DisplayClass6_0.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c__DisplayClass6_0>.NativeClassPtr, "url");
				RequestDailyChallengeInfo.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				RequestDailyChallengeInfo.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c__DisplayClass6_0>.NativeClassPtr, 100664272);
				RequestDailyChallengeInfo.__c__DisplayClass6_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c__DisplayClass6_0>.NativeClassPtr, 100664273);
				RequestDailyChallengeInfo.__c__DisplayClass6_0.NativeMethodInfoPtr__execute_b__2_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c__DisplayClass6_0>.NativeClassPtr, 100664274);
			}

			// Token: 0x06002509 RID: 9481 RVA: 0x00097398 File Offset: 0x00095598
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestDailyChallengeInfo.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600250A RID: 9482 RVA: 0x000973D4 File Offset: 0x000955D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503059, XrefRangeEnd = 503086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__1(DwdWebRequestCommand request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo.__c__DisplayClass6_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600250B RID: 9483 RVA: 0x00097418 File Offset: 0x00095618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503086, XrefRangeEnd = 503097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__2(ErrorInfo errorInfo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(errorInfo));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo.__c__DisplayClass6_0.NativeMethodInfoPtr__execute_b__2_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600250C RID: 9484 RVA: 0x0001340B File Offset: 0x0001160B
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A2D RID: 2605
			// (get) Token: 0x0600250D RID: 9485 RVA: 0x00097460 File Offset: 0x00095660
			// (set) Token: 0x0600250E RID: 9486 RVA: 0x00013414 File Offset: 0x00011614
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo.__c__DisplayClass6_0.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo.__c__DisplayClass6_0.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A2E RID: 2606
			// (get) Token: 0x0600250F RID: 9487 RVA: 0x00097488 File Offset: 0x00095688
			// (set) Token: 0x06002510 RID: 9488 RVA: 0x00013433 File Offset: 0x00011633
			public unsafe RequestDailyChallengeInfo __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestDailyChallengeInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001741 RID: 5953
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x04001742 RID: 5954
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001743 RID: 5955
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001744 RID: 5956
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0;

			// Token: 0x04001745 RID: 5957
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_Internal_Void_ErrorInfo_0;
		}

		// Token: 0x02000310 RID: 784
		[ObfuscatedName("dbgclient.menus.commands.RequestDailyChallengeInfo+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06002511 RID: 9489 RVA: 0x000974B8 File Offset: 0x000956B8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<RequestDailyChallengeInfo._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RequestDailyChallengeInfo>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestDailyChallengeInfo._execute_d__6>.NativeClassPtr);
				RequestDailyChallengeInfo._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeInfo._execute_d__6>.NativeClassPtr, "<>1__state");
				RequestDailyChallengeInfo._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeInfo._execute_d__6>.NativeClassPtr, "<>2__current");
				RequestDailyChallengeInfo._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestDailyChallengeInfo._execute_d__6>.NativeClassPtr, "<>4__this");
				RequestDailyChallengeInfo._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo._execute_d__6>.NativeClassPtr, 100664275);
				RequestDailyChallengeInfo._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo._execute_d__6>.NativeClassPtr, 100664276);
				RequestDailyChallengeInfo._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo._execute_d__6>.NativeClassPtr, 100664277);
				RequestDailyChallengeInfo._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo._execute_d__6>.NativeClassPtr, 100664278);
				RequestDailyChallengeInfo._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo._execute_d__6>.NativeClassPtr, 100664279);
				RequestDailyChallengeInfo._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestDailyChallengeInfo._execute_d__6>.NativeClassPtr, 100664280);
			}

			// Token: 0x06002512 RID: 9490 RVA: 0x00097598 File Offset: 0x00095798
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestDailyChallengeInfo._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002513 RID: 9491 RVA: 0x000975E0 File Offset: 0x000957E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002514 RID: 9492 RVA: 0x00097614 File Offset: 0x00095814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503097, XrefRangeEnd = 503168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A32 RID: 2610
			// (get) Token: 0x06002515 RID: 9493 RVA: 0x00097650 File Offset: 0x00095850
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002516 RID: 9494 RVA: 0x00097690 File Offset: 0x00095890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503168, XrefRangeEnd = 503173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A33 RID: 2611
			// (get) Token: 0x06002517 RID: 9495 RVA: 0x000976C4 File Offset: 0x000958C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestDailyChallengeInfo._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002518 RID: 9496 RVA: 0x00013452 File Offset: 0x00011652
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A2F RID: 2607
			// (get) Token: 0x06002519 RID: 9497 RVA: 0x00097704 File Offset: 0x00095904
			// (set) Token: 0x0600251A RID: 9498 RVA: 0x0001345B File Offset: 0x0001165B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A30 RID: 2608
			// (get) Token: 0x0600251B RID: 9499 RVA: 0x0009772C File Offset: 0x0009592C
			// (set) Token: 0x0600251C RID: 9500 RVA: 0x00013476 File Offset: 0x00011676
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A31 RID: 2609
			// (get) Token: 0x0600251D RID: 9501 RVA: 0x0009775C File Offset: 0x0009595C
			// (set) Token: 0x0600251E RID: 9502 RVA: 0x00013495 File Offset: 0x00011695
			public unsafe RequestDailyChallengeInfo __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestDailyChallengeInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestDailyChallengeInfo._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001746 RID: 5958
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001747 RID: 5959
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001748 RID: 5960
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001749 RID: 5961
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400174A RID: 5962
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400174B RID: 5963
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400174C RID: 5964
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400174D RID: 5965
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400174E RID: 5966
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
