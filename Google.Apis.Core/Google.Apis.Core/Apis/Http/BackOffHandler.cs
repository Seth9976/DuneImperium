using System;
using Google.Apis.Logging;
using Google.Apis.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Http
{
	// Token: 0x02000025 RID: 37
	public class BackOffHandler : Object
	{
		// Token: 0x06000171 RID: 369 RVA: 0x00009960 File Offset: 0x00007B60
		// Note: this type is marked as 'beforefieldinit'.
		static BackOffHandler()
		{
			Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "BackOffHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr);
			BackOffHandler.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, "Logger");
			BackOffHandler.NativeFieldInfoPtr__BackOff_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, "<BackOff>k__BackingField");
			BackOffHandler.NativeFieldInfoPtr__MaxTimeSpan_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, "<MaxTimeSpan>k__BackingField");
			BackOffHandler.NativeFieldInfoPtr__HandleUnsuccessfulResponseFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, "<HandleUnsuccessfulResponseFunc>k__BackingField");
			BackOffHandler.NativeFieldInfoPtr__HandleExceptionFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, "<HandleExceptionFunc>k__BackingField");
			BackOffHandler.NativeMethodInfoPtr_get_BackOff_Public_get_IBackOff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663522);
			BackOffHandler.NativeMethodInfoPtr_set_BackOff_Private_set_Void_IBackOff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663523);
			BackOffHandler.NativeMethodInfoPtr_get_MaxTimeSpan_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663524);
			BackOffHandler.NativeMethodInfoPtr_set_MaxTimeSpan_Private_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663525);
			BackOffHandler.NativeMethodInfoPtr_get_HandleUnsuccessfulResponseFunc_Public_get_Func_2_HttpResponseMessage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663526);
			BackOffHandler.NativeMethodInfoPtr_set_HandleUnsuccessfulResponseFunc_Private_set_Void_Func_2_HttpResponseMessage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663527);
			BackOffHandler.NativeMethodInfoPtr_get_HandleExceptionFunc_Public_get_Func_2_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663528);
			BackOffHandler.NativeMethodInfoPtr_set_HandleExceptionFunc_Private_set_Void_Func_2_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663529);
			BackOffHandler.NativeMethodInfoPtr__ctor_Public_Void_IBackOff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663530);
			BackOffHandler.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663531);
			BackOffHandler.NativeMethodInfoPtr_HandleResponseAsync_Public_Virtual_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663532);
			BackOffHandler.NativeMethodInfoPtr_HandleExceptionAsync_Public_Virtual_New_Task_1_Boolean_HandleExceptionArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663533);
			BackOffHandler.NativeMethodInfoPtr_HandleAsync_Private_Task_1_Boolean_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663534);
			BackOffHandler.NativeMethodInfoPtr_Wait_Protected_Virtual_New_Task_TimeSpan_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, 100663535);
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00009B0C File Offset: 0x00007D0C
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00009B4C File Offset: 0x00007D4C
		public unsafe IBackOff BackOff
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.NativeMethodInfoPtr_get_BackOff_Public_get_IBackOff_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBackOff>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.NativeMethodInfoPtr_set_BackOff_Private_set_Void_IBackOff_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00009B90 File Offset: 0x00007D90
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00009BCC File Offset: 0x00007DCC
		public unsafe TimeSpan MaxTimeSpan
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.NativeMethodInfoPtr_get_MaxTimeSpan_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.NativeMethodInfoPtr_set_MaxTimeSpan_Private_set_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00009C0C File Offset: 0x00007E0C
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00009C4C File Offset: 0x00007E4C
		public unsafe Func<HttpResponseMessage, bool> HandleUnsuccessfulResponseFunc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.NativeMethodInfoPtr_get_HandleUnsuccessfulResponseFunc_Public_get_Func_2_HttpResponseMessage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<HttpResponseMessage, bool>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.NativeMethodInfoPtr_set_HandleUnsuccessfulResponseFunc_Private_set_Void_Func_2_HttpResponseMessage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00009C90 File Offset: 0x00007E90
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00009CD0 File Offset: 0x00007ED0
		public unsafe Func<Exception, bool> HandleExceptionFunc
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.NativeMethodInfoPtr_get_HandleExceptionFunc_Public_get_Func_2_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Exception, bool>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.NativeMethodInfoPtr_set_HandleExceptionFunc_Private_set_Void_Func_2_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00009D14 File Offset: 0x00007F14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1211497, RefRangeEnd = 1211500, XrefRangeStart = 1211477, XrefRangeEnd = 1211497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackOffHandler(IBackOff backOff)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(backOff);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.NativeMethodInfoPtr__ctor_Public_Void_IBackOff_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00009D60 File Offset: 0x00007F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211500, XrefRangeEnd = 1211505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackOffHandler(BackOffHandler.Initializer initializer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00009DAC File Offset: 0x00007FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211505, XrefRangeEnd = 1211520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<bool> HandleResponseAsync(HandleUnsuccessfulResponseArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BackOffHandler.NativeMethodInfoPtr_HandleResponseAsync_Public_Virtual_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00009E08 File Offset: 0x00008008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211520, XrefRangeEnd = 1211535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<bool> HandleExceptionAsync(HandleExceptionArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BackOffHandler.NativeMethodInfoPtr_HandleExceptionAsync_Public_Virtual_New_Task_1_Boolean_HandleExceptionArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00009E64 File Offset: 0x00008064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1211550, RefRangeEnd = 1211552, XrefRangeStart = 1211535, XrefRangeEnd = 1211550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> HandleAsync(bool supportsRetry, int currentFailedTry, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref supportsRetry;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentFailedTry;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.NativeMethodInfoPtr_HandleAsync_Private_Task_1_Boolean_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00009ED8 File Offset: 0x000080D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211552, XrefRangeEnd = 1211562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task Wait(TimeSpan ts, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ts;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BackOffHandler.NativeMethodInfoPtr_Wait_Protected_Virtual_New_Task_TimeSpan_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000028AA File Offset: 0x00000AAA
		public BackOffHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00009F48 File Offset: 0x00008148
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000028B3 File Offset: 0x00000AB3
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BackOffHandler.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BackOffHandler.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00009F70 File Offset: 0x00008170
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000028C5 File Offset: 0x00000AC5
		public unsafe IBackOff _BackOff_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.NativeFieldInfoPtr__BackOff_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IBackOff>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.NativeFieldInfoPtr__BackOff_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00009FA0 File Offset: 0x000081A0
		// (set) Token: 0x06000186 RID: 390 RVA: 0x000028E4 File Offset: 0x00000AE4
		public unsafe TimeSpan _MaxTimeSpan_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.NativeFieldInfoPtr__MaxTimeSpan_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.NativeFieldInfoPtr__MaxTimeSpan_k__BackingField)) = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00009FC8 File Offset: 0x000081C8
		// (set) Token: 0x06000188 RID: 392 RVA: 0x000028FF File Offset: 0x00000AFF
		public unsafe Func<HttpResponseMessage, bool> _HandleUnsuccessfulResponseFunc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.NativeFieldInfoPtr__HandleUnsuccessfulResponseFunc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<HttpResponseMessage, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.NativeFieldInfoPtr__HandleUnsuccessfulResponseFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00009FF8 File Offset: 0x000081F8
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0000291E File Offset: 0x00000B1E
		public unsafe Func<Exception, bool> _HandleExceptionFunc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.NativeFieldInfoPtr__HandleExceptionFunc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Exception, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.NativeFieldInfoPtr__HandleExceptionFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr__BackOff_k__BackingField;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr__MaxTimeSpan_k__BackingField;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr__HandleUnsuccessfulResponseFunc_k__BackingField;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr__HandleExceptionFunc_k__BackingField;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_get_BackOff_Public_get_IBackOff_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_set_BackOff_Private_set_Void_IBackOff_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxTimeSpan_Public_get_TimeSpan_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxTimeSpan_Private_set_Void_TimeSpan_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleUnsuccessfulResponseFunc_Public_get_Func_2_HttpResponseMessage_Boolean_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_set_HandleUnsuccessfulResponseFunc_Private_set_Void_Func_2_HttpResponseMessage_Boolean_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_get_HandleExceptionFunc_Public_get_Func_2_Exception_Boolean_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_set_HandleExceptionFunc_Private_set_Void_Func_2_Exception_Boolean_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IBackOff_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Initializer_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_HandleResponseAsync_Public_Virtual_New_Task_1_Boolean_HandleUnsuccessfulResponseArgs_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_HandleExceptionAsync_Public_Virtual_New_Task_1_Boolean_HandleExceptionArgs_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_HandleAsync_Private_Task_1_Boolean_Boolean_Int32_CancellationToken_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Protected_Virtual_New_Task_TimeSpan_CancellationToken_0;

		// Token: 0x02000056 RID: 86
		public class Initializer : Object
		{
			// Token: 0x06000313 RID: 787 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
			// Note: this type is marked as 'beforefieldinit'.
			static Initializer()
			{
				Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, "Initializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr);
				BackOffHandler.Initializer.NativeFieldInfoPtr__BackOff_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, "<BackOff>k__BackingField");
				BackOffHandler.Initializer.NativeFieldInfoPtr__MaxTimeSpan_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, "<MaxTimeSpan>k__BackingField");
				BackOffHandler.Initializer.NativeFieldInfoPtr__HandleUnsuccessfulResponseFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, "<HandleUnsuccessfulResponseFunc>k__BackingField");
				BackOffHandler.Initializer.NativeFieldInfoPtr__HandleExceptionFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, "<HandleExceptionFunc>k__BackingField");
				BackOffHandler.Initializer.NativeFieldInfoPtr_DefaultHandleUnsuccessfulResponseFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, "DefaultHandleUnsuccessfulResponseFunc");
				BackOffHandler.Initializer.NativeFieldInfoPtr_DefaultHandleExceptionFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, "DefaultHandleExceptionFunc");
				BackOffHandler.Initializer.NativeMethodInfoPtr_get_BackOff_Public_get_IBackOff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, 100663537);
				BackOffHandler.Initializer.NativeMethodInfoPtr_set_BackOff_Private_set_Void_IBackOff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, 100663538);
				BackOffHandler.Initializer.NativeMethodInfoPtr_get_MaxTimeSpan_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, 100663539);
				BackOffHandler.Initializer.NativeMethodInfoPtr_set_MaxTimeSpan_Public_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, 100663540);
				BackOffHandler.Initializer.NativeMethodInfoPtr_get_HandleUnsuccessfulResponseFunc_Public_get_Func_2_HttpResponseMessage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, 100663541);
				BackOffHandler.Initializer.NativeMethodInfoPtr_set_HandleUnsuccessfulResponseFunc_Public_set_Void_Func_2_HttpResponseMessage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, 100663542);
				BackOffHandler.Initializer.NativeMethodInfoPtr_get_HandleExceptionFunc_Public_get_Func_2_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, 100663543);
				BackOffHandler.Initializer.NativeMethodInfoPtr_set_HandleExceptionFunc_Public_set_Void_Func_2_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, 100663544);
				BackOffHandler.Initializer.NativeMethodInfoPtr__ctor_Public_Void_IBackOff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, 100663545);
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x06000314 RID: 788 RVA: 0x0000F64C File Offset: 0x0000D84C
			// (set) Token: 0x06000315 RID: 789 RVA: 0x0000F68C File Offset: 0x0000D88C
			public unsafe IBackOff BackOff
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.Initializer.NativeMethodInfoPtr_get_BackOff_Public_get_IBackOff_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBackOff>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.Initializer.NativeMethodInfoPtr_set_BackOff_Private_set_Void_IBackOff_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x06000316 RID: 790 RVA: 0x0000F6D0 File Offset: 0x0000D8D0
			// (set) Token: 0x06000317 RID: 791 RVA: 0x0000F70C File Offset: 0x0000D90C
			public unsafe TimeSpan MaxTimeSpan
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.Initializer.NativeMethodInfoPtr_get_MaxTimeSpan_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.Initializer.NativeMethodInfoPtr_set_MaxTimeSpan_Public_set_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x06000318 RID: 792 RVA: 0x0000F74C File Offset: 0x0000D94C
			// (set) Token: 0x06000319 RID: 793 RVA: 0x0000F78C File Offset: 0x0000D98C
			public unsafe Func<HttpResponseMessage, bool> HandleUnsuccessfulResponseFunc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.Initializer.NativeMethodInfoPtr_get_HandleUnsuccessfulResponseFunc_Public_get_Func_2_HttpResponseMessage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<HttpResponseMessage, bool>>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.Initializer.NativeMethodInfoPtr_set_HandleUnsuccessfulResponseFunc_Public_set_Void_Func_2_HttpResponseMessage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x0600031A RID: 794 RVA: 0x0000F7D0 File Offset: 0x0000D9D0
			// (set) Token: 0x0600031B RID: 795 RVA: 0x0000F810 File Offset: 0x0000DA10
			public unsafe Func<Exception, bool> HandleExceptionFunc
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.Initializer.NativeMethodInfoPtr_get_HandleExceptionFunc_Public_get_Func_2_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Exception, bool>>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.Initializer.NativeMethodInfoPtr_set_HandleExceptionFunc_Public_set_Void_Func_2_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600031C RID: 796 RVA: 0x0000F854 File Offset: 0x0000DA54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211323, XrefRangeEnd = 1211336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initializer(IBackOff backOff)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(backOff);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.Initializer.NativeMethodInfoPtr__ctor_Public_Void_IBackOff_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600031D RID: 797 RVA: 0x000033D3 File Offset: 0x000015D3
			public Initializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x0600031E RID: 798 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
			// (set) Token: 0x0600031F RID: 799 RVA: 0x000033DC File Offset: 0x000015DC
			public unsafe IBackOff _BackOff_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.Initializer.NativeFieldInfoPtr__BackOff_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IBackOff>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.Initializer.NativeFieldInfoPtr__BackOff_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x06000320 RID: 800 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
			// (set) Token: 0x06000321 RID: 801 RVA: 0x000033FB File Offset: 0x000015FB
			public unsafe TimeSpan _MaxTimeSpan_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.Initializer.NativeFieldInfoPtr__MaxTimeSpan_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.Initializer.NativeFieldInfoPtr__MaxTimeSpan_k__BackingField)) = value;
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x06000322 RID: 802 RVA: 0x0000F8F8 File Offset: 0x0000DAF8
			// (set) Token: 0x06000323 RID: 803 RVA: 0x00003416 File Offset: 0x00001616
			public unsafe Func<HttpResponseMessage, bool> _HandleUnsuccessfulResponseFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.Initializer.NativeFieldInfoPtr__HandleUnsuccessfulResponseFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<HttpResponseMessage, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.Initializer.NativeFieldInfoPtr__HandleUnsuccessfulResponseFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x06000324 RID: 804 RVA: 0x0000F928 File Offset: 0x0000DB28
			// (set) Token: 0x06000325 RID: 805 RVA: 0x00003435 File Offset: 0x00001635
			public unsafe Func<Exception, bool> _HandleExceptionFunc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.Initializer.NativeFieldInfoPtr__HandleExceptionFunc_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Exception, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler.Initializer.NativeFieldInfoPtr__HandleExceptionFunc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x06000326 RID: 806 RVA: 0x0000F958 File Offset: 0x0000DB58
			// (set) Token: 0x06000327 RID: 807 RVA: 0x00003454 File Offset: 0x00001654
			public unsafe static Func<HttpResponseMessage, bool> DefaultHandleUnsuccessfulResponseFunc
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BackOffHandler.Initializer.NativeFieldInfoPtr_DefaultHandleUnsuccessfulResponseFunc, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<HttpResponseMessage, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BackOffHandler.Initializer.NativeFieldInfoPtr_DefaultHandleUnsuccessfulResponseFunc, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x06000328 RID: 808 RVA: 0x0000F980 File Offset: 0x0000DB80
			// (set) Token: 0x06000329 RID: 809 RVA: 0x00003466 File Offset: 0x00001666
			public unsafe static Func<Exception, bool> DefaultHandleExceptionFunc
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BackOffHandler.Initializer.NativeFieldInfoPtr_DefaultHandleExceptionFunc, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Exception, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BackOffHandler.Initializer.NativeFieldInfoPtr_DefaultHandleExceptionFunc, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400020E RID: 526
			private static readonly IntPtr NativeFieldInfoPtr__BackOff_k__BackingField;

			// Token: 0x0400020F RID: 527
			private static readonly IntPtr NativeFieldInfoPtr__MaxTimeSpan_k__BackingField;

			// Token: 0x04000210 RID: 528
			private static readonly IntPtr NativeFieldInfoPtr__HandleUnsuccessfulResponseFunc_k__BackingField;

			// Token: 0x04000211 RID: 529
			private static readonly IntPtr NativeFieldInfoPtr__HandleExceptionFunc_k__BackingField;

			// Token: 0x04000212 RID: 530
			private static readonly IntPtr NativeFieldInfoPtr_DefaultHandleUnsuccessfulResponseFunc;

			// Token: 0x04000213 RID: 531
			private static readonly IntPtr NativeFieldInfoPtr_DefaultHandleExceptionFunc;

			// Token: 0x04000214 RID: 532
			private static readonly IntPtr NativeMethodInfoPtr_get_BackOff_Public_get_IBackOff_0;

			// Token: 0x04000215 RID: 533
			private static readonly IntPtr NativeMethodInfoPtr_set_BackOff_Private_set_Void_IBackOff_0;

			// Token: 0x04000216 RID: 534
			private static readonly IntPtr NativeMethodInfoPtr_get_MaxTimeSpan_Public_get_TimeSpan_0;

			// Token: 0x04000217 RID: 535
			private static readonly IntPtr NativeMethodInfoPtr_set_MaxTimeSpan_Public_set_Void_TimeSpan_0;

			// Token: 0x04000218 RID: 536
			private static readonly IntPtr NativeMethodInfoPtr_get_HandleUnsuccessfulResponseFunc_Public_get_Func_2_HttpResponseMessage_Boolean_0;

			// Token: 0x04000219 RID: 537
			private static readonly IntPtr NativeMethodInfoPtr_set_HandleUnsuccessfulResponseFunc_Public_set_Void_Func_2_HttpResponseMessage_Boolean_0;

			// Token: 0x0400021A RID: 538
			private static readonly IntPtr NativeMethodInfoPtr_get_HandleExceptionFunc_Public_get_Func_2_Exception_Boolean_0;

			// Token: 0x0400021B RID: 539
			private static readonly IntPtr NativeMethodInfoPtr_set_HandleExceptionFunc_Public_set_Void_Func_2_Exception_Boolean_0;

			// Token: 0x0400021C RID: 540
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IBackOff_0;

			// Token: 0x02000067 RID: 103
			[ObfuscatedName("Google.Apis.Http.BackOffHandler+Initializer+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06000417 RID: 1047 RVA: 0x00011F1C File Offset: 0x0001011C
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<BackOffHandler.Initializer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BackOffHandler.Initializer>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackOffHandler.Initializer.__c>.NativeClassPtr);
					BackOffHandler.Initializer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler.Initializer.__c>.NativeClassPtr, "<>9");
					BackOffHandler.Initializer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler.Initializer.__c>.NativeClassPtr, 100663548);
					BackOffHandler.Initializer.__c.NativeMethodInfoPtr___cctor_b__19_0_Internal_Boolean_HttpResponseMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler.Initializer.__c>.NativeClassPtr, 100663549);
					BackOffHandler.Initializer.__c.NativeMethodInfoPtr___cctor_b__19_1_Internal_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler.Initializer.__c>.NativeClassPtr, 100663550);
				}

				// Token: 0x06000418 RID: 1048 RVA: 0x00011F98 File Offset: 0x00010198
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackOffHandler.Initializer.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.Initializer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000419 RID: 1049 RVA: 0x00011FD4 File Offset: 0x000101D4
				[CallerCount(0)]
				public unsafe bool __cctor_b__19_0(HttpResponseMessage r)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.Initializer.__c.NativeMethodInfoPtr___cctor_b__19_0_Internal_Boolean_HttpResponseMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x0600041A RID: 1050 RVA: 0x00012024 File Offset: 0x00010224
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211320, XrefRangeEnd = 1211323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool __cctor_b__19_1(Exception ex)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler.Initializer.__c.NativeMethodInfoPtr___cctor_b__19_1_Internal_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x0600041B RID: 1051 RVA: 0x00004055 File Offset: 0x00002255
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000143 RID: 323
				// (get) Token: 0x0600041C RID: 1052 RVA: 0x00012074 File Offset: 0x00010274
				// (set) Token: 0x0600041D RID: 1053 RVA: 0x0000405E File Offset: 0x0000225E
				public unsafe static BackOffHandler.Initializer.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(BackOffHandler.Initializer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BackOffHandler.Initializer.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(BackOffHandler.Initializer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400029E RID: 670
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400029F RID: 671
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040002A0 RID: 672
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__19_0_Internal_Boolean_HttpResponseMessage_0;

				// Token: 0x040002A1 RID: 673
				private static readonly IntPtr NativeMethodInfoPtr___cctor_b__19_1_Internal_Boolean_Exception_0;
			}
		}

		// Token: 0x02000057 RID: 87
		[ObfuscatedName("Google.Apis.Http.BackOffHandler+<HandleResponseAsync>d__20")]
		public sealed class _HandleResponseAsync_d__20 : ValueType
		{
			// Token: 0x0600032A RID: 810 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleResponseAsync_d__20()
			{
				Il2CppClassPointerStore<BackOffHandler._HandleResponseAsync_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, "<HandleResponseAsync>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackOffHandler._HandleResponseAsync_d__20>.NativeClassPtr);
				BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleResponseAsync_d__20>.NativeClassPtr, "<>1__state");
				BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleResponseAsync_d__20>.NativeClassPtr, "<>t__builder");
				BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleResponseAsync_d__20>.NativeClassPtr, "<>4__this");
				BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleResponseAsync_d__20>.NativeClassPtr, "args");
				BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleResponseAsync_d__20>.NativeClassPtr, "<>u__1");
				BackOffHandler._HandleResponseAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler._HandleResponseAsync_d__20>.NativeClassPtr, 100663551);
				BackOffHandler._HandleResponseAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler._HandleResponseAsync_d__20>.NativeClassPtr, 100663552);
			}

			// Token: 0x0600032B RID: 811 RVA: 0x0000FA60 File Offset: 0x0000DC60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211336, XrefRangeEnd = 1211362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler._HandleResponseAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600032C RID: 812 RVA: 0x0000FA98 File Offset: 0x0000DC98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211362, XrefRangeEnd = 1211368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler._HandleResponseAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600032D RID: 813 RVA: 0x00003478 File Offset: 0x00001678
			public _HandleResponseAsync_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600032E RID: 814 RVA: 0x00003481 File Offset: 0x00001681
			public _HandleResponseAsync_d__20()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackOffHandler._HandleResponseAsync_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x0600032F RID: 815 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
			// (set) Token: 0x06000330 RID: 816 RVA: 0x00003493 File Offset: 0x00001693
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x06000331 RID: 817 RVA: 0x0000FB08 File Offset: 0x0000DD08
			// (set) Token: 0x06000332 RID: 818 RVA: 0x000034AE File Offset: 0x000016AE
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x06000333 RID: 819 RVA: 0x0000FB38 File Offset: 0x0000DD38
			// (set) Token: 0x06000334 RID: 820 RVA: 0x000034DC File Offset: 0x000016DC
			public unsafe BackOffHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BackOffHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x06000335 RID: 821 RVA: 0x0000FB68 File Offset: 0x0000DD68
			// (set) Token: 0x06000336 RID: 822 RVA: 0x000034FB File Offset: 0x000016FB
			public unsafe HandleUnsuccessfulResponseArgs args
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr_args);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandleUnsuccessfulResponseArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x06000337 RID: 823 RVA: 0x0000FB98 File Offset: 0x0000DD98
			// (set) Token: 0x06000338 RID: 824 RVA: 0x0000351A File Offset: 0x0000171A
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleResponseAsync_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400021D RID: 541
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400021E RID: 542
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400021F RID: 543
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000220 RID: 544
			private static readonly IntPtr NativeFieldInfoPtr_args;

			// Token: 0x04000221 RID: 545
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000222 RID: 546
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000223 RID: 547
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000058 RID: 88
		[ObfuscatedName("Google.Apis.Http.BackOffHandler+<HandleExceptionAsync>d__21")]
		public sealed class _HandleExceptionAsync_d__21 : ValueType
		{
			// Token: 0x06000339 RID: 825 RVA: 0x0000FBC8 File Offset: 0x0000DDC8
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleExceptionAsync_d__21()
			{
				Il2CppClassPointerStore<BackOffHandler._HandleExceptionAsync_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, "<HandleExceptionAsync>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackOffHandler._HandleExceptionAsync_d__21>.NativeClassPtr);
				BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleExceptionAsync_d__21>.NativeClassPtr, "<>1__state");
				BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleExceptionAsync_d__21>.NativeClassPtr, "<>t__builder");
				BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleExceptionAsync_d__21>.NativeClassPtr, "<>4__this");
				BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleExceptionAsync_d__21>.NativeClassPtr, "args");
				BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleExceptionAsync_d__21>.NativeClassPtr, "<>u__1");
				BackOffHandler._HandleExceptionAsync_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler._HandleExceptionAsync_d__21>.NativeClassPtr, 100663553);
				BackOffHandler._HandleExceptionAsync_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler._HandleExceptionAsync_d__21>.NativeClassPtr, 100663554);
			}

			// Token: 0x0600033A RID: 826 RVA: 0x0000FC80 File Offset: 0x0000DE80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211368, XrefRangeEnd = 1211394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler._HandleExceptionAsync_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600033B RID: 827 RVA: 0x0000FCB8 File Offset: 0x0000DEB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211394, XrefRangeEnd = 1211400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler._HandleExceptionAsync_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600033C RID: 828 RVA: 0x00003548 File Offset: 0x00001748
			public _HandleExceptionAsync_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600033D RID: 829 RVA: 0x00003551 File Offset: 0x00001751
			public _HandleExceptionAsync_d__21()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackOffHandler._HandleExceptionAsync_d__21>.NativeClassPtr))
			{
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x0600033E RID: 830 RVA: 0x0000FD00 File Offset: 0x0000DF00
			// (set) Token: 0x0600033F RID: 831 RVA: 0x00003563 File Offset: 0x00001763
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000340 RID: 832 RVA: 0x0000FD28 File Offset: 0x0000DF28
			// (set) Token: 0x06000341 RID: 833 RVA: 0x0000357E File Offset: 0x0000177E
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x06000342 RID: 834 RVA: 0x0000FD58 File Offset: 0x0000DF58
			// (set) Token: 0x06000343 RID: 835 RVA: 0x000035AC File Offset: 0x000017AC
			public unsafe BackOffHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BackOffHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x06000344 RID: 836 RVA: 0x0000FD88 File Offset: 0x0000DF88
			// (set) Token: 0x06000345 RID: 837 RVA: 0x000035CB File Offset: 0x000017CB
			public unsafe HandleExceptionArgs args
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr_args);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandleExceptionArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x06000346 RID: 838 RVA: 0x0000FDB8 File Offset: 0x0000DFB8
			// (set) Token: 0x06000347 RID: 839 RVA: 0x000035EA File Offset: 0x000017EA
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleExceptionAsync_d__21.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000224 RID: 548
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000225 RID: 549
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000226 RID: 550
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000227 RID: 551
			private static readonly IntPtr NativeFieldInfoPtr_args;

			// Token: 0x04000228 RID: 552
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000229 RID: 553
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400022A RID: 554
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000059 RID: 89
		[ObfuscatedName("Google.Apis.Http.BackOffHandler+<HandleAsync>d__22")]
		public sealed class _HandleAsync_d__22 : ValueType
		{
			// Token: 0x06000348 RID: 840 RVA: 0x0000FDE8 File Offset: 0x0000DFE8
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleAsync_d__22()
			{
				Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, "<HandleAsync>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr);
				BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr, "<>1__state");
				BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr, "<>t__builder");
				BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr_supportsRetry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr, "supportsRetry");
				BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr, "<>4__this");
				BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr_currentFailedTry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr, "currentFailedTry");
				BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr, "cancellationToken");
				BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr__ts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr, "<ts>5__2");
				BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr, "<>u__1");
				BackOffHandler._HandleAsync_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr, 100663555);
				BackOffHandler._HandleAsync_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr, 100663556);
			}

			// Token: 0x06000349 RID: 841 RVA: 0x0000FEDC File Offset: 0x0000E0DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211400, XrefRangeEnd = 1211454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler._HandleAsync_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600034A RID: 842 RVA: 0x0000FF14 File Offset: 0x0000E114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211454, XrefRangeEnd = 1211460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler._HandleAsync_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600034B RID: 843 RVA: 0x00003618 File Offset: 0x00001818
			public _HandleAsync_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600034C RID: 844 RVA: 0x00003621 File Offset: 0x00001821
			public _HandleAsync_d__22()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackOffHandler._HandleAsync_d__22>.NativeClassPtr))
			{
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x0600034D RID: 845 RVA: 0x0000FF5C File Offset: 0x0000E15C
			// (set) Token: 0x0600034E RID: 846 RVA: 0x00003633 File Offset: 0x00001833
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x0600034F RID: 847 RVA: 0x0000FF84 File Offset: 0x0000E184
			// (set) Token: 0x06000350 RID: 848 RVA: 0x0000364E File Offset: 0x0000184E
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x06000351 RID: 849 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
			// (set) Token: 0x06000352 RID: 850 RVA: 0x0000367C File Offset: 0x0000187C
			public unsafe bool supportsRetry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr_supportsRetry);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr_supportsRetry)) = value;
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000353 RID: 851 RVA: 0x0000FFDC File Offset: 0x0000E1DC
			// (set) Token: 0x06000354 RID: 852 RVA: 0x00003697 File Offset: 0x00001897
			public unsafe BackOffHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BackOffHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x06000355 RID: 853 RVA: 0x0001000C File Offset: 0x0000E20C
			// (set) Token: 0x06000356 RID: 854 RVA: 0x000036B6 File Offset: 0x000018B6
			public unsafe int currentFailedTry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr_currentFailedTry);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr_currentFailedTry)) = value;
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x06000357 RID: 855 RVA: 0x00010034 File Offset: 0x0000E234
			// (set) Token: 0x06000358 RID: 856 RVA: 0x000036D1 File Offset: 0x000018D1
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000359 RID: 857 RVA: 0x00010064 File Offset: 0x0000E264
			// (set) Token: 0x0600035A RID: 858 RVA: 0x000036FF File Offset: 0x000018FF
			public unsafe TimeSpan _ts_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr__ts_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr__ts_5__2)) = value;
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x0600035B RID: 859 RVA: 0x0001008C File Offset: 0x0000E28C
			// (set) Token: 0x0600035C RID: 860 RVA: 0x0000371A File Offset: 0x0000191A
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._HandleAsync_d__22.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400022B RID: 555
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400022C RID: 556
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400022D RID: 557
			private static readonly IntPtr NativeFieldInfoPtr_supportsRetry;

			// Token: 0x0400022E RID: 558
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400022F RID: 559
			private static readonly IntPtr NativeFieldInfoPtr_currentFailedTry;

			// Token: 0x04000230 RID: 560
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04000231 RID: 561
			private static readonly IntPtr NativeFieldInfoPtr__ts_5__2;

			// Token: 0x04000232 RID: 562
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000233 RID: 563
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000234 RID: 564
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200005A RID: 90
		[ObfuscatedName("Google.Apis.Http.BackOffHandler+<Wait>d__23")]
		public sealed class _Wait_d__23 : ValueType
		{
			// Token: 0x0600035D RID: 861 RVA: 0x000100BC File Offset: 0x0000E2BC
			// Note: this type is marked as 'beforefieldinit'.
			static _Wait_d__23()
			{
				Il2CppClassPointerStore<BackOffHandler._Wait_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BackOffHandler>.NativeClassPtr, "<Wait>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackOffHandler._Wait_d__23>.NativeClassPtr);
				BackOffHandler._Wait_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._Wait_d__23>.NativeClassPtr, "<>1__state");
				BackOffHandler._Wait_d__23.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._Wait_d__23>.NativeClassPtr, "<>t__builder");
				BackOffHandler._Wait_d__23.NativeFieldInfoPtr_ts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._Wait_d__23>.NativeClassPtr, "ts");
				BackOffHandler._Wait_d__23.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._Wait_d__23>.NativeClassPtr, "cancellationToken");
				BackOffHandler._Wait_d__23.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackOffHandler._Wait_d__23>.NativeClassPtr, "<>u__1");
				BackOffHandler._Wait_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler._Wait_d__23>.NativeClassPtr, 100663557);
				BackOffHandler._Wait_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackOffHandler._Wait_d__23>.NativeClassPtr, 100663558);
			}

			// Token: 0x0600035E RID: 862 RVA: 0x00010174 File Offset: 0x0000E374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211460, XrefRangeEnd = 1211473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler._Wait_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600035F RID: 863 RVA: 0x000101AC File Offset: 0x0000E3AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211473, XrefRangeEnd = 1211477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackOffHandler._Wait_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000360 RID: 864 RVA: 0x00003748 File Offset: 0x00001948
			public _Wait_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000361 RID: 865 RVA: 0x00003751 File Offset: 0x00001951
			public _Wait_d__23()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackOffHandler._Wait_d__23>.NativeClassPtr))
			{
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000362 RID: 866 RVA: 0x000101F4 File Offset: 0x0000E3F4
			// (set) Token: 0x06000363 RID: 867 RVA: 0x00003763 File Offset: 0x00001963
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._Wait_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._Wait_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x06000364 RID: 868 RVA: 0x0001021C File Offset: 0x0000E41C
			// (set) Token: 0x06000365 RID: 869 RVA: 0x0000377E File Offset: 0x0000197E
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._Wait_d__23.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._Wait_d__23.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x06000366 RID: 870 RVA: 0x0001024C File Offset: 0x0000E44C
			// (set) Token: 0x06000367 RID: 871 RVA: 0x000037AC File Offset: 0x000019AC
			public unsafe TimeSpan ts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._Wait_d__23.NativeFieldInfoPtr_ts);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._Wait_d__23.NativeFieldInfoPtr_ts)) = value;
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x06000368 RID: 872 RVA: 0x00010274 File Offset: 0x0000E474
			// (set) Token: 0x06000369 RID: 873 RVA: 0x000037C7 File Offset: 0x000019C7
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._Wait_d__23.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._Wait_d__23.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x0600036A RID: 874 RVA: 0x000102A4 File Offset: 0x0000E4A4
			// (set) Token: 0x0600036B RID: 875 RVA: 0x000037F5 File Offset: 0x000019F5
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._Wait_d__23.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackOffHandler._Wait_d__23.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000235 RID: 565
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000236 RID: 566
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000237 RID: 567
			private static readonly IntPtr NativeFieldInfoPtr_ts;

			// Token: 0x04000238 RID: 568
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04000239 RID: 569
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400023A RID: 570
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400023B RID: 571
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
