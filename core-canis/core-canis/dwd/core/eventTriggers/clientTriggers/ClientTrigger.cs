using System;
using dwd.core.endorsement;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.clientevents;

namespace dwd.core.eventTriggers.clientTriggers
{
	// Token: 0x020001AF RID: 431
	public class ClientTrigger : Request
	{
		// Token: 0x06001857 RID: 6231 RVA: 0x000752A8 File Offset: 0x000734A8
		// Note: this type is marked as 'beforefieldinit'.
		static ClientTrigger()
		{
			Il2CppClassPointerStore<ClientTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers.clientTriggers", "ClientTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientTrigger>.NativeClassPtr);
			ClientTrigger.NativeMethodInfoPtr_Matches_Public_Boolean_ClientEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientTrigger>.NativeClassPtr, 100667199);
			ClientTrigger.NativeMethodInfoPtr_matches_Protected_Abstract_Virtual_New_Boolean_ClientEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientTrigger>.NativeClassPtr, 100667200);
			ClientTrigger.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientTrigger>.NativeClassPtr, 100667201);
			ClientTrigger.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientTrigger>.NativeClassPtr, 100667202);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00075328 File Offset: 0x00073528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 880486, RefRangeEnd = 880488, XrefRangeStart = 880463, XrefRangeEnd = 880486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Matches(ClientEvent clientEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientTrigger.NativeMethodInfoPtr_Matches_Public_Boolean_ClientEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00075378 File Offset: 0x00073578
		[CallerCount(0)]
		public unsafe virtual bool matches(ClientEvent clientEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientTrigger.NativeMethodInfoPtr_matches_Protected_Abstract_Virtual_New_Boolean_ClientEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x000753D0 File Offset: 0x000735D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880488, XrefRangeEnd = 880490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientTrigger.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00075414 File Offset: 0x00073614
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 880491, RefRangeEnd = 880498, XrefRangeStart = 880490, XrefRangeEnd = 880491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientTrigger.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0000AAC0 File Offset: 0x00008CC0
		public ClientTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Boolean_ClientEvent_0;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr_matches_Protected_Abstract_Virtual_New_Boolean_ClientEvent_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
