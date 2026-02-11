using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public sealed class LocalizationAsset : Object
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public static void Internal_CreateInstance(LocalizationAsset locAsset)
		{
			LocalizationAsset.Internal_CreateInstanceDelegateField(IL2CPP.Il2CppObjectBaseToPtr(locAsset));
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002062 File Offset: 0x00000262
		public void SetLocalizedString(string original, string localized)
		{
			LocalizationAsset.SetLocalizedStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(original), IL2CPP.ManagedStringToIl2Cpp(localized));
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002138 File Offset: 0x00000338
		public string GetLocalizedString(string original)
		{
			IntPtr intPtr = LocalizationAsset.GetLocalizedStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(original));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002164 File Offset: 0x00000364
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002080 File Offset: 0x00000280
		public string localeIsoCode
		{
			get
			{
				IntPtr intPtr = LocalizationAsset.get_localeIsoCodeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				LocalizationAsset.set_localeIsoCodeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000020AA File Offset: 0x000002AA
		public bool isEditorAsset
		{
			get
			{
				return LocalizationAsset.get_isEditorAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LocalizationAsset.set_isEditorAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly LocalizationAsset.Internal_CreateInstanceDelegate Internal_CreateInstanceDelegateField = IL2CPP.ResolveICall<LocalizationAsset.Internal_CreateInstanceDelegate>("UnityEngine.LocalizationAsset::Internal_CreateInstance");

		// Token: 0x04000002 RID: 2
		private static readonly LocalizationAsset.SetLocalizedStringDelegate SetLocalizedStringDelegateField = IL2CPP.ResolveICall<LocalizationAsset.SetLocalizedStringDelegate>("UnityEngine.LocalizationAsset::SetLocalizedString");

		// Token: 0x04000003 RID: 3
		private static readonly LocalizationAsset.GetLocalizedStringDelegate GetLocalizedStringDelegateField = IL2CPP.ResolveICall<LocalizationAsset.GetLocalizedStringDelegate>("UnityEngine.LocalizationAsset::GetLocalizedString");

		// Token: 0x04000004 RID: 4
		private static readonly LocalizationAsset.get_localeIsoCodeDelegate get_localeIsoCodeDelegateField = IL2CPP.ResolveICall<LocalizationAsset.get_localeIsoCodeDelegate>("UnityEngine.LocalizationAsset::get_localeIsoCode");

		// Token: 0x04000005 RID: 5
		private static readonly LocalizationAsset.set_localeIsoCodeDelegate set_localeIsoCodeDelegateField = IL2CPP.ResolveICall<LocalizationAsset.set_localeIsoCodeDelegate>("UnityEngine.LocalizationAsset::set_localeIsoCode");

		// Token: 0x04000006 RID: 6
		private static readonly LocalizationAsset.get_isEditorAssetDelegate get_isEditorAssetDelegateField = IL2CPP.ResolveICall<LocalizationAsset.get_isEditorAssetDelegate>("UnityEngine.LocalizationAsset::get_isEditorAsset");

		// Token: 0x04000007 RID: 7
		private static readonly LocalizationAsset.set_isEditorAssetDelegate set_isEditorAssetDelegateField = IL2CPP.ResolveICall<LocalizationAsset.set_isEditorAssetDelegate>("UnityEngine.LocalizationAsset::set_isEditorAsset");

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x0600000A RID: 10
		private delegate void Internal_CreateInstanceDelegate(IntPtr locAsset);

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600000C RID: 12
		private delegate void SetLocalizedStringDelegate(IntPtr @this, IntPtr original, IntPtr localized);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600000E RID: 14
		private delegate IntPtr GetLocalizedStringDelegate(IntPtr @this, IntPtr original);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000010 RID: 16
		private delegate IntPtr get_localeIsoCodeDelegate(IntPtr @this);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000012 RID: 18
		private delegate void set_localeIsoCodeDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000014 RID: 20
		private delegate bool get_isEditorAssetDelegate(IntPtr @this);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000016 RID: 22
		private delegate void set_isEditorAssetDelegate(IntPtr @this, bool value);
	}
}
