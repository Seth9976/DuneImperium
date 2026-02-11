using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.messageRouters
{
	// Token: 0x02000069 RID: 105
	public class ConnectionMessageRouter : MessageRouter
	{
		// Token: 0x060005BB RID: 1467 RVA: 0x0002FD28 File Offset: 0x0002DF28
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionMessageRouter()
		{
			Il2CppClassPointerStore<ConnectionMessageRouter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messageRouters", "ConnectionMessageRouter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionMessageRouter>.NativeClassPtr);
			ConnectionMessageRouter.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionMessageRouter>.NativeClassPtr, 100664470);
			ConnectionMessageRouter.NativeMethodInfoPtr_handle_Protected_Virtual_Boolean_Object_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionMessageRouter>.NativeClassPtr, 100664471);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0002FD80 File Offset: 0x0002DF80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 555127, RefRangeEnd = 555130, XrefRangeStart = 555126, XrefRangeEnd = 555127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionMessageRouter(Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionMessageRouter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionMessageRouter.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0002FDCC File Offset: 0x0002DFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555130, XrefRangeEnd = 555133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool handle(Object response, string messageName, AccountID accountID = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConnectionMessageRouter.NativeMethodInfoPtr_handle_Protected_Virtual_Boolean_Object_String_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00004776 File Offset: 0x00002976
		public ConnectionMessageRouter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_handle_Protected_Virtual_Boolean_Object_String_AccountID_0;
	}
}
