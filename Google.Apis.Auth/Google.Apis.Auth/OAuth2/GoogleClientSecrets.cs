using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x0200000E RID: 14
	public sealed class GoogleClientSecrets : Object
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000903C File Offset: 0x0000723C
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleClientSecrets()
		{
			Il2CppClassPointerStore<GoogleClientSecrets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "GoogleClientSecrets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleClientSecrets>.NativeClassPtr);
			GoogleClientSecrets.NativeFieldInfoPtr__Installed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleClientSecrets>.NativeClassPtr, "<Installed>k__BackingField");
			GoogleClientSecrets.NativeFieldInfoPtr__Web_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleClientSecrets>.NativeClassPtr, "<Web>k__BackingField");
			GoogleClientSecrets.NativeMethodInfoPtr_get_Installed_Private_get_ClientSecrets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleClientSecrets>.NativeClassPtr, 100663457);
			GoogleClientSecrets.NativeMethodInfoPtr_set_Installed_Private_set_Void_ClientSecrets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleClientSecrets>.NativeClassPtr, 100663458);
			GoogleClientSecrets.NativeMethodInfoPtr_get_Web_Private_get_ClientSecrets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleClientSecrets>.NativeClassPtr, 100663459);
			GoogleClientSecrets.NativeMethodInfoPtr_set_Web_Private_set_Void_ClientSecrets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleClientSecrets>.NativeClassPtr, 100663460);
			GoogleClientSecrets.NativeMethodInfoPtr_get_Secrets_Public_get_ClientSecrets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleClientSecrets>.NativeClassPtr, 100663461);
			GoogleClientSecrets.NativeMethodInfoPtr_Load_Public_Static_GoogleClientSecrets_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleClientSecrets>.NativeClassPtr, 100663462);
			GoogleClientSecrets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleClientSecrets>.NativeClassPtr, 100663463);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00009120 File Offset: 0x00007320
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00009160 File Offset: 0x00007360
		public unsafe ClientSecrets Installed
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleClientSecrets.NativeMethodInfoPtr_get_Installed_Private_get_ClientSecrets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientSecrets>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleClientSecrets.NativeMethodInfoPtr_set_Installed_Private_set_Void_ClientSecrets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000091A4 File Offset: 0x000073A4
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000091E4 File Offset: 0x000073E4
		public unsafe ClientSecrets Web
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleClientSecrets.NativeMethodInfoPtr_get_Web_Private_get_ClientSecrets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientSecrets>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleClientSecrets.NativeMethodInfoPtr_set_Web_Private_set_Void_ClientSecrets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00009228 File Offset: 0x00007428
		public unsafe ClientSecrets Secrets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleClientSecrets.NativeMethodInfoPtr_get_Secrets_Public_get_ClientSecrets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientSecrets>(intPtr3) : null;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00009268 File Offset: 0x00007468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153553, XrefRangeEnd = 1153564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GoogleClientSecrets Load(Stream stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleClientSecrets.NativeMethodInfoPtr_Load_Public_Static_GoogleClientSecrets_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleClientSecrets>(intPtr3) : null;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000092AC File Offset: 0x000074AC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleClientSecrets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleClientSecrets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleClientSecrets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000024E9 File Offset: 0x000006E9
		public GoogleClientSecrets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000092E8 File Offset: 0x000074E8
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000024F2 File Offset: 0x000006F2
		public unsafe ClientSecrets _Installed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleClientSecrets.NativeFieldInfoPtr__Installed_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientSecrets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleClientSecrets.NativeFieldInfoPtr__Installed_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00009318 File Offset: 0x00007518
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002511 File Offset: 0x00000711
		public unsafe ClientSecrets _Web_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleClientSecrets.NativeFieldInfoPtr__Web_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientSecrets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleClientSecrets.NativeFieldInfoPtr__Web_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr__Installed_k__BackingField;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr__Web_k__BackingField;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_Installed_Private_get_ClientSecrets_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_set_Installed_Private_set_Void_ClientSecrets_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_Web_Private_get_ClientSecrets_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_set_Web_Private_set_Void_ClientSecrets_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_Secrets_Public_get_ClientSecrets_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_GoogleClientSecrets_Stream_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
