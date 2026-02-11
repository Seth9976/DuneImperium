using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace analytics
{
	// Token: 0x0200000A RID: 10
	public class IAnalyticsManager : Il2CppObjectBase
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002D50 File Offset: 0x00000F50
		// Note: this type is marked as 'beforefieldinit'.
		static IAnalyticsManager()
		{
			Il2CppClassPointerStore<IAnalyticsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("analytics.dll", "analytics", "IAnalyticsManager");
			IAnalyticsManager.NativeMethodInfoPtr_logAnalyticsMessage_Public_Abstract_Virtual_New_Void_IAnalyticsMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnalyticsManager>.NativeClassPtr, 100663324);
			IAnalyticsManager.NativeMethodInfoPtr_Enabled_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnalyticsManager>.NativeClassPtr, 100663325);
			IAnalyticsManager.NativeMethodInfoPtr_URL_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnalyticsManager>.NativeClassPtr, 100663326);
			IAnalyticsManager.NativeMethodInfoPtr_game_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnalyticsManager>.NativeClassPtr, 100663327);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002DC8 File Offset: 0x00000FC8
		[CallerCount(0)]
		public unsafe virtual void logAnalyticsMessage(IAnalyticsMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAnalyticsManager.NativeMethodInfoPtr_logAnalyticsMessage_Public_Abstract_Virtual_New_Void_IAnalyticsMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002E18 File Offset: 0x00001018
		[CallerCount(0)]
		public unsafe virtual bool Enabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAnalyticsManager.NativeMethodInfoPtr_Enabled_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002E60 File Offset: 0x00001060
		[CallerCount(0)]
		public unsafe virtual string URL()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAnalyticsManager.NativeMethodInfoPtr_URL_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002EA4 File Offset: 0x000010A4
		[CallerCount(0)]
		public unsafe virtual string game()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAnalyticsManager.NativeMethodInfoPtr_game_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000215B File Offset: 0x0000035B
		public IAnalyticsManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_logAnalyticsMessage_Public_Abstract_Virtual_New_Void_IAnalyticsMessage_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_Enabled_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_URL_Public_Abstract_Virtual_New_String_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_game_Public_Abstract_Virtual_New_String_0;
	}
}
