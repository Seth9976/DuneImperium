using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.messageRouters
{
	// Token: 0x0200006C RID: 108
	public class ResignMatchRouter : MessageRouter
	{
		// Token: 0x060005D2 RID: 1490 RVA: 0x00030368 File Offset: 0x0002E568
		// Note: this type is marked as 'beforefieldinit'.
		static ResignMatchRouter()
		{
			Il2CppClassPointerStore<ResignMatchRouter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.messageRouters", "ResignMatchRouter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResignMatchRouter>.NativeClassPtr);
			ResignMatchRouter.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignMatchRouter>.NativeClassPtr, 100664488);
			ResignMatchRouter.NativeMethodInfoPtr_handle_Protected_Virtual_Boolean_Object_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResignMatchRouter>.NativeClassPtr, 100664489);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000303C0 File Offset: 0x0002E5C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 555127, RefRangeEnd = 555130, XrefRangeStart = 555127, XrefRangeEnd = 555130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResignMatchRouter(Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResignMatchRouter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResignMatchRouter.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0003040C File Offset: 0x0002E60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 555378, XrefRangeEnd = 555381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResignMatchRouter.NativeMethodInfoPtr_handle_Protected_Virtual_Boolean_Object_String_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x000047EE File Offset: 0x000029EE
		public ResignMatchRouter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_handle_Protected_Virtual_Boolean_Object_String_AccountID_0;
	}
}
