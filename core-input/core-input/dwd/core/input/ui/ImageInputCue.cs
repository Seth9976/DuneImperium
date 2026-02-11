using System;
using dwd.core.input.compositeModule;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.input.ui
{
	// Token: 0x0200005C RID: 92
	public class ImageInputCue : VersionedView<CurrentInputModuleType>
	{
		// Token: 0x0600034D RID: 845 RVA: 0x000112D8 File Offset: 0x0000F4D8
		// Note: this type is marked as 'beforefieldinit'.
		static ImageInputCue()
		{
			Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.ui", "ImageInputCue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr);
			ImageInputCue.NativeFieldInfoPtr_cachedStringBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "cachedStringBindings");
			ImageInputCue.NativeFieldInfoPtr_inputId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "inputId");
			ImageInputCue.NativeFieldInfoPtr_setNativeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "setNativeSize");
			ImageInputCue.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "image");
			ImageInputCue.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "spriteRenderer");
			ImageInputCue.NativeFieldInfoPtr_gamepadSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "gamepadSprite");
			ImageInputCue.NativeFieldInfoPtr_keyboardSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "keyboardSprite");
			ImageInputCue.NativeFieldInfoPtr_mouseSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "mouseSprite");
			ImageInputCue.NativeFieldInfoPtr_keyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "keyboard");
			ImageInputCue.NativeFieldInfoPtr_mouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "mouse");
			ImageInputCue.NativeFieldInfoPtr_gamepad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "gamepad");
			ImageInputCue.NativeFieldInfoPtr_Logging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "Logging");
			ImageInputCue.NativeFieldInfoPtr_standardEventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, "standardEventSystem");
			ImageInputCue.NativeMethodInfoPtr_get_InputId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, 100663677);
			ImageInputCue.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, 100663678);
			ImageInputCue.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, 100663679);
			ImageInputCue.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, 100663680);
			ImageInputCue.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, 100663681);
			ImageInputCue.NativeMethodInfoPtr_FindBindingSprite_Private_Sprite_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, 100663682);
			ImageInputCue.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, 100663683);
			ImageInputCue.NativeMethodInfoPtr_setImageSprite_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, 100663684);
			ImageInputCue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr, 100663685);
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600034E RID: 846 RVA: 0x000114C0 File Offset: 0x0000F6C0
		public unsafe string InputId
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageInputCue.NativeMethodInfoPtr_get_InputId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000114F8 File Offset: 0x0000F6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121566, XrefRangeEnd = 1121587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageInputCue.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0001152C File Offset: 0x0000F72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121587, XrefRangeEnd = 1121632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageInputCue.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00011568 File Offset: 0x0000F768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121632, XrefRangeEnd = 1121636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageInputCue.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000115A4 File Offset: 0x0000F7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121636, XrefRangeEnd = 1121637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageInputCue.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000115D8 File Offset: 0x0000F7D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1121652, RefRangeEnd = 1121655, XrefRangeStart = 1121637, XrefRangeEnd = 1121652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite FindBindingSprite(Il2CppStringArray bindingStrings, string imagePrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bindingStrings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(imagePrefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageInputCue.NativeMethodInfoPtr_FindBindingSprite_Private_Sprite_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0001163C File Offset: 0x0000F83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121655, XrefRangeEnd = 1121667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageInputCue.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00011678 File Offset: 0x0000F878
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1121679, RefRangeEnd = 1121682, XrefRangeStart = 1121667, XrefRangeEnd = 1121679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setImageSprite(Sprite pSprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pSprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageInputCue.NativeMethodInfoPtr_setImageSprite_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000116BC File Offset: 0x0000F8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121682, XrefRangeEnd = 1121689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageInputCue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageInputCue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageInputCue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003E86 File Offset: 0x00002086
		public ImageInputCue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000358 RID: 856 RVA: 0x000116F8 File Offset: 0x0000F8F8
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00003E8F File Offset: 0x0000208F
		public unsafe static Dictionary<string, StringBindings> cachedStringBindings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImageInputCue.NativeFieldInfoPtr_cachedStringBindings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, StringBindings>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImageInputCue.NativeFieldInfoPtr_cachedStringBindings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00011720 File Offset: 0x0000F920
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00003EA1 File Offset: 0x000020A1
		public unsafe string inputId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_inputId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_inputId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00011748 File Offset: 0x0000F948
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00003EC0 File Offset: 0x000020C0
		public unsafe bool setNativeSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_setNativeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_setNativeSize)) = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00011770 File Offset: 0x0000F970
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00003EDB File Offset: 0x000020DB
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000360 RID: 864 RVA: 0x000117A0 File Offset: 0x0000F9A0
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00003EFA File Offset: 0x000020FA
		public unsafe SpriteRenderer spriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_spriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000362 RID: 866 RVA: 0x000117D0 File Offset: 0x0000F9D0
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00003F19 File Offset: 0x00002119
		public unsafe Sprite gamepadSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_gamepadSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_gamepadSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00011800 File Offset: 0x0000FA00
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00003F38 File Offset: 0x00002138
		public unsafe Sprite keyboardSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_keyboardSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_keyboardSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00011830 File Offset: 0x0000FA30
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00003F57 File Offset: 0x00002157
		public unsafe Sprite mouseSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_mouseSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_mouseSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00011860 File Offset: 0x0000FA60
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00003F76 File Offset: 0x00002176
		public unsafe bool keyboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_keyboard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_keyboard)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00011888 File Offset: 0x0000FA88
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00003F91 File Offset: 0x00002191
		public unsafe bool mouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_mouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_mouse)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000118B0 File Offset: 0x0000FAB0
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00003FAC File Offset: 0x000021AC
		public unsafe bool gamepad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_gamepad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_gamepad)) = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600036E RID: 878 RVA: 0x000118D8 File Offset: 0x0000FAD8
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00003FC7 File Offset: 0x000021C7
		public unsafe bool Logging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_Logging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_Logging)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00011900 File Offset: 0x0000FB00
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00003FE2 File Offset: 0x000021E2
		public unsafe InputDetector standardEventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_standardEventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageInputCue.NativeFieldInfoPtr_standardEventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_cachedStringBindings;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_inputId;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_setNativeSize;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr_gamepadSprite;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_keyboardSprite;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_mouseSprite;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_keyboard;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_mouse;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_gamepad;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr_Logging;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_standardEventSystem;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_get_InputId_Public_get_String_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_FindBindingSprite_Private_Sprite_Il2CppStringArray_String_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_setImageSprite_Private_Void_Sprite_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
