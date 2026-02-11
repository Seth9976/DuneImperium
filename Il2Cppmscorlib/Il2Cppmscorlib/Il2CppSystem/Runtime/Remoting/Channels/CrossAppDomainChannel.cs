using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002C9 RID: 713
	[Serializable]
	public class CrossAppDomainChannel : Object
	{
		// Token: 0x06002D11 RID: 11537 RVA: 0x000EB540 File Offset: 0x000E9740
		// Note: this type is marked as 'beforefieldinit'.
		static CrossAppDomainChannel()
		{
			Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CrossAppDomainChannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr);
			CrossAppDomainChannel.NativeFieldInfoPtr_s_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, "s_lock");
			CrossAppDomainChannel.NativeMethodInfoPtr_RegisterCrossAppDomainChannel_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100670543);
			CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100670544);
			CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100670545);
			CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelData_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100670546);
			CrossAppDomainChannel.NativeMethodInfoPtr_StartListening_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100670547);
			CrossAppDomainChannel.NativeMethodInfoPtr_CreateMessageSink_Public_Virtual_New_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100670548);
			CrossAppDomainChannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr, 100670549);
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x000EB610 File Offset: 0x000E9810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381597, RefRangeEnd = 1381598, XrefRangeStart = 1381579, XrefRangeEnd = 1381597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCrossAppDomainChannel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainChannel.NativeMethodInfoPtr_RegisterCrossAppDomainChannel_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x000EB638 File Offset: 0x000E9838
		public unsafe virtual string ChannelName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381598, XrefRangeEnd = 1381600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x000EB67C File Offset: 0x000E987C
		public unsafe virtual int ChannelPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x000EB6C4 File Offset: 0x000E98C4
		public unsafe virtual Object ChannelData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381600, XrefRangeEnd = 1381614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_get_ChannelData_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x000EB710 File Offset: 0x000E9910
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartListening(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_StartListening_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x000EB760 File Offset: 0x000E9960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381614, XrefRangeEnd = 1381629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageSink CreateMessageSink(string url, Object data, out string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CrossAppDomainChannel.NativeMethodInfoPtr_CreateMessageSink_Public_Virtual_New_IMessageSink_String_Object_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			uri = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x000EB7E8 File Offset: 0x000E99E8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossAppDomainChannel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossAppDomainChannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainChannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x0000F1F6 File Offset: 0x0000D3F6
		public CrossAppDomainChannel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x000EB824 File Offset: 0x000E9A24
		// (set) Token: 0x06002D1B RID: 11547 RVA: 0x0000F1FF File Offset: 0x0000D3FF
		public unsafe static Object s_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CrossAppDomainChannel.NativeFieldInfoPtr_s_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrossAppDomainChannel.NativeFieldInfoPtr_s_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025E0 RID: 9696
		private static readonly IntPtr NativeFieldInfoPtr_s_lock;

		// Token: 0x040025E1 RID: 9697
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCrossAppDomainChannel_Internal_Static_Void_0;

		// Token: 0x040025E2 RID: 9698
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelName_Public_Virtual_New_get_String_0;

		// Token: 0x040025E3 RID: 9699
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x040025E4 RID: 9700
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelData_Public_Virtual_New_get_Object_0;

		// Token: 0x040025E5 RID: 9701
		private static readonly IntPtr NativeMethodInfoPtr_StartListening_Public_Virtual_New_Void_Object_0;

		// Token: 0x040025E6 RID: 9702
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessageSink_Public_Virtual_New_IMessageSink_String_Object_byref_String_0;

		// Token: 0x040025E7 RID: 9703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
