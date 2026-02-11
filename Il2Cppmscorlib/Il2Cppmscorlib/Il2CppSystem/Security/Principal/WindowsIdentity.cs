using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Claims;

namespace Il2CppSystem.Security.Principal
{
	// Token: 0x02000287 RID: 647
	[Serializable]
	public class WindowsIdentity : ClaimsIdentity
	{
		// Token: 0x06002972 RID: 10610 RVA: 0x000DDD98 File Offset: 0x000DBF98
		// Note: this type is marked as 'beforefieldinit'.
		static WindowsIdentity()
		{
			Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Principal", "WindowsIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr);
			WindowsIdentity.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_token");
			WindowsIdentity.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_type");
			WindowsIdentity.NativeFieldInfoPtr__account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_account");
			WindowsIdentity.NativeFieldInfoPtr__authenticated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_authenticated");
			WindowsIdentity.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_name");
			WindowsIdentity.NativeFieldInfoPtr__info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "_info");
			WindowsIdentity.NativeFieldInfoPtr_invalidWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, "invalidWindows");
			WindowsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_String_WindowsAccountType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670074);
			WindowsIdentity.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670075);
			WindowsIdentity.NativeMethodInfoPtr__ctor_Internal_Void_ClaimsIdentity_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670076);
			WindowsIdentity.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670077);
			WindowsIdentity.NativeMethodInfoPtr_GetCurrent_Public_Static_WindowsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670078);
			WindowsIdentity.NativeMethodInfoPtr_Impersonate_Public_Virtual_New_WindowsImpersonationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670079);
			WindowsIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670080);
			WindowsIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670081);
			WindowsIdentity.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670082);
			WindowsIdentity.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670083);
			WindowsIdentity.NativeMethodInfoPtr_CloneAsBase_Internal_ClaimsIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670084);
			WindowsIdentity.NativeMethodInfoPtr_GetTokenInternal_Internal_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670085);
			WindowsIdentity.NativeMethodInfoPtr_SetToken_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670086);
			WindowsIdentity.NativeMethodInfoPtr_GetCurrentToken_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670087);
			WindowsIdentity.NativeMethodInfoPtr_GetTokenName_Private_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr, 100670088);
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x000DDF80 File Offset: 0x000DC180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375681, XrefRangeEnd = 1375685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userToken;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acctType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAuthenticated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_String_WindowsAccountType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000DDFF8 File Offset: 0x000DC1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375685, XrefRangeEnd = 1375687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsIdentity(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000DE05C File Offset: 0x000DC25C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375691, RefRangeEnd = 1375692, XrefRangeStart = 1375687, XrefRangeEnd = 1375691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsIdentity(ClaimsIdentity claimsIdentity, IntPtr userToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(claimsIdentity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userToken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr__ctor_Internal_Void_ClaimsIdentity_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x000DE0B8 File Offset: 0x000DC2B8
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000DE0EC File Offset: 0x000DC2EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1375702, RefRangeEnd = 1375705, XrefRangeStart = 1375692, XrefRangeEnd = 1375702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WindowsIdentity GetCurrent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_GetCurrent_Public_Static_WindowsIdentity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WindowsIdentity>(intPtr3) : null;
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000DE120 File Offset: 0x000DC320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375705, XrefRangeEnd = 1375711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WindowsImpersonationContext Impersonate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WindowsIdentity.NativeMethodInfoPtr_Impersonate_Public_Virtual_New_WindowsImpersonationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WindowsImpersonationContext>(intPtr3) : null;
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x000DE16C File Offset: 0x000DC36C
		public unsafe override string AuthenticationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x0600297A RID: 10618 RVA: 0x000DE1A4 File Offset: 0x000DC3A4
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375711, XrefRangeEnd = 1375716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WindowsIdentity.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000DE1E8 File Offset: 0x000DC3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375716, XrefRangeEnd = 1375759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000DE22C File Offset: 0x000DC42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375759, XrefRangeEnd = 1375780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000DE288 File Offset: 0x000DC488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375780, XrefRangeEnd = 1375781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClaimsIdentity CloneAsBase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_CloneAsBase_Internal_ClaimsIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClaimsIdentity>(intPtr3) : null;
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x000DE2C8 File Offset: 0x000DC4C8
		[CallerCount(0)]
		public unsafe IntPtr GetTokenInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_GetTokenInternal_Internal_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x000DE304 File Offset: 0x000DC504
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1375796, RefRangeEnd = 1375799, XrefRangeStart = 1375781, XrefRangeEnd = 1375796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToken(IntPtr token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_SetToken_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x000DE344 File Offset: 0x000DC544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetCurrentToken()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_GetCurrentToken_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000DE374 File Offset: 0x000DC574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375799, XrefRangeEnd = 1375800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTokenName(IntPtr token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsIdentity.NativeMethodInfoPtr_GetTokenName_Private_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x0000DAF3 File Offset: 0x0000BCF3
		public WindowsIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x000DE3AC File Offset: 0x000DC5AC
		// (set) Token: 0x06002984 RID: 10628 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		public unsafe IntPtr _token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__token)) = value;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06002985 RID: 10629 RVA: 0x000DE3D4 File Offset: 0x000DC5D4
		// (set) Token: 0x06002986 RID: 10630 RVA: 0x0000DB17 File Offset: 0x0000BD17
		public unsafe string _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x000DE3FC File Offset: 0x000DC5FC
		// (set) Token: 0x06002988 RID: 10632 RVA: 0x0000DB36 File Offset: 0x0000BD36
		public unsafe WindowsAccountType _account
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__account);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__account)) = value;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002989 RID: 10633 RVA: 0x000DE424 File Offset: 0x000DC624
		// (set) Token: 0x0600298A RID: 10634 RVA: 0x0000DB51 File Offset: 0x0000BD51
		public unsafe bool _authenticated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__authenticated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__authenticated)) = value;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x0600298B RID: 10635 RVA: 0x000DE44C File Offset: 0x000DC64C
		// (set) Token: 0x0600298C RID: 10636 RVA: 0x0000DB6C File Offset: 0x0000BD6C
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x0600298D RID: 10637 RVA: 0x000DE474 File Offset: 0x000DC674
		// (set) Token: 0x0600298E RID: 10638 RVA: 0x0000DB8B File Offset: 0x0000BD8B
		public unsafe SerializationInfo _info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsIdentity.NativeFieldInfoPtr__info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x0600298F RID: 10639 RVA: 0x000DE4A4 File Offset: 0x000DC6A4
		// (set) Token: 0x06002990 RID: 10640 RVA: 0x0000DBAA File Offset: 0x0000BDAA
		public unsafe static IntPtr invalidWindows
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WindowsIdentity.NativeFieldInfoPtr_invalidWindows, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WindowsIdentity.NativeFieldInfoPtr_invalidWindows, (void*)(&value));
			}
		}

		// Token: 0x0400236A RID: 9066
		private static readonly IntPtr NativeFieldInfoPtr__token;

		// Token: 0x0400236B RID: 9067
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x0400236C RID: 9068
		private static readonly IntPtr NativeFieldInfoPtr__account;

		// Token: 0x0400236D RID: 9069
		private static readonly IntPtr NativeFieldInfoPtr__authenticated;

		// Token: 0x0400236E RID: 9070
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x0400236F RID: 9071
		private static readonly IntPtr NativeFieldInfoPtr__info;

		// Token: 0x04002370 RID: 9072
		private static readonly IntPtr NativeFieldInfoPtr_invalidWindows;

		// Token: 0x04002371 RID: 9073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_String_WindowsAccountType_Boolean_0;

		// Token: 0x04002372 RID: 9074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002373 RID: 9075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ClaimsIdentity_IntPtr_0;

		// Token: 0x04002374 RID: 9076
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002375 RID: 9077
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrent_Public_Static_WindowsIdentity_0;

		// Token: 0x04002376 RID: 9078
		private static readonly IntPtr NativeMethodInfoPtr_Impersonate_Public_Virtual_New_WindowsImpersonationContext_0;

		// Token: 0x04002377 RID: 9079
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Virtual_Final_get_String_0;

		// Token: 0x04002378 RID: 9080
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04002379 RID: 9081
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400237A RID: 9082
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400237B RID: 9083
		private static readonly IntPtr NativeMethodInfoPtr_CloneAsBase_Internal_ClaimsIdentity_0;

		// Token: 0x0400237C RID: 9084
		private static readonly IntPtr NativeMethodInfoPtr_GetTokenInternal_Internal_IntPtr_0;

		// Token: 0x0400237D RID: 9085
		private static readonly IntPtr NativeMethodInfoPtr_SetToken_Private_Void_IntPtr_0;

		// Token: 0x0400237E RID: 9086
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentToken_Internal_Static_IntPtr_0;

		// Token: 0x0400237F RID: 9087
		private static readonly IntPtr NativeMethodInfoPtr_GetTokenName_Private_Static_String_IntPtr_0;
	}
}
