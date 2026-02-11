using System;
using dwd.core.settings;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001BA RID: 442
	public class NewContentAlertBehaviour : MonoBehaviour
	{
		// Token: 0x060013EA RID: 5098 RVA: 0x0005DFF8 File Offset: 0x0005C1F8
		// Note: this type is marked as 'beforefieldinit'.
		static NewContentAlertBehaviour()
		{
			Il2CppClassPointerStore<NewContentAlertBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "NewContentAlertBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewContentAlertBehaviour>.NativeClassPtr);
			NewContentAlertBehaviour.NativeFieldInfoPtr_Enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewContentAlertBehaviour>.NativeClassPtr, "Enable");
			NewContentAlertBehaviour.NativeFieldInfoPtr_contentVersionPrefName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewContentAlertBehaviour>.NativeClassPtr, "contentVersionPrefName");
			NewContentAlertBehaviour.NativeFieldInfoPtr_contentVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewContentAlertBehaviour>.NativeClassPtr, "contentVersion");
			NewContentAlertBehaviour.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewContentAlertBehaviour>.NativeClassPtr, "animator");
			NewContentAlertBehaviour.NativeFieldInfoPtr_contentVersionPref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewContentAlertBehaviour>.NativeClassPtr, "contentVersionPref");
			NewContentAlertBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewContentAlertBehaviour>.NativeClassPtr, 100666228);
			NewContentAlertBehaviour.NativeMethodInfoPtr_Event_OnContentInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewContentAlertBehaviour>.NativeClassPtr, 100666229);
			NewContentAlertBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewContentAlertBehaviour>.NativeClassPtr, 100666230);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0005E0C8 File Offset: 0x0005C2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519851, XrefRangeEnd = 519873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewContentAlertBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0005E0FC File Offset: 0x0005C2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519873, XrefRangeEnd = 519879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnContentInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewContentAlertBehaviour.NativeMethodInfoPtr_Event_OnContentInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0005E130 File Offset: 0x0005C330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519879, XrefRangeEnd = 519883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewContentAlertBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewContentAlertBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewContentAlertBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0000B5A6 File Offset: 0x000097A6
		public NewContentAlertBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x0005E16C File Offset: 0x0005C36C
		// (set) Token: 0x060013F0 RID: 5104 RVA: 0x0000B5AF File Offset: 0x000097AF
		public unsafe static int Enable
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NewContentAlertBehaviour.NativeFieldInfoPtr_Enable, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NewContentAlertBehaviour.NativeFieldInfoPtr_Enable, (void*)(&value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0005E188 File Offset: 0x0005C388
		// (set) Token: 0x060013F2 RID: 5106 RVA: 0x0000B5BD File Offset: 0x000097BD
		public unsafe string contentVersionPrefName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewContentAlertBehaviour.NativeFieldInfoPtr_contentVersionPrefName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewContentAlertBehaviour.NativeFieldInfoPtr_contentVersionPrefName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0005E1B0 File Offset: 0x0005C3B0
		// (set) Token: 0x060013F4 RID: 5108 RVA: 0x0000B5DC File Offset: 0x000097DC
		public unsafe int contentVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewContentAlertBehaviour.NativeFieldInfoPtr_contentVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewContentAlertBehaviour.NativeFieldInfoPtr_contentVersion)) = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0005E1D8 File Offset: 0x0005C3D8
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x0000B5F7 File Offset: 0x000097F7
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewContentAlertBehaviour.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewContentAlertBehaviour.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0005E208 File Offset: 0x0005C408
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x0000B616 File Offset: 0x00009816
		public unsafe IWritableSettingDefinition<int> contentVersionPref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewContentAlertBehaviour.NativeFieldInfoPtr_contentVersionPref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWritableSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewContentAlertBehaviour.NativeFieldInfoPtr_contentVersionPref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeFieldInfoPtr_Enable;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeFieldInfoPtr_contentVersionPrefName;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeFieldInfoPtr_contentVersion;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeFieldInfoPtr_contentVersionPref;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnContentInteracted_Public_Void_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
