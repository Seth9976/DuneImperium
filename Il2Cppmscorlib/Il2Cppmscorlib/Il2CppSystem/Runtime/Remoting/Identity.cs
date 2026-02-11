using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000296 RID: 662
	public class Identity : Object
	{
		// Token: 0x06002A3B RID: 10811 RVA: 0x000E0C30 File Offset: 0x000DEE30
		// Note: this type is marked as 'beforefieldinit'.
		static Identity()
		{
			Il2CppClassPointerStore<Identity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "Identity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Identity>.NativeClassPtr);
			Identity.NativeFieldInfoPtr__objectUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_objectUri");
			Identity.NativeFieldInfoPtr__channelSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_channelSink");
			Identity.NativeFieldInfoPtr__envoySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_envoySink");
			Identity.NativeFieldInfoPtr__clientDynamicProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_clientDynamicProperties");
			Identity.NativeFieldInfoPtr__serverDynamicProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_serverDynamicProperties");
			Identity.NativeFieldInfoPtr__objRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_objRef");
			Identity.NativeFieldInfoPtr__disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Identity>.NativeClassPtr, "_disposed");
			Identity.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670177);
			Identity.NativeMethodInfoPtr_CreateObjRef_Public_Abstract_Virtual_New_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670178);
			Identity.NativeMethodInfoPtr_get_ChannelSink_Public_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670179);
			Identity.NativeMethodInfoPtr_set_ChannelSink_Public_set_Void_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670180);
			Identity.NativeMethodInfoPtr_get_EnvoySink_Public_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670181);
			Identity.NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670182);
			Identity.NativeMethodInfoPtr_set_ObjectUri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670183);
			Identity.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670184);
			Identity.NativeMethodInfoPtr_get_Disposed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670185);
			Identity.NativeMethodInfoPtr_set_Disposed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670186);
			Identity.NativeMethodInfoPtr_get_ClientDynamicProperties_Public_get_DynamicPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670187);
			Identity.NativeMethodInfoPtr_get_HasServerDynamicSinks_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670188);
			Identity.NativeMethodInfoPtr_NotifyClientDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670189);
			Identity.NativeMethodInfoPtr_NotifyServerDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Identity>.NativeClassPtr, 100670190);
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x000E0E04 File Offset: 0x000DF004
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Identity(string objectUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Identity>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x000E0E50 File Offset: 0x000DF050
		[CallerCount(0)]
		public unsafe virtual ObjRef CreateObjRef(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Identity.NativeMethodInfoPtr_CreateObjRef_Public_Abstract_Virtual_New_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06002A3E RID: 10814 RVA: 0x000E0EAC File Offset: 0x000DF0AC
		// (set) Token: 0x06002A3F RID: 10815 RVA: 0x000E0EEC File Offset: 0x000DF0EC
		public unsafe IMessageSink ChannelSink
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_ChannelSink_Public_get_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_set_ChannelSink_Public_set_Void_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x000E0F30 File Offset: 0x000DF130
		public unsafe IMessageSink EnvoySink
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_EnvoySink_Public_get_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06002A41 RID: 10817 RVA: 0x000E0F70 File Offset: 0x000DF170
		// (set) Token: 0x06002A42 RID: 10818 RVA: 0x000E0FA8 File Offset: 0x000DF1A8
		public unsafe string ObjectUri
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_set_ObjectUri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002A43 RID: 10819 RVA: 0x000E0FEC File Offset: 0x000DF1EC
		public unsafe bool IsConnected
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322834, RefRangeEnd = 322836, XrefRangeStart = 322834, XrefRangeEnd = 322836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x000E1028 File Offset: 0x000DF228
		// (set) Token: 0x06002A45 RID: 10821 RVA: 0x000E1064 File Offset: 0x000DF264
		public unsafe bool Disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_Disposed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_set_Disposed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x000E10A4 File Offset: 0x000DF2A4
		public unsafe DynamicPropertyCollection ClientDynamicProperties
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1376820, RefRangeEnd = 1376822, XrefRangeStart = 1376815, XrefRangeEnd = 1376820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_ClientDynamicProperties_Public_get_DynamicPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x000E10E4 File Offset: 0x000DF2E4
		public unsafe bool HasServerDynamicSinks
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1376822, RefRangeEnd = 1376823, XrefRangeStart = 1376822, XrefRangeEnd = 1376822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_get_HasServerDynamicSinks_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x000E1120 File Offset: 0x000DF320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376823, XrefRangeEnd = 1376825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(req_msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_NotifyClientDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x000E118C File Offset: 0x000DF38C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1376827, RefRangeEnd = 1376832, XrefRangeStart = 1376825, XrefRangeEnd = 1376827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(req_msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Identity.NativeMethodInfoPtr_NotifyServerDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x0000E087 File Offset: 0x0000C287
		public Identity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x000E11F8 File Offset: 0x000DF3F8
		// (set) Token: 0x06002A4C RID: 10828 RVA: 0x0000E090 File Offset: 0x0000C290
		public unsafe string _objectUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__objectUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__objectUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x000E1220 File Offset: 0x000DF420
		// (set) Token: 0x06002A4E RID: 10830 RVA: 0x0000E0AF File Offset: 0x0000C2AF
		public unsafe IMessageSink _channelSink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__channelSink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__channelSink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x000E1250 File Offset: 0x000DF450
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x0000E0CE File Offset: 0x0000C2CE
		public unsafe IMessageSink _envoySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__envoySink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__envoySink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x000E1280 File Offset: 0x000DF480
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x0000E0ED File Offset: 0x0000C2ED
		public unsafe DynamicPropertyCollection _clientDynamicProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__clientDynamicProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__clientDynamicProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x000E12B0 File Offset: 0x000DF4B0
		// (set) Token: 0x06002A54 RID: 10836 RVA: 0x0000E10C File Offset: 0x0000C30C
		public unsafe DynamicPropertyCollection _serverDynamicProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__serverDynamicProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__serverDynamicProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x000E12E0 File Offset: 0x000DF4E0
		// (set) Token: 0x06002A56 RID: 10838 RVA: 0x0000E12B File Offset: 0x0000C32B
		public unsafe ObjRef _objRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__objRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__objRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x000E1310 File Offset: 0x000DF510
		// (set) Token: 0x06002A58 RID: 10840 RVA: 0x0000E14A File Offset: 0x0000C34A
		public unsafe bool _disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Identity.NativeFieldInfoPtr__disposed)) = value;
			}
		}

		// Token: 0x040023F2 RID: 9202
		private static readonly IntPtr NativeFieldInfoPtr__objectUri;

		// Token: 0x040023F3 RID: 9203
		private static readonly IntPtr NativeFieldInfoPtr__channelSink;

		// Token: 0x040023F4 RID: 9204
		private static readonly IntPtr NativeFieldInfoPtr__envoySink;

		// Token: 0x040023F5 RID: 9205
		private static readonly IntPtr NativeFieldInfoPtr__clientDynamicProperties;

		// Token: 0x040023F6 RID: 9206
		private static readonly IntPtr NativeFieldInfoPtr__serverDynamicProperties;

		// Token: 0x040023F7 RID: 9207
		private static readonly IntPtr NativeFieldInfoPtr__objRef;

		// Token: 0x040023F8 RID: 9208
		private static readonly IntPtr NativeFieldInfoPtr__disposed;

		// Token: 0x040023F9 RID: 9209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040023FA RID: 9210
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Abstract_Virtual_New_ObjRef_Type_0;

		// Token: 0x040023FB RID: 9211
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelSink_Public_get_IMessageSink_0;

		// Token: 0x040023FC RID: 9212
		private static readonly IntPtr NativeMethodInfoPtr_set_ChannelSink_Public_set_Void_IMessageSink_0;

		// Token: 0x040023FD RID: 9213
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvoySink_Public_get_IMessageSink_0;

		// Token: 0x040023FE RID: 9214
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0;

		// Token: 0x040023FF RID: 9215
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectUri_Public_set_Void_String_0;

		// Token: 0x04002400 RID: 9216
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0;

		// Token: 0x04002401 RID: 9217
		private static readonly IntPtr NativeMethodInfoPtr_get_Disposed_Public_get_Boolean_0;

		// Token: 0x04002402 RID: 9218
		private static readonly IntPtr NativeMethodInfoPtr_set_Disposed_Public_set_Void_Boolean_0;

		// Token: 0x04002403 RID: 9219
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientDynamicProperties_Public_get_DynamicPropertyCollection_0;

		// Token: 0x04002404 RID: 9220
		private static readonly IntPtr NativeMethodInfoPtr_get_HasServerDynamicSinks_Public_get_Boolean_0;

		// Token: 0x04002405 RID: 9221
		private static readonly IntPtr NativeMethodInfoPtr_NotifyClientDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0;

		// Token: 0x04002406 RID: 9222
		private static readonly IntPtr NativeMethodInfoPtr_NotifyServerDynamicSinks_Public_Void_Boolean_IMessage_Boolean_Boolean_0;
	}
}
