using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ImaginationOverflow.UniversalDeepLinking
{
	// Token: 0x0200000F RID: 15
	public class LinkProviderBase : Object
	{
		// Token: 0x060000AD RID: 173 RVA: 0x000050E4 File Offset: 0x000032E4
		// Note: this type is marked as 'beforefieldinit'.
		static LinkProviderBase()
		{
			Il2CppClassPointerStore<LinkProviderBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking", "LinkProviderBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkProviderBase>.NativeClassPtr);
			LinkProviderBase.NativeFieldInfoPtr__IsConnectedToUnity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkProviderBase>.NativeClassPtr, "<IsConnectedToUnity>k__BackingField");
			LinkProviderBase.NativeMethodInfoPtr_get_IsConnectedToUnity_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkProviderBase>.NativeClassPtr, 100663423);
			LinkProviderBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkProviderBase>.NativeClassPtr, 100663424);
			LinkProviderBase.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkProviderBase>.NativeClassPtr, 100663425);
			LinkProviderBase.NativeMethodInfoPtr_add_LinkReceived_Public_Abstract_Virtual_New_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkProviderBase>.NativeClassPtr, 100663426);
			LinkProviderBase.NativeMethodInfoPtr_remove_LinkReceived_Public_Abstract_Virtual_New_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkProviderBase>.NativeClassPtr, 100663427);
			LinkProviderBase.NativeMethodInfoPtr_PollInfoAfterPause_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkProviderBase>.NativeClassPtr, 100663428);
			LinkProviderBase.NativeMethodInfoPtr_OnLinkReceived_Protected_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkProviderBase>.NativeClassPtr, 100663429);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000051B4 File Offset: 0x000033B4
		public unsafe bool IsConnectedToUnity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkProviderBase.NativeMethodInfoPtr_get_IsConnectedToUnity_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000051F0 File Offset: 0x000033F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240869, XrefRangeEnd = 1240899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkProviderBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkProviderBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkProviderBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000522C File Offset: 0x0000342C
		[CallerCount(0)]
		public unsafe virtual bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LinkProviderBase.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005274 File Offset: 0x00003474
		[CallerCount(0)]
		public unsafe virtual void add_LinkReceived(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LinkProviderBase.NativeMethodInfoPtr_add_LinkReceived_Public_Abstract_Virtual_New_add_Void_Action_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000052C4 File Offset: 0x000034C4
		[CallerCount(0)]
		public unsafe virtual void remove_LinkReceived(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LinkProviderBase.NativeMethodInfoPtr_remove_LinkReceived_Public_Abstract_Virtual_New_rem_Void_Action_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005314 File Offset: 0x00003514
		[CallerCount(0)]
		public unsafe virtual void PollInfoAfterPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LinkProviderBase.NativeMethodInfoPtr_PollInfoAfterPause_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00005350 File Offset: 0x00003550
		[CallerCount(0)]
		public unsafe virtual void OnLinkReceived(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LinkProviderBase.NativeMethodInfoPtr_OnLinkReceived_Protected_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002413 File Offset: 0x00000613
		public LinkProviderBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000053A0 File Offset: 0x000035A0
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000241C File Offset: 0x0000061C
		public unsafe bool _IsConnectedToUnity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkProviderBase.NativeFieldInfoPtr__IsConnectedToUnity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkProviderBase.NativeFieldInfoPtr__IsConnectedToUnity_k__BackingField)) = value;
			}
		}

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr__IsConnectedToUnity_k__BackingField;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConnectedToUnity_Protected_get_Boolean_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_add_LinkReceived_Public_Abstract_Virtual_New_add_Void_Action_1_String_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_remove_LinkReceived_Public_Abstract_Virtual_New_rem_Void_Action_1_String_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_PollInfoAfterPause_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_OnLinkReceived_Protected_Abstract_Virtual_New_Void_String_0;
	}
}
