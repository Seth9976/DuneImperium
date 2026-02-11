using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020002BF RID: 703
	public class IContextProperty : Il2CppObjectBase
	{
		// Token: 0x06002CD3 RID: 11475 RVA: 0x000EA8FC File Offset: 0x000E8AFC
		// Note: this type is marked as 'beforefieldinit'.
		static IContextProperty()
		{
			Il2CppClassPointerStore<IContextProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContextProperty");
			IContextProperty.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextProperty>.NativeClassPtr, 100670516);
			IContextProperty.NativeMethodInfoPtr_Freeze_Public_Abstract_Virtual_New_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextProperty>.NativeClassPtr, 100670517);
			IContextProperty.NativeMethodInfoPtr_IsNewContextOK_Public_Abstract_Virtual_New_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextProperty>.NativeClassPtr, 100670518);
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x000EA960 File Offset: 0x000E8B60
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextProperty.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x000EA9A4 File Offset: 0x000E8BA4
		[CallerCount(0)]
		public unsafe virtual void Freeze(Context newContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextProperty.NativeMethodInfoPtr_Freeze_Public_Abstract_Virtual_New_Void_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x000EA9F4 File Offset: 0x000E8BF4
		[CallerCount(0)]
		public unsafe virtual bool IsNewContextOK(Context newCtx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newCtx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextProperty.NativeMethodInfoPtr_IsNewContextOK_Public_Abstract_Virtual_New_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x0000EFCF File Offset: 0x0000D1CF
		public IContextProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025BE RID: 9662
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040025BF RID: 9663
		private static readonly IntPtr NativeMethodInfoPtr_Freeze_Public_Abstract_Virtual_New_Void_Context_0;

		// Token: 0x040025C0 RID: 9664
		private static readonly IntPtr NativeMethodInfoPtr_IsNewContextOK_Public_Abstract_Virtual_New_Boolean_Context_0;
	}
}
