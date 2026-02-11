using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Platform.iOS
{
	// Token: 0x020000AE RID: 174
	[Serializable]
	public class AppInfo : Object
	{
		// Token: 0x0600089F RID: 2207 RVA: 0x0002A740 File Offset: 0x00028940
		// Note: this type is marked as 'beforefieldinit'.
		static AppInfo()
		{
			Il2CppClassPointerStore<AppInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Platform.iOS", "AppInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppInfo>.NativeClassPtr);
			AppInfo.NativeFieldInfoPtr_m_ShortName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, "m_ShortName");
			AppInfo.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, "m_DisplayName");
			AppInfo.NativeFieldInfoPtr_m_CameraUsageDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, "m_CameraUsageDescription");
			AppInfo.NativeFieldInfoPtr_m_MicrophoneUsageDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, "m_MicrophoneUsageDescription");
			AppInfo.NativeFieldInfoPtr_m_LocationUsageDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, "m_LocationUsageDescription");
			AppInfo.NativeFieldInfoPtr_m_UserTrackingUsageDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, "m_UserTrackingUsageDescription");
			AppInfo.NativeMethodInfoPtr_get_ShortName_Public_get_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664828);
			AppInfo.NativeMethodInfoPtr_set_ShortName_Public_set_Void_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664829);
			AppInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664830);
			AppInfo.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664831);
			AppInfo.NativeMethodInfoPtr_get_CameraUsageDescription_Public_get_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664832);
			AppInfo.NativeMethodInfoPtr_set_CameraUsageDescription_Public_set_Void_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664833);
			AppInfo.NativeMethodInfoPtr_get_MicrophoneUsageDescription_Public_get_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664834);
			AppInfo.NativeMethodInfoPtr_set_MicrophoneUsageDescription_Public_set_Void_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664835);
			AppInfo.NativeMethodInfoPtr_get_LocationUsageDescription_Public_get_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664836);
			AppInfo.NativeMethodInfoPtr_set_LocationUsageDescription_Public_set_Void_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664837);
			AppInfo.NativeMethodInfoPtr_get_UserTrackingUsageDescription_Public_get_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664838);
			AppInfo.NativeMethodInfoPtr_set_UserTrackingUsageDescription_Public_set_Void_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664839);
			AppInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppInfo>.NativeClassPtr, 100664840);
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0002A8EC File Offset: 0x00028AEC
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x0002A92C File Offset: 0x00028B2C
		public unsafe LocalizedString ShortName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_get_ShortName_Public_get_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_set_ShortName_Public_set_Void_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x0002A970 File Offset: 0x00028B70
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x0002A9B0 File Offset: 0x00028BB0
		public unsafe LocalizedString DisplayName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0002A9F4 File Offset: 0x00028BF4
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x0002AA34 File Offset: 0x00028C34
		public unsafe LocalizedString CameraUsageDescription
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_get_CameraUsageDescription_Public_get_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_set_CameraUsageDescription_Public_set_Void_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0002AA78 File Offset: 0x00028C78
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x0002AAB8 File Offset: 0x00028CB8
		public unsafe LocalizedString MicrophoneUsageDescription
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_get_MicrophoneUsageDescription_Public_get_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_set_MicrophoneUsageDescription_Public_set_Void_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0002AAFC File Offset: 0x00028CFC
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x0002AB3C File Offset: 0x00028D3C
		public unsafe LocalizedString LocationUsageDescription
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_get_LocationUsageDescription_Public_get_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_set_LocationUsageDescription_Public_set_Void_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0002AB80 File Offset: 0x00028D80
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x0002ABC0 File Offset: 0x00028DC0
		public unsafe LocalizedString UserTrackingUsageDescription
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_get_UserTrackingUsageDescription_Public_get_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr_set_UserTrackingUsageDescription_Public_set_Void_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0002AC04 File Offset: 0x00028E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1076981, XrefRangeEnd = 1077007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00005462 File Offset: 0x00003662
		public AppInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0002AC40 File Offset: 0x00028E40
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x0000546B File Offset: 0x0000366B
		public unsafe LocalizedString m_ShortName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_ShortName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_ShortName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0002AC70 File Offset: 0x00028E70
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x0000548A File Offset: 0x0000368A
		public unsafe LocalizedString m_DisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_DisplayName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_DisplayName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0002ACA0 File Offset: 0x00028EA0
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x000054A9 File Offset: 0x000036A9
		public unsafe LocalizedString m_CameraUsageDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_CameraUsageDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_CameraUsageDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0002ACD0 File Offset: 0x00028ED0
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x000054C8 File Offset: 0x000036C8
		public unsafe LocalizedString m_MicrophoneUsageDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_MicrophoneUsageDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_MicrophoneUsageDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0002AD00 File Offset: 0x00028F00
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x000054E7 File Offset: 0x000036E7
		public unsafe LocalizedString m_LocationUsageDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_LocationUsageDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_LocationUsageDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0002AD30 File Offset: 0x00028F30
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00005506 File Offset: 0x00003706
		public unsafe LocalizedString m_UserTrackingUsageDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_UserTrackingUsageDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppInfo.NativeFieldInfoPtr_m_UserTrackingUsageDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeFieldInfoPtr_m_ShortName;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayName;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraUsageDescription;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeFieldInfoPtr_m_MicrophoneUsageDescription;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeFieldInfoPtr_m_LocationUsageDescription;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeFieldInfoPtr_m_UserTrackingUsageDescription;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_get_ShortName_Public_get_LocalizedString_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_set_ShortName_Public_set_Void_LocalizedString_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_LocalizedString_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayName_Public_set_Void_LocalizedString_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraUsageDescription_Public_get_LocalizedString_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_set_CameraUsageDescription_Public_set_Void_LocalizedString_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_get_MicrophoneUsageDescription_Public_get_LocalizedString_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_set_MicrophoneUsageDescription_Public_set_Void_LocalizedString_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_get_LocationUsageDescription_Public_get_LocalizedString_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_set_LocationUsageDescription_Public_set_Void_LocalizedString_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_get_UserTrackingUsageDescription_Public_get_LocalizedString_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_set_UserTrackingUsageDescription_Public_set_Void_LocalizedString_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
