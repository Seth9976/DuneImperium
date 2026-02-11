using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Google.Apis.Discovery
{
	// Token: 0x0200003D RID: 61
	public class IParameter : Il2CppObjectBase
	{
		// Token: 0x06000296 RID: 662 RVA: 0x0000D728 File Offset: 0x0000B928
		// Note: this type is marked as 'beforefieldinit'.
		static IParameter()
		{
			Il2CppClassPointerStore<IParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Discovery", "IParameter");
			IParameter.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IParameter>.NativeClassPtr, 100663707);
			IParameter.NativeMethodInfoPtr_get_Pattern_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IParameter>.NativeClassPtr, 100663708);
			IParameter.NativeMethodInfoPtr_get_IsRequired_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IParameter>.NativeClassPtr, 100663709);
			IParameter.NativeMethodInfoPtr_get_DefaultValue_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IParameter>.NativeClassPtr, 100663710);
			IParameter.NativeMethodInfoPtr_get_ParameterType_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IParameter>.NativeClassPtr, 100663711);
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IParameter.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000D7F8 File Offset: 0x0000B9F8
		public unsafe virtual string Pattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IParameter.NativeMethodInfoPtr_get_Pattern_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000D83C File Offset: 0x0000BA3C
		public unsafe virtual bool IsRequired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IParameter.NativeMethodInfoPtr_get_IsRequired_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000D884 File Offset: 0x0000BA84
		public unsafe virtual string DefaultValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IParameter.NativeMethodInfoPtr_get_DefaultValue_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0000D8C8 File Offset: 0x0000BAC8
		public unsafe virtual string ParameterType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IParameter.NativeMethodInfoPtr_get_ParameterType_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00003102 File Offset: 0x00001302
		public IParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_get_Pattern_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRequired_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterType_Public_Abstract_Virtual_New_get_String_0;
	}
}
