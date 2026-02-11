using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x0200003D RID: 61
	public class PromptWithVignette : MonoBehaviour
	{
		// Token: 0x0600023B RID: 571 RVA: 0x0000B24C File Offset: 0x0000944C
		// Note: this type is marked as 'beforefieldinit'.
		static PromptWithVignette()
		{
			Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "PromptWithVignette");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr);
			PromptWithVignette.NativeFieldInfoPtr_sceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr, "sceneName");
			PromptWithVignette.NativeFieldInfoPtr_unloadOnResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr, "unloadOnResolve");
			PromptWithVignette.NativeFieldInfoPtr_setAsActiveScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr, "setAsActiveScene");
			PromptWithVignette.NativeFieldInfoPtr_cameraAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr, "cameraAnimName");
			PromptWithVignette.NativeFieldInfoPtr__SceneLoaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr, "<SceneLoaded>k__BackingField");
			PromptWithVignette.NativeMethodInfoPtr_get_SceneName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr, 100663568);
			PromptWithVignette.NativeMethodInfoPtr_get_UnloadOnResolve_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr, 100663569);
			PromptWithVignette.NativeMethodInfoPtr_get_LoadAsActiveScene_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr, 100663570);
			PromptWithVignette.NativeMethodInfoPtr_get_CameraAnimName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr, 100663571);
			PromptWithVignette.NativeMethodInfoPtr_get_SceneLoaded_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr, 100663572);
			PromptWithVignette.NativeMethodInfoPtr_set_SceneLoaded_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr, 100663573);
			PromptWithVignette.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr, 100663574);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000B36C File Offset: 0x0000956C
		public unsafe virtual string SceneName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptWithVignette.NativeMethodInfoPtr_get_SceneName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000B3A4 File Offset: 0x000095A4
		public unsafe virtual bool UnloadOnResolve
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptWithVignette.NativeMethodInfoPtr_get_UnloadOnResolve_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0000B3E0 File Offset: 0x000095E0
		public unsafe virtual bool LoadAsActiveScene
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptWithVignette.NativeMethodInfoPtr_get_LoadAsActiveScene_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000B41C File Offset: 0x0000961C
		public unsafe virtual string CameraAnimName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptWithVignette.NativeMethodInfoPtr_get_CameraAnimName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0000B454 File Offset: 0x00009654
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0000B490 File Offset: 0x00009690
		public unsafe virtual bool SceneLoaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptWithVignette.NativeMethodInfoPtr_get_SceneLoaded_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptWithVignette.NativeMethodInfoPtr_set_SceneLoaded_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000B4D0 File Offset: 0x000096D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214763, XrefRangeEnd = 1214769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptWithVignette()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptWithVignette>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptWithVignette.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00003202 File Offset: 0x00001402
		public PromptWithVignette(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000B50C File Offset: 0x0000970C
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0000320B File Offset: 0x0000140B
		public unsafe string sceneName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptWithVignette.NativeFieldInfoPtr_sceneName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptWithVignette.NativeFieldInfoPtr_sceneName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000B534 File Offset: 0x00009734
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0000322A File Offset: 0x0000142A
		public unsafe bool unloadOnResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptWithVignette.NativeFieldInfoPtr_unloadOnResolve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptWithVignette.NativeFieldInfoPtr_unloadOnResolve)) = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0000B55C File Offset: 0x0000975C
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00003245 File Offset: 0x00001445
		public unsafe bool setAsActiveScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptWithVignette.NativeFieldInfoPtr_setAsActiveScene);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptWithVignette.NativeFieldInfoPtr_setAsActiveScene)) = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0000B584 File Offset: 0x00009784
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00003260 File Offset: 0x00001460
		public unsafe string cameraAnimName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptWithVignette.NativeFieldInfoPtr_cameraAnimName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptWithVignette.NativeFieldInfoPtr_cameraAnimName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000B5AC File Offset: 0x000097AC
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0000327F File Offset: 0x0000147F
		public unsafe bool _SceneLoaded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptWithVignette.NativeFieldInfoPtr__SceneLoaded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptWithVignette.NativeFieldInfoPtr__SceneLoaded_k__BackingField)) = value;
			}
		}

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_sceneName;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_unloadOnResolve;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_setAsActiveScene;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_cameraAnimName;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr__SceneLoaded_k__BackingField;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_get_UnloadOnResolve_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadAsActiveScene_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraAnimName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneLoaded_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_set_SceneLoaded_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
