using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000C9 RID: 201
	public class SteamClass : Object
	{
		// Token: 0x06000CD0 RID: 3280 RVA: 0x00053D48 File Offset: 0x00051F48
		// Note: this type is marked as 'beforefieldinit'.
		static SteamClass()
		{
			Il2CppClassPointerStore<SteamClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamClass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamClass>.NativeClassPtr);
			SteamClass.NativeMethodInfoPtr_InitializeInterface_Internal_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClass>.NativeClassPtr, 100666432);
			SteamClass.NativeMethodInfoPtr_DestroyInterface_Internal_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClass>.NativeClassPtr, 100666433);
			SteamClass.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClass>.NativeClassPtr, 100666434);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00053DB4 File Offset: 0x00051FB4
		[CallerCount(0)]
		public unsafe virtual void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamClass.NativeMethodInfoPtr_InitializeInterface_Internal_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00053E00 File Offset: 0x00052000
		[CallerCount(0)]
		public unsafe virtual void DestroyInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamClass.NativeMethodInfoPtr_DestroyInterface_Internal_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00053E4C File Offset: 0x0005204C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamClass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamClass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClass.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x000033A0 File Offset: 0x000015A0
		public SteamClass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_DestroyInterface_Internal_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
