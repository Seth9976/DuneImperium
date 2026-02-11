using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000C7 RID: 199
	public static class SourceServerQuery : Object
	{
		// Token: 0x06000CAC RID: 3244 RVA: 0x0005359C File Offset: 0x0005179C
		// Note: this type is marked as 'beforefieldinit'.
		static SourceServerQuery()
		{
			Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SourceServerQuery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr);
			SourceServerQuery.NativeFieldInfoPtr_A2S_SERVERQUERY_GETCHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, "A2S_SERVERQUERY_GETCHALLENGE");
			SourceServerQuery.NativeFieldInfoPtr_A2S_RULES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, "A2S_RULES");
			SourceServerQuery.NativeFieldInfoPtr_PendingQueries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, "PendingQueries");
			SourceServerQuery.NativeMethodInfoPtr_GetRules_Internal_Static_Task_1_Dictionary_2_String_String_ServerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, 100666399);
			SourceServerQuery.NativeMethodInfoPtr_GetRulesImpl_Private_Static_Task_1_Dictionary_2_String_String_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, 100666400);
			SourceServerQuery.NativeMethodInfoPtr_GetRules_Private_Static_Task_1_Dictionary_2_String_String_UdpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, 100666401);
			SourceServerQuery.NativeMethodInfoPtr_Receive_Private_Static_Task_1_Il2CppStructArray_1_Byte_UdpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, 100666402);
			SourceServerQuery.NativeMethodInfoPtr_GetChallengeData_Private_Static_Task_1_Il2CppStructArray_1_Byte_UdpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, 100666403);
			SourceServerQuery.NativeMethodInfoPtr_Send_Private_Static_Task_UdpClient_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, 100666404);
			SourceServerQuery.NativeMethodInfoPtr_Combine_Private_Static_Il2CppStructArray_1_Byte_Il2CppReferenceArray_1_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, 100666405);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00053694 File Offset: 0x00051894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 948049, RefRangeEnd = 948050, XrefRangeStart = 947992, XrefRangeEnd = 948049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Dictionary<string, string>> GetRules(ServerInfo server)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(server));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery.NativeMethodInfoPtr_GetRules_Internal_Static_Task_1_Dictionary_2_String_String_ServerInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Dictionary<string, string>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x000536E0 File Offset: 0x000518E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948050, XrefRangeEnd = 948064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Dictionary<string, string>> GetRulesImpl(IPEndPoint endpoint)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(endpoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery.NativeMethodInfoPtr_GetRulesImpl_Private_Static_Task_1_Dictionary_2_String_String_IPEndPoint_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Dictionary<string, string>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00053724 File Offset: 0x00051924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948064, XrefRangeEnd = 948078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Dictionary<string, string>> GetRules(UdpClient client)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(client);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery.NativeMethodInfoPtr_GetRules_Private_Static_Task_1_Dictionary_2_String_String_UdpClient_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Dictionary<string, string>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00053768 File Offset: 0x00051968
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 948092, RefRangeEnd = 948094, XrefRangeStart = 948078, XrefRangeEnd = 948092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Il2CppStructArray<byte>> Receive(UdpClient client)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(client);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery.NativeMethodInfoPtr_Receive_Private_Static_Task_1_Il2CppStructArray_1_Byte_UdpClient_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<byte>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x000537AC File Offset: 0x000519AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948094, XrefRangeEnd = 948108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Il2CppStructArray<byte>> GetChallengeData(UdpClient client)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(client);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery.NativeMethodInfoPtr_GetChallengeData_Private_Static_Task_1_Il2CppStructArray_1_Byte_UdpClient_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<byte>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000537F0 File Offset: 0x000519F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 948119, RefRangeEnd = 948121, XrefRangeStart = 948108, XrefRangeEnd = 948119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task Send(UdpClient client, Il2CppStructArray<byte> message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(client);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery.NativeMethodInfoPtr_Send_Private_Static_Task_UdpClient_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00053848 File Offset: 0x00051A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948121, XrefRangeEnd = 948144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Combine(Il2CppReferenceArray<Il2CppStructArray<byte>> arrays)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrays);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery.NativeMethodInfoPtr_Combine_Private_Static_Il2CppStructArray_1_Byte_Il2CppReferenceArray_1_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x000032D5 File Offset: 0x000014D5
		public SourceServerQuery(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0005388C File Offset: 0x00051A8C
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x000032DE File Offset: 0x000014DE
		public unsafe static Il2CppStructArray<byte> A2S_SERVERQUERY_GETCHALLENGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SourceServerQuery.NativeFieldInfoPtr_A2S_SERVERQUERY_GETCHALLENGE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SourceServerQuery.NativeFieldInfoPtr_A2S_SERVERQUERY_GETCHALLENGE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x000538B4 File Offset: 0x00051AB4
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x000032F0 File Offset: 0x000014F0
		public unsafe static byte A2S_RULES
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SourceServerQuery.NativeFieldInfoPtr_A2S_RULES, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SourceServerQuery.NativeFieldInfoPtr_A2S_RULES, (void*)(&value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x000538D0 File Offset: 0x00051AD0
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x000032FE File Offset: 0x000014FE
		public unsafe static Dictionary<IPEndPoint, Task<Dictionary<string, string>>> PendingQueries
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SourceServerQuery.NativeFieldInfoPtr_PendingQueries, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IPEndPoint, Task<Dictionary<string, string>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SourceServerQuery.NativeFieldInfoPtr_PendingQueries, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeFieldInfoPtr_A2S_SERVERQUERY_GETCHALLENGE;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeFieldInfoPtr_A2S_RULES;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeFieldInfoPtr_PendingQueries;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_GetRules_Internal_Static_Task_1_Dictionary_2_String_String_ServerInfo_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_GetRulesImpl_Private_Static_Task_1_Dictionary_2_String_String_IPEndPoint_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_GetRules_Private_Static_Task_1_Dictionary_2_String_String_UdpClient_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Private_Static_Task_1_Il2CppStructArray_1_Byte_UdpClient_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_GetChallengeData_Private_Static_Task_1_Il2CppStructArray_1_Byte_UdpClient_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_Send_Private_Static_Task_UdpClient_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Private_Static_Il2CppStructArray_1_Byte_Il2CppReferenceArray_1_Il2CppStructArray_1_Byte_0;

		// Token: 0x02000284 RID: 644
		[ObfuscatedName("Steamworks.SourceServerQuery+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060020A2 RID: 8354 RVA: 0x0008F6E0 File Offset: 0x0008D8E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SourceServerQuery.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SourceServerQuery.__c>.NativeClassPtr);
				SourceServerQuery.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery.__c>.NativeClassPtr, "<>9");
				SourceServerQuery.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery.__c>.NativeClassPtr, "<>9__6_0");
				SourceServerQuery.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery.__c>.NativeClassPtr, "<>9__9_0");
				SourceServerQuery.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery.__c>.NativeClassPtr, 100666408);
				SourceServerQuery.__c.NativeMethodInfoPtr__Receive_b__6_0_Internal_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery.__c>.NativeClassPtr, 100666409);
				SourceServerQuery.__c.NativeMethodInfoPtr__Combine_b__9_0_Internal_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery.__c>.NativeClassPtr, 100666410);
			}

			// Token: 0x060020A3 RID: 8355 RVA: 0x0008F784 File Offset: 0x0008D984
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SourceServerQuery.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020A4 RID: 8356 RVA: 0x0008F7C0 File Offset: 0x0008D9C0
			[CallerCount(0)]
			public unsafe bool _Receive_b__6_0(Il2CppStructArray<byte> p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery.__c.NativeMethodInfoPtr__Receive_b__6_0_Internal_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020A5 RID: 8357 RVA: 0x0008F810 File Offset: 0x0008DA10
			[CallerCount(0)]
			public unsafe int _Combine_b__9_0(Il2CppStructArray<byte> a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery.__c.NativeMethodInfoPtr__Combine_b__9_0_Internal_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020A6 RID: 8358 RVA: 0x0000C82C File Offset: 0x0000AA2C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000869 RID: 2153
			// (get) Token: 0x060020A7 RID: 8359 RVA: 0x0008F860 File Offset: 0x0008DA60
			// (set) Token: 0x060020A8 RID: 8360 RVA: 0x0000C835 File Offset: 0x0000AA35
			public unsafe static SourceServerQuery.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SourceServerQuery.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceServerQuery.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SourceServerQuery.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x060020A9 RID: 8361 RVA: 0x0008F888 File Offset: 0x0008DA88
			// (set) Token: 0x060020AA RID: 8362 RVA: 0x0000C847 File Offset: 0x0000AA47
			public unsafe static Func<Il2CppStructArray<byte>, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SourceServerQuery.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStructArray<byte>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SourceServerQuery.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086B RID: 2155
			// (get) Token: 0x060020AB RID: 8363 RVA: 0x0008F8B0 File Offset: 0x0008DAB0
			// (set) Token: 0x060020AC RID: 8364 RVA: 0x0000C859 File Offset: 0x0000AA59
			public unsafe static Func<Il2CppStructArray<byte>, int> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SourceServerQuery.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStructArray<byte>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SourceServerQuery.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022E5 RID: 8933
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040022E6 RID: 8934
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040022E7 RID: 8935
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040022E8 RID: 8936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040022E9 RID: 8937
			private static readonly IntPtr NativeMethodInfoPtr__Receive_b__6_0_Internal_Boolean_Il2CppStructArray_1_Byte_0;

			// Token: 0x040022EA RID: 8938
			private static readonly IntPtr NativeMethodInfoPtr__Combine_b__9_0_Internal_Int32_Il2CppStructArray_1_Byte_0;
		}

		// Token: 0x02000285 RID: 645
		[ObfuscatedName("Steamworks.SourceServerQuery+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060020AD RID: 8365 RVA: 0x0008F8D8 File Offset: 0x0008DAD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<SourceServerQuery.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SourceServerQuery.__c__DisplayClass3_0>.NativeClassPtr);
				SourceServerQuery.__c__DisplayClass3_0.NativeFieldInfoPtr_endpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery.__c__DisplayClass3_0>.NativeClassPtr, "endpoint");
				SourceServerQuery.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery.__c__DisplayClass3_0>.NativeClassPtr, 100666411);
				SourceServerQuery.__c__DisplayClass3_0.NativeMethodInfoPtr__GetRules_b__0_Internal_Task_1_Dictionary_2_String_String_Task_1_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery.__c__DisplayClass3_0>.NativeClassPtr, 100666412);
			}

			// Token: 0x060020AE RID: 8366 RVA: 0x0008F940 File Offset: 0x0008DB40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SourceServerQuery.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020AF RID: 8367 RVA: 0x0008F97C File Offset: 0x0008DB7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947664, XrefRangeEnd = 947678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<Dictionary<string, string>> _GetRules_b__0(Task<Dictionary<string, string>> t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery.__c__DisplayClass3_0.NativeMethodInfoPtr__GetRules_b__0_Internal_Task_1_Dictionary_2_String_String_Task_1_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Dictionary<string, string>>>(intPtr3) : null;
				}
			}

			// Token: 0x060020B0 RID: 8368 RVA: 0x0000C86B File Offset: 0x0000AA6B
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700086C RID: 2156
			// (get) Token: 0x060020B1 RID: 8369 RVA: 0x0008F9CC File Offset: 0x0008DBCC
			// (set) Token: 0x060020B2 RID: 8370 RVA: 0x0000C874 File Offset: 0x0000AA74
			public unsafe IPEndPoint endpoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery.__c__DisplayClass3_0.NativeFieldInfoPtr_endpoint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery.__c__DisplayClass3_0.NativeFieldInfoPtr_endpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040022EB RID: 8939
			private static readonly IntPtr NativeFieldInfoPtr_endpoint;

			// Token: 0x040022EC RID: 8940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040022ED RID: 8941
			private static readonly IntPtr NativeMethodInfoPtr__GetRules_b__0_Internal_Task_1_Dictionary_2_String_String_Task_1_Dictionary_2_String_String_0;
		}

		// Token: 0x02000286 RID: 646
		[ObfuscatedName("Steamworks.SourceServerQuery+<GetChallengeData>d__7")]
		public sealed class _GetChallengeData_d__7 : ValueType
		{
			// Token: 0x060020B3 RID: 8371 RVA: 0x0008F9FC File Offset: 0x0008DBFC
			// Note: this type is marked as 'beforefieldinit'.
			static _GetChallengeData_d__7()
			{
				Il2CppClassPointerStore<SourceServerQuery._GetChallengeData_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, "<GetChallengeData>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SourceServerQuery._GetChallengeData_d__7>.NativeClassPtr);
				SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetChallengeData_d__7>.NativeClassPtr, "<>1__state");
				SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetChallengeData_d__7>.NativeClassPtr, "<>t__builder");
				SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetChallengeData_d__7>.NativeClassPtr, "client");
				SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetChallengeData_d__7>.NativeClassPtr, "<>u__1");
				SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetChallengeData_d__7>.NativeClassPtr, "<>u__2");
				SourceServerQuery._GetChallengeData_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery._GetChallengeData_d__7>.NativeClassPtr, 100666413);
				SourceServerQuery._GetChallengeData_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery._GetChallengeData_d__7>.NativeClassPtr, 100666414);
			}

			// Token: 0x060020B4 RID: 8372 RVA: 0x0008FAB4 File Offset: 0x0008DCB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947678, XrefRangeEnd = 947708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery._GetChallengeData_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020B5 RID: 8373 RVA: 0x0008FAEC File Offset: 0x0008DCEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947708, XrefRangeEnd = 947714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery._GetChallengeData_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020B6 RID: 8374 RVA: 0x0000C893 File Offset: 0x0000AA93
			public _GetChallengeData_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020B7 RID: 8375 RVA: 0x0000C89C File Offset: 0x0000AA9C
			public _GetChallengeData_d__7()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SourceServerQuery._GetChallengeData_d__7>.NativeClassPtr))
			{
			}

			// Token: 0x1700086D RID: 2157
			// (get) Token: 0x060020B8 RID: 8376 RVA: 0x0008FB34 File Offset: 0x0008DD34
			// (set) Token: 0x060020B9 RID: 8377 RVA: 0x0000C8AE File Offset: 0x0000AAAE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700086E RID: 2158
			// (get) Token: 0x060020BA RID: 8378 RVA: 0x0008FB5C File Offset: 0x0008DD5C
			// (set) Token: 0x060020BB RID: 8379 RVA: 0x0000C8C9 File Offset: 0x0000AAC9
			public AsyncTaskMethodBuilder<Il2CppStructArray<byte>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppStructArray<byte>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700086F RID: 2159
			// (get) Token: 0x060020BC RID: 8380 RVA: 0x0008FB8C File Offset: 0x0008DD8C
			// (set) Token: 0x060020BD RID: 8381 RVA: 0x0000C8F7 File Offset: 0x0000AAF7
			public unsafe UdpClient client
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr_client);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UdpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr_client), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000870 RID: 2160
			// (get) Token: 0x060020BE RID: 8382 RVA: 0x0008FBBC File Offset: 0x0008DDBC
			// (set) Token: 0x060020BF RID: 8383 RVA: 0x0000C916 File Offset: 0x0000AB16
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000871 RID: 2161
			// (get) Token: 0x060020C0 RID: 8384 RVA: 0x0008FBEC File Offset: 0x0008DDEC
			// (set) Token: 0x060020C1 RID: 8385 RVA: 0x0000C944 File Offset: 0x0000AB44
			public TaskAwaiter<Il2CppStructArray<byte>> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter<Il2CppStructArray<byte>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppStructArray<byte>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetChallengeData_d__7.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppStructArray<byte>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040022EE RID: 8942
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022EF RID: 8943
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040022F0 RID: 8944
			private static readonly IntPtr NativeFieldInfoPtr_client;

			// Token: 0x040022F1 RID: 8945
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040022F2 RID: 8946
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040022F3 RID: 8947
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022F4 RID: 8948
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000287 RID: 647
		[ObfuscatedName("Steamworks.SourceServerQuery+<GetRules>d__5")]
		public sealed class _GetRules_d__5 : ValueType
		{
			// Token: 0x060020C2 RID: 8386 RVA: 0x0008FC1C File Offset: 0x0008DE1C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetRules_d__5()
			{
				Il2CppClassPointerStore<SourceServerQuery._GetRules_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, "<GetRules>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SourceServerQuery._GetRules_d__5>.NativeClassPtr);
				SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetRules_d__5>.NativeClassPtr, "<>1__state");
				SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetRules_d__5>.NativeClassPtr, "<>t__builder");
				SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetRules_d__5>.NativeClassPtr, "client");
				SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetRules_d__5>.NativeClassPtr, "<>u__1");
				SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetRules_d__5>.NativeClassPtr, "<>u__2");
				SourceServerQuery._GetRules_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery._GetRules_d__5>.NativeClassPtr, 100666415);
				SourceServerQuery._GetRules_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery._GetRules_d__5>.NativeClassPtr, 100666416);
			}

			// Token: 0x060020C3 RID: 8387 RVA: 0x0008FCD4 File Offset: 0x0008DED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947714, XrefRangeEnd = 947800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery._GetRules_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020C4 RID: 8388 RVA: 0x0008FD0C File Offset: 0x0008DF0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947800, XrefRangeEnd = 947806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery._GetRules_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020C5 RID: 8389 RVA: 0x0000C972 File Offset: 0x0000AB72
			public _GetRules_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020C6 RID: 8390 RVA: 0x0000C97B File Offset: 0x0000AB7B
			public _GetRules_d__5()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SourceServerQuery._GetRules_d__5>.NativeClassPtr))
			{
			}

			// Token: 0x17000872 RID: 2162
			// (get) Token: 0x060020C7 RID: 8391 RVA: 0x0008FD54 File Offset: 0x0008DF54
			// (set) Token: 0x060020C8 RID: 8392 RVA: 0x0000C98D File Offset: 0x0000AB8D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000873 RID: 2163
			// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0008FD7C File Offset: 0x0008DF7C
			// (set) Token: 0x060020CA RID: 8394 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
			public AsyncTaskMethodBuilder<Dictionary<string, string>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Dictionary<string, string>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Dictionary<string, string>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Dictionary<string, string>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000874 RID: 2164
			// (get) Token: 0x060020CB RID: 8395 RVA: 0x0008FDAC File Offset: 0x0008DFAC
			// (set) Token: 0x060020CC RID: 8396 RVA: 0x0000C9D6 File Offset: 0x0000ABD6
			public unsafe UdpClient client
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr_client);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UdpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr_client), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000875 RID: 2165
			// (get) Token: 0x060020CD RID: 8397 RVA: 0x0008FDDC File Offset: 0x0008DFDC
			// (set) Token: 0x060020CE RID: 8398 RVA: 0x0000C9F5 File Offset: 0x0000ABF5
			public TaskAwaiter<Il2CppStructArray<byte>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Il2CppStructArray<byte>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppStructArray<byte>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppStructArray<byte>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000876 RID: 2166
			// (get) Token: 0x060020CF RID: 8399 RVA: 0x0008FE0C File Offset: 0x0008E00C
			// (set) Token: 0x060020D0 RID: 8400 RVA: 0x0000CA23 File Offset: 0x0000AC23
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRules_d__5.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040022F5 RID: 8949
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022F6 RID: 8950
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040022F7 RID: 8951
			private static readonly IntPtr NativeFieldInfoPtr_client;

			// Token: 0x040022F8 RID: 8952
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040022F9 RID: 8953
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040022FA RID: 8954
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040022FB RID: 8955
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000288 RID: 648
		[ObfuscatedName("Steamworks.SourceServerQuery+<GetRulesImpl>d__4")]
		public sealed class _GetRulesImpl_d__4 : ValueType
		{
			// Token: 0x060020D1 RID: 8401 RVA: 0x0008FE3C File Offset: 0x0008E03C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetRulesImpl_d__4()
			{
				Il2CppClassPointerStore<SourceServerQuery._GetRulesImpl_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, "<GetRulesImpl>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SourceServerQuery._GetRulesImpl_d__4>.NativeClassPtr);
				SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetRulesImpl_d__4>.NativeClassPtr, "<>1__state");
				SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetRulesImpl_d__4>.NativeClassPtr, "<>t__builder");
				SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr_endpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetRulesImpl_d__4>.NativeClassPtr, "endpoint");
				SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr__client_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetRulesImpl_d__4>.NativeClassPtr, "<client>5__2");
				SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._GetRulesImpl_d__4>.NativeClassPtr, "<>u__1");
				SourceServerQuery._GetRulesImpl_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery._GetRulesImpl_d__4>.NativeClassPtr, 100666417);
				SourceServerQuery._GetRulesImpl_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery._GetRulesImpl_d__4>.NativeClassPtr, 100666418);
			}

			// Token: 0x060020D2 RID: 8402 RVA: 0x0008FEF4 File Offset: 0x0008E0F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947806, XrefRangeEnd = 947862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery._GetRulesImpl_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020D3 RID: 8403 RVA: 0x0008FF2C File Offset: 0x0008E12C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947862, XrefRangeEnd = 947868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery._GetRulesImpl_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020D4 RID: 8404 RVA: 0x0000CA51 File Offset: 0x0000AC51
			public _GetRulesImpl_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020D5 RID: 8405 RVA: 0x0000CA5A File Offset: 0x0000AC5A
			public _GetRulesImpl_d__4()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SourceServerQuery._GetRulesImpl_d__4>.NativeClassPtr))
			{
			}

			// Token: 0x17000877 RID: 2167
			// (get) Token: 0x060020D6 RID: 8406 RVA: 0x0008FF74 File Offset: 0x0008E174
			// (set) Token: 0x060020D7 RID: 8407 RVA: 0x0000CA6C File Offset: 0x0000AC6C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000878 RID: 2168
			// (get) Token: 0x060020D8 RID: 8408 RVA: 0x0008FF9C File Offset: 0x0008E19C
			// (set) Token: 0x060020D9 RID: 8409 RVA: 0x0000CA87 File Offset: 0x0000AC87
			public AsyncTaskMethodBuilder<Dictionary<string, string>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Dictionary<string, string>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Dictionary<string, string>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Dictionary<string, string>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000879 RID: 2169
			// (get) Token: 0x060020DA RID: 8410 RVA: 0x0008FFCC File Offset: 0x0008E1CC
			// (set) Token: 0x060020DB RID: 8411 RVA: 0x0000CAB5 File Offset: 0x0000ACB5
			public unsafe IPEndPoint endpoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr_endpoint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr_endpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087A RID: 2170
			// (get) Token: 0x060020DC RID: 8412 RVA: 0x0008FFFC File Offset: 0x0008E1FC
			// (set) Token: 0x060020DD RID: 8413 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
			public unsafe UdpClient _client_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr__client_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UdpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr__client_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087B RID: 2171
			// (get) Token: 0x060020DE RID: 8414 RVA: 0x0009002C File Offset: 0x0008E22C
			// (set) Token: 0x060020DF RID: 8415 RVA: 0x0000CAF3 File Offset: 0x0000ACF3
			public TaskAwaiter<Dictionary<string, string>> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<Dictionary<string, string>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Dictionary<string, string>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._GetRulesImpl_d__4.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Dictionary<string, string>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040022FC RID: 8956
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040022FD RID: 8957
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040022FE RID: 8958
			private static readonly IntPtr NativeFieldInfoPtr_endpoint;

			// Token: 0x040022FF RID: 8959
			private static readonly IntPtr NativeFieldInfoPtr__client_5__2;

			// Token: 0x04002300 RID: 8960
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002301 RID: 8961
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002302 RID: 8962
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000289 RID: 649
		[ObfuscatedName("Steamworks.SourceServerQuery+<Receive>d__6")]
		public sealed class _Receive_d__6 : ValueType
		{
			// Token: 0x060020E0 RID: 8416 RVA: 0x0009005C File Offset: 0x0008E25C
			// Note: this type is marked as 'beforefieldinit'.
			static _Receive_d__6()
			{
				Il2CppClassPointerStore<SourceServerQuery._Receive_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, "<Receive>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SourceServerQuery._Receive_d__6>.NativeClassPtr);
				SourceServerQuery._Receive_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._Receive_d__6>.NativeClassPtr, "<>1__state");
				SourceServerQuery._Receive_d__6.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._Receive_d__6>.NativeClassPtr, "<>t__builder");
				SourceServerQuery._Receive_d__6.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._Receive_d__6>.NativeClassPtr, "client");
				SourceServerQuery._Receive_d__6.NativeFieldInfoPtr__packets_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._Receive_d__6>.NativeClassPtr, "<packets>5__2");
				SourceServerQuery._Receive_d__6.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._Receive_d__6>.NativeClassPtr, "<>u__1");
				SourceServerQuery._Receive_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery._Receive_d__6>.NativeClassPtr, 100666419);
				SourceServerQuery._Receive_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery._Receive_d__6>.NativeClassPtr, 100666420);
			}

			// Token: 0x060020E1 RID: 8417 RVA: 0x00090114 File Offset: 0x0008E314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947868, XrefRangeEnd = 947962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery._Receive_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020E2 RID: 8418 RVA: 0x0009014C File Offset: 0x0008E34C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947962, XrefRangeEnd = 947968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery._Receive_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020E3 RID: 8419 RVA: 0x0000CB21 File Offset: 0x0000AD21
			public _Receive_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020E4 RID: 8420 RVA: 0x0000CB2A File Offset: 0x0000AD2A
			public _Receive_d__6()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SourceServerQuery._Receive_d__6>.NativeClassPtr))
			{
			}

			// Token: 0x1700087C RID: 2172
			// (get) Token: 0x060020E5 RID: 8421 RVA: 0x00090194 File Offset: 0x0008E394
			// (set) Token: 0x060020E6 RID: 8422 RVA: 0x0000CB3C File Offset: 0x0000AD3C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Receive_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Receive_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700087D RID: 2173
			// (get) Token: 0x060020E7 RID: 8423 RVA: 0x000901BC File Offset: 0x0008E3BC
			// (set) Token: 0x060020E8 RID: 8424 RVA: 0x0000CB57 File Offset: 0x0000AD57
			public AsyncTaskMethodBuilder<Il2CppStructArray<byte>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Receive_d__6.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppStructArray<byte>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Receive_d__6.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700087E RID: 2174
			// (get) Token: 0x060020E9 RID: 8425 RVA: 0x000901EC File Offset: 0x0008E3EC
			// (set) Token: 0x060020EA RID: 8426 RVA: 0x0000CB85 File Offset: 0x0000AD85
			public unsafe UdpClient client
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Receive_d__6.NativeFieldInfoPtr_client);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UdpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Receive_d__6.NativeFieldInfoPtr_client), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087F RID: 2175
			// (get) Token: 0x060020EB RID: 8427 RVA: 0x0009021C File Offset: 0x0008E41C
			// (set) Token: 0x060020EC RID: 8428 RVA: 0x0000CBA4 File Offset: 0x0000ADA4
			public unsafe Il2CppReferenceArray<Il2CppStructArray<byte>> _packets_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Receive_d__6.NativeFieldInfoPtr__packets_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<byte>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Receive_d__6.NativeFieldInfoPtr__packets_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000880 RID: 2176
			// (get) Token: 0x060020ED RID: 8429 RVA: 0x0009024C File Offset: 0x0008E44C
			// (set) Token: 0x060020EE RID: 8430 RVA: 0x0000CBC3 File Offset: 0x0000ADC3
			public TaskAwaiter<UdpReceiveResult> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Receive_d__6.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<UdpReceiveResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<UdpReceiveResult>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Receive_d__6.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<UdpReceiveResult>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002303 RID: 8963
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002304 RID: 8964
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002305 RID: 8965
			private static readonly IntPtr NativeFieldInfoPtr_client;

			// Token: 0x04002306 RID: 8966
			private static readonly IntPtr NativeFieldInfoPtr__packets_5__2;

			// Token: 0x04002307 RID: 8967
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002308 RID: 8968
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002309 RID: 8969
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200028A RID: 650
		[ObfuscatedName("Steamworks.SourceServerQuery+<Send>d__8")]
		public sealed class _Send_d__8 : ValueType
		{
			// Token: 0x060020EF RID: 8431 RVA: 0x0009027C File Offset: 0x0008E47C
			// Note: this type is marked as 'beforefieldinit'.
			static _Send_d__8()
			{
				Il2CppClassPointerStore<SourceServerQuery._Send_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SourceServerQuery>.NativeClassPtr, "<Send>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SourceServerQuery._Send_d__8>.NativeClassPtr);
				SourceServerQuery._Send_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._Send_d__8>.NativeClassPtr, "<>1__state");
				SourceServerQuery._Send_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._Send_d__8>.NativeClassPtr, "<>t__builder");
				SourceServerQuery._Send_d__8.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._Send_d__8>.NativeClassPtr, "message");
				SourceServerQuery._Send_d__8.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._Send_d__8>.NativeClassPtr, "client");
				SourceServerQuery._Send_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SourceServerQuery._Send_d__8>.NativeClassPtr, "<>u__1");
				SourceServerQuery._Send_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery._Send_d__8>.NativeClassPtr, 100666421);
				SourceServerQuery._Send_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SourceServerQuery._Send_d__8>.NativeClassPtr, 100666422);
			}

			// Token: 0x060020F0 RID: 8432 RVA: 0x00090334 File Offset: 0x0008E534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947968, XrefRangeEnd = 947988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery._Send_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020F1 RID: 8433 RVA: 0x0009036C File Offset: 0x0008E56C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947988, XrefRangeEnd = 947992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SourceServerQuery._Send_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020F2 RID: 8434 RVA: 0x0000CBF1 File Offset: 0x0000ADF1
			public _Send_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020F3 RID: 8435 RVA: 0x0000CBFA File Offset: 0x0000ADFA
			public _Send_d__8()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SourceServerQuery._Send_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x17000881 RID: 2177
			// (get) Token: 0x060020F4 RID: 8436 RVA: 0x000903B4 File Offset: 0x0008E5B4
			// (set) Token: 0x060020F5 RID: 8437 RVA: 0x0000CC0C File Offset: 0x0000AE0C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Send_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Send_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000882 RID: 2178
			// (get) Token: 0x060020F6 RID: 8438 RVA: 0x000903DC File Offset: 0x0008E5DC
			// (set) Token: 0x060020F7 RID: 8439 RVA: 0x0000CC27 File Offset: 0x0000AE27
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Send_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Send_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000883 RID: 2179
			// (get) Token: 0x060020F8 RID: 8440 RVA: 0x0009040C File Offset: 0x0008E60C
			// (set) Token: 0x060020F9 RID: 8441 RVA: 0x0000CC55 File Offset: 0x0000AE55
			public unsafe Il2CppStructArray<byte> message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Send_d__8.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Send_d__8.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000884 RID: 2180
			// (get) Token: 0x060020FA RID: 8442 RVA: 0x0009043C File Offset: 0x0008E63C
			// (set) Token: 0x060020FB RID: 8443 RVA: 0x0000CC74 File Offset: 0x0000AE74
			public unsafe UdpClient client
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Send_d__8.NativeFieldInfoPtr_client);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UdpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Send_d__8.NativeFieldInfoPtr_client), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x060020FC RID: 8444 RVA: 0x0009046C File Offset: 0x0008E66C
			// (set) Token: 0x060020FD RID: 8445 RVA: 0x0000CC93 File Offset: 0x0000AE93
			public TaskAwaiter<int> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Send_d__8.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SourceServerQuery._Send_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400230A RID: 8970
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400230B RID: 8971
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400230C RID: 8972
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x0400230D RID: 8973
			private static readonly IntPtr NativeFieldInfoPtr_client;

			// Token: 0x0400230E RID: 8974
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400230F RID: 8975
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002310 RID: 8976
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
