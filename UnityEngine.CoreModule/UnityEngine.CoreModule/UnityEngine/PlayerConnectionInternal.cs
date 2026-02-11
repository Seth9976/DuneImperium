using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200010A RID: 266
	public class PlayerConnectionInternal : Object
	{
		// Token: 0x06001654 RID: 5716 RVA: 0x0006BE70 File Offset: 0x0006A070
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerConnectionInternal()
		{
			Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PlayerConnectionInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_SendMessage_Private_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666393);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_TrySendMessage_Private_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666394);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Poll_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666395);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_RegisterInternal_Private_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666396);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal_Private_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666397);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Initialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666398);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_IsConnected_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666399);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_DisconnectAll_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666400);
			PlayerConnectionInternal.NativeMethodInfoPtr_IsConnected_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666401);
			PlayerConnectionInternal.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666402);
			PlayerConnectionInternal.NativeMethodInfoPtr_RegisterInternal_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666403);
			PlayerConnectionInternal.NativeMethodInfoPtr_UnregisterInternal_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666404);
			PlayerConnectionInternal.NativeMethodInfoPtr_SendMessage_Private_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666405);
			PlayerConnectionInternal.NativeMethodInfoPtr_TrySendMessage_Private_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666406);
			PlayerConnectionInternal.NativeMethodInfoPtr_PollInternal_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666407);
			PlayerConnectionInternal.NativeMethodInfoPtr_DisconnectAll_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666408);
			PlayerConnectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100666409);
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0006BFF4 File Offset: 0x0006A1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660010, XrefRangeEnd = 660018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_SendMessage(Guid messageId, Il2CppStructArray<byte> data, int playerId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_SendMessage_Private_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0006C054 File Offset: 0x0006A254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660018, XrefRangeEnd = 660026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_IPlayerEditorConnectionNative_TrySendMessage(Guid messageId, Il2CppStructArray<byte> data, int playerId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_TrySendMessage_Private_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x0006C0C0 File Offset: 0x0006A2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660026, XrefRangeEnd = 660028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_Poll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Poll_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0006C0F4 File Offset: 0x0006A2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660028, XrefRangeEnd = 660033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_RegisterInternal(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_RegisterInternal_Private_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0006C134 File Offset: 0x0006A334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660033, XrefRangeEnd = 660038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal_Private_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0006C174 File Offset: 0x0006A374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660038, XrefRangeEnd = 660040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Initialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0006C1A8 File Offset: 0x0006A3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660040, XrefRangeEnd = 660042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_IPlayerEditorConnectionNative_IsConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_IsConnected_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0006C1E4 File Offset: 0x0006A3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660042, XrefRangeEnd = 660044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_IPlayerEditorConnectionNative_DisconnectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_DisconnectAll_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0006C218 File Offset: 0x0006A418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsConnected()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_IsConnected_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0006C248 File Offset: 0x0006A448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0006C270 File Offset: 0x0006A470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660044, XrefRangeEnd = 660046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterInternal(string messageId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(messageId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_RegisterInternal_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0006C2A8 File Offset: 0x0006A4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660046, XrefRangeEnd = 660048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterInternal(string messageId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(messageId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnregisterInternal_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0006C2E0 File Offset: 0x0006A4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660048, XrefRangeEnd = 660050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendMessage(string messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(messageId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_SendMessage_Private_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0006C338 File Offset: 0x0006A538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660050, XrefRangeEnd = 660052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySendMessage(string messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(messageId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_TrySendMessage_Private_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x0006C39C File Offset: 0x0006A59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PollInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_PollInternal_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0006C3C4 File Offset: 0x0006A5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisconnectAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_DisconnectAll_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x0006C3EC File Offset: 0x0006A5EC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerConnectionInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00008D1B File Offset: 0x00006F1B
		public PlayerConnectionInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_SendMessage_Private_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_TrySendMessage_Private_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Poll_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_RegisterInternal_Private_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal_Private_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Initialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_IsConnected_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_DisconnectAll_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_IsConnected_Private_Static_Boolean_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInternal_Private_Static_Void_String_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterInternal_Private_Static_Void_String_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Private_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_TrySendMessage_Private_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_PollInternal_Private_Static_Void_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectAll_Private_Static_Void_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200070B RID: 1803
		public enum MulticastFlags
		{
			// Token: 0x04002C20 RID: 11296
			kRequestImmediateConnect = 1,
			// Token: 0x04002C21 RID: 11297
			kSupportsProfile,
			// Token: 0x04002C22 RID: 11298
			kCustomMessage = 4,
			// Token: 0x04002C23 RID: 11299
			kUseAlternateIP = 8
		}
	}
}
