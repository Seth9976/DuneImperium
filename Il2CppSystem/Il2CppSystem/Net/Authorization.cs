using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001A8 RID: 424
	public class Authorization : Object
	{
		// Token: 0x06001A96 RID: 6806 RVA: 0x000848FC File Offset: 0x00082AFC
		// Note: this type is marked as 'beforefieldinit'.
		static Authorization()
		{
			Il2CppClassPointerStore<Authorization>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Authorization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Authorization>.NativeClassPtr);
			Authorization.NativeFieldInfoPtr_m_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Authorization>.NativeClassPtr, "m_Message");
			Authorization.NativeFieldInfoPtr_m_Complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Authorization>.NativeClassPtr, "m_Complete");
			Authorization.NativeFieldInfoPtr_ModuleAuthenticationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Authorization>.NativeClassPtr, "ModuleAuthenticationType");
			Authorization.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authorization>.NativeClassPtr, 100667439);
			Authorization.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authorization>.NativeClassPtr, 100667440);
			Authorization.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authorization>.NativeClassPtr, 100667441);
			Authorization.NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authorization>.NativeClassPtr, 100667442);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x000849B8 File Offset: 0x00082BB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 474025, RefRangeEnd = 474027, XrefRangeStart = 474019, XrefRangeEnd = 474025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authorization(string token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Authorization>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authorization.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00084A04 File Offset: 0x00082C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474027, XrefRangeEnd = 474033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authorization(string token, bool finished)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Authorization>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finished;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authorization.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x00084A60 File Offset: 0x00082C60
		public unsafe string Message
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authorization.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x00084A98 File Offset: 0x00082C98
		public unsafe bool Complete
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authorization.NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x0000B636 File Offset: 0x00009836
		public Authorization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x00084AD4 File Offset: 0x00082CD4
		// (set) Token: 0x06001A9D RID: 6813 RVA: 0x0000B63F File Offset: 0x0000983F
		public unsafe string m_Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_m_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_m_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x00084AFC File Offset: 0x00082CFC
		// (set) Token: 0x06001A9F RID: 6815 RVA: 0x0000B65E File Offset: 0x0000985E
		public unsafe bool m_Complete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_m_Complete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_m_Complete)) = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x00084B24 File Offset: 0x00082D24
		// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x0000B679 File Offset: 0x00009879
		public unsafe string ModuleAuthenticationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_ModuleAuthenticationType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Authorization.NativeFieldInfoPtr_ModuleAuthenticationType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeFieldInfoPtr_m_Message;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeFieldInfoPtr_m_Complete;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeFieldInfoPtr_ModuleAuthenticationType;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0;
	}
}
