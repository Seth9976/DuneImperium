using System;
using boardgames.account;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.account;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace boardgames.menus.ui
{
	// Token: 0x020001B0 RID: 432
	public class LoggedInUserLabel : VersionedView<IAttribute<string>>
	{
		// Token: 0x06001366 RID: 4966 RVA: 0x0005C688 File Offset: 0x0005A888
		// Note: this type is marked as 'beforefieldinit'.
		static LoggedInUserLabel()
		{
			Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.ui", "LoggedInUserLabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr);
			LoggedInUserLabel.NativeFieldInfoPtr_usernameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr, "usernameObject");
			LoggedInUserLabel.NativeFieldInfoPtr_usernameField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr, "usernameField");
			LoggedInUserLabel.NativeFieldInfoPtr_loggedInAsLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr, "loggedInAsLoc");
			LoggedInUserLabel.NativeFieldInfoPtr_dataNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr, "dataNamespace");
			LoggedInUserLabel.NativeFieldInfoPtr__cachedAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr, "_cachedAccountID");
			LoggedInUserLabel.NativeFieldInfoPtr__accountProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr, "_accountProvider");
			LoggedInUserLabel.NativeFieldInfoPtr__userDataProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr, "_userDataProvider");
			LoggedInUserLabel.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr, 100666173);
			LoggedInUserLabel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr, 100666174);
			LoggedInUserLabel.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr, 100666175);
			LoggedInUserLabel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr, 100666176);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0005C794 File Offset: 0x0005A994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519376, XrefRangeEnd = 519398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoggedInUserLabel.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0005C7D0 File Offset: 0x0005A9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519398, XrefRangeEnd = 519408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggedInUserLabel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0005C804 File Offset: 0x0005AA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519408, XrefRangeEnd = 519424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoggedInUserLabel.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0005C840 File Offset: 0x0005AA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519424, XrefRangeEnd = 519431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggedInUserLabel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggedInUserLabel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggedInUserLabel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0000B178 File Offset: 0x00009378
		public LoggedInUserLabel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0005C87C File Offset: 0x0005AA7C
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x0000B181 File Offset: 0x00009381
		public unsafe GameObject usernameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr_usernameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr_usernameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x0005C8AC File Offset: 0x0005AAAC
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x0000B1A0 File Offset: 0x000093A0
		public unsafe TMP_Text usernameField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr_usernameField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr_usernameField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x0005C8DC File Offset: 0x0005AADC
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x0000B1BF File Offset: 0x000093BF
		public unsafe string loggedInAsLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr_loggedInAsLoc);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr_loggedInAsLoc), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x0005C904 File Offset: 0x0005AB04
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x0000B1DE File Offset: 0x000093DE
		public unsafe UserDataNamespace dataNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr_dataNamespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr_dataNamespace)) = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x0005C92C File Offset: 0x0005AB2C
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x0000B1F9 File Offset: 0x000093F9
		public unsafe AccountID _cachedAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr__cachedAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr__cachedAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x0005C95C File Offset: 0x0005AB5C
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x0000B218 File Offset: 0x00009418
		public unsafe AccountProvider _accountProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr__accountProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr__accountProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x0005C98C File Offset: 0x0005AB8C
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x0000B237 File Offset: 0x00009437
		public unsafe NamespaceUserDataProvider _userDataProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr__userDataProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamespaceUserDataProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggedInUserLabel.NativeFieldInfoPtr__userDataProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeFieldInfoPtr_usernameObject;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeFieldInfoPtr_usernameField;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeFieldInfoPtr_loggedInAsLoc;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeFieldInfoPtr_dataNamespace;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeFieldInfoPtr__cachedAccountID;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeFieldInfoPtr__accountProvider;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeFieldInfoPtr__userDataProvider;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
