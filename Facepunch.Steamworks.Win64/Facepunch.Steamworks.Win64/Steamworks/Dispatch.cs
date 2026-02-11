using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000007 RID: 7
	public static class Dispatch : Object
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0000F014 File Offset: 0x0000D214
		// Note: this type is marked as 'beforefieldinit'.
		static Dispatch()
		{
			Il2CppClassPointerStore<Dispatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "Dispatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dispatch>.NativeClassPtr);
			Dispatch.NativeFieldInfoPtr_OnDebugCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "OnDebugCallback");
			Dispatch.NativeFieldInfoPtr_OnException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "OnException");
			Dispatch.NativeFieldInfoPtr__ClientPipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "<ClientPipe>k__BackingField");
			Dispatch.NativeFieldInfoPtr__ServerPipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "<ServerPipe>k__BackingField");
			Dispatch.NativeFieldInfoPtr_runningFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "runningFrame");
			Dispatch.NativeFieldInfoPtr_actionsToCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "actionsToCall");
			Dispatch.NativeFieldInfoPtr_ResultCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "ResultCallbacks");
			Dispatch.NativeFieldInfoPtr_Callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "Callbacks");
			Dispatch.NativeMethodInfoPtr_SteamAPI_ManualDispatch_Init_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663309);
			Dispatch.NativeMethodInfoPtr_SteamAPI_ManualDispatch_RunFrame_Internal_Static_Void_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663310);
			Dispatch.NativeMethodInfoPtr_SteamAPI_ManualDispatch_GetNextCallback_Internal_Static_Boolean_HSteamPipe_byref_CallbackMsg_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663311);
			Dispatch.NativeMethodInfoPtr_SteamAPI_ManualDispatch_FreeLastCallback_Internal_Static_Boolean_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663312);
			Dispatch.NativeMethodInfoPtr_get_ClientPipe_Internal_Static_get_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663313);
			Dispatch.NativeMethodInfoPtr_set_ClientPipe_Internal_Static_set_Void_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663314);
			Dispatch.NativeMethodInfoPtr_get_ServerPipe_Internal_Static_get_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663315);
			Dispatch.NativeMethodInfoPtr_set_ServerPipe_Internal_Static_set_Void_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663316);
			Dispatch.NativeMethodInfoPtr_Init_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663317);
			Dispatch.NativeMethodInfoPtr_Frame_Internal_Static_Void_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663318);
			Dispatch.NativeMethodInfoPtr_ProcessCallback_Private_Static_Void_CallbackMsg_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663319);
			Dispatch.NativeMethodInfoPtr_CallbackToString_Internal_Static_String_CallbackType_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663320);
			Dispatch.NativeMethodInfoPtr_ProcessResult_Private_Static_Void_CallbackMsg_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663321);
			Dispatch.NativeMethodInfoPtr_LoopClientAsync_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663322);
			Dispatch.NativeMethodInfoPtr_LoopServerAsync_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663323);
			Dispatch.NativeMethodInfoPtr_OnCallComplete_Internal_Static_Void_SteamAPICall_t_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663324);
			Dispatch.NativeMethodInfoPtr_Install_Internal_Static_Void_Action_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663325);
			Dispatch.NativeMethodInfoPtr_ShutdownServer_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663326);
			Dispatch.NativeMethodInfoPtr_ShutdownClient_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, 100663327);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000F260 File Offset: 0x0000D460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930452, XrefRangeEnd = 930454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SteamAPI_ManualDispatch_Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_SteamAPI_ManualDispatch_Init_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000F288 File Offset: 0x0000D488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930454, XrefRangeEnd = 930456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SteamAPI_ManualDispatch_RunFrame(HSteamPipe pipe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pipe;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_SteamAPI_ManualDispatch_RunFrame_Internal_Static_Void_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930456, XrefRangeEnd = 930458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe pipe, [In] [Out] ref Dispatch.CallbackMsg_t msg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pipe;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &msg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_SteamAPI_ManualDispatch_GetNextCallback_Internal_Static_Boolean_HSteamPipe_byref_CallbackMsg_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000F308 File Offset: 0x0000D508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930458, XrefRangeEnd = 930460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe pipe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pipe;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_SteamAPI_ManualDispatch_FreeLastCallback_Internal_Static_Boolean_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000F348 File Offset: 0x0000D548
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000F378 File Offset: 0x0000D578
		public unsafe static HSteamPipe ClientPipe
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930460, XrefRangeEnd = 930464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_get_ClientPipe_Internal_Static_get_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930464, XrefRangeEnd = 930468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_set_ClientPipe_Internal_Static_set_Void_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000F3AC File Offset: 0x0000D5AC
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0000F3DC File Offset: 0x0000D5DC
		public unsafe static HSteamPipe ServerPipe
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930468, XrefRangeEnd = 930472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_get_ServerPipe_Internal_Static_get_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930472, XrefRangeEnd = 930476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_set_ServerPipe_Internal_Static_set_Void_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000F410 File Offset: 0x0000D610
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 930481, RefRangeEnd = 930483, XrefRangeStart = 930476, XrefRangeEnd = 930481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_Init_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000F438 File Offset: 0x0000D638
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 930519, RefRangeEnd = 930523, XrefRangeStart = 930483, XrefRangeEnd = 930519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Frame(HSteamPipe pipe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pipe;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_Frame_Internal_Static_Void_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000F46C File Offset: 0x0000D66C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930581, RefRangeEnd = 930582, XrefRangeStart = 930523, XrefRangeEnd = 930581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessCallback(Dispatch.CallbackMsg_t msg, bool isServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref msg;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_ProcessCallback_Private_Static_Void_CallbackMsg_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000F4AC File Offset: 0x0000D6AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 930627, RefRangeEnd = 930629, XrefRangeStart = 930582, XrefRangeEnd = 930627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CallbackToString(CallbackType type, IntPtr data, int expectedsize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectedsize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_CallbackToString_Internal_Static_String_CallbackType_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000F500 File Offset: 0x0000D700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930629, XrefRangeEnd = 930649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessResult(Dispatch.CallbackMsg_t msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref msg;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_ProcessResult_Private_Static_Void_CallbackMsg_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000F534 File Offset: 0x0000D734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930654, RefRangeEnd = 930655, XrefRangeStart = 930649, XrefRangeEnd = 930654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoopClientAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_LoopClientAsync_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000F55C File Offset: 0x0000D75C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930660, RefRangeEnd = 930661, XrefRangeStart = 930655, XrefRangeEnd = 930660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoopServerAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_LoopServerAsync_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000F584 File Offset: 0x0000D784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930669, RefRangeEnd = 930670, XrefRangeStart = 930661, XrefRangeEnd = 930669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnCallComplete<T>(SteamAPICall_t call, Action continuation, bool server) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref call;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.MethodInfoStoreGeneric_OnCallComplete_Internal_Static_Void_SteamAPICall_t_Action_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000F5D8 File Offset: 0x0000D7D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930706, RefRangeEnd = 930707, XrefRangeStart = 930670, XrefRangeEnd = 930706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Install<T>(Action<T> p, bool server = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.MethodInfoStoreGeneric_Install_Internal_Static_Void_Action_1_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000F61C File Offset: 0x0000D81C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930811, RefRangeEnd = 930812, XrefRangeStart = 930707, XrefRangeEnd = 930811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShutdownServer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_ShutdownServer_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000F644 File Offset: 0x0000D844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 930916, RefRangeEnd = 930918, XrefRangeStart = 930812, XrefRangeEnd = 930916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShutdownClient()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.NativeMethodInfoPtr_ShutdownClient_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000219E File Offset: 0x0000039E
		public Dispatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000F66C File Offset: 0x0000D86C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000021A7 File Offset: 0x000003A7
		public unsafe static Action<CallbackType, string, bool> OnDebugCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dispatch.NativeFieldInfoPtr_OnDebugCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CallbackType, string, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dispatch.NativeFieldInfoPtr_OnDebugCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0000F694 File Offset: 0x0000D894
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000021B9 File Offset: 0x000003B9
		public unsafe static Action<Exception> OnException
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dispatch.NativeFieldInfoPtr_OnException, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Exception>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dispatch.NativeFieldInfoPtr_OnException, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000F6BC File Offset: 0x0000D8BC
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000021CB File Offset: 0x000003CB
		public unsafe static HSteamPipe _ClientPipe_k__BackingField
		{
			get
			{
				HSteamPipe hsteamPipe;
				IL2CPP.il2cpp_field_static_get_value(Dispatch.NativeFieldInfoPtr__ClientPipe_k__BackingField, (void*)(&hsteamPipe));
				return hsteamPipe;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dispatch.NativeFieldInfoPtr__ClientPipe_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000021D9 File Offset: 0x000003D9
		public unsafe static HSteamPipe _ServerPipe_k__BackingField
		{
			get
			{
				HSteamPipe hsteamPipe;
				IL2CPP.il2cpp_field_static_get_value(Dispatch.NativeFieldInfoPtr__ServerPipe_k__BackingField, (void*)(&hsteamPipe));
				return hsteamPipe;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dispatch.NativeFieldInfoPtr__ServerPipe_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000F6F4 File Offset: 0x0000D8F4
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000021E7 File Offset: 0x000003E7
		public unsafe static bool runningFrame
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Dispatch.NativeFieldInfoPtr_runningFrame, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dispatch.NativeFieldInfoPtr_runningFrame, (void*)(&value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000F710 File Offset: 0x0000D910
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000021F5 File Offset: 0x000003F5
		public unsafe static List<Action<IntPtr>> actionsToCall
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dispatch.NativeFieldInfoPtr_actionsToCall, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action<IntPtr>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dispatch.NativeFieldInfoPtr_actionsToCall, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000F738 File Offset: 0x0000D938
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002207 File Offset: 0x00000407
		public unsafe static Dictionary<ulong, Dispatch.ResultCallback> ResultCallbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dispatch.NativeFieldInfoPtr_ResultCallbacks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ulong, Dispatch.ResultCallback>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dispatch.NativeFieldInfoPtr_ResultCallbacks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000F760 File Offset: 0x0000D960
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002219 File Offset: 0x00000419
		public unsafe static Dictionary<CallbackType, List<Dispatch.Callback>> Callbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dispatch.NativeFieldInfoPtr_Callbacks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<CallbackType, List<Dispatch.Callback>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dispatch.NativeFieldInfoPtr_Callbacks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_OnDebugCallback;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_OnException;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr__ClientPipe_k__BackingField;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr__ServerPipe_k__BackingField;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_runningFrame;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_actionsToCall;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_ResultCallbacks;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_Callbacks;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_ManualDispatch_Init_Internal_Static_Void_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_ManualDispatch_RunFrame_Internal_Static_Void_HSteamPipe_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_ManualDispatch_GetNextCallback_Internal_Static_Boolean_HSteamPipe_byref_CallbackMsg_t_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_ManualDispatch_FreeLastCallback_Internal_Static_Boolean_HSteamPipe_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientPipe_Internal_Static_get_HSteamPipe_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientPipe_Internal_Static_set_Void_HSteamPipe_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerPipe_Internal_Static_get_HSteamPipe_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_set_ServerPipe_Internal_Static_set_Void_HSteamPipe_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Static_Void_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_Frame_Internal_Static_Void_HSteamPipe_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCallback_Private_Static_Void_CallbackMsg_t_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_CallbackToString_Internal_Static_String_CallbackType_IntPtr_Int32_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_ProcessResult_Private_Static_Void_CallbackMsg_t_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_LoopClientAsync_Internal_Static_Void_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_LoopServerAsync_Internal_Static_Void_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_OnCallComplete_Internal_Static_Void_SteamAPICall_t_Action_Boolean_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_Install_Internal_Static_Void_Action_1_T_Boolean_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_ShutdownServer_Internal_Static_Void_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_ShutdownClient_Internal_Static_Void_0;

		// Token: 0x0200020F RID: 527
		[StructLayout(2)]
		public struct CallbackMsg_t
		{
			// Token: 0x06001AAB RID: 6827 RVA: 0x0007FCB0 File Offset: 0x0007DEB0
			// Note: this type is marked as 'beforefieldinit'.
			static CallbackMsg_t()
			{
				Il2CppClassPointerStore<Dispatch.CallbackMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "CallbackMsg_t");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dispatch.CallbackMsg_t>.NativeClassPtr);
				Dispatch.CallbackMsg_t.NativeFieldInfoPtr_m_hSteamUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.CallbackMsg_t>.NativeClassPtr, "m_hSteamUser");
				Dispatch.CallbackMsg_t.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.CallbackMsg_t>.NativeClassPtr, "Type");
				Dispatch.CallbackMsg_t.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.CallbackMsg_t>.NativeClassPtr, "Data");
				Dispatch.CallbackMsg_t.NativeFieldInfoPtr_DataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.CallbackMsg_t>.NativeClassPtr, "DataSize");
			}

			// Token: 0x06001AAC RID: 6828 RVA: 0x00008BC0 File Offset: 0x00006DC0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dispatch.CallbackMsg_t>.NativeClassPtr, ref this));
			}

			// Token: 0x04001FA1 RID: 8097
			private static readonly IntPtr NativeFieldInfoPtr_m_hSteamUser;

			// Token: 0x04001FA2 RID: 8098
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x04001FA3 RID: 8099
			private static readonly IntPtr NativeFieldInfoPtr_Data;

			// Token: 0x04001FA4 RID: 8100
			private static readonly IntPtr NativeFieldInfoPtr_DataSize;

			// Token: 0x04001FA5 RID: 8101
			[FieldOffset(0)]
			public HSteamUser m_hSteamUser;

			// Token: 0x04001FA6 RID: 8102
			[FieldOffset(4)]
			public CallbackType Type;

			// Token: 0x04001FA7 RID: 8103
			[FieldOffset(8)]
			public IntPtr Data;

			// Token: 0x04001FA8 RID: 8104
			[FieldOffset(16)]
			public int DataSize;
		}

		// Token: 0x02000210 RID: 528
		public sealed class ResultCallback : ValueType
		{
			// Token: 0x06001AAD RID: 6829 RVA: 0x0007FD2C File Offset: 0x0007DF2C
			// Note: this type is marked as 'beforefieldinit'.
			static ResultCallback()
			{
				Il2CppClassPointerStore<Dispatch.ResultCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "ResultCallback");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dispatch.ResultCallback>.NativeClassPtr);
				Dispatch.ResultCallback.NativeFieldInfoPtr_continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.ResultCallback>.NativeClassPtr, "continuation");
				Dispatch.ResultCallback.NativeFieldInfoPtr_server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.ResultCallback>.NativeClassPtr, "server");
			}

			// Token: 0x06001AAE RID: 6830 RVA: 0x00008BD2 File Offset: 0x00006DD2
			public ResultCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AAF RID: 6831 RVA: 0x00008BDB File Offset: 0x00006DDB
			public ResultCallback()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dispatch.ResultCallback>.NativeClassPtr))
			{
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0007FD80 File Offset: 0x0007DF80
			// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x00008BED File Offset: 0x00006DED
			public unsafe Action continuation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch.ResultCallback.NativeFieldInfoPtr_continuation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch.ResultCallback.NativeFieldInfoPtr_continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x0007FDB0 File Offset: 0x0007DFB0
			// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x00008C0C File Offset: 0x00006E0C
			public unsafe bool server
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch.ResultCallback.NativeFieldInfoPtr_server);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch.ResultCallback.NativeFieldInfoPtr_server)) = value;
				}
			}

			// Token: 0x04001FA9 RID: 8105
			private static readonly IntPtr NativeFieldInfoPtr_continuation;

			// Token: 0x04001FAA RID: 8106
			private static readonly IntPtr NativeFieldInfoPtr_server;
		}

		// Token: 0x02000211 RID: 529
		public sealed class Callback : ValueType
		{
			// Token: 0x06001AB4 RID: 6836 RVA: 0x0007FDD8 File Offset: 0x0007DFD8
			// Note: this type is marked as 'beforefieldinit'.
			static Callback()
			{
				Il2CppClassPointerStore<Dispatch.Callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "Callback");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dispatch.Callback>.NativeClassPtr);
				Dispatch.Callback.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.Callback>.NativeClassPtr, "action");
				Dispatch.Callback.NativeFieldInfoPtr_server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.Callback>.NativeClassPtr, "server");
			}

			// Token: 0x06001AB5 RID: 6837 RVA: 0x00008C27 File Offset: 0x00006E27
			public Callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AB6 RID: 6838 RVA: 0x00008C30 File Offset: 0x00006E30
			public Callback()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dispatch.Callback>.NativeClassPtr))
			{
			}

			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x0007FE2C File Offset: 0x0007E02C
			// (set) Token: 0x06001AB8 RID: 6840 RVA: 0x00008C42 File Offset: 0x00006E42
			public unsafe Action<IntPtr> action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch.Callback.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntPtr>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch.Callback.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x0007FE5C File Offset: 0x0007E05C
			// (set) Token: 0x06001ABA RID: 6842 RVA: 0x00008C61 File Offset: 0x00006E61
			public unsafe bool server
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch.Callback.NativeFieldInfoPtr_server);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch.Callback.NativeFieldInfoPtr_server)) = value;
				}
			}

			// Token: 0x04001FAB RID: 8107
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04001FAC RID: 8108
			private static readonly IntPtr NativeFieldInfoPtr_server;
		}

		// Token: 0x02000212 RID: 530
		[ObfuscatedName("Steamworks.Dispatch+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001ABB RID: 6843 RVA: 0x0007FE84 File Offset: 0x0007E084
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr);
				Dispatch.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, "<>9");
				Dispatch.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, "<>9__20_0");
				Dispatch.__c.NativeFieldInfoPtr___9__30_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, "<>9__30_3");
				Dispatch.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, "<>9__30_0");
				Dispatch.__c.NativeFieldInfoPtr___9__30_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, "<>9__30_1");
				Dispatch.__c.NativeFieldInfoPtr___9__30_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, "<>9__30_2");
				Dispatch.__c.NativeFieldInfoPtr___9__31_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, "<>9__31_3");
				Dispatch.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, "<>9__31_0");
				Dispatch.__c.NativeFieldInfoPtr___9__31_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, "<>9__31_1");
				Dispatch.__c.NativeFieldInfoPtr___9__31_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, "<>9__31_2");
				Dispatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, 100663330);
				Dispatch.__c.NativeMethodInfoPtr__CallbackToString_b__20_0_Internal_Int32_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, 100663331);
				Dispatch.__c.NativeMethodInfoPtr__ShutdownServer_b__30_3_Internal_Boolean_Callback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, 100663332);
				Dispatch.__c.NativeMethodInfoPtr__ShutdownServer_b__30_0_Internal_Boolean_KeyValuePair_2_UInt64_ResultCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, 100663333);
				Dispatch.__c.NativeMethodInfoPtr__ShutdownServer_b__30_1_Internal_UInt64_KeyValuePair_2_UInt64_ResultCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, 100663334);
				Dispatch.__c.NativeMethodInfoPtr__ShutdownServer_b__30_2_Internal_ResultCallback_KeyValuePair_2_UInt64_ResultCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, 100663335);
				Dispatch.__c.NativeMethodInfoPtr__ShutdownClient_b__31_3_Internal_Boolean_Callback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, 100663336);
				Dispatch.__c.NativeMethodInfoPtr__ShutdownClient_b__31_0_Internal_Boolean_KeyValuePair_2_UInt64_ResultCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, 100663337);
				Dispatch.__c.NativeMethodInfoPtr__ShutdownClient_b__31_1_Internal_UInt64_KeyValuePair_2_UInt64_ResultCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, 100663338);
				Dispatch.__c.NativeMethodInfoPtr__ShutdownClient_b__31_2_Internal_ResultCallback_KeyValuePair_2_UInt64_ResultCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr, 100663339);
			}

			// Token: 0x06001ABC RID: 6844 RVA: 0x00080040 File Offset: 0x0007E240
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dispatch.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ABD RID: 6845 RVA: 0x0008007C File Offset: 0x0007E27C
			[CallerCount(0)]
			public unsafe int _CallbackToString_b__20_0(FieldInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.__c.NativeMethodInfoPtr__CallbackToString_b__20_0_Internal_Int32_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001ABE RID: 6846 RVA: 0x000800CC File Offset: 0x0007E2CC
			[CallerCount(0)]
			public unsafe bool _ShutdownServer_b__30_3(Dispatch.Callback x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.__c.NativeMethodInfoPtr__ShutdownServer_b__30_3_Internal_Boolean_Callback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001ABF RID: 6847 RVA: 0x00080120 File Offset: 0x0007E320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930375, XrefRangeEnd = 930376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShutdownServer_b__30_0(KeyValuePair<ulong, Dispatch.ResultCallback> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.__c.NativeMethodInfoPtr__ShutdownServer_b__30_0_Internal_Boolean_KeyValuePair_2_UInt64_ResultCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AC0 RID: 6848 RVA: 0x00080174 File Offset: 0x0007E374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930376, XrefRangeEnd = 930377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ulong _ShutdownServer_b__30_1(KeyValuePair<ulong, Dispatch.ResultCallback> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.__c.NativeMethodInfoPtr__ShutdownServer_b__30_1_Internal_UInt64_KeyValuePair_2_UInt64_ResultCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AC1 RID: 6849 RVA: 0x000801C8 File Offset: 0x0007E3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930377, XrefRangeEnd = 930378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dispatch.ResultCallback _ShutdownServer_b__30_2(KeyValuePair<ulong, Dispatch.ResultCallback> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.__c.NativeMethodInfoPtr__ShutdownServer_b__30_2_Internal_ResultCallback_KeyValuePair_2_UInt64_ResultCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Dispatch.ResultCallback(intPtr);
				}
			}

			// Token: 0x06001AC2 RID: 6850 RVA: 0x00080218 File Offset: 0x0007E418
			[CallerCount(0)]
			public unsafe bool _ShutdownClient_b__31_3(Dispatch.Callback x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.__c.NativeMethodInfoPtr__ShutdownClient_b__31_3_Internal_Boolean_Callback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AC3 RID: 6851 RVA: 0x0008026C File Offset: 0x0007E46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930378, XrefRangeEnd = 930379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShutdownClient_b__31_0(KeyValuePair<ulong, Dispatch.ResultCallback> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.__c.NativeMethodInfoPtr__ShutdownClient_b__31_0_Internal_Boolean_KeyValuePair_2_UInt64_ResultCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AC4 RID: 6852 RVA: 0x000802C0 File Offset: 0x0007E4C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930379, XrefRangeEnd = 930380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ulong _ShutdownClient_b__31_1(KeyValuePair<ulong, Dispatch.ResultCallback> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.__c.NativeMethodInfoPtr__ShutdownClient_b__31_1_Internal_UInt64_KeyValuePair_2_UInt64_ResultCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AC5 RID: 6853 RVA: 0x00080314 File Offset: 0x0007E514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930380, XrefRangeEnd = 930381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dispatch.ResultCallback _ShutdownClient_b__31_2(KeyValuePair<ulong, Dispatch.ResultCallback> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.__c.NativeMethodInfoPtr__ShutdownClient_b__31_2_Internal_ResultCallback_KeyValuePair_2_UInt64_ResultCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Dispatch.ResultCallback(intPtr);
				}
			}

			// Token: 0x06001AC6 RID: 6854 RVA: 0x00008C7C File Offset: 0x00006E7C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x00080364 File Offset: 0x0007E564
			// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x00008C85 File Offset: 0x00006E85
			public unsafe static Dispatch.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dispatch.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dispatch.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dispatch.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x0008038C File Offset: 0x0007E58C
			// (set) Token: 0x06001ACA RID: 6858 RVA: 0x00008C97 File Offset: 0x00006E97
			public unsafe static Func<FieldInfo, int> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dispatch.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dispatch.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x06001ACB RID: 6859 RVA: 0x000803B4 File Offset: 0x0007E5B4
			// (set) Token: 0x06001ACC RID: 6860 RVA: 0x00008CA9 File Offset: 0x00006EA9
			public unsafe static Predicate<Dispatch.Callback> __9__30_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dispatch.__c.NativeFieldInfoPtr___9__30_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Dispatch.Callback>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dispatch.__c.NativeFieldInfoPtr___9__30_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x06001ACD RID: 6861 RVA: 0x000803DC File Offset: 0x0007E5DC
			// (set) Token: 0x06001ACE RID: 6862 RVA: 0x00008CBB File Offset: 0x00006EBB
			public unsafe static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool> __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dispatch.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dispatch.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x06001ACF RID: 6863 RVA: 0x00080404 File Offset: 0x0007E604
			// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x00008CCD File Offset: 0x00006ECD
			public unsafe static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong> __9__30_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dispatch.__c.NativeFieldInfoPtr___9__30_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dispatch.__c.NativeFieldInfoPtr___9__30_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0008042C File Offset: 0x0007E62C
			// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x00008CDF File Offset: 0x00006EDF
			public unsafe static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback> __9__30_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dispatch.__c.NativeFieldInfoPtr___9__30_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dispatch.__c.NativeFieldInfoPtr___9__30_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x00080454 File Offset: 0x0007E654
			// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x00008CF1 File Offset: 0x00006EF1
			public unsafe static Predicate<Dispatch.Callback> __9__31_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dispatch.__c.NativeFieldInfoPtr___9__31_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Dispatch.Callback>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dispatch.__c.NativeFieldInfoPtr___9__31_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x0008047C File Offset: 0x0007E67C
			// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x00008D03 File Offset: 0x00006F03
			public unsafe static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dispatch.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dispatch.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x000804A4 File Offset: 0x0007E6A4
			// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x00008D15 File Offset: 0x00006F15
			public unsafe static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong> __9__31_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dispatch.__c.NativeFieldInfoPtr___9__31_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dispatch.__c.NativeFieldInfoPtr___9__31_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x000804CC File Offset: 0x0007E6CC
			// (set) Token: 0x06001ADA RID: 6874 RVA: 0x00008D27 File Offset: 0x00006F27
			public unsafe static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback> __9__31_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dispatch.__c.NativeFieldInfoPtr___9__31_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dispatch.__c.NativeFieldInfoPtr___9__31_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FAD RID: 8109
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001FAE RID: 8110
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x04001FAF RID: 8111
			private static readonly IntPtr NativeFieldInfoPtr___9__30_3;

			// Token: 0x04001FB0 RID: 8112
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x04001FB1 RID: 8113
			private static readonly IntPtr NativeFieldInfoPtr___9__30_1;

			// Token: 0x04001FB2 RID: 8114
			private static readonly IntPtr NativeFieldInfoPtr___9__30_2;

			// Token: 0x04001FB3 RID: 8115
			private static readonly IntPtr NativeFieldInfoPtr___9__31_3;

			// Token: 0x04001FB4 RID: 8116
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x04001FB5 RID: 8117
			private static readonly IntPtr NativeFieldInfoPtr___9__31_1;

			// Token: 0x04001FB6 RID: 8118
			private static readonly IntPtr NativeFieldInfoPtr___9__31_2;

			// Token: 0x04001FB7 RID: 8119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FB8 RID: 8120
			private static readonly IntPtr NativeMethodInfoPtr__CallbackToString_b__20_0_Internal_Int32_FieldInfo_0;

			// Token: 0x04001FB9 RID: 8121
			private static readonly IntPtr NativeMethodInfoPtr__ShutdownServer_b__30_3_Internal_Boolean_Callback_0;

			// Token: 0x04001FBA RID: 8122
			private static readonly IntPtr NativeMethodInfoPtr__ShutdownServer_b__30_0_Internal_Boolean_KeyValuePair_2_UInt64_ResultCallback_0;

			// Token: 0x04001FBB RID: 8123
			private static readonly IntPtr NativeMethodInfoPtr__ShutdownServer_b__30_1_Internal_UInt64_KeyValuePair_2_UInt64_ResultCallback_0;

			// Token: 0x04001FBC RID: 8124
			private static readonly IntPtr NativeMethodInfoPtr__ShutdownServer_b__30_2_Internal_ResultCallback_KeyValuePair_2_UInt64_ResultCallback_0;

			// Token: 0x04001FBD RID: 8125
			private static readonly IntPtr NativeMethodInfoPtr__ShutdownClient_b__31_3_Internal_Boolean_Callback_0;

			// Token: 0x04001FBE RID: 8126
			private static readonly IntPtr NativeMethodInfoPtr__ShutdownClient_b__31_0_Internal_Boolean_KeyValuePair_2_UInt64_ResultCallback_0;

			// Token: 0x04001FBF RID: 8127
			private static readonly IntPtr NativeMethodInfoPtr__ShutdownClient_b__31_1_Internal_UInt64_KeyValuePair_2_UInt64_ResultCallback_0;

			// Token: 0x04001FC0 RID: 8128
			private static readonly IntPtr NativeMethodInfoPtr__ShutdownClient_b__31_2_Internal_ResultCallback_KeyValuePair_2_UInt64_ResultCallback_0;
		}

		// Token: 0x02000213 RID: 531
		[ObfuscatedName("Steamworks.Dispatch+<>c__DisplayClass29_0`1")]
		public sealed class __c__DisplayClass29_0<T> : Object
		{
			// Token: 0x06001ADB RID: 6875 RVA: 0x000804F4 File Offset: 0x0007E6F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<Dispatch.__c__DisplayClass29_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "<>c__DisplayClass29_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dispatch.__c__DisplayClass29_0<T>>.NativeClassPtr);
				Dispatch.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch.__c__DisplayClass29_0<T>>.NativeClassPtr, "p");
				Dispatch.__c__DisplayClass29_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch.__c__DisplayClass29_0<T>>.NativeClassPtr, 100663340);
				Dispatch.__c__DisplayClass29_0<T>.NativeMethodInfoPtr__Install_b__0_Internal_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch.__c__DisplayClass29_0<T>>.NativeClassPtr, 100663341);
			}

			// Token: 0x06001ADC RID: 6876 RVA: 0x00080598 File Offset: 0x0007E798
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dispatch.__c__DisplayClass29_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.__c__DisplayClass29_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ADD RID: 6877 RVA: 0x000805D4 File Offset: 0x0007E7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930381, XrefRangeEnd = 930390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Install_b__0(IntPtr x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch.__c__DisplayClass29_0<T>.NativeMethodInfoPtr__Install_b__0_Internal_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001ADE RID: 6878 RVA: 0x00008D39 File Offset: 0x00006F39
			public __c__DisplayClass29_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x06001ADF RID: 6879 RVA: 0x00080614 File Offset: 0x0007E814
			// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x00008D42 File Offset: 0x00006F42
			public unsafe Action<T> p
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_p);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch.__c__DisplayClass29_0<T>.NativeFieldInfoPtr_p), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FC1 RID: 8129
			private static readonly IntPtr NativeFieldInfoPtr_p;

			// Token: 0x04001FC2 RID: 8130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FC3 RID: 8131
			private static readonly IntPtr NativeMethodInfoPtr__Install_b__0_Internal_Void_IntPtr_0;
		}

		// Token: 0x02000214 RID: 532
		[ObfuscatedName("Steamworks.Dispatch+<LoopClientAsync>d__22")]
		public sealed class _LoopClientAsync_d__22 : ValueType
		{
			// Token: 0x06001AE1 RID: 6881 RVA: 0x00080644 File Offset: 0x0007E844
			// Note: this type is marked as 'beforefieldinit'.
			static _LoopClientAsync_d__22()
			{
				Il2CppClassPointerStore<Dispatch._LoopClientAsync_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "<LoopClientAsync>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dispatch._LoopClientAsync_d__22>.NativeClassPtr);
				Dispatch._LoopClientAsync_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch._LoopClientAsync_d__22>.NativeClassPtr, "<>1__state");
				Dispatch._LoopClientAsync_d__22.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch._LoopClientAsync_d__22>.NativeClassPtr, "<>t__builder");
				Dispatch._LoopClientAsync_d__22.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch._LoopClientAsync_d__22>.NativeClassPtr, "<>u__1");
				Dispatch._LoopClientAsync_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch._LoopClientAsync_d__22>.NativeClassPtr, 100663342);
				Dispatch._LoopClientAsync_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch._LoopClientAsync_d__22>.NativeClassPtr, 100663343);
			}

			// Token: 0x06001AE2 RID: 6882 RVA: 0x000806D4 File Offset: 0x0007E8D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930390, XrefRangeEnd = 930421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch._LoopClientAsync_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AE3 RID: 6883 RVA: 0x0008070C File Offset: 0x0007E90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch._LoopClientAsync_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AE4 RID: 6884 RVA: 0x00008D61 File Offset: 0x00006F61
			public _LoopClientAsync_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AE5 RID: 6885 RVA: 0x00008D6A File Offset: 0x00006F6A
			public _LoopClientAsync_d__22()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dispatch._LoopClientAsync_d__22>.NativeClassPtr))
			{
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x00080754 File Offset: 0x0007E954
			// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x00008D7C File Offset: 0x00006F7C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch._LoopClientAsync_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch._LoopClientAsync_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x0008077C File Offset: 0x0007E97C
			// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x00008D97 File Offset: 0x00006F97
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch._LoopClientAsync_d__22.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch._LoopClientAsync_d__22.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x06001AEA RID: 6890 RVA: 0x000807AC File Offset: 0x0007E9AC
			// (set) Token: 0x06001AEB RID: 6891 RVA: 0x00008DC5 File Offset: 0x00006FC5
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch._LoopClientAsync_d__22.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch._LoopClientAsync_d__22.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001FC4 RID: 8132
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FC5 RID: 8133
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001FC6 RID: 8134
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001FC7 RID: 8135
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FC8 RID: 8136
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000215 RID: 533
		[ObfuscatedName("Steamworks.Dispatch+<LoopServerAsync>d__23")]
		public sealed class _LoopServerAsync_d__23 : ValueType
		{
			// Token: 0x06001AEC RID: 6892 RVA: 0x000807DC File Offset: 0x0007E9DC
			// Note: this type is marked as 'beforefieldinit'.
			static _LoopServerAsync_d__23()
			{
				Il2CppClassPointerStore<Dispatch._LoopServerAsync_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dispatch>.NativeClassPtr, "<LoopServerAsync>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dispatch._LoopServerAsync_d__23>.NativeClassPtr);
				Dispatch._LoopServerAsync_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch._LoopServerAsync_d__23>.NativeClassPtr, "<>1__state");
				Dispatch._LoopServerAsync_d__23.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch._LoopServerAsync_d__23>.NativeClassPtr, "<>t__builder");
				Dispatch._LoopServerAsync_d__23.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dispatch._LoopServerAsync_d__23>.NativeClassPtr, "<>u__1");
				Dispatch._LoopServerAsync_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch._LoopServerAsync_d__23>.NativeClassPtr, 100663344);
				Dispatch._LoopServerAsync_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dispatch._LoopServerAsync_d__23>.NativeClassPtr, 100663345);
			}

			// Token: 0x06001AED RID: 6893 RVA: 0x0008086C File Offset: 0x0007EA6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930421, XrefRangeEnd = 930452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch._LoopServerAsync_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AEE RID: 6894 RVA: 0x000808A4 File Offset: 0x0007EAA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dispatch._LoopServerAsync_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AEF RID: 6895 RVA: 0x00008DF3 File Offset: 0x00006FF3
			public _LoopServerAsync_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001AF0 RID: 6896 RVA: 0x00008DFC File Offset: 0x00006FFC
			public _LoopServerAsync_d__23()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dispatch._LoopServerAsync_d__23>.NativeClassPtr))
			{
			}

			// Token: 0x170006A2 RID: 1698
			// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x000808EC File Offset: 0x0007EAEC
			// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x00008E0E File Offset: 0x0000700E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch._LoopServerAsync_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch._LoopServerAsync_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006A3 RID: 1699
			// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x00080914 File Offset: 0x0007EB14
			// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x00008E29 File Offset: 0x00007029
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch._LoopServerAsync_d__23.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch._LoopServerAsync_d__23.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006A4 RID: 1700
			// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00080944 File Offset: 0x0007EB44
			// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x00008E57 File Offset: 0x00007057
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch._LoopServerAsync_d__23.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dispatch._LoopServerAsync_d__23.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001FC9 RID: 8137
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FCA RID: 8138
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001FCB RID: 8139
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001FCC RID: 8140
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FCD RID: 8141
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000216 RID: 534
		private sealed class MethodInfoStoreGeneric_OnCallComplete_Internal_Static_Void_SteamAPICall_t_Action_Boolean_0<T>
		{
			// Token: 0x04001FCE RID: 8142
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Dispatch.NativeMethodInfoPtr_OnCallComplete_Internal_Static_Void_SteamAPICall_t_Action_Boolean_0, Il2CppClassPointerStore<Dispatch>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000217 RID: 535
		private sealed class MethodInfoStoreGeneric_Install_Internal_Static_Void_Action_1_T_Boolean_0<T>
		{
			// Token: 0x04001FCF RID: 8143
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Dispatch.NativeMethodInfoPtr_Install_Internal_Static_Void_Action_1_T_Boolean_0, Il2CppClassPointerStore<Dispatch>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
