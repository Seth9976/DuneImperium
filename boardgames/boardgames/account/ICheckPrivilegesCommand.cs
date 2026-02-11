using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.account
{
	// Token: 0x02000184 RID: 388
	public class ICheckPrivilegesCommand : Il2CppObjectBase
	{
		// Token: 0x0600131D RID: 4893 RVA: 0x0004C13C File Offset: 0x0004A33C
		// Note: this type is marked as 'beforefieldinit'.
		static ICheckPrivilegesCommand()
		{
			Il2CppClassPointerStore<ICheckPrivilegesCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.account", "ICheckPrivilegesCommand");
			ICheckPrivilegesCommand.NativeMethodInfoPtr_HasPrivileges_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICheckPrivilegesCommand>.NativeClassPtr, 100666102);
			ICheckPrivilegesCommand.NativeMethodInfoPtr_Create_Public_Static_ICheckPrivilegesCommand_Boolean_Il2CppStructArray_1_Permissions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICheckPrivilegesCommand>.NativeClassPtr, 100666103);
			ICheckPrivilegesCommand.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_byref_ICheckPrivilegesCommand_Boolean_Il2CppStructArray_1_Permissions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICheckPrivilegesCommand>.NativeClassPtr, 100666104);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0004C1A0 File Offset: 0x0004A3A0
		[CallerCount(0)]
		public unsafe virtual bool HasPrivileges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICheckPrivilegesCommand.NativeMethodInfoPtr_HasPrivileges_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0004C1E8 File Offset: 0x0004A3E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1001797, RefRangeEnd = 1001801, XrefRangeStart = 1001781, XrefRangeEnd = 1001797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICheckPrivilegesCommand Create(bool notifyUser, [Optional] Il2CppStructArray<Permissions> privileges)
		{
			if (privileges == null)
			{
				privileges = new Il2CppStructArray<Permissions>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref notifyUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(privileges);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ICheckPrivilegesCommand.NativeMethodInfoPtr_Create_Public_Static_ICheckPrivilegesCommand_Boolean_Il2CppStructArray_1_Permissions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICheckPrivilegesCommand>(intPtr3) : null;
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0004C248 File Offset: 0x0004A448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001801, XrefRangeEnd = 1001817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCreate(out ICheckPrivilegesCommand command, bool notifyUser, [Optional] Il2CppStructArray<Permissions> privileges)
		{
			if (privileges == null)
			{
				privileges = new Il2CppStructArray<Permissions>(0L);
			}
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notifyUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(privileges);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ICheckPrivilegesCommand.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_byref_ICheckPrivilegesCommand_Boolean_Il2CppStructArray_1_Permissions_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			command = ((intPtr4 == 0) ? null : new ICheckPrivilegesCommand(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0000AEBE File Offset: 0x000090BE
		public static ICheckPrivilegesCommand Create(bool notifyUser, params Permissions[] privileges)
		{
			return ICheckPrivilegesCommand.Create(notifyUser, new Il2CppStructArray<Permissions>(privileges));
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0000AECC File Offset: 0x000090CC
		public static bool TryCreate(out ICheckPrivilegesCommand command, bool notifyUser, params Permissions[] privileges)
		{
			return ICheckPrivilegesCommand.TryCreate(out command, notifyUser, new Il2CppStructArray<Permissions>(privileges));
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0000AEDB File Offset: 0x000090DB
		public ICheckPrivilegesCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr_HasPrivileges_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ICheckPrivilegesCommand_Boolean_Il2CppStructArray_1_Permissions_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_byref_ICheckPrivilegesCommand_Boolean_Il2CppStructArray_1_Permissions_0;
	}
}
