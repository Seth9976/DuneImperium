using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000004 RID: 4
	public sealed class CallResult<T> : ValueType, INotifyCompletion where T : new()
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000EAB8 File Offset: 0x0000CCB8
		// Note: this type is marked as 'beforefieldinit'.
		static CallResult()
		{
			Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "CallResult`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr);
			CallResult<T>.NativeFieldInfoPtr_call = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, "call");
			CallResult<T>.NativeFieldInfoPtr_utils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, "utils");
			CallResult<T>.NativeFieldInfoPtr_server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, "server");
			CallResult<T>.NativeMethodInfoPtr__ctor_Public_Void_SteamAPICall_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100663299);
			CallResult<T>.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100663300);
			CallResult<T>.NativeMethodInfoPtr_GetResult_Public_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100663301);
			CallResult<T>.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100663302);
			CallResult<T>.NativeMethodInfoPtr_GetAwaiter_Internal_CallResult_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr, 100663303);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 929072, RefRangeEnd = 929073, XrefRangeStart = 929054, XrefRangeEnd = 929072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult(SteamAPICall_t call, bool server)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref call;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr__ctor_Public_Void_SteamAPICall_t_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000EC20 File Offset: 0x0000CE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929073, XrefRangeEnd = 929190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000EC68 File Offset: 0x0000CE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 929190, XrefRangeEnd = 929253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<T> GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_GetResult_Public_Nullable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<T>(intPtr);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
		public unsafe bool IsCompleted
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 929254, RefRangeEnd = 929304, XrefRangeStart = 929253, XrefRangeEnd = 929254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 681416, RefRangeEnd = 681465, XrefRangeStart = 681416, XrefRangeEnd = 681465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<T> GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult<T>.NativeMethodInfoPtr_GetAwaiter_Internal_CallResult_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<T>(intPtr);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020D4 File Offset: 0x000002D4
		public CallResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020DD File Offset: 0x000002DD
		public CallResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallResult<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000ED24 File Offset: 0x0000CF24
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000020EF File Offset: 0x000002EF
		public unsafe SteamAPICall_t call
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallResult<T>.NativeFieldInfoPtr_call);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallResult<T>.NativeFieldInfoPtr_call)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000ED4C File Offset: 0x0000CF4C
		// (set) Token: 0x06000012 RID: 18 RVA: 0x0000210A File Offset: 0x0000030A
		public unsafe ISteamUtils utils
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallResult<T>.NativeFieldInfoPtr_utils);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamUtils>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallResult<T>.NativeFieldInfoPtr_utils), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000ED7C File Offset: 0x0000CF7C
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002129 File Offset: 0x00000329
		public unsafe bool server
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallResult<T>.NativeFieldInfoPtr_server);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallResult<T>.NativeFieldInfoPtr_server)) = value;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002144 File Offset: 0x00000344
		public void OnCompleted(Action continuation)
		{
			this.OnCompleted(continuation);
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_call;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_utils;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_server;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SteamAPICall_t_Boolean_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Nullable_1_T_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Internal_CallResult_1_T_0;
	}
}
