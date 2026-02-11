using System;
using dwd.core.account;
using dwd.core.session;
using dwd.core.wargServer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace platformCore.session
{
	// Token: 0x02000006 RID: 6
	public class PlatformSessionProvider : SessionProvider
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000034D4 File Offset: 0x000016D4
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformSessionProvider()
		{
			Il2CppClassPointerStore<PlatformSessionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("platformCore.dll", "platformCore.session", "PlatformSessionProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformSessionProvider>.NativeClassPtr);
			PlatformSessionProvider.NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSessionProvider>.NativeClassPtr, "writer");
			PlatformSessionProvider.NativeMethodInfoPtr_get_Account_Public_get_SerializableAccount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSessionProvider>.NativeClassPtr, 100663303);
			PlatformSessionProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSessionProvider>.NativeClassPtr, 100663304);
			PlatformSessionProvider.NativeMethodInfoPtr_set_Initialized_Protected_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSessionProvider>.NativeClassPtr, 100663305);
			PlatformSessionProvider.NativeMethodInfoPtr_Terminate_Public_Virtual_Void_DisconnectReasons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSessionProvider>.NativeClassPtr, 100663306);
			PlatformSessionProvider.NativeMethodInfoPtr_RegisterWriter_Public_Void_ISessionWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSessionProvider>.NativeClassPtr, 100663307);
			PlatformSessionProvider.NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSessionProvider>.NativeClassPtr, 100663308);
			PlatformSessionProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSessionProvider>.NativeClassPtr, 100663309);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000035A4 File Offset: 0x000017A4
		public unsafe SerializableAccount Account
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249657, XrefRangeEnd = 1249665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSessionProvider.NativeMethodInfoPtr_get_Account_Public_get_SerializableAccount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableAccount>(intPtr3) : null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000035E4 File Offset: 0x000017E4
		// (set) Token: 0x06000016 RID: 22 RVA: 0x0000362C File Offset: 0x0000182C
		public unsafe override bool Initialized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249665, XrefRangeEnd = 1249672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSessionProvider.NativeMethodInfoPtr_get_Initialized_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249672, XrefRangeEnd = 1249678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSessionProvider.NativeMethodInfoPtr_set_Initialized_Protected_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003678 File Offset: 0x00001878
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Terminate(WargSession.DisconnectReasons reason = WargSession.DisconnectReasons.Error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reason;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSessionProvider.NativeMethodInfoPtr_Terminate_Public_Virtual_Void_DisconnectReasons_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000036C4 File Offset: 0x000018C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterWriter(ISessionWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSessionProvider.NativeMethodInfoPtr_RegisterWriter_Public_Void_ISessionWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003708 File Offset: 0x00001908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249678, XrefRangeEnd = 1249692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSessionProvider.NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003758 File Offset: 0x00001958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249692, XrefRangeEnd = 1249693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformSessionProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformSessionProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSessionProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020E7 File Offset: 0x000002E7
		public PlatformSessionProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003794 File Offset: 0x00001994
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe ISessionWriter writer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSessionProvider.NativeFieldInfoPtr_writer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISessionWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSessionProvider.NativeFieldInfoPtr_writer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_writer;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_Account_Public_get_SerializableAccount_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_get_Boolean_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Protected_Virtual_set_Void_Boolean_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_Terminate_Public_Virtual_Void_DisconnectReasons_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWriter_Public_Void_ISessionWriter_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
