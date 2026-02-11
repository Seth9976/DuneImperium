using System;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

// Token: 0x02000019 RID: 25
public static class ServerVersion : Object
{
	// Token: 0x060000CC RID: 204 RVA: 0x00002549 File Offset: 0x00000749
	// Note: this type is marked as 'beforefieldinit'.
	static ServerVersion()
	{
		Il2CppClassPointerStore<ServerVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "ServerVersion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerVersion>.NativeClassPtr);
		ServerVersion.NativeMethodInfoPtr_GetCurrentServerVersionThen_Public_Static_IEnumerator_String_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersion>.NativeClassPtr, 100663453);
	}

	// Token: 0x060000CD RID: 205 RVA: 0x000132C8 File Offset: 0x000114C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982951, XrefRangeEnd = 982957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator GetCurrentServerVersionThen(string client, Action<string> callback)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(client);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersion.NativeMethodInfoPtr_GetCurrentServerVersionThen_Public_Static_IEnumerator_String_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002582 File Offset: 0x00000782
	public ServerVersion(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000088 RID: 136
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentServerVersionThen_Public_Static_IEnumerator_String_Action_1_String_0;

	// Token: 0x02000197 RID: 407
	[ObfuscatedName("ServerVersion+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x060013D6 RID: 5078 RVA: 0x0004E5A8 File Offset: 0x0004C7A8
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<ServerVersion.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerVersion>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerVersion.__c>.NativeClassPtr);
			ServerVersion.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVersion.__c>.NativeClassPtr, "<>9");
			ServerVersion.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVersion.__c>.NativeClassPtr, "<>9__0_0");
			ServerVersion.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersion.__c>.NativeClassPtr, 100663455);
			ServerVersion.__c.NativeMethodInfoPtr__GetCurrentServerVersionThen_b__0_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersion.__c>.NativeClassPtr, 100663456);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0004E624 File Offset: 0x0004C824
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerVersion.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersion.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0004E660 File Offset: 0x0004C860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982860, XrefRangeEnd = 982868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetCurrentServerVersionThen_b__0_0(UnityWebRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersion.__c.NativeMethodInfoPtr__GetCurrentServerVersionThen_b__0_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0000B401 File Offset: 0x00009601
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x0004E6A4 File Offset: 0x0004C8A4
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x0000B40A File Offset: 0x0000960A
		public unsafe static ServerVersion.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServerVersion.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerVersion.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServerVersion.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0004E6CC File Offset: 0x0004C8CC
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x0000B41C File Offset: 0x0000961C
		public unsafe static Action<UnityWebRequest> __9__0_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServerVersion.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServerVersion.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr__GetCurrentServerVersionThen_b__0_0_Internal_Void_UnityWebRequest_0;
	}

	// Token: 0x02000198 RID: 408
	[ObfuscatedName("ServerVersion+<>c__DisplayClass0_0")]
	public sealed class __c__DisplayClass0_0 : Object
	{
		// Token: 0x060013DE RID: 5086 RVA: 0x0004E6F4 File Offset: 0x0004C8F4
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass0_0()
		{
			Il2CppClassPointerStore<ServerVersion.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerVersion>.NativeClassPtr, "<>c__DisplayClass0_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerVersion.__c__DisplayClass0_0>.NativeClassPtr);
			ServerVersion.__c__DisplayClass0_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVersion.__c__DisplayClass0_0>.NativeClassPtr, "callback");
			ServerVersion.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersion.__c__DisplayClass0_0>.NativeClassPtr, 100663457);
			ServerVersion.__c__DisplayClass0_0.NativeMethodInfoPtr__GetCurrentServerVersionThen_b__1_Internal_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersion.__c__DisplayClass0_0>.NativeClassPtr, 100663458);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0004E75C File Offset: 0x0004C95C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass0_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerVersion.__c__DisplayClass0_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersion.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0004E798 File Offset: 0x0004C998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982868, XrefRangeEnd = 982882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetCurrentServerVersionThen_b__1(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersion.__c__DisplayClass0_0.NativeMethodInfoPtr__GetCurrentServerVersionThen_b__1_Internal_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0000B42E File Offset: 0x0000962E
		public __c__DisplayClass0_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0004E7DC File Offset: 0x0004C9DC
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x0000B437 File Offset: 0x00009637
		public unsafe Action<string> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersion.__c__DisplayClass0_0.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersion.__c__DisplayClass0_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr__GetCurrentServerVersionThen_b__1_Internal_Void_DwdWebRequestCommand_0;
	}

	// Token: 0x02000199 RID: 409
	[ObfuscatedName("ServerVersion+<GetCurrentServerVersionThen>d__0")]
	public sealed class _GetCurrentServerVersionThen_d__0 : Object
	{
		// Token: 0x060013E4 RID: 5092 RVA: 0x0004E80C File Offset: 0x0004CA0C
		// Note: this type is marked as 'beforefieldinit'.
		static _GetCurrentServerVersionThen_d__0()
		{
			Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerVersion>.NativeClassPtr, "<GetCurrentServerVersionThen>d__0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr);
			ServerVersion._GetCurrentServerVersionThen_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr, "<>1__state");
			ServerVersion._GetCurrentServerVersionThen_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr, "<>2__current");
			ServerVersion._GetCurrentServerVersionThen_d__0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr, "callback");
			ServerVersion._GetCurrentServerVersionThen_d__0.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr, "client");
			ServerVersion._GetCurrentServerVersionThen_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr, 100663459);
			ServerVersion._GetCurrentServerVersionThen_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr, 100663460);
			ServerVersion._GetCurrentServerVersionThen_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr, 100663461);
			ServerVersion._GetCurrentServerVersionThen_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr, 100663462);
			ServerVersion._GetCurrentServerVersionThen_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr, 100663463);
			ServerVersion._GetCurrentServerVersionThen_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr, 100663464);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0004E900 File Offset: 0x0004CB00
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _GetCurrentServerVersionThen_d__0(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerVersion._GetCurrentServerVersionThen_d__0>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersion._GetCurrentServerVersionThen_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0004E948 File Offset: 0x0004CB48
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersion._GetCurrentServerVersionThen_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0004E97C File Offset: 0x0004CB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982882, XrefRangeEnd = 982946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersion._GetCurrentServerVersionThen_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0004E9B8 File Offset: 0x0004CBB8
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersion._GetCurrentServerVersionThen_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0004E9F8 File Offset: 0x0004CBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982946, XrefRangeEnd = 982951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersion._GetCurrentServerVersionThen_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0004EA2C File Offset: 0x0004CC2C
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersion._GetCurrentServerVersionThen_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0000B456 File Offset: 0x00009656
		public _GetCurrentServerVersionThen_d__0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x0004EA6C File Offset: 0x0004CC6C
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x0000B45F File Offset: 0x0000965F
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersion._GetCurrentServerVersionThen_d__0.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersion._GetCurrentServerVersionThen_d__0.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x0004EA94 File Offset: 0x0004CC94
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x0000B47A File Offset: 0x0000967A
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersion._GetCurrentServerVersionThen_d__0.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersion._GetCurrentServerVersionThen_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0004EAC4 File Offset: 0x0004CCC4
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x0000B499 File Offset: 0x00009699
		public unsafe Action<string> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersion._GetCurrentServerVersionThen_d__0.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersion._GetCurrentServerVersionThen_d__0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0004EAF4 File Offset: 0x0004CCF4
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x0000B4B8 File Offset: 0x000096B8
		public unsafe string client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersion._GetCurrentServerVersionThen_d__0.NativeFieldInfoPtr_client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersion._GetCurrentServerVersionThen_d__0.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeFieldInfoPtr_client;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
