using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002CA RID: 714
	public class CrossAppDomainSink : Object
	{
		// Token: 0x06002D1C RID: 11548 RVA: 0x000EB84C File Offset: 0x000E9A4C
		// Note: this type is marked as 'beforefieldinit'.
		static CrossAppDomainSink()
		{
			Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CrossAppDomainSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr);
			CrossAppDomainSink.NativeFieldInfoPtr_s_sinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, "s_sinks");
			CrossAppDomainSink.NativeFieldInfoPtr_processMessageMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, "processMessageMethod");
			CrossAppDomainSink.NativeFieldInfoPtr__domainID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, "_domainID");
			CrossAppDomainSink.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100670551);
			CrossAppDomainSink.NativeMethodInfoPtr_GetSink_Internal_Static_CrossAppDomainSink_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100670552);
			CrossAppDomainSink.NativeMethodInfoPtr_get_TargetDomainId_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100670553);
			CrossAppDomainSink.NativeMethodInfoPtr_ProcessMessageInDomain_Private_Static_ProcessMessageRes_Il2CppStructArray_1_Byte_CADMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100670554);
			CrossAppDomainSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100670555);
			CrossAppDomainSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100670556);
			CrossAppDomainSink.NativeMethodInfoPtr_SendAsyncMessage_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100670557);
			CrossAppDomainSink.NativeMethodInfoPtr__AsyncProcessMessage_b__10_0_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, 100670559);
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x000EB958 File Offset: 0x000E9B58
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossAppDomainSink(int domainID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000EB9A0 File Offset: 0x000E9BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381659, RefRangeEnd = 1381660, XrefRangeStart = 1381629, XrefRangeEnd = 1381659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CrossAppDomainSink GetSink(int domainID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr_GetSink_Internal_Static_CrossAppDomainSink_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CrossAppDomainSink>(intPtr3) : null;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x000EB9E0 File Offset: 0x000E9BE0
		public unsafe int TargetDomainId
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr_get_TargetDomainId_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x000EBA1C File Offset: 0x000E9C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381660, XrefRangeEnd = 1381671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(Il2CppStructArray<byte> arrRequest, CADMethodCallMessage cadMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cadMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr_ProcessMessageInDomain_Private_Static_ProcessMessageRes_Il2CppStructArray_1_Byte_CADMethodCallMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CrossAppDomainSink.ProcessMessageRes(intPtr);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x000EBA6C File Offset: 0x000E9C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381671, XrefRangeEnd = 1381714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msgRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msgRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x000EBAC8 File Offset: 0x000E9CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381714, XrefRangeEnd = 1381727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reqMsg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x000EBB38 File Offset: 0x000E9D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381727, XrefRangeEnd = 1381734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAsyncMessage(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr_SendAsyncMessage_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x000EBB7C File Offset: 0x000E9D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381734, XrefRangeEnd = 1381740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AsyncProcessMessage_b__10_0(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainSink.NativeMethodInfoPtr__AsyncProcessMessage_b__10_0_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x0000F211 File Offset: 0x0000D411
		public CrossAppDomainSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06002D26 RID: 11558 RVA: 0x000EBBC0 File Offset: 0x000E9DC0
		// (set) Token: 0x06002D27 RID: 11559 RVA: 0x0000F21A File Offset: 0x0000D41A
		public unsafe static Hashtable s_sinks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CrossAppDomainSink.NativeFieldInfoPtr_s_sinks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrossAppDomainSink.NativeFieldInfoPtr_s_sinks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06002D28 RID: 11560 RVA: 0x000EBBE8 File Offset: 0x000E9DE8
		// (set) Token: 0x06002D29 RID: 11561 RVA: 0x0000F22C File Offset: 0x0000D42C
		public unsafe static MethodInfo processMessageMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CrossAppDomainSink.NativeFieldInfoPtr_processMessageMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrossAppDomainSink.NativeFieldInfoPtr_processMessageMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06002D2A RID: 11562 RVA: 0x000EBC10 File Offset: 0x000E9E10
		// (set) Token: 0x06002D2B RID: 11563 RVA: 0x0000F23E File Offset: 0x0000D43E
		public unsafe int _domainID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.NativeFieldInfoPtr__domainID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.NativeFieldInfoPtr__domainID)) = value;
			}
		}

		// Token: 0x040025E8 RID: 9704
		private static readonly IntPtr NativeFieldInfoPtr_s_sinks;

		// Token: 0x040025E9 RID: 9705
		private static readonly IntPtr NativeFieldInfoPtr_processMessageMethod;

		// Token: 0x040025EA RID: 9706
		private static readonly IntPtr NativeFieldInfoPtr__domainID;

		// Token: 0x040025EB RID: 9707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040025EC RID: 9708
		private static readonly IntPtr NativeMethodInfoPtr_GetSink_Internal_Static_CrossAppDomainSink_Int32_0;

		// Token: 0x040025ED RID: 9709
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetDomainId_Internal_get_Int32_0;

		// Token: 0x040025EE RID: 9710
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessageInDomain_Private_Static_ProcessMessageRes_Il2CppStructArray_1_Byte_CADMethodCallMessage_0;

		// Token: 0x040025EF RID: 9711
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0;

		// Token: 0x040025F0 RID: 9712
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x040025F1 RID: 9713
		private static readonly IntPtr NativeMethodInfoPtr_SendAsyncMessage_Public_Void_Object_0;

		// Token: 0x040025F2 RID: 9714
		private static readonly IntPtr NativeMethodInfoPtr__AsyncProcessMessage_b__10_0_Private_Void_Object_0;

		// Token: 0x0200066B RID: 1643
		public sealed class ProcessMessageRes : ValueType
		{
			// Token: 0x06005B40 RID: 23360 RVA: 0x0019F60C File Offset: 0x0019D80C
			// Note: this type is marked as 'beforefieldinit'.
			static ProcessMessageRes()
			{
				Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrossAppDomainSink>.NativeClassPtr, "ProcessMessageRes");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr);
				CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_arrResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr, "arrResponse");
				CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_cadMrm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr, "cadMrm");
			}

			// Token: 0x06005B41 RID: 23361 RVA: 0x00021103 File Offset: 0x0001F303
			public ProcessMessageRes(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005B42 RID: 23362 RVA: 0x0002110C File Offset: 0x0001F30C
			public ProcessMessageRes()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossAppDomainSink.ProcessMessageRes>.NativeClassPtr))
			{
			}

			// Token: 0x17001760 RID: 5984
			// (get) Token: 0x06005B43 RID: 23363 RVA: 0x0019F660 File Offset: 0x0019D860
			// (set) Token: 0x06005B44 RID: 23364 RVA: 0x0002111E File Offset: 0x0001F31E
			public unsafe Il2CppStructArray<byte> arrResponse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_arrResponse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_arrResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001761 RID: 5985
			// (get) Token: 0x06005B45 RID: 23365 RVA: 0x0019F690 File Offset: 0x0019D890
			// (set) Token: 0x06005B46 RID: 23366 RVA: 0x0002113D File Offset: 0x0001F33D
			public unsafe CADMethodReturnMessage cadMrm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_cadMrm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CADMethodReturnMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainSink.ProcessMessageRes.NativeFieldInfoPtr_cadMrm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A62 RID: 19042
			private static readonly IntPtr NativeFieldInfoPtr_arrResponse;

			// Token: 0x04004A63 RID: 19043
			private static readonly IntPtr NativeFieldInfoPtr_cadMrm;
		}
	}
}
