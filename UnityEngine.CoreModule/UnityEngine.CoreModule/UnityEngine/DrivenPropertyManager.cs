using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020002FA RID: 762
	public class DrivenPropertyManager
	{
		// Token: 0x06002D97 RID: 11671 RVA: 0x0001222E File Offset: 0x0001042E
		public static void RegisterProperty(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.RegisterPropertyPartial(driver, target, propertyPath);
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x0001223A File Offset: 0x0001043A
		public static void TryRegisterProperty(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.TryRegisterPropertyPartial(driver, target, propertyPath);
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x00012246 File Offset: 0x00010446
		public static void UnregisterProperty(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.UnregisterPropertyPartial(driver, target, propertyPath);
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x00012252 File Offset: 0x00010452
		public static void UnregisterProperties(Object driver)
		{
			DrivenPropertyManager.UnregisterPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver));
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x00012264 File Offset: 0x00010464
		public static void RegisterPropertyPartial(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.RegisterPropertyPartialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver), IL2CPP.Il2CppObjectBaseToPtr(target), IL2CPP.ManagedStringToIl2Cpp(propertyPath));
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x00012282 File Offset: 0x00010482
		public static void TryRegisterPropertyPartial(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.TryRegisterPropertyPartialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver), IL2CPP.Il2CppObjectBaseToPtr(target), IL2CPP.ManagedStringToIl2Cpp(propertyPath));
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x000122A0 File Offset: 0x000104A0
		public static void UnregisterPropertyPartial(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.UnregisterPropertyPartialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver), IL2CPP.Il2CppObjectBaseToPtr(target), IL2CPP.ManagedStringToIl2Cpp(propertyPath));
		}

		// Token: 0x0400292D RID: 10541
		private static readonly DrivenPropertyManager.UnregisterPropertiesDelegate UnregisterPropertiesDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.UnregisterPropertiesDelegate>("UnityEngine.DrivenPropertyManager::UnregisterProperties");

		// Token: 0x0400292E RID: 10542
		private static readonly DrivenPropertyManager.RegisterPropertyPartialDelegate RegisterPropertyPartialDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.RegisterPropertyPartialDelegate>("UnityEngine.DrivenPropertyManager::RegisterPropertyPartial");

		// Token: 0x0400292F RID: 10543
		private static readonly DrivenPropertyManager.TryRegisterPropertyPartialDelegate TryRegisterPropertyPartialDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.TryRegisterPropertyPartialDelegate>("UnityEngine.DrivenPropertyManager::TryRegisterPropertyPartial");

		// Token: 0x04002930 RID: 10544
		private static readonly DrivenPropertyManager.UnregisterPropertyPartialDelegate UnregisterPropertyPartialDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.UnregisterPropertyPartialDelegate>("UnityEngine.DrivenPropertyManager::UnregisterPropertyPartial");

		// Token: 0x02000B5E RID: 2910
		// (Invoke) Token: 0x06003FB1 RID: 16305
		private delegate void UnregisterPropertiesDelegate(IntPtr driver);

		// Token: 0x02000B5F RID: 2911
		// (Invoke) Token: 0x06003FB3 RID: 16307
		private delegate void RegisterPropertyPartialDelegate(IntPtr driver, IntPtr target, IntPtr propertyPath);

		// Token: 0x02000B60 RID: 2912
		// (Invoke) Token: 0x06003FB5 RID: 16309
		private delegate void TryRegisterPropertyPartialDelegate(IntPtr driver, IntPtr target, IntPtr propertyPath);

		// Token: 0x02000B61 RID: 2913
		// (Invoke) Token: 0x06003FB7 RID: 16311
		private delegate void UnregisterPropertyPartialDelegate(IntPtr driver, IntPtr target, IntPtr propertyPath);
	}
}
