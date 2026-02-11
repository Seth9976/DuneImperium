using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000109 RID: 265
	public class IPlayerEditorConnectionNative : Il2CppObjectBase
	{
		// Token: 0x0600164A RID: 5706 RVA: 0x0006BB34 File Offset: 0x00069D34
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayerEditorConnectionNative()
		{
			Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "IPlayerEditorConnectionNative");
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100666385);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_DisconnectAll_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100666386);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100666387);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_TrySendMessage_Public_Abstract_Virtual_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100666388);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_Poll_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100666389);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_RegisterInternal_Public_Abstract_Virtual_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100666390);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_UnregisterInternal_Public_Abstract_Virtual_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100666391);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_IsConnected_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100666392);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0006BBFC File Offset: 0x00069DFC
		[CallerCount(0)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0006BC38 File Offset: 0x00069E38
		[CallerCount(0)]
		public unsafe virtual void DisconnectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_DisconnectAll_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0006BC74 File Offset: 0x00069E74
		[CallerCount(0)]
		public unsafe virtual void SendMessage(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0006BCE0 File Offset: 0x00069EE0
		[CallerCount(0)]
		public unsafe virtual bool TrySendMessage(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_TrySendMessage_Public_Abstract_Virtual_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0006BD54 File Offset: 0x00069F54
		[CallerCount(0)]
		public unsafe virtual void Poll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_Poll_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0006BD90 File Offset: 0x00069F90
		[CallerCount(0)]
		public unsafe virtual void RegisterInternal(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_RegisterInternal_Public_Abstract_Virtual_New_Void_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0006BDDC File Offset: 0x00069FDC
		[CallerCount(0)]
		public unsafe virtual void UnregisterInternal(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_UnregisterInternal_Public_Abstract_Virtual_New_Void_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0006BE28 File Offset: 0x0006A028
		[CallerCount(0)]
		public unsafe virtual bool IsConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_IsConnected_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00008D12 File Offset: 0x00006F12
		public IPlayerEditorConnectionNative(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectAll_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_TrySendMessage_Public_Abstract_Virtual_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_Poll_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInternal_Public_Abstract_Virtual_New_Void_Guid_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterInternal_Public_Abstract_Virtual_New_Void_Guid_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_IsConnected_Public_Abstract_Virtual_New_Boolean_0;
	}
}
