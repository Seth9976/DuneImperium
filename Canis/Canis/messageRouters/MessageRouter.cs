using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.messageRouters
{
	// Token: 0x0200006B RID: 107
	public class MessageRouter : Object
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x000300D0 File Offset: 0x0002E2D0
		// Note: this type is marked as 'beforefieldinit'.
		static MessageRouter()
		{
			Il2CppClassPointerStore<MessageRouter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messageRouters", "MessageRouter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageRouter>.NativeClassPtr);
			MessageRouter.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageRouter>.NativeClassPtr, "match");
			MessageRouter.NativeFieldInfoPtr_subrouters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageRouter>.NativeClassPtr, "subrouters");
			MessageRouter.NativeMethodInfoPtr__ctor_Protected_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageRouter>.NativeClassPtr, 100664484);
			MessageRouter.NativeMethodInfoPtr_Handle_Public_Boolean_Object_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageRouter>.NativeClassPtr, 100664485);
			MessageRouter.NativeMethodInfoPtr_handle_Protected_Abstract_Virtual_New_Boolean_Object_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageRouter>.NativeClassPtr, 100664486);
			MessageRouter.NativeMethodInfoPtr_InstallSubrouter_Public_Void_String_MessageRouter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageRouter>.NativeClassPtr, 100664487);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00030178 File Offset: 0x0002E378
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 555353, RefRangeEnd = 555357, XrefRangeStart = 555344, XrefRangeEnd = 555353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageRouter(Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageRouter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageRouter.NativeMethodInfoPtr__ctor_Protected_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000301C4 File Offset: 0x0002E3C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 555366, RefRangeEnd = 555370, XrefRangeStart = 555357, XrefRangeEnd = 555366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Handle(Object response, string messageName, AccountID accountID = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(messageName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageRouter.NativeMethodInfoPtr_Handle_Public_Boolean_Object_String_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00030238 File Offset: 0x0002E438
		[CallerCount(0)]
		public unsafe virtual bool handle(Object response, string messageName, AccountID accountID = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(messageName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageRouter.NativeMethodInfoPtr_handle_Protected_Abstract_Virtual_New_Boolean_Object_String_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000302B4 File Offset: 0x0002E4B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 555374, RefRangeEnd = 555378, XrefRangeStart = 555370, XrefRangeEnd = 555374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstallSubrouter(string messageName, MessageRouter subrouter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(messageName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subrouter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageRouter.NativeMethodInfoPtr_InstallSubrouter_Public_Void_String_MessageRouter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000047A7 File Offset: 0x000029A7
		public MessageRouter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00030308 File Offset: 0x0002E508
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x000047B0 File Offset: 0x000029B0
		public unsafe Match match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageRouter.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageRouter.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00030338 File Offset: 0x0002E538
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x000047CF File Offset: 0x000029CF
		public unsafe Dictionary<string, MessageRouter> subrouters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageRouter.NativeFieldInfoPtr_subrouters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, MessageRouter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageRouter.NativeFieldInfoPtr_subrouters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr_subrouters;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Boolean_Object_String_AccountID_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_handle_Protected_Abstract_Virtual_New_Boolean_Object_String_AccountID_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_InstallSubrouter_Public_Void_String_MessageRouter_0;
	}
}
