using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000014 RID: 20
	public class AsyncProtocolRequest : Object
	{
		// Token: 0x060000DA RID: 218 RVA: 0x0001DCDC File Offset: 0x0001BEDC
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncProtocolRequest()
		{
			Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "AsyncProtocolRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr);
			AsyncProtocolRequest.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<Parent>k__BackingField");
			AsyncProtocolRequest.NativeFieldInfoPtr__RunSynchronously_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<RunSynchronously>k__BackingField");
			AsyncProtocolRequest.NativeFieldInfoPtr__UserResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<UserResult>k__BackingField");
			AsyncProtocolRequest.NativeFieldInfoPtr_Started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "Started");
			AsyncProtocolRequest.NativeFieldInfoPtr_RequestedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "RequestedSize");
			AsyncProtocolRequest.NativeFieldInfoPtr_WriteRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "WriteRequested");
			AsyncProtocolRequest.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "locker");
			AsyncProtocolRequest.NativeMethodInfoPtr_get_Parent_Public_get_MobileAuthenticatedStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663476);
			AsyncProtocolRequest.NativeMethodInfoPtr_get_RunSynchronously_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663477);
			AsyncProtocolRequest.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663478);
			AsyncProtocolRequest.NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663479);
			AsyncProtocolRequest.NativeMethodInfoPtr_set_UserResult_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663480);
			AsyncProtocolRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663481);
			AsyncProtocolRequest.NativeMethodInfoPtr_RequestRead_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663482);
			AsyncProtocolRequest.NativeMethodInfoPtr_RequestWrite_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663483);
			AsyncProtocolRequest.NativeMethodInfoPtr_StartOperation_Internal_Task_1_AsyncProtocolResult_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663484);
			AsyncProtocolRequest.NativeMethodInfoPtr_ProcessOperation_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663485);
			AsyncProtocolRequest.NativeMethodInfoPtr_InnerRead_Private_Task_1_Nullable_1_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663486);
			AsyncProtocolRequest.NativeMethodInfoPtr_Run_Protected_Abstract_Virtual_New_AsyncOperationStatus_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663487);
			AsyncProtocolRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, 100663488);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0001DE9C File Offset: 0x0001C09C
		public unsafe MobileAuthenticatedStream Parent
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_get_Parent_Public_get_MobileAuthenticatedStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr3) : null;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0001DEDC File Offset: 0x0001C0DC
		public unsafe bool RunSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_get_RunSynchronously_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0001DF18 File Offset: 0x0001C118
		public unsafe string Name
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 427817, RefRangeEnd = 427822, XrefRangeStart = 427815, XrefRangeEnd = 427817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0001DF50 File Offset: 0x0001C150
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0001DF8C File Offset: 0x0001C18C
		public unsafe int UserResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_set_UserResult_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0001DFCC File Offset: 0x0001C1CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 427829, RefRangeEnd = 427832, XrefRangeStart = 427822, XrefRangeEnd = 427829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncProtocolRequest(MobileAuthenticatedStream parent, bool sync)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0001E028 File Offset: 0x0001C228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 427836, RefRangeEnd = 427838, XrefRangeStart = 427832, XrefRangeEnd = 427836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRead(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_RequestRead_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0001E068 File Offset: 0x0001C268
		[CallerCount(0)]
		public unsafe void RequestWrite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_RequestWrite_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0001E09C File Offset: 0x0001C29C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 427853, RefRangeEnd = 427855, XrefRangeStart = 427838, XrefRangeEnd = 427853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_StartOperation_Internal_Task_1_AsyncProtocolResult_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AsyncProtocolResult>>(intPtr3) : null;
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0001E0F4 File Offset: 0x0001C2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427855, XrefRangeEnd = 427866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ProcessOperation(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_ProcessOperation_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0001E14C File Offset: 0x0001C34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427866, XrefRangeEnd = 427881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<int>> InnerRead(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest.NativeMethodInfoPtr_InnerRead_Private_Task_1_Nullable_1_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0001E1A4 File Offset: 0x0001C3A4
		[CallerCount(0)]
		public unsafe virtual AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncProtocolRequest.NativeMethodInfoPtr_Run_Protected_Abstract_Virtual_New_AsyncOperationStatus_AsyncOperationStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427881, XrefRangeEnd = 427886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncProtocolRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002587 File Offset: 0x00000787
		public AsyncProtocolRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0001E23C File Offset: 0x0001C43C
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002590 File Offset: 0x00000790
		public unsafe MobileAuthenticatedStream _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0001E26C File Offset: 0x0001C46C
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000025AF File Offset: 0x000007AF
		public unsafe bool _RunSynchronously_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__RunSynchronously_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__RunSynchronously_k__BackingField)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0001E294 File Offset: 0x0001C494
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000025CA File Offset: 0x000007CA
		public unsafe int _UserResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__UserResult_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr__UserResult_k__BackingField)) = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0001E2BC File Offset: 0x0001C4BC
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000025E5 File Offset: 0x000007E5
		public unsafe int Started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_Started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_Started)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0001E2E4 File Offset: 0x0001C4E4
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002600 File Offset: 0x00000800
		public unsafe int RequestedSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_RequestedSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_RequestedSize)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0001E30C File Offset: 0x0001C50C
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000261B File Offset: 0x0000081B
		public unsafe int WriteRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_WriteRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_WriteRequested)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0001E334 File Offset: 0x0001C534
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002636 File Offset: 0x00000836
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr__RunSynchronously_k__BackingField;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr__UserResult_k__BackingField;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_Started;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_RequestedSize;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_WriteRequested;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_MobileAuthenticatedStream_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_get_RunSynchronously_Public_get_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_set_UserResult_Protected_set_Void_Int32_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MobileAuthenticatedStream_Boolean_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_RequestRead_Internal_Void_Int32_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_RequestWrite_Internal_Void_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_StartOperation_Internal_Task_1_AsyncProtocolResult_CancellationToken_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOperation_Private_Task_CancellationToken_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_InnerRead_Private_Task_1_Nullable_1_Int32_CancellationToken_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_Run_Protected_Abstract_Virtual_New_AsyncOperationStatus_AsyncOperationStatus_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000297 RID: 663
		[ObfuscatedName("Mono.Net.Security.AsyncProtocolRequest+<StartOperation>d__23")]
		public sealed class _StartOperation_d__23 : ValueType
		{
			// Token: 0x06002A15 RID: 10773 RVA: 0x000BD568 File Offset: 0x000BB768
			// Note: this type is marked as 'beforefieldinit'.
			static _StartOperation_d__23()
			{
				Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<StartOperation>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr);
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "<>1__state");
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "<>t__builder");
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "<>4__this");
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "cancellationToken");
				AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, "<>u__1");
				AsyncProtocolRequest._StartOperation_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, 100663489);
				AsyncProtocolRequest._StartOperation_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr, 100663490);
			}

			// Token: 0x06002A16 RID: 10774 RVA: 0x000BD620 File Offset: 0x000BB820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427641, XrefRangeEnd = 427680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._StartOperation_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A17 RID: 10775 RVA: 0x000BD658 File Offset: 0x000BB858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427680, XrefRangeEnd = 427686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._StartOperation_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A18 RID: 10776 RVA: 0x00012614 File Offset: 0x00010814
			public _StartOperation_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002A19 RID: 10777 RVA: 0x0001261D File Offset: 0x0001081D
			public _StartOperation_d__23()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolRequest._StartOperation_d__23>.NativeClassPtr))
			{
			}

			// Token: 0x17000D4E RID: 3406
			// (get) Token: 0x06002A1A RID: 10778 RVA: 0x000BD6A0 File Offset: 0x000BB8A0
			// (set) Token: 0x06002A1B RID: 10779 RVA: 0x0001262F File Offset: 0x0001082F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D4F RID: 3407
			// (get) Token: 0x06002A1C RID: 10780 RVA: 0x000BD6C8 File Offset: 0x000BB8C8
			// (set) Token: 0x06002A1D RID: 10781 RVA: 0x0001264A File Offset: 0x0001084A
			public AsyncTaskMethodBuilder<AsyncProtocolResult> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<AsyncProtocolResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AsyncProtocolResult>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AsyncProtocolResult>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D50 RID: 3408
			// (get) Token: 0x06002A1E RID: 10782 RVA: 0x000BD6F8 File Offset: 0x000BB8F8
			// (set) Token: 0x06002A1F RID: 10783 RVA: 0x00012678 File Offset: 0x00010878
			public unsafe AsyncProtocolRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D51 RID: 3409
			// (get) Token: 0x06002A20 RID: 10784 RVA: 0x000BD728 File Offset: 0x000BB928
			// (set) Token: 0x06002A21 RID: 10785 RVA: 0x00012697 File Offset: 0x00010897
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D52 RID: 3410
			// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000BD758 File Offset: 0x000BB958
			// (set) Token: 0x06002A23 RID: 10787 RVA: 0x000126C5 File Offset: 0x000108C5
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._StartOperation_d__23.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002159 RID: 8537
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400215A RID: 8538
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400215B RID: 8539
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400215C RID: 8540
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400215D RID: 8541
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400215E RID: 8542
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400215F RID: 8543
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000298 RID: 664
		[ObfuscatedName("Mono.Net.Security.AsyncProtocolRequest+<ProcessOperation>d__24")]
		public sealed class _ProcessOperation_d__24 : ValueType
		{
			// Token: 0x06002A24 RID: 10788 RVA: 0x000BD788 File Offset: 0x000BB988
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessOperation_d__24()
			{
				Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<ProcessOperation>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr);
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>1__state");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>t__builder");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "cancellationToken");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>4__this");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__status_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<status>5__2");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__newStatus_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<newStatus>5__3");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>u__1");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, "<>u__2");
				AsyncProtocolRequest._ProcessOperation_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, 100663491);
				AsyncProtocolRequest._ProcessOperation_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr, 100663492);
			}

			// Token: 0x06002A25 RID: 10789 RVA: 0x000BD87C File Offset: 0x000BBA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427686, XrefRangeEnd = 427754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._ProcessOperation_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A26 RID: 10790 RVA: 0x000BD8B4 File Offset: 0x000BBAB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427754, XrefRangeEnd = 427758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._ProcessOperation_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A27 RID: 10791 RVA: 0x000126F3 File Offset: 0x000108F3
			public _ProcessOperation_d__24(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002A28 RID: 10792 RVA: 0x000126FC File Offset: 0x000108FC
			public _ProcessOperation_d__24()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolRequest._ProcessOperation_d__24>.NativeClassPtr))
			{
			}

			// Token: 0x17000D53 RID: 3411
			// (get) Token: 0x06002A29 RID: 10793 RVA: 0x000BD8FC File Offset: 0x000BBAFC
			// (set) Token: 0x06002A2A RID: 10794 RVA: 0x0001270E File Offset: 0x0001090E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D54 RID: 3412
			// (get) Token: 0x06002A2B RID: 10795 RVA: 0x000BD924 File Offset: 0x000BBB24
			// (set) Token: 0x06002A2C RID: 10796 RVA: 0x00012729 File Offset: 0x00010929
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D55 RID: 3413
			// (get) Token: 0x06002A2D RID: 10797 RVA: 0x000BD954 File Offset: 0x000BBB54
			// (set) Token: 0x06002A2E RID: 10798 RVA: 0x00012757 File Offset: 0x00010957
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D56 RID: 3414
			// (get) Token: 0x06002A2F RID: 10799 RVA: 0x000BD984 File Offset: 0x000BBB84
			// (set) Token: 0x06002A30 RID: 10800 RVA: 0x00012785 File Offset: 0x00010985
			public unsafe AsyncProtocolRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D57 RID: 3415
			// (get) Token: 0x06002A31 RID: 10801 RVA: 0x000BD9B4 File Offset: 0x000BBBB4
			// (set) Token: 0x06002A32 RID: 10802 RVA: 0x000127A4 File Offset: 0x000109A4
			public unsafe AsyncOperationStatus _status_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__status_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__status_5__2)) = value;
				}
			}

			// Token: 0x17000D58 RID: 3416
			// (get) Token: 0x06002A33 RID: 10803 RVA: 0x000BD9DC File Offset: 0x000BBBDC
			// (set) Token: 0x06002A34 RID: 10804 RVA: 0x000127BF File Offset: 0x000109BF
			public unsafe AsyncOperationStatus _newStatus_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__newStatus_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr__newStatus_5__3)) = value;
				}
			}

			// Token: 0x17000D59 RID: 3417
			// (get) Token: 0x06002A35 RID: 10805 RVA: 0x000BDA04 File Offset: 0x000BBC04
			// (set) Token: 0x06002A36 RID: 10806 RVA: 0x000127DA File Offset: 0x000109DA
			public ConfiguredTaskAwaitable<Nullable<int>>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Nullable<int>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Nullable<int>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Nullable<int>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D5A RID: 3418
			// (get) Token: 0x06002A37 RID: 10807 RVA: 0x000BDA34 File Offset: 0x000BBC34
			// (set) Token: 0x06002A38 RID: 10808 RVA: 0x00012808 File Offset: 0x00010A08
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._ProcessOperation_d__24.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002160 RID: 8544
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002161 RID: 8545
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002162 RID: 8546
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04002163 RID: 8547
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002164 RID: 8548
			private static readonly IntPtr NativeFieldInfoPtr__status_5__2;

			// Token: 0x04002165 RID: 8549
			private static readonly IntPtr NativeFieldInfoPtr__newStatus_5__3;

			// Token: 0x04002166 RID: 8550
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002167 RID: 8551
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04002168 RID: 8552
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002169 RID: 8553
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000299 RID: 665
		[ObfuscatedName("Mono.Net.Security.AsyncProtocolRequest+<InnerRead>d__25")]
		public sealed class _InnerRead_d__25 : ValueType
		{
			// Token: 0x06002A39 RID: 10809 RVA: 0x000BDA64 File Offset: 0x000BBC64
			// Note: this type is marked as 'beforefieldinit'.
			static _InnerRead_d__25()
			{
				Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncProtocolRequest>.NativeClassPtr, "<InnerRead>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr);
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<>1__state");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<>t__builder");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<>4__this");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "cancellationToken");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__totalRead_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<totalRead>5__2");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__requestedSize_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<requestedSize>5__3");
				AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, "<>u__1");
				AsyncProtocolRequest._InnerRead_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, 100663493);
				AsyncProtocolRequest._InnerRead_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr, 100663494);
			}

			// Token: 0x06002A3A RID: 10810 RVA: 0x000BDB44 File Offset: 0x000BBD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427758, XrefRangeEnd = 427809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._InnerRead_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002A3B RID: 10811 RVA: 0x000BDB7C File Offset: 0x000BBD7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 427809, XrefRangeEnd = 427815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolRequest._InnerRead_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002A3C RID: 10812 RVA: 0x00012836 File Offset: 0x00010A36
			public _InnerRead_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002A3D RID: 10813 RVA: 0x0001283F File Offset: 0x00010A3F
			public _InnerRead_d__25()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolRequest._InnerRead_d__25>.NativeClassPtr))
			{
			}

			// Token: 0x17000D5B RID: 3419
			// (get) Token: 0x06002A3E RID: 10814 RVA: 0x000BDBC4 File Offset: 0x000BBDC4
			// (set) Token: 0x06002A3F RID: 10815 RVA: 0x00012851 File Offset: 0x00010A51
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D5C RID: 3420
			// (get) Token: 0x06002A40 RID: 10816 RVA: 0x000BDBEC File Offset: 0x000BBDEC
			// (set) Token: 0x06002A41 RID: 10817 RVA: 0x0001286C File Offset: 0x00010A6C
			public AsyncTaskMethodBuilder<Nullable<int>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D5D RID: 3421
			// (get) Token: 0x06002A42 RID: 10818 RVA: 0x000BDC1C File Offset: 0x000BBE1C
			// (set) Token: 0x06002A43 RID: 10819 RVA: 0x0001289A File Offset: 0x00010A9A
			public unsafe AsyncProtocolRequest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncProtocolRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D5E RID: 3422
			// (get) Token: 0x06002A44 RID: 10820 RVA: 0x000BDC4C File Offset: 0x000BBE4C
			// (set) Token: 0x06002A45 RID: 10821 RVA: 0x000128B9 File Offset: 0x00010AB9
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D5F RID: 3423
			// (get) Token: 0x06002A46 RID: 10822 RVA: 0x000BDC7C File Offset: 0x000BBE7C
			// (set) Token: 0x06002A47 RID: 10823 RVA: 0x000128E7 File Offset: 0x00010AE7
			public Nullable<int> _totalRead_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__totalRead_5__2);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__totalRead_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000D60 RID: 3424
			// (get) Token: 0x06002A48 RID: 10824 RVA: 0x000BDCAC File Offset: 0x000BBEAC
			// (set) Token: 0x06002A49 RID: 10825 RVA: 0x00012915 File Offset: 0x00010B15
			public unsafe int _requestedSize_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__requestedSize_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr__requestedSize_5__3)) = value;
				}
			}

			// Token: 0x17000D61 RID: 3425
			// (get) Token: 0x06002A4A RID: 10826 RVA: 0x000BDCD4 File Offset: 0x000BBED4
			// (set) Token: 0x06002A4B RID: 10827 RVA: 0x00012930 File Offset: 0x00010B30
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolRequest._InnerRead_d__25.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400216A RID: 8554
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400216B RID: 8555
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400216C RID: 8556
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400216D RID: 8557
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400216E RID: 8558
			private static readonly IntPtr NativeFieldInfoPtr__totalRead_5__2;

			// Token: 0x0400216F RID: 8559
			private static readonly IntPtr NativeFieldInfoPtr__requestedSize_5__3;

			// Token: 0x04002170 RID: 8560
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002171 RID: 8561
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002172 RID: 8562
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
