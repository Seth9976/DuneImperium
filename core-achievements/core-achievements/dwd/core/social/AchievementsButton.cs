using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.social
{
	// Token: 0x02000006 RID: 6
	public class AchievementsButton : MonoBehaviour
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000026AC File Offset: 0x000008AC
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementsButton()
		{
			Il2CppClassPointerStore<AchievementsButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-achievements.dll", "dwd.core.social", "AchievementsButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementsButton>.NativeClassPtr);
			AchievementsButton.NativeFieldInfoPtr_platforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsButton>.NativeClassPtr, "platforms");
			AchievementsButton.NativeFieldInfoPtr_enabledObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsButton>.NativeClassPtr, "enabledObject");
			AchievementsButton.NativeFieldInfoPtr_unitySocialProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsButton>.NativeClassPtr, "unitySocialProvider");
			AchievementsButton.NativeFieldInfoPtr_socialFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsButton>.NativeClassPtr, "socialFound");
			AchievementsButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsButton>.NativeClassPtr, 100663303);
			AchievementsButton.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsButton>.NativeClassPtr, 100663304);
			AchievementsButton.NativeMethodInfoPtr_checkForSocial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsButton>.NativeClassPtr, 100663305);
			AchievementsButton.NativeMethodInfoPtr_Event_ViewAchievements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsButton>.NativeClassPtr, 100663306);
			AchievementsButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsButton>.NativeClassPtr, 100663307);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002790 File Offset: 0x00000990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273122, XrefRangeEnd = 1273127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementsButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000027C4 File Offset: 0x000009C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273127, XrefRangeEnd = 1273128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementsButton.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000027F8 File Offset: 0x000009F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1273145, RefRangeEnd = 1273147, XrefRangeStart = 1273128, XrefRangeEnd = 1273145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void checkForSocial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementsButton.NativeMethodInfoPtr_checkForSocial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000282C File Offset: 0x00000A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273147, XrefRangeEnd = 1273152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ViewAchievements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementsButton.NativeMethodInfoPtr_Event_ViewAchievements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002860 File Offset: 0x00000A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273152, XrefRangeEnd = 1273160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementsButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementsButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementsButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020E7 File Offset: 0x000002E7
		public AchievementsButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000289C File Offset: 0x00000A9C
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe List<RuntimePlatform> platforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementsButton.NativeFieldInfoPtr_platforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RuntimePlatform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementsButton.NativeFieldInfoPtr_platforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000028CC File Offset: 0x00000ACC
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000210F File Offset: 0x0000030F
		public unsafe GameObject enabledObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementsButton.NativeFieldInfoPtr_enabledObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementsButton.NativeFieldInfoPtr_enabledObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000028FC File Offset: 0x00000AFC
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000212E File Offset: 0x0000032E
		public unsafe UnitySocialProvider unitySocialProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementsButton.NativeFieldInfoPtr_unitySocialProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitySocialProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementsButton.NativeFieldInfoPtr_unitySocialProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000292C File Offset: 0x00000B2C
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000214D File Offset: 0x0000034D
		public unsafe bool socialFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementsButton.NativeFieldInfoPtr_socialFound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementsButton.NativeFieldInfoPtr_socialFound)) = value;
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_platforms;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_enabledObject;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_unitySocialProvider;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_socialFound;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_checkForSocial_Private_Void_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_Event_ViewAchievements_Public_Void_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
